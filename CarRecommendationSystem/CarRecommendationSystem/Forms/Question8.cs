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
    public partial class Question8 : Form
    {
        public Question8()
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
                Question9 q9 = new Question9();
                NavigationHelper.GoToForm(this, q9);
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
                EvaluationModel.FuelEfficiency = "good";
            if (cbAverage.Checked)
                EvaluationModel.FuelEfficiency = "average";
            if (cbPoor.Checked)
                EvaluationModel.FuelEfficiency = "poor";
        }
    }
}
