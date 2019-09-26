using System.Linq;
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

        [HttpGet]
        //localhost:5000/course/apply method: Get
        public IActionResult Apply()
        {
          
          return View();
        }
        [HttpPost]
        //localhost:5000/course/apply methot: Post
        public IActionResult Apply(Student student)
        {

            if( ModelState.IsValid==true){
                Repository.AddStudent(student);
                return View("Thanks",student);
            }
            else{
                return View(student);
            }
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

            var student =Repository.Students.Where(i=>i.Confirm==true);
            return View(student);
        }
    }
}