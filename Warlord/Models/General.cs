using System;
using System.Text;

namespace Warlord.Models
{
    public class General:Character
    {
        public General(decimal level) : base(level)
        {
            PowerUp();
        }

        public General(decimal level, decimal intelligence, decimal vitality, decimal strength, decimal agility, decimal dominance) : base(level, intelligence, vitality, strength, agility, dominance)
        {
        }

        public override void GainExp(decimal exp)
        {
            base.GainExp(exp);
            PowerUp();
        }

        public override string CharacterInfo()
        {
            StringBuilder sb = new StringBuilder("General:", 100);
            sb.AppendFormat(base.CharacterInfo());
            return sb.ToString();
        }

        public void PowerUp()
        {
            Intelligence = (decimal)(10 + ((double)Level) * 1);
            Vitality = (decimal)(8 + ((double)Level) * 0.7);
            Strength = (decimal)(9 + ((double)Level) * 1);
            Agility = (decimal)(8 + ((double)Level) * 0.7);
            Dominance = (decimal)(14 + ((double)Level) * 1.5);
        }
    }
}
