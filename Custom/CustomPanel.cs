using System.Drawing.Drawing2D;

namespace Managment.Custom
{
    public class CustomPanel : Panel
    {
        // Fields
        private int borderRadius = 30;

        public Color panelBackColor = Color.Empty;

        private Color defaultColor = Color.DodgerBlue;
        private Color hoveColor = Color.DodgerBlue;
        private Color clickedColor = Color.DodgerBlue;

        private string panelText = "Default Text";

        // Constructor
        public CustomPanel()
        {
            BackColor = Color.White;
            ForeColor = Color.Black;
            Size = new Size(350, 200);

            MouseEnter += Panel_MouseEnter;
            MouseLeave += Panel_MouseLeave;
            MouseUp += Panel_MouseLeave;
            MouseDown += Panel_MouseDown;
        }

        // Properties
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }
        public Color DefaultColor
        {
            get => defaultColor;
            set
            {
                defaultColor = value;
                if (panelBackColor.IsEmpty)
                    panelBackColor = defaultColor;
                Invalidate();
            }
        }
        public Color HoverColor
        {
            get => hoveColor;
            set { hoveColor = value; Invalidate(); }
        }
        public Color ClickedColor
        {
            get => clickedColor;
            set { clickedColor = value; Invalidate(); }
        }
        public string PanelText
        {
            get => panelText;
            set { panelText = value; Invalidate(); }
        }

        // Methods
        private GraphicsPath GetCustomPath(RectangleF rectangle, float radius)
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
            using (SolidBrush brushCustom = new SolidBrush(DefaultColor)) // Use a single color
            {
                e.Graphics.FillRectangle(brushCustom, ClientRectangle); // Fill with one color
            }

            // BorderRadius
            RectangleF rect = new RectangleF(0, 0, Width, Height);
            using (GraphicsPath path = GetCustomPath(rect, borderRadius))
            {
                Region = new Region(path); // Set the region of the control (rounded)
            }

            // Draw centered text
            using (StringFormat stringFormat = new StringFormat())
            {
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                using (SolidBrush textBrush = new SolidBrush(ForeColor))
                {
                    e.Graphics.DrawString(panelText, Font, textBrush, ClientRectangle, stringFormat);
                }
            }
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            DefaultColor = clickedColor;
        }
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            DefaultColor = hoveColor;
        }
        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            DefaultColor = panelBackColor;
        }
    }
}
