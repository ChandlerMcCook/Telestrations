namespace TelestrationsUI;

partial class GameScreen
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        toolsGroupBox = new GroupBox();
        fillButton = new Button();
        drawButton = new Button();
        redoButton = new Button();
        undoButton = new Button();
        colorRadioButton1 = new TelestrationsUI.Components.ColorRadioButton();
        penSizeTrackBar = new TrackBar();
        resetButton = new Button();
        telestrationsCanvas = new TelestrationsUI.Components.TelestrationsPictureBox();
        smoothButton = new Button();
        toolsGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)penSizeTrackBar).BeginInit();
        ((System.ComponentModel.ISupportInitialize)telestrationsCanvas).BeginInit();
        SuspendLayout();
        // 
        // toolsGroupBox
        // 
        toolsGroupBox.BackColor = SystemColors.ControlLight;
        toolsGroupBox.Controls.Add(smoothButton);
        toolsGroupBox.Controls.Add(fillButton);
        toolsGroupBox.Controls.Add(drawButton);
        toolsGroupBox.Controls.Add(redoButton);
        toolsGroupBox.Controls.Add(undoButton);
        toolsGroupBox.Controls.Add(colorRadioButton1);
        toolsGroupBox.Controls.Add(penSizeTrackBar);
        toolsGroupBox.Controls.Add(resetButton);
        toolsGroupBox.Location = new Point(12, 24);
        toolsGroupBox.Name = "toolsGroupBox";
        toolsGroupBox.Size = new Size(1250, 120);
        toolsGroupBox.TabIndex = 3;
        toolsGroupBox.TabStop = false;
        // 
        // fillButton
        // 
        fillButton.Location = new Point(504, 83);
        fillButton.Name = "fillButton";
        fillButton.Size = new Size(59, 29);
        fillButton.TabIndex = 6;
        fillButton.Text = "Fill!";
        fillButton.UseVisualStyleBackColor = true;
        fillButton.Click += fillButton_Click;
        // 
        // drawButton
        // 
        drawButton.Location = new Point(405, 83);
        drawButton.Name = "drawButton";
        drawButton.Size = new Size(64, 29);
        drawButton.TabIndex = 5;
        drawButton.Text = "Draw!";
        drawButton.UseVisualStyleBackColor = true;
        drawButton.Click += drawButton_Click;
        // 
        // redoButton
        // 
        redoButton.Location = new Point(504, 22);
        redoButton.Name = "redoButton";
        redoButton.Size = new Size(59, 34);
        redoButton.TabIndex = 4;
        redoButton.Text = "redo";
        redoButton.UseVisualStyleBackColor = true;
        redoButton.Click += redoButton_Click;
        // 
        // undoButton
        // 
        undoButton.Location = new Point(405, 22);
        undoButton.Name = "undoButton";
        undoButton.Size = new Size(64, 34);
        undoButton.TabIndex = 3;
        undoButton.Text = "undo";
        undoButton.UseVisualStyleBackColor = true;
        undoButton.Click += undoButton_Click;
        // 
        // colorRadioButton1
        // 
        colorRadioButton1.AutoSize = true;
        colorRadioButton1.Location = new Point(887, 43);
        colorRadioButton1.Name = "colorRadioButton1";
        colorRadioButton1.OffColor = Color.LightCoral;
        colorRadioButton1.OnColor = Color.IndianRed;
        colorRadioButton1.Size = new Size(186, 29);
        colorRadioButton1.TabIndex = 2;
        colorRadioButton1.TabStop = true;
        colorRadioButton1.Text = "colorRadioButton1";
        colorRadioButton1.UseVisualStyleBackColor = true;
        // 
        // penSizeTrackBar
        // 
        penSizeTrackBar.Location = new Point(6, 43);
        penSizeTrackBar.Maximum = 30;
        penSizeTrackBar.Minimum = 1;
        penSizeTrackBar.Name = "penSizeTrackBar";
        penSizeTrackBar.Size = new Size(321, 69);
        penSizeTrackBar.TabIndex = 1;
        penSizeTrackBar.Value = 1;
        penSizeTrackBar.Scroll += penSizeTrackBar_Scroll;
        // 
        // resetButton
        // 
        resetButton.Location = new Point(1166, 43);
        resetButton.Name = "resetButton";
        resetButton.Size = new Size(53, 40);
        resetButton.TabIndex = 0;
        resetButton.Text = "button1";
        resetButton.UseVisualStyleBackColor = true;
        resetButton.Click += resetButton_Click;
        // 
        // telestrationsCanvas
        // 
        telestrationsCanvas.BackColor = SystemColors.Window;
        telestrationsCanvas.CurrentColor = Color.Black;
        telestrationsCanvas.DrawMode = TelestrationsLibrary.Globals.DrawingMode.Draw;
        telestrationsCanvas.Location = new Point(12, 150);
        telestrationsCanvas.Name = "telestrationsCanvas";
        telestrationsCanvas.Size = new Size(1250, 775);
        telestrationsCanvas.TabIndex = 4;
        telestrationsCanvas.TabStop = false;
        telestrationsCanvas.TeleCursor = Cursors.Default;
        // 
        // smoothButton
        // 
        smoothButton.Location = new Point(604, 26);
        smoothButton.Name = "smoothButton";
        smoothButton.Size = new Size(52, 26);
        smoothButton.TabIndex = 7;
        smoothButton.Text = "smooth";
        smoothButton.UseVisualStyleBackColor = true;
        smoothButton.Click += smoothButton_Click;
        // 
        // GameScreen
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(1278, 944);
        Controls.Add(telestrationsCanvas);
        Controls.Add(toolsGroupBox);
        Name = "GameScreen";
        Text = "GameScreen";
        FormClosed += GameScreen_FormClosed;
        toolsGroupBox.ResumeLayout(false);
        toolsGroupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)penSizeTrackBar).EndInit();
        ((System.ComponentModel.ISupportInitialize)telestrationsCanvas).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private GroupBox toolsGroupBox;
    private Button resetButton;
    private TrackBar penSizeTrackBar;
    private Components.TelestrationsPictureBox telestrationsCanvas;
    private Components.ColorRadioButton colorRadioButton1;
    private Button redoButton;
    private Button undoButton;
    private Button fillButton;
    private Button drawButton;
    private Button smoothButton;
}