using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;

using AYasuo.Misc.Constants;
using AYasuo.Spells;

namespace AYasuo
{
    class Action
    {
        public static void LastHit()
        {
            List<Obj_AI_Base> MinionsInRange = MinionManager.GetMinions(Variables.Player.ServerPosition, Variables.Q[0].Range + 35);
            foreach(Obj_AI_Base Minion in MinionsInRange.Where(Minion=> Minion.IsValidTarget(Variables.Q[0].Range)))
            {
                if (Variables.Q[Spells.Utility.GetQState()].GetDamage(Minion) >= Minion.Health)
                {
                    if (STempest.CastQ(ObjectManager.Player.ServerPosition, Minion))
                    {
                        continue;
                    }
                }
                if(Variables.Spells[SpellSlot.E].GetDamage(Minion) >= Minion.Health)
                {
                    if(SBlade.CastE(ObjectManager.Player.ServerPosition, Minion))
                    {
                        continue;
                    }
                }
            }
        }
    }
}
