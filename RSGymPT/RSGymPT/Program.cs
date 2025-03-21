﻿using RSGymPT.Utils;
using RSGymPT.UI;
using RSGymPT.Data;

namespace RSGymPT
{
    //<summary>
    //This class contains the main method.
    //</summary>
    class Program
    {
        //<summary>
        //This is the main method.
        //</summary>
        //<param name="args">The arguments passed to the application (not used).</param>
        static void Main(string[] args)
        {
            SeedData.Initialize();
            Console.WriteLine("Seed data initialized.");
            Helpers.PauseConsole();

            LoginMenu.ShowLoginMenu();
            Helpers.PauseConsole();
        }
    }
}