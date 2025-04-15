using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelestrationsUI
{
    public partial class GameLobbyForm : Form
    {
        private readonly int _userId;
        private readonly GameManager _gm;

        public GameLobbyForm(int userId, GameManager gm)
        {
            _userId = userId;
            _gm = gm;

            InitializeComponent();
        }

        private void GameLobbyForm_Load(object sender, EventArgs e)
        {
            InitializeLobbyListView();
        }

        private async void InitializeLobbyListView()
        { 
            var games = await _gm.GetGames();
        }

        private void lobbyListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
