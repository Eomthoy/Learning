using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonitorManageClient.Models
{
    /// <summary>
    ///  系统设置
    /// </summary>
    public class SystemSetting
    {
        /// <summary>
        /// 实时预览--视频策略（1：集群，2：平台）
        /// </summary>
        public int LiveVideo { get; set; }
        /// <summary>
        /// 实时预览--码流（1：主码流，2：辅码流）
        /// </summary>
        public int LiveStream { get; set; }
        /// <summary>
        /// 录像回放--存储（1：主存，2：备存）
        /// </summary>
        public int PlaybackStorage { get; set; }
        /// <summary>
        /// 录像回放--码流（1：主码流，2：辅码流）
        /// </summary>
        public int PlaybackStream { get; set; }
        /// <summary>
        /// 行为记录--存储（1：主存，2：备存）
        /// </summary>
        public int ActionStorage { get; set; }
        /// <summary>
        /// 行为记录--码流（1：主码流，2：辅码流）
        /// </summary>
        public int Actiontream { get; set; }
    }
}
