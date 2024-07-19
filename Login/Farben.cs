using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public static class Farben
    {
        public static Color DeepSea => ColorTranslator.FromHtml("#003a47");
        public static Color AfterStorm => ColorTranslator.FromHtml("#004757");
        public static Color WildSea => ColorTranslator.FromHtml("#005163");
        public static Color BlueLagoon => ColorTranslator.FromHtml("#005c70");
        public static Color DarkSurfie => ColorTranslator.FromHtml("#00637a");
        public static Color BlueShadow => ColorTranslator.FromHtml("#00718a");
        public static Color Surfie => ColorTranslator.FromHtml("#007f9c");
        public static Color CaribicBlue => ColorTranslator.FromHtml("#9bcfde");
        public static Color IceBlue  => ColorTranslator.FromHtml("#deeef2");
        public static Color Carbon  => ColorTranslator.FromHtml("#04161c");
        public static Color Rock  => ColorTranslator.FromHtml("#16282e");
        public static Color DeepSky  => ColorTranslator.FromHtml("#3d494d");
        public static Color ColdMountain   => ColorTranslator.FromHtml("#5e737a");
        public static Color Mystic  => ColorTranslator.FromHtml("#ccd5da");
        public static Color Illusion  => ColorTranslator.FromHtml("#d6dee3");
        public static Color Iron  => ColorTranslator.FromHtml("#dae1e5");
        public static Color ArcticGrey  => ColorTranslator.FromHtml("#dee4e8");
        public static Color Sergiy  => ColorTranslator.FromHtml("#e8eef0");
        public static Color ArcticWhite  => ColorTranslator.FromHtml("#e4e9ec");
        public static Color IceWhite  => ColorTranslator.FromHtml("#f2f6f7");
        public static Color StormyBlue  => ColorTranslator.FromHtml("#32606b");
        public static Color LightStormy  => ColorTranslator.FromHtml("#3c707d");
        public static Color DarkSmoky  => ColorTranslator.FromHtml("#4e7987");
        public static Color SmokyBlue => ColorTranslator.FromHtml("#688b99");
        public static Color BermudaGrey  => ColorTranslator.FromHtml("#8ba8b2");
        public static Color FrostyBlue  => ColorTranslator.FromHtml("#d0d9de");
        public static Color FreshFir  => ColorTranslator.FromHtml("#08a169");
        public static Color BabyFir  => ColorTranslator.FromHtml("#d8f0e4");
        public static Color OldRuby  => ColorTranslator.FromHtml("#db1a37");
        public static Color BabyRuby  => ColorTranslator.FromHtml("#f6eff0");
        public static Color SisterAct  => ColorTranslator.FromHtml("#eb8c0c");
        public static Color CrazyDaisy  => ColorTranslator.FromHtml("#f5e622");
        public static Color ButtonOpacity => ColorTranslator.FromHtml("#9cccd7");
    }
}
