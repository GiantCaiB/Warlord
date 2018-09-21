using System;
namespace Warlord.UI
{
    public interface IMenu
    {
        int DisplayMenu();
        void DisplayErrorMsg(string errorMsg);
    }
}
