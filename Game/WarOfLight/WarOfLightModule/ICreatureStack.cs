using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarOfLightModule
{
    public class Creture
    {
        private int Cost { get; set; }
        private int BasicGrowth { get; set; }
        private int Attack { get; set; }
        private int Defence { get; set; }
        private (int, int) Damage { get; set; }
        private int HP { get; set; }
        private int Initiative { get; set; }
        private int Move { get; set; }
        private int BasicShots { get; set; }
        private int BasicMana { get; set; }
    }

    public class CreaturStack: Creture
    {
        public int count;
    }
}
