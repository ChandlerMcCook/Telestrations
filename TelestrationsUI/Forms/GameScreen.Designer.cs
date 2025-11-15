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
        resetButton = new Button();
        ((System.ComponentModel.ISupportInitialize)canvasPictureBox).BeginInit();
        toolsGroupBox.SuspendLayout();
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
        canvasPictureBox.MouseLeave += canvasPictureBox_MouseLeave;
        canvasPictureBox.MouseMove += canvasPictureBox_MouseMove;
        canvasPictureBox.MouseUp += canvasPictureBox_MouseUp;
        // 
        // toolsGroupBox
        // 
        toolsGroupBox.BackColor = SystemColors.ControlLight;
        toolsGroupBox.Controls.Add(resetButton);
        toolsGroupBox.Location = new Point(12, 20);
        toolsGroupBox.Name = "toolsGroupBox";
        toolsGroupBox.Size = new Size(1250, 120);
        toolsGroupBox.TabIndex = 3;
        toolsGroupBox.TabStop = false;
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
        toolsGroupBox.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private PictureBox canvasPictureBox;
    private GroupBox toolsGroupBox;
    private Button resetButton;
}