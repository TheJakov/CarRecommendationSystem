using CarRecommendationSystem.Helpers;
using CarRecommendationSystem.Models;
using System;
using System.Windows.Forms;

namespace CarRecommendationSystem.Forms
{
    public partial class Question7 : Form
    {
        public Question7()
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
                NavigationHelper.GoToForm(this, new Question8());
            }
        }

        private bool ValidateAnswer()
        {
            int numChecked = 0;

            if (cb2.Checked)
                numChecked++;
            if (cb4.Checked)
                numChecked++;
            if (cb5.Checked)
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
            if (cb2.Checked)
                EvaluationModel.Seats = 2;
            if (cb4.Checked)
                EvaluationModel.Seats = 4;
            if (cb5.Checked)
                EvaluationModel.Seats = 5;
            if (cbNeutral.Checked)
                EvaluationModel.Seats = -1;
        }
    }
}
