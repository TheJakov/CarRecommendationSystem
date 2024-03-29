// This file was auto-generated by ML.NET Model Builder. 

using System;
using System.IO;
using System.Linq;
using Microsoft.ML;
using CarRecommendationSystemML.Model;

namespace CarRecommendationSystemML.ConsoleApp
{
    class Program
    {
        //Dataset to use for predictions 
        private const string DATA_FILEPATH = @"..\..\..\..\..\dataset.csv";

        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = CreateSingleDataSample(DATA_FILEPATH);

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Name with predicted Name from sample data...\n\n");
            Console.WriteLine($"car_id: {sampleData.Car_id}");
            Console.WriteLine($"year: {sampleData.Year}");
            Console.WriteLine($"price: {sampleData.Price}");
            Console.WriteLine($"overall_score: {sampleData.Overall_score}");
            Console.WriteLine($"driving_score: {sampleData.Driving_score}");
            Console.WriteLine($"comfort_score: {sampleData.Comfort_score}");
            Console.WriteLine($"interior_score: {sampleData.Interior_score}");
            Console.WriteLine($"tech_score: {sampleData.Tech_score}");
            Console.WriteLine($"storage_score: {sampleData.Storage_score}");
            Console.WriteLine($"economical_score: {sampleData.Economical_score}");
            Console.WriteLine($"good_value_score: {sampleData.Good_value_score}");
            Console.WriteLine($"litres_on_100km: {sampleData.Litres_on_100km}");
            Console.WriteLine($"seats: {sampleData.Seats}");
            Console.WriteLine($"transmission: {sampleData.Transmission}");
            Console.WriteLine($"horsepower: {sampleData.Horsepower}");
            Console.WriteLine($"fuel: {sampleData.Fuel}");
            Console.WriteLine($"\n\nActual Name: {sampleData.Name} \nPredicted Name value: {predictionResult.Prediction} \nPrediction accuracy: {predictionResult.Score.Max() * 100}%\nTotal number of records: {predictionResult.Score.Count()} \nPredicted Name scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }

        #region CreateSingleDataSample
        // Method to load single row of dataset to try a single prediction
        private static ModelInput CreateSingleDataSample(string dataFilePath)
        {
            // Create MLContext
            MLContext mlContext = new MLContext();

            // Load dataset
            IDataView dataView = mlContext.Data.LoadFromTextFile<ModelInput>(
                                            path: dataFilePath,
                                            hasHeader: true,
                                            separatorChar: ',',
                                            allowQuoting: true,
                                            allowSparse: false);

            // Use first line of dataset as model input
            // You can replace this with new test data (hardcoded or from end-user application)
            ModelInput sampleForPrediction = mlContext.Data.CreateEnumerable<ModelInput>(dataView, false).FirstOrDefault();

            //Under this goes testing override
            sampleForPrediction.Name = "This are custom made user preferences for the car with budget";
            sampleForPrediction.Price = 28500f;
            sampleForPrediction.Overall_score = 75;
            sampleForPrediction.Driving_score = 75;
            sampleForPrediction.Comfort_score = 80;
            sampleForPrediction.Interior_score = 75;
            sampleForPrediction.Tech_score = 70;
            sampleForPrediction.Storage_score = 85;
            sampleForPrediction.Economical_score = 80;
            sampleForPrediction.Good_value_score = 75;
            sampleForPrediction.Litres_on_100km = 10;
            sampleForPrediction.Horsepower = 250;

            return sampleForPrediction;
        }
        #endregion
    }
}
