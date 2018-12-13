using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution
{
    /// <summary>
    /// 请求结果
    /// </summary>
    public class RequestResultsDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string result { get; set; }
        /// <summary>
        /// 成功
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<DataItemDto> data { get; set; }
    }
    public class DataItemDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string sameCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string payaccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string kuaidinum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string expressCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sameProv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string destCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string destSortingCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string kdComOrderNum { get; set; }
        /// <summary>
        /// 面单页面
        /// </summary>
        public List<string> template { get; set; }
        /// <summary>
        /// 面单URL
        /// </summary>
        public List<string> templateurl { get; set; }
    }
}
