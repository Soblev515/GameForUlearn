using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarOfLightModule.Creatures
{
    public class Thief : Creature
    {
        public Thief()
        {
            cost = 30;
            basicGrowth = 22;
            attack = 2;
            defense = 2;
            damage = (1, 2);
            hp = 7;
            initiative = 5;
            move = 4;
            bitmap = new Bitmap("D:\\Project\\GameForUlearn\\Game\\WarOfLight\\WarOfLinghtForms\\Images\\EnemyCreature\\Bandits\\Thief.png");
        }
    }

    public class Thrower : Creature
    {
        public Thrower()
        {
            cost = 80;
            basicGrowth = 12;
            attack = 4;
            defense = 4;
            damage = (2, 8);
            hp = 10;
            initiative = 6;
            move = 4;
            basicShots = 12;
            bitmap = new Bitmap("D:\\Project\\GameForUlearn\\Game\\WarOfLight\\WarOfLinghtForms\\Images\\EnemyCreature\\Bandits\\Thrower.png");
        }
    }

    public class Bully : Creature
    {
        public Bully()
        {
            cost = 80;
            basicGrowth = 12;
            attack = 4;
            defense = 5;
            damage = (2, 8);
            hp = 12;
            initiative = 5;
            move = 3;
            bitmap = new Bitmap("D:\\Project\\GameForUlearn\\Game\\WarOfLight\\WarOfLinghtForms\\Images\\EnemyCreature\\Bandits\\Bully.png");
        }
    }

    public class Sworman : Creature
    {
        public Sworman()
        {
            cost = 85;
            basicGrowth = 10;
            attack = 5;
            defense = 15;
            damage = (2, 8);
            hp = 15;
            initiative = 5;
            move = 4;
            bitmap = new Bitmap("D:\\Project\\GameForUlearn\\Game\\WarOfLight\\WarOfLinghtForms\\Images\\EnemyCreature\\Army\\Sworman.png");
        }
    }

    public class Crossbowman : Creature
    {
        public Crossbowman()
        {
            cost = 50;
            basicGrowth = 12;
            attack = 5;
            defense = 3;
            damage = (2, 5);
            hp = 8;
            initiative = 9;
            move = 4;
            basicShots = 8;
            bitmap = new Bitmap("D:\\Project\\GameForUlearn\\Game\\WarOfLight\\WarOfLinghtForms\\Images\\EnemyCreature\\Army\\Crossbowman.png");
        }
    }

    public class Axeman : Creature
    {
        public Axeman()
        {
            cost = 80;
            basicGrowth = 12;
            attack = 6;
            defense = 6;
            damage = (5, 8);
            hp = 20;
            initiative = 3;
            move = 3;
            bitmap = new Bitmap("D:\\Project\\GameForUlearn\\Game\\WarOfLight\\WarOfLinghtForms\\Images\\EnemyCreature\\Army\\Axeman.png");
        }
    }
}
