using System;
using System.Collections.Generic;
using Warlord.Models;

namespace Warlord.UI
{
    public class ChooseClassMenu : Menu
    {
        public ChooseClassMenu()
        {
            menuOptions = new HashSet<string>()
            {
                "General",
                "Champion",
                "Warlock"
            };
        }

        protected override void PrintTitle()
        {
            Console.WriteLine("Now among those classes below, choose your destination:");
        }
    }
}
