using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarOfLinghtForms;

namespace WarOfLightModule
{
    public partial class BattleTable: Form
    {
        private readonly Map map;
        private readonly GameManager gm;
        private readonly Button[,] mapButtons;
        private readonly int sizeHex = 40;
        private CreatureStack activCreature;

        public BattleTable()
        {
            InitializeComponent();
            this.ClientSize = new Size(1800,900);
            map = new Map(new Point(160, 20), sizeHex);
            gm = new GameManager(map);
            mapButtons = new PolygonButton[map.CountX, map.CountY];
            this.BackColor = Color.LightGreen;
            activCreature = gm.NextCreatureStep();
            Init();
            SetMoveHex(activCreature, activCreature.Creature.Move);
        }

        public void OnFigurePress(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;
            var y = (pressedButton.Top) / (Hexagon.GetWidthAndHeigth(sizeHex).Item2 - 20);
            var x = (pressedButton.Left - 160) / Hexagon.GetWidthAndHeigth(sizeHex).Item1;
            if (y % 2 == 1)
                x++;

            if (gm.GetCreatoreForCoord((x, y)) == activCreature)
                return;

            if(pressedButton.BackColor == Color.DarkGreen) MoveCreature(y, x);
            else if(pressedButton.BackColor == Color.Red) SetTargetForAttack(y, x);
            else if (pressedButton.BackColor == Color.IndianRed) MiddleAttack(y, x);
            else if (pressedButton.BackColor == Color.OrangeRed) RangeAttack(y, x);
        }

        private void RangeAttack(int y, int x)
        {
            mapButtons[activCreature.Coord.Item1, activCreature.Coord.Item2].Image = null;
            var attakedCreature = gm.GetCreatoreForCoord((x, y));
            activCreature.Shot(attakedCreature);
            IsKillCreature(y, x, attakedCreature);
            Step();
        }

        private void MiddleAttack(int y, int x)
        {
            mapButtons[activCreature.Coord.Item1, activCreature.Coord.Item2].Image = null;
            var a = gm.GetHexagonsForMove(new CreatureStack(null, 0, (x, y)), 1);
            var (x0, y0) = (0, 0);
            foreach (var coord in a)
                if (mapButtons[coord.Item1, coord.Item2].BackColor == Color.Red)
                    (x0, y0) = coord;
            activCreature.Coord = (x, y);

            var attakedCreature = gm.GetCreatoreForCoord((x0, y0));
            activCreature.Attack(attakedCreature);

            IsKillCreature(y0, x0, attakedCreature);
            Step();
        }

        private void IsKillCreature(int y, int x, CreatureStack attakedCreature)
        {
            if (attakedCreature.NumCreatures <= 0)
            {
                gm.DeleteCreatue(attakedCreature);
                mapButtons[x, y].Image = null;
            }
        }

        private void SetTargetForAttack(int y, int x)
        {
            mapButtons[activCreature.Coord.Item1, activCreature.Coord.Item2].Image = null;
            var a = gm.GetHexagonsForMove(new CreatureStack(null, 0, (x, y)), 1);

            foreach (var coord in a)
                mapButtons[coord.Item1, coord.Item2].BackColor = Color.IndianRed;
        }

        private void MoveCreature(int y, int x)
        {
            mapButtons[activCreature.Coord.Item1, activCreature.Coord.Item2].Image = null;
            activCreature.Coord = (x, y);
            Step();
        }

        private void DrawCreature(CreatureStack creature)
        {
            mapButtons[creature.Coord.Item1, creature.Coord.Item2].Image = creature.Creature.Bitmap;
            mapButtons[creature.Coord.Item1, creature.Coord.Item2].Text = creature.NumCreatures.ToString();
            mapButtons[creature.Coord.Item1, creature.Coord.Item2].TextAlign = ContentAlignment.BottomCenter;
            mapButtons[creature.Coord.Item1, creature.Coord.Item2].ForeColor = Color.Aqua;
            mapButtons[creature.Coord.Item1, creature.Coord.Item2].Enabled = true;
        }

        private void SetMoveHex(CreatureStack creature, int move)
        {
            var a = gm.GetHexagonsForMove(creature, move);

            foreach (var b in a)
            {
                if (gm.GetCoordCreatores(gm.playerStacks).Contains(b))
                    continue;
                mapButtons[b.Item1, b.Item2].Enabled = true;
                mapButtons[b.Item1, b.Item2].BackColor = gm.GetCoordCreatores(gm.enemyStacks).Contains(b) ?
                                                                    Color.Red : Color.DarkGreen;
            }
        }

        private void Shot_Click(object sender, EventArgs e)
        {
            var coords = gm.GetCoordCreatores(gm.enemyStacks);
            if (Shot.BackColor == Color.White)
            {
                foreach (var coord in coords)
                {
                    mapButtons[coord.Item1, coord.Item2].Enabled = true;
                    mapButtons[coord.Item1, coord.Item2].BackColor = Color.OrangeRed;
                }
                Shot.BackColor = Color.BlueViolet;
            }

            else
            {
                foreach (var coord in coords)
                {
                    mapButtons[coord.Item1, coord.Item2].Enabled = false;
                    mapButtons[coord.Item1, coord.Item2].BackColor = Color.ForestGreen;
                }
                Shot.BackColor = Color.White;
            }

        }

        private void Init()
        {
            var size = map.Field[0, 0].Size;
            for (int y = 0; y < map.CountY; y++)
                for (int x = 0; x < map.CountX; x++)
                {
                    mapButtons[x, y] = new PolygonButton();

                    PolygonButton butt = new PolygonButton
                    {
                        Location = new Point(map.Field[x, y].Center.X - size, map.Field[x, y].Center.Y - size),
                        Size = new Size(2 * size, 2 * size)
                    };

                    butt.BackColor = Color.ForestGreen;
                    this.Controls.Add(butt);
                    butt.Enabled = false;

                    mapButtons[x, y] = butt;
                    mapButtons[x, y].Click += OnFigurePress;
                }

            DrawAllCretures();
            Shot.Enabled = activCreature.Creature.BasicShots != 0;
            Shot.BackColor = Color.White;
        }

        private void Step()
        {
            if (gm.enemyStacks.Count == 0)
                BattleTable.ActiveForm.Close();
            for (int y = 0; y < map.CountY; y++)
                for (int x = 0; x < map.CountX; x++)
                {
                    mapButtons[x, y].Enabled = false;
                    mapButtons[x, y].BackColor = Color.ForestGreen;
                    mapButtons[x, y].Text = null;
                }

            DrawAllCretures();

            activCreature = gm.NextCreatureStep();
            SetMoveHex(activCreature, activCreature.Creature.Move);
            Shot.Enabled = activCreature.Creature.BasicShots != 0;
            Shot.BackColor = Color.White;
        }

        private void DrawAllCretures()
        {
            foreach (var stack in gm.playerStacks)
                DrawCreature(stack);
            foreach (var stack in gm.enemyStacks)
                DrawCreature(stack);
        }

    }
}
