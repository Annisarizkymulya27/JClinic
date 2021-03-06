using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JClinic.Models
{
    public class User
    {
        [Key]
        [Required(ErrorMessage = "Username tidak boleh kosong")]
        [MinLength(5, ErrorMessage = "Username minimal 5 karakter")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password tidak boleh kosong")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Password minimal 6 karakter")]
        public string Password { get; set; }
        public Roles Roles { get; set; }
    }

    public class UserDaftar
    {
        [Required(ErrorMessage = "Username tidak boleh kosong")]
        [MinLength(5, ErrorMessage = "Username minimal 5 karakter")]
        [DisplayName("Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password tidak boleh kosong")]
        [MinLength(6, ErrorMessage = "Password minimal 6 karakter")]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Nama tidak boleh kosong")]
        [MinLength(5, ErrorMessage = "Nama minimal 5 karakter")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email tidak boleh kosong")]
        [MinLength(5, ErrorMessage = "Email minimal 5 karakter")]
        public string Email { get; set; }

        public Roles Roles { get; set; }
    }
}
