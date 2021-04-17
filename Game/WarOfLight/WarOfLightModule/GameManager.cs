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

        public void GeneratePlayerCreatures()
        {
            playerStacks.Add((0, 1), new CreatureStack(new Militiaman(), 20));
            playerStacks.Add((0, 3), new CreatureStack(new Militiaman(), 10));
        }

        public void GenerateEnemyCreatures()
        {
            playerStacks.Add((14, 1), new CreatureStack(new Spearman(), 20));
            playerStacks.Add((14, 3), new CreatureStack(new Spearman(), 10));
        }

        public void MoveCreatue((int, int) StartCord, (int, int) EndCord)
        {
            playerStacks.Add(EndCord, playerStacks[StartCord]);
            playerStacks.Remove(StartCord);
        }
    }
}
