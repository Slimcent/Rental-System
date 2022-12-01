using Rental.Lists;
using Rental.Models;
using Rental.Validation;

class Program
{
    static void Main(string[] args)
    {
        List<User> users = Users.GetUsers();

        List<Movie> movies = Movies.GetMovies();
              
        
        Console.WriteLine("Welcome to Slim Movies. Please enter User ID to continue");
        string id = Console.ReadLine();

        string userId =  UserValidation.ValidateUser(id);

        User user = users.Where(u => u.Id == Convert.ToInt16(userId)).FirstOrDefault();

        IEnumerable<Movie> availableMoviesForUser = movies.Where(m => m.AgeLimit <= user.Age);
        Console.WriteLine($"\nHi {user.Name}, select a number to rent any of these movies");

        foreach (Movie movie in availableMoviesForUser )
        {
            Console.WriteLine($"{movie.Id} {movie.Title}");
        }

        string movieId = Console.ReadLine();

        string movieChoiceId = MovieValidation.ValidateMovieSelection(movieId);
                
        Movie userMovie = movies.Where(u => u.Id == Convert.ToInt16(movieChoiceId)).FirstOrDefault();

        Console.WriteLine($"\nYou have successfully rented {userMovie.Title}");
    }
}