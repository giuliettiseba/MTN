using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MTN_Administration
{
    public class CustomComboBox : ComboBox
    {
        private Color _borderColor = Color.Black;
        private ButtonBorderStyle _borderStyle = ButtonBorderStyle.Solid;
        private Brush ArrowBrush = new SolidBrush(SystemColors.ControlText);
        private static int WM_PAINT = 0x000F;
        private Brush BorderBrush = new SolidBrush(SystemColors.Window);

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                Graphics g = Graphics.FromHwnd(Handle);
                Rectangle bounds = new Rectangle(0, 0, Width, Height);
                ControlPaint.DrawBorder(g, bounds, _borderColor, _borderStyle);

                Brush DropButtonBrush = new SolidBrush(BorderColor);
                //Draw the background of the dropdown button
                Rectangle rect = new Rectangle(this.Width - 20, 0, 20, this.Height );
                g.FillRectangle(DropButtonBrush, rect);
                //Create the path for the arrow
                System.Drawing.Drawing2D.GraphicsPath pth = new System.Drawing.Drawing2D.GraphicsPath();
                PointF TopLeft = new PointF(this.Width - 13, (this.Height - 5) / 2);
                PointF TopRight = new PointF(this.Width - 6, (this.Height - 5) / 2);
                PointF Bottom = new PointF(this.Width - 9, (this.Height + 2) / 2);
                pth.AddLine(TopLeft, TopRight);
                pth.AddLine(TopRight, Bottom);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //Determine the arrow's color.
                if (this.DroppedDown)
                {
                    ArrowBrush = new SolidBrush(SystemColors.HighlightText);
                }
                else
                {
                    ArrowBrush = new SolidBrush(SystemColors.ControlText);
                }
                //Draw the arrow
                g.FillPath(ArrowBrush, pth);
            }
        }
        [Category("Appearance")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate(); // causes control to be redrawn
            }
        }

        [Category("Appearance")]
        public ButtonBorderStyle BorderStyle
        {
            get { return _borderStyle; }
            set
            {
                _borderStyle = value;
                Invalidate();
            }
        }
    }
}
