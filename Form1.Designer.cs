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
            label1 = new Label();
            loginButton = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            passwordText = new TextBox();
            usernameText = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(83, 47);
            label1.Name = "label1";
            label1.Size = new Size(174, 65);
            label1.TabIndex = 4;
            label1.Text = "Sing In";
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.None;
            loginButton.BackColor = SystemColors.MenuHighlight;
            loginButton.BackgroundImageLayout = ImageLayout.None;
            loginButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.Location = new Point(117, 193);
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 146);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.MenuHighlight;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(311, 9);
            label2.Name = "label2";
            label2.Size = new Size(24, 25);
            label2.TabIndex = 5;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(passwordText);
            panel2.Controls.Add(usernameText);
            panel2.Controls.Add(loginButton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 337);
            panel2.TabIndex = 11;
            // 
            // passwordText
            // 
            passwordText.Anchor = AnchorStyles.None;
            passwordText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordText.ForeColor = Color.LightGray;
            passwordText.Location = new Point(52, 120);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(242, 33);
            passwordText.TabIndex = 7;
            passwordText.Text = "Password";
            passwordText.TextAlign = HorizontalAlignment.Center;
            passwordText.Enter += passwordText_Enter;
            passwordText.Leave += passwordText_Leave;
            // 
            // usernameText
            // 
            usernameText.Anchor = AnchorStyles.None;
            usernameText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameText.ForeColor = Color.LightGray;
            usernameText.Location = new Point(52, 52);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(242, 33);
            usernameText.TabIndex = 6;
            usernameText.Text = "Username";
            usernameText.TextAlign = HorizontalAlignment.Center;
            usernameText.Enter += usernameText_Enter;
            usernameText.Leave += usernameText_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 483);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox userNameText;
        private Label label1;
        private Button loginButton;
        private Panel panel1;
        private Panel panel2;
        private TextBox usernameText;
        private TextBox passwordText;
        private Label label2;
    }
}
