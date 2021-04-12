using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WarOfLightModule
{
    class Hexagons
    {
        public Point Center;
        public int Size;
        private Point[] hexCorner;
        //private static StackCreature creature; Поля для значения существа


        public Hexagons()
        {
            Center = new Point();
            Size = new int();
        }

        public Hexagons(Point center, int size)
        {
            Center = center;
            Size = size;
            hexCorner = SetHexCorner(center, size);
        }

        public Point[] GetHexCorner()
        {
            return hexCorner;
        }

        private Point[] SetHexCorner(Point center, int size)
        {
            var hexCorner = new List<Point>();
            for (int i = 0; i < 6; i++)
            {
                var angle_deg = 60 * i - 30;
                var angle_rad = Math.PI / 180 * angle_deg;
                hexCorner.Add(new Point(center.X + Convert.ToInt32(size * Math.Cos(angle_rad)),
                                        center.Y + Convert.ToInt32(size * Math.Sin(angle_rad))));
            }
            hexCorner.Add(hexCorner[0]);

            return hexCorner.ToArray();
        }

        public static (int,int) GetWidthAndHeigth(int size)
        {
            return (2 * Convert.ToInt32(size * Math.Cos(Math.PI / 180 * 30)), 2 * size);
        }
    }
}
