using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JClinic.Models
{
    public class Doctor
    {
        [Key]
        public string Id { get; set; }
        public string doctorName { get; set; }
        public string noHp { get; set; }
        public Department fkDepartment { get; set; }
        public string password { get; set; }
        public string docAddress { get; set; }
        public string doctorEdu { get; set; }
        public int consulCharge { get; set; }
        public bool docStatus { get; set; }
    }
}
