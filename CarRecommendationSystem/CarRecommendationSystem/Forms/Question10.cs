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
    public partial class Question10 : Form
    {
        public Question10()
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
                MessageBox.Show("You need to enter integer value.", "Horsepower", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHorsePower.Clear();
            }
            else
            {
                // Adjust evaluation model
                Question11 q11 = new Question11();
                NavigationHelper.GoToForm(this, q11);
            }
        }

        private bool ValidateAnswer()
        {
            if (int.TryParse(txtHorsePower.Text, out int number))
                return true;
            else
                return false;    
        }
    }
}
