using Microsoft.AspNetCore.Mvc;

namespace MovieAppMvc.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
          return View();
        }
        public IActionResult Create()
        {
          return View();
        }
        public IActionResult List()
        {
          return View();
        }
        public IActionResult Details()
        {
          return View();
        }
    }
}