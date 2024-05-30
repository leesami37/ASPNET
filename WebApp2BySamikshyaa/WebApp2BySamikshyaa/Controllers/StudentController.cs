using Microsoft.AspNetCore.Mvc;

namespace WebApp2BySamikshyaa.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Student()
        {
            return View();
        }
    }
}