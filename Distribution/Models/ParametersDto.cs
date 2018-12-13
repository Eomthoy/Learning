using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution
{
    /// <summary>
    /// 请求参数
    /// </summary>
    public class ParametersDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string partnerId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string partnerKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string net { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string kuaidicom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string kuaidinum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string orderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public RecManDto recMan { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SendManDto sendMan { get; set; }
        /// <summary>
        /// 测试物品
        /// </summary>
        public string cargo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string weight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string volumn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string payType { get; set; }
        /// <summary>
        /// 标准快递
        /// </summary>
        public string expType { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string valinsPay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string collection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string needChild { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string needBack { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string needTemplate { get; set; }
    }
    /// <summary>
    /// 收件人信息
    /// </summary>
    public class RecManDto
    {
        /// <summary>
        /// 程恩蒙
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string zipCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string province { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string district { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string addr { get; set; }
        /// <summary>
        /// 成都中医药大学
        /// </summary>
        public string printAddr { get; set; }
        /// <summary>
        /// 成都中医药大学
        /// </summary>
        public string company { get; set; }
    }
    /// <summary>
    /// 发件人信息
    /// </summary>
    public class SendManDto
    {
        /// <summary>
        /// 敖龙彪
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string zipCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string province { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string district { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string addr { get; set; }
        /// <summary>
        /// 成都中医药大学十二桥校区
        /// </summary>
        public string printAddr { get; set; }
        /// <summary>
        /// 成都中医药大学十二桥校区
        /// </summary>
        public string company { get; set; }
    }

}
