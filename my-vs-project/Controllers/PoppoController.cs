using Microsoft.AspNetCore.Mvc;

namespace my_vs_project.Controllers
{
    public class PoppoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
