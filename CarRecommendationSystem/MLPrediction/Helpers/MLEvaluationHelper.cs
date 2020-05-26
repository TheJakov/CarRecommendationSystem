using CarRecommendationSystemML.Model;
using MLPrediction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MLPrediction.Helpers
{
    static class MLEvaluationHelper
    {
        private static int minCarPrice = 22100;
        public static List<ModelInput> CreateMLModelsFromEvaluationModel()
        {
            ModelInput modelInput = new ModelInput();

            // ID - 1 / 16
            modelInput.Car_id = EvaluationModel.ID;

            // Year 2 / 16
            modelInput.Year = AdjustYear(EvaluationModel.Year);

            //coefficients - 10 / 16
            modelInput.Driving_score = AdjustCoefficient(EvaluationModel.DrivingScoreCoef);
            modelInput.Comfort_score = AdjustCoefficient(EvaluationModel.ComfortScoreCoef);
            modelInput.Interior_score = AdjustCoefficient(EvaluationModel.InteriorScoreCoef);
            modelInput.Tech_score = AdjustCoefficient(EvaluationModel.TechnologyScoreCoef);
            modelInput.Storage_score = AdjustCoefficient(EvaluationModel.StorageScoreCoef);
            modelInput.Economical_score = AdjustCoefficient(EvaluationModel.EconomicalScoreCoef);
            modelInput.Good_value_score = AdjustCoefficient(EvaluationModel.GoodValueScoreCoef);
            modelInput.Overall_score = AdjustOverallScore(modelInput);

            // horsepower 11 / 16
            modelInput.Horsepower = (int)EvaluationModel.Horsepower;

            // seats 12 / 16
            modelInput.Seats = AdjustSeats(EvaluationModel.Seats);

            // fuel type 13 / 16
            modelInput.Fuel = AdjustFuelType(EvaluationModel.FuelType);

            //transmission 14 / 16
            modelInput.Transmission = AdjustTransmission(EvaluationModel.Transmission);

            // fuel efficiency 15 / 16
            modelInput.Litres_on_100km = AdjustFuelEfficiency(EvaluationModel.FuelEfficiency);

            // price 16 / 16
            List<int> consideredPrices = GetAdjustedPrices((int)EvaluationModel.Price);

            //getting all models
            List<ModelInput> allConsideredModels = new List<ModelInput>();

            foreach (var price in consideredPrices)
            {
                ModelInput modelClone = CloneModel(modelInput);
                modelClone.Price = price;
                allConsideredModels.Add(modelClone);
            }

            return allConsideredModels;
        }

        private static int AdjustCoefficient(int? coef)
        {
            int adjustedValue = 75;

            if (coef == 1)
                adjustedValue = 70;
            else if (coef == 2)
                adjustedValue = 80;
            else if (coef == 3)
                adjustedValue = 90;

            return adjustedValue;
        }

        private static int AdjustOverallScore(ModelInput input)
        {
            float sum = input.Driving_score + input.Comfort_score + input.Interior_score +
                input.Tech_score + input.Storage_score + input.Economical_score + input.Good_value_score;

            double overall = Math.Round(sum / 7f);
            int intOverall = int.Parse(overall.ToString());
            return intOverall;
        }

        private static int AdjustYear(int? year)
        {
            if (year != -1)
                return (int)year;
            else
                return 2020;
        }

        private static int AdjustSeats(int? seats)
        {
            if (seats != -1)
                return (int)seats;
            else
                return 5;
        }

        private static string AdjustFuelType(string type)
        {
            if (type != "any")
                return type;
            else
                return "petrol";
        }

        private static string AdjustTransmission(string type)
        {
            if (type != "any")
                return type;
            else
                return "shiftable automatic";
        }

        private static int AdjustFuelEfficiency(string type) 
        {
            if (type == "poor")
                return 13;
            else if (type == "average")
                return 10;
            else
                return 7;
        }

        private static List<int> GetAdjustedPrices(int budget)
        {
            List<int> outputPrices = new List<int>();

            do
            {
                outputPrices.Add(budget);
                budget -= 2000;
            } while (budget >= minCarPrice);

            return outputPrices;
        }

        private static ModelInput CloneModel(ModelInput model)
        {
            ModelInput cloned = new ModelInput();

            cloned.Car_id = model.Car_id;
            cloned.Year = model.Year;

            cloned.Overall_score = model.Overall_score;
            cloned.Driving_score = model.Driving_score;
            cloned.Comfort_score = model.Comfort_score;
            cloned.Interior_score = model.Interior_score;
            cloned.Tech_score = model.Tech_score;
            cloned.Storage_score = model.Storage_score;
            cloned.Economical_score = model.Economical_score;
            cloned.Good_value_score = model.Good_value_score;

            cloned.Horsepower = model.Horsepower;
            cloned.Seats = model.Seats;

            cloned.Fuel = model.Fuel;
            cloned.Litres_on_100km = model.Litres_on_100km;

            cloned.Transmission = model.Transmission;

            return cloned;
        }

        public static string GeneratePredictions(List<ModelInput> consideredModels)
        {
            List<ModelOutput> modelOutputs = new List<ModelOutput>();

            foreach (var model in consideredModels)
            {
                SignalThreadAlive();
                ModelOutput newOutput;
                try
                {
                    newOutput = ConsumeModel.Predict(model);
                    Array.Sort(newOutput.Score);
                    modelOutputs.Add(newOutput);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return CreatePredictionText(modelOutputs);
        }

        private static string CreatePredictionText(List<ModelOutput> outputsList)
        {
            outputsList = outputsList.OrderByDescending(x => x.Score.Last()).ToList();
            string text = "";
            foreach (var output in outputsList)
            {
                decimal confidence = (decimal)output.Score[output.Score.Length - 1] * 100;
                confidence = (decimal)Math.Round(confidence, 2);
                text += output.Prediction + ";" + confidence + "\n";
            }
            return text;
        }

        private static string SignalText = "Processing ML prediction ";

        private static void SignalThreadAlive()
        {
            Console.Clear();
            SignalText += ".";
            Console.WriteLine(SignalText);
        }
    }
}
