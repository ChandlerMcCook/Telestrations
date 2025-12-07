using System.Net.Http.Json;
using System.Windows.Forms;
using TelestrationsLibrary;
using TelestrationsUI.Forms;
using TelestrationsUI.Network;

namespace TelestrationsUI;

public partial class LandingPage : Form
{
    private readonly uint _playerId;
    public LandingPage(uint playerId)
    {
        InitializeComponent();

        _playerId = playerId;
        SetUpGrid();
    }

    private async void SetUpGrid()
    {
        gamesDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        gamesDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        gamesDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        gamesDataGrid.AutoGenerateColumns = false;

        var idColumn = new DataGridViewTextBoxColumn
        {
            Name = "GameId",
            HeaderText = "Game ID",
            DataPropertyName = "Id",
            Visible = false // hide this column
        };
        gamesDataGrid.Columns.Add(idColumn);

        gamesDataGrid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "GameName",
            HeaderText = "Game Name",
            DataPropertyName = "GameName"
        });

        gamesDataGrid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "HostName",
            HeaderText = "Host",
            DataPropertyName = "HostName"
        });

        gamesDataGrid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "PlayerCount",
            HeaderText = "Player Count",
            DataPropertyName = "PlayerCount"
        });

        var joinButton = new DataGridViewButtonColumn
        {
            Name = "JoinButton",
            HeaderText = "",
            Text = "Join",
            UseColumnTextForButtonValue = true
        };
        gamesDataGrid.Columns.Add(joinButton);

        List<LobbyListing>? games = await FrontendLogic.GetGames();

        if (games != null)
        {
            gamesDataGrid.DataSource = games;
        }
    }
    private async void RefreshGrid()
    {
        List<LobbyListing>? games = await FrontendLogic.GetGames();

        if (games != null)
        {
            gamesDataGrid.DataSource = games;
        }
    }
    private void JoinGame(uint gameId)
    {
        MessageBox.Show($"Joining game with ID: {gameId}");
        //GameScreen gameScreen = new GameScreen();
    }
    private async void createGameButton_Click(object sender, EventArgs e)
    {
        uint result = await FrontendLogic.CreateGame(gameNameTextBox.Text, _playerId);
        //if (result)
        //{
        //    RefreshGrid();
        //}
        //else
        //{
        //    MessageBox.Show("Error creating game. Please try again.");
        //}
    }
    private void refreshButton_Click(object sender, EventArgs e)
    {
        RefreshGrid();
    }
    private void gamesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
            return;

        if (gamesDataGrid.Columns[e.ColumnIndex].Name == "JoinButton")
        {
            uint gameId = (uint)gamesDataGrid.Rows[e.RowIndex].Cells["GameId"].Value;

            JoinGame(gameId);
        }
    }
    private void gameNameTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            createGameButton.PerformClick();
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }
    private void LandingPage_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (Application.OpenForms.Count == 0)
        {
            Application.Exit();
        }
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        uint gameId = await FrontendLogic.CreateGame("Bruh City", _playerId);
        bool result = await FrontendLogic.StartGame(gameId);
        if (result)
        {
            MasterForm form = new MasterForm(gameId, _playerId);
            form.Show();
        }
        else
        {
            MessageBox.Show("NOOOO");
        }
    }
}
