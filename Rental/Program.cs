

using Rental.Models;

class Program
{
    static void Main(string[] args)
    {
        User[] myUsers ={
                            new User(1, "Ezra", 22),
                            new User(2, "Jerrie", 12),
                            new User(3, "Dj Titties", 17),
                            new User(4, "Osita", 15)
                        };
        Movie[] myMovies ={
                                  new Movie(1, "Spartacus", 18),
                                  new Movie(2, "Every Seth MacFarlane Film", 18),
                                  new Movie(3, "Fast and Furious 11", 13),
                                  new Movie(4, "Inception", 16),
                              };


        Console.WriteLine("Welcome to Slim Movies. Please enter User ID to continue");
        string userID = Console.ReadLine();
        User myUser = myUsers.Where(u => u.Id == Convert.ToInt16(userID)).First();
        while (userID != myUser.Id.ToString())
        {
            Console.WriteLine("Please input a correct Id!!!");
            userID = Console.ReadLine();
        }
        Movie[] availableMoviesForUser = myMovies.Where(m => m.AgeLimit <= myUser.Age).ToArray();
        Console.WriteLine("Hi {0}. You can rent any if these movies", myUser.Name);
        for (int i = 0; i < availableMoviesForUser.Count(); i++)
        {
            Movie usersMovie = availableMoviesForUser[i];
            Console.WriteLine("{0}.{1}", i + 1, usersMovie.Title);

        }
        string movieChoice = Console.ReadLine();
        while (movieChoice != availableMoviesForUser.FirstOrDefault().Id.ToString())
        {
            Console.WriteLine("Invalid selection. You have to select a valid option");
            movieChoice = Console.ReadLine();
        }

        Rent myRent = new Rent(availableMoviesForUser.FirstOrDefault(), myUser);
        if (myRent.RentMovie())
        {
            Console.WriteLine("You have successfully rented {0}", myRent.Movie.Title);
        }
        else
        {
            Console.WriteLine("Sorry! You cannot rent a movie bwoi");
        }
    }
}