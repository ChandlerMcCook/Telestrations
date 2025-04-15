namespace TelestrationsUI
{
    partial class RegistrationForm
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
            userText = new System.Windows.Forms.TextBox();
            userLabel = new System.Windows.Forms.Label();
            passLabel = new System.Windows.Forms.Label();
            passText = new System.Windows.Forms.TextBox();
            registerButton = new System.Windows.Forms.Button();
            goToSignInButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // userText
            // 
            userText.Location = new System.Drawing.Point(359, 222);
            userText.Name = "userText";
            userText.Size = new System.Drawing.Size(381, 39);
            userText.TabIndex = 0;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new System.Drawing.Point(220, 225);
            userLabel.Name = "userLabel";
            userLabel.Size = new System.Drawing.Size(92, 32);
            userLabel.TabIndex = 1;
            userLabel.Text = "label1";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new System.Drawing.Point(220, 346);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(92, 32);
            passLabel.TabIndex = 3;
            passLabel.Text = "label2";
            // 
            // passText
            // 
            passText.Location = new System.Drawing.Point(359, 343);
            passText.Name = "passText";
            passText.Size = new System.Drawing.Size(381, 39);
            passText.TabIndex = 2;
            // 
            // registerButton
            // 
            registerButton.Location = new System.Drawing.Point(359, 455);
            registerButton.Name = "registerButton";
            registerButton.Size = new System.Drawing.Size(152, 39);
            registerButton.TabIndex = 4;
            registerButton.Text = "register";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // goToSignInButton
            // 
            goToSignInButton.Location = new System.Drawing.Point(789, 621);
            goToSignInButton.Name = "goToSignInButton";
            goToSignInButton.Size = new System.Drawing.Size(144, 50);
            goToSignInButton.TabIndex = 5;
            goToSignInButton.Text = "sign in";
            goToSignInButton.UseVisualStyleBackColor = true;
            // 
            // LobbyScreenForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(978, 694);
            Controls.Add(goToSignInButton);
            Controls.Add(registerButton);
            Controls.Add(passLabel);
            Controls.Add(passText);
            Controls.Add(userLabel);
            Controls.Add(userText);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "LobbyScreenForm";
            Text = "LobbyScreenForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button goToSignInButton;
    }
}