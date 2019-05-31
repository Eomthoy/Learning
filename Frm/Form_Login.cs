using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            MyInit();
        }

        private void MyInit()
        {
            InitFormMove();
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

        private void button1_Click(object sender, EventArgs e)
        {
            new Form_Main().Show();
            this.Close();
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
