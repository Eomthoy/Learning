namespace Frm
{
    partial class Form_Live
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_FullScreen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(310, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 582);
            this.panel2.TabIndex = 5;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(32, 119);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(228, 580);
            this.treeView1.TabIndex = 6;
            // 
            // btn_FullScreen
            // 
            this.btn_FullScreen.BackColor = System.Drawing.Color.Transparent;
            this.btn_FullScreen.BackgroundImage = global::Frm.Properties.Resources.quiteFullScreen;
            this.btn_FullScreen.FlatAppearance.BorderSize = 0;
            this.btn_FullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FullScreen.Font = new System.Drawing.Font("阿里巴巴普惠体 R", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_FullScreen.ForeColor = System.Drawing.Color.Black;
            this.btn_FullScreen.Location = new System.Drawing.Point(892, 53);
            this.btn_FullScreen.Margin = new System.Windows.Forms.Padding(4, 3, 1, 1);
            this.btn_FullScreen.Name = "btn_FullScreen";
            this.btn_FullScreen.Size = new System.Drawing.Size(32, 32);
            this.btn_FullScreen.TabIndex = 69;
            this.btn_FullScreen.UseVisualStyleBackColor = false;
            this.btn_FullScreen.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 70;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Frm.Properties.Resources.quiteFullScreen;
            this.panel1.Location = new System.Drawing.Point(673, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 32);
            this.panel1.TabIndex = 71;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // Form_Live
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 713);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_FullScreen);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Live";
            this.Text = "Form_Live";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.Button btn_FullScreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}