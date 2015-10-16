using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using Color = System.Drawing.Color;

using AYasuo.Misc.Constants;
using AYasuo.Misc.MenuUtility;

namespace AYasuo.Misc
{
    class Drawings
    {
        public static void Initialize()
        {
            Drawing.OnDraw += Drawing_OnDraw;
        }
        private static void Drawing_OnDraw(EventArgs eArgs)
        {
            if(ExtendsMenu.GetItemValue<bool>("ares.ayasou.drawings.aa"))
            {
                Render.Circle.DrawCircle(Variables.Player.Position, 175, Color.Green);
            }
            if (ExtendsMenu.GetItemValue<bool>("ares.ayasou.drawings.q"))
            {
                Render.Circle.DrawCircle(Variables.Player.Position, 475, Color.Green);
            }
            if (ExtendsMenu.GetItemValue<bool>("ares.ayasou.drawings.w"))
            {
                Render.Circle.DrawCircle(Variables.Player.Position, 400, Color.Green);
            }
            if (ExtendsMenu.GetItemValue<bool>("ares.ayasou.drawings.e"))
            {
                Render.Circle.DrawCircle(Variables.Player.Position, 475, Color.Green);
            }
            if (ExtendsMenu.GetItemValue<bool>("ares.ayasou.drawings.r"))
            {
                Render.Circle.DrawCircle(Variables.Player.Position, 1200, Color.Green);
            }
        }
    }
}
