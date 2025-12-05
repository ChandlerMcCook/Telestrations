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
        tableLayoutPanel1 = new TableLayoutPanel();
        panel1 = new Panel();
        button1 = new Button();
        ((System.ComponentModel.ISupportInitialize)guessPictureBox).BeginInit();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // guessPictureBox
        // 
        guessPictureBox.Anchor = AnchorStyles.None;
        guessPictureBox.Location = new Point(14, 4);
        guessPictureBox.MaximumSize = new Size(1250, 775);
        guessPictureBox.MinimumSize = new Size(1250, 775);
        guessPictureBox.Name = "guessPictureBox";
        guessPictureBox.Size = new Size(1250, 775);
        guessPictureBox.TabIndex = 0;
        guessPictureBox.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(303, 11);
        label1.Name = "label1";
        label1.Size = new Size(126, 25);
        label1.TabIndex = 1;
        label1.Text = "Make a Guess!";
        // 
        // guessTextBox
        // 
        guessTextBox.Location = new Point(40, 45);
        guessTextBox.MaxLength = 100;
        guessTextBox.Name = "guessTextBox";
        guessTextBox.Size = new Size(659, 86);
        guessTextBox.TabIndex = 2;
        guessTextBox.Text = "";
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(panel1, 0, 1);
        tableLayoutPanel1.Controls.Add(guessPictureBox, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
        tableLayoutPanel1.Size = new Size(1278, 944);
        tableLayoutPanel1.TabIndex = 3;
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        panel1.Controls.Add(button1);
        panel1.Controls.Add(guessTextBox);
        panel1.Controls.Add(label1);
        panel1.Location = new Point(267, 787);
        panel1.Name = "panel1";
        panel1.Size = new Size(743, 154);
        panel1.TabIndex = 4;
        // 
        // button1
        // 
        button1.Location = new Point(686, 11);
        button1.Name = "button1";
        button1.Size = new Size(42, 22);
        button1.TabIndex = 3;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // GuessScreen
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSize = true;
        ClientSize = new Size(1278, 944);
        Controls.Add(tableLayoutPanel1);
        MaximizeBox = false;
        MaximumSize = new Size(1300, 1000);
        MinimumSize = new Size(1300, 1000);
        Name = "GuessScreen";
        Text = "Guess";
        ((System.ComponentModel.ISupportInitialize)guessPictureBox).EndInit();
        tableLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private PictureBox guessPictureBox;
    private Label label1;
    private RichTextBox guessTextBox;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel1;
    private Button button1;
}