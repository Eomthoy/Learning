﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Frm
{
    public partial class Form_UpdatePassword : Form
    {
        public Form_UpdatePassword()
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
            //Application.Exit();
            this.Close();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
