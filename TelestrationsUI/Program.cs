using TelestrationsUI.Forms;
using TelestrationsLibrary;
using TelestrationsUI.Network;
using System.Diagnostics;

namespace TelestrationsUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            if (Debugger.IsAttached)
            {
                TestHarness th = new TestHarness();
                th.Show();
            }
            else
            {
                SignIn si = new SignIn();
                si.Show();
            }

            Application.Run();
        }
    }
}