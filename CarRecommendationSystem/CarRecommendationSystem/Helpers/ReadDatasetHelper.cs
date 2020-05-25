﻿using CarRecommendationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRecommendationSystem.Helpers
{
    public static class ReadDatasetHelper
    {
        private static string filePath = @"../../../../dataset.csv";

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

            //string[] headerAttributes = dataRows[0].Split(splitter);

            for (int i = 0; i < dataRows.Length; i++)
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
    }
}