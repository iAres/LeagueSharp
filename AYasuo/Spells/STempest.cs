using System;
using System.Collections.Generic;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;

using AYasuo.Misc.Constants;
using AYasuo.Spells;


namespace AYasuo.Spells
{
    class STempest 
    {
        private static List<Spell> GetQ
        {
            get { return Variables.Q; }
        }
        public static void Initialize()
        {
            GetQ[0].SetSkillshot(Utility.GetQDelay, 20.0f, float.MaxValue, false, SkillshotType.SkillshotLine);
            GetQ[1].SetSkillshot(Utility.GetQDelay, 20.0f, float.MaxValue, false, SkillshotType.SkillshotLine);
            GetQ[2].SetSkillshot(Utility.GetQ3Delay, 90.0f, float.MaxValue, false, SkillshotType.SkillshotCircle);
        }
        public static bool CastQ(Vector3 Position, Obj_AI_Base Target)
        {
            Console.WriteLine("tried to execute q.");
            if (ObjectManager.Player.IsDashing() || !Variables.Q[Utility.GetQState()].IsReady())
            {
                return false;
            }
            Variables.Q[Utility.GetQState()].Cast(Target);
            return true;
        }
    }
}
