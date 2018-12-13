using NetCoreApp.Repository;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreApp.Models
{
    /// <summary>
    /// 
    /// </summary>
    //[Table("Student")]
    public class StudentDto : IAggrateRoot
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? ClassId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Test { get; set; }
    }
}
