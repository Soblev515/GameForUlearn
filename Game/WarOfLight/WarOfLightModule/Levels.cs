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
            gm.enemyStacks.Add(new CreatureStack(new Thrower(), 45, (12, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Thrower(), 70, (13, 7)));
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

        public void EighthLevel(GameManager gm)
        {
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 1)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 2)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 3)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 4)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 5)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 6)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 7)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 8)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 9)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 1)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 2)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 3)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 4)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 5)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 6)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 7)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 8)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 9)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 80, (2, 0)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 80, (2, 1)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 80, (2, 9)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 80, (2, 10)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 30, (0, 2)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 50, (0, 5)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 50, (0, 6)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 30, (0, 9)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 30, (1, 2)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 50, (1, 5)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 50, (1, 6)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 30, (1, 9)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 290, (11, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 290, (11, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 290, (11, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 190, (12, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 190, (12, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 190, (12, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (13, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (13, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (13, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 190, (14, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 190, (14, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 190, (14, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 160, (12, 0)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (13, 0)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 160, (12, 10)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (13, 10)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 60, (14, 1)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 60, (14, 2)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 60, (14, 3)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 70, (13, 2)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 60, (14, 7)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 60, (14, 8)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 60, (14, 9)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 70, (13, 8)));
        }

        public void NinthLevel(GameManager gm)
        {
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 1)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 2)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 3)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 4)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 5)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 6)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 7)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 8)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 50, (3, 9)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 1)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 2)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 3)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 4)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 5)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 6)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 7)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 8)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 9)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 1)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 2)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 3)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 4)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 5)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 6)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 7)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 8)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 9)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 80, (1, 0)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 80, (1, 1)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 80, (1, 9)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 80, (1, 10)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 30, (0, 2)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 50, (0, 4)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 50, (0, 6)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 30, (0, 8)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 30, (1, 2)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 50, (1, 4)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 50, (1, 6)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 50, (1, 8)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 290, (12, 1)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 290, (11, 2)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (11, 3)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 290, (11, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 290, (11, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 290, (11, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (11, 7)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 290, (11, 8)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 290, (12, 9)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (12, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (12, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (12, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (13, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (13, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (13, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (14, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (14, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (14, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 220, (9, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (10, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (10, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (10, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (12, 0)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (13, 0)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (12, 10)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (13, 10)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 260, (14, 1)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 260, (14, 2)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 260, (14, 3)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 270, (13, 2)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 260, (14, 7)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 260, (14, 8)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 260, (14, 9)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 270, (13, 8)));
        }

        public void TenthLevel(GameManager gm)
        {
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 250, (3, 1)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 250, (3, 2)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 250, (3, 3)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 250, (3, 4)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 250, (3, 5)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 250, (3, 6)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 250, (3, 7)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 250, (3, 8)));
            gm.playerStacks.Add(new CreatureStack(new Recruit(), 250, (3, 9)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 1)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 2)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 3)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 4)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 5)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 6)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 7)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 8)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (4, 9)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 1)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 2)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 3)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 4)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 5)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 6)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 7)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 8)));
            gm.playerStacks.Add(new CreatureStack(new Swordsman(), 150, (2, 9)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 80, (0, 0)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 80, (0, 1)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 80, (1, 0)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 80, (1, 1)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 80, (1, 10)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 80, (0, 10)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 80, (1, 9)));
            gm.playerStacks.Add(new CreatureStack(new Horseman(), 80, (0, 9)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 130, (0, 2)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 150, (0, 4)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 150, (0, 6)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 130, (0, 8)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 130, (1, 2)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 150, (1, 4)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 150, (1, 6)));
            gm.playerStacks.Add(new CreatureStack(new Archer(), 150, (1, 8)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 290, (12, 1)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 290, (11, 2)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (11, 3)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 290, (11, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 290, (11, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 290, (11, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (11, 7)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 290, (11, 8)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 290, (12, 9)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (12, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (12, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (12, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (13, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (13, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (13, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (14, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (14, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Sworman(), 90, (14, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (10, 3)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (9, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 220, (9, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (9, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (10, 7)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (10, 4)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (10, 5)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (10, 6)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (12, 0)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (13, 0)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (12, 10)));
            gm.enemyStacks.Add(new CreatureStack(new Axeman(), 120, (13, 10)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 260, (14, 0)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 260, (14, 1)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 260, (14, 2)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 260, (14, 3)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 270, (13, 1)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 270, (13, 2)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 260, (14, 7)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 260, (14, 8)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 260, (14, 9)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 260, (14, 10)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 270, (13, 8)));
            gm.enemyStacks.Add(new CreatureStack(new Crossbowman(), 270, (13, 9)));
        }
    }
}
