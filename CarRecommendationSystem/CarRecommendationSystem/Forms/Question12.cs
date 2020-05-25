using CarRecommendationSystem.Helpers;
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
    public partial class Question12 : Form
    {
        public Question12()
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
            {
                MessageBox.Show("You need to enter integer value.", "Budget", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBudget.Clear();
            }
            else
            {
                // Adjust evaluation model
                Question13 q13 = new Question13();
                NavigationHelper.GoToForm(this, q13);
            }
        }

        private bool ValidateAnswer()
        {
            if (int.TryParse(txtBudget.Text, out int number))
                return true;
            else
                return false;
        }
    }
}
