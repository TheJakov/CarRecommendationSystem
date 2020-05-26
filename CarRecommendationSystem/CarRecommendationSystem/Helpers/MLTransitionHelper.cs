using CarRecommendationSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRecommendationSystem.Helpers
{
    static class MLTransitionHelper
    {
        private static string delimiter = ",";
        private static string argsPath = @"../../../../Args.txt";
        private static string processPath = @"../../../MLPrediction/bin/Debug/netcoreapp3.1/MLPrediction.exe";
        private static string processWorkingDirectory = @"../../../MLPrediction/bin/Debug/netcoreapp3.1/";
        private static string CreateUserProfileParameters()
        {
            string userParams = "";

            userParams += EvaluationModel.ID + delimiter;
            userParams += EvaluationModel.Year + delimiter;
            userParams += EvaluationModel.Price + delimiter;

            userParams += EvaluationModel.OverallScoreCoef + delimiter;
            userParams += EvaluationModel.DrivingScoreCoef + delimiter;
            userParams += EvaluationModel.ComfortScoreCoef + delimiter;
            userParams += EvaluationModel.InteriorScoreCoef + delimiter;
            userParams += EvaluationModel.TechnologyScoreCoef + delimiter;
            userParams += EvaluationModel.StorageScoreCoef + delimiter;
            userParams += EvaluationModel.EconomicalScoreCoef + delimiter;
            userParams += EvaluationModel.GoodValueScoreCoef + delimiter;

            userParams += EvaluationModel.FuelEfficiency + delimiter;
            userParams += EvaluationModel.Seats + delimiter;
            userParams += EvaluationModel.Transmission + delimiter;
            userParams += EvaluationModel.Horsepower + delimiter;
            userParams += EvaluationModel.FuelType;

            return userParams.Trim();
        }
        
        public static void WriteUserProfileParamsToFile()
        {
            string userParameters = CreateUserProfileParameters();

            if (File.Exists(argsPath))
                File.Delete(argsPath);

            using (StreamWriter sw = File.CreateText(argsPath))
            {
                sw.Write(userParameters);
            }
        }

        public static void StartMLPredictionProcess()
        {
            ProcessStartInfo psi = new ProcessStartInfo(processPath);
            psi.UseShellExecute = false;
            psi.WorkingDirectory = processWorkingDirectory;

            try
            {
                using (Process mlExeProcess = Process.Start(psi))
                {
                    mlExeProcess.WaitForExit();
                }
            }
            catch {
                MessageBox.Show("Something happend.");
            }
        }
    }
}
