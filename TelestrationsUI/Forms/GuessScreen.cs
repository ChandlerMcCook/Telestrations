using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelestrationsLibrary;
using TelestrationsUI.Network;

namespace TelestrationsUI.Forms;
public partial class GuessScreen : Form
{
    private uint gameId;
    private uint playerId;

    public GuessScreen(uint gid, uint pid, Bitmap image)
    {
        InitializeComponent();
        gameId = gid;
        playerId = pid;
        guessTelePictureBox.SetCanvas(image);
    }

    private async void submitButton_Click(object sender, EventArgs e)
    {
        ClientAction action = new ClientAction(Guess: guessTextBox.Text);
        bool result = await FrontendLogic.SendAction(gameId, playerId, action);
        if (result)
        {
            MessageBox.Show("Yayy");
            this.Close();
        }
        else
        {
            MessageBox.Show("Nayy");
        }
    }

    private async void GuessScreen_Load(object sender, EventArgs e)
    {
        if (Debugger.IsAttached)
            this.Text = await FrontendLogic.GetPlayerName(gameId, playerId);
    }
}
