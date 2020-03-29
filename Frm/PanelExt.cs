using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using CCWin;

namespace Frm
{
    public partial class PanelExt : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private bool m_shadow = false;
        /// <summary>
        /// 阴影
        /// </summary>
        [Description("阴影"), Category("自定义")]
        public bool Shadow
        {
            get
            {
                return this.m_shadow;
            }
            set
            {
                this.m_shadow = value;
                Refresh();
            }
        }

        public PanelExt()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            if (Shadow)
            {
                Rectangle _BacklightLTRB = new Rectangle(10, 10, 10, 10);//窗体光泽重绘边界
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.HighQuality; //高质量
                g.PixelOffsetMode = PixelOffsetMode.HighQuality; //高像素偏移质量
                ImageDrawRect.DrawRect(g, Properties.Resources.main_light_bkg_top123, e.ClipRectangle, Rectangle.FromLTRB(_BacklightLTRB.X, _BacklightLTRB.Y, _BacklightLTRB.Width, _BacklightLTRB.Height), 1, 1);
            }
        }
    }
}
