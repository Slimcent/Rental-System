using Rental.Lists;
using Rental.Models;
using Rental.Validation;

namespace Rental.Operations
{
    public static class RentMovie
    {
        public static void RentAMovie()
        {
            List<User> users = Users.GetUsers();

            List<Movie> movies = Movies.GetMovies();


            Console.WriteLine("Welcome to Slim Movies. Please enter User ID to continue");
            string id = Console.ReadLine();

            string userId = UserValidation.ValidateUser(id);

            User user = users.Where(u => u.Id == Convert.ToInt16(userId)).FirstOrDefault();

            MovieDisplay.DisplayMovies(user);

            string movieId = Console.ReadLine();

            string movieChoiceId = MovieValidation.ValidateMovieSelection(movieId);

            Movie userMovie = movies.Where(u => u.Id == Convert.ToInt16(movieChoiceId)).FirstOrDefault();

            Console.WriteLine($"\nYou have successfully rented {userMovie.Title}");

            Application.End();
        }
    }
}
