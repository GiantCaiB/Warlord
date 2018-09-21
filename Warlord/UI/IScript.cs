using System;
namespace Warlord.UI
{
    public interface IScript
    {
        string Location { get; set; }
        string Description { get; set; }
        void HandleChoice(string choice);
    }
}
