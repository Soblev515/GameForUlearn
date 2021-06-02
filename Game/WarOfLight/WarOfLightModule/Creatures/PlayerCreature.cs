using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WarOfLightModule
{
    public class Recruit : Creature
    {
        public Recruit()
        {
            cost = 20;
            basicGrowth = 22;
            attack = 1;
            defense = 1;
            damage = (1, 1);
            hp = 3;
            initiative = 8;
            move = 5;
            bitmap = new Bitmap("D:\\Project\\GameForUlearn\\Game\\WarOfLight\\WarOfLinghtForms\\Images\\PlayerCreature\\Recruit.png");
        }
    }

    public class Archer : Creature
    {
        public Archer()
        {
            cost = 50;
            basicGrowth = 12;
            attack = 4;
            defense = 3;
            damage = (2, 4);
            hp = 7;
            initiative = 9;
            move = 4;
            basicShots = 10;
            bitmap = new Bitmap("D:\\Project\\GameForUlearn\\Game\\WarOfLight\\WarOfLinghtForms\\Images\\PlayerCreature\\Archer.png");
        }
    }

    public class Swordsman : Creature
    {
        public Swordsman()
        {
            cost = 85;
            basicGrowth = 10;
            attack = 4;
            defense = 8;
            damage = (2, 4);
            hp = 16;
            initiative = 8;
            move = 4;
            bitmap = new Bitmap("D:\\Project\\GameForUlearn\\Game\\WarOfLight\\WarOfLinghtForms\\Images\\PlayerCreature\\Swordsman.png");
        }
    }

    public class Horseman : Creature
    {
        public Horseman()
        {
            cost = 1300;
            basicGrowth = 2;
            attack = 23;
            defense = 21;
            damage = (5, 10);
            hp = 90;
            initiative = 11;
            move = 7;
            bitmap = new Bitmap("D:\\Project\\GameForUlearn\\Game\\WarOfLight\\WarOfLinghtForms\\Images\\PlayerCreature\\Horseman.png");
        }
    }
}
