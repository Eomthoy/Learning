using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Learning.Models
{
    [Table("Class")]
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
