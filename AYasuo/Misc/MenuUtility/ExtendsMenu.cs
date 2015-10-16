using System;
using LeagueSharp;
using LeagueSharp.Common;

using AYasuo.Misc.Constants;

namespace AYasuo.Misc.MenuUtility
{
    static class ExtendsMenu
    {
        public static void AddBool(this Menu menu, string displayName, string name, bool defaultValue = false)
        {
            menu.AddItem(new MenuItem(name, displayName).SetValue(defaultValue));
        }

        public static T GetItemValue<T>(string item)
        {
            return Variables.Menu.Item(item).GetValue<T>();
        }
    }
}
