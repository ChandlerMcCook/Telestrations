namespace TelestrationsUI;

partial class SignIn
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
        logoPictureBox = new PictureBox();
        signInButton = new Button();
        playerNameTextBox = new TextBox();
        signInGroupBox = new GroupBox();
        label1 = new Label();
        logoGroupBox = new GroupBox();
        ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
        signInGroupBox.SuspendLayout();
        logoGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // logoPictureBox
        // 
        logoPictureBox.BackgroundImage = (Image)resources.GetObject("logoPictureBox.BackgroundImage");
        logoPictureBox.Location = new Point(10, 8);
        logoPictureBox.Name = "logoPictureBox";
        logoPictureBox.Size = new Size(1000, 500);
        logoPictureBox.TabIndex = 0;
        logoPictureBox.TabStop = false;
        // 
        // signInButton
        // 
        signInButton.Location = new Point(455, 36);
        signInButton.Name = "signInButton";
        signInButton.Size = new Size(125, 45);
        signInButton.TabIndex = 1;
        signInButton.Text = "Join!";
        signInButton.UseVisualStyleBackColor = true;
        signInButton.Click += signInButton_Click;
        // 
        // playerNameTextBox
        // 
        playerNameTextBox.Location = new Point(55, 43);
        playerNameTextBox.Name = "playerNameTextBox";
        playerNameTextBox.Size = new Size(319, 31);
        playerNameTextBox.TabIndex = 2;
        playerNameTextBox.KeyDown += playerNameTextBox_KeyDown;
        // 
        // signInGroupBox
        // 
        signInGroupBox.BackColor = SystemColors.ControlLight;
        signInGroupBox.Controls.Add(label1);
        signInGroupBox.Controls.Add(playerNameTextBox);
        signInGroupBox.Controls.Add(signInButton);
        signInGroupBox.Location = new Point(302, 745);
        signInGroupBox.Name = "signInGroupBox";
        signInGroupBox.Size = new Size(665, 117);
        signInGroupBox.TabIndex = 3;
        signInGroupBox.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(55, 15);
        label1.Name = "label1";
        label1.Size = new Size(111, 25);
        label1.TabIndex = 3;
        label1.Text = "Player Name";
        // 
        // logoGroupBox
        // 
        logoGroupBox.BackColor = SystemColors.ControlLight;
        logoGroupBox.Controls.Add(logoPictureBox);
        logoGroupBox.Location = new Point(123, 81);
        logoGroupBox.Name = "logoGroupBox";
        logoGroupBox.Size = new Size(1020, 521);
        logoGroupBox.TabIndex = 4;
        logoGroupBox.TabStop = false;
        // 
        // SignIn
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Window;
        ClientSize = new Size(1278, 944);
        Controls.Add(logoGroupBox);
        Controls.Add(signInGroupBox);
        Name = "SignIn";
        Text = "SignIn";
        FormClosed += SignIn_FormClosed;
        ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
        signInGroupBox.ResumeLayout(false);
        signInGroupBox.PerformLayout();
        logoGroupBox.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private PictureBox logoPictureBox;
    private Button signInButton;
    private TextBox playerNameTextBox;
    private GroupBox signInGroupBox;
    private Label label1;
    private GroupBox logoGroupBox;
}