using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarOfLightModule
{
    public class EnemyLogic
    {
        private CreatureStack FindPlayerStack(GameManager gm)
        {
            var creture = new CreatureStack(new Creature(), 0);
            var min = double.MaxValue;
            foreach (var playerStack in gm.playerStacks)
                if (GetDistantion(gm.ActivCreature, playerStack.Coord) < min)
                    (creture, min) = (playerStack, GetDistantion(playerStack, playerStack.Coord));
            return creture;
        } 

        public ((int, int), (int, int)) StepEnemyStack(GameManager gm)
        {
            var playerStack = FindPlayerStack(gm);
            if (gm.ActivCreature.Creature.BasicShots != 0)
            {
                gm.RangeAttack(playerStack.Coord.Item2, playerStack.Coord.Item1);
                return (playerStack.Coord, gm.ActivCreature.Coord);
            }
            var hexagons = gm.GetHexagonsForMove(gm.ActivCreature, gm.ActivCreature.Creature.Move);
            var resultHexagon = gm.ActivCreature.Coord;
            var min = double.MaxValue;
            if (hexagons.Contains(playerStack.Coord))
            {
                var hexagonsForAttack = gm.GetHexagonsForMove(gm.ActivCreature, 1);
                foreach (var hexagon in hexagonsForAttack)
                    if (GetDistantion(gm.ActivCreature, hexagon) < min)
                        (resultHexagon, min) = (hexagon, GetDistantion(playerStack, hexagon));
                gm.MiddleAttack(playerStack.Coord.Item1, playerStack.Coord.Item2);
            }
            else
            {
                foreach (var hexagon in hexagons)
                    if (GetDistantion(playerStack, hexagon) < min)
                        (resultHexagon, min) = (hexagon, GetDistantion(playerStack, hexagon));
            }

            return (playerStack.Coord, resultHexagon);
        }

        private double GetDistantion(CreatureStack playerStack, (int, int) hexagon)
        {
            return Math.Sqrt(Math.Pow(playerStack.Coord.Item1 - hexagon.Item1, 2)
                        + Math.Pow(playerStack.Coord.Item2 - hexagon.Item2, 2));
        }
    }
}
