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
            playerStacks.Add((0, 1), new CreatureStack(new Militiaman(), 20));
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
            for (var dy = -move; dy <= move; dy++)
                for (var dx = -move; dx <= move; dx++)
                    if (Math.Abs(dx - x) + Math.Abs(dy - y) >= move + 2 || 
                        Math.Abs(dx - x) >= move || Math.Abs(dy - y) >= move 
                        || x + dx < 0 || y + dy < 0 
                        || playerStacks.ContainsKey(((x + dx), (y + dy)))) continue;
                    else list.Add(((x + dx), (y + dy)));
            return list;
        }
    }
}
