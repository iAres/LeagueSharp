using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SharpDX;
using LeagueSharp;

using AYasuo.Misc.Constants;

namespace AYasuo.Spells
{
    class Utility
    {
        public static float GetQDelay
        {
            get
            {
                return (1 - Math.Min((Variables.Player.AttackSpeedMod - 1) * 0.006f, 0.66f)) * 0.4f;
            }
        }
        public static float GetQ3Delay
        {
            get
            {
                return (1 - Math.Min((Variables.Player.AttackSpeedMod - 1) * 0.006f, 0.66f)) * 0.5f;
            }
        }

        public static Vector3 V3E(Vector3 from, Vector3 to, float distance)
        {
            return from + Vector3.Normalize(to - from) * distance;
        }

        public static int GetQState()
        {
            if (ObjectManager.Player.GetBuff("yasuoq2") != null)
            {
                return 1;
            }
            else if (ObjectManager.Player.GetBuff("yasuoq3w") != null)
            {
                return 2;
            }
            return 0;
        }

    }
}
