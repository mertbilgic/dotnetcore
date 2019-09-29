
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
using MovieApp.Data;
using System.Linq;

namespace MovieApp.Controllers
{
    public class HomeController:Controller
    {
        

        [HttpGet]
        //Home/Index/3
        //Home/Index
        public IActionResult Index(int? id)
        {
            var movies = MovieRepository.Movies;

            if(id!=null)
            {
             movies = movies.Where(i => i.CategoryId == id).ToList();
            }
        
          

            return View(movies);
        }
        public IActionResult Details(int id){

            // MovieCategoryModel model = new MovieCategoryModel();
            // model.Categories=CategoryRepository.Categoryies;
            // model.Movie=MovieRepository.GetById(id);

            return View(MovieRepository.GetById(id));
        }
        public IActionResult Contact()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }


    }
}