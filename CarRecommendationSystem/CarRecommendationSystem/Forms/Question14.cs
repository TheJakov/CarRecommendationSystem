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
    public partial class Question14 : Form
    {
        public Question14()
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
                // Adjust evaluation model
                Results results = new Results();
                NavigationHelper.GoToForm(this, results);
            }
        }

        private bool ValidateAnswer()
        {
            int numChecked = 0;

            if (cb2020.Checked)
                numChecked++;
            if (cb2019.Checked)
                numChecked++;
            if (cb2018.Checked)
                numChecked++;
            if (cb2017.Checked)
                numChecked++;
            if (cbNeutral.Checked)
                numChecked++;

            if (numChecked == 1)
                return true;
            else
                return false;
        }
    }
}
