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
        penSizeTrackBar = new TrackBar();
        resetButton = new Button();
        telestrationsCanvas = new TelestrationsUI.Components.TelestrationsPictureBox();
        toolsGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)penSizeTrackBar).BeginInit();
        ((System.ComponentModel.ISupportInitialize)telestrationsCanvas).BeginInit();
        SuspendLayout();
        // 
        // toolsGroupBox
        // 
        toolsGroupBox.BackColor = SystemColors.ControlLight;
        toolsGroupBox.Controls.Add(penSizeTrackBar);
        toolsGroupBox.Controls.Add(resetButton);
        toolsGroupBox.Location = new Point(12, 20);
        toolsGroupBox.Name = "toolsGroupBox";
        toolsGroupBox.Size = new Size(1250, 120);
        toolsGroupBox.TabIndex = 3;
        toolsGroupBox.TabStop = false;
        // 
        // penSizeTrackBar
        // 
        penSizeTrackBar.Location = new Point(26, 30);
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
        telestrationsCanvas.Location = new Point(12, 150);
        telestrationsCanvas.Name = "telestrationsCanvas";
        telestrationsCanvas.Size = new Size(1250, 775);
        telestrationsCanvas.TabIndex = 4;
        telestrationsCanvas.TabStop = false;
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
}