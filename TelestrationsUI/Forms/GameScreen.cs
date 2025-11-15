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
public partial class GameScreen : Form
{
    private bool isDrawing = false;
    private Point lastPoint = Point.Empty;
    private Bitmap canvas;

    public GameScreen()
    {
        InitializeComponent();

        canvas = new Bitmap(Globals.CANVAS_SIZE_X, Globals.CANVAS_SIZE_Y);
    }

    private void canvasPictureBox_MouseDown(object sender, MouseEventArgs e)
    {
        isDrawing = true;
        lastPoint = e.Location;
    }

    private void canvasPictureBox_MouseMove(object sender, MouseEventArgs e)
    {
        if (isDrawing)
        {
            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.DrawLine(Pens.Black, lastPoint, e.Location);
            }
            lastPoint = e.Location;
            canvasPictureBox.Image = canvas;
        }
    }
    private void GameScreen_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (Application.OpenForms.Count == 0)
        {
            Application.Exit();
        }
    }

    private void canvasPictureBox_MouseUp(object sender, MouseEventArgs e)
    {
        isDrawing = false;
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        canvas = new Bitmap(Globals.CANVAS_SIZE_X, Globals.CANVAS_SIZE_Y);
        canvasPictureBox.Image = canvas;
    }

    private void canvasPictureBox_MouseLeave(object sender, EventArgs e)
    {
        isDrawing = false;
    }
}
