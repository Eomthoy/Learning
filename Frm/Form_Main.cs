﻿using System;
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
    public partial class Form_Main : Form
    {

        public Form_Main()
        {
            InitializeComponent();
            MyInit();
        }

        private void MyInit()
        {
            InitFormMove();
            InitShadow();
        }

        #region 窗体关闭按钮控制方法

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                Label label = sender as Label;
                label.BackColor = Color.DeepSkyBlue;
            }
            else if (sender is Button)
            {
                Button btn = sender as Button;
                btn.BackColor = Color.DeepSkyBlue;
            }
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                Label label = sender as Label;
                label.BackColor = Color.FromArgb(0, 102, 102);
            }
            else if (sender is Button)
            {
                Button btn = sender as Button;
                btn.BackColor = Color.FromArgb(0, 102, 102);
            }
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
            new Form_Login().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form_UpdatePassword().Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            item.BackColor = Color.DimGray;
        }

        private void menuUpdatePwd_Click(object sender, EventArgs e)
        {

        }

        private void menuLogout_Click(object sender, EventArgs e)
        {

        }
    }
}