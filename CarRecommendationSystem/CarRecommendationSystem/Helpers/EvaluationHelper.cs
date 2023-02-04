using CarRecommendationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRecommendationSystem.Helpers
{
    static class EvaluationHelper
    {
        public static int VeryImportantCoef = 3;
        public static int ImportantCoef = 2;
        public static int NeutralCoef = 1;

        private static int ScoreBonus = 25;
        private static float KunasToUsdFixedConversionRatio = 6.96f;

        public static string Any = "any";
        public static string AutomatedManual = "automated manual";
        public static string Average = "average";
        public static string Biofuels = "biofuels";
        public static string ContinuousAutomatic = "continuous automatic";
        public static string Diesel = "diesel";
        public static string Electric = "electric";
        public static string Good = "good";
        public static string Hybrid = "hybrid";
        public static string Lpg = "lpg";
        public static string Manual = "manual";
        public static string Petrol = "petrol";
        public static string Poor = "poor";
        public static string ShiftableAutomatic = "shiftable automatic";

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
            double transform = value / KunasToUsdFixedConversionRatio;
            double dolars = Math.Round(transform);
            int intDolars = int.Parse(dolars.ToString());
            return intDolars;
        }

        public static int USDToKunas(int value)
        {
            double transform = value * KunasToUsdFixedConversionRatio;
            double kunas = Math.Round(transform);
            int intKunas = int.Parse(kunas.ToString());
            return intKunas;
        }

        public static void EvaluateCarModels(IEnumerable<CSVCarModel> carList)
        {
            if (carList == null)
                return;

            carList.AsParallel().ForAll(car => {
                car.Score = 0;
                EvaluateCoefficients(car);
                EvaluateSeats(car);
                EvaluateFuelEfficency(car);
                EvaluateTransmission(car);
                EvaluateHorsepower(car);
                EvaluateFuelType(car);
                EvaluateBudget(car);
                EvalutateReleaseYear(car);
            });
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
                car.Score += ScoreBonus;
            else
            {
                if (car.Seats == (int)EvaluationModel.Seats)
                    car.Score += ScoreBonus;
            }
        }

        private static void EvaluateFuelEfficency(CSVCarModel car) {
            if (EvaluationModel.FuelEfficiency == Poor)
                car.Score += ScoreBonus;
            else
            {
                if (EvaluationModel.FuelEfficiency == Good) {
                    if (car.Litres100km <= 8)
                        car.Score += ScoreBonus;
                }
                else if(EvaluationModel.FuelEfficiency == Average)
                {
                    if (car.Litres100km <= 11)
                        car.Score += ScoreBonus;
                }
            }
        }

        private static void EvaluateTransmission(CSVCarModel car)
        {
            if (EvaluationModel.Transmission == Any)
                car.Score += ScoreBonus;
            else if (EvaluationModel.Transmission == car.Transmission)
                    car.Score += ScoreBonus;
        }

        private static void EvaluateHorsepower(CSVCarModel car)
        {
            // If car has more horsepower, it gets some score points
            if ((int)EvaluationModel.Horsepower <= car.Horsepower)
                car.Score += ScoreBonus;

            // If car horsepower is in radius of 50 HP, scores additional score
            if ( Math.Abs((int)EvaluationModel.Horsepower - car.Horsepower) <= 50)
                car.Score += ScoreBonus;
        }

        private static void EvaluateFuelType(CSVCarModel car)
        {
            if (EvaluationModel.FuelType == Any)
                car.Score += ScoreBonus;
            else
            {
                if (EvaluationModel.FuelType == car.FuelType)
                    car.Score += ScoreBonus;
            }
        }

        private static void EvaluateBudget(CSVCarModel car)
        {
            if ((int)EvaluationModel.Price >= car.Price)
                car.Score += (ScoreBonus * 2);
        }

        private static void EvalutateReleaseYear(CSVCarModel car)
        {
            if (EvaluationModel.Year == -1)
                car.Score += ScoreBonus;
            else
            {
                if (EvaluationModel.Year == car.Year)
                    car.Score += ScoreBonus;
            }
        }
    }
}
