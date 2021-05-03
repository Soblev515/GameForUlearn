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
        private Map map;
        private GameManager gm;
        private Graphics graphics;
        private Pen pen = new Pen(Color.Black);
        private static Brush brush = Brushes.Green;
        private Button[,] mapButtons;
        private Point activiryHex;
        private int sizeHex = 40;
        private CreatureStack activCreture;
        public BattleTable()
        {
            InitializeComponent();
            this.ClientSize = new Size(1800,900);
            map = new Map(new Point(160, 20), sizeHex);
            gm = new GameManager(map);
            graphics = CreateGraphics();
            mapButtons = new PolygonButton[map.CountX, map.CountY];
            ////var thread = new Thread(() => UpdateGame());
            //thread.Start();
            activCreture = gm.NextCreatureStep();
            Init();
        }

        private void Init()
        {
            var size = map.Field[0, 0].Size;
            for (int y = 0; y < map.CountY; y++)
                for (int x = 0; x < map.CountX; x++)
                {
                    mapButtons[x, y] = new PolygonButton();

                    PolygonButton butt = new PolygonButton();
                    butt.Location = new Point(map.Field[x, y].Center.X - size, map.Field[x, y].Center.Y - size);
                    butt.Size = new Size(2 * size, 2 * size);


                    Image part = new Bitmap(50, 50);
                    Graphics g = Graphics.FromImage(part);
                    g.DrawImage(gm.playerStacks.FirstOrDefault().Creature.Bitmap, map.Field[x,y].Center.X - 20, map.Field[x, y].Center.Y - 59, new Rectangle(new Point(0, 0), new Size(52, 96)), GraphicsUnit.Pixel);
                    butt.BackgroundImage = part;

                    butt.ForeColor = Color.Gray;
                    this.Controls.Add(butt);
                    butt.Enabled = false;

                    mapButtons[x, y] = butt;
                    mapButtons[x, y].Click += OnFigurePress;
                }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (var stack in gm.playerStacks)
                DrawCreature(map.Field[stack.Coord.Item1, stack.Coord.Item2], stack.Creature);
            
            //button1.Enabled = false;
            button5.Enabled = true;

            gm.DeleteCreatue(gm.playerStacks.FirstOrDefault());
        }

        public void OnFigurePress(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;
            var y = (pressedButton.Top) / (Hexagon.GetWidthAndHeigth(sizeHex).Item2 - 20);
            var x = (pressedButton.Left - 160) / Hexagon.GetWidthAndHeigth(sizeHex).Item1;
            if (y % 2 == 1)
                x++;
            activCreture.Coord = (x, y);
            pressedButton.BackColor = Color.Red;
        }

        private void DrawCreature(Hexagon hexagon, Creature creature)
        {
            graphics.DrawImage(creature.Bitmap, hexagon.Center.X - 20, hexagon.Center.Y - 59, new Rectangle(new Point(0, 0), new Size(52, 96)), GraphicsUnit.Pixel);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var a = gm.GetHexagonsForMove(gm.playerStacks.FirstOrDefault(), gm.playerStacks.First().Creature.Move);
            foreach (var b in a)
            {
                map.Field[b.Item1, b.Item2].activ = true;
                mapButtons[b.Item1, b.Item2].Enabled = true;
                mapButtons[b.Item1, b.Item2].BackColor = Color.Green;
            }
            //DrawMap(graphics, pen, map);
            DrawCreature(map.Field[gm.playerStacks.FirstOrDefault().Coord.Item1, gm.playerStacks.FirstOrDefault().Coord.Item2], gm.playerStacks.First().Creature);
            //mapButtons[coord.Item1, coord.Item2].Image = new Bitmap(gm.playerStacks.Values.First().Creature.Bitmap);
            //mapButtons[coord.Item1, coord.Item2].BackgroundImage = new Bitmap(gm.playerStacks.Values.First().Creature.Bitmap);
        }

        //private void updateBox()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        this.Invoke((MethodInvoker)delegate ()
        //        {
        //            pictureBox1.ImageLocation = "C:\\" + i.ToString() + ".jpg";
        //        }
        //        );
        //        Thread.Sleep(100);
        //        if (i == 10) i = 0;
        //    };

        //}
    }
}
