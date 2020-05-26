using CarRecommendationSystemML.Model;
using MLPrediction.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace MLPrediction
{
    class Program
    {
        private static List<ModelInput> modelCombinations;
        static void Main(string[] args)
        {
            Console.WriteLine("Processing ML prediction");
            AdjustWindowState();
            FileDedicatedHelper.GetUserArgumentsIntoEvaluationModel();
            modelCombinations = MLEvaluationHelper.CreateMLModelsFromEvaluationModel();
            string results = MLEvaluationHelper.GeneratePredictions(modelCombinations);
            FileDedicatedHelper.WritePredictionsToFile(results);

            Environment.Exit(0);
        }

        private static void AdjustWindowState()
        {
            Console.WindowHeight = 15;
            Console.WindowWidth = 55;
        }
    }
}
