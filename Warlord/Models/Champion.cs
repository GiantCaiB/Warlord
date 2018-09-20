using System;
using System.Text;

namespace Warlord.Models
{
    public class Champion:ICharacter
    {
        string name;
        public string Name { get => name; set => name = value; }
        double intelligence;
        public double Intelligence { get => intelligence; set => intelligence = value; }
        double vitality;
        public double Vitality { get => vitality; set => vitality = value; }
        double strength;
        public double Strength { get => strength; set => strength = value; }
        double agility;
        public double Agility { get => agility; set => agility = value; }
        double dominance;
        public double Dominance { get => dominance; set => dominance = value; }
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
        public Champion(decimal level, double intelligence, double vitality, double strength, double agility, double dominance)
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
            GameMaster.LevelUp(this, exp);
            PowerUp();
        }

        public string CharacterInfo()
        {
            StringBuilder sb = new StringBuilder("Champion", 100);
            sb.AppendFormat(" {0}\n", Name);
            sb.AppendFormat("LVL: {0}\n", Level);
            sb.AppendFormat("STR: {0}\n", Strength);
            sb.AppendFormat("INT: {0}\n", Intelligence);
            sb.AppendFormat("AGL: {0}\n", Agility);
            sb.AppendFormat("VIT: {0}\n", Vitality);
            sb.AppendFormat("DOM: {0}\n", Dominance);
            return sb.ToString();
        }

        void PowerUp()
        {
            Intelligence = 7 + ((double)level) * 0.6;
            Vitality = 10 + ((double)level) * 1.1;
            Strength = 12 + ((double)level) * 1.5;
            Agility = 9 + ((double)level) * 1;
            Dominance = 10 + ((double)level) * 0.9;
        }
    }
}
