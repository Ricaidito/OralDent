using OralDent.Forms;
using System;
using System.Windows.Forms;

namespace OralDent
{
    internal static class Program
    {
        private static bool debugMode = false;

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (debugMode)
                Application.Run(new MenuForm("Debug", new LoginForm()));
            else
                Application.Run(new LoginForm());
        }
    }
}
