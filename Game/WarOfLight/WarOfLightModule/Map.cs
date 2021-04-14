using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarOfLightModule
{
    public class Map
    {
        public readonly int CountX = 15;
        public readonly int CountY = 11;
        public readonly Hexagons[,] Field;

        private static int widthHex;
        private static int heightHex;
        public Map(Point startPoint, int sizeHexagons)
        {
            Field = new Hexagons[CountX, CountY];
            (widthHex, heightHex) = Hexagons.GetWidthAndHeigth(sizeHexagons);

            for (int j = 0; j < CountY; j++)
            {
                var center = j % 2 == 0 ? new Point(startPoint.X + widthHex,
                                                 startPoint.Y + sizeHexagons + (j / 2) * (3 * sizeHexagons) ) :
                                       new Point(startPoint.X + widthHex / 2,
                                                 startPoint.Y + 5 * heightHex / 4 + (j / 2) * (3 * sizeHexagons));
                for (int i = 0; i < CountX; i++)
                {
                    Field[i, j] = new Hexagons(center, sizeHexagons);
                    var a = new Creature();
                    Field[i, j].SetCreatureStack(new CreatureStack(a, 9));
                    center.X += widthHex; 
                }
            }
        }
    }
}
