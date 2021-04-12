using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarOfLightModule
{
    interface ICreture
    {
        int Cost { get; set; }
        int BasicGrowth { get; set; }
        int Attack { get; set; }
        int Defence { get; set; }
        (int, int) Damage { get; set; }
        int HP { get; set; }
        int Initiative { get; set; }
        int Move { get; set; }
        int BasicShots { get; set; }
        int BasicMana { get; set; }
    }

    class Creature: ICreture
    {
        int ICreture.Cost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ICreture.BasicGrowth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ICreture.Attack { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ICreture.Defence { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        (int, int) ICreture.Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ICreture.HP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ICreture.Initiative { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ICreture.Move { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ICreture.BasicShots { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ICreture.BasicMana { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
