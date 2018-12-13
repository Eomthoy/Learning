using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreApp.Models
{
    public class SearchDto
    {
        public string Code { get; set; }
        public DateTime? Date { get; set; }
        /// <summary>
        /// 角色：1、教师，2、学生
        /// </summary>
        public string Role { get; set; }
        public string Name { get; set; }
    }
}
