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
        submitButton = new Button();
        toolsPanel = new Panel();
        eraserButton = new RadioButton();
        pencilButton = new RadioButton();
        fillButton = new RadioButton();
        brushButton = new RadioButton();
        colorRadioButton20 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton19 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton18 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton17 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton16 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton15 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton14 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton13 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton12 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton11 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton10 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton9 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton8 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton7 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton6 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton5 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton4 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton3 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton2 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton1 = new TelestrationsUI.Components.ColorRadioButton();
        redoButton = new Button();
        undoButton = new Button();
        penSizeTrackBar = new TrackBar();
        resetButton = new Button();
        telestrationsCanvas = new TelestrationsUI.Components.TelestrationsPictureBox();
        button1 = new Button();
        toolsGroupBox.SuspendLayout();
        toolsPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)penSizeTrackBar).BeginInit();
        ((System.ComponentModel.ISupportInitialize)telestrationsCanvas).BeginInit();
        SuspendLayout();
        // 
        // toolsGroupBox
        // 
        toolsGroupBox.BackColor = SystemColors.ControlLight;
        toolsGroupBox.Controls.Add(button1);
        toolsGroupBox.Controls.Add(submitButton);
        toolsGroupBox.Controls.Add(toolsPanel);
        toolsGroupBox.Controls.Add(colorRadioButton20);
        toolsGroupBox.Controls.Add(colorRadioButton19);
        toolsGroupBox.Controls.Add(colorRadioButton18);
        toolsGroupBox.Controls.Add(colorRadioButton17);
        toolsGroupBox.Controls.Add(colorRadioButton16);
        toolsGroupBox.Controls.Add(colorRadioButton15);
        toolsGroupBox.Controls.Add(colorRadioButton14);
        toolsGroupBox.Controls.Add(colorRadioButton13);
        toolsGroupBox.Controls.Add(colorRadioButton12);
        toolsGroupBox.Controls.Add(colorRadioButton11);
        toolsGroupBox.Controls.Add(colorRadioButton10);
        toolsGroupBox.Controls.Add(colorRadioButton9);
        toolsGroupBox.Controls.Add(colorRadioButton8);
        toolsGroupBox.Controls.Add(colorRadioButton7);
        toolsGroupBox.Controls.Add(colorRadioButton6);
        toolsGroupBox.Controls.Add(colorRadioButton5);
        toolsGroupBox.Controls.Add(colorRadioButton4);
        toolsGroupBox.Controls.Add(colorRadioButton3);
        toolsGroupBox.Controls.Add(colorRadioButton2);
        toolsGroupBox.Controls.Add(colorRadioButton1);
        toolsGroupBox.Controls.Add(redoButton);
        toolsGroupBox.Controls.Add(undoButton);
        toolsGroupBox.Controls.Add(penSizeTrackBar);
        toolsGroupBox.Controls.Add(resetButton);
        toolsGroupBox.Location = new Point(12, 24);
        toolsGroupBox.Name = "toolsGroupBox";
        toolsGroupBox.Size = new Size(1250, 120);
        toolsGroupBox.TabIndex = 3;
        toolsGroupBox.TabStop = false;
        // 
        // submitButton
        // 
        submitButton.Location = new Point(1051, 15);
        submitButton.Name = "submitButton";
        submitButton.Size = new Size(175, 88);
        submitButton.TabIndex = 31;
        submitButton.Text = "SUBMIT";
        submitButton.UseVisualStyleBackColor = true;
        submitButton.Click += submitButton_Click;
        // 
        // toolsPanel
        // 
        toolsPanel.BackColor = SystemColors.ControlDark;
        toolsPanel.Controls.Add(eraserButton);
        toolsPanel.Controls.Add(pencilButton);
        toolsPanel.Controls.Add(fillButton);
        toolsPanel.Controls.Add(brushButton);
        toolsPanel.Location = new Point(374, 15);
        toolsPanel.Name = "toolsPanel";
        toolsPanel.Size = new Size(212, 89);
        toolsPanel.TabIndex = 30;
        // 
        // eraserButton
        // 
        eraserButton.AutoSize = true;
        eraserButton.Location = new Point(12, 51);
        eraserButton.Name = "eraserButton";
        eraserButton.Size = new Size(84, 29);
        eraserButton.TabIndex = 30;
        eraserButton.TabStop = true;
        eraserButton.Text = "eraser";
        eraserButton.UseVisualStyleBackColor = true;
        eraserButton.Click += eraserButton_Click;
        // 
        // pencilButton
        // 
        pencilButton.AutoSize = true;
        pencilButton.Location = new Point(12, 11);
        pencilButton.Name = "pencilButton";
        pencilButton.Size = new Size(83, 29);
        pencilButton.TabIndex = 28;
        pencilButton.TabStop = true;
        pencilButton.Text = "pencil";
        pencilButton.UseVisualStyleBackColor = true;
        pencilButton.Click += pencilButton_Click;
        // 
        // fillButton
        // 
        fillButton.AutoSize = true;
        fillButton.Location = new Point(112, 51);
        fillButton.Name = "fillButton";
        fillButton.Size = new Size(90, 29);
        fillButton.TabIndex = 29;
        fillButton.TabStop = true;
        fillButton.Text = "bucket";
        fillButton.UseVisualStyleBackColor = true;
        fillButton.Click += fillButton_Click;
        // 
        // brushButton
        // 
        brushButton.AutoSize = true;
        brushButton.Location = new Point(112, 11);
        brushButton.Name = "brushButton";
        brushButton.Size = new Size(82, 29);
        brushButton.TabIndex = 29;
        brushButton.TabStop = true;
        brushButton.Text = "brush";
        brushButton.UseVisualStyleBackColor = true;
        brushButton.Click += brushButton_Click;
        // 
        // colorRadioButton20
        // 
        colorRadioButton20.Appearance = Appearance.Button;
        colorRadioButton20.AutoSize = true;
        colorRadioButton20.BackColor = Color.Transparent;
        colorRadioButton20.CircleColor = Color.Thistle;
        colorRadioButton20.FlatAppearance.BorderSize = 0;
        colorRadioButton20.FlatStyle = FlatStyle.Flat;
        colorRadioButton20.Location = new Point(956, 66);
        colorRadioButton20.Name = "colorRadioButton20";
        colorRadioButton20.Size = new Size(28, 28);
        colorRadioButton20.TabIndex = 27;
        colorRadioButton20.TabStop = true;
        colorRadioButton20.Text = "colorRadioButton20";
        colorRadioButton20.UseVisualStyleBackColor = false;
        colorRadioButton20.Click += colorRadioButton_Click;
        // 
        // colorRadioButton19
        // 
        colorRadioButton19.Appearance = Appearance.Button;
        colorRadioButton19.AutoSize = true;
        colorRadioButton19.BackColor = Color.Transparent;
        colorRadioButton19.CircleColor = Color.MediumOrchid;
        colorRadioButton19.FlatAppearance.BorderSize = 0;
        colorRadioButton19.FlatStyle = FlatStyle.Flat;
        colorRadioButton19.Location = new Point(956, 30);
        colorRadioButton19.Name = "colorRadioButton19";
        colorRadioButton19.Size = new Size(28, 28);
        colorRadioButton19.TabIndex = 26;
        colorRadioButton19.TabStop = true;
        colorRadioButton19.Text = "colorRadioButton19";
        colorRadioButton19.UseVisualStyleBackColor = false;
        colorRadioButton19.Click += colorRadioButton_Click;
        // 
        // colorRadioButton18
        // 
        colorRadioButton18.Appearance = Appearance.Button;
        colorRadioButton18.AutoSize = true;
        colorRadioButton18.BackColor = Color.Transparent;
        colorRadioButton18.CircleColor = Color.LightSteelBlue;
        colorRadioButton18.FlatAppearance.BorderSize = 0;
        colorRadioButton18.FlatStyle = FlatStyle.Flat;
        colorRadioButton18.Location = new Point(922, 66);
        colorRadioButton18.Name = "colorRadioButton18";
        colorRadioButton18.Size = new Size(28, 28);
        colorRadioButton18.TabIndex = 25;
        colorRadioButton18.TabStop = true;
        colorRadioButton18.Text = "colorRadioButton18";
        colorRadioButton18.UseVisualStyleBackColor = false;
        colorRadioButton18.Click += colorRadioButton_Click;
        // 
        // colorRadioButton17
        // 
        colorRadioButton17.Appearance = Appearance.Button;
        colorRadioButton17.AutoSize = true;
        colorRadioButton17.BackColor = Color.Transparent;
        colorRadioButton17.CircleColor = Color.RoyalBlue;
        colorRadioButton17.FlatAppearance.BorderSize = 0;
        colorRadioButton17.FlatStyle = FlatStyle.Flat;
        colorRadioButton17.Location = new Point(922, 30);
        colorRadioButton17.Name = "colorRadioButton17";
        colorRadioButton17.Size = new Size(28, 28);
        colorRadioButton17.TabIndex = 24;
        colorRadioButton17.TabStop = true;
        colorRadioButton17.Text = "colorRadioButton17";
        colorRadioButton17.UseVisualStyleBackColor = false;
        colorRadioButton17.Click += colorRadioButton_Click;
        // 
        // colorRadioButton16
        // 
        colorRadioButton16.Appearance = Appearance.Button;
        colorRadioButton16.AutoSize = true;
        colorRadioButton16.BackColor = Color.Transparent;
        colorRadioButton16.CircleColor = Color.LightCyan;
        colorRadioButton16.FlatAppearance.BorderSize = 0;
        colorRadioButton16.FlatStyle = FlatStyle.Flat;
        colorRadioButton16.Location = new Point(888, 66);
        colorRadioButton16.Name = "colorRadioButton16";
        colorRadioButton16.Size = new Size(28, 28);
        colorRadioButton16.TabIndex = 23;
        colorRadioButton16.TabStop = true;
        colorRadioButton16.Text = "colorRadioButton16";
        colorRadioButton16.UseVisualStyleBackColor = false;
        colorRadioButton16.Click += colorRadioButton_Click;
        // 
        // colorRadioButton15
        // 
        colorRadioButton15.Appearance = Appearance.Button;
        colorRadioButton15.AutoSize = true;
        colorRadioButton15.BackColor = Color.Transparent;
        colorRadioButton15.CircleColor = Color.DeepSkyBlue;
        colorRadioButton15.FlatAppearance.BorderSize = 0;
        colorRadioButton15.FlatStyle = FlatStyle.Flat;
        colorRadioButton15.Location = new Point(888, 30);
        colorRadioButton15.Name = "colorRadioButton15";
        colorRadioButton15.Size = new Size(28, 28);
        colorRadioButton15.TabIndex = 22;
        colorRadioButton15.TabStop = true;
        colorRadioButton15.Text = "colorRadioButton15";
        colorRadioButton15.UseVisualStyleBackColor = false;
        colorRadioButton15.Click += colorRadioButton_Click;
        // 
        // colorRadioButton14
        // 
        colorRadioButton14.Appearance = Appearance.Button;
        colorRadioButton14.AutoSize = true;
        colorRadioButton14.BackColor = Color.Transparent;
        colorRadioButton14.CircleColor = Color.PaleGreen;
        colorRadioButton14.FlatAppearance.BorderSize = 0;
        colorRadioButton14.FlatStyle = FlatStyle.Flat;
        colorRadioButton14.Location = new Point(854, 66);
        colorRadioButton14.Name = "colorRadioButton14";
        colorRadioButton14.Size = new Size(28, 28);
        colorRadioButton14.TabIndex = 21;
        colorRadioButton14.TabStop = true;
        colorRadioButton14.Text = "colorRadioButton14";
        colorRadioButton14.UseVisualStyleBackColor = false;
        colorRadioButton14.Click += colorRadioButton_Click;
        // 
        // colorRadioButton13
        // 
        colorRadioButton13.Appearance = Appearance.Button;
        colorRadioButton13.AutoSize = true;
        colorRadioButton13.BackColor = Color.Transparent;
        colorRadioButton13.CircleColor = Color.Wheat;
        colorRadioButton13.FlatAppearance.BorderSize = 0;
        colorRadioButton13.FlatStyle = FlatStyle.Flat;
        colorRadioButton13.Location = new Point(820, 66);
        colorRadioButton13.Name = "colorRadioButton13";
        colorRadioButton13.Size = new Size(28, 28);
        colorRadioButton13.TabIndex = 20;
        colorRadioButton13.TabStop = true;
        colorRadioButton13.Text = "colorRadioButton13";
        colorRadioButton13.UseVisualStyleBackColor = false;
        colorRadioButton13.Click += colorRadioButton_Click;
        // 
        // colorRadioButton12
        // 
        colorRadioButton12.Appearance = Appearance.Button;
        colorRadioButton12.AutoSize = true;
        colorRadioButton12.BackColor = Color.Transparent;
        colorRadioButton12.CircleColor = Color.Gold;
        colorRadioButton12.FlatAppearance.BorderSize = 0;
        colorRadioButton12.FlatStyle = FlatStyle.Flat;
        colorRadioButton12.Location = new Point(786, 66);
        colorRadioButton12.Name = "colorRadioButton12";
        colorRadioButton12.Size = new Size(28, 28);
        colorRadioButton12.TabIndex = 19;
        colorRadioButton12.TabStop = true;
        colorRadioButton12.Text = "colorRadioButton12";
        colorRadioButton12.UseVisualStyleBackColor = false;
        colorRadioButton12.Click += colorRadioButton_Click;
        // 
        // colorRadioButton11
        // 
        colorRadioButton11.Appearance = Appearance.Button;
        colorRadioButton11.AutoSize = true;
        colorRadioButton11.BackColor = Color.Transparent;
        colorRadioButton11.CircleColor = Color.HotPink;
        colorRadioButton11.FlatAppearance.BorderSize = 0;
        colorRadioButton11.FlatStyle = FlatStyle.Flat;
        colorRadioButton11.Location = new Point(752, 66);
        colorRadioButton11.Name = "colorRadioButton11";
        colorRadioButton11.Size = new Size(28, 28);
        colorRadioButton11.TabIndex = 18;
        colorRadioButton11.TabStop = true;
        colorRadioButton11.Text = "colorRadioButton11";
        colorRadioButton11.UseVisualStyleBackColor = false;
        colorRadioButton11.Click += colorRadioButton_Click;
        // 
        // colorRadioButton10
        // 
        colorRadioButton10.Appearance = Appearance.Button;
        colorRadioButton10.AutoSize = true;
        colorRadioButton10.BackColor = Color.Transparent;
        colorRadioButton10.CircleColor = Color.SaddleBrown;
        colorRadioButton10.FlatAppearance.BorderSize = 0;
        colorRadioButton10.FlatStyle = FlatStyle.Flat;
        colorRadioButton10.Location = new Point(718, 66);
        colorRadioButton10.Name = "colorRadioButton10";
        colorRadioButton10.Size = new Size(28, 28);
        colorRadioButton10.TabIndex = 17;
        colorRadioButton10.TabStop = true;
        colorRadioButton10.Text = "colorRadioButton10";
        colorRadioButton10.UseVisualStyleBackColor = false;
        colorRadioButton10.Click += colorRadioButton_Click;
        // 
        // colorRadioButton9
        // 
        colorRadioButton9.Appearance = Appearance.Button;
        colorRadioButton9.AutoSize = true;
        colorRadioButton9.BackColor = Color.Transparent;
        colorRadioButton9.CircleColor = Color.LightGray;
        colorRadioButton9.FlatAppearance.BorderSize = 0;
        colorRadioButton9.FlatStyle = FlatStyle.Flat;
        colorRadioButton9.Location = new Point(684, 66);
        colorRadioButton9.Name = "colorRadioButton9";
        colorRadioButton9.Size = new Size(28, 28);
        colorRadioButton9.TabIndex = 16;
        colorRadioButton9.TabStop = true;
        colorRadioButton9.Text = "colorRadioButton9";
        colorRadioButton9.UseVisualStyleBackColor = false;
        colorRadioButton9.Click += colorRadioButton_Click;
        // 
        // colorRadioButton8
        // 
        colorRadioButton8.Appearance = Appearance.Button;
        colorRadioButton8.AutoSize = true;
        colorRadioButton8.BackColor = Color.Transparent;
        colorRadioButton8.CircleColor = Color.LimeGreen;
        colorRadioButton8.FlatAppearance.BorderSize = 0;
        colorRadioButton8.FlatStyle = FlatStyle.Flat;
        colorRadioButton8.Location = new Point(854, 30);
        colorRadioButton8.Name = "colorRadioButton8";
        colorRadioButton8.Size = new Size(28, 28);
        colorRadioButton8.TabIndex = 15;
        colorRadioButton8.TabStop = true;
        colorRadioButton8.Text = "colorRadioButton8";
        colorRadioButton8.UseVisualStyleBackColor = false;
        colorRadioButton8.Click += colorRadioButton_Click;
        // 
        // colorRadioButton7
        // 
        colorRadioButton7.Appearance = Appearance.Button;
        colorRadioButton7.AutoSize = true;
        colorRadioButton7.BackColor = Color.Transparent;
        colorRadioButton7.CircleColor = Color.Yellow;
        colorRadioButton7.FlatAppearance.BorderSize = 0;
        colorRadioButton7.FlatStyle = FlatStyle.Flat;
        colorRadioButton7.Location = new Point(820, 30);
        colorRadioButton7.Name = "colorRadioButton7";
        colorRadioButton7.Size = new Size(28, 28);
        colorRadioButton7.TabIndex = 14;
        colorRadioButton7.TabStop = true;
        colorRadioButton7.Text = "colorRadioButton7";
        colorRadioButton7.UseVisualStyleBackColor = false;
        colorRadioButton7.Click += colorRadioButton_Click;
        // 
        // colorRadioButton6
        // 
        colorRadioButton6.Appearance = Appearance.Button;
        colorRadioButton6.AutoSize = true;
        colorRadioButton6.BackColor = Color.Transparent;
        colorRadioButton6.CircleColor = Color.White;
        colorRadioButton6.FlatAppearance.BorderSize = 0;
        colorRadioButton6.FlatStyle = FlatStyle.Flat;
        colorRadioButton6.Location = new Point(650, 66);
        colorRadioButton6.Name = "colorRadioButton6";
        colorRadioButton6.Size = new Size(28, 28);
        colorRadioButton6.TabIndex = 13;
        colorRadioButton6.TabStop = true;
        colorRadioButton6.Text = "colorRadioButton6";
        colorRadioButton6.UseVisualStyleBackColor = false;
        colorRadioButton6.Click += colorRadioButton_Click;
        // 
        // colorRadioButton5
        // 
        colorRadioButton5.Appearance = Appearance.Button;
        colorRadioButton5.AutoSize = true;
        colorRadioButton5.BackColor = Color.Transparent;
        colorRadioButton5.CircleColor = Color.Orange;
        colorRadioButton5.FlatAppearance.BorderSize = 0;
        colorRadioButton5.FlatStyle = FlatStyle.Flat;
        colorRadioButton5.Location = new Point(786, 30);
        colorRadioButton5.Name = "colorRadioButton5";
        colorRadioButton5.Size = new Size(28, 28);
        colorRadioButton5.TabIndex = 12;
        colorRadioButton5.TabStop = true;
        colorRadioButton5.Text = "colorRadioButton5";
        colorRadioButton5.UseVisualStyleBackColor = false;
        colorRadioButton5.Click += colorRadioButton_Click;
        // 
        // colorRadioButton4
        // 
        colorRadioButton4.Appearance = Appearance.Button;
        colorRadioButton4.AutoSize = true;
        colorRadioButton4.BackColor = Color.Transparent;
        colorRadioButton4.CircleColor = Color.Red;
        colorRadioButton4.FlatAppearance.BorderSize = 0;
        colorRadioButton4.FlatStyle = FlatStyle.Flat;
        colorRadioButton4.Location = new Point(752, 30);
        colorRadioButton4.Name = "colorRadioButton4";
        colorRadioButton4.Size = new Size(28, 28);
        colorRadioButton4.TabIndex = 11;
        colorRadioButton4.TabStop = true;
        colorRadioButton4.Text = "colorRadioButton4";
        colorRadioButton4.UseVisualStyleBackColor = false;
        colorRadioButton4.Click += colorRadioButton_Click;
        // 
        // colorRadioButton3
        // 
        colorRadioButton3.Appearance = Appearance.Button;
        colorRadioButton3.AutoSize = true;
        colorRadioButton3.BackColor = Color.Transparent;
        colorRadioButton3.CircleColor = Color.Brown;
        colorRadioButton3.FlatAppearance.BorderSize = 0;
        colorRadioButton3.FlatStyle = FlatStyle.Flat;
        colorRadioButton3.Location = new Point(718, 30);
        colorRadioButton3.Name = "colorRadioButton3";
        colorRadioButton3.Size = new Size(28, 28);
        colorRadioButton3.TabIndex = 10;
        colorRadioButton3.TabStop = true;
        colorRadioButton3.Text = "colorRadioButton3";
        colorRadioButton3.UseVisualStyleBackColor = false;
        colorRadioButton3.Click += colorRadioButton_Click;
        // 
        // colorRadioButton2
        // 
        colorRadioButton2.Appearance = Appearance.Button;
        colorRadioButton2.AutoSize = true;
        colorRadioButton2.BackColor = Color.Transparent;
        colorRadioButton2.CircleColor = Color.DarkGray;
        colorRadioButton2.FlatAppearance.BorderSize = 0;
        colorRadioButton2.FlatStyle = FlatStyle.Flat;
        colorRadioButton2.Location = new Point(684, 30);
        colorRadioButton2.Name = "colorRadioButton2";
        colorRadioButton2.Size = new Size(28, 28);
        colorRadioButton2.TabIndex = 9;
        colorRadioButton2.TabStop = true;
        colorRadioButton2.Text = "colorRadioButton2";
        colorRadioButton2.UseVisualStyleBackColor = false;
        colorRadioButton2.Click += colorRadioButton_Click;
        // 
        // colorRadioButton1
        // 
        colorRadioButton1.Appearance = Appearance.Button;
        colorRadioButton1.AutoSize = true;
        colorRadioButton1.BackColor = Color.Transparent;
        colorRadioButton1.CircleColor = Color.Black;
        colorRadioButton1.FlatAppearance.BorderSize = 0;
        colorRadioButton1.FlatStyle = FlatStyle.Flat;
        colorRadioButton1.Location = new Point(650, 30);
        colorRadioButton1.Name = "colorRadioButton1";
        colorRadioButton1.Size = new Size(28, 28);
        colorRadioButton1.TabIndex = 8;
        colorRadioButton1.TabStop = true;
        colorRadioButton1.Text = "colorRadioButton1";
        colorRadioButton1.UseVisualStyleBackColor = false;
        colorRadioButton1.Click += colorRadioButton_Click;
        // 
        // redoButton
        // 
        redoButton.Location = new Point(76, 3);
        redoButton.Name = "redoButton";
        redoButton.Size = new Size(59, 34);
        redoButton.TabIndex = 4;
        redoButton.Text = "redo";
        redoButton.UseVisualStyleBackColor = true;
        redoButton.Click += redoButton_Click;
        // 
        // undoButton
        // 
        undoButton.Location = new Point(6, 3);
        undoButton.Name = "undoButton";
        undoButton.Size = new Size(64, 34);
        undoButton.TabIndex = 3;
        undoButton.Text = "undo";
        undoButton.UseVisualStyleBackColor = true;
        undoButton.Click += undoButton_Click;
        // 
        // penSizeTrackBar
        // 
        penSizeTrackBar.LargeChange = 10;
        penSizeTrackBar.Location = new Point(0, 51);
        penSizeTrackBar.Maximum = 201;
        penSizeTrackBar.Minimum = 1;
        penSizeTrackBar.Name = "penSizeTrackBar";
        penSizeTrackBar.Size = new Size(321, 69);
        penSizeTrackBar.SmallChange = 10;
        penSizeTrackBar.TabIndex = 1;
        penSizeTrackBar.TickFrequency = 10;
        penSizeTrackBar.Value = 1;
        penSizeTrackBar.Scroll += penSizeTrackBar_Scroll;
        // 
        // resetButton
        // 
        resetButton.Location = new Point(199, 0);
        resetButton.Name = "resetButton";
        resetButton.Size = new Size(78, 40);
        resetButton.TabIndex = 0;
        resetButton.Text = "CLEAR";
        resetButton.UseVisualStyleBackColor = true;
        resetButton.Click += resetButton_Click;
        // 
        // telestrationsCanvas
        // 
        telestrationsCanvas.BackColor = SystemColors.ScrollBar;
        telestrationsCanvas.CurrentColor = Color.Black;
        telestrationsCanvas.DrawMode = TelestrationsLibrary.Globals.DrawingMode.Draw;
        telestrationsCanvas.Location = new Point(12, 150);
        telestrationsCanvas.Name = "telestrationsCanvas";
        telestrationsCanvas.Size = new Size(1250, 775);
        telestrationsCanvas.SmoothMode = false;
        telestrationsCanvas.TabIndex = 4;
        telestrationsCanvas.TabStop = false;
        telestrationsCanvas.TeleCursor = Cursors.Default;
        // 
        // button1
        // 
        button1.Location = new Point(1006, 38);
        button1.Name = "button1";
        button1.Size = new Size(28, 56);
        button1.TabIndex = 32;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
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
        Load += GameScreen_Load;
        toolsGroupBox.ResumeLayout(false);
        toolsGroupBox.PerformLayout();
        toolsPanel.ResumeLayout(false);
        toolsPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)penSizeTrackBar).EndInit();
        ((System.ComponentModel.ISupportInitialize)telestrationsCanvas).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private GroupBox toolsGroupBox;
    private Button resetButton;
    private TrackBar penSizeTrackBar;
    private Components.TelestrationsPictureBox telestrationsCanvas;
    private Button redoButton;
    private Button undoButton;
    private Components.ColorRadioButton colorRadioButton1;
    private Components.ColorRadioButton colorRadioButton14;
    private Components.ColorRadioButton colorRadioButton13;
    private Components.ColorRadioButton colorRadioButton12;
    private Components.ColorRadioButton colorRadioButton11;
    private Components.ColorRadioButton colorRadioButton10;
    private Components.ColorRadioButton colorRadioButton9;
    private Components.ColorRadioButton colorRadioButton8;
    private Components.ColorRadioButton colorRadioButton7;
    private Components.ColorRadioButton colorRadioButton6;
    private Components.ColorRadioButton colorRadioButton5;
    private Components.ColorRadioButton colorRadioButton4;
    private Components.ColorRadioButton colorRadioButton3;
    private Components.ColorRadioButton colorRadioButton2;
    private Components.ColorRadioButton colorRadioButton20;
    private Components.ColorRadioButton colorRadioButton19;
    private Components.ColorRadioButton colorRadioButton18;
    private Components.ColorRadioButton colorRadioButton17;
    private Components.ColorRadioButton colorRadioButton16;
    private Components.ColorRadioButton colorRadioButton15;
    private RadioButton fillButton;
    private RadioButton pencilButton;
    private RadioButton brushButton;
    private Panel toolsPanel;
    private Button submitButton;
    private RadioButton eraserButton;
    private Button button1;
}