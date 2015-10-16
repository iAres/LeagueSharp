using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AYasuo.Misc.MenuUtility;
using AYasuo.Misc.Constants;

using LeagueSharp;
using LeagueSharp.Common;

namespace AYasuo.Misc
{
    class CBootstrap
    {
        public static void Initalize()
        {
            Variables.Menu = new LeagueSharp.Common.Menu("AYasou by Ares", "ares.ayasou", true);
            Variables.Player = ObjectManager.Player;
            MenuGenerator.Initalize();
            CAYasuo.Initialize();
            Drawings.Initialize();
        }
    }
}
