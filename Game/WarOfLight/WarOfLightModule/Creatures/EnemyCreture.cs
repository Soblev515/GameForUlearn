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
            initiative = 8;
            move = 4;
            bitmap = new Bitmap("D:\\Project\\GameForUlearn\\Game\\WarOfLight\\WarOfLinghtForms\\Images\\EnemyCreature\\Bandits\\Thief.png");
        }
    }
}
