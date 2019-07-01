using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weeb.Models
{
    class Hero : ICharacter
    {
        public decimal Agility { get; set; }

        public decimal Luck { get; set; }

        public decimal Experience { get; set; }

        public decimal Intelligence { get; set; }

        public decimal Level { get; set; }

        public string Name { get; set; }
        public string Class { get; set; }

        public decimal Strength { get; set; }

        public decimal Vitality { get; set; }

        public decimal HealthPoints { get; set; }
        public decimal AttackPower { get; set; }
        public decimal DefencePower { get; set; }
        public bool ActionFlag { get; set; }
        // default values
        public Hero(string name, decimal level)
        {
            Name = name;
            Level = level;
            Experience = 0;
            PowerUp(Level);
        }

        // customised charactor
        public Hero(string name, decimal level, decimal intelligence, decimal vitality, decimal strength, decimal agility, decimal luck)
        {
            Name = name;
            Level = level;
            Experience = 0;
            Intelligence = intelligence;
            Vitality = vitality;
            Strength = strength;
            Agility = agility;
            Luck = luck;
        }
        public string CharacterInfo()
        {
            StringBuilder sb = new StringBuilder("", 100);
            sb.AppendFormat("{0}\n", Name);
            sb.AppendFormat("{0}\n", Class);
            sb.AppendFormat("LVL: {0}\n", Level);
            sb.AppendFormat("EXP: {0}/{1}\n", Math.Round(Experience, 2).ToString(), MaxExp(Level));
            sb.AppendFormat("HP: {0}\n", Vitality);
            sb.AppendFormat("=====\n");
            sb.AppendFormat("STR: {0}\n", Strength);
            sb.AppendFormat("INT: {0}\n", Intelligence);
            sb.AppendFormat("AGL: {0}\n", Agility);
            sb.AppendFormat("LUK: {0}\n", Luck);
            return sb.ToString();
        }
        public string[] BattleInfo()
        {
            var battleInfo = new[]
            {
                "============".PadRight(10),
                " "+Name.PadRight(10),
                " "+Class.PadRight(10),
                " HP: "+HealthPoints.ToString()+"/"+Vitality.ToString().PadRight(4),
                " LVL: "+Level.ToString().PadRight(5),
                " EXP: "+Math.Round(Experience, 2)+"/"+MaxExp(Level).ToString().PadRight(3),
                " ATK: "+String.Format("{0:.#}",AttackPower).PadRight(5),
                " DEF: "+String.Format("{0:.#}",DefencePower).PadRight(5),
                "============".PadRight(10)
            };
            return battleInfo;
        }
        private decimal MaxExp(decimal level)
        {
            return 3 * level + 1;
        }
        public decimal GainExp(decimal gainedExp)
        {
            if (Experience + gainedExp < MaxExp(Level))
            {
                Experience += gainedExp;
            }
            else
            {
                while (Experience + gainedExp >= MaxExp(Level))
                {
                    Experience += gainedExp - MaxExp(Level);
                    gainedExp -= MaxExp(Level);
                    Level++;
                }
                StringBuilder sb = new StringBuilder("", 100);
                sb.AppendFormat("Congrat! {0} has level up to {1}",Name,Level);
                PowerUp(Level);
                HealthPoints = Vitality;
                Game.Message(sb.ToString());
            }
            return Level;
        }
        public virtual void PowerUp(decimal level)
        {
            Intelligence = (decimal)(4 + ((double)Level) * 1);
            Vitality = (decimal)(9 + ((double)Level) * 1);
            Strength = (decimal)(4 + ((double)Level) * 1);
            Agility = (decimal)(4 + ((double)Level) * 1);
            Luck = (decimal)(4 + ((double)Level) * 1);
        }
    }
}
