using JClinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JClinic.Repositories
{
    public interface IRepository
    {
        Task<bool> BuatDepartmentAsync(Department dataDep);
        Task<List<Department>> TampilSemuaDepartmentAsync();
        Task<bool> UpdateDepartmentAsync(Department dataDep);
        Task<bool> HapusDepartmentAsync(Department dataDep);

    }
}
