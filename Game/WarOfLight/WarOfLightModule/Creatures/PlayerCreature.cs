using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WarOfLightModule
{
    public class Militiaman : Creature
    {
        public Militiaman()
        {
            cost = 20;
            basicGrowth = 22;
            attack = 1;
            defense = 1;
            damage = (1, 1);
            hp = 3;
            initiative = 8;
            move = 4;
        }
    }

    public class Spearman : Creature
    {
        public Spearman()
        {
            cost = 30;
            basicGrowth = 22;
            attack = 2;
            defense = 2;
            damage = (1, 2);
            hp = 7;
            initiative = 8;
            move = 4;
        }
    }
}
