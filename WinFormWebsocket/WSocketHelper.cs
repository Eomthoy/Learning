using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketClient
{
    public class WSocketHelper
    {
        private static WSocketClient _socket { get; set; }
        private static void Connect()
        {
            if (_socket == null)
            {
                //_socket = new WSocketClient("ws://192.168.1.189:50000");
                _socket = new WSocketClient(System.Configuration.ConfigurationManager.AppSettings["socketAddr"]);
                _socket.Start();
            }
        }
        public static void Send(string msg)
        {
            Connect();
            _socket.SendMessage(msg);
        }
    }
}
