﻿using CarRecommendationSystem.Helpers;
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
    public partial class Question1 : Form
    {
        public Question1()
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
                Question2 q2 = new Question2();
                NavigationHelper.GoToForm(this, q2);
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
                EvaluationModel.DrivingScoreCoef = EvaluationHelper.VeryImportantCoef;
            if (cbImportant.Checked)
                EvaluationModel.DrivingScoreCoef = EvaluationHelper.ImportantCoef;
            if (cbNeutral.Checked)
                EvaluationModel.DrivingScoreCoef = EvaluationHelper.NeutralCoef;
        }
    }
}
