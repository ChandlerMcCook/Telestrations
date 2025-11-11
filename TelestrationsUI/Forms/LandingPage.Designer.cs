namespace TelestrationsUI
{
    partial class LandingPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hostGameGroupBox = new GroupBox();
            label1 = new Label();
            gameNameTextBox = new TextBox();
            createGameButton = new Button();
            joinGameGroupBox = new GroupBox();
            refreshButton = new Button();
            gamesDataGrid = new DataGridView();
            hostGameGroupBox.SuspendLayout();
            joinGameGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gamesDataGrid).BeginInit();
            SuspendLayout();
            // 
            // hostGameGroupBox
            // 
            hostGameGroupBox.BackColor = SystemColors.ControlLight;
            hostGameGroupBox.Controls.Add(label1);
            hostGameGroupBox.Controls.Add(gameNameTextBox);
            hostGameGroupBox.Controls.Add(createGameButton);
            hostGameGroupBox.Location = new Point(45, 29);
            hostGameGroupBox.Name = "hostGameGroupBox";
            hostGameGroupBox.Size = new Size(1182, 195);
            hostGameGroupBox.TabIndex = 0;
            hostGameGroupBox.TabStop = false;
            hostGameGroupBox.Text = "Host a Game";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 48);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 2;
            label1.Text = "Game Name";
            // 
            // gameNameTextBox
            // 
            gameNameTextBox.Location = new Point(310, 90);
            gameNameTextBox.Name = "gameNameTextBox";
            gameNameTextBox.Size = new Size(319, 31);
            gameNameTextBox.TabIndex = 1;
            gameNameTextBox.KeyDown += gameNameTextBox_KeyDown;
            // 
            // createGameButton
            // 
            createGameButton.Location = new Point(676, 83);
            createGameButton.Name = "createGameButton";
            createGameButton.Size = new Size(125, 45);
            createGameButton.TabIndex = 0;
            createGameButton.Text = "Create Game";
            createGameButton.UseVisualStyleBackColor = true;
            createGameButton.Click += createGameButton_Click;
            // 
            // joinGameGroupBox
            // 
            joinGameGroupBox.BackColor = SystemColors.ControlLight;
            joinGameGroupBox.Controls.Add(refreshButton);
            joinGameGroupBox.Controls.Add(gamesDataGrid);
            joinGameGroupBox.Location = new Point(45, 286);
            joinGameGroupBox.Name = "joinGameGroupBox";
            joinGameGroupBox.Size = new Size(1182, 623);
            joinGameGroupBox.TabIndex = 1;
            joinGameGroupBox.TabStop = false;
            joinGameGroupBox.Text = "Join a Game";
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(1007, 9);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(112, 32);
            refreshButton.TabIndex = 1;
            refreshButton.Text = "refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // gamesDataGrid
            // 
            gamesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gamesDataGrid.Location = new Point(32, 47);
            gamesDataGrid.Name = "gamesDataGrid";
            gamesDataGrid.RowHeadersWidth = 62;
            gamesDataGrid.Size = new Size(1123, 553);
            gamesDataGrid.TabIndex = 0;
            gamesDataGrid.CellContentClick += gamesDataGrid_CellContentClick;
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 944);
            Controls.Add(joinGameGroupBox);
            Controls.Add(hostGameGroupBox);
            Name = "LandingPage";
            Text = "Pick a Game";
            FormClosed += LandingPage_FormClosed;
            hostGameGroupBox.ResumeLayout(false);
            hostGameGroupBox.PerformLayout();
            joinGameGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gamesDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox hostGameGroupBox;
        private GroupBox joinGameGroupBox;
        private DataGridView gamesDataGrid;
        private Label label1;
        private TextBox gameNameTextBox;
        private Button createGameButton;
        private Button refreshButton;
    }
}
