using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weeb.Models
{
    class Thief:Hero
    {
        public Thief(string name, decimal level):base(name, level)
        {
            Class = "Thief";
            Intelligence = 6;
            Vitality = 6;
            Strength = 6;
            Agility = 10;
            Luck = 5;
            StatusUpdate();
        }
        public Thief(string name, decimal level, decimal intelligence, decimal vitality, decimal strength, decimal agility, decimal luck) : base(name, level, intelligence, vitality, strength, agility, luck)
        {
            Class = "Thief";
            StatusUpdate();
        }
        public override void PowerUp(decimal level)
        {
            Intelligence = (decimal)((double)Intelligence + ((double)Level) * 1);
            Vitality = (decimal)((double)Vitality + ((double)Level) * 0.5);
            Strength = (decimal)((double)Strength + ((double)Level) * 0.6);
            Agility = (decimal)((double)Agility + ((double)Level) * 1.5);
            Luck = (decimal)((double)Luck + ((double)Level) * 1.2);
            StatusUpdate();
        }
        private void StatusUpdate()
        {
            HealthPoints = Vitality;
            AttackPower = Agility/Level;
            DefencePower = Agility/ Level;
        }
    }
}
