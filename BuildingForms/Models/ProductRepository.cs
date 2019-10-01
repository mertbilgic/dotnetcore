using System.Collections.Generic;

namespace BuildingForms.Models
{
    public class ProductRepository
    {
        private static List<Product> _products;

        static ProductRepository(){

            _products = new List<Product>()
            {
                new Product(){Id=1, Name="Product 1",Description="Description 1",Price=10,isApproved=true},   
                new Product(){Id=2, Name="Product 2",Description="Description 2",Price=20,isApproved=true},
                new Product(){Id=3, Name="Product 3",Description="Description 3",Price=30,isApproved=false},
                new Product(){Id=4, Name="Product 4",Description="Description 4",Price=40,isApproved=true},
                new Product(){Id=5, Name="Product 5",Description="Description 5",Price=50,isApproved=false},   
                new Product(){Id=6, Name="Product 6",Description="Description 6",Price=60,isApproved=true}   

            };
        }

        public static List<Product> Products
        {
            get { return _products;}
        }

        public static void AddList(Product entity){

            _products.Add(entity);

        }
    }
}