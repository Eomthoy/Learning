using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Frm
{
    public partial class Form_Live : Form
    {
        public Form_Live()
        {
            InitializeComponent();
        }

        public void FullScreen()
        {
            this.panel2.Width = this.Width;
            this.panel2.Height = this.Height;
            this.panel2.Location = new Point(0, 0);
            int Width = this.panel2.Width / 4;
            int Height = this.panel2.Height / 4;
            panel2.BringToFront();

            pictureBox1.Width = Width;
            pictureBox1.Height = Height;
            pictureBox1.Location = new Point(0, 0);
        }
    }
}
