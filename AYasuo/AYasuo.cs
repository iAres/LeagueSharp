using System;
using System.Collections.Generic;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;

using AYasuo.Spells;
using AYasuo.Misc.Constants;

namespace AYasuo
{
    class CAYasuo
    {
        public static void Initialize()
        {
            STempest.Initialize();
            SBlade.Initialize();
            Console.Clear();
            Game.OnUpdate += Game_OnUpdate;
        }

        private static void Game_OnUpdate(EventArgs eArgs)
        {
            switch(Variables.Orbwalker.ActiveMode)
            {
                case Orbwalking.OrbwalkingMode.LastHit:
                    Action.LastHit();
                    break;
            }
        }
    }
}
