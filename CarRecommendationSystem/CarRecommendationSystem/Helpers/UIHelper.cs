using System.Windows.Forms;

namespace CarRecommendationSystem.Helpers
{
    public static class UIHelper
    {
        public static void ShowInfoMessage(string text, string caption)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
