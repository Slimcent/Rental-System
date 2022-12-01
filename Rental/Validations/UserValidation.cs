using Rental.Lists;
using Rental.Models;

namespace Rental.Validation
{
    public static class UserValidation
    {
        public static string ValidateUser( string userId)
        {
            List<User> users = Users.GetUsers();

            while (!users.Any(x => x.Id.ToString() == userId))
            {
                Console.WriteLine("Please input a correct Id!!!");
                userId = Console.ReadLine();
            }

            return userId;
        }
    }
}
