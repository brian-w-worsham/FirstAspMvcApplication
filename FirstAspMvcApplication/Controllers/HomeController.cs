using FirstAspMvcApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstAspMvcApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index(string id, string name)
        {
            // return "Hello World! " + id + " times";
            return "The value of  Id = " + id + " and Name = " + name;
        }

       
    }
}