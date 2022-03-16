using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ContactApp.Models;
using ContactApp.Data.Services;

namespace ContactApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailService _service;

        public HomeController(ILogger<HomeController> logger, IEmailService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SendEmail(ComposeEmailVM composeEmail)
        {
            try
            {
                var response = _service.SendSingleEmail(composeEmail);
                 return View("Success");
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}
