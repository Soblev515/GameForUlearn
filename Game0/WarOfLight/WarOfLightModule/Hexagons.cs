using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WarOfLightModule
{
    class Hexagons
    {
        public static Point Center;
        public static int Size;
        private static List<Point> hexCorner;
        private static int height;

        public Hexagons(Point center, int size)
        {
            Center = center;
            Size = size;
            hexCorner = SetHexCorner(center, size);
            height = size * 2;
        }

        public List<Point> GetHexCorner()
        {
            return hexCorner;
        }

        private List<Point> SetHexCorner(Point center, int size)
        {
            var hexCorner = new List<Point>();
            for (int i = 0; i < 6; i++)
            {
                var angle_deg = 60 * i - 30;
                var angle_rad = Math.PI / 180 * angle_deg;
                hexCorner.Add(new Point(center.X + (int)(size * Math.Cos(angle_rad)),
                                        center.Y + (int)(size * Math.Sin(angle_rad))));
            }

            return hexCorner;
        }
    }
}
