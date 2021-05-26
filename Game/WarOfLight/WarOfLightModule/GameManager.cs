using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarOfLightModule
{
    public class GameManager
    {
        public readonly List<CreatureStack> playerStacks = new List<CreatureStack>();
        public readonly List<CreatureStack> enemyStacks = new List<CreatureStack>();
        private readonly Dictionary<bool, List<(int, int)>> offsetCoords = new Dictionary<bool, List<(int, int)>>();
        private readonly Map map;
        private readonly List<CreatureStack> ATM = new List<CreatureStack>();
        private readonly Levels levels = new Levels();
        private readonly EnemyLogic enemyLogic = new EnemyLogic();

        public CreatureStack ActivCreature { get; private set; }

        public GameManager(Map Map, int numLevel)
        {
            switch (numLevel)
            {
                case 1:
                    levels.FirstLevel(this);
                    break;
                case 2:
                    levels.SecondLevel(this);
                    break;
                default:
                    levels.FirstLevel(this);
                    break;

            }

            SetDictOffcetCoord();
            SetATM();
            map = Map;            
        }


        public void NextCreatureStep()
        {
            ActivCreature = ATM.First();
            ATM.RemoveAt(0);
            ATM.Add(ActivCreature);
        }

        public void MoveCreature(int x, int y)
        {
            ActivCreature.Coord = (x, y);
        }

        public void RangeAttack(int x, int y)
        {
            var attakedCreature = GetCreatureForCoord((x, y));
            ActivCreature.Shot(attakedCreature);
        }

        public void MiddleAttack(int x, int y)
        {
            var attakedCreature = GetCreatureForCoord((x, y));
            ActivCreature.Attack(attakedCreature);
        }

        public ((int, int), (int, int)) MoveEnemy()
        {
            return enemyLogic.StepEnemyStack(this);
        } 

        public bool IsKillCreature(CreatureStack Creature)
        {
            if (Creature.NumCreatures <= 0)
            {
                DeleteCreatue(Creature);
                return true;
            }
            return false;
        }

        public List<(int, int)> GetHexagonsForMove(CreatureStack creatureStack, int move)
        {
            var list = new List<(int, int)>();
            var (x, y) = (creatureStack.Coord.Item1, creatureStack.Coord.Item2);

            if (move % 2 == 0)
                GetHexForEvenMove(creatureStack, move, list, x, y);
            else
                GetHexForOddMove(creatureStack, move, list, x, y);

            return list;
        }

        private void GetHexForEvenMove(CreatureStack creatureStack, int move, List<(int, int)> list, int x, int y)
        {
            var p = 0;
            for (var row = y - move; row <= y; row += 2)
            {

                for (var col = x - p - move / 2; col <= p + x + move / 2; col++)
                {
                    if (creatureStack.Coord == (col, row))
                        continue;
                    if (col < map.CountX && row < map.CountY
                        && col >= 0 && row >= 0)
                        list.Add((col, row));
                    if (col < map.CountX && 2 * y - row < map.CountY
                        && col >= 0 && 2 * y - row >= 0)
                        list.Add((col, 2 * y - row));
                }
                p++;
            }

            p = 0;
            var n = y % 2 == 0 ? 0 : 1;
            for (var row = y - move + 1; row <= y; row += 2)
            {

                for (var col = x - p - n - move / 2; col <= p + x + (1 - n) + move / 2; col++)
                {
                    if (creatureStack.Coord == (col, row))
                        continue;
                    if (col < map.CountX && row < map.CountY
                        && col >= 0 && row >= 0)
                        list.Add((col, row));
                    if (col < map.CountX && 2 * y - row < map.CountY
                        && col >= 0 && 2 * y - row >= 0)
                        list.Add((col, 2 * y - row));
                }
                p++;
            }
        }

        private void GetHexForOddMove(CreatureStack creatureStack, int move, List<(int, int)> list, int x, int y)
        {
            var p = 0;
            for (var row = y - move + 1; row <= y; row += 2)
            {

                for (var col = x - p - 1 - move / 2; col <= p + x + 1 + move / 2; col++)
                {
                    if (creatureStack.Coord == (col, row))
                        continue;
                    if (col < map.CountX && row < map.CountY
                        && col >= 0 && row >= 0)
                        list.Add((col, row));
                    if (col < map.CountX && 2 * y - row < map.CountY
                        && col >= 0 && 2 * y - row >= 0)
                        list.Add((col, 2 * y - row));
                }
                p++;
            }

            p = 0;
            var n = y % 2 == 0 ? 0 : 1;
            for (var row = y - move; row <= y; row += 2)
            {

                for (var col = x - p - n - move / 2; col <= p + x + (1 - n) + move / 2; col++)
                {
                    if (creatureStack.Coord == (col, row))
                        continue;
                    if (col < map.CountX && row < map.CountY
                        && col >= 0 && row >= 0)
                        list.Add((col, row));
                    if (col < map.CountX && 2 * y - row < map.CountY
                        && col >= 0 && 2 * y - row >= 0)
                        list.Add((col, 2 * y - row));
                }
                p++;
            }
        }

        public void DeleteCreatue(CreatureStack creatureStack)
        {
            ATM.Remove(creatureStack);
            if (enemyStacks.Contains(creatureStack))
                enemyStacks.Remove(creatureStack);
            else if (playerStacks.Contains(creatureStack))
                playerStacks.Remove(creatureStack);
        }
        

        public List<(int,int)> GetCoordCreatores(List<CreatureStack> creatureStacks)
            => creatureStacks.Select(x => x.Coord).ToList();

        public CreatureStack GetCreatureForCoord((int,int) coord)
            => ATM.Select(x => x).Where(stack=> stack.Coord == coord).FirstOrDefault();

        private void SetATM()
        {
            ATM.AddRange(playerStacks);
            ATM.AddRange(enemyStacks);

            ATM.OrderBy(x => x.Creature.Initiative);
        }

        private void SetDictOffcetCoord()
        {
            offsetCoords.Add(true, new List<(int, int)> { (1, 0), (1, -1), (0, -1), (-1, 0), (0, 1), (1, 1) });
            offsetCoords.Add(false, new List<(int, int)> { (1, 0), (0, -1), (-1, -1), (-1, 0), (0, 1), (-1, 1) });
        }
    }
}
