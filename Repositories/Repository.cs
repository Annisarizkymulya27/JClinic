using JClinic.Data;
using JClinic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JClinic.Repositories
{
    public class Repository : IRepository
    {
        private readonly AppDbContext _db;

        public Repository(AppDbContext db)
        {
            _db = db;
        }
        public async Task<bool> BuatDepartmentAsync(Department dataDep)
        {
            try
            {
                _db.Tb_Department.Add(dataDep); // insert into tb_department ...
                await _db.SaveChangesAsync(); // eksekusi
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
            
        }

        public async Task<bool> HapusDepartmentAsync(Department dataDep)
        {
            try
            {
                _db.Tb_Department.Remove(dataDep); // delete from tb_blog
                await _db.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
            
        }

        public async Task<List<Department>> TampilSemuaDepartmentAsync()
        {
            var data = await _db.Tb_Department.Include(x => x.User.Roles).ToListAsync(); // select *
            return data;
        }

        public async Task<bool> UpdateDepartmentAsync(Department dataDep)
        {
            try
            {
                _db.Tb_Department.Update(dataDep); // update from tb_blog set ...
                await _db.SaveChangesAsync(); // eksekusi
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
