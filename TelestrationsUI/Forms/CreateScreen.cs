using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelestrationsLibrary;
using TelestrationsUI.Network;

namespace TelestrationsUI.Forms;
public partial class CreateScreen : Form
{
    private uint gameId;
    private uint playerId;
    public CreateScreen(uint gid, uint pid)
    {
        InitializeComponent();
        gameId = gid;
        playerId = pid;
    }

    private async void submitButton_Click(object sender, EventArgs e)
    {
        string prompt = textBox1.Text.Trim();
        if (prompt.Length < 1)
        {
            MessageBox.Show("Please enter a prompt");
            return;
        }

        ClientAction action = new ClientAction(Guess: textBox1.Text);
        bool result = await FrontendLogic.SendAction(gameId, playerId, action);
        if (result)
        {
            this.Close();
        } 
        else
        {
            MessageBox.Show("Nayy");
        }
    }
}
