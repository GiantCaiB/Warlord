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

        protected override int HandleChoice(int input)
        {
            switch(input){
                case 1:
                    ICharacter character = GameMaster.CreateNewRole();
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("".PadRight(Config.Config.padRight));
                    Console.WriteLine("@ Author: Wenfei(Danny) YU");
                    Console.Write("".PadRight(Config.Config.padRight));
                    Console.WriteLine("@ Sep 2018");
                    Console.ReadKey();
                    Console.Clear();
                    DisplayMenu();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
            return input;
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
            Console.WriteLine("\n");
            foreach (string line in arr)
                Console.WriteLine(line);
        }
    }
}
