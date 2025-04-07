namespace Telestrations
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
            this.userText = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.goToRegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(352, 218);
            this.userText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(381, 39);
            this.userText.TabIndex = 1;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(227, 221);
            this.userLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(69, 32);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "user";
            this.userLabel.Click += new System.EventHandler(this.userLabel_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(227, 351);
            this.passLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(74, 32);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "pass";
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(352, 348);
            this.passText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(381, 39);
            this.passText.TabIndex = 3;
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(352, 461);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(169, 47);
            this.signInButton.TabIndex = 5;
            this.signInButton.Text = "sign in";
            this.signInButton.UseVisualStyleBackColor = true;
            // 
            // goToRegisterButton
            // 
            this.goToRegisterButton.Location = new System.Drawing.Point(797, 635);
            this.goToRegisterButton.Name = "goToRegisterButton";
            this.goToRegisterButton.Size = new System.Drawing.Size(169, 47);
            this.goToRegisterButton.TabIndex = 6;
            this.goToRegisterButton.Text = "register";
            this.goToRegisterButton.UseVisualStyleBackColor = true;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.goToRegisterButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.userText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "SignInForm";
            this.Text = "Telestrations";
            this.ResumeLayout(false);
            this.PerformLayout();

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

