using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketClient;

namespace WinFormWebsocket
{
    public partial class Form1 : Form
    {
        // 这里的URL配置成你websocket服务端的地址就好了
        private static string url = "ws://192.168.100.91:50000";
        WSocketClient client = new WSocketClient(url);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            txtServerIP.Text = url;
            this.Text = "客户端";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //新建客户端类 
            //服务端IP地址 ws://192.168.1.13 如果服务端开启了ssl或者tsl 这里前缀应该改成 wss:/
            //服务端监听端口 1234
            //自定义的地址参数 可以根据地址参数来区分客户端 /lcj控制台
            //开始链接
            try
            {
                client.Start();
                //txtLog.Text = "链接成功";
                MessageReceived();
            }
            catch (Exception ex)
            {
                txtLog.Text = $"发生异常链接失败{ex.ToString()}";
                throw;
            }
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            string inputMsg = txtInputMsg.Text.ToString();
            if (string.IsNullOrEmpty(inputMsg))
                MessageBox.Show("小调皮,空值不让传！");
            client.SendMessage(inputMsg);
            MessageReceived();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // 记得释放资源否则会造成堆栈
            client.Dispose();
            txtLog.Text = $"已成功释放资源。";
            MessageReceived();
        }

        /// <summary>
        /// 服务端返回的消息
        /// </summary>
        private void MessageReceived()
        {
            //注册消息接收事件，接收服务端发送的数据
            client.MessageReceived += (data) =>
            {
                txtLog.Text += data;
            };
        }
    }
}
