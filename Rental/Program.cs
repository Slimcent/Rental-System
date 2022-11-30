
class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public User(int userId, string userName, int userAge)
    {
        this.Id = userId;
        this.Name = userName;
        this.Age = userAge;
    }
}

class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int AgeLimit { get; set; }
    public Movie(int movieID, string movieTitle, int ageLimit)
    {
        this.Id = movieID;
        this.Title = movieTitle;
        this.AgeLimit = ageLimit;
    }
}



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("A Rental system");
    }
}