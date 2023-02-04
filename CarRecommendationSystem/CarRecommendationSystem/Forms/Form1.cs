using CarRecommendationSystem.Forms;
using CarRecommendationSystem.Helpers;
using System;
using System.Windows.Forms;

namespace CarRecommendationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            EvaluationHelper.ResetModel();
            Question1 q1 = new Question1();
            NavigationHelper.GoToForm(this, q1);
        }
    }
}
