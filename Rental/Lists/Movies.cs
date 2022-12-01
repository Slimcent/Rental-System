using Rental.Models;

namespace Rental.Lists
{
    public static class Movies
    {
        public static List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie (1, "Spartacus", 18 ),
                new Movie (2, "Tom & Jerry", 10 ),
                new Movie (3, "Gods must be crazy", 14 ),
                new Movie (4, "Alexia", 18 ),
                new Movie (5, "Good Guy", 16 ),
            };

            return movies;
        }
    }
}
