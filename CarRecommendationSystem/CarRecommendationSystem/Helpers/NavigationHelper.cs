using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRecommendationSystem.Helpers
{
    public static class NavigationHelper
    {
        public static void GoToForm(Form current, Form next)
        {
            current.Hide();
            next.ShowDialog();
            current.Close();
        }
    }
}
