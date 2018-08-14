//using System;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LxCallcenter
{
    class OvalPictureBox : PictureBox
    {
        public OvalPictureBox()
        {
            this.BackColor = Color.FromArgb(237, 231, 246);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var _GraphicsPath = new GraphicsPath())
            {
                _GraphicsPath.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(_GraphicsPath);
            }
        }
    }
}
