using System;
using System.Drawing;
using LeagueSharp.Common;

namespace AMastery.Misc.Bootstrap
{
    class InternalMenu
    {
        public static void Initalize()
        {
            CommonVariables.Menu = new Menu("AMastery", "ares.aks", true);
            CommonVariables.Menu.AddItem(new MenuItem("OnOff", "Enable?")).SetValue<bool>(true);
            CommonVariables.Menu.AddItem(new MenuItem("Enemy", "Trigger when killing an enemy?")).SetValue<bool>(true);
            CommonVariables.Menu.AddItem(new MenuItem("Ward", "Trigger when killing a ward?")).SetValue<bool>(false);
            CommonVariables.Menu.AddItem(new MenuItem("Assist", "Trigger when getting an assist?")).SetValue<bool>(false);
            CommonVariables.Menu.AddToMainMenu();
        }
    }
}
