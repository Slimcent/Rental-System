namespace Rental.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AgeLimit { get; set; }
        public Movie(int movieId, string movieTitle, int ageLimit)
        {
            this.Id = movieId;
            this.Title = movieTitle;
            this.AgeLimit = ageLimit;
        }
    }
}
