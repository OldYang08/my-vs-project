using Microsoft.AspNetCore.Mvc;

namespace my_vs_project.Controllers
{
    public class AllenController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.text = "Hello World";
            return View();
        }
        
    }
}
