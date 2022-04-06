using JClinic.Data;
using JClinic.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JClinic.Controllers
{
    public class AkunController : Controller
    {
        private readonly AppDbContext _context;

        public AkunController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Masuk()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Masuk(User datanya)
        {

            var cariusername = _context.Tb_User.Where(bebas => bebas.Username == datanya.Username).FirstOrDefault();

            if (cariusername != null)
            {
                var cekpassword = _context.Tb_User.Where(  // proses pengecekan username & pass
                                            bebas =>
                                            bebas.Username == datanya.Username
                                            &&
                                            bebas.Password == datanya.Password
                                            )
                                    .Include(bebas2 => bebas2.Roles)
                                    .FirstOrDefault();

                if (cekpassword != null)
                {
                    // proses tampungan data
                    var daftar = new List<Claim>
                    {
                        new Claim("Username", cariusername.Username),
                        new Claim("Role", cariusername.Roles.Id)
                    };

                    // proses daftar auth
                    await HttpContext.SignInAsync(
                        new ClaimsPrincipal(
                            new ClaimsIdentity(daftar, "Cookie", "Username", "Role")
                            )
                        );

                    if (cariusername.Roles.Id == "1")
                    {
                        return RedirectToAction(controllerName: "Futsal", actionName: "Index");
                    }
                    else if (cariusername.Roles.Id == "2")
                    {
                        return RedirectToAction(controllerName: "Cust", actionName: "Index");
                    }

                    return RedirectToAction(controllerName: "Home", actionName: "Index");
                }

                ViewBag.pesan = "passwordnya salah";

                return View(datanya);
            }

            ViewBag.pesan = "username anda tidak ada";

            return View(datanya);
        }
    }
}
