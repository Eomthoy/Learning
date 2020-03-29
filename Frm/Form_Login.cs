using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Frm
{
    public partial class Form_Login : Form
    {

        public Form_Login()
        {
            InitializeComponent();

            //CreateFloatingPanel(this.originalPanel);

            //MyInit();
        }

        private void MyInit()
        {
            //InitFormMove();

            //InitShadow();
        }

        public void CreateFloatingPanel()
        {
            Bitmap bitmap = new Bitmap(panel2.Width, panel2.Height);
            //Rectangle _BacklightLTRB = new Rectangle(20, 20, 20, 20);//窗体光泽重绘边界
            Rectangle _BacklightLTRB = new Rectangle(20, 20, 20, 20);//窗体光泽重绘边界
            //Graphics g = Graphics.FromImage(bitmap);
            Graphics g = panel2.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality; //高质量
            g.PixelOffsetMode = PixelOffsetMode.HighQuality; //高像素偏移质量
            ImageDrawRect.DrawRect(g, Properties.Resources.main_light_bkg_top123, ClientRectangle, Rectangle.FromLTRB(_BacklightLTRB.X, _BacklightLTRB.Y, _BacklightLTRB.Width, _BacklightLTRB.Height), 1, 1);

            //if (!Bitmap.IsCanonicalPixelFormat(bitmap.PixelFormat) || !Bitmap.IsAlphaPixelFormat(bitmap.PixelFormat))
            //    throw new ApplicationException("图片必须是32位带Alhpa通道的图片。");
            //IntPtr oldBits = IntPtr.Zero;
            //IntPtr screenDC = Win32.GetDC(IntPtr.Zero);
            //IntPtr hBitmap = IntPtr.Zero;
            //IntPtr memDc = Win32.CreateCompatibleDC(screenDC);

            //try
            //{
            //    Win32.Point topLoc = new Win32.Point(Left, Top);
            //    Win32.Size bitMapSize = new Win32.Size(Width, Height);
            //    Win32.BLENDFUNCTION blendFunc = new Win32.BLENDFUNCTION();
            //    Win32.Point srcLoc = new Win32.Point(0, 0);

            //    hBitmap = bitmap.GetHbitmap(Color.FromArgb(0));
            //    oldBits = Win32.SelectObject(memDc, hBitmap);

            //    blendFunc.BlendOp = Win32.AC_SRC_OVER;
            //    blendFunc.SourceConstantAlpha = Byte.Parse("255");
            //    blendFunc.AlphaFormat = Win32.AC_SRC_ALPHA;
            //    blendFunc.BlendFlags = 0;

            //    Win32.UpdateLayeredWindow(Handle, screenDC, ref topLoc, ref bitMapSize, memDc, ref srcLoc, 0, ref blendFunc, Win32.ULW_ALPHA);
            //}
            //finally
            //{
            //    if (hBitmap != IntPtr.Zero)
            //    {
            //        Win32.SelectObject(memDc, oldBits);
            //        Win32.DeleteObject(hBitmap);
            //    }
            //    Win32.ReleaseDC(IntPtr.Zero, screenDC);
            //    Win32.DeleteDC(memDc);
            //}
        }

        #region 窗体关闭按钮控制方法

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {

        }

        #endregion

        #region 控制无边框窗体的移动、阴影

        /// <summary>
        /// 无边框窗体移动初始化
        /// </summary>
        private void InitFormMove()
        {
            this.MouseDown += control_MouseDown;
            foreach (Control item in this.Controls)
            {
                if (!(item is Button) && !(item is TextBox))
                {
                    item.MouseDown += control_MouseDown;
                }
            }
        }
        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            //常量
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int HTCAPTION = 0x0002;
            //API函数加载，实现窗体窗体移动
            FormSetHelper.ReleaseCapture();
            FormSetHelper.SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        /// <summary>
        /// 窗体阴影设置
        /// </summary>
        private void InitShadow()
        {
            //常量
            const int CS_DropSHADOW = 0x20000;
            const int GCL_STYLE = (-26);
            //API函数加载，实现窗体边框阴影效果
            FormSetHelper.SetClassLong(this.Handle, GCL_STYLE, FormSetHelper.GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
        }

        #endregion

        private List<Panel> Panels { get; set; } = new List<Panel>();
        private List<Panel> Panels2 { get; set; } = new List<Panel>();

        private void button1_Click(object sender, EventArgs e)
        {
            //new Form_Main().Show();
            //this.Close();
            //foreach (var item in Panels)
            //{

            //}
            //for (int i = 0; i < 100; i++)
            //{
            //    Panels.Add(new Panel());
            //    Panels2.Add(new Panel());
            //}

            CreateFloatingPanel();
        }

        #region 阴影

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }



        #endregion

        private void Form_Login_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new MenuItemRenderer();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Gray;
        }

        private void label2_MouseLeave_1(object sender, EventArgs e)
        {
            label2.BackColor = Color.DimGray;
        }
    }
}
