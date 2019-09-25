using System;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    //localhost:5000
    //localhost:5000/home
    public class Home : Controller
    {   
        //localhost:5000/home
        //localhost:5000/home/index
        public IActionResult Index(){

            int hour = DateTime.Now.Hour;

            ViewBag.Greeting = hour>12 ? "İyi Günler" : "Günaydın";
            ViewBag.Username = "Mert Bilgiç";

            return View();
        }

        //localhost:5000/home/about
        public IActionResult about(){
            return View();
        }
        
    }
}