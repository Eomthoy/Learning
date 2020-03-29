using System;

namespace Eom.Common.Helpers
{
    /// <summary>
    /// Excel导入
    /// </summary>
    public class ExcelColumAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public ExcelColumAttribute() { }
        /// <summary>
        /// Excel列名
        /// </summary>
        public string ColumName { get; set; }
    }
}