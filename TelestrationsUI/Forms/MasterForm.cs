using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelestrationsLibrary;
using TelestrationsUI.Network;

namespace TelestrationsUI.Forms;
public partial class MasterForm : Form
{
    private uint _gameId;
    private Player _player;
    private List<Player>? _playerList;

    public MasterForm(uint gameId, Player player)
    {
        InitializeComponent();
        _gameId = gameId;
        _player = player;
        HandleGame();
    }

    private async void HandleGame()
    {
        _playerList = await FrontendLogic.GetPlayers(_gameId);
        ServerAction? response = await FrontendLogic.GetNextAction(_gameId, _player.ID);
        while (response!.Action != ActionType.Finish)
        {
            switch (response.Action)
            {
                case ActionType.Create:
                    CreateScreen cs = new CreateScreen(_gameId, _player.ID);
                    cs.ShowDialog();
                    break;
                case ActionType.Draw:
                case ActionType.CreateAndDraw:
                    GameScreen gs = new GameScreen(_gameId, _player.ID, response);
                    gs.ShowDialog();
                    break;
                case ActionType.Guess:
                    if (response.Drawing is not null)
                    {
                        Bitmap image = FrontendLogic.ConvertByteArrToBitmap(response.Drawing);
                        GuessScreen gus = new GuessScreen(_gameId, _player.ID, image);
                        gus.ShowDialog();
                    }
                    break;
                case ActionType.Wait:
                    Thread.Sleep(2000);
                    break;
            }
            response = await FrontendLogic.GetNextAction(_gameId, _player.ID);
        }
    }
}
