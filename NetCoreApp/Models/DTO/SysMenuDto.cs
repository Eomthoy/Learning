
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace NetCoreApp.Models
{
     
    public class SysMenuDto
    {
        public int Id { get; set; }
        public string MenuNo { get; set; }
        public string ApplicationCode { get; set; }
        public string MenuParentNo { get; set; }
        public Nullable<int> MenuOrder { get; set; }
        public string MenuName { get; set; }
        public string MenuUrl { get; set; }
        public string MenuIcon { get; set; }
        public Nullable<bool> IsVisible { get; set; }
        public Nullable<bool> IsLeaf { get; set; }
        public Nullable<bool> Enable { get; set; }
        public Nullable<int> ApplicationId { get; set; }
        public DateTime? CreateDate { get; set; }
         
        //public virtual SysApplication SysApplication { get; set; }
        /// <summary>
        /// ÊÇ·ñÉóºËÍ¨¹ý
        /// </summary>
        public bool? IsFReviewed { get; set; }

        [NotMapped]
        public DateTime? TspCreateDate { get; set; }
        //public virtual ICollection<SysButton> Sys_Button { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<SysMenuDto> Children { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<SysButtonDto> BtnChildren { get; set; }
    }
}
