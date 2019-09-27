using System.Collections.Generic;
using System.Linq;
using CourseApp.Models;
using CourseApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{   
    //localhost:5000/course
    public class CourseController:Controller
    {   

        public ActionResult TestList(){

            var list = new List<Listcs>()
            {
                new Listcs(){Name="Kategori 1"},
                new Listcs(){Name="Kategori 2"},
                new Listcs(){Name="Kategori 3"}
            };

            var products = new List<Product>(){

                new Product(){Name ="Product 1"},
                new Product(){Name ="Product 2"},
                new Product(){Name ="Product 3"}
            };

            ProductsListViewModel model = new ProductsListViewModel();
            model.Products=products;
            model.Lists=list;
            

            return View(model);
        }
        public ActionResult TestIndex(){

            var kurs = new Course(){Id=1,Name="Komple Uygulamalı Web Geliştirme Kursu"};
            var ogrenciler = new List<StudentData>(){

                new StudentData(){name = "Ali"},
                new StudentData(){name = "Termos"},
                new StudentData(){name = "Ali"},
                new StudentData(){name = "Termos"}
            };

            var viewmodel = new CourseStudentsViewModel();

            viewmodel.Course=kurs;
            viewmodel.Students=ogrenciler;


            return View(viewmodel);
        }
        public ActionResult ByReleased(int year,int month){

            return Content("year : "+year+" month : "+month);
        }
        public ActionResult CourseList(int? pageindex ,string sortby){

            if(!pageindex.HasValue)
                pageindex=1;
            
            if(string.IsNullOrWhiteSpace(sortby))
                sortby ="name";
            
            return Content("pageindex = "+pageindex+" sort by = "+sortby);
        }
        
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

        public IActionResult testID(int id){

            return Content("id="+id);
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