using JClinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JClinic.Services
{
    public interface IService
    {
        //Dep
        List<Department> TampilSemuaData();
        bool BuatDepartment(Department datanya);
        bool HapusDepartment(string id);
        bool UbahDepartment(Department data);
    }
}
