using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarOfLightModule
{
    public class CreatureStack
    {
        public readonly int NumCreatures;

        private Creature Creature;

        public CreatureStack(Creature creture, int numCreature)
        {
            Creature = creture;
            NumCreatures = numCreature;
        }

        public int TotalDamage(CreatureStack Attacked)
        {
            return (int)(NumCreatures * BaseDamage() * AttackDefenseModifier(Creature.Attack, Attacked.Creature.Defense));
        }

        private int BaseDamage()
        {
            var random = new Random();
            var a = new Militiaman();
            
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
