using Rental.Lists;
using Rental.Models;

namespace Rental.Validation
{
    public class MovieValidation
    {
        public static string ValidateMovieSelection(string movieChoiceId)
        {
            List<Movie> movies = Movies.GetMovies();

            while (!movies.Any(x => x.Id.ToString() == movieChoiceId))
            {
                Console.WriteLine("Invalid selection. You have to select a valid option");
                movieChoiceId = Console.ReadLine();
            }

            return movieChoiceId;
        }
    }
}
