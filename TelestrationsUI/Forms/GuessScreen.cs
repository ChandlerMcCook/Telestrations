using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelestrationsUI.Network;

namespace TelestrationsUI.Forms;
public partial class GuessScreen : Form
{
    public GuessScreen()
    {
        InitializeComponent();
    }

    private async void GuessScreen_Load(object sender, EventArgs e)
    {
        Bitmap image = await FrontendLogic.GetDrawing();
        guessPictureBox.Image = image;
    }
}
