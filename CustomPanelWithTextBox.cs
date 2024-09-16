using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Managment
{
    public class CustomPanelWithTextBox : Panel
    {
        // Fields
        private int borderRadius = 30;
        private string customText = "Default Text"; // Default text
        private char customPasswordChar = '*'; // Default text
        private Color defaultColor = Color.DodgerBlue;
        private Color customTextColor = Color.Black;
        private TextBox textBox;

        // Constructor
        public CustomPanelWithTextBox()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 200);

            // Initialize and configure TextBox
            textBox = new TextBox
            {
                ForeColor = this.ForeColor,
                BackColor = Color.White,
                BorderStyle = BorderStyle.None,
                Text = customText, // Set default text
                Multiline = false // Set to true if you want multiline text
            };
            textBox.TextChanged += TextBox_TextChanged; // Attach the event handler
            this.Controls.Add(textBox);

            // Center the TextBox initially
            CenterTextBox();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            customText = textBox.Text;
        }

        // Properties
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }
        public Color DefaultColor
        {
            get => defaultColor;
            set { defaultColor = value; this.Invalidate(); }
        }

        // Methods
        private GraphicsPath RoundButton(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphicsPath.CloseFigure();

            return graphicsPath;
        }

        // Overridden Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Gradient
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brushCustom = new SolidBrush(this.DefaultColor)) // Use a single color
            {
                e.Graphics.FillRectangle(brushCustom, this.ClientRectangle); // Fill with one color
            }

            // BorderRadius
            RectangleF rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath path = RoundButton(rect, borderRadius))
            {
                this.Region = new Region(path); // Set the region of the control (rounded)
            }
        }

        #region TextBox
        //Properties
        public string CustomText
        {
            get => customText;
            set
            {
                customText = value;
                if (textBox != null)
                {
                    textBox.Text = customText;
                }
                this.Invalidate(); // Refresh the panel to show any changes
            }
        }
        public Color CustomTextColor
        {
            get => customTextColor;
            set
            {
                customTextColor = value;
                if (textBox != null)
                {
                    textBox.ForeColor = customTextColor;
                }
                this.Invalidate(); // Refresh the panel to show any changes
            }
        }

        public char CustomPasswordChar
        {
            get => customPasswordChar;
            set
            {
                customPasswordChar = value;
                if (textBox != null)
                {
                    textBox.PasswordChar = customPasswordChar;
                }
                this.Invalidate(); // Refresh the panel to show any changes
            }
        }

        //Method

        // Override OnResize to center the TextBox when the panel is resized
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CenterTextBox();
        }
        private void CenterTextBox()
        {
            // Center the TextBox in the panel
            if (textBox != null)
            {
                int textBoxWidth = this.Width - 20;
                int textBoxHeight = 30;
                textBox.Size = new Size(textBoxWidth, textBoxHeight);
                textBox.TextAlign = HorizontalAlignment.Center;
                textBox.Location = new Point(
                    (this.Width - textBoxWidth) / 2,
                    (this.Height - textBoxHeight) / 2
                );
            }
        }
        #endregion
    }
}
