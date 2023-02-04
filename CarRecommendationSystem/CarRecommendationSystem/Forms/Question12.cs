using CarRecommendationSystem.Helpers;
using CarRecommendationSystem.Models;
using System;
using System.Windows.Forms;

namespace CarRecommendationSystem.Forms
{
    public partial class Question12 : Form
    {
        private int BudgetHrk;

        public Question12()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) => NavigationHelper.GoToStartForm(this);

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!ValidateAnswer())
            {
                UIHelper.ShowInfoMessage(Strings.YouNeedToEnterIntegerValue, Strings.Budget);
                txtBudget.Clear();
            }
            else
            {
                AssignEvaluationModelValue();
                NavigationHelper.GoToForm(this, new Question13());
            }
        }

        private bool ValidateAnswer()
        {
            if (int.TryParse(txtBudget.Text, out BudgetHrk))
                return true;
            else
                return false;
        }

        private void AssignEvaluationModelValue()
        {
            int budgetUSD = EvaluationHelper.KunasToUSD(BudgetHrk);
            EvaluationModel.Price = budgetUSD;
        }
    }
}
