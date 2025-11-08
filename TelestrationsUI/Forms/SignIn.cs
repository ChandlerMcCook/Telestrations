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

namespace TelestrationsUI;
public partial class SignIn : Form
{
    public SignIn()
    {
        InitializeComponent();
    }

    public void signInButton_Click(object sender, EventArgs e)
    {
        string playerName = playerNameTextBox.Text;
        if (playerName.Length == 0)
        {
            MessageBox.Show("Please enter a valid name.");
            return;
        }
        Player user = new Player(playerName);
        LandingPageForm landingPageForm = new LandingPageForm(user);
        landingPageForm.Show();
        this.Hide();
    }

    private void playerNameTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            signInButton.PerformClick();
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }
}
