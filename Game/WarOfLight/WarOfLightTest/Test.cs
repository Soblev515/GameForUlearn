using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfLightModule;
using Xunit;

namespace WarOfLightTests
{
    public class GameManagerTests
    {
        private static readonly Map map = new Map(new Point(160, 20), 40);
        private readonly GameManager gm = new GameManager(map, 1);

        [Fact]
        public void MoveCreatureTest()
        {
            gm.NextCreatureStep();

            gm.MoveCreature(0, 0);

            Assert.Equal((0,0), gm.ActivCreature.Coord);
        }

        [Fact]
        public void NoCanMoveCreatureTest()
        {
            gm.NextCreatureStep();

            var coord = gm.ActivCreature.Coord;
            gm.MoveCreature(-1, -1);

            Assert.Equal(coord, gm.ActivCreature.Coord);
        }

        [Fact]
        public void MiddleAttackTest()
        {
            gm.NextCreatureStep();
            var creture = gm.GetCreatureForCoord((14, 1));

            gm.MiddleAttack(14, 1);

            Assert.Equal(1, creture.NumCreatures);
        }

        [Fact]
        public void RangeAttackTest()
        {
            gm.NextCreatureStep();
            var creture = gm.GetCreatureForCoord((14, 1));

            gm.RangeAttack(14, 1);

            Assert.Equal(1, creture.NumCreatures);
        }
    }
}
