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
        private readonly List<Button> buttonsForMove = new List<Button>();
        private readonly List<Button> buttonsForAttack = new List<Button>(); 
        private (int,int) CoordAttack = (0, 0);
        private bool CanShot = false;
        private bool BackMenu = false;

        public BattleTable(int level)
        {
            InitializeComponent();
            this.ClientSize = new Size(1800,900);
            map = new Map(new Point(160, 20), sizeHex);
            gm = new GameManager(map, level);
            mapButtons = new PolygonButton[map.CountX, map.CountY];
            this.BackColor = Color.LightGreen;
            gm.NextCreatureStep();
            Init();
            SetMoveHex(gm.ActivCreature, gm.ActivCreature.Creature.Move);
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += ClickShotKey;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && gm.playerStacks.Count !=0 && gm.enemyStacks.Count !=0 && !BackMenu)
                Application.Exit();
        }

        private void OnFigurePress(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;
            var y = (pressedButton.Top) / (Hexagon.GetWidthAndHeigth(sizeHex).Item2 - 20);
            var x = (pressedButton.Left - 160) / Hexagon.GetWidthAndHeigth(sizeHex).Item1;
            if (y % 2 == 1)
                x++;

            if (gm.GetCreatureForCoord((x, y)) == gm.ActivCreature)
                return;

            if (CanShot && gm.enemyStacks.Contains(gm.GetCreatureForCoord((x, y))))
                RangeAttack(x, y);
            else if (buttonsForAttack.Contains(sender))
            {
                MiddleAttack(x, y);
                buttonsForAttack.RemoveRange(0, buttonsForAttack.Count);
            }
            else if (gm.enemyStacks.Contains(gm.GetCreatureForCoord((x, y))) && buttonsForMove.Contains(mapButtons[x,y]))
                SetTargetForAttack(x, y);
            else if (buttonsForMove.Contains(mapButtons[x, y]))
                MoveCreature(x, y);
        }

        private void ClickShotKey (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && gm.ActivCreature.Creature.BasicShots != 0)
            {
                CanShot = !CanShot;
                Shot.BackColor = CanShot? Color.BlueViolet: Color.White;
            }                
        }

        private void MoveCreature(int x, int y)
        {
            mapButtons[gm.ActivCreature.Coord.Item1, gm.ActivCreature.Coord.Item2].Image = null;
            gm.MoveCreature(x, y);
            Step();
        }

        private void RangeAttack(int x, int y)
        {
            mapButtons[gm.ActivCreature.Coord.Item1, gm.ActivCreature.Coord.Item2].Image = null;
            gm.RangeAttack(x, y);
            if(gm.IsKillCreature(gm.GetCreatureForCoord((x, y))))
                mapButtons[x, y].Image = null;
            Step();
        }

        private void MiddleAttack(int x, int y)
        {
            mapButtons[gm.ActivCreature.Coord.Item1, gm.ActivCreature.Coord.Item2].Image = null;
            
            gm.ActivCreature.Coord = (x, y);

            gm.MiddleAttack(CoordAttack.Item1, CoordAttack.Item2);

            if (gm.IsKillCreature(gm.GetCreatureForCoord((CoordAttack.Item1, CoordAttack.Item2))))
                mapButtons[CoordAttack.Item1, CoordAttack.Item2].Image = null;
            Step();
        }

        private void SetTargetForAttack(int x, int y)
        {
            CoordAttack = (x, y);
            mapButtons[gm.ActivCreature.Coord.Item1, gm.ActivCreature.Coord.Item2].Image = null;
            var a = gm.GetHexagonsForMove(new CreatureStack(null, 0, (x, y)), 1);

            foreach (var coord in a)
            {
                if(gm.GetCreatureForCoord(coord) == null)
                {
                    mapButtons[coord.Item1, coord.Item2].BackColor = Color.IndianRed;
                    buttonsForAttack.Add(mapButtons[coord.Item1, coord.Item2]);
                }
            }
        }

        private void DrawCreature(CreatureStack creature)
        {
            mapButtons[creature.Coord.Item1, creature.Coord.Item2].Image = creature.Creature.Bitmap;
            mapButtons[creature.Coord.Item1, creature.Coord.Item2].Text = creature.NumCreatures.ToString();
            mapButtons[creature.Coord.Item1, creature.Coord.Item2].TextAlign = ContentAlignment.BottomCenter;
            mapButtons[creature.Coord.Item1, creature.Coord.Item2].ForeColor = Color.Black;
            mapButtons[creature.Coord.Item1, creature.Coord.Item2].Enabled = true;
        }

        private void SetMoveHex(CreatureStack creature, int move)
        {
            var a = gm.GetHexagonsForMove(creature, move);

            foreach (var b in a)
            {
                if (gm.GetCoordCreatores(gm.playerStacks).Contains(b))
                    continue;
                buttonsForMove.Add(mapButtons[b.Item1, b.Item2]);
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

                CanShot = true;
                Shot.BackColor = Color.BlueViolet;
            }

            else
            {
                foreach (var coord in coords)
                {
                    mapButtons[coord.Item1, coord.Item2].Enabled = false;
                    mapButtons[coord.Item1, coord.Item2].BackColor = Color.ForestGreen;
                }

                CanShot = false;
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
                    butt.FlatStyle = FlatStyle.Standard;

                    butt.FlatAppearance.BorderColor = Color.ForestGreen;
                    butt.BackColor = Color.ForestGreen;
                    this.Controls.Add(butt);
                    butt.Enabled = false;

                    mapButtons[x, y] = butt;
                    mapButtons[x, y].Click += OnFigurePress;
                }

            DrawAllCretures();
            Shot.Enabled = gm.ActivCreature.Creature.BasicShots != 0;
            Shot.BackColor = Color.White;
            mapButtons[gm.ActivCreature.Coord.Item1, gm.ActivCreature.Coord.Item2].ForeColor = Color.Red;
        }

        private void Step()
        {
            buttonsForMove.RemoveRange(0, buttonsForMove.Count);
            SetDefautMap();
            DrawAllCretures();

            if (gm.enemyStacks.Count == 0 || gm.playerStacks.Count == 0)
            {
                Thread.Sleep(1000);
                var form = new WinOrLossForm(gm.enemyStacks.Count == 0);
                form.Show();
                this.Close();
            }
            else
            {
                gm.NextCreatureStep();
                mapButtons[gm.ActivCreature.Coord.Item1, gm.ActivCreature.Coord.Item2].ForeColor = Color.Red;

                if (gm.playerStacks.Contains(gm.ActivCreature))
                    SetPlayerMove();

                else
                    EnemyMove();
            }
        }

        private void EnemyMove()
        {
            mapButtons[gm.ActivCreature.Coord.Item1, gm.ActivCreature.Coord.Item2].ForeColor = Color.Red;
            Shot.Enabled = gm.ActivCreature.Creature.BasicShots != 0;
            var (playerStack, hexagon) = gm.MoveEnemy();
            var creature = gm.GetCreatureForCoord(playerStack);
            Thread.Sleep(1000);
            if (creature != null && gm.IsKillCreature(creature))
                mapButtons[playerStack.Item1, playerStack.Item2].Image = null;
            mapButtons[gm.ActivCreature.Coord.Item1, gm.ActivCreature.Coord.Item2].Image = null;
            gm.MoveCreature(hexagon.Item1, hexagon.Item2);
            Step();
        }

        private void SetPlayerMove()
        {
            SetMoveHex(gm.ActivCreature, gm.ActivCreature.Creature.Move);
            Shot.Enabled = gm.ActivCreature.Creature.BasicShots != 0;
            CanShot = false;
            Shot.BackColor = Color.White;
        }

        private void SetDefautMap()
        {
            for (int y = 0; y < map.CountY; y++)
                for (int x = 0; x < map.CountX; x++)
                {
                    mapButtons[x, y].FlatStyle = FlatStyle.Flat;
                    mapButtons[x, y].BackColor = Color.ForestGreen;
                    mapButtons[x, y].Text = null;
                    mapButtons[x, y].Enabled = false;
                }
        }

        private void DrawAllCretures()
        {
            foreach (var stack in gm.playerStacks)
                DrawCreature(stack);
            foreach (var stack in gm.enemyStacks)
                DrawCreature(stack);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var menu = new WarOfLinghtForms.Menu();
            menu.Show();
            BackMenu = true;
            this.Close();
        }
    }
}
