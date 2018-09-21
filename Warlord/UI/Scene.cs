using System;
using Warlord.Models;

namespace Warlord.UI
{
    public class Scene:IScene
    {
        public ICharacter Role { get; set; }
        public IScript Script { get; set; }

        public Scene(ICharacter role, IScript script)
        {
            Role = role;
            Script = script;
        }

        public void LoadScene()
        {
            Console.Clear();
            Console.WriteLine("\n----{0}\n\n",Script.Location);
            Console.WriteLine("\n{0}\n\n",Script.Description);
            string choice = Console.ReadLine();
            Script.HandleChoice(choice);
        }
    }
}
