using Eom.Common;
using Eom.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Models
{

    public class Person
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ExcelColum(ColumName = "姓名")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ExcelColum(ColumName = "编号")]
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Enable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ExcelColum(ColumName = "性别")]
        public int? Sex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ExcelColum(ColumName = "身份证")]
        public string IDCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ExcelColum(ColumName = "角色")]
        public int? Role { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ExcelColum(ColumName = "位置")]
        public int? Position { get; set; }
    }
}
