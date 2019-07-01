using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weeb.Models;

namespace Weeb.Scenes
{
    interface IScene
    {
        List<ICharacter> Heroes { get; set; }
        void LoadScene();
    }
}
