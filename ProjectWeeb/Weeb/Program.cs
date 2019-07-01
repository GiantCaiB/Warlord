using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weeb.Models;
using Weeb.Scenes;

namespace Weeb
{
    class Program
    {

        static void Main(string[] args)
        {
            Game.Init();
            // Test Data
            Warrior danny = new Warrior("Danny", 2);
            Warrior kevin = new Warrior("Kevin",3);
            Thief prakash = new Thief("Prakash", 2);
            BattleScene testScene = new BattleScene(new List<ICharacter>() { kevin }, new List<ICharacter>() { danny });
            testScene.LoadScene();
            Console.ReadKey();
            danny.GainExp(1000);
            Console.ReadKey();
        }
    }
}
