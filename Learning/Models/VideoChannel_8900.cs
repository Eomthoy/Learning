using System.Collections.Generic;

namespace MonitorManageClient.Models
{
    public class Channel
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 二号谈话间3
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string channelType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string channelSN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rights { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cameraType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CtrlId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cameraFunctions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string multicastPort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string subMulticastPort { get; set; }
    }

    public class UnitNodes
    {
        /// <summary>
        /// 
        /// </summary>
        public string index { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string channelnum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string streamType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string subType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string zeroChnEncode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Channel> Channel { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 二号谈话间3
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string manufacturer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string port { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string proxyport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string unitnum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string deviceIp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string devicePort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string serviceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string role { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rights { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public UnitNodes UnitNodes { get; set; }
    }
}
