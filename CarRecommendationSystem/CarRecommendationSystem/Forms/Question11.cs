using CarRecommendationSystem.Helpers;
using CarRecommendationSystem.Models;
using System;
using System.Windows.Forms;

namespace CarRecommendationSystem.Forms
{
    public partial class Question11 : Form
    {
        public Question11()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) => NavigationHelper.GoToStartForm(this);

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!ValidateAnswer())
                UIHelper.ShowInfoMessage(Strings.YouNeedToCheckOneOption, Strings.Oops);
            else
            {
                AssignEvaluationModelValue();
                NavigationHelper.GoToForm(this, new Question12());
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
                EvaluationModel.FuelType = EvaluationHelper.Petrol;
            if (cbDiesel.Checked)
                EvaluationModel.FuelType = EvaluationHelper.Diesel;
            if (cbLPG.Checked)
                EvaluationModel.FuelType = EvaluationHelper.Lpg;
            if (cbBiofuel.Checked)
                EvaluationModel.FuelType = EvaluationHelper.Biofuels;
            if (cbHybrid.Checked)
                EvaluationModel.FuelType = EvaluationHelper.Hybrid;
            if (cbElectric.Checked)
                EvaluationModel.FuelType = EvaluationHelper.Electric;
            if (cbNeutral.Checked)
                EvaluationModel.Transmission = EvaluationHelper.Any;
        }
    }
}
