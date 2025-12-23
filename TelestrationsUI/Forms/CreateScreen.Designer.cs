using TelestrationsLibrary;

namespace TelestrationsUI.Forms;

partial class CreateScreen
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
        textBox1 = new TextBox();
        submitButton = new Button();
        tableLayoutPanel1 = new TableLayoutPanel();
        label1 = new Label();
        tableLayoutPanel2 = new TableLayoutPanel();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Anchor = AnchorStyles.None;
        textBox1.BorderStyle = BorderStyle.None;
        textBox1.Location = new Point(29, 28);
        textBox1.MaxLength = Globals.MAX_GUESS_LEN;
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(637, 83);
        textBox1.TabIndex = 0;
        textBox1.TextAlign = HorizontalAlignment.Center;
        // 
        // submitButton
        // 
        submitButton.Anchor = AnchorStyles.None;
        submitButton.Location = new Point(347, 436);
        submitButton.Name = "submitButton";
        submitButton.Size = new Size(307, 143);
        submitButton.TabIndex = 1;
        submitButton.Text = "submit";
        submitButton.UseVisualStyleBackColor = true;
        submitButton.Click += submitButton_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
        tableLayoutPanel1.Controls.Add(submitButton, 0, 2);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel1.Size = new Size(1002, 610);
        tableLayoutPanel1.TabIndex = 2;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.None;
        label1.AutoSize = true;
        label1.Location = new Point(426, 89);
        label1.Name = "label1";
        label1.Size = new Size(149, 25);
        label1.TabIndex = 2;
        label1.Text = "Create A Prompt!";
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.Anchor = AnchorStyles.None;
        tableLayoutPanel2.BackColor = SystemColors.Window;
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.Controls.Add(textBox1, 0, 0);
        tableLayoutPanel2.Location = new Point(153, 234);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new Size(696, 140);
        tableLayoutPanel2.TabIndex = 3;
        // 
        // CreateScreen
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1002, 610);
        Controls.Add(tableLayoutPanel1);
        Name = "CreateScreen";
        Text = "CreateScreen";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TextBox textBox1;
    private Button submitButton;
    private TableLayoutPanel tableLayoutPanel1;
    private Label label1;
    private TableLayoutPanel tableLayoutPanel2;
}