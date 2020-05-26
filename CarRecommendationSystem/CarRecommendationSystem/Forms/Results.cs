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
            //get labels for ML prediction
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
            Alg1stPrice.Text = orderedList[0].Price.ToString() + " kn";
            Alg1stHorsepower.Text = orderedList[0].Horsepower.ToString();
            Alg1stLitres.Text = orderedList[0].Litres100km.ToString();
            Alg1stFuelType.Text = orderedList[0].FuelType;
            Alg1stTransmission.Text = orderedList[0].Transmission;
            pictureBox1stAlg.ImageLocation = imageDir + orderedList[0].ID + ".png";

            //2nd
            Alg2ndCarName.Text = orderedList[1].Name + " - Score: " + orderedList[1].Score;
            Alg2ndPrice.Text = orderedList[1].Price.ToString() + " kn";
            Alg2ndHorsepower.Text = orderedList[1].Horsepower.ToString();
            Alg2ndLitres.Text = orderedList[1].Litres100km.ToString();
            Alg2ndFuelType.Text = orderedList[1].FuelType;
            Alg2ndTransmission.Text = orderedList[1].Transmission;
            pictureBox2ndAlg.ImageLocation = imageDir + orderedList[1].ID + ".png";

            //3rd
            Alg3rdCarName.Text = orderedList[2].Name + " - Score: " + orderedList[2].Score;
            Alg3rdPrice.Text = orderedList[2].Price.ToString() + " kn";
            Alg3rdHorsepower.Text = orderedList[2].Horsepower.ToString();
            Alg3rdLitres.Text = orderedList[2].Litres100km.ToString();
            Alg3rdFuelType.Text = orderedList[2].FuelType;
            Alg3rdTransmission.Text = orderedList[2].Transmission;
            pictureBox3rdAlg.ImageLocation = imageDir + orderedList[2].ID + ".png";
        }
    }
}
