using CarRecommendationSystem.Helpers;
using CarRecommendationSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CarRecommendationSystem.Forms
{
    public partial class Results : Form
    {
        private readonly string Confidence = "Confidence";
        private readonly string ImageDir = @"../../../../dataset_media/";
        private readonly string Kn = "kn";
        private readonly string NthPredictionHadTooLowConfidenceTemplate = "{0} Prediction had too low confidence.";
        private readonly string PngExtension = ".png";
        private readonly string Score = "Score";
        private readonly string ResultTextTemplate = "{0} - {1}: {2}";

        public Results()
        {
            InitializeComponent();

            MLTransitionHelper.WriteUserProfileParamsToFile();
            MLTransitionHelper.StartMLPredictionProcess();
            ApplyMLResults();
            CustomEvalutationAlgorithm();
        }

        private void btnAgain_Click(object sender, EventArgs e) => NavigationHelper.GoToStartForm(this);

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void CustomEvalutationAlgorithm()
        {
            string textualData = ReadDatasetHelper.ReadCSVData();
            string[] allRows = ReadDatasetHelper.FetchDataRowsFromText(textualData, '\n');
            IEnumerable<CSVCarModel> AllCarsList = ReadDatasetHelper.FetchCarList(allRows, ',');
            EvaluationHelper.EvaluateCarModels(AllCarsList);
            List<CSVCarModel> orderedCarList = AllCarsList.OrderByDescending(x => x.Score).ToList();
            ApplyResults(orderedCarList);
        }

        private void ApplyResults(List<CSVCarModel> orderedList)
        {
            // 1st
            Alg1stCarName.Text = string.Format(CultureInfo.InvariantCulture, ResultTextTemplate, orderedList[0].Name, Score, orderedList[0].Score);
            Alg1stPrice.Text = EvaluationHelper.USDToKunas(orderedList[0].Price) + $" {Kn}";
            Alg1stHorsepower.Text = orderedList[0].Horsepower.ToString();
            Alg1stLitres.Text = orderedList[0].Litres100km.ToString();
            Alg1stFuelType.Text = orderedList[0].FuelType;
            Alg1stTransmission.Text = orderedList[0].Transmission;
            pictureBox1stAlg.ImageLocation = ImageDir + orderedList[0].ID + PngExtension;

            //2nd
            Alg2ndCarName.Text = string.Format(CultureInfo.InvariantCulture, ResultTextTemplate, orderedList[1].Name, Score, orderedList[1].Score);
            Alg2ndPrice.Text = EvaluationHelper.USDToKunas(orderedList[1].Price) + $" {Kn}";
            Alg2ndHorsepower.Text = orderedList[1].Horsepower.ToString();
            Alg2ndLitres.Text = orderedList[1].Litres100km.ToString();
            Alg2ndFuelType.Text = orderedList[1].FuelType;
            Alg2ndTransmission.Text = orderedList[1].Transmission;
            pictureBox2ndAlg.ImageLocation = ImageDir + orderedList[1].ID + PngExtension;

            //3rd
            Alg3rdCarName.Text = string.Format(CultureInfo.InvariantCulture, ResultTextTemplate, orderedList[2].Name, Score, orderedList[2].Score);
            Alg3rdPrice.Text = EvaluationHelper.USDToKunas(orderedList[2].Price) + $" {Kn}";
            Alg3rdHorsepower.Text = orderedList[2].Horsepower.ToString();
            Alg3rdLitres.Text = orderedList[2].Litres100km.ToString();
            Alg3rdFuelType.Text = orderedList[2].FuelType;
            Alg3rdTransmission.Text = orderedList[2].Transmission;
            pictureBox3rdAlg.ImageLocation = ImageDir + orderedList[2].ID + PngExtension;
        }

        private void ApplyMLResults()
        {
            List<PredictionResultModel> resultList = ReadDatasetHelper.FetchMLResults();
            resultList = ReadDatasetHelper.RemovePossibleLowerConfidenceDuplicates(resultList);

            ApplyML1stResult(resultList);
            ApplyML2ndResult(resultList);
            ApplyML3rdResult(resultList);
        }

        private void ApplyML1stResult(List<PredictionResultModel> resultList)
        {
            if(resultList.Count >= 1)
            {
                ML1stCarName.Text = string.Format(CultureInfo.CurrentUICulture, ResultTextTemplate, resultList[0].Name, Confidence, resultList[0].Confidence) + "%";
                CSVCarModel exactCarModel = FindCarObjectPerName(resultList[0].Name);
                ML1stCarPrice.Text = EvaluationHelper.USDToKunas(exactCarModel.Price) + $" {Kn}";
                ML1stHorsepower.Text = exactCarModel.Horsepower.ToString();
                ML1stLitres.Text = exactCarModel.Litres100km.ToString();
                ML1stFuelType.Text = exactCarModel.FuelType;
                ML1stTransmission.Text = exactCarModel.Transmission;
                pictureBox1stML.ImageLocation = ImageDir + exactCarModel.ID + PngExtension;
            }
            else 
            {
                // Should never be executed
                ML1stCarName.Text = "Something went wrong with generating ML prediction.";
                ML1stNumber.Visible = false;
                ML1stCarPrice.Visible = false;
                ML1stHorsepower.Visible = false;
                ML1stLitres.Visible = false;
                ML1stFuelType.Visible = false;
                ML1stTransmission.Visible = false;
                pictureBox1stML.Visible = false;
            }
        }

        private void ApplyML2ndResult(List<PredictionResultModel> resultList)
        {
            if(resultList.Count >= 2)
            {
                ML2ndCarName.Text = string.Format(CultureInfo.CurrentUICulture, ResultTextTemplate, resultList[1].Name, Confidence, resultList[1].Confidence) + "%";
                CSVCarModel exactCarModel = FindCarObjectPerName(resultList[1].Name);
                ML2ndPrice.Text = EvaluationHelper.USDToKunas(exactCarModel.Price) + $" {Kn}";
                ML2ndHorsepower.Text = exactCarModel.Horsepower.ToString();
                ML2ndLitres.Text = exactCarModel.Litres100km.ToString();
                ML2ndFuelType.Text = exactCarModel.FuelType;
                ML2ndTransmission.Text = exactCarModel.Transmission;
                pictureBox2ndML.ImageLocation = ImageDir + exactCarModel.ID + PngExtension;
            }
            else
            {
                ML2ndCarName.Text = string.Format(CultureInfo.InvariantCulture, NthPredictionHadTooLowConfidenceTemplate, "2nd");
                ML2ndNumber.Visible = false;
                ML2ndPrice.Visible = false;
                ML2ndHorsepower.Visible = false;
                ML2ndLitres.Visible = false;
                ML2ndFuelType.Visible = false;
                ML2ndTransmission.Visible = false;
                pictureBox2ndML.Visible = false;
            }
        }

        private void ApplyML3rdResult(List<PredictionResultModel> resultList)
        {
            if(resultList.Count >= 3)
            {
                ML3rdCarName.Text = string.Format(CultureInfo.CurrentUICulture, ResultTextTemplate, resultList[2].Name, Confidence, resultList[2].Confidence) + "%";
                CSVCarModel exactCarModel = FindCarObjectPerName(resultList[2].Name);
                ML3rdPrice.Text = EvaluationHelper.USDToKunas(exactCarModel.Price) + $" {Kn}";
                ML3rdHorsepower.Text = exactCarModel.Horsepower.ToString();
                ML3rdLitres.Text = exactCarModel.Litres100km.ToString();
                ML3rdFuelType.Text = exactCarModel.FuelType;
                ML3rdTransmission.Text = exactCarModel.Transmission;
                pictureBox3rdML.ImageLocation = ImageDir + exactCarModel.ID + PngExtension;
            }
            else
            {
                ML3rdCarName.Text = string.Format(CultureInfo.InvariantCulture, NthPredictionHadTooLowConfidenceTemplate, "3rd");
                ML3rdNumber.Visible = false;
                ML3rdPrice.Visible = false;
                ML3rdHorsepower.Visible = false;
                ML3rdLitres.Visible = false;
                ML3rdFuelType.Visible = false;
                ML3rdTransmission.Visible = false;
                pictureBox3rdML.Visible = false;
            }
        }

        private CSVCarModel FindCarObjectPerName(string name)
        {
            string textualData = ReadDatasetHelper.ReadCSVData();
            string[] allRows = ReadDatasetHelper.FetchDataRowsFromText(textualData, '\n');
            List<CSVCarModel> AllCarsList = ReadDatasetHelper.FetchCarList(allRows, ',');

            var results = AllCarsList.Where(x => x.Name == name);
            // All names are unique so it is also the only one
            return results.First();
        }
    }
}
