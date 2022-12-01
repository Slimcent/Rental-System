using Rental.Operations;
using Rental.Validation;
using System.Text;

namespace Rental
{
    public static class Application
    {
        public static void Menu()
        {
            Console.Clear();
            var menu = new StringBuilder();
            menu.AppendLine("Please, select the Operation to perform\n");
            menu.Append("Press 1 to Add a user\n");
            menu.Append("Press 2 to Add a movie\n");
            menu.Append("Press 3 to Rent a movie\n");
            menu.Append("Press 11 to Log out/Exit\n");

            Console.WriteLine(menu.ToString());
            var selection = Console.ReadLine();

            while (selection != "1" && selection != "2" && selection != "3" && selection != "11")
            {
                Console.ResetColor();
                MenuValidation.InvalidPrompt(selection);
                selection = Console.ReadLine();
            }

            switch (selection)
            {
                case "1":
                    
                    break;
                case "2":
                    
                    break;
                case "3":
                    RentMovie.RentAMovie();
                    break;
                case "11":
                    Exit("11");
                    break;
                default:
                    Console.WriteLine("Invalid selection made, Choose the right option");
                    break;
            }
        }

        public static void End()
        {
            Console.Clear();
            var menu = new StringBuilder();
            menu.AppendLine("Please, what else do you want to do?\n");
            menu.Append("Press 1 to Return to main menu\n");
            menu.Append("Press 11 to Log out/Exit\n");

            Console.WriteLine(menu.ToString());
            var selection = Console.ReadLine();

            while (selection != "1" && selection != "2")
            {
                Console.ResetColor();
                MenuValidation.InvalidPrompt(selection);
                selection = Console.ReadLine();
            }

            switch (selection)
            {
                case "1":

                    break;
                case "11":
                    Exit("11");
                    break;
                default:
                    Console.WriteLine("Invalid selection made, Choose the right option");
                    break;
            }
        }

        public static bool Exit(string num)
        {
            return string.Equals(num, "11", StringComparison.OrdinalIgnoreCase);
        }
    }
}
