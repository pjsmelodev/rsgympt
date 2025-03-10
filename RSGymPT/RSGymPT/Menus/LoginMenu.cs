using RSGymPT.Utils;

namespace RSGymPT.Menus
{
    //<summary>
    //Class responsible for displaying the login menu and handling user interaction.
    //</summary>
    public class LoginMenu
    {
        //<summary>
        //Displays the login menu and waits for the user's input.
        //</summary>
        public static void DisplayLoginMenu() 
        {
            bool exit = false;

            while (!exit) 
            {
                Utilities.PrintTitle("Login Menu");

                Console.WriteLine("1. Login");
                Console.WriteLine("2. Exit");
                Console.Write("Select an option: ");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        // TODO: implementar logica
                        Utilities.PauseTerminal();
                        break;
                    case "2":
                        Console.WriteLine("Exiting...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Option not recognized. Please enter '1' or '2'.");
                        Utilities.PauseTerminal();
                        break;
                }
            }
        }
    }
}
