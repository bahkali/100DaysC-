﻿using Microsoft.AspNetCore.Mvc;
using RegistrationAndLoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAndLoginApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel)
        {
            if (userModel.UserName == "KaliBah" && userModel.Password == "123")
            { return View("LoginSucess", userModel); }
            else { return View("LoginFailure", userModel); }
        }
    }
}