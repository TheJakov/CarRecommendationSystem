using CarRecommendationSystem.Helpers;
using CarRecommendationSystem.Models;
using System;
using System.Windows.Forms;

namespace CarRecommendationSystem.Forms
{
    public partial class Question9 : Form
    {
        public Question9()
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
                NavigationHelper.GoToForm(this, new Question10());
            }
        }

        private bool ValidateAnswer()
        {
            int numChecked = 0;

            if (cbManual.Checked)
                numChecked++;
            if (cbAutomatedManual.Checked)
                numChecked++;
            if (cbContAutomatic.Checked)
                numChecked++;
            if (cbShiftAutomatic.Checked)
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
            if (cbManual.Checked)
                EvaluationModel.Transmission = EvaluationHelper.Manual;
            if (cbAutomatedManual.Checked)
                EvaluationModel.Transmission = EvaluationHelper.AutomatedManual;
            if (cbContAutomatic.Checked)
                EvaluationModel.Transmission = EvaluationHelper.ContinuousAutomatic;
            if (cbShiftAutomatic.Checked)
                EvaluationModel.Transmission = EvaluationHelper.ShiftableAutomatic;
            if (cbNeutral.Checked)
                EvaluationModel.Transmission = EvaluationHelper.Any;
        }
    }
}
