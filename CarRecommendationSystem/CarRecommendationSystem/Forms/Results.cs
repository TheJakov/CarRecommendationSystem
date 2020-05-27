using CarRecommendationSystem.Helpers;
using CarRecommendationSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRecommendationSystem.Forms
{
    public partial class Results : Form
    {
        private string imageDir = @"../../../../dataset_media/";
        public Results()
        {
            InitializeComponent();

            MLTransitionHelper.WriteUserProfileParamsToFile();
            MLTransitionHelper.StartMLPredictionProcess();
            ApplyMLResults();
            CustomEvalutationAlgorithm();
        }

        private void CustomEvalutationAlgorithm()
        {
            string textualData = ReadDatasetHelper.ReadCSVData();
            string[] allRows = ReadDatasetHelper.FetchDataRowsFromText(textualData, '\n');
            List<CSVCarModel> AllCarsList = ReadDatasetHelper.FetchCarList(allRows, ',');
            EvaluationHelper.EvaluateList(AllCarsList);
            List<CSVCarModel> orderedCarList = AllCarsList.OrderByDescending(x => x.Score).ToList();
            ApplyResults(orderedCarList);
        }

        private void ApplyResults(List<CSVCarModel> orderedList)
        {
            // 1st
            Alg1stCarName.Text = orderedList[0].Name + " - Score: " + orderedList[0].Score;
            Alg1stPrice.Text = EvaluationHelper.USDToKunas(orderedList[0].Price) + " kn";
            Alg1stHorsepower.Text = orderedList[0].Horsepower.ToString();
            Alg1stLitres.Text = orderedList[0].Litres100km.ToString();
            Alg1stFuelType.Text = orderedList[0].FuelType;
            Alg1stTransmission.Text = orderedList[0].Transmission;
            pictureBox1stAlg.ImageLocation = imageDir + orderedList[0].ID + ".png";

            //2nd
            Alg2ndCarName.Text = orderedList[1].Name + " - Score: " + orderedList[1].Score;
            Alg2ndPrice.Text = EvaluationHelper.USDToKunas(orderedList[1].Price) + " kn";
            Alg2ndHorsepower.Text = orderedList[1].Horsepower.ToString();
            Alg2ndLitres.Text = orderedList[1].Litres100km.ToString();
            Alg2ndFuelType.Text = orderedList[1].FuelType;
            Alg2ndTransmission.Text = orderedList[1].Transmission;
            pictureBox2ndAlg.ImageLocation = imageDir + orderedList[1].ID + ".png";

            //3rd
            Alg3rdCarName.Text = orderedList[2].Name + " - Score: " + orderedList[2].Score;
            Alg3rdPrice.Text = EvaluationHelper.USDToKunas(orderedList[2].Price) + " kn";
            Alg3rdHorsepower.Text = orderedList[2].Horsepower.ToString();
            Alg3rdLitres.Text = orderedList[2].Litres100km.ToString();
            Alg3rdFuelType.Text = orderedList[2].FuelType;
            Alg3rdTransmission.Text = orderedList[2].Transmission;
            pictureBox3rdAlg.ImageLocation = imageDir + orderedList[2].ID + ".png";
        }

        private void ApplyMLResults()
        {
            List<PredictionResultModel> resultList = ReadDatasetHelper.FetchMLResults();

            ApplyML1stResult(resultList);
            ApplyML2ndResult(resultList);
            ApplyML3rdResult(resultList);
        }

        private void ApplyML1stResult(List<PredictionResultModel> resultList)
        {
            if(resultList.Count >= 1)
            {
                ML1stCarName.Text = resultList[0].Name + " - Confidence: " + resultList[0].Confidence + "%";
                CSVCarModel exactCarModel = FindCarObjectPerName(resultList[0].Name);
                ML1stCarPrice.Text = EvaluationHelper.USDToKunas(exactCarModel.Price) + " kn";
                ML1stHorsepower.Text = exactCarModel.Horsepower.ToString();
                ML1stLitres.Text = exactCarModel.Litres100km.ToString();
                ML1stFuelType.Text = exactCarModel.FuelType;
                ML1stTransmission.Text = exactCarModel.Transmission;
                pictureBox1stML.ImageLocation = imageDir + exactCarModel.ID + ".png";
            }
            else // Should be executed only if reading/writing exception...
            {
                ML1stCarName.Visible = false;
                ML1stNumber.Visible = false;
            }
        }

        private void ApplyML2ndResult(List<PredictionResultModel> resultList)
        {
            if(resultList.Count >= 2)
            {
                ML2ndCarName.Text = resultList[1].Name + " - Confidence: " + resultList[1].Confidence + "%";
                CSVCarModel exactCarModel = FindCarObjectPerName(resultList[1].Name);
                ML2ndPrice.Text = EvaluationHelper.USDToKunas(exactCarModel.Price) + " kn";
                ML2ndHorsepower.Text = exactCarModel.Horsepower.ToString();
                ML2ndLitres.Text = exactCarModel.Litres100km.ToString();
                ML2ndFuelType.Text = exactCarModel.FuelType;
                ML2ndTransmission.Text = exactCarModel.Transmission;
                pictureBox2ndML.ImageLocation = imageDir + exactCarModel.ID + ".png";
            }
            else
            {
                ML2ndCarName.Visible = false;
                ML2ndNumber.Visible = false;
            }
        }

        private void ApplyML3rdResult(List<PredictionResultModel> resultList)
        {
            if(resultList.Count >= 3)
            {
                ML3rdCarName.Text = resultList[2].Name + " - Confidence: " + resultList[2].Confidence + "%";
                CSVCarModel exactCarModel = FindCarObjectPerName(resultList[2].Name);
                ML3rdPrice.Text = EvaluationHelper.USDToKunas(exactCarModel.Price) + " kn";
                ML3rdHorsepower.Text = exactCarModel.Horsepower.ToString();
                ML3rdLitres.Text = exactCarModel.Litres100km.ToString();
                ML3rdFuelType.Text = exactCarModel.FuelType;
                ML3rdTransmission.Text = exactCarModel.Transmission;
                pictureBox3rdML.ImageLocation = imageDir + exactCarModel.ID + ".png";
            }
            else
            {
                ML3rdCarName.Visible = false;
                ML3rdNumber.Visible = false;
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

        private void btnAgain_Click(object sender, EventArgs e)
        {
            Form1 start = new Form1();
            NavigationHelper.GoToForm(this, start);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TheJakov/CarRecommendationSystem");
        }
    }
}
