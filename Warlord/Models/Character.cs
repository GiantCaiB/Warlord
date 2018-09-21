using System;
using System.Text;

namespace Warlord.Models
{
    public class Character:ICharacter
    {
        public string Name { get; set; }
        public decimal Intelligence { get; set; }
        public decimal Vitality { get; set; }
        public decimal Strength { get; set; }
        public decimal Agility { get; set; }
        public decimal Dominance { get; set; }
        public decimal Experience { get; set; }
        public decimal Level { get; set; }

        // default values
        public Character(decimal level)
        {
            Level = level;
            Experience = 0;
        }

        // customised charactor
        public Character(decimal level, decimal intelligence, decimal vitality, decimal strength, decimal agility, decimal dominance)
        {
            Level = level;
            Experience = 0;
            Intelligence = intelligence;
            Vitality = vitality;
            Strength = strength;
            Agility = agility;
            Dominance = dominance;
        }

        public virtual void GainExp(decimal exp)
        {
            exp = exp * (1 + Intelligence / 200);
            GameMaster.LevelUp(this, exp);
        }

        public virtual string CharacterInfo()
        {
            StringBuilder sb = new StringBuilder("", 100);
            sb.AppendFormat(" {0}\n", Name);
            sb.AppendFormat("LVL: {0}, EXP: {1}/{2}\n", Level, Math.Round(Experience, 2).ToString(), GameMaster.MaxExp(Level));
            sb.AppendFormat("STR: {0}\n", Strength);
            sb.AppendFormat("INT: {0}\n", Intelligence);
            sb.AppendFormat("AGL: {0}\n", Agility);
            sb.AppendFormat("VIT: {0}\n", Vitality);
            sb.AppendFormat("DOM: {0}\n", Dominance);
            return sb.ToString();
        }
    }
}
