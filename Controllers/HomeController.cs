using Microsoft.AspNetCore.Mvc;
using MovieAppMvc.Data;
using MovieAppMvc.Models;
using System.Linq;

namespace MovieAppMvc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(int? id)
        {
          var movie = MovieRepository.Movies;
          if(id!=null){
            movie = movie.Where(i=>i.CategoryId==id).ToList();
          }

           return View(movie);
        }
        public IActionResult Contact()
        {
          return View();
        }
        public IActionResult Details(int id)
        {
          // ProductCategoryModel model = new ProductCategoryModel();
          // model.Categories = CategoryRepository.Categories;
          // model.Movie = MovieRepository.GetById(id);


          return  View(MovieRepository.GetById(id));
        }
    }
}