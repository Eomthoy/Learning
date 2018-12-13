using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreApp.Models
{
    /// <summary>
    /// 统计
    /// </summary>
    public class StatisticsDto
    {
        /// <summary>
        /// 作业数
        /// </summary>
        public int TaskNumber { get; set; }
        /// <summary>
        /// 讨论数
        /// </summary>
        public int DiscussNumber { get; set; }
        /// <summary>
        /// 师生交流数
        /// </summary>
        public int CommunicationNumber { get; set; }
        /// <summary>
        /// 文件数
        /// </summary>
        public int FileNumber { get; set; }
    }
}
