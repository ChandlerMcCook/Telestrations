namespace TelestrationsUI
{
    partial class GameLobbyForm
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
            lobbyListView = new System.Windows.Forms.ListView();
            nameCol = new System.Windows.Forms.ColumnHeader();
            hostCol = new System.Windows.Forms.ColumnHeader();
            membersCol = new System.Windows.Forms.ColumnHeader();
            usernameLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lobbyListView
            // 
            lobbyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { nameCol, hostCol, membersCol });
            lobbyListView.FullRowSelect = true;
            lobbyListView.GridLines = true;
            lobbyListView.Location = new System.Drawing.Point(61, 178);
            lobbyListView.Name = "lobbyListView";
            lobbyListView.Size = new System.Drawing.Size(862, 459);
            lobbyListView.TabIndex = 0;
            lobbyListView.UseCompatibleStateImageBehavior = false;
            lobbyListView.View = System.Windows.Forms.View.Details;
            lobbyListView.SelectedIndexChanged += lobbyListView_SelectedIndexChanged;
            // 
            // nameCol
            // 
            nameCol.Text = "Name";
            nameCol.Width = 200;
            // 
            // hostCol
            // 
            hostCol.Text = "Host";
            hostCol.Width = 200;
            // 
            // membersCol
            // 
            membersCol.Text = "Members";
            membersCol.Width = 200;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(819, 54);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(0, 32);
            usernameLabel.TabIndex = 1;
            // 
            // GameLobbyForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(978, 694);
            Controls.Add(usernameLabel);
            Controls.Add(lobbyListView);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "GameLobbyForm";
            Text = "GameLobbyForm";
            Load += GameLobbyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView lobbyListView;
        private System.Windows.Forms.ColumnHeader GameName;
        private System.Windows.Forms.ColumnHeader hostCol;
        private System.Windows.Forms.ColumnHeader membersCol;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.ColumnHeader nameCol;
    }
}