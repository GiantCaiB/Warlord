using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weeb.Models
{
    interface ICharacter
    {
        string Name { get; set; }
        string Class { get; set; }
        decimal Intelligence { get; set; }
        decimal Vitality { get; set; }
        decimal HealthPoints { get; set; }
        decimal Strength { get; set; }
        decimal Agility { get; set; }
        decimal Luck { get; set; }
        decimal Experience { get; set; }
        decimal Level { get; set; }
        decimal AttackPower { get; set; }
        decimal DefencePower { get; set; }
        bool ActionFlag { get; set; }
        string CharacterInfo();
        string[] BattleInfo();
    }
}
