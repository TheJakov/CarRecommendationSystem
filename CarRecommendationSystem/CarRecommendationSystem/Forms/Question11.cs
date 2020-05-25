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
    public partial class Question11 : Form
    {
        public Question11()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 startForm = new Form1();
            NavigationHelper.GoToForm(this, startForm);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!ValidateAnswer())
                MessageBox.Show("You need to check ONE option.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                AssignEvaluationModelValue();
                Question12 q12 = new Question12();
                NavigationHelper.GoToForm(this, q12);
            }
        }

        private bool ValidateAnswer()
        {
            int numChecked = 0;

            if (cbPetrol.Checked)
                numChecked++;
            if (cbDiesel.Checked)
                numChecked++;
            if (cbLPG.Checked)
                numChecked++;
            if (cbBiofuel.Checked)
                numChecked++;
            if (cbHybrid.Checked)
                numChecked++;
            if (cbElectric.Checked)
                numChecked++;
            if (cbNeutral.Checked)
                numChecked++;

            if (numChecked == 1)
                return true;
            else
                return false;
        }

        private void AssignEvaluationModelValue()
        {
            if (cbPetrol.Checked)
                EvaluationModel.FuelType = "petrol";
            if (cbDiesel.Checked)
                EvaluationModel.FuelType = "diesel";
            if (cbLPG.Checked)
                EvaluationModel.FuelType = "lpg";
            if (cbBiofuel.Checked)
                EvaluationModel.FuelType = "biofuels";
            if (cbHybrid.Checked)
                EvaluationModel.FuelType = "hybrid";
            if (cbElectric.Checked)
                EvaluationModel.FuelType = "electric";
            if (cbNeutral.Checked)
                EvaluationModel.Transmission = "any";
        }
    }
}
