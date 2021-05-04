using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarOfLightModule
{
    public class GameManager
    {
        public readonly List<CreatureStack> playerStacks = new List<CreatureStack>();
        public readonly List<CreatureStack> enemyStacks = new List<CreatureStack>();
        private Dictionary<bool, List<(int, int)>> offsetCoords = new Dictionary<bool, List<(int, int)>>();
        private Map map;
        private List<CreatureStack> ATM = new List<CreatureStack>(); 

        public GameManager(Map Map)
        {
            GeneratePlayerCreatures();
            GenerateEnemyCreatures();
            SetDictOffcetCoord();
            SetATM();
            map = Map;
            
        }

        public CreatureStack NextCreatureStep()
        {
            var a = ATM.First();
            ATM.RemoveAt(0);
            ATM.Add(a);
            return a;
        }

        public void MoveCreatue(ref CreatureStack creatureStack, (int, int) EndCord, bool isPlayerCreture)
        {
            if (isPlayerCreture)
                creatureStack.Coord = EndCord;
            else
                creatureStack.Coord = EndCord;
        }

        public void DeleteCreatue(CreatureStack creatureStack)
        {
            ATM.Remove(creatureStack);
        }

        public List<(int,int)> GetCoordCreatores(List<CreatureStack> creatureStacks)
        {
            return creatureStacks.Select(x => x.Coord).ToList();
        }
        private void GeneratePlayerCreatures()
        {
            playerStacks.Add(new CreatureStack(new Militiaman(), 20, (4, 5)));
            playerStacks.Add(new CreatureStack(new Militiaman(), 10, (0, 3)));
        }

        private void GenerateEnemyCreatures()
        {
            enemyStacks.Add(new CreatureStack(new Spearman(), 20, (14, 1)));
            enemyStacks.Add(new CreatureStack(new Spearman(), 10, (14, 3)));
        }

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

        public List<(int, int)> GetHexagonsForMove(CreatureStack creatureStack, int move)
        {
            var list = new List<(int, int)>();
            var (x, y) = (creatureStack.Coord.Item1, creatureStack.Coord.Item2);
            var p = 0;
            for (var row = y - move; row <= y; row += 2)
            {
                
                for (var col = x -p- move / 2; col <= p + x + move / 2; col++)
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

                for (var col = x - p - n - move / 2; col <= p + x +(1-n) + move / 2; col++)
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

            return list;
        }
    }
}
