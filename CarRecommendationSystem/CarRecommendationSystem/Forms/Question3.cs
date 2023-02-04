using CarRecommendationSystem.Helpers;
using CarRecommendationSystem.Models;
using System;
using System.Windows.Forms;

namespace CarRecommendationSystem.Forms
{
    public partial class Question3 : Form
    {
        public Question3()
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
                NavigationHelper.GoToForm(this, new Question4());
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
                EvaluationModel.InteriorScoreCoef = EvaluationHelper.VeryImportantCoef;
            if (cbImportant.Checked)
                EvaluationModel.InteriorScoreCoef = EvaluationHelper.ImportantCoef;
            if (cbNeutral.Checked)
                EvaluationModel.InteriorScoreCoef = EvaluationHelper.NeutralCoef;
        }
    }
}
