using System;
using System.Drawing;
using LeagueSharp.Common;

using AYasuo.Misc.Constants;

namespace AYasuo.Misc.MenuUtility
{
    class MenuGenerator
    {
        public static void Initalize()
        {
            Menu MainMenu = Variables.Menu;

            Menu OWMenu = new Menu("Orbwalker", "ares.ayasou.orbwalker");
            Variables.Orbwalker = new Orbwalking.Orbwalker(OWMenu);
            OWMenu.AddItem(new MenuItem("ares.ayasou.orbwalker.flee", "Flee").SetValue(new KeyBind('A', KeyBindType.Press, false)));
            MainMenu.AddSubMenu(OWMenu);

            Menu TSMenu = new Menu("Target Selector", "ares.ayasou.target_selector");
            TargetSelector.AddToMenu(TSMenu);
            MainMenu.AddSubMenu(TSMenu);

            Menu DWMenu = new Menu("Drawings", "ares.ayasou.drawings");
            DWMenu.AddBool("Draw AA Range", "ares.ayasou.drawings.aa", true);
            DWMenu.AddBool("Draw Q Range", "ares.ayasou.drawings.q", true);
            DWMenu.AddBool("Draw W Range", "ares.ayasou.drawings.w", true);
            DWMenu.AddBool("Draw E Range", "ares.ayasou.drawings.e", true);
            DWMenu.AddBool("Draw R Range", "ares.ayasou.drawings.r", true);
            MainMenu.AddSubMenu(DWMenu);


            MainMenu.AddToMainMenu();

        }
    }
}
