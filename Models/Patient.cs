using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JClinic.Models
{
    public class Patient
    {
        [Key]
        public string Id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public DateTime birthdate { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public DateTime regisdate { get; set; }
        public int height { get; set; }
        public int weight { get; set; }

        public int age
        {
            get
            {
                var now = DateTime.Today;
                var umur = now.Year - birthdate.Year;
                if (birthdate > now.AddYears(-umur)) umur--;
                return umur;
            }
        }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
