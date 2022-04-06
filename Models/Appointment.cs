using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JClinic.Models
{
    public class Appointment
    {
        [Key]
        public string Id { get; set; }
        public DateTime appointDate { get; set; }
        public string details { get; set; }
        public bool appointStatus { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
