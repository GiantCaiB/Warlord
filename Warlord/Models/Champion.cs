using System;
using System.Text;

namespace Warlord.Models
{
    public class Champion:ICharacter
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
            exp = exp * (1 + Intelligence / 200);
            GameMaster.LevelUp(this, exp);
            PowerUp();
        }

        public string CharacterInfo()
        {
            StringBuilder sb = new StringBuilder("Champion:", 100);
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
            Intelligence = (decimal)(7 + ((double)Level) * 0.6);
            Vitality = (decimal)(10 + ((double)Level) * 1.1);
            Strength = (decimal)(12 + ((double)Level) * 1.5);
            Agility = (decimal)(9 + ((double)Level) * 1);
            Dominance = (decimal)(10 + ((double)Level) * 0.9);
        }
    }
}
