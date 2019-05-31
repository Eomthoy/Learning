using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Frm
{
    public partial class Form_Main : Form
    {
        public Form_Live Form_Live { get; set; }
        public string Num { get; set; }
        public Form_Main()
        {
            InitializeComponent();
            MyInit();
        }

        public Form_Main(string num)
        {
            InitializeComponent();
            MyInit();
            this.Num = num;
        }

        private void MyInit()
        {
            InitFormMove();
            InitShadow();

            Form_Live = new Form_Live();
            Form_Live.TopLevel = false;// 将子窗体设置为非顶级控件。
            Form_Live.Parent = panel2;// 指定容器。
            Form_Live.Dock = DockStyle.Fill;// 随着容器大小自动调整窗体大小。
            Form_Live.Show();
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
            //new Form_Login().Show();
            //this.Close();

            this.WindowState = FormWindowState.Maximized;
            this.panel2.Dock = DockStyle.Fill;
            Form_Live.FullScreen();
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

        #region 滚轮缩放、拖拽

        public Point mouseDownPoint = new Point();
        public bool isMove { get; set; }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint.X = Cursor.Position.X; //记录鼠标左键按下时位置
                mouseDownPoint.Y = Cursor.Position.Y;
                isMove = true;
                pictureBox.Focus(); //鼠标滚轮事件(缩放时)需要picturebox有焦点
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMove = false;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.Focus(); //鼠标在picturebox上时才有焦点，此时可以缩放
            if (isMove)
            {
                int x, y;   //新的pictureBox.Location(x,y)
                int moveX, moveY; //X方向，Y方向移动大小。
                moveX = Cursor.Position.X - mouseDownPoint.X;
                moveY = Cursor.Position.Y - mouseDownPoint.Y;
                x = pictureBox.Location.X + moveX;
                y = pictureBox.Location.Y + moveY;
                pictureBox.Location = new Point(x, y);
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
            }
        }

        public int zoomStep { get { return 10; } }
        public PictureBox myBmp { get; set; }
        //实现锚点缩放(以鼠标所指位置为中心缩放)；
        //步骤：
        //①先改picturebox长宽，长宽改变量一样；
        //②获取缩放后picturebox中实际显示图像的长宽，这里长宽是不一样的；
        //③将picturebox的长宽设置为显示图像的长宽；
        //④补偿picturebox因缩放产生的位移，实现锚点缩放。
        // 注释：为啥要②③步？由于zoom模式的机制，把picturebox背景设为黑就知道为啥了。
        //这里需要获取zoom模式下picturebox所显示图像的大小信息，添加 using System.Reflection；
        //pictureBox_MouseWheel事件没找到。。。手动添加，别忘在Form1.Designer.cs的“Windows 窗体设计器生成的代码”里加入：  
        //this.pictureBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseWheel)。
        private void pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            int x = e.Location.X;
            int y = e.Location.Y;
            int ow = pictureBox.Width;
            int oh = pictureBox.Height;
            int VX, VY;  //因缩放产生的位移矢量
            if (e.Delta > 0) //放大
            {
                //第①步
                pictureBox.Width += zoomStep;
                pictureBox.Height += zoomStep;
                //第②步
                PropertyInfo pInfo = pictureBox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
                 BindingFlags.NonPublic);
                Rectangle rect = (Rectangle)pInfo.GetValue(pictureBox, null);
                //第③步
                pictureBox.Width = rect.Width;
                pictureBox.Height = rect.Height;
            }
            if (e.Delta < 0) //缩小
            {
                //防止一直缩成负值
                if (pictureBox.Width < myBmp.Width)
                    return;

                pictureBox.Width -= zoomStep;
                pictureBox.Height -= zoomStep;
                PropertyInfo pInfo = pictureBox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
                 BindingFlags.NonPublic);
                Rectangle rect = (Rectangle)pInfo.GetValue(pictureBox, null);
                pictureBox.Width = rect.Width;
                pictureBox.Height = rect.Height;
            }
            //第④步，求因缩放产生的位移，进行补偿，实现锚点缩放的效果
            VX = (int)((double)x * (ow - pictureBox.Width) / ow);
            VY = (int)((double)y * (oh - pictureBox.Height) / oh);
            pictureBox.Location = new Point(pictureBox.Location.X + VX, pictureBox.Location.Y + VY);
        }

        #endregion

        private void Form_Main_Load(object sender, EventArgs e)
        {
            //pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureBox.MouseDown += pictureBox_MouseDown;
            //pictureBox.MouseUp += pictureBox_MouseUp;
            //pictureBox.MouseMove += pictureBox_MouseMove;
            //pictureBox.MouseWheel += pictureBox_MouseWheel;
            //myBmp = new PictureBox()
            //{
            //    Size = pictureBox.Size
            //};
        }
    }
}
