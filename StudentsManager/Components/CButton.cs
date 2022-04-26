using StudentsManager.Classes;
using StudentsManager.Components.Classes;
using System.Drawing.Drawing2D;

namespace StudentsManager.Components
{
    public class CButton : Button, ColorTypeSelection
    {
        private ColorType colorType;
        private int borderSize;
        private int borderRadius;
        private Color borderColor;

        public CButton()
        {
            this.colorType = ColorType.Primary;
            this.borderSize = 0;
            this.borderRadius = 5;
            this.borderColor = ColorCollection.Gray;
            this.Size = new Size(160, 32);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Cursor = Cursors.Hand;
            this.Font = new Font("Segoe UI", 11, FontStyle.Bold);
        }

        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;
            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                this.Region = new Region(rectSurface);

                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

            this.PaintSelectedColorType();
        }

        public void PaintSelectedColorType()
        {
            this.ForeColor = Color.White;

            switch (this.colorType)
            {
                default: case ColorType.Primary: this.BackColor = ColorCollection.Primary; break;
                case ColorType.Secondary: this.BackColor = ColorCollection.LightGrayV2; break;
                case ColorType.Success: this.BackColor = ColorCollection.Green; break;
                case ColorType.Error: this.BackColor = ColorCollection.Tomato; break;
            }
        }

        public ColorType ColorSelected
        {
            get => this.colorType;
            set
            {
                this.colorType = value;
                this.Invalidate();
            }
        }
    }
}
