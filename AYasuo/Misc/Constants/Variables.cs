using System;
using System.Collections.Generic;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;

namespace AYasuo.Misc.Constants
{
    class Variables
    {

        public static Dictionary<SpellSlot, Spell> Spells = 
            new Dictionary<SpellSlot, Spell>
            {
                { SpellSlot.W, new Spell(SpellSlot.W, 400) },
                { SpellSlot.E, new Spell(SpellSlot.E, 475) },
                { SpellSlot.R, new Spell(SpellSlot.R, 1200) }
            };

        public static List<Spell> Q = new List<Spell>
        {
            new Spell(SpellSlot.Q, 475),
            new Spell(SpellSlot.Q, 375),
            new Spell(SpellSlot.Q, 900)
        };

        public static Obj_AI_Hero Player { get; set; }
        public static Menu Menu { get; set; }
        public static Orbwalking.Orbwalker Orbwalker { get; set; }
        public static Dictionary<string, Vector2> Positions { get; set; }
    }
}
