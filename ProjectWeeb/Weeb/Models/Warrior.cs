using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weeb.Models
{
    class Warrior:Hero
    {
        public Warrior(string name, decimal level):base(name, level)
        {
            Class = "Warrior";
            Intelligence = 4;
            Vitality = 10;
            Strength = 10;
            Agility = 5;
            Luck = 4;
            StatusUpdate();
        }
        public Warrior(string name, decimal level, decimal intelligence, decimal vitality, decimal strength, decimal agility, decimal luck) : base(name, level, intelligence, vitality, strength, agility, luck)
        {
            Class = "Warrior";
            StatusUpdate();
        }
        public override void PowerUp(decimal level)
        {
            Intelligence = (decimal)((double)Intelligence + ((double)Level) * 0.6);
            Vitality = (decimal)((double)Vitality + ((double)Level) * 1.1);
            Strength = (decimal)((double)Strength + ((double)Level) * 1.5);
            Agility = (decimal)((double)Agility + ((double)Level) * 1);
            Luck = (decimal)((double)Luck + ((double)Level) * 1);
            StatusUpdate();
        }
        private void StatusUpdate()
        {
            HealthPoints = Vitality;
            AttackPower = (Strength + Luck)/Level;
            DefencePower = Vitality/Level;
        }
    }
}
