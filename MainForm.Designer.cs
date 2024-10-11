namespace Managment
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            sideBarMenu = new FlowLayoutPanel();
            itemMenu = new FlowLayoutPanel();
            itemContainer = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            itemOption = new Button();
            basesSubContainer = new Panel();
            basesSubOption = new Button();
            mattressSubContainer = new Panel();
            mattressSubOption = new Button();
            fabricSubContainer = new Panel();
            fabricsSubOption = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            itemMenuTransition = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            sideBarToggle = new Button();
            sideBar = new System.Windows.Forms.Timer(components);
            dataGridView1 = new DataGridView();
            editButton = new Button();
            deleteButton = new Button();
            clearSelection = new Button();
            newItem = new Button();
            itemPanel = new Panel();
            sideBarMenu.SuspendLayout();
            itemMenu.SuspendLayout();
            itemContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            basesSubContainer.SuspendLayout();
            mattressSubContainer.SuspendLayout();
            fabricSubContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            itemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(547, 214);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(610, 214);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // sideBarMenu
            // 
            sideBarMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sideBarMenu.BackColor = Color.DodgerBlue;
            sideBarMenu.Controls.Add(itemMenu);
            sideBarMenu.Controls.Add(panel1);
            sideBarMenu.Location = new Point(0, 40);
            sideBarMenu.Name = "sideBarMenu";
            sideBarMenu.Size = new Size(191, 576);
            sideBarMenu.TabIndex = 2;
            // 
            // itemMenu
            // 
            itemMenu.BackColor = Color.LightSkyBlue;
            itemMenu.Controls.Add(itemContainer);
            itemMenu.Controls.Add(basesSubContainer);
            itemMenu.Controls.Add(mattressSubContainer);
            itemMenu.Controls.Add(fabricSubContainer);
            itemMenu.Location = new Point(3, 3);
            itemMenu.Name = "itemMenu";
            itemMenu.Size = new Size(215, 50);
            itemMenu.TabIndex = 5;
            // 
            // itemContainer
            // 
            itemContainer.BackColor = Color.DodgerBlue;
            itemContainer.Controls.Add(pictureBox3);
            itemContainer.Controls.Add(pictureBox1);
            itemContainer.Controls.Add(itemOption);
            itemContainer.Location = new Point(0, 0);
            itemContainer.Margin = new Padding(0);
            itemContainer.Name = "itemContainer";
            itemContainer.Size = new Size(215, 52);
            itemContainer.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(147, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // itemOption
            // 
            itemOption.BackColor = Color.DodgerBlue;
            itemOption.DialogResult = DialogResult.No;
            itemOption.FlatAppearance.MouseDownBackColor = Color.SkyBlue;
            itemOption.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            itemOption.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemOption.ImageAlign = ContentAlignment.MiddleLeft;
            itemOption.Location = new Point(-9, -11);
            itemOption.Name = "itemOption";
            itemOption.Padding = new Padding(15, 0, 0, 0);
            itemOption.Size = new Size(203, 73);
            itemOption.TabIndex = 0;
            itemOption.Text = "Items";
            itemOption.UseVisualStyleBackColor = false;
            itemOption.Click += button2_Click;
            // 
            // basesSubContainer
            // 
            basesSubContainer.BackColor = Color.DodgerBlue;
            basesSubContainer.Controls.Add(basesSubOption);
            basesSubContainer.Location = new Point(3, 55);
            basesSubContainer.Name = "basesSubContainer";
            basesSubContainer.Size = new Size(215, 52);
            basesSubContainer.TabIndex = 6;
            // 
            // basesSubOption
            // 
            basesSubOption.BackColor = Color.LightSkyBlue;
            basesSubOption.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            basesSubOption.Image = (Image)resources.GetObject("basesSubOption.Image");
            basesSubOption.ImageAlign = ContentAlignment.MiddleLeft;
            basesSubOption.Location = new Point(-9, -11);
            basesSubOption.Name = "basesSubOption";
            basesSubOption.Padding = new Padding(40, 0, 0, 0);
            basesSubOption.Size = new Size(233, 73);
            basesSubOption.TabIndex = 0;
            basesSubOption.Text = "Bases";
            basesSubOption.UseVisualStyleBackColor = false;
            basesSubOption.Click += basesSubOption_Click;
            // 
            // mattressSubContainer
            // 
            mattressSubContainer.BackColor = Color.DodgerBlue;
            mattressSubContainer.Controls.Add(mattressSubOption);
            mattressSubContainer.Location = new Point(3, 113);
            mattressSubContainer.Name = "mattressSubContainer";
            mattressSubContainer.Size = new Size(215, 52);
            mattressSubContainer.TabIndex = 7;
            // 
            // mattressSubOption
            // 
            mattressSubOption.BackColor = Color.LightSkyBlue;
            mattressSubOption.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mattressSubOption.Image = (Image)resources.GetObject("mattressSubOption.Image");
            mattressSubOption.ImageAlign = ContentAlignment.MiddleLeft;
            mattressSubOption.Location = new Point(-9, -11);
            mattressSubOption.Name = "mattressSubOption";
            mattressSubOption.Padding = new Padding(40, 0, 0, 0);
            mattressSubOption.Size = new Size(233, 73);
            mattressSubOption.TabIndex = 0;
            mattressSubOption.Text = "Mattress";
            mattressSubOption.UseVisualStyleBackColor = false;
            mattressSubOption.Click += mattressSubOption_Click;
            // 
            // fabricSubContainer
            // 
            fabricSubContainer.BackColor = Color.DodgerBlue;
            fabricSubContainer.Controls.Add(fabricsSubOption);
            fabricSubContainer.Location = new Point(3, 171);
            fabricSubContainer.Name = "fabricSubContainer";
            fabricSubContainer.Size = new Size(215, 52);
            fabricSubContainer.TabIndex = 8;
            // 
            // fabricsSubOption
            // 
            fabricsSubOption.BackColor = Color.LightSkyBlue;
            fabricsSubOption.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fabricsSubOption.Image = (Image)resources.GetObject("fabricsSubOption.Image");
            fabricsSubOption.ImageAlign = ContentAlignment.MiddleLeft;
            fabricsSubOption.Location = new Point(-9, -11);
            fabricsSubOption.Name = "fabricsSubOption";
            fabricsSubOption.Padding = new Padding(40, 0, 0, 0);
            fabricsSubOption.Size = new Size(233, 73);
            fabricsSubOption.TabIndex = 0;
            fabricsSubOption.Text = "Fabrics";
            fabricsSubOption.UseVisualStyleBackColor = false;
            fabricsSubOption.Click += fabricsSubOption_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 52);
            panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.DialogResult = DialogResult.No;
            button1.FlatAppearance.MouseDownBackColor = Color.SkyBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-9, -11);
            button1.Name = "button1";
            button1.Size = new Size(233, 73);
            button1.TabIndex = 0;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // itemMenuTransition
            // 
            itemMenuTransition.Interval = 10;
            itemMenuTransition.Tick += itemMenuTransition_Tick;
            // 
            // panel2
            // 
            panel2.Controls.Add(sideBarToggle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1018, 41);
            panel2.TabIndex = 3;
            // 
            // sideBarToggle
            // 
            sideBarToggle.Dock = DockStyle.Left;
            sideBarToggle.Image = (Image)resources.GetObject("sideBarToggle.Image");
            sideBarToggle.Location = new Point(0, 0);
            sideBarToggle.Name = "sideBarToggle";
            sideBarToggle.Size = new Size(55, 41);
            sideBarToggle.TabIndex = 0;
            sideBarToggle.UseVisualStyleBackColor = true;
            sideBarToggle.Click += sideBarToggle_Click;
            // 
            // sideBar
            // 
            sideBar.Interval = 10;
            sideBar.Tick += sideBarTransition_Tick;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(6, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(803, 249);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // editButton
            // 
            editButton.Enabled = false;
            editButton.Location = new Point(113, 301);
            editButton.Name = "editButton";
            editButton.Size = new Size(101, 46);
            editButton.TabIndex = 10;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Enabled = false;
            deleteButton.Location = new Point(220, 301);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(101, 46);
            deleteButton.TabIndex = 11;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // clearSelection
            // 
            clearSelection.Location = new Point(705, 6);
            clearSelection.Name = "clearSelection";
            clearSelection.Size = new Size(101, 34);
            clearSelection.TabIndex = 12;
            clearSelection.Text = "Clear Selection";
            clearSelection.UseVisualStyleBackColor = true;
            clearSelection.Click += clearSelection_Click;
            // 
            // newItem
            // 
            newItem.Location = new Point(6, 301);
            newItem.Name = "newItem";
            newItem.Size = new Size(101, 46);
            newItem.TabIndex = 15;
            newItem.Text = "New";
            newItem.UseVisualStyleBackColor = true;
            newItem.Click += newItem_Click;
            // 
            // itemPanel
            // 
            itemPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itemPanel.Controls.Add(newItem);
            itemPanel.Controls.Add(clearSelection);
            itemPanel.Controls.Add(deleteButton);
            itemPanel.Controls.Add(editButton);
            itemPanel.Controls.Add(dataGridView1);
            itemPanel.Location = new Point(197, 47);
            itemPanel.Name = "itemPanel";
            itemPanel.Size = new Size(809, 552);
            itemPanel.TabIndex = 4;
            itemPanel.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 611);
            Controls.Add(itemPanel);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(sideBarMenu);
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            sideBarMenu.ResumeLayout(false);
            itemMenu.ResumeLayout(false);
            itemContainer.ResumeLayout(false);
            itemContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            basesSubContainer.ResumeLayout(false);
            mattressSubContainer.ResumeLayout(false);
            fabricSubContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            itemPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private FlowLayoutPanel sideBarMenu;
        private FlowLayoutPanel itemMenu;
        private System.Windows.Forms.Timer itemMenuTransition;
        private Panel itemContainer;
        private Button itemOption;
        private Panel basesSubContainer;
        private Button basesSubOption;
        private Panel mattressSubContainer;
        private Button mattressSubOption;
        private Panel fabricSubContainer;
        private Button fabricsSubOption;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button sideBarToggle;
        private System.Windows.Forms.Timer sideBar;
        private DataGridView dataGridView1;
        private Button editButton;
        private Button deleteButton;
        private Button clearSelection;
        private Button newItem;
        private Panel itemPanel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}