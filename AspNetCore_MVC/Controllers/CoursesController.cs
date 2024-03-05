using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
			ViewData["Title"] = "Course Library";
			return View();
        }
    }
}
