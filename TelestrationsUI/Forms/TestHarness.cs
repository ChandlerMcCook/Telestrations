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
public partial class TestHarness : Form
{
    private uint hostId;
    private uint gameId;
    private uint friendId;
    public TestHarness()
    {
        InitializeComponent();
    }

    private async void TestHarness_Load(object sender, EventArgs e)
    {
        await Task.Delay(5000);

        hostId = await FrontendLogic.CreatePlayer("Bruh");
        friendId = await FrontendLogic.CreatePlayer("Bruh's Friend");

        gameId = await FrontendLogic.CreateGame("Bruh Zone", hostId);
        bool result = await FrontendLogic.AddPlayer(gameId, friendId);

        result = await FrontendLogic.StartGame(gameId);

        await TestHarnessHandleGame();
    }

    private async Task TestHarnessHandleGame()
    {
        uint playerId = hostId;
        ServerAction? response = await FrontendLogic.GetNextAction(gameId, playerId);

        while (response!.Action != ActionType.Finish)
        {
            switch (response.Action)
            {
                case ActionType.Create:
                    using (CreateScreen cs = new CreateScreen(gameId, playerId))
                    {
                        cs.ShowDialog();
                    }
                    break;

                case ActionType.Draw:
                case ActionType.CreateAndDraw:
                    using (GameScreen gs = new GameScreen(gameId, playerId, response))
                    {
                        gs.ShowDialog();
                    }
                    break;

                case ActionType.Guess:
                    if (response.Drawing is not null)
                    {
                        Bitmap image = FrontendLogic.ConvertByteArrToBitmap(response.Drawing);
                        using (GuessScreen gus = new GuessScreen(gameId, playerId, image))
                        {
                            gus.ShowDialog();
                        }
                    }
                    break;

                case ActionType.Wait:
                    string? playerName = await FrontendLogic.GetPlayerName(gameId, playerId);
                    MessageBox.Show($"{playerName} Wait");
                    break;
            }
            
            playerId = (playerId == hostId) ? friendId : hostId;
            response = await FrontendLogic.GetNextAction(gameId, playerId);
        }
    }

}
