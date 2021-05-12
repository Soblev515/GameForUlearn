using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarOfLightModule
{
    public class CreatureStack
    {
        public int NumCreatures { get; private set; }
        public (int, int) Coord;
        public Creature Creature;

        public CreatureStack(Creature creture, int numCreature)
        {
            Creature = creture;
            NumCreatures = numCreature;
        }

        public CreatureStack(Creature creture, int numCreature, (int, int) coord)
        {
            Creature = creture;
            NumCreatures = numCreature;
            SetCoord(coord);
        }

        public void SetCoord((int, int) coord)
        {
            if(coord.Item1>=0 && coord.Item2>=0)
                Coord = coord;
        }

        public void Attack(CreatureStack Attacked)
            => Attacked.NumCreatures -= TotalDamage(Attacked);

        public void Shot(CreatureStack Attacked)
        {
            Attacked.NumCreatures -= TotalDamage(Attacked);
            Creature.Shot();
        }

        private int TotalDamage(CreatureStack Attacked)
            => (int)(NumCreatures * BaseDamage() * AttackDefenseModifier(Creature.Attack, Attacked.Creature.Defense));

        private int BaseDamage()
        {
            var random = new Random();
                        
            var baseDamage = Creature.Damage.Item1 + random.Next(0, 1) * (Creature.Damage.Item2 - Creature.Damage.Item1);
            return baseDamage;
        }
        
        private static double AttackDefenseModifier(int attackerAttack, int defendedDefense)
        {
            if (attackerAttack >= defendedDefense)
                return 1 + (attackerAttack - defendedDefense) * 0.05;
            return 1 / 1 + (attackerAttack - defendedDefense) * 0.05;
        }
    }
}
