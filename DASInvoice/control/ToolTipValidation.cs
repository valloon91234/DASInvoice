using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DASInvoice.control
{
    public partial class ToolTipValidation : ToolTip
    {
        public ToolTipValidation()
        {
            this.OwnerDraw = true;
            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
        }

        private void OnPopup(object sender, PopupEventArgs e) // use this event to set the size of the tool tip
        {
            e.ToolTipSize = new Size(200, 27);
        }

        private void OnDraw(object sender, DrawToolTipEventArgs e) // use this event to customise the tool tip
        {
            using (Graphics g = e.Graphics)
            {
                using (LinearGradientBrush b = new LinearGradientBrush(e.Bounds, Color.White, Color.White, 45f))
                {
                    g.FillRectangle(b, e.Bounds);
                    g.DrawRectangle(new Pen(Brushes.Red, 1), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1));
                    g.DrawString(e.ToolTipText, new Font(e.Font, FontStyle.Regular), Brushes.Silver, new PointF(e.Bounds.X + 6, e.Bounds.Y + 6)); // shadow layer
                    g.DrawString(e.ToolTipText, new Font(e.Font, FontStyle.Regular), Brushes.Red, new PointF(e.Bounds.X + 5, e.Bounds.Y + 5)); // top layer
                }
            }
        }
    }
}
