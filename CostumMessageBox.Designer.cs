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
            components = new System.ComponentModel.Container();
            messageBox = new Label();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            errorInfo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorInfo).BeginInit();
            SuspendLayout();
            // 
            // messageBox
            // 
            messageBox.AutoSize = true;
            messageBox.Font = new Font("Segoe UI", 12F);
            messageBox.Location = new Point(66, 25);
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(94, 21);
            messageBox.TabIndex = 0;
            messageBox.Text = "Successfully";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.success;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // errorInfo
            // 
            errorInfo.Image = Properties.Resources.icons8_info_48;
            errorInfo.Location = new Point(166, 25);
            errorInfo.Name = "errorInfo";
            errorInfo.Size = new Size(25, 23);
            errorInfo.SizeMode = PictureBoxSizeMode.Zoom;
            errorInfo.TabIndex = 2;
            errorInfo.TabStop = false;
            // 
            // CostumMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 80);
            Controls.Add(errorInfo);
            Controls.Add(pictureBox1);
            Controls.Add(messageBox);
            Name = "CostumMessageBox";
            Text = "Successully";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label messageBox;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private PictureBox errorInfo;
    }
}