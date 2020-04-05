using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public static class Repository
    {
        private static List<Movie> _movies = null;


        static Repository()
        {
            InitiateMovies();
        }
        private static void InitiateMovies()
        {
            _movies = new List<Movie>()
            {
                new Movie() { Id = 1, Name = "Shazam", Description = "Shazam", ImageUrl = "1.jpg" },
                new Movie() { Id = 1, Name = "Amazing Grace", Description = "Amazing Grace", ImageUrl = "2.jpg" },
                new Movie() { Id = 1, Name = "High Life", Description = "High Life", ImageUrl = "3.jpg" },
                new Movie() { Id = 1, Name = "Billboard", Description = "Billboard", ImageUrl = "4.jpg" },
                new Movie() { Id = 1, Name = "Storm Boy", Description = "Storm Boy", ImageUrl = "5.jpg" }

            };

        }

        public static List<Movie> GetList
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

        public static Movie GetByID(int MovieId)
        {
            return _movies.FirstOrDefault(i => i.Id == MovieId);
        }
    }


}
