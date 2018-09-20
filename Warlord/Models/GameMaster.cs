using System;
namespace Warlord.Models
{
    public static class GameMaster
    {
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
                Console.WriteLine("Congrats, character levels up!");
            }
            else
            {
                character.Experience = currentExp + exp;
            }
        }

        static decimal MaxExp(decimal level)
        {
            return level * 250;
        }
    }
}
