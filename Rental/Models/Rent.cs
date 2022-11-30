namespace Rental.Models
{
    public class Rent
    {
        public User User { get; set; }
        public Movie Movie { get; set; }

        public Rent(Movie someMovie, User someUser)
        {
            this.User = someUser;
            this.Movie = someMovie;
        }

        private bool userCanRentMovie()
        {
            return (this.Movie.AgeLimit <= this.User.Age);
        }
        public bool RentMovie()
        {
            if (userCanRentMovie())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
