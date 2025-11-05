using System.Net.Http.Json;
using TelestrationsLibrary;

namespace TelestrationsUI;

public partial class LandingPageForm : Form
{
    private readonly Player _user;
    public LandingPageForm(Player user)
    {
        InitializeComponent();

        _user = user;
        LoadGrid();
    }

    private async void LoadGrid()
    {
        List<Game>? games = await FrontendLogic.GetGamesAsync();

        if (games != null)
        {
            gamesDataGrid.DataSource = games;
        }
    }

    private async void createGameButton_Click(object sender, EventArgs e)
    {
        bool result = await FrontendLogic.CreateGameAsync(gameNameTextBox.Text, _user);
        if (result)
        {
            LoadGrid();
        }
        else
        {
            MessageBox.Show("Error creating game. Please try again.");
        }
    }

    private void refreshButton_Click(object sender, EventArgs e)
    {
        LoadGrid();
    }
}
