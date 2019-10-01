using System.Collections.Generic;
using System.Linq;
using BuildingForms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuildingForms.Controllers
{
    public class HomeController:Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View(ProductRepository.Products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories =new SelectList(new List<string>(){"Telefon","Tablet","Laptop"});
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product ){

            ProductRepository.AddList(product);
            
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Search(string q)
        {

            if(string.IsNullOrWhiteSpace(q))
                return View();
            
            return View("Index",ProductRepository.Products.Where(i=>i.Name.Contains(q)));
        }
        
    }
}