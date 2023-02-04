using CarRecommendationSystem.Helpers;
using CarRecommendationSystem.Models;
using System;
using System.Windows.Forms;

namespace CarRecommendationSystem.Forms
{
    public partial class Question14 : Form
    {
        public Question14()
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
                NavigationHelper.GoToForm(this, new Results());
            }
        }

        private bool ValidateAnswer()
        {
            int numChecked = 0;

            if (cb2020.Checked)
                numChecked++;
            if (cb2019.Checked)
                numChecked++;
            if (cb2018.Checked)
                numChecked++;
            if (cb2017.Checked)
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
            if (cb2020.Checked)
                EvaluationModel.Year = 2020;
            if (cb2019.Checked)
                EvaluationModel.Year = 2019;
            if (cb2018.Checked)
                EvaluationModel.Year = 2018;
            if (cb2017.Checked)
                EvaluationModel.Year = 2017;
            if (cbNeutral.Checked)
                EvaluationModel.Year = -1;
        }
    }
}
