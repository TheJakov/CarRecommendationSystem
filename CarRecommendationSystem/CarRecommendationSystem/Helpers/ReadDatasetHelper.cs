using CarRecommendationSystem.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CarRecommendationSystem.Helpers
{
    public static class ReadDatasetHelper
    {
        private static string filePath = @"../../../../dataset.csv";
        private static string resultsPath = @"../../../../Results.txt";

        public static string ReadCSVData()
        {
            string csvCarAllText = "";

            try
            {
                csvCarAllText = System.IO.File.ReadAllText(filePath);
            }
            catch
            {
                MessageBox.Show("There was an error while trying to read CSV dataset file.", "Ooops",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return csvCarAllText;
        }

        public static string[] FetchDataRowsFromText(string inputText, char splitter)
        {
            string[] outputList = inputText.Split(splitter);
            for (int i = 0; i < outputList.Length; i++)
            {
                outputList[i].Trim();
            }
            return outputList;
        }

        public static List<CSVCarModel> FetchCarList(string[] dataRows, char splitter)
        {
            List<CSVCarModel> outputListCarModels = new List<CSVCarModel>();

            for (int i = 1; i < dataRows.Length-1; i++)
            {
                string[] oneRowCarObject = dataRows[i].Split(splitter);

                // It is assumed that all data available in dataset is formated properly
                // so there are no any datatype verifications in following step
                CSVCarModel tempCarModel = new CSVCarModel();

                tempCarModel.ID = int.Parse(oneRowCarObject[0].Trim());
                tempCarModel.Name = oneRowCarObject[1].ToString().Trim();
                tempCarModel.Year = int.Parse(oneRowCarObject[2].Trim());
                tempCarModel.Price = int.Parse(oneRowCarObject[3].Trim());
                tempCarModel.OverallScore = int.Parse(oneRowCarObject[4].Trim());
                tempCarModel.DrivingScore = int.Parse(oneRowCarObject[5].Trim());
                tempCarModel.ComfortScore = int.Parse(oneRowCarObject[6].Trim());
                tempCarModel.InteriorScore = int.Parse(oneRowCarObject[7].Trim());
                tempCarModel.TechnologyScore = int.Parse(oneRowCarObject[8].Trim());
                tempCarModel.StorageScore = int.Parse(oneRowCarObject[9].Trim());
                tempCarModel.EconomicalScore = int.Parse(oneRowCarObject[10].Trim());
                tempCarModel.GoodValueScore = int.Parse(oneRowCarObject[11].Trim());
                tempCarModel.Litres100km = int.Parse(oneRowCarObject[12].Trim());
                tempCarModel.Seats = int.Parse(oneRowCarObject[13].Trim());
                tempCarModel.Transmission = oneRowCarObject[14].ToString().Trim();
                tempCarModel.Horsepower = int.Parse(oneRowCarObject[15].Trim());
                tempCarModel.FuelType = oneRowCarObject[16].ToString().Trim();

                outputListCarModels.Add(tempCarModel);
            }
            return outputListCarModels;
        }

        public static List<PredictionResultModel> FetchMLResults()
        {
            List<PredictionResultModel> resultList = new List<PredictionResultModel>();
            if (File.Exists(resultsPath))
            {
                using(StreamReader stream = File.OpenText(resultsPath))
                {
                    string row = "";
                    while ((row = stream.ReadLine()) != null)
                    {
                        string[] dataPair = row.Split(';');
                        if (dataPair.Length < 2)
                            break;
                        else
                        {
                            PredictionResultModel resultModel = new PredictionResultModel();
                            resultModel.Name = dataPair[0].Trim();
                            resultModel.Confidence = decimal.Parse(dataPair[1].Trim());
                            resultList.Add(resultModel);
                        }
                    }
                }
            }
            return resultList.OrderByDescending(x => x.Confidence).ToList();
        }

        public static List<PredictionResultModel> RemovePossibleLowerConfidenceDuplicates(List<PredictionResultModel> originalList)
        {
            List<PredictionResultModel> outList = new List<PredictionResultModel>();

            if (!originalList.Any())
                return outList;

            outList.Add(originalList.First());

            for (int i = 1; i < originalList.Count; i++)
            {
                bool duplicate = false;
                for (int j = 0; j < outList.Count; j++)
                {
                    if (originalList[i].Name == outList[j].Name)
                        duplicate = true;
                }
                if (!duplicate)
                    outList.Add(originalList[i]);
            }

            return outList;
        }
    }
}
