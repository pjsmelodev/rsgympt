using RSGymPT.Utils;
using RSGymPT.Menus;

namespace RSGymPT
{
	//<summary>
	//The main entry point for the application.
	//Responsible for initializing the login menu.
	//</summary>
    public class Program
	{
		//<summary>
		//Main method that starts the application.
		//</summary>
		//<param name = "args" > The command-line arguments (not used).</param>
        public static void Main(string[] args)
		{
			LoginMenu.DisplayLoginMenu();

            Utilities.PauseTerminal();
        }
	}
}