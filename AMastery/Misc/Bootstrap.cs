using LeagueSharp.Common;

using AfterKillSharp;
using AfterKillSharp.Misc;
using AfterKillSharp.Misc.Bootstrap;

namespace AfterKillSharp.Misc
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
