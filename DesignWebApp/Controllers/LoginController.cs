using DesignWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignWebApp.Controllers
{
    public class LoginController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel user)
        {
            if(user.Username == "Kaly" && user.Password == "1234")
            {
                return View("LoginSuccess", user);
            } else
            {
                return View("LoginFailure", user);
            }
                  
        }

    }
}
