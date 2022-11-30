namespace Rental.Models
{
    public class User
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
}
