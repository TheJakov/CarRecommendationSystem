using CarRecommendationSystem.Helpers;
using CarRecommendationSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRecommendationSystem.Forms
{
    public partial class Question9 : Form
    {
        public Question9()
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
                Question10 q10 = new Question10();
                NavigationHelper.GoToForm(this, q10);
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
                EvaluationModel.Transmission = "manual";
            if (cbAutomatedManual.Checked)
                EvaluationModel.Transmission = "automated manual";
            if (cbContAutomatic.Checked)
                EvaluationModel.Transmission = "continuous automatic";
            if (cbShiftAutomatic.Checked)
                EvaluationModel.Transmission = "shiftable automatic";
            if (cbNeutral.Checked)
                EvaluationModel.Transmission = "any";
        }
    }
}
