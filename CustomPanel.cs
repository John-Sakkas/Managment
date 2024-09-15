﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Managment
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
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 200);

            this.MouseEnter += Panel_MouseEnter;
            this.MouseLeave += Panel_MouseLeave;
            this.MouseUp += Panel_MouseLeave;
            this.MouseDown += Panel_MouseDown;
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
            set 
            { 
                defaultColor = value;
                if (panelBackColor.IsEmpty)
                    panelBackColor = defaultColor;
                this.Invalidate(); 
            }
        }
        public Color HoverColor
        {
            get => hoveColor;
            set { hoveColor = value; this.Invalidate(); }
        }
        public Color ClickedColor
        {
            get => clickedColor;
            set { clickedColor = value; this.Invalidate(); }
        }
        public string PanelText
        {
            get => panelText;
            set { panelText = value; this.Invalidate(); }
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
                e.Graphics.FillRectangle(brushCustom, this.ClientRectangle); // Fill with one color
            }

            // BorderRadius
            RectangleF rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath path = GetCustomPath(rect, borderRadius))
            {
                this.Region = new Region(path); // Set the region of the control (rounded)
            }

            // Draw centered text
            using (StringFormat stringFormat = new StringFormat())
            {
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
                {
                    e.Graphics.DrawString(this.panelText, this.Font, textBrush, this.ClientRectangle, stringFormat);
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
