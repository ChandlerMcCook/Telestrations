﻿namespace Telestrations
{
    partial class SignInForm
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
            signInButton = new System.Windows.Forms.Button();
            goToRegisterButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // userText
            // 
            userText.Location = new System.Drawing.Point(352, 218);
            userText.Margin = new System.Windows.Forms.Padding(5);
            userText.Name = "userText";
            userText.Size = new System.Drawing.Size(381, 39);
            userText.TabIndex = 1;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new System.Drawing.Point(227, 221);
            userLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new System.Drawing.Size(69, 32);
            userLabel.TabIndex = 2;
            userLabel.Text = "user";
            userLabel.Click += userLabel_Click;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new System.Drawing.Point(227, 351);
            passLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(74, 32);
            passLabel.TabIndex = 4;
            passLabel.Text = "pass";
            // 
            // passText
            // 
            passText.Location = new System.Drawing.Point(352, 348);
            passText.Margin = new System.Windows.Forms.Padding(5);
            passText.Name = "passText";
            passText.Size = new System.Drawing.Size(381, 39);
            passText.TabIndex = 3;
            // 
            // signInButton
            // 
            signInButton.Location = new System.Drawing.Point(352, 461);
            signInButton.Name = "signInButton";
            signInButton.Size = new System.Drawing.Size(169, 47);
            signInButton.TabIndex = 5;
            signInButton.Text = "sign in";
            signInButton.UseVisualStyleBackColor = true;
            // 
            // goToRegisterButton
            // 
            goToRegisterButton.Location = new System.Drawing.Point(797, 635);
            goToRegisterButton.Name = "goToRegisterButton";
            goToRegisterButton.Size = new System.Drawing.Size(169, 47);
            goToRegisterButton.TabIndex = 6;
            goToRegisterButton.Text = "register";
            goToRegisterButton.UseVisualStyleBackColor = true;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(978, 694);
            Controls.Add(goToRegisterButton);
            Controls.Add(signInButton);
            Controls.Add(passLabel);
            Controls.Add(passText);
            Controls.Add(userLabel);
            Controls.Add(userText);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "SignInForm";
            Text = "Telestrations";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button goToRegisterButton;
    }
}

