using CarRecommendationSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
