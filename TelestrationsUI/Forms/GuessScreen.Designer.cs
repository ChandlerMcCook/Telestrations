using TelestrationsLibrary;

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
        label1 = new Label();
        tableLayoutPanel1 = new TableLayoutPanel();
        submitButton = new Button();
        guessTelePictureBox = new TelestrationsUI.Components.TelestrationsPictureBox();
        tableLayoutPanel2 = new TableLayoutPanel();
        guessTextBox = new TextBox();
        tableLayoutPanel3 = new TableLayoutPanel();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)guessTelePictureBox).BeginInit();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.None;
        label1.AutoSize = true;
        label1.Location = new Point(573, 2);
        label1.Name = "label1";
        label1.Size = new Size(126, 25);
        label1.TabIndex = 1;
        label1.Text = "Make a Guess!";
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(submitButton, 0, 2);
        tableLayoutPanel1.Controls.Add(guessTelePictureBox, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(10, 10);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tableLayoutPanel1.Size = new Size(1278, 994);
        tableLayoutPanel1.TabIndex = 3;
        // 
        // submitButton
        // 
        submitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        submitButton.Location = new Point(594, 947);
        submitButton.Name = "submitButton";
        submitButton.Size = new Size(90, 44);
        submitButton.TabIndex = 3;
        submitButton.Text = "Submit!";
        submitButton.UseVisualStyleBackColor = true;
        submitButton.Click += submitButton_Click;
        // 
        // guessTelePictureBox
        // 
        guessTelePictureBox.Dock = DockStyle.Fill;
        guessTelePictureBox.DrawMode = TelestrationsLibrary.Globals.DrawingMode.Draw;
        guessTelePictureBox.Location = new Point(3, 3);
        guessTelePictureBox.MinimumSize = new Size(1250, 775);
        guessTelePictureBox.Name = "guessTelePictureBox";
        guessTelePictureBox.Readonly = true;
        guessTelePictureBox.Size = new Size(1272, 778);
        guessTelePictureBox.SmoothMode = false;
        guessTelePictureBox.TabIndex = 5;
        guessTelePictureBox.TabStop = false;
        guessTelePictureBox.TeleCursor = Cursors.Default;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(label1, 0, 0);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 787);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
        tableLayoutPanel2.Size = new Size(1272, 154);
        tableLayoutPanel2.TabIndex = 3;
        // 
        // guessTextBox
        // 
        guessTextBox.Anchor = AnchorStyles.None;
        guessTextBox.BorderStyle = BorderStyle.None;
        guessTextBox.Location = new Point(86, 18);
        guessTextBox.MaxLength = Globals.MAX_GUESS_LEN;
        guessTextBox.Multiline = true;
        guessTextBox.Name = "guessTextBox";
        guessTextBox.Size = new Size(684, 65);
        guessTextBox.TabIndex = 2;
        guessTextBox.TextAlign = HorizontalAlignment.Center;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.Anchor = AnchorStyles.None;
        tableLayoutPanel3.BackColor = SystemColors.Window;
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.Controls.Add(guessTextBox, 0, 0);
        tableLayoutPanel3.Location = new Point(208, 41);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.Size = new Size(856, 101);
        tableLayoutPanel3.TabIndex = 3;
        // 
        // GuessScreen
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSize = true;
        ClientSize = new Size(1298, 1014);
        Controls.Add(tableLayoutPanel1);
        MaximizeBox = false;
        MinimumSize = new Size(1320, 1070);
        Name = "GuessScreen";
        Padding = new Padding(10);
        Text = "Guess";
        Load += GuessScreen_Load;
        tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)guessTelePictureBox).EndInit();
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel3.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private Label label1;
    private TableLayoutPanel tableLayoutPanel1;
    private Button submitButton;
    private Components.TelestrationsPictureBox telestrationsPictureBox1;
    private Components.TelestrationsPictureBox guessTelePictureBox;
    private TableLayoutPanel tableLayoutPanel2;
    private TextBox guessTextBox;
    private TableLayoutPanel tableLayoutPanel3;
}