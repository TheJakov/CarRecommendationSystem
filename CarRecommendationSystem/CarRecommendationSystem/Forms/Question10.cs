using CarRecommendationSystem.Helpers;
using CarRecommendationSystem.Models;
using System;
using System.Windows.Forms;

namespace CarRecommendationSystem.Forms
{
    public partial class Question10 : Form
    {
        private int Horsepower;

        public Question10()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) => NavigationHelper.GoToStartForm(this);

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!ValidateAnswer())
            {
                UIHelper.ShowInfoMessage(Strings.YouNeedToEnterIntegerValue, Strings.Horsepower);
                txtHorsePower.Clear();
            }
            else
            {
                AssignEvaluationModelValue();
                NavigationHelper.GoToForm(this, new Question11());
            }
        }

        private bool ValidateAnswer()
        {
            if (int.TryParse(txtHorsePower.Text, out Horsepower))
                return true;
            else
                return false;    
        }

        private void AssignEvaluationModelValue()
        {
            EvaluationModel.Horsepower = Horsepower;
        }
    }
}
