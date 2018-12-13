using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreApp.Models
{

    public class SysButtonDto
    {

        public int Id { get; set; }
        public string BtnName { get; set; }
        public string BtnNo { get; set; }
        public string BtnClass { get; set; }
        public string BtnIcon { get; set; }
        public string BtnScript { get; set; }
        public string MenuNo { get; set; }
        public string InitStatus { get; set; }
        public string Target { get; set; }
        public string Toggle { get; set; }
        public int? SeqNo { get; set; }
        public bool? Enable { get; set; }
        public int? MenuId { get; set; } 
        /// <summary>
        /// 是否审核通过
        /// </summary>
        public bool? IsFReviewed { get; set; }
        [NotMapped]
        public DateTime? TspCreateDate { get; set; }

        public bool? MobileIcon { get; set; }

        /// <summary>
        /// 手机样式
        /// </summary> 
        public string MobileClass { get; set; }
        /// <summary>
        /// 排序字段
        /// </summary>
        public int? Sort { get; set; }
    }
}
