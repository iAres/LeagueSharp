using System;
using LeagueSharp;
using LeagueSharp.Common;
using AMastery.Misc;

namespace AMastery
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
            Game.PrintChat("<b><font color='#FF0000'>A</font>Mastery</b> loaded. Written by Ares.");
        }
    }
}
