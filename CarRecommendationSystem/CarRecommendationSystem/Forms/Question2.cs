﻿using CarRecommendationSystem.Helpers;
using CarRecommendationSystem.Models;
using System;
using System.Windows.Forms;

namespace CarRecommendationSystem.Forms
{
    public partial class Question2 : Form
    {
        public Question2()
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
                NavigationHelper.GoToForm(this, new Question3());
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
                EvaluationModel.ComfortScoreCoef = EvaluationHelper.VeryImportantCoef;
            if (cbImportant.Checked)
                EvaluationModel.ComfortScoreCoef = EvaluationHelper.ImportantCoef;
            if (cbNeutral.Checked)
                EvaluationModel.ComfortScoreCoef = EvaluationHelper.NeutralCoef;
        }
    }
}
