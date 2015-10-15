using System;
using System.Drawing;
using LeagueSharp.Common;

namespace AfterKillSharp.Misc.Bootstrap
{
    class InternalMenu
    {
        public static void Initalize()
        {
            Menu rootMenu = CommonVariables.Menu;
            rootMenu = new Menu("AfterKillSharp", "ares.aks", true);
            rootMenu.AddItem(new MenuItem("OnOff", "Is Enabled?")).SetValue<Boolean>(true);
        }
    }
}
