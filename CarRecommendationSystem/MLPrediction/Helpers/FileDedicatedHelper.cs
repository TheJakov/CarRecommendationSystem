using MLPrediction.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MLPrediction.Helpers
{
    public static class FileDedicatedHelper
    {
        private static string argsPath = @"../../../../../Args.txt";
        private static string resultsPath = @"../../../../../Results.txt";

        private static string[] ReadUserProfileArgs()
        {
            string data = File.ReadAllText(argsPath);
            string[] userArgs = data.Split(',');
            return userArgs;
        }
        
        public static void GetUserArgumentsIntoEvaluationModel()
        {
            string[] userArgs = ReadUserProfileArgs();

            // redudant EvaluationModel.ID = int.Parse(userArgs[0].Trim());

            EvaluationModel.Year = int.Parse(userArgs[1].Trim());
            EvaluationModel.Price = int.Parse(userArgs[2].Trim());

            EvaluationModel.OverallScoreCoef = int.Parse(userArgs[3].Trim());
            EvaluationModel.DrivingScoreCoef = int.Parse(userArgs[4].Trim());
            EvaluationModel.ComfortScoreCoef = int.Parse(userArgs[5].Trim());
            EvaluationModel.InteriorScoreCoef = int.Parse(userArgs[6].Trim());
            EvaluationModel.TechnologyScoreCoef = int.Parse(userArgs[7].Trim());
            EvaluationModel.StorageScoreCoef = int.Parse(userArgs[8].Trim());
            EvaluationModel.EconomicalScoreCoef = int.Parse(userArgs[9].Trim());
            EvaluationModel.GoodValueScoreCoef = int.Parse(userArgs[10].Trim());

            EvaluationModel.FuelEfficiency = userArgs[11].Trim();
            EvaluationModel.Seats = int.Parse(userArgs[12].Trim());
            EvaluationModel.Transmission = userArgs[13].Trim();
            EvaluationModel.Horsepower = int.Parse(userArgs[14].Trim());
            EvaluationModel.FuelType = userArgs[15].Trim();
        }

        public static void WritePredictionsToFile(string predictionsString)
        {
            if (File.Exists(resultsPath))
                File.Delete(resultsPath);

            using (StreamWriter sw = File.CreateText(resultsPath))
            {
                sw.Write(predictionsString);
            }
        }

    }
}
