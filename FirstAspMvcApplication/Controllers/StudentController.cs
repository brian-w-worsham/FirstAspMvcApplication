using FirstAspMvcApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstAspMvcApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            StudentBusinessLayer studentBusinessLayer = new StudentBusinessLayer();
            Student student = studentBusinessLayer.GetStudentDetails(1);
            // ViewData
            // public ViewDatqDictionary ViewData {get; set;}

           /* ViewData["Student"] = student;
            ViewData["Header"] = "Student Details";*/

            ViewBag.Student = student;
            ViewBag.Header = "Student Details";


            Address address = new Address()
            {
                AddressId = 1,
                City = "NYC",
                State = "NY",
                Country = "USA",
                Pin = "89122"
            };

            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address,
                Title = "Student Details Title",
                Header = "Student Details Header"
            };
            // return View(); 
            //  return View(student);
            return View(studentDetailsViewModel);
        }

        public ActionResult TempDataActionOne()
        {
            TempData["Name"] = "Jane";
            TempData["Age"] = 30;

            TempData.Keep();
            return View();
        }

        public ActionResult TempDataActionTwo()
        {
            string Name = "";
            int age = 0;

            if (TempData.ContainsKey("Name"))
            {
                Name = TempData["Name"].ToString();
            }

            if (TempData.ContainsKey("Age"))
            {
                age = int.Parse(TempData["Age"].ToString());
            }

            ViewBag.Name = Name;
            ViewBag.Age = age;

            // TempData.Keep();
            TempData.Keep("Name");
            return View();
        }

        public ActionResult TempDataActionThree()
        {
            string Name = "Dummy";
            int age = 0;

            if (TempData.ContainsKey("Name"))
            {
                Name = TempData["Name"].ToString();
            }

            if (TempData.ContainsKey("Age"))
            {
                age = int.Parse(TempData["Age"].ToString());
            }

            ViewBag.Name = Name;
            ViewBag.Age = age;

            // TempData.Keep();
            return View();
        }
    }
}
