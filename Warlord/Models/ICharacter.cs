using System;
namespace Warlord.Models
{
    public interface ICharacter
    {
        string Name { get; set; }
        double Intelligence { get; set; }
        double Vitality { get; set; }
        double Strength { get; set; }
        double Agility { get; set; }
        double Dominance { get; set; }
        decimal Experience { get; set; }
        decimal Level { get; set; }
        void GainExp(decimal exp);
        string CharacterInfo();
    }
}
