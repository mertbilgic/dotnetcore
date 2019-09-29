using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public class MovieRepository
    {
        private static List <Movie> _movies =null;
        
        static MovieRepository(){

            _movies = new List<Movie>()
            {
                new Movie(){
                    Id=1,
                    Name="Shazam",
                    Description="<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Tenetur, rem dolor possimus a cupiditate autem incidunt explicabo quod, libero porro optio corporis in repellat impedit aspernatur alias quisquam, natus ullam.</p>"+
                    "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Tenetur, rem dolor possimus a cupiditate autem incidunt explicabo quod, libero porro optio corporis in repellat impedit aspernatur alias quisquam, natus ullam.</p>"+
                    "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Tenetur, rem dolor possimus a cupiditate autem incidunt explicabo quod, libero porro optio corporis in repellat impedit aspernatur alias quisquam, natus ullam.</p>",
                    ShortDescription="Shazam",
                    ImageUrl="1.jpg",
                    CategoryId=1
                    
                    },
                new Movie(){
                    Id=2,
                    Name="Amazing Grace",
                    Description="<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Tenetur, rem dolor possimus a cupiditate autem incidunt explicabo quod, libero porro optio corporis in repellat impedit aspernatur alias quisquam, natus ullam.</p>"+
                    "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Tenetur, rem dolor possimus a cupiditate autem incidunt explicabo quod, libero porro optio corporis in repellat impedit aspernatur alias quisquam, natus ullam.</p>"+
                    "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Tenetur, rem dolor possimus a cupiditate autem incidunt explicabo quod, libero porro optio corporis in repellat impedit aspernatur alias quisquam, natus ullam.</p>",
                    ShortDescription="Amazing Grace",
                    ImageUrl="2.jpg",
                    CategoryId=4
                },
                new Movie(){
                    Id=3,
                    Name="High Life",
                    Description="<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Tenetur, rem dolor possimus a cupiditate autem incidunt explicabo quod, libero porro optio corporis in repellat impedit aspernatur alias quisquam, natus ullam.</p>"+
                    "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Tenetur, rem dolor possimus a cupiditate autem incidunt explicabo quod, libero porro optio corporis in repellat impedit aspernatur alias quisquam, natus ullam.</p>"+
                    "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Tenetur, rem dolor possimus a cupiditate autem incidunt explicabo quod, libero porro optio corporis in repellat impedit aspernatur alias quisquam, natus ullam.</p>",
                    ShortDescription="High Life",
                    ImageUrl="3.jpg",
                    CategoryId=3
                },
                new Movie(){
                    Id=4,
                    Name="Billboard",
                    Description="<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Tenetur, rem dolor possimus a cupiditate autem incidunt explicabo quod, libero porro optio corporis in repellat impedit aspernatur alias quisquam, natus ullam.</p>"+
                    "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Tenetur, rem dolor possimus a cupiditate autem incidunt explicabo quod, libero porro optio corporis in repellat impedit aspernatur alias quisquam, natus ullam.</p>"+
                    "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Tenetur, rem dolor possimus a cupiditate autem incidunt explicabo quod, libero porro optio corporis in repellat impedit aspernatur alias quisquam, natus ullam.</p>",
                    ShortDescription="Billboard",
                    ImageUrl="4.jpg",
                    CategoryId=1
                },
                new Movie(){
                    Id=5,
                    Name="Storm Boy",
                    Description="<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Tenetur, rem dolor possimus a cupiditate autem incidunt explicabo quod, libero porro optio corporis in repellat impedit aspernatur alias quisquam, natus ullam.</p>"+
                    "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Tenetur, rem dolor possimus a cupiditate autem incidunt explicabo quod, libero porro optio corporis in repellat impedit aspernatur alias quisquam, natus ullam.</p>"+
                    "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Tenetur, rem dolor possimus a cupiditate autem incidunt explicabo quod, libero porro optio corporis in repellat impedit aspernatur alias quisquam, natus ullam.</p>",
                    ShortDescription="Storm Boy",
                    ImageUrl="5.jpg",
                    CategoryId=2
                }
            };

        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }

        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id){

            return _movies.FirstOrDefault(i => i.Id ==id);
        }
    }
}