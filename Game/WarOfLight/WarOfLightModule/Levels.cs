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
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 15, (3, 8)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 20, (0, 3)));
            gm.enemyStacks.Add(new CreatureStack(new Thrower(), 40, (12, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Thrower(), 30, (13, 7)));
        }

        public void ThirdLevel(GameManager gm)
        {
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 20, (4, 5)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 10, (0, 3)));
            gm.enemyStacks.Add(new CreatureStack(new Thief(), 60, (12, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Thief(), 10, (14, 3)));
        }
        
        public void FourthLevel(GameManager gm)
        {
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 20, (4, 5)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 20, (1, 6)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 10, (0, 3)));
            gm.enemyStacks.Add(new CreatureStack(new Bully(), 120, (12, 4)));
        }

        public void FifthLevel(GameManager gm)
        {
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 50, (3, 5)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 50, (3, 6)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 40, (1, 7)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 30, (0, 9)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 30, (0, 3)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (12, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (12, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (12, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (13, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (13, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (13, 6)));
        }

        public void SixthLevel(GameManager gm)
        {
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 50, (3, 5)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 50, (3, 6)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 70, (4, 5)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 70, (4, 6)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 40, (1, 7)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 40, (1, 2)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 30, (0, 9)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 30, (0, 3)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (12, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (12, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (12, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 50, (14, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 50, (14, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 50, (14, 6)));
        }

        public void SeventhLevel(GameManager gm)
        {
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 50, (3, 1)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 50, (3, 2)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 50, (3, 3)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 50, (3, 4)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 50, (3, 5)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 50, (3, 6)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 50, (3, 7)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 50, (3, 8)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 50, (3, 9)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 60, (2, 0)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 60, (2, 10)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 30, (0, 2)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 50, (0, 5)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 50, (0, 6)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 30, (0, 9)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (12, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (12, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (12, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (13, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (13, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (13, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (14, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (14, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (14, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 60, (14, 1)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 60, (14, 2)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 60, (14, 8)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 60, (14, 9)));
        }
    }
}
