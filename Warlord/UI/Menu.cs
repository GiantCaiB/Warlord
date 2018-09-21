using System;
using System.Collections.Generic;

namespace Warlord.UI
{
    public class Menu:IMenu
    {
        protected int index;
        protected int choice;
        protected HashSet<string> menuOptions = new HashSet<string>();

        // draw the menu based on the option params
        public int DisplayMenu()
        {
            index = 1;
            PrintTitle();
            foreach(string menuOption in menuOptions)
            {
                Console.Write("".PadRight(Config.Config.padRight));
                Console.Write(">>>{0}.",index);
                Console.WriteLine(menuOption.PadRight(10));
                index++;
            }
            string input = Console.ReadLine();
            if(ValidateNumberic(input)&&ValidateRange(choice))
            {
                return HandleChoice(choice);
            }
            return 0;
        }

        // user's input must be a number
        bool ValidateNumberic(string input)
        {
            bool res = int.TryParse(input, out choice);
            if (res == false)
            {
                DisplayErrorMsg("Invalid input: choice must be numeric");
            }
            return res;
        }

        // input number must be within the range of options
        bool ValidateRange(int input)
        {
            if(input<1||input>index)
            {
                DisplayErrorMsg("Invalid input: entered choice is out of range");
                return false;
            }
            return true;
        }

        // display the error message and redraw the current menu
        public void DisplayErrorMsg(string errorMsg)
        {
            Console.WriteLine("{0}, press any key to continue...", errorMsg);
            Console.ReadKey();
            Console.Clear();
            DisplayMenu();
        }

        // handle the user's input
        protected virtual int HandleChoice(int input){
            return input;
        }

        protected virtual void PrintTitle(){}
    }
}
