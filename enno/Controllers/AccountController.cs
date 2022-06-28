using enno.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace enno.Controllers
{
    [Area("manage")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AccountController(UserManager<AppUser> userManager )
        {
            _userManager = userManager;
        }
        //public async Task<IActionResult> CreateAdmin()
        //{
        //    AppUser admin = new AppUser
        //    { 
        //        FullName="super admmin",
        //        UserName="superAdmin",
        //    };
        //    var result= await _userManager.CreateAsync(admin, "Admin123");

        //    if (!result.Succeeded)
        //    {
        //        return Ok(result.Errors);

        //    }

        //    return View();
        //}


        public IActionResult Login()
        {
            return View();
        }
    }
}
