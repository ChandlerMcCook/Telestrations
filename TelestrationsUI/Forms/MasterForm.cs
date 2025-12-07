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
    private uint _playerId;
    private List<Player>? _playerList; // need to change to a viewable class

    public MasterForm(uint gameId, uint playerId)
    {
        InitializeComponent();
        _gameId = gameId;
        _playerId = playerId;
        HandleGame();
    }

    private async void HandleGame()
    {
        //_playerList = await FrontendLogic.GetPlayers(_gameId);
        ServerAction? response = await FrontendLogic.GetNextAction(_gameId, _playerId);
        while (response!.Action != ActionType.Finish)
        {
            switch (response.Action)
            {
                case ActionType.Create:
                    CreateScreen cs = new CreateScreen(_gameId, _playerId);
                    cs.ShowDialog();
                    break;
                case ActionType.Draw:
                case ActionType.CreateAndDraw:
                    GameScreen gs = new GameScreen(_gameId, _playerId, response);
                    gs.ShowDialog();
                    break;
                case ActionType.Guess:
                    if (response.Drawing is not null)
                    {
                        Bitmap image = FrontendLogic.ConvertByteArrToBitmap(response.Drawing);
                        GuessScreen gus = new GuessScreen(_gameId, _playerId, image);
                        gus.ShowDialog();
                    }
                    break;
                case ActionType.Wait:
                    Thread.Sleep(2000);
                    break;
            }
            response = await FrontendLogic.GetNextAction(_gameId, _playerId);
        }
    }
}
