using System.Collections.Generic;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {

        public IViewComponentResult Invoke(){
            
            var list = new List<Listcs>()
                {
                    new Listcs(){Name="Kategori 1"},
                    new Listcs(){Name="Kategori 2"},
                    new Listcs(){Name="Kategori 3"}
                };

            return View(list); 
        }
    }
}