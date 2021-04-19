using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarOfLightModule
{
    public class GameManager
    {
        public readonly Dictionary<(int, int), CreatureStack> playerStacks = new Dictionary<(int, int), CreatureStack>();
        public readonly Dictionary<(int, int), CreatureStack> enemyStacks;
        private Dictionary<bool, List<(int, int)>> offsetCoords = new Dictionary<bool, List<(int, int)>>();
        private Map map;

        public GameManager(Map Map)
        {
            GeneratePlayerCreatures();
            GenerateEnemyCreatures();
            SetDictOffcetCoord();
            map = Map;
        }
        private void GeneratePlayerCreatures()
        {
            playerStacks.Add((5, 6), new CreatureStack(new Militiaman(), 20));
            playerStacks.Add((0, 3), new CreatureStack(new Militiaman(), 10));
        }

        private void GenerateEnemyCreatures()
        {
            playerStacks.Add((14, 1), new CreatureStack(new Spearman(), 20));
            playerStacks.Add((14, 3), new CreatureStack(new Spearman(), 10));
        }

        public void MoveCreatue((int, int) StartCord, (int, int) EndCord)
        {
            playerStacks.Add(EndCord, playerStacks[StartCord]);
            playerStacks.Remove(StartCord);
        }

        private void SetDictOffcetCoord()
        {
            offsetCoords.Add(true, new List<(int, int)> { (1, 0), (1, -1), (0, -1), (-1, 0), (0, 1), (1, 1) });
            offsetCoords.Add(false, new List<(int, int)> { (1, 0), (0, -1), (-1, -1), (-1, 0), (0, 1), (-1, 1) });
        }

        public List<(int, int)> GetHexagonsForMove(int x, int y, int move)
        {
            var list = new List<(int, int)>();

            var n = 0;
            for(int row = y-move; row <= y; row++)
            {
                for (int col = x-move/2 - n/2 ; col <= x+move / 2 + (1 + n)/2; col++)
                {
                    if (row-x + col - y > move || 
                        row < 0 || col < 0) continue;
                    if(!playerStacks.ContainsKey(((col), (row))) && col < map.CountX && row < map.CountY)
                        list.Add((col,row));
                    if (!playerStacks.ContainsKey(((col), (y - row + move + 2))) && y - row + move + 2 < map.CountY)
                        list.Add((col,y - row + move + 2));
                }
                n +=1;
            }
            return list;
        }
    }
}
