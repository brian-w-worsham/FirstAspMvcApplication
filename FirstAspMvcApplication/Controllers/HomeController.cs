using FirstAspMvcApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web.Mvc;

namespace FirstAspMvcApplication.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /*public string Index(string id, string name)
        {
            // return "Hello World! " + id + " times";
            return "The value of  Id = " + id + " and Name = " + name;
        }*/


        /*public PartialViewResult Index()
        {
            return PartialView("_PartialView");
        }*/

        /*public JsonResult Index()
        {
            // return Json(new { Name = "John Smith", ID = 4, DateOfBirth = new DateTime(1999, 12, 31) });

            var persons = new List<Person>
           {
                new Person{Id=1, FirstName="Harry", LastName="Potter"},
                new Person{Id=2, FirstName="James", LastName="Raj"}
           };

            return Json(persons);
        }*/

        /*public Microsoft.AspNetCore.Mvc.ActionResult Index()
        {
            return View();
        }

        public JavaScriptResult WarningMessage()
        {
            var msg = "alert('Are you sure?');";

            return new JavaScriptResult()
            {
                Script = msg
            };
        }*/

        // File Result
        public System.Web.Mvc.FileResult Index()
        {
            return new FilePathResult("~/Files", "SimpleText.txt");

           /* string name = "me.txt";

            FileInfo info = new FileInfo(name);
            if (!info.Exists)
            {
                using (StreamWriter writer = info.CreateText())
                {
                    writer.WriteLine("Hello, I am a new text file");

                }
            }

            return File(Url.Content(name), "text/plain");*/
        }

        // Content Result
        /*public ContentResult Index()
        {
            return Content("<h3>Some content goes here!</h3>", "text/html");
        }*/

        /* public string Index()
         {
             return "<h3>Some content goes here!</h3>";
         }*/

        // Empty Result


        // Redirect, RedirectToRoute, RedirectToAction

        /*public RedirectResult Index()
        {
            return Redirect("https://www.google.com");
        }*/

        /*public RedirectToRouteResult Index()
        {
            return RedirectToRoute(new
            {
                controller = "Student",
                action = "Details"
            });
        }*/


        /* public RedirectToActionResult Index()
         {
             return RedirectToAction("Demo");
         }*/

        public string Demo()
        {
            return "Demo Action Method!";
        }
    }
}