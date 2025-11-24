namespace TelestrationsUI.Forms;

partial class GuessScreen
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
        guessPictureBox = new PictureBox();
        label1 = new Label();
        guessTextBox = new RichTextBox();
        ((System.ComponentModel.ISupportInitialize)guessPictureBox).BeginInit();
        SuspendLayout();
        // 
        // guessPictureBox
        // 
        guessPictureBox.Location = new Point(12, 12);
        guessPictureBox.Name = "guessPictureBox";
        guessPictureBox.Size = new Size(1250, 775);
        guessPictureBox.TabIndex = 0;
        guessPictureBox.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(558, 812);
        label1.Name = "label1";
        label1.Size = new Size(126, 25);
        label1.TabIndex = 1;
        label1.Text = "Make a Guess!";
        // 
        // guessTextBox
        // 
        guessTextBox.Location = new Point(295, 846);
        guessTextBox.Name = "guessTextBox";
        guessTextBox.Size = new Size(659, 86);
        guessTextBox.TabIndex = 2;
        guessTextBox.Text = "";
        // 
        // GuessScreen
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1278, 944);
        Controls.Add(guessTextBox);
        Controls.Add(label1);
        Controls.Add(guessPictureBox);
        Name = "GuessScreen";
        Text = "Guess";
        Load += GuessScreen_Load;
        ((System.ComponentModel.ISupportInitialize)guessPictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox guessPictureBox;
    private Label label1;
    private RichTextBox guessTextBox;
}