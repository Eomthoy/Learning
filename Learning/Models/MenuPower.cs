using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MonitorManageClient.Enums
{
    /// <summary>
    /// 菜单权限
    /// </summary>
    public enum MenuPower
    {
        [Description("实时预览")]
        BtnLive = 1,
        [Description("录像回放")]
        BtnPlayBack = 2,
        [Description("行为记录")]
        BtnActionRecord = 4,
        [Description("系统设置")]
        BtnSystemSetting = 8
    }
}
