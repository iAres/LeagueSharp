using System;
using LeagueSharp;
using LeagueSharp.Common;
using AfterKillSharp.Misc;

namespace AfterKillSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }
        static void Game_OnGameLoad(EventArgs eventArgs)
        {
            CBootstrap.Bootstrap();
            Game.PrintChat("<b>AfterKill</b> loaded. Written by Ares.");
        }
    }
}
