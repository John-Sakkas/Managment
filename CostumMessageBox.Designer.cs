namespace Managment
{
    partial class CostumMessageBox
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
            messageBox = new Label();
            SuspendLayout();
            // 
            // messageBox
            // 
            messageBox.AutoSize = true;
            messageBox.Font = new Font("Segoe UI", 12F);
            messageBox.Location = new Point(150, 21);
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(130, 21);
            messageBox.TabIndex = 0;
            messageBox.Text = "Message Box Text";
            // 
            // CostumMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 149);
            Controls.Add(messageBox);
            Name = "CostumMessageBox";
            Text = "CostumMessageBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label messageBox;
    }
}