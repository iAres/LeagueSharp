using LeagueSharp.Common;

using AMastery;
using AMastery.Misc;
using AMastery.Misc.Bootstrap;

namespace AMastery.Misc
{
    class CBootstrap
    {
        public static void Bootstrap()
        {
            InternalMenu.Initalize();
            CAMastery.OnLoad();
        }
    }
}
