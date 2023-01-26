using LoginApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            LoginModel model = new LoginModel();
            return View("Login", model);
        }

        public IActionResult UserDetails()
        {
            UserDetailsModel model = new UserDetailsModel(50,60);
            return View("UserDetails", model);
        }

        [HttpPost]
        public IActionResult SaveUserDetails(UserDetailsModel model)
        {
            bool isSuccess = true;
            return new JsonResult(new { isSuccess });
        }

    }
}
