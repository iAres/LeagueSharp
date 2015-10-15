using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueSharp;
using LeagueSharp.Common;

using AfterKillSharp.Misc;

namespace AfterKillSharp
{
    class CAMastery
    {
        static int[] killedStats;
        public static void OnLoad()
        {
            Game.OnNotify += OnNotify;

            killedStats = new int[3];
            killedStats[0] = ObjectManager.Player.ChampionsKilled;
            killedStats[1] = ObjectManager.Player.Assists;
            killedStats[2] = ObjectManager.Player.WardsKilled;
        }

        static void OnNotify(GameNotifyEventArgs notifyArgs)
        {
            if (CommonVariables.Menu.Item("OnOff").GetValue<bool>())
            {
                if (CheckKillStates())
                {
                    Game.Say("/masterybadge");
                }
            }
        }

        static bool CheckKillStates()
        {
            if (killedStats[0] < ObjectManager.Player.ChampionsKilled)
            {
                killedStats[0] = ObjectManager.Player.ChampionsKilled;
                return true;
            }
            else if (killedStats[1] < ObjectManager.Player.Assists && CommonVariables.Menu.Item("Assists").GetValue<bool>())
            {
                killedStats[1] = ObjectManager.Player.Assists;
                return true;
            }
            else if (killedStats[2] < ObjectManager.Player.WardsKilled && CommonVariables.Menu.Item("Wards").GetValue<bool>())
            {
                killedStats[2] = ObjectManager.Player.WardsKilled;
                return true;
            }
            return false;
        }

    }
}
