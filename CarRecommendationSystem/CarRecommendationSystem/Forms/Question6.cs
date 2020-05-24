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
    public partial class Question6 : Form
    {
        public Question6()
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
            Question7 q7 = new Question7();
            NavigationHelper.GoToForm(this, q7);
        }
    }
}
