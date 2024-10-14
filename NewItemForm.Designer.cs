namespace Managment
{
    partial class NewItemForm
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
            sumbitButton = new Button();
            cancelButton = new Button();
            comboBox1 = new ComboBox();
            itemCategory = new Label();
            fabricPanel = new Panel();
            label8 = new Label();
            fabricName = new TextBox();
            label9 = new Label();
            fabricMeter = new TextBox();
            basePanel = new Panel();
            label1 = new Label();
            itemName = new TextBox();
            label2 = new Label();
            itemDimensionX = new TextBox();
            label7 = new Label();
            itemQuantity = new TextBox();
            itemDimensionY = new TextBox();
            label10 = new Label();
            fabricPanel.SuspendLayout();
            basePanel.SuspendLayout();
            SuspendLayout();
            // 
            // sumbitButton
            // 
            sumbitButton.Location = new Point(80, 291);
            sumbitButton.Name = "sumbitButton";
            sumbitButton.Size = new Size(112, 46);
            sumbitButton.TabIndex = 0;
            sumbitButton.Text = "Submit";
            sumbitButton.UseVisualStyleBackColor = true;
            sumbitButton.Click += sumbitButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(198, 291);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 46);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bases", "Mattress", "Fabric" });
            comboBox1.Location = new Point(162, 14);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // itemCategory
            // 
            itemCategory.AutoSize = true;
            itemCategory.Font = new Font("Segoe UI", 14F);
            itemCategory.Location = new Point(12, 9);
            itemCategory.Name = "itemCategory";
            itemCategory.Size = new Size(144, 25);
            itemCategory.TabIndex = 3;
            itemCategory.Text = "Item Category : ";
            // 
            // fabricPanel
            // 
            fabricPanel.Controls.Add(label8);
            fabricPanel.Controls.Add(fabricName);
            fabricPanel.Controls.Add(label9);
            fabricPanel.Controls.Add(fabricMeter);
            fabricPanel.Location = new Point(41, 83);
            fabricPanel.Name = "fabricPanel";
            fabricPanel.Size = new Size(305, 156);
            fabricPanel.TabIndex = 16;
            fabricPanel.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 25);
            label8.Name = "label8";
            label8.Size = new Size(94, 21);
            label8.TabIndex = 1;
            label8.Text = "Item Name :";
            // 
            // fabricName
            // 
            fabricName.Location = new Point(143, 23);
            fabricName.Name = "fabricName";
            fabricName.Size = new Size(143, 23);
            fabricName.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 68);
            label9.Name = "label9";
            label9.Size = new Size(100, 21);
            label9.TabIndex = 3;
            label9.Text = "Item Meters :";
            // 
            // fabricMeter
            // 
            fabricMeter.Location = new Point(143, 68);
            fabricMeter.Name = "fabricMeter";
            fabricMeter.Size = new Size(57, 23);
            fabricMeter.TabIndex = 4;
            // 
            // basePanel
            // 
            basePanel.Controls.Add(label1);
            basePanel.Controls.Add(itemName);
            basePanel.Controls.Add(label2);
            basePanel.Controls.Add(itemDimensionX);
            basePanel.Controls.Add(label7);
            basePanel.Controls.Add(itemQuantity);
            basePanel.Controls.Add(itemDimensionY);
            basePanel.Controls.Add(label10);
            basePanel.Enabled = false;
            basePanel.Location = new Point(41, 83);
            basePanel.Name = "basePanel";
            basePanel.Size = new Size(312, 172);
            basePanel.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 25);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 1;
            label1.Text = "Item Name :";
            // 
            // itemName
            // 
            itemName.Location = new Point(143, 23);
            itemName.Name = "itemName";
            itemName.Size = new Size(143, 23);
            itemName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 68);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 3;
            label2.Text = "Item Dimensions :";
            // 
            // itemDimensionX
            // 
            itemDimensionX.Location = new Point(143, 68);
            itemDimensionX.Name = "itemDimensionX";
            itemDimensionX.Size = new Size(57, 23);
            itemDimensionX.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(206, 70);
            label7.Name = "label7";
            label7.Size = new Size(17, 21);
            label7.TabIndex = 5;
            label7.Text = "x";
            // 
            // itemQuantity
            // 
            itemQuantity.Location = new Point(143, 109);
            itemQuantity.Name = "itemQuantity";
            itemQuantity.Size = new Size(143, 23);
            itemQuantity.TabIndex = 8;
            // 
            // itemDimensionY
            // 
            itemDimensionY.Location = new Point(229, 68);
            itemDimensionY.Name = "itemDimensionY";
            itemDimensionY.Size = new Size(57, 23);
            itemDimensionY.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 111);
            label10.Name = "label10";
            label10.Size = new Size(112, 21);
            label10.TabIndex = 7;
            label10.Text = "Item Quantity :";
            // 
            // NewItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 385);
            Controls.Add(basePanel);
            Controls.Add(fabricPanel);
            Controls.Add(itemCategory);
            Controls.Add(comboBox1);
            Controls.Add(cancelButton);
            Controls.Add(sumbitButton);
            Name = "NewItemForm";
            Text = "NewItemForm";
            fabricPanel.ResumeLayout(false);
            fabricPanel.PerformLayout();
            basePanel.ResumeLayout(false);
            basePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sumbitButton;
        private Button cancelButton;
        private ComboBox comboBox1;
        private Label itemCategory;
        private Panel fabricPanel;
        private Label label8;
        private TextBox fabricName;
        private Label label9;
        private TextBox fabricMeter;
        private Panel basePanel;
        private Label label1;
        private TextBox itemName;
        private Label label2;
        private TextBox itemDimensionX;
        private Label label7;
        private TextBox itemQuantity;
        private TextBox itemDimensionY;
        private Label label10;
    }
}