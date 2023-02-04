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

        public static void GoToStartForm(Form current) => GoToForm(current, new Form1());
    }
}
