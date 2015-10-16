﻿using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;

using AYasuo.Misc.Constants;
using AYasuo.Spells;

namespace AYasuo.Spells
{
    class SBlade
    {
        private static Spell E
        {
            get { return Variables.Spells[SpellSlot.E]; }
        }
        public static void Initialize()
        {
            E.SetTargetted(E.Instance.SData.SpellCastTime, float.MaxValue);
        }

        public static bool CastE(Vector3 Position, Obj_AI_Base Target)
        {
            if(!E.IsReady() || !E.IsInRange(Target) || Utility.V3E(ObjectManager.Player.ServerPosition, Target.ServerPosition, E.Range).UnderTurret(true))
            {
                return false;
            }
            E.Cast(Target);
            return true;
        }
    }
}
