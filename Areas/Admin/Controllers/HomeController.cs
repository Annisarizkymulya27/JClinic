using JClinic.Models;
using JClinic.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JClinic.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IService _service;
        public HomeController(IService s)
        {
            _service = s;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Department parameter)
        {
            if (ModelState.IsValid)
            {
                _service.BuatDepartment(parameter); // dari helper, tanpa tampungan
                return RedirectToAction("Index");
            }
            return View(parameter); // ini kondisi else
        }

    }
}
