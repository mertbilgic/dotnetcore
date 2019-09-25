using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    //localhost:5000/course
    public class CourseController:Controller
    {
        
        //localhost:5000/course/index
        public IActionResult Index(){
            return View();
        }

        public IActionResult Details(){

            var course = new Course();
            course.Name =".NetCore";
            course.description="C#";
            course.isPublished= true;

            return View(course);
        }
        
        //localhost:5000/course/list
        public IActionResult List(){
            return View();
        }
        
    }
}