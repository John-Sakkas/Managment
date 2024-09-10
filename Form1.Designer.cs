namespace Managment
{
    partial class Form1
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
            UsernameLabel = new Label();
            userNameText = new TextBox();
            PasswordLabel = new Label();
            passwordText = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameLabel.Location = new Point(252, 149);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(136, 37);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username";
            // 
            // userNameText
            // 
            userNameText.Location = new Point(211, 189);
            userNameText.Name = "userNameText";
            userNameText.Size = new Size(215, 23);
            userNameText.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(252, 215);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(128, 37);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password";
            // 
            // passwordText
            // 
            passwordText.Location = new Point(211, 255);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(215, 23);
            passwordText.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(211, 43);
            label1.Name = "label1";
            label1.Size = new Size(224, 65);
            label1.TabIndex = 4;
            label1.Text = "Welcome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 356);
            Controls.Add(label1);
            Controls.Add(passwordText);
            Controls.Add(PasswordLabel);
            Controls.Add(userNameText);
            Controls.Add(UsernameLabel);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UsernameLabel;
        private TextBox userNameText;
        private Label PasswordLabel;
        private TextBox passwordText;
        private Label label1;
    }
}
