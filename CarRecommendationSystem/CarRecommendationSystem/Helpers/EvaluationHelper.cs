using CarRecommendationSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CarRecommendationSystem.Helpers
{
    static class EvaluationHelper
    {
        public static int VeryImportantCoef = 3;
        public static int ImportantCoef = 2;
        public static int NeutralCoef = 1;
        public static void ResetModel()
        {
            EvaluationModel.Year = null;
            EvaluationModel.Price = null;

            EvaluationModel.OverallScoreCoef = 1;
            EvaluationModel.DrivingScoreCoef = null;
            EvaluationModel.ComfortScoreCoef = null;
            EvaluationModel.InteriorScoreCoef = null;
            EvaluationModel.TechnologyScoreCoef = null;
            EvaluationModel.StorageScoreCoef = null;
            EvaluationModel.EconomicalScoreCoef = null;
            EvaluationModel.GoodValueScoreCoef = null;

            EvaluationModel.FuelEfficiency = null;
            EvaluationModel.Seats = null;
            EvaluationModel.Transmission = null;
            EvaluationModel.Horsepower = null;
            EvaluationModel.FuelType = null;
        }

        public static int KunasToUSD(int value)
        {
            double transform = value / 6.96f;
            double dolars = Math.Round(transform);
            int intDolars = int.Parse(dolars.ToString());
            return intDolars;
        }

        public static int USDToKunas(int value)
        {
            double transform = value * 6.96f;
            double kunas = Math.Round(transform);
            int intKunas = int.Parse(kunas.ToString());
            return intKunas;
        }

        public static void EvaluateList(List<CSVCarModel> carList)
        {
            foreach (var car in carList)
            {
                car.Score = 0;
                EvaluateCoefficients(car);
                EvaluateSeats(car);
                EvaluateFuelEfficency(car);
                EvaluateTransmission(car);
                EvaluateHorsepower(car);
                EvaluateFuelType(car);
                EvaluateBudget(car);
                EvalutateReleaseYear(car);
            }
        }

        private static void EvaluateCoefficients(CSVCarModel car)
        {
            int drivingEval = car.DrivingScore * (int)EvaluationModel.DrivingScoreCoef;
            int comfortEval = car.ComfortScore * (int)EvaluationModel.ComfortScoreCoef;
            int interiorEval = car.InteriorScore * (int)EvaluationModel.InteriorScoreCoef;
            int technologyEval = car.TechnologyScore * (int)EvaluationModel.TechnologyScoreCoef;
            int storageEval = car.StorageScore * (int)EvaluationModel.StorageScoreCoef;
            int economyEval = car.EconomicalScore * (int)EvaluationModel.EconomicalScoreCoef;
            int goodValueEval = car.GoodValueScore * (int)EvaluationModel.GoodValueScoreCoef;
            int overallEval = car.OverallScore * EvaluationModel.OverallScoreCoef;


            car.Score += drivingEval + comfortEval + interiorEval + technologyEval + storageEval
                + economyEval + goodValueEval + overallEval;
        }

        private static void EvaluateSeats(CSVCarModel car)
        {
            if (EvaluationModel.Seats == -1)
                car.Score += 25;
            else
            {
                if (car.Seats == (int)EvaluationModel.Seats)
                    car.Score += 25;
            }
        }

        private static void EvaluateFuelEfficency(CSVCarModel car) {
            if (EvaluationModel.FuelEfficiency == "poor")
                car.Score += 25;
            else
            {
                if (EvaluationModel.FuelEfficiency == "good") {
                    if (car.Litres100km <= 8)
                        car.Score += 25;
                }
                else if(EvaluationModel.FuelEfficiency == "average")
                {
                    if (car.Litres100km <= 11)
                        car.Score += 25;
                }
            }
        }

        private static void EvaluateTransmission(CSVCarModel car)
        {
            if (EvaluationModel.Transmission == "any")
                car.Score += 25;
            else
            {
                if (EvaluationModel.Transmission == car.Transmission)
                    car.Score += 25;
            }
        }

        private static void EvaluateHorsepower(CSVCarModel car)
        {
            // If car has more horsepower, it gets some score points
            if ((int)EvaluationModel.Horsepower <= car.Horsepower)
                car.Score += 25;
            // If car horsepower is in radius of 50 HP, scores additional score
            if ( Math.Abs((int)EvaluationModel.Horsepower - car.Horsepower) <= 50)
                car.Score += 25;
        }

        private static void EvaluateFuelType(CSVCarModel car)
        {
            if (EvaluationModel.FuelType == "any")
                car.Score += 25;
            else
            {
                if (EvaluationModel.FuelType == car.FuelType)
                    car.Score += 25;
            }
        }

        private static void EvaluateBudget(CSVCarModel car)
        {
            if ((int)EvaluationModel.Price >= car.Price)
                car.Score += 50;
        }

        private static void EvalutateReleaseYear(CSVCarModel car)
        {
            if (EvaluationModel.Year == -1)
                car.Score += 25;
            else
            {
                if (EvaluationModel.Year == car.Year)
                    car.Score += 25;
            }
        }
    }
}
