using Rental.Lists;
using Rental.Models;

namespace Rental
{
    public static  class MovieDisplay
    {
        public static void DisplayMovies(User user)
        {
            List<Movie> movies = Movies.GetMovies();

            IEnumerable<Movie> availableMoviesForUser = movies.Where(m => m.AgeLimit <= user.Age);
            Console.WriteLine($"\nHi {user.Name}, select a number to rent any of these movies");

            foreach (Movie movie in availableMoviesForUser)
            {
                Console.WriteLine($"{movie.Id} {movie.Title}");
            }
        }
    }
}
