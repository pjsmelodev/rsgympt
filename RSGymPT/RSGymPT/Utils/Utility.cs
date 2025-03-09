using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSGymPT.Utils
{
    public static class Utility
    {
        public static void PauseTerminal()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
