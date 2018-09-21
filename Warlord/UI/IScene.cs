using System;
using Warlord.Models;

namespace Warlord.UI
{
    public interface IScene
    {
        ICharacter Role { get; set; }
        IScript Script { get; set; }
        void LoadScene();
    }
}
