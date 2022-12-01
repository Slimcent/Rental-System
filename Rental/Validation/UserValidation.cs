using Rental.Lists;
using Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
