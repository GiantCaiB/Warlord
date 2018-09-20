using System;
namespace Warlord.Models
{
    public interface ICharacter
    {
        string Name { get; set; }
        decimal Intelligence { get; set; }
        decimal Vitality { get; set; }
        decimal Strength { get; set; }
        decimal Agility { get; set; }
        decimal Dominance { get; set; }
        decimal Experience { get; set; }
        decimal Level { get; set; }
        void GainExp(decimal exp);
        string CharacterInfo();
    }
}
