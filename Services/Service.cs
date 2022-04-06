using JClinic.Helper;
using JClinic.Models;
using JClinic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JClinic.Services
{
    public class Service : IService
    {
        private readonly IRepository _repo;
       // private readonly FileService _file;

        public Service(IRepository r)
        {
            _repo = r;
         //   _file = f;
        }
        public bool BuatDepartment(Department datanya)
        {
            datanya.Id = BantuanUmum.BuatPrimary();
            //datanya.User = _repo.TampilUserByUsernameAsync(username).Result;
            //datanya.Image = _file.SimpanFile(fotonya).Result;

            return _repo.BuatDepartmentAsync(datanya).Result;
        }

        public bool HapusDepartment(string id)
        {
            throw new NotImplementedException();
        }

        public List<Department> TampilSemuaData()
        {
            throw new NotImplementedException();
        }

        public bool UbahDepartment(Department data)
        {
            throw new NotImplementedException();
        }
    }
}
