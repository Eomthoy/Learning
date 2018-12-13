using NetCoreApp.Repository;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreApp.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Table("Class")]
    public class Class : IAggrateRoot
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
    }
}
