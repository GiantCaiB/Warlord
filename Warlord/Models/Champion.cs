using System;
using System.Text;

namespace Warlord.Models
{
    public class Champion:ICharacter
    {
        string name;
        public string Name { get => name; set => name = value; }
        decimal intelligence;
        public decimal Intelligence { get => intelligence; set => intelligence = value; }
        decimal vitality;
        public decimal Vitality { get => vitality; set => vitality = value; }
        decimal strength;
        public decimal Strength { get => strength; set => strength = value; }
        decimal agility;
        public decimal Agility { get => agility; set => agility = value; }
        decimal dominance;
        public decimal Dominance { get => dominance; set => dominance = value; }
        decimal experience;
        public decimal Experience { get => experience; set => experience = value; }
        decimal level;
        public decimal Level { get => level; set => level = value; }

        // default values
        public Champion(decimal level)
        {
            Level = level;
            Experience = 0;
            PowerUp();
        }

        // customised charactor
        public Champion(decimal level, decimal intelligence, decimal vitality, decimal strength, decimal agility, decimal dominance)
        {
            Level = level;
            Experience = 0;
            Intelligence = intelligence;
            Vitality = vitality;
            Strength = strength;
            Agility = agility;
            Dominance = dominance;
        }

        public void GainExp(decimal exp)
        {
            exp = exp * (1 + Intelligence / 150);
            GameMaster.LevelUp(this, exp);
            PowerUp();
        }

        public string CharacterInfo()
        {
            StringBuilder sb = new StringBuilder("Champion", 100);
            sb.AppendFormat(" {0}\n", Name);
            sb.AppendFormat("LVL: {0}, EXP: {1}/{2}\n", Level, Math.Round(Experience, 2).ToString(), GameMaster.MaxExp(Level));
            sb.AppendFormat("STR: {0}\n", Strength);
            sb.AppendFormat("INT: {0}\n", Intelligence);
            sb.AppendFormat("AGL: {0}\n", Agility);
            sb.AppendFormat("VIT: {0}\n", Vitality);
            sb.AppendFormat("DOM: {0}\n", Dominance);
            return sb.ToString();
        }

        void PowerUp()
        {
            Intelligence = (decimal)(7 + ((double)level) * 0.6);
            Vitality = (decimal)(10 + ((double)level) * 1.1);
            Strength = (decimal)(12 + ((double)level) * 1.5);
            Agility = (decimal)(9 + ((double)level) * 1);
            Dominance = (decimal)(10 + ((double)level) * 0.9);
        }
    }
}
