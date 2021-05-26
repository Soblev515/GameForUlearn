using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfLightModule;
using WarOfLightModule.Creatures;

namespace WarOfLightModule
{
    public class Levels
    {
        public void FirstLevel(GameManager gm)
        {
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 20, (4, 5)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 10, (0, 3)));
            gm.enemyStacks.Add(new CreatureStack(new Thief(), 20, (14, 1)));
            gm.enemyStacks.Add(new CreatureStack(new Thief(), 10, (14, 3)));
        }

        public void SecondLevel(GameManager gm)
        {
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 20, (4, 5)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 10, (0, 3)));
            gm.enemyStacks.Add(new CreatureStack(new Thief(), 60, (12, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Thief(), 10, (14, 3)));
        }
    }
}
