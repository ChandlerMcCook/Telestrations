using TelestrationsLibrary;

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
        telestrationsCanvas = new TelestrationsUI.Components.TelestrationsPictureBox();
        toolsTableLayoutPanel = new TableLayoutPanel();
        submitButton = new Button();
        brushTableLayoutPanel = new TableLayoutPanel();
        eraserButton = new RadioButton();
        pencilButton = new RadioButton();
        fillButton = new RadioButton();
        brushButton = new RadioButton();
        leftTableLayoutPanel = new TableLayoutPanel();
        penSizeTrackBar = new TrackBar();
        tableLayoutPanel4 = new TableLayoutPanel();
        redoButton = new Button();
        undoButton = new Button();
        resetButton = new Button();
        brushSizeLabel = new Label();
        colorTableLayoutPanel = new TableLayoutPanel();
        colorRadioButton20 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton3 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton19 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton4 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton18 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton5 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton17 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton2 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton15 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton1 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton14 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton9 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton13 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton10 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton12 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton11 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton7 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton8 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton6 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton16 = new TelestrationsUI.Components.ColorRadioButton();
        tableLayoutPanel1 = new TableLayoutPanel();
        guessTextBox = new TextBox();
        zoomLabel = new Label();
        button1 = new Button();
        colorRadioButton21 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton22 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton23 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton24 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton25 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton26 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton27 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton28 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton29 = new TelestrationsUI.Components.ColorRadioButton();
        colorRadioButton30 = new TelestrationsUI.Components.ColorRadioButton();
        ((System.ComponentModel.ISupportInitialize)telestrationsCanvas).BeginInit();
        toolsTableLayoutPanel.SuspendLayout();
        brushTableLayoutPanel.SuspendLayout();
        leftTableLayoutPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)penSizeTrackBar).BeginInit();
        tableLayoutPanel4.SuspendLayout();
        colorTableLayoutPanel.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // telestrationsCanvas
        // 
        telestrationsCanvas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        telestrationsCanvas.BackColor = SystemColors.ScrollBar;
        telestrationsCanvas.DrawMode = Globals.DrawingMode.Draw;
        telestrationsCanvas.Location = new Point(3, 223);
        telestrationsCanvas.Name = "telestrationsCanvas";
        telestrationsCanvas.Readonly = false;
        telestrationsCanvas.Size = new Size(1272, 798);
        telestrationsCanvas.SmoothMode = false;
        telestrationsCanvas.TabIndex = 4;
        telestrationsCanvas.TabStop = false;
        telestrationsCanvas.TeleCursor = Cursors.Default;
        telestrationsCanvas.ZoomLabel = null;
        // 
        // toolsTableLayoutPanel
        // 
        toolsTableLayoutPanel.ColumnCount = 7;
        toolsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
        toolsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        toolsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
        toolsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        toolsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
        toolsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        toolsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
        toolsTableLayoutPanel.Controls.Add(submitButton, 6, 0);
        toolsTableLayoutPanel.Controls.Add(brushTableLayoutPanel, 2, 0);
        toolsTableLayoutPanel.Controls.Add(leftTableLayoutPanel, 0, 0);
        toolsTableLayoutPanel.Controls.Add(colorTableLayoutPanel, 4, 0);
        toolsTableLayoutPanel.Dock = DockStyle.Fill;
        toolsTableLayoutPanel.Location = new Point(3, 103);
        toolsTableLayoutPanel.Name = "toolsTableLayoutPanel";
        toolsTableLayoutPanel.RowCount = 1;
        toolsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        toolsTableLayoutPanel.Size = new Size(1272, 114);
        toolsTableLayoutPanel.TabIndex = 33;
        // 
        // submitButton
        // 
        submitButton.Dock = DockStyle.Fill;
        submitButton.Location = new Point(996, 3);
        submitButton.MaximumSize = new Size(273, 0);
        submitButton.Name = "submitButton";
        submitButton.Size = new Size(273, 108);
        submitButton.TabIndex = 31;
        submitButton.Text = "SUBMIT";
        submitButton.UseVisualStyleBackColor = true;
        submitButton.Click += submitButton_Click;
        // 
        // brushTableLayoutPanel
        // 
        brushTableLayoutPanel.BackColor = SystemColors.ControlDark;
        brushTableLayoutPanel.ColumnCount = 2;
        brushTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.2754822F));
        brushTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.7245178F));
        brushTableLayoutPanel.Controls.Add(eraserButton, 0, 1);
        brushTableLayoutPanel.Controls.Add(pencilButton, 0, 0);
        brushTableLayoutPanel.Controls.Add(fillButton, 1, 1);
        brushTableLayoutPanel.Controls.Add(brushButton, 1, 0);
        brushTableLayoutPanel.Dock = DockStyle.Fill;
        brushTableLayoutPanel.Location = new Point(307, 3);
        brushTableLayoutPanel.Name = "brushTableLayoutPanel";
        brushTableLayoutPanel.RowCount = 2;
        brushTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        brushTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        brushTableLayoutPanel.Size = new Size(305, 108);
        brushTableLayoutPanel.TabIndex = 37;
        // 
        // eraserButton
        // 
        eraserButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        eraserButton.AutoSize = true;
        eraserButton.Location = new Point(34, 57);
        eraserButton.Name = "eraserButton";
        eraserButton.Size = new Size(84, 48);
        eraserButton.TabIndex = 30;
        eraserButton.TabStop = true;
        eraserButton.Text = "eraser";
        eraserButton.UseVisualStyleBackColor = true;
        eraserButton.Click += eraserButton_Click;
        // 
        // pencilButton
        // 
        pencilButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        pencilButton.AutoSize = true;
        pencilButton.Location = new Point(35, 3);
        pencilButton.Name = "pencilButton";
        pencilButton.Size = new Size(83, 48);
        pencilButton.TabIndex = 28;
        pencilButton.TabStop = true;
        pencilButton.Text = "pencil";
        pencilButton.UseVisualStyleBackColor = true;
        pencilButton.Click += pencilButton_Click;
        // 
        // fillButton
        // 
        fillButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        fillButton.AutoSize = true;
        fillButton.Location = new Point(184, 57);
        fillButton.Name = "fillButton";
        fillButton.Size = new Size(90, 48);
        fillButton.TabIndex = 29;
        fillButton.TabStop = true;
        fillButton.Text = "bucket";
        fillButton.UseVisualStyleBackColor = true;
        fillButton.Click += fillButton_Click;
        // 
        // brushButton
        // 
        brushButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        brushButton.AutoSize = true;
        brushButton.Location = new Point(188, 3);
        brushButton.Name = "brushButton";
        brushButton.Size = new Size(82, 48);
        brushButton.TabIndex = 29;
        brushButton.TabStop = true;
        brushButton.Text = "brush";
        brushButton.UseVisualStyleBackColor = true;
        brushButton.Click += brushButton_Click;
        // 
        // leftTableLayoutPanel
        // 
        leftTableLayoutPanel.ColumnCount = 3;
        leftTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        leftTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        leftTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        leftTableLayoutPanel.Controls.Add(penSizeTrackBar, 0, 1);
        leftTableLayoutPanel.Controls.Add(tableLayoutPanel4, 0, 0);
        leftTableLayoutPanel.Controls.Add(resetButton, 2, 0);
        leftTableLayoutPanel.Controls.Add(brushSizeLabel, 1, 0);
        leftTableLayoutPanel.Dock = DockStyle.Fill;
        leftTableLayoutPanel.Location = new Point(3, 3);
        leftTableLayoutPanel.Name = "leftTableLayoutPanel";
        leftTableLayoutPanel.RowCount = 2;
        leftTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        leftTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        leftTableLayoutPanel.Size = new Size(302, 108);
        leftTableLayoutPanel.TabIndex = 34;
        // 
        // penSizeTrackBar
        // 
        leftTableLayoutPanel.SetColumnSpan(penSizeTrackBar, 3);
        penSizeTrackBar.Dock = DockStyle.Fill;
        penSizeTrackBar.LargeChange = 10;
        penSizeTrackBar.Location = new Point(3, 57);
        penSizeTrackBar.Maximum = 201;
        penSizeTrackBar.Minimum = 1;
        penSizeTrackBar.Name = "penSizeTrackBar";
        penSizeTrackBar.Size = new Size(296, 48);
        penSizeTrackBar.SmallChange = 10;
        penSizeTrackBar.TabIndex = 1;
        penSizeTrackBar.TickFrequency = 10;
        penSizeTrackBar.Value = 1;
        penSizeTrackBar.Scroll += penSizeTrackBar_Scroll;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 2;
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.Controls.Add(redoButton, 1, 0);
        tableLayoutPanel4.Controls.Add(undoButton, 0, 0);
        tableLayoutPanel4.Dock = DockStyle.Fill;
        tableLayoutPanel4.Location = new Point(3, 3);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 1;
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel4.Size = new Size(94, 48);
        tableLayoutPanel4.TabIndex = 2;
        // 
        // redoButton
        // 
        redoButton.Dock = DockStyle.Fill;
        redoButton.Location = new Point(50, 3);
        redoButton.Name = "redoButton";
        redoButton.Size = new Size(41, 42);
        redoButton.TabIndex = 4;
        redoButton.Text = "redo";
        redoButton.UseVisualStyleBackColor = true;
        redoButton.Click += redoButton_Click;
        // 
        // undoButton
        // 
        undoButton.Dock = DockStyle.Fill;
        undoButton.Location = new Point(3, 3);
        undoButton.Name = "undoButton";
        undoButton.Size = new Size(41, 42);
        undoButton.TabIndex = 3;
        undoButton.Text = "undo";
        undoButton.UseVisualStyleBackColor = true;
        undoButton.Click += undoButton_Click;
        // 
        // resetButton
        // 
        resetButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        resetButton.Location = new Point(203, 3);
        resetButton.Name = "resetButton";
        resetButton.Size = new Size(96, 48);
        resetButton.TabIndex = 0;
        resetButton.Text = "CLEAR";
        resetButton.UseVisualStyleBackColor = true;
        resetButton.Click += resetButton_Click;
        // 
        // brushSizeLabel
        // 
        brushSizeLabel.Anchor = AnchorStyles.None;
        brushSizeLabel.AutoSize = true;
        brushSizeLabel.BackColor = SystemColors.ActiveCaption;
        brushSizeLabel.Location = new Point(139, 14);
        brushSizeLabel.Name = "brushSizeLabel";
        brushSizeLabel.Size = new Size(22, 25);
        brushSizeLabel.TabIndex = 3;
        brushSizeLabel.Text = "0";
        // 
        // colorTableLayoutPanel
        // 
        colorTableLayoutPanel.ColumnCount = 11;
        colorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
        colorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        colorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        colorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        colorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        colorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        colorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        colorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        colorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        colorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        colorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        colorTableLayoutPanel.Controls.Add(colorRadioButton30, 10, 2);
        colorTableLayoutPanel.Controls.Add(colorRadioButton29, 9, 2);
        colorTableLayoutPanel.Controls.Add(colorRadioButton28, 8, 2);
        colorTableLayoutPanel.Controls.Add(colorRadioButton27, 7, 2);
        colorTableLayoutPanel.Controls.Add(colorRadioButton26, 6, 2);
        colorTableLayoutPanel.Controls.Add(colorRadioButton25, 5, 2);
        colorTableLayoutPanel.Controls.Add(colorRadioButton24, 4, 2);
        colorTableLayoutPanel.Controls.Add(colorRadioButton23, 3, 2);
        colorTableLayoutPanel.Controls.Add(colorRadioButton22, 2, 2);
        colorTableLayoutPanel.Controls.Add(colorRadioButton20, 10, 1);
        colorTableLayoutPanel.Controls.Add(colorRadioButton3, 3, 0);
        colorTableLayoutPanel.Controls.Add(colorRadioButton19, 10, 0);
        colorTableLayoutPanel.Controls.Add(colorRadioButton4, 4, 0);
        colorTableLayoutPanel.Controls.Add(colorRadioButton18, 9, 1);
        colorTableLayoutPanel.Controls.Add(colorRadioButton5, 5, 0);
        colorTableLayoutPanel.Controls.Add(colorRadioButton17, 9, 0);
        colorTableLayoutPanel.Controls.Add(colorRadioButton2, 2, 0);
        colorTableLayoutPanel.Controls.Add(colorRadioButton15, 8, 0);
        colorTableLayoutPanel.Controls.Add(colorRadioButton1, 1, 0);
        colorTableLayoutPanel.Controls.Add(colorRadioButton14, 7, 1);
        colorTableLayoutPanel.Controls.Add(colorRadioButton9, 2, 1);
        colorTableLayoutPanel.Controls.Add(colorRadioButton13, 6, 1);
        colorTableLayoutPanel.Controls.Add(colorRadioButton10, 3, 1);
        colorTableLayoutPanel.Controls.Add(colorRadioButton12, 5, 1);
        colorTableLayoutPanel.Controls.Add(colorRadioButton11, 4, 1);
        colorTableLayoutPanel.Controls.Add(colorRadioButton7, 6, 0);
        colorTableLayoutPanel.Controls.Add(colorRadioButton8, 7, 0);
        colorTableLayoutPanel.Controls.Add(colorRadioButton6, 1, 1);
        colorTableLayoutPanel.Controls.Add(colorRadioButton16, 8, 1);
        colorTableLayoutPanel.Controls.Add(button1, 0, 0);
        colorTableLayoutPanel.Controls.Add(colorRadioButton21, 1, 2);
        colorTableLayoutPanel.Dock = DockStyle.Fill;
        colorTableLayoutPanel.Location = new Point(614, 3);
        colorTableLayoutPanel.MinimumSize = new Size(380, 0);
        colorTableLayoutPanel.Name = "colorTableLayoutPanel";
        colorTableLayoutPanel.RowCount = 3;
        colorTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        colorTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        colorTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        colorTableLayoutPanel.Size = new Size(380, 108);
        colorTableLayoutPanel.TabIndex = 38;
        // 
        // colorRadioButton20
        // 
        colorRadioButton20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton20.Appearance = Appearance.Button;
        colorRadioButton20.AutoSize = true;
        colorRadioButton20.BackColor = Color.Transparent;
        colorRadioButton20.CircleColor = Color.Thistle;
        colorRadioButton20.FlatAppearance.BorderSize = 0;
        colorRadioButton20.FlatStyle = FlatStyle.Flat;
        colorRadioButton20.Location = new Point(349, 38);
        colorRadioButton20.Name = "colorRadioButton20";
        colorRadioButton20.Size = new Size(28, 29);
        colorRadioButton20.TabIndex = 27;
        colorRadioButton20.TabStop = true;
        colorRadioButton20.Text = "colorRadioButton20";
        colorRadioButton20.UseVisualStyleBackColor = false;
        colorRadioButton20.Click += colorRadioButton_Click;
        // 
        // colorRadioButton3
        // 
        colorRadioButton3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton3.Appearance = Appearance.Button;
        colorRadioButton3.AutoSize = true;
        colorRadioButton3.BackColor = Color.Transparent;
        colorRadioButton3.CircleColor = Color.Brown;
        colorRadioButton3.FlatAppearance.BorderSize = 0;
        colorRadioButton3.FlatStyle = FlatStyle.Flat;
        colorRadioButton3.Location = new Point(111, 3);
        colorRadioButton3.Name = "colorRadioButton3";
        colorRadioButton3.Size = new Size(28, 29);
        colorRadioButton3.TabIndex = 10;
        colorRadioButton3.TabStop = true;
        colorRadioButton3.Text = "colorRadioButton3";
        colorRadioButton3.UseVisualStyleBackColor = false;
        colorRadioButton3.Click += colorRadioButton_Click;
        // 
        // colorRadioButton19
        // 
        colorRadioButton19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton19.Appearance = Appearance.Button;
        colorRadioButton19.AutoSize = true;
        colorRadioButton19.BackColor = Color.Transparent;
        colorRadioButton19.CircleColor = Color.MediumOrchid;
        colorRadioButton19.FlatAppearance.BorderSize = 0;
        colorRadioButton19.FlatStyle = FlatStyle.Flat;
        colorRadioButton19.Location = new Point(349, 3);
        colorRadioButton19.Name = "colorRadioButton19";
        colorRadioButton19.Size = new Size(28, 29);
        colorRadioButton19.TabIndex = 26;
        colorRadioButton19.TabStop = true;
        colorRadioButton19.Text = "colorRadioButton19";
        colorRadioButton19.UseVisualStyleBackColor = false;
        colorRadioButton19.Click += colorRadioButton_Click;
        // 
        // colorRadioButton4
        // 
        colorRadioButton4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton4.Appearance = Appearance.Button;
        colorRadioButton4.AutoSize = true;
        colorRadioButton4.BackColor = Color.Transparent;
        colorRadioButton4.CircleColor = Color.Red;
        colorRadioButton4.FlatAppearance.BorderSize = 0;
        colorRadioButton4.FlatStyle = FlatStyle.Flat;
        colorRadioButton4.Location = new Point(145, 3);
        colorRadioButton4.Name = "colorRadioButton4";
        colorRadioButton4.Size = new Size(28, 29);
        colorRadioButton4.TabIndex = 11;
        colorRadioButton4.TabStop = true;
        colorRadioButton4.Text = "colorRadioButton4";
        colorRadioButton4.UseVisualStyleBackColor = false;
        colorRadioButton4.Click += colorRadioButton_Click;
        // 
        // colorRadioButton18
        // 
        colorRadioButton18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton18.Appearance = Appearance.Button;
        colorRadioButton18.AutoSize = true;
        colorRadioButton18.BackColor = Color.Transparent;
        colorRadioButton18.CircleColor = Color.LightSteelBlue;
        colorRadioButton18.FlatAppearance.BorderSize = 0;
        colorRadioButton18.FlatStyle = FlatStyle.Flat;
        colorRadioButton18.Location = new Point(315, 38);
        colorRadioButton18.Name = "colorRadioButton18";
        colorRadioButton18.Size = new Size(28, 29);
        colorRadioButton18.TabIndex = 25;
        colorRadioButton18.TabStop = true;
        colorRadioButton18.Text = "colorRadioButton18";
        colorRadioButton18.UseVisualStyleBackColor = false;
        colorRadioButton18.Click += colorRadioButton_Click;
        // 
        // colorRadioButton5
        // 
        colorRadioButton5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton5.Appearance = Appearance.Button;
        colorRadioButton5.AutoSize = true;
        colorRadioButton5.BackColor = Color.Transparent;
        colorRadioButton5.CircleColor = Color.Orange;
        colorRadioButton5.FlatAppearance.BorderSize = 0;
        colorRadioButton5.FlatStyle = FlatStyle.Flat;
        colorRadioButton5.Location = new Point(179, 3);
        colorRadioButton5.Name = "colorRadioButton5";
        colorRadioButton5.Size = new Size(28, 29);
        colorRadioButton5.TabIndex = 12;
        colorRadioButton5.TabStop = true;
        colorRadioButton5.Text = "colorRadioButton5";
        colorRadioButton5.UseVisualStyleBackColor = false;
        colorRadioButton5.Click += colorRadioButton_Click;
        // 
        // colorRadioButton17
        // 
        colorRadioButton17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton17.Appearance = Appearance.Button;
        colorRadioButton17.AutoSize = true;
        colorRadioButton17.BackColor = Color.Transparent;
        colorRadioButton17.CircleColor = Color.RoyalBlue;
        colorRadioButton17.FlatAppearance.BorderSize = 0;
        colorRadioButton17.FlatStyle = FlatStyle.Flat;
        colorRadioButton17.Location = new Point(315, 3);
        colorRadioButton17.Name = "colorRadioButton17";
        colorRadioButton17.Size = new Size(28, 29);
        colorRadioButton17.TabIndex = 24;
        colorRadioButton17.TabStop = true;
        colorRadioButton17.Text = "colorRadioButton17";
        colorRadioButton17.UseVisualStyleBackColor = false;
        colorRadioButton17.Click += colorRadioButton_Click;
        // 
        // colorRadioButton2
        // 
        colorRadioButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton2.Appearance = Appearance.Button;
        colorRadioButton2.AutoSize = true;
        colorRadioButton2.BackColor = Color.Transparent;
        colorRadioButton2.CircleColor = Color.DarkGray;
        colorRadioButton2.FlatAppearance.BorderSize = 0;
        colorRadioButton2.FlatStyle = FlatStyle.Flat;
        colorRadioButton2.Location = new Point(77, 3);
        colorRadioButton2.Name = "colorRadioButton2";
        colorRadioButton2.Size = new Size(28, 29);
        colorRadioButton2.TabIndex = 9;
        colorRadioButton2.TabStop = true;
        colorRadioButton2.Text = "colorRadioButton2";
        colorRadioButton2.UseVisualStyleBackColor = false;
        colorRadioButton2.Click += colorRadioButton_Click;
        // 
        // colorRadioButton15
        // 
        colorRadioButton15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton15.Appearance = Appearance.Button;
        colorRadioButton15.AutoSize = true;
        colorRadioButton15.BackColor = Color.Transparent;
        colorRadioButton15.CircleColor = Color.DeepSkyBlue;
        colorRadioButton15.FlatAppearance.BorderSize = 0;
        colorRadioButton15.FlatStyle = FlatStyle.Flat;
        colorRadioButton15.Location = new Point(281, 3);
        colorRadioButton15.Name = "colorRadioButton15";
        colorRadioButton15.Size = new Size(28, 29);
        colorRadioButton15.TabIndex = 22;
        colorRadioButton15.TabStop = true;
        colorRadioButton15.Text = "colorRadioButton15";
        colorRadioButton15.UseVisualStyleBackColor = false;
        colorRadioButton15.Click += colorRadioButton_Click;
        // 
        // colorRadioButton1
        // 
        colorRadioButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton1.Appearance = Appearance.Button;
        colorRadioButton1.AutoSize = true;
        colorRadioButton1.BackColor = Color.Transparent;
        colorRadioButton1.CircleColor = Color.Black;
        colorRadioButton1.FlatAppearance.BorderSize = 0;
        colorRadioButton1.FlatStyle = FlatStyle.Flat;
        colorRadioButton1.Location = new Point(43, 3);
        colorRadioButton1.Name = "colorRadioButton1";
        colorRadioButton1.Size = new Size(28, 29);
        colorRadioButton1.TabIndex = 8;
        colorRadioButton1.TabStop = true;
        colorRadioButton1.Text = "colorRadioButton1";
        colorRadioButton1.UseVisualStyleBackColor = false;
        colorRadioButton1.Click += colorRadioButton_Click;
        // 
        // colorRadioButton14
        // 
        colorRadioButton14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton14.Appearance = Appearance.Button;
        colorRadioButton14.AutoSize = true;
        colorRadioButton14.BackColor = Color.Transparent;
        colorRadioButton14.CircleColor = Color.PaleGreen;
        colorRadioButton14.FlatAppearance.BorderSize = 0;
        colorRadioButton14.FlatStyle = FlatStyle.Flat;
        colorRadioButton14.Location = new Point(247, 38);
        colorRadioButton14.Name = "colorRadioButton14";
        colorRadioButton14.Size = new Size(28, 29);
        colorRadioButton14.TabIndex = 21;
        colorRadioButton14.TabStop = true;
        colorRadioButton14.Text = "colorRadioButton14";
        colorRadioButton14.UseVisualStyleBackColor = false;
        colorRadioButton14.Click += colorRadioButton_Click;
        // 
        // colorRadioButton9
        // 
        colorRadioButton9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton9.Appearance = Appearance.Button;
        colorRadioButton9.AutoSize = true;
        colorRadioButton9.BackColor = Color.Transparent;
        colorRadioButton9.CircleColor = Color.LightGray;
        colorRadioButton9.FlatAppearance.BorderSize = 0;
        colorRadioButton9.FlatStyle = FlatStyle.Flat;
        colorRadioButton9.Location = new Point(77, 38);
        colorRadioButton9.Name = "colorRadioButton9";
        colorRadioButton9.Size = new Size(28, 29);
        colorRadioButton9.TabIndex = 16;
        colorRadioButton9.TabStop = true;
        colorRadioButton9.Text = "colorRadioButton9";
        colorRadioButton9.UseVisualStyleBackColor = false;
        colorRadioButton9.Click += colorRadioButton_Click;
        // 
        // colorRadioButton13
        // 
        colorRadioButton13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton13.Appearance = Appearance.Button;
        colorRadioButton13.AutoSize = true;
        colorRadioButton13.BackColor = Color.Transparent;
        colorRadioButton13.CircleColor = Color.Wheat;
        colorRadioButton13.FlatAppearance.BorderSize = 0;
        colorRadioButton13.FlatStyle = FlatStyle.Flat;
        colorRadioButton13.Location = new Point(213, 38);
        colorRadioButton13.Name = "colorRadioButton13";
        colorRadioButton13.Size = new Size(28, 29);
        colorRadioButton13.TabIndex = 20;
        colorRadioButton13.TabStop = true;
        colorRadioButton13.Text = "colorRadioButton13";
        colorRadioButton13.UseVisualStyleBackColor = false;
        colorRadioButton13.Click += colorRadioButton_Click;
        // 
        // colorRadioButton10
        // 
        colorRadioButton10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton10.Appearance = Appearance.Button;
        colorRadioButton10.AutoSize = true;
        colorRadioButton10.BackColor = Color.Transparent;
        colorRadioButton10.CircleColor = Color.SaddleBrown;
        colorRadioButton10.FlatAppearance.BorderSize = 0;
        colorRadioButton10.FlatStyle = FlatStyle.Flat;
        colorRadioButton10.Location = new Point(111, 38);
        colorRadioButton10.Name = "colorRadioButton10";
        colorRadioButton10.Size = new Size(28, 29);
        colorRadioButton10.TabIndex = 17;
        colorRadioButton10.TabStop = true;
        colorRadioButton10.Text = "colorRadioButton10";
        colorRadioButton10.UseVisualStyleBackColor = false;
        colorRadioButton10.Click += colorRadioButton_Click;
        // 
        // colorRadioButton12
        // 
        colorRadioButton12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton12.Appearance = Appearance.Button;
        colorRadioButton12.AutoSize = true;
        colorRadioButton12.BackColor = Color.Transparent;
        colorRadioButton12.CircleColor = Color.Gold;
        colorRadioButton12.FlatAppearance.BorderSize = 0;
        colorRadioButton12.FlatStyle = FlatStyle.Flat;
        colorRadioButton12.Location = new Point(179, 38);
        colorRadioButton12.Name = "colorRadioButton12";
        colorRadioButton12.Size = new Size(28, 29);
        colorRadioButton12.TabIndex = 19;
        colorRadioButton12.TabStop = true;
        colorRadioButton12.Text = "colorRadioButton12";
        colorRadioButton12.UseVisualStyleBackColor = false;
        colorRadioButton12.Click += colorRadioButton_Click;
        // 
        // colorRadioButton11
        // 
        colorRadioButton11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton11.Appearance = Appearance.Button;
        colorRadioButton11.AutoSize = true;
        colorRadioButton11.BackColor = Color.Transparent;
        colorRadioButton11.CircleColor = Color.HotPink;
        colorRadioButton11.FlatAppearance.BorderSize = 0;
        colorRadioButton11.FlatStyle = FlatStyle.Flat;
        colorRadioButton11.Location = new Point(145, 38);
        colorRadioButton11.Name = "colorRadioButton11";
        colorRadioButton11.Size = new Size(28, 29);
        colorRadioButton11.TabIndex = 18;
        colorRadioButton11.TabStop = true;
        colorRadioButton11.Text = "colorRadioButton11";
        colorRadioButton11.UseVisualStyleBackColor = false;
        colorRadioButton11.Click += colorRadioButton_Click;
        // 
        // colorRadioButton7
        // 
        colorRadioButton7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton7.Appearance = Appearance.Button;
        colorRadioButton7.AutoSize = true;
        colorRadioButton7.BackColor = Color.Transparent;
        colorRadioButton7.CircleColor = Color.Yellow;
        colorRadioButton7.FlatAppearance.BorderSize = 0;
        colorRadioButton7.FlatStyle = FlatStyle.Flat;
        colorRadioButton7.Location = new Point(213, 3);
        colorRadioButton7.Name = "colorRadioButton7";
        colorRadioButton7.Size = new Size(28, 29);
        colorRadioButton7.TabIndex = 14;
        colorRadioButton7.TabStop = true;
        colorRadioButton7.Text = "colorRadioButton7";
        colorRadioButton7.UseVisualStyleBackColor = false;
        colorRadioButton7.Click += colorRadioButton_Click;
        // 
        // colorRadioButton8
        // 
        colorRadioButton8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton8.Appearance = Appearance.Button;
        colorRadioButton8.AutoSize = true;
        colorRadioButton8.BackColor = Color.Transparent;
        colorRadioButton8.CircleColor = Color.LimeGreen;
        colorRadioButton8.FlatAppearance.BorderSize = 0;
        colorRadioButton8.FlatStyle = FlatStyle.Flat;
        colorRadioButton8.Location = new Point(247, 3);
        colorRadioButton8.Name = "colorRadioButton8";
        colorRadioButton8.Size = new Size(28, 29);
        colorRadioButton8.TabIndex = 15;
        colorRadioButton8.TabStop = true;
        colorRadioButton8.Text = "colorRadioButton8";
        colorRadioButton8.UseVisualStyleBackColor = false;
        colorRadioButton8.Click += colorRadioButton_Click;
        // 
        // colorRadioButton6
        // 
        colorRadioButton6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton6.Appearance = Appearance.Button;
        colorRadioButton6.AutoSize = true;
        colorRadioButton6.BackColor = Color.Transparent;
        colorRadioButton6.CircleColor = Color.White;
        colorRadioButton6.FlatAppearance.BorderSize = 0;
        colorRadioButton6.FlatStyle = FlatStyle.Flat;
        colorRadioButton6.Location = new Point(43, 38);
        colorRadioButton6.Name = "colorRadioButton6";
        colorRadioButton6.Size = new Size(28, 29);
        colorRadioButton6.TabIndex = 13;
        colorRadioButton6.TabStop = true;
        colorRadioButton6.Text = "colorRadioButton6";
        colorRadioButton6.UseVisualStyleBackColor = false;
        colorRadioButton6.Click += colorRadioButton_Click;
        // 
        // colorRadioButton16
        // 
        colorRadioButton16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        colorRadioButton16.Appearance = Appearance.Button;
        colorRadioButton16.AutoSize = true;
        colorRadioButton16.BackColor = Color.Transparent;
        colorRadioButton16.CircleColor = Color.LightCyan;
        colorRadioButton16.FlatAppearance.BorderSize = 0;
        colorRadioButton16.FlatStyle = FlatStyle.Flat;
        colorRadioButton16.Location = new Point(281, 38);
        colorRadioButton16.Name = "colorRadioButton16";
        colorRadioButton16.Size = new Size(28, 29);
        colorRadioButton16.TabIndex = 23;
        colorRadioButton16.TabStop = true;
        colorRadioButton16.Text = "colorRadioButton16";
        colorRadioButton16.UseVisualStyleBackColor = false;
        colorRadioButton16.Click += colorRadioButton_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(toolsTableLayoutPanel, 0, 1);
        tableLayoutPanel1.Controls.Add(telestrationsCanvas, 0, 2);
        tableLayoutPanel1.Controls.Add(guessTextBox, 0, 0);
        tableLayoutPanel1.Controls.Add(zoomLabel, 0, 3);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(10, 10);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new Size(1278, 1044);
        tableLayoutPanel1.TabIndex = 34;
        // 
        // guessTextBox
        // 
        guessTextBox.Anchor = AnchorStyles.None;
        guessTextBox.Location = new Point(252, 20);
        guessTextBox.MaxLength = 60;
        guessTextBox.Multiline = true;
        guessTextBox.Name = "guessTextBox";
        guessTextBox.Size = new Size(773, 59);
        guessTextBox.TabIndex = 34;
        guessTextBox.TextAlign = HorizontalAlignment.Center;
        // 
        // zoomLabel
        // 
        zoomLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        zoomLabel.AutoSize = true;
        zoomLabel.Location = new Point(1218, 1024);
        zoomLabel.Name = "zoomLabel";
        zoomLabel.Size = new Size(57, 20);
        zoomLabel.TabIndex = 35;
        zoomLabel.Text = "100%";
        // 
        // button1
        // 
        button1.Dock = DockStyle.Fill;
        button1.Location = new Point(3, 3);
        button1.Name = "button1";
        colorTableLayoutPanel.SetRowSpan(button1, 3);
        button1.Size = new Size(34, 102);
        button1.TabIndex = 28;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // colorRadioButton21
        // 
        colorRadioButton21.AutoSize = true;
        colorRadioButton21.BackColor = Color.Transparent;
        colorRadioButton21.CircleColor = Color.Transparent;
        colorRadioButton21.Enabled = false;
        colorRadioButton21.Location = new Point(43, 73);
        colorRadioButton21.Name = "colorRadioButton21";
        colorRadioButton21.Size = new Size(28, 28);
        colorRadioButton21.TabIndex = 29;
        colorRadioButton21.TabStop = true;
        colorRadioButton21.Text = "colorRadioButton21";
        colorRadioButton21.UseVisualStyleBackColor = false;
        // 
        // colorRadioButton22
        // 
        colorRadioButton22.AutoSize = true;
        colorRadioButton22.BackColor = Color.Transparent;
        colorRadioButton22.CircleColor = Color.Transparent;
        colorRadioButton22.Enabled = false;
        colorRadioButton22.Location = new Point(77, 73);
        colorRadioButton22.Name = "colorRadioButton22";
        colorRadioButton22.Size = new Size(28, 28);
        colorRadioButton22.TabIndex = 30;
        colorRadioButton22.TabStop = true;
        colorRadioButton22.Text = "colorRadioButton22";
        colorRadioButton22.UseVisualStyleBackColor = false;
        // 
        // colorRadioButton23
        // 
        colorRadioButton23.AutoSize = true;
        colorRadioButton23.BackColor = Color.Transparent;
        colorRadioButton23.CircleColor = Color.Transparent;
        colorRadioButton23.Enabled = false;
        colorRadioButton23.Location = new Point(111, 73);
        colorRadioButton23.Name = "colorRadioButton23";
        colorRadioButton23.Size = new Size(28, 28);
        colorRadioButton23.TabIndex = 31;
        colorRadioButton23.TabStop = true;
        colorRadioButton23.Text = "colorRadioButton23";
        colorRadioButton23.UseVisualStyleBackColor = false;
        // 
        // colorRadioButton24
        // 
        colorRadioButton24.AutoSize = true;
        colorRadioButton24.BackColor = Color.Transparent;
        colorRadioButton24.CircleColor = Color.Transparent;
        colorRadioButton24.Enabled = false;
        colorRadioButton24.Location = new Point(145, 73);
        colorRadioButton24.Name = "colorRadioButton24";
        colorRadioButton24.Size = new Size(28, 28);
        colorRadioButton24.TabIndex = 32;
        colorRadioButton24.TabStop = true;
        colorRadioButton24.Text = "colorRadioButton24";
        colorRadioButton24.UseVisualStyleBackColor = false;
        // 
        // colorRadioButton25
        // 
        colorRadioButton25.AutoSize = true;
        colorRadioButton25.BackColor = Color.Transparent;
        colorRadioButton25.CircleColor = Color.Transparent;
        colorRadioButton25.Enabled = false;
        colorRadioButton25.Location = new Point(179, 73);
        colorRadioButton25.Name = "colorRadioButton25";
        colorRadioButton25.Size = new Size(28, 28);
        colorRadioButton25.TabIndex = 33;
        colorRadioButton25.TabStop = true;
        colorRadioButton25.Text = "colorRadioButton25";
        colorRadioButton25.UseVisualStyleBackColor = false;
        // 
        // colorRadioButton26
        // 
        colorRadioButton26.AutoSize = true;
        colorRadioButton26.BackColor = Color.Transparent;
        colorRadioButton26.CircleColor = Color.Transparent;
        colorRadioButton26.Enabled = false;
        colorRadioButton26.Location = new Point(213, 73);
        colorRadioButton26.Name = "colorRadioButton26";
        colorRadioButton26.Size = new Size(28, 28);
        colorRadioButton26.TabIndex = 34;
        colorRadioButton26.TabStop = true;
        colorRadioButton26.Text = "colorRadioButton26";
        colorRadioButton26.UseVisualStyleBackColor = false;
        // 
        // colorRadioButton27
        // 
        colorRadioButton27.AutoSize = true;
        colorRadioButton27.BackColor = Color.Transparent;
        colorRadioButton27.CircleColor = Color.Transparent;
        colorRadioButton27.Enabled = false;
        colorRadioButton27.Location = new Point(247, 73);
        colorRadioButton27.Name = "colorRadioButton27";
        colorRadioButton27.Size = new Size(28, 28);
        colorRadioButton27.TabIndex = 35;
        colorRadioButton27.TabStop = true;
        colorRadioButton27.Text = "colorRadioButton27";
        colorRadioButton27.UseVisualStyleBackColor = false;
        // 
        // colorRadioButton28
        // 
        colorRadioButton28.AutoSize = true;
        colorRadioButton28.BackColor = Color.Transparent;
        colorRadioButton28.CircleColor = Color.Transparent;
        colorRadioButton28.Enabled = false;
        colorRadioButton28.Location = new Point(281, 73);
        colorRadioButton28.Name = "colorRadioButton28";
        colorRadioButton28.Size = new Size(28, 28);
        colorRadioButton28.TabIndex = 36;
        colorRadioButton28.TabStop = true;
        colorRadioButton28.Text = "colorRadioButton28";
        colorRadioButton28.UseVisualStyleBackColor = false;
        // 
        // colorRadioButton29
        // 
        colorRadioButton29.AutoSize = true;
        colorRadioButton29.BackColor = Color.Transparent;
        colorRadioButton29.CircleColor = Color.Transparent;
        colorRadioButton29.Enabled = false;
        colorRadioButton29.Location = new Point(315, 73);
        colorRadioButton29.Name = "colorRadioButton29";
        colorRadioButton29.Size = new Size(28, 28);
        colorRadioButton29.TabIndex = 37;
        colorRadioButton29.TabStop = true;
        colorRadioButton29.Text = "colorRadioButton29";
        colorRadioButton29.UseVisualStyleBackColor = false;
        // 
        // colorRadioButton30
        // 
        colorRadioButton30.AutoSize = true;
        colorRadioButton30.BackColor = Color.Transparent;
        colorRadioButton30.CircleColor = Color.Transparent;
        colorRadioButton30.Enabled = false;
        colorRadioButton30.Location = new Point(349, 73);
        colorRadioButton30.Name = "colorRadioButton30";
        colorRadioButton30.Size = new Size(28, 28);
        colorRadioButton30.TabIndex = 38;
        colorRadioButton30.TabStop = true;
        colorRadioButton30.Text = "colorRadioButton30";
        colorRadioButton30.UseVisualStyleBackColor = false;
        // 
        // GameScreen
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(1298, 1064);
        Controls.Add(tableLayoutPanel1);
        KeyPreview = true;
        MinimumSize = new Size(1320, 1120);
        Name = "GameScreen";
        Padding = new Padding(10);
        Text = "GameScreen";
        FormClosed += GameScreen_FormClosed;
        Load += GameScreen_Load;
        KeyDown += GameScreen_KeyDown;
        ((System.ComponentModel.ISupportInitialize)telestrationsCanvas).EndInit();
        toolsTableLayoutPanel.ResumeLayout(false);
        brushTableLayoutPanel.ResumeLayout(false);
        brushTableLayoutPanel.PerformLayout();
        leftTableLayoutPanel.ResumeLayout(false);
        leftTableLayoutPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)penSizeTrackBar).EndInit();
        tableLayoutPanel4.ResumeLayout(false);
        colorTableLayoutPanel.ResumeLayout(false);
        colorTableLayoutPanel.PerformLayout();
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private Components.TelestrationsPictureBox telestrationsCanvas;
    private TableLayoutPanel toolsTableLayoutPanel;
    private Button submitButton;
    private TableLayoutPanel brushTableLayoutPanel;
    private RadioButton eraserButton;
    private RadioButton pencilButton;
    private RadioButton fillButton;
    private RadioButton brushButton;
    private TableLayoutPanel leftTableLayoutPanel;
    private TrackBar penSizeTrackBar;
    private Button resetButton;
    private TableLayoutPanel tableLayoutPanel4;
    private Button redoButton;
    private Button undoButton;
    private TableLayoutPanel colorTableLayoutPanel;
    private Components.ColorRadioButton colorRadioButton20;
    private Components.ColorRadioButton colorRadioButton3;
    private Components.ColorRadioButton colorRadioButton19;
    private Components.ColorRadioButton colorRadioButton4;
    private Components.ColorRadioButton colorRadioButton18;
    private Components.ColorRadioButton colorRadioButton5;
    private Components.ColorRadioButton colorRadioButton17;
    private Components.ColorRadioButton colorRadioButton2;
    private Components.ColorRadioButton colorRadioButton15;
    private Components.ColorRadioButton colorRadioButton1;
    private Components.ColorRadioButton colorRadioButton14;
    private Components.ColorRadioButton colorRadioButton9;
    private Components.ColorRadioButton colorRadioButton13;
    private Components.ColorRadioButton colorRadioButton10;
    private Components.ColorRadioButton colorRadioButton12;
    private Components.ColorRadioButton colorRadioButton11;
    private Components.ColorRadioButton colorRadioButton7;
    private Components.ColorRadioButton colorRadioButton8;
    private Components.ColorRadioButton colorRadioButton6;
    private Components.ColorRadioButton colorRadioButton16;
    private TableLayoutPanel tableLayoutPanel1;
    private TextBox guessTextBox;
    private Label brushSizeLabel;
    private Label zoomLabel;
    private Button button1;
    private Components.ColorRadioButton colorRadioButton21;
    private Components.ColorRadioButton colorRadioButton30;
    private Components.ColorRadioButton colorRadioButton29;
    private Components.ColorRadioButton colorRadioButton28;
    private Components.ColorRadioButton colorRadioButton27;
    private Components.ColorRadioButton colorRadioButton26;
    private Components.ColorRadioButton colorRadioButton25;
    private Components.ColorRadioButton colorRadioButton24;
    private Components.ColorRadioButton colorRadioButton23;
    private Components.ColorRadioButton colorRadioButton22;
}