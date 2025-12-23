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
using TelestrationsUI.Components;
using TelestrationsUI.Forms;
using TelestrationsUI.Network;
using static TelestrationsLibrary.Globals;


namespace TelestrationsUI;
public partial class GameScreen : Form
{
    private Color _prevColor = Color.Black;
    private uint gameId;
    private uint playerId;
    private ActionType actionType;

    public GameScreen(uint gid, uint pid, ServerAction action)
    {
        InitializeComponent();
        gameId = gid;
        playerId = pid;
        actionType = action.Action;

        if (actionType == ActionType.Draw)
        {
            guessTextBox.Text = action.Guess;
            guessTextBox.ReadOnly = true;
        }
    }

    private async void GameScreen_Load(object sender, EventArgs e)
    {
        if (Debugger.IsAttached)
            this.Text = await FrontendLogic.GetPlayerName(gameId, playerId);
        pencilButton.PerformClick();
        colorRadioButton1.PerformClick();
        telestrationsCanvas.ZoomLabel = zoomLabel;
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
        penSizeTrackBar.Value = (int)Math.Round(penSizeTrackBar.Value / 10.0) * 10 + 1;
        telestrationsCanvas.TelePen.Width = penSizeTrackBar.Value;
        brushSizeLabel.Text = ((penSizeTrackBar.Value - 1) / 10).ToString();
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
        telestrationsCanvas.TelePen.Color = _prevColor;
    }

    private void colorRadioButton_Click(object sender, EventArgs e)
    {
        telestrationsCanvas.TelePen.Color = ((ColorRadioButton)sender).CircleColor;
        _prevColor = telestrationsCanvas.TelePen.Color;
    }

    private void pencilButton_Click(object sender, EventArgs e)
    {
        telestrationsCanvas.TeleCursor = Cursors.Default;
        telestrationsCanvas.DrawMode = DrawingMode.Draw;
        telestrationsCanvas.SmoothMode = false;
        telestrationsCanvas.TelePen.Color = _prevColor;
    }

    private void brushButton_Click(object sender, EventArgs e)
    {
        telestrationsCanvas.TeleCursor = Cursors.Default;
        telestrationsCanvas.DrawMode = DrawingMode.Draw;
        telestrationsCanvas.SmoothMode = true;
        telestrationsCanvas.TelePen.Color = _prevColor;
    }

    private void eraserButton_Click(object sender, EventArgs e)
    {
        telestrationsCanvas.TeleCursor = Cursors.Default;
        telestrationsCanvas.DrawMode = DrawingMode.Draw;
        telestrationsCanvas.SmoothMode = false;
        telestrationsCanvas.TelePen.Color = Color.White;
    }

    private async void submitButton_Click(object sender, EventArgs e)
    {
        Bitmap image = telestrationsCanvas.GetCanvas();
        byte[] imageBytes = FrontendLogic.ConvertBitmapToByteArr(image);
        ClientAction action = actionType == ActionType.CreateAndDraw
            ? new ClientAction(Guess: guessTextBox.Text, Drawing: imageBytes)
            : new ClientAction(Drawing: imageBytes);
        bool result = await FrontendLogic.SendAction(gameId, playerId, action);
        if (result)
            this.Close();
        else
            MessageBox.Show("Fail");
    }

    private void GameScreen_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Z && e.Control)
        {
            if (e.Shift)
                redoButton_Click(sender, e);
            else
                undoButton_Click(sender, e);
        }
    }
}
