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
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            errorMessage = new Label();
            passwordText = new CustomPanelWithTextBox();
            usernameText = new CustomPanelWithTextBox();
            customToolbox1 = new CustomPanel();
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
            label1.Location = new Point(83, 41);
            label1.Name = "label1";
            label1.Size = new Size(174, 65);
            label1.TabIndex = 4;
            label1.Text = "Sing In";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
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
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(156, 293);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 5;
            label2.Text = "Exit";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(errorMessage);
            panel2.Controls.Add(passwordText);
            panel2.Controls.Add(usernameText);
            panel2.Controls.Add(customToolbox1);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 337);
            panel2.TabIndex = 11;
            // 
            // errorMessage
            // 
            errorMessage.AutoSize = true;
            errorMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorMessage.ForeColor = Color.IndianRed;
            errorMessage.Location = new Point(55, 181);
            errorMessage.Name = "errorMessage";
            errorMessage.Size = new Size(0, 21);
            errorMessage.TabIndex = 13;
            // 
            // passwordText
            // 
            passwordText.BackColor = Color.Transparent;
            passwordText.BorderRadius = 30;
            passwordText.CustomPasswordChar = '*';
            passwordText.CustomText = "Password";
            passwordText.CustomTextColor = Color.LightGray;
            passwordText.DefaultColor = Color.White;
            passwordText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordText.ForeColor = Color.Black;
            passwordText.GradientAngle = 90F;
            passwordText.Location = new Point(55, 111);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(236, 53);
            passwordText.TabIndex = 12;
            passwordText.Enter += passwordText_Enter;
            passwordText.Leave += passwordText_Leave;
            // 
            // usernameText
            // 
            usernameText.BackColor = Color.Transparent;
            usernameText.BorderRadius = 30;
            usernameText.CustomPasswordChar = '\0';
            usernameText.CustomText = "Username";
            usernameText.CustomTextColor = Color.LightGray;
            usernameText.DefaultColor = Color.White;
            usernameText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameText.ForeColor = Color.Black;
            usernameText.GradientAngle = 90F;
            usernameText.Location = new Point(55, 41);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(236, 53);
            usernameText.TabIndex = 11;
            usernameText.Enter += usernameText_Enter;
            usernameText.Leave += usernameText_Leave;
            // 
            // customToolbox1
            // 
            customToolbox1.BackColor = Color.Transparent;
            customToolbox1.BorderRadius = 30;
            customToolbox1.ClickedColor = Color.FromArgb(24, 116, 205);
            customToolbox1.DefaultColor = Color.DodgerBlue;
            customToolbox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customToolbox1.ForeColor = Color.Black;
            customToolbox1.HoverColor = Color.FromArgb(28, 134, 238);
            customToolbox1.Location = new Point(95, 220);
            customToolbox1.Name = "customToolbox1";
            customToolbox1.PanelText = "Submit";
            customToolbox1.Size = new Size(162, 62);
            customToolbox1.TabIndex = 10;
            customToolbox1.Click += loginButton_Click;
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
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private CustomPanel customToolbox1;
        private CustomPanelWithTextBox usernameText;
        private CustomPanelWithTextBox passwordText;
        private Label errorMessage;
    }
}
