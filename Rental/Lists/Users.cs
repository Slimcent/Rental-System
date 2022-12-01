using Rental.Models;

namespace Rental.Lists
{
    public static class Users
    {
        public static List<User> GetUsers() 
        {
            List<User> users = new List<User>()
            {
                new User(1, "Chike", 18),
                new User(2, "Obi", 18),
                new User(3, "Zara", 14),
                new User(4, "Vera", 10),
                new User(5, "Julia", 16),
            };

            return users;
        }
    }
}
