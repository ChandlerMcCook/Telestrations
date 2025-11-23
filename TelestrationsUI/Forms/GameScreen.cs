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
using static TelestrationsLibrary.Globals;


namespace TelestrationsUI;
public partial class GameScreen : Form
{
    public GameScreen()
    {
        InitializeComponent();
    }
    private void GameScreen_Load(object sender, EventArgs e)
    {
        pencilButton.PerformClick();
        colorRadioButton1.PerformClick();
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

    private void undoButton_Click(object sender, EventArgs e)
    {
        if (telestrationsCanvas.CanvasImageHistory.CanUndo())
        {
            Bitmap undoImage = telestrationsCanvas.CanvasImageHistory.Undo();
            telestrationsCanvas.SetCanvas(undoImage);
        }
        redoButton.Enabled = telestrationsCanvas.CanvasImageHistory.CanRedo();
    }

    private void redoButton_Click(object sender, EventArgs e)
    {
        if (telestrationsCanvas.CanvasImageHistory.CanRedo())
        {
            Bitmap redoImage = telestrationsCanvas.CanvasImageHistory.Redo();
            telestrationsCanvas.SetCanvas(redoImage);
        }
        redoButton.Enabled = telestrationsCanvas.CanvasImageHistory.CanRedo();
    }

    private void drawButton_Click(object sender, EventArgs e)
    {
        telestrationsCanvas.TeleCursor = Cursors.Default;
        telestrationsCanvas.DrawMode = DrawingMode.Draw;
    }

    private void fillButton_Click(object sender, EventArgs e)
    {
        telestrationsCanvas.TeleCursor = new Cursor(Properties.Resources.Bucket.Handle);
        telestrationsCanvas.DrawMode = DrawingMode.Fill;
    }

    private void colorRadioButton_Click(object sender, EventArgs e)
    {
        telestrationsCanvas.TelePen.Color = ((ColorRadioButton)sender).CircleColor;
    }

    private void pencilButton_Click(object sender, EventArgs e)
    {
        telestrationsCanvas.TeleCursor = Cursors.Default;
        telestrationsCanvas.DrawMode = DrawingMode.Draw;
        telestrationsCanvas.SmoothMode = false;
    }

    private void brushButton_Click(object sender, EventArgs e)
    {
        telestrationsCanvas.TeleCursor = Cursors.Default;
        telestrationsCanvas.DrawMode = DrawingMode.Draw;
        telestrationsCanvas.SmoothMode = true;
    }

}
