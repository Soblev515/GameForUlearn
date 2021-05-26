using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfLightModule;

namespace WarOfLightModule
{
    public class Levels
    {
        public void FirstLevel(GameManager gm)
        {
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 20, (4, 5)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 10, (0, 3)));
            gm.enemyStacks.Add(new CreatureStack(new Spearman(), 20, (14, 1)));
            gm.enemyStacks.Add(new CreatureStack(new Spearman(), 10, (14, 3)));
        }

        public void SecondLevel(GameManager gm)
        {
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 20, (4, 5)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 10, (0, 3)));
            gm.enemyStacks.Add(new CreatureStack(new Spearman(), 20, (14, 1)));
            gm.enemyStacks.Add(new CreatureStack(new Spearman(), 10, (14, 3)));
        }
    }
}
