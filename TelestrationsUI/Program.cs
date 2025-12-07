using TelestrationsUI.Forms;
using TelestrationsLibrary;
using TelestrationsUI.Network;

namespace TelestrationsUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //SignIn signIn = new SignIn();
            //signIn.Show();
            //GameScreen gameScreen = new GameScreen();
            //gameScreen.Show();

            uint playerId = await FrontendLogic.CreatePlayer("guy");
            LandingPage page = new LandingPage(playerId);
            page.Show();

            Application.Run();
        }
    }
}