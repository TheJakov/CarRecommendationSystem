using CarRecommendationSystem.Helpers;
using CarRecommendationSystem.Models;
using System;
using System.Windows.Forms;

namespace CarRecommendationSystem.Forms
{
    public partial class Question5 : Form
    {
        public Question5()
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
                NavigationHelper.GoToForm(this, new Question6());
            }
        }

        private bool ValidateAnswer()
        {
            int numChecked = 0;

            if (cbNeutral.Checked)
                numChecked++;
            if (cbImportant.Checked)
                numChecked++;
            if (cbVeryImportant.Checked)
                numChecked++;

            if (numChecked == 1)
                return true;
            else
                return false;
        }

        private void AssignEvaluationModelValue()
        {
            if (cbVeryImportant.Checked)
                EvaluationModel.StorageScoreCoef = EvaluationHelper.VeryImportantCoef;
            if (cbImportant.Checked)
                EvaluationModel.StorageScoreCoef = EvaluationHelper.ImportantCoef;
            if (cbNeutral.Checked)
                EvaluationModel.StorageScoreCoef = EvaluationHelper.NeutralCoef;
        }
    }
}
