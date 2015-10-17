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
            Variables.Q[0].SetSkillshot(Utility.GetQDelay, 20.0f, float.MaxValue, false, SkillshotType.SkillshotLine);
            Variables.Q[1].SetSkillshot(Utility.GetQDelay, 20.0f, float.MaxValue, false, SkillshotType.SkillshotLine);
            Variables.Q[2].SetSkillshot(Utility.GetQ3Delay, 90.0f, float.MaxValue, false, SkillshotType.SkillshotLine);

            
        }
        public static bool CastQ(Obj_AI_Base Target)
        {
            if (ObjectManager.Player.IsDashing() || !Variables.Q[Utility.GetQState()].IsReady())
            {
                return false;
            }
            Variables.Q[Utility.GetQState()].Cast(Target);
            return true;
        }
    }
}
