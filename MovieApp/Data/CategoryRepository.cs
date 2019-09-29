using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public class CategoryRepository
    {
        private static List <Category> _categoryies =null;
        
        static CategoryRepository(){

            _categoryies = new List<Category>()
            {
                new Category(){Id=1,Name="Macera"},
                new Category(){Id=2,Name="Komedi"},
                new Category(){Id=3,Name="Bilim Kurgu"},
                new Category(){Id=4,Name="Savaş"},
                new Category(){Id=5,Name="Romantik"},
               
            };

        }

        public static List<Category> Categoryies
        {
            get
            {
                return _categoryies;
            }

        }

        public static void AddCategory(Category entity)
        {
            _categoryies.Add(entity);
        }

        public static Category GetById(int id){

            return _categoryies.FirstOrDefault(i => i.Id ==id);
        }
    }
}