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
using TelestrationsUI.Components;

namespace TelestrationsUI;
public partial class GameScreen : Form
{
    private bool _isDrawing = false;
    private Point _lastPoint = Point.Empty;
    private Bitmap _image;
    private Color _color = Color.Black;
    private Pen _pen = new Pen(Color.Black, 1);

    public GameScreen()
    {
        InitializeComponent();

        _image = new Bitmap(Globals.CANVAS_SIZE_X, Globals.CANVAS_SIZE_Y);
    }

    private void GameScreen_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (Application.OpenForms.Count == 0)
        {
            Application.Exit();
        }
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        telestrationsCanvas.ClearCanvas();
    }

    private void penSizeTrackBar_Scroll(object sender, EventArgs e)
    {
        telestrationsCanvas.TelePen.Width = penSizeTrackBar.Value;
    }
}
