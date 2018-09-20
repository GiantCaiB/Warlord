using System;
using System.Collections.Generic;
using Warlord.Models;

namespace Warlord.UI
{
    public class MainMenu : Menu
    {
        public MainMenu()
        {
            menuOptions = new HashSet<string>()
            {
                "New Game",
                "Credits",
                "Exit"
            };
            DisplayMenu();
        }

        protected override void HandleChoice(int input)
        {
            switch(input){
                case 1:
                    Console.Clear();
                    Champion champion = new Champion(1);
                    champion.Name = "Danny";
                    Console.WriteLine(champion.CharacterInfo());
                    champion.GainExp(260);
                    Console.WriteLine(champion.CharacterInfo());
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("".PadRight(Config.Config.padRight));
                    Console.WriteLine("Author: Wenfei(Danny) YU");
                    Console.Write("".PadRight(Config.Config.padRight));
                    Console.WriteLine("@ Sep 2018");
                    Console.ReadKey();
                    DisplayMenu();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        protected override void PrintTitle()
        {
            var arr = new[]
            {
                @" __      __                   ___                    __     ",
                @"/\ \  __/\ \                 /\_ \                  /\ \    ",
                @"\ \ \/\ \ \ \     __     _ __\//\ \     ___   _ __  \_\ \   ",
                @" \ \ \ \ \ \ \  /'__`\  /\`'__\\ \ \   / __`\/\`'__\/'_` \  ",
                @"  \ \ \_/ \_\ \/\ \L\.\_\ \ \/  \_\ \_/\ \L\ \ \ \//\ \L\ \ ",
                @"   \ `\___x___/\ \__/.\_\\ \_\  /\____\ \____/\ \_\\ \___,_\",
                @"    '\/__//__/  \/__/\/_/ \/_/  \/____/\/___/  \/_/ \/__,_ /",
                @"",
                @"",
            };
            Console.WriteLine("\n\n");
            foreach (string line in arr)
                Console.WriteLine(line);
        }
    }
}
