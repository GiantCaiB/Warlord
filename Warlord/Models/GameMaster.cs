using System;
using Warlord.UI;

namespace Warlord.Models
{
    public static class GameMaster
    {
        public static ICharacter CreateNewRole()
        {
            ICharacter character;
            Console.Clear();
            Console.WriteLine("\n\n ===Create A New Character===".PadRight(Config.Config.padRight));
            Console.WriteLine("\n\n Please give me a name:\n".PadRight(Config.Config.padRight));
            string name = Console.ReadLine();
            Console.WriteLine("\nOk, your name is {0}.\n", name);
            ChooseClassMenu classMenu = new ChooseClassMenu();
            switch (classMenu.DisplayMenu())
            {
                case 1:
                    character = new Champion(1);
                    break;
                case 2:
                    character = new Champion(1);
                    break;
                case 3:
                    character = new Champion(1);
                    break;
                default:
                    character = new Champion(1);
                    break;
            }
            character.Name = name;
            Console.Clear();
            Console.WriteLine("\n\n Character Created!\n");
            Console.WriteLine(character.CharacterInfo());
            return character;
        }

        public static void LevelUp(ICharacter character, decimal exp)
        {
            decimal currentLevel = character.Level;
            decimal currentExp = character.Experience;
            decimal maxExp = MaxExp(currentLevel);
            // level up or not
            if(currentExp+exp >= maxExp) 
            {
                character.Level++;
                character.Experience = currentExp + exp - maxExp;
                Console.WriteLine("\nCongrats, character levels up!\n");
            }
            else
            {
                character.Experience = currentExp + exp;
            }
        }

        public static decimal MaxExp(decimal level)
        {
            return level * 250;
        }
    }
}
