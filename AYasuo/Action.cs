using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;

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
                if (Variables.Spells[SpellSlot.E].GetDamage(Minion) >= Minion.Health)
                {
                    if (SBlade.CastE(Minion))
                    {
                        continue;
                    }
                }
                if (Variables.Q[Spells.Utility.GetQState()].GetDamage(Minion) >= Minion.Health)
                {
                    if (STempest.CastQ(Minion))
                    {
                        continue;
                    }
                }
            }
        }

        public static void LaneClear()
        {
            List<Obj_AI_Base> MinionsInRange = MinionManager.GetMinions(Variables.Player.ServerPosition, Variables.Q[Spells.Utility.GetQState()].Range+30, MinionTypes.All, MinionTeam.NotAlly);
            foreach (Obj_AI_Base Minion in MinionsInRange.Where(Minion => Minion.IsValidTarget(Variables.Q[Spells.Utility.GetQState()].Range)))
            {
                if (Minion.Health + 45 < ObjectManager.Player.GetSpellDamage(Minion, SpellSlot.E))
                {
                    SBlade.CastE(Minion);
                }
                else if(Minion.Health + 45 <
                    (ObjectManager.Player.GetSpellDamage(Minion, SpellSlot.E) + ObjectManager.Player.GetSpellDamage(Minion, SpellSlot.Q, Spells.Utility.GetQState())) 
                    || Variables.Q[Spells.Utility.GetQState()].IsReady())
                {
                    SBlade.CastE(Minion);
                    if(Spells.Utility.GetQState() == 2)
                    {
                        List<Vector2> MinionsPos = MinionManager.GetMinionsPredictedPositions(MinionsInRange, Spells.Utility.GetQ3Delay, 60.0f, float.MaxValue, ObjectManager.Player.ServerPosition, 950.0f, false, SkillshotType.SkillshotLine);
                        MinionManager.FarmLocation FarmLocation = MinionManager.GetBestLineFarmLocation(MinionsPos, 70.0f, 1000);
                        Variables.Q[2].Cast(FarmLocation.Position);
                        return;
                    }
                    else
                    {
                        List<Vector2> MinionsPos = MinionManager.GetMinionsPredictedPositions(MinionsInRange, Spells.Utility.GetQDelay, 27.0f, float.MaxValue, ObjectManager.Player.ServerPosition, 467.0f, false, SkillshotType.SkillshotLine);
                        Vector2 ClosestMinion = Geometry.Closest(ObjectManager.Player.ServerPosition.To2D(), MinionsPos);
                        if(ObjectManager.Player.Distance(ClosestMinion) < 450.0f)
                        {
                            Variables.Q[Spells.Utility.GetQState()].Cast(ClosestMinion);
                            return;
                        }
                    }

                }
            }
        }

        public static void Flee()
        {
            Obj_AI_Base Object = ObjectManager.Get<Obj_AI_Base>()
                .Where(Min => Min.Type == GameObjectType.obj_AI_Minion && !Min.HasBuff("YasuoDashWrapper") && ObjectManager.Player.Distance(Min, false) <= 475)
                .OrderBy(Min => Min.Distance(Game.CursorPos))
                .FirstOrDefault();

            ObjectManager.Player.IssueOrder(GameObjectOrder.MoveTo, Game.CursorPos);
            if (!Variables.Spells[SpellSlot.E].IsReady())
            {
                return;
            }
            Variables.Spells[SpellSlot.E].Cast(Object);
            STempest.CastQ(Object);

            /** FLEE OVER WALLS (JUNGLE CREEPS)
             * 
            Vector3 test = new Vector3(7008, 5422, 53.10995f);
            Console.WriteLine("SERVER: " + ObjectManager.Player.ServerPosition.ToString() + "POS:" + test.ToString());
            ObjectManager.Player.IssueOrder(GameObjectOrder.MoveTo, test);
            if(ObjectManager.Player.ServerPosition != test)
            {
                return;
            }
            List<Obj_AI_Base> MinionsInRange = MinionManager.GetMinions(test, 100, MinionTypes.All, MinionTeam.Neutral, MinionOrderTypes.None);
            Console.WriteLine(MinionsInRange.Count().ToString());
            Variables.Spells[SpellSlot.E].Cast(MinionsInRange[0]);
             * 
             **/
        }
    }
}
