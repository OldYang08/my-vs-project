using Microsoft.AspNetCore.Mvc;
using my_vs_project.Models;

namespace my_vs_project.Controllers
{
    public class AllenController : Controller
    {
        NorthwindContext _context;
        public AllenController(NorthwindContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.text = "Hello World";
            return View();
        }
        public IActionResult News()
        {
            return RedirectToAction("Index");
        }
    }
}
