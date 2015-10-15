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
    class CAfterKillSharp
    {
        public static void OnLoad()
        {
            Game.OnNotify += OnNotify;
        }

        static void OnNotify(GameNotifyEventArgs notifyArgs)
        {
            if (CommonVariables.Menu.Item("OnOff").GetValue<Boolean>())
            {
                if (notifyArgs.EventId.Equals("OnChampionKillPost"))
                {
                    Game.Say("/masterybadge");
                }
            }
        }
    }
}
