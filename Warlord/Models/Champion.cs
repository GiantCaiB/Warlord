using System;
using System.Text;

namespace Warlord.Models
{
    public class Champion:Character
    {
        public Champion(decimal level) : base(level)
        {
            PowerUp();
        }

        public Champion(decimal level, decimal intelligence, decimal vitality, decimal strength, decimal agility, decimal dominance) : base(level, intelligence, vitality, strength, agility, dominance)
        {
        }

        public override void GainExp(decimal exp)
        {
            base.GainExp(exp);
            PowerUp();
        }

        public override string CharacterInfo()
        {
            StringBuilder sb = new StringBuilder("Champion:", 100);
            sb.AppendFormat(base.CharacterInfo());
            return sb.ToString();
        }

        public void PowerUp()
        {
            Intelligence = (decimal)(7 + ((double)Level) * 0.6);
            Vitality = (decimal)(10 + ((double)Level) * 1.1);
            Strength = (decimal)(13 + ((double)Level) * 1.5);
            Agility = (decimal)(9 + ((double)Level) * 1);
            Dominance = (decimal)(9 + ((double)Level) * 0.9);
        }
    }
}
