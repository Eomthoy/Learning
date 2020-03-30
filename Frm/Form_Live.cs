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

            this.panel2.Controls.Add(new PictureBox() { Location = new Point(0, 0), Size = this.panel2.Size });
            //this.panel1.BringToFront();
        }

        public void FullScreen()
        {
            this.panel2.Width = this.Width;
            this.panel2.Height = this.Height;
            this.panel2.Location = new Point(0, 0);
            int Width = this.panel2.Width / 4;
            int Height = this.panel2.Height / 4;
            panel2.BringToFront();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            FullScreen();
        }
    }
}
