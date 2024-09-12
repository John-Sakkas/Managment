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
            passwordText = new TextBox();
            label1 = new Label();
            loginButton = new Button();
            panel1 = new Panel();
            passwordLabel = new Label();
            usernameText = new TextBox();
            usernameLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // passwordText
            // 
            passwordText.Location = new Point(97, 276);
            passwordText.Multiline = true;
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = '*';
            passwordText.Size = new Size(215, 36);
            passwordText.TabIndex = 3;
            passwordText.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(115, 47);
            label1.Name = "label1";
            label1.Size = new Size(174, 65);
            label1.TabIndex = 4;
            label1.Text = "Sing In";
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.MenuHighlight;
            loginButton.BackgroundImageLayout = ImageLayout.None;
            loginButton.Location = new Point(159, 342);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(101, 52);
            loginButton.TabIndex = 5;
            loginButton.Text = "Submit";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 146);
            panel1.TabIndex = 7;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = SystemColors.Window;
            passwordLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = SystemColors.AppWorkspace;
            passwordLabel.Location = new Point(149, 278);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(111, 32);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Password";
            // 
            // usernameText
            // 
            usernameText.Location = new Point(97, 201);
            usernameText.Multiline = true;
            usernameText.Name = "usernameText";
            usernameText.PasswordChar = '*';
            usernameText.Size = new Size(215, 36);
            usernameText.TabIndex = 9;
            usernameText.TextAlign = HorizontalAlignment.Center;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = SystemColors.Window;
            usernameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = SystemColors.AppWorkspace;
            usernameLabel.Location = new Point(149, 203);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(121, 32);
            usernameLabel.TabIndex = 10;
            usernameLabel.Text = "Username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 483);
            Controls.Add(usernameLabel);
            Controls.Add(usernameText);
            Controls.Add(passwordLabel);
            Controls.Add(panel1);
            Controls.Add(loginButton);
            Controls.Add(passwordText);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox userNameText;
        private TextBox passwordText;
        private Label label1;
        private Button loginButton;
        private Panel panel1;
        private Label passwordLabel;
        private TextBox usernameText;
        private Label usernameLabel;
    }
}
