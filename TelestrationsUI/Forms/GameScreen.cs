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

    private void smoothButton_Click(object sender, EventArgs e)
    {
        telestrationsCanvas.SmoothMode = !telestrationsCanvas.SmoothMode;
    }

    private void colorRadioButton_Click(object sender, EventArgs e)
    {
        telestrationsCanvas.TelePen.Color = ((ColorRadioButton)sender).CircleColor;
    }
}
