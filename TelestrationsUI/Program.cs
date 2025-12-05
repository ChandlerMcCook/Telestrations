using TelestrationsUI.Forms;
using TelestrationsLibrary;

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
            //SignIn signIn = new SignIn();
            //signIn.Show();
            GameScreen gameScreen = new GameScreen();
            gameScreen.Show();

            //Player user = new Player("guy");
            //LandingPage page = new LandingPage(user);
            //page.Show();

            Application.Run();
        }
    }
}