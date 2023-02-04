using CarRecommendationSystem.Helpers;
using CarRecommendationSystem.Models;
using System;
using System.Windows.Forms;

namespace CarRecommendationSystem.Forms
{
    public partial class Question8 : Form
    {
        public Question8()
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
                NavigationHelper.GoToForm(this, new Question9());
            }
        }

        private bool ValidateAnswer()
        {
            int numChecked = 0;

            if (cbGood.Checked)
                numChecked++;
            if (cbAverage.Checked)
                numChecked++;
            if (cbPoor.Checked)
                numChecked++;

            if (numChecked == 1)
                return true;
            else
                return false;
        }

        private void AssignEvaluationModelValue()
        {
            if (cbGood.Checked)
                EvaluationModel.FuelEfficiency = EvaluationHelper.Good;
            if (cbAverage.Checked)
                EvaluationModel.FuelEfficiency = EvaluationHelper.Average;
            if (cbPoor.Checked)
                EvaluationModel.FuelEfficiency = EvaluationHelper.Poor;
        }
    }
}
