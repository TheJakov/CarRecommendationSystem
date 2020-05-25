using CarRecommendationSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRecommendationSystem.Helpers
{
    static class EvaluationHelper
    {
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

            EvaluationModel.FuelConsumption = null;
            EvaluationModel.Seats = null;
            EvaluationModel.Transmission = null;
            EvaluationModel.Horsepower = null;
            EvaluationModel.FuelType = null;
        }
    }
}
