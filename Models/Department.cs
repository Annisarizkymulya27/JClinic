using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JClinic.Models
{
    public class Department
    {
        [Key]
        public string Id { get; set; }
        public string depName { get; set; }
        public string depDescription { get; set; }
        public bool depStatus { get; set; }
        public User User { get; set; }
    }
}
