using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weeb
{
    static class Game
    {
        // Initialise game
        public static void Init()
        {

            Refresh();
            var logo = new[]
            {
                @"            __      __                   ___                    __     ",
                @"           /\ \  __/\ \                 /\_ \                  /\ \    ",
                @"           \ \ \/\ \ \ \     __     _ __\//\ \     ___   _ __  \_\ \   ",
                @"            \ \ \ \ \ \ \  /'__`\  /\`'__\\ \ \   / __`\/\`'__\/'_` \  ",
                @"             \ \ \_/ \_\ \/\ \L\.\_\ \ \/  \_\ \_/\ \L\ \ \ \//\ \L\ \ ",
                @"              \ `\___x___/\ \__/.\_\\ \_\  /\____\ \____/\ \_\\ \___,_\",
                @"               '\/__//__/  \/__/\/_/ \/_/  \/____/\/___/  \/_/ \/__,_ /",
                @"",
                @"",
            };
            Console.WriteLine("\n");
            Console.SetWindowSize(Config.Config.srcWidth, Config.Config.srcHeight);
            foreach (string line in logo)
                Console.WriteLine(line);
            Console.ReadKey();
            Console.Write("".PadRight(Config.Config.padRight));
            Console.WriteLine("- Press Any Key -");
            Console.ReadKey();
            Refresh();
        }
        // Logic for input
        public static void Logic()
        {
            ConsoleKeyInfo key = Console.ReadKey();
        }
        // System message
        public static void Message(string msg)
        {
            Console.Write("".PadRight(Config.Config.padRight));
            Console.WriteLine(msg);
        }
        // Refresh screen
        public static void Refresh()
        {
            Console.Clear();
        }
    }
}
