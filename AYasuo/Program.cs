using System;
using LeagueSharp;
using LeagueSharp.Common;

using AYasuo.Misc;
namespace AYasuo
{
    class Program
    {
        private static string ChampionName = "Yasuo";
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }
        static void Game_OnGameLoad(EventArgs eArgs)
        {
            if (!ObjectManager.Player.IsChampion(ChampionName))
            {
                return;
            }
            CBootstrap.Initalize();
        }
    }
}
