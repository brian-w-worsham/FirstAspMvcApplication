using Microsoft.AspNetCore.Mvc;

namespace FirstAspMvcApplication.Controllers
{
    public class FirstController : Controller
    {
        public string Index()
        {
            return "My First Controller";
        }
    }
}
