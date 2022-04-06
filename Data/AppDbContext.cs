using JClinic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JClinic.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Department> Tb_Department { get; set; }
        public virtual DbSet<Doctor> Tb_Doctor { get; set; }
        public virtual DbSet<Patient> Tb_Patient { get; set; }
        public virtual DbSet<Roles> Tb_Roles { get; set; }
        public virtual DbSet<User> Tb_User { get; set; }
        public virtual DbSet<Appointment> Tb_Appointment { get; set; }
    }
}
