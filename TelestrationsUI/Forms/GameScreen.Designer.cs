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
        canvasPictureBox = new PictureBox();
        toolsGroupBox = new GroupBox();
        ((System.ComponentModel.ISupportInitialize)canvasPictureBox).BeginInit();
        SuspendLayout();
        // 
        // canvasPictureBox
        // 
        canvasPictureBox.BackColor = SystemColors.Window;
        canvasPictureBox.Location = new Point(12, 150);
        canvasPictureBox.Name = "canvasPictureBox";
        canvasPictureBox.Size = new Size(1250, 775);
        canvasPictureBox.TabIndex = 2;
        canvasPictureBox.TabStop = false;
        canvasPictureBox.MouseDown += canvasPictureBox_MouseDown;
        canvasPictureBox.MouseMove += canvasPictureBox_MouseMove;
        canvasPictureBox.MouseUp += canvasPictureBox_MouseUp;
        // 
        // toolsGroupBox
        // 
        toolsGroupBox.BackColor = SystemColors.ControlLight;
        toolsGroupBox.Location = new Point(12, 20);
        toolsGroupBox.Name = "toolsGroupBox";
        toolsGroupBox.Size = new Size(1250, 120);
        toolsGroupBox.TabIndex = 3;
        toolsGroupBox.TabStop = false;
        // 
        // GameScreen
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(1278, 944);
        Controls.Add(toolsGroupBox);
        Controls.Add(canvasPictureBox);
        Name = "GameScreen";
        Text = "GameScreen";
        FormClosed += GameScreen_FormClosed;
        ((System.ComponentModel.ISupportInitialize)canvasPictureBox).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PictureBox canvasPictureBox;
    private GroupBox toolsGroupBox;
}