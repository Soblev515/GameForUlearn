using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarOfLightModule
{
    public partial class BattleTable: Form
    {
        private Map map;
        private GameManager gm;
        private Graphics graphics;
        private Pen pen = new Pen(Color.Black);
        private static Brush brush = Brushes.Green;
        public BattleTable()
        {
            InitializeComponent();
            this.ClientSize = new Size(1800,900);
            map = new Map(new Point(160, 20), 40);
            gm = new GameManager(map);
            graphics = CreateGraphics();
            var thread = new Thread(() => UpdateGame());
            thread.Start();
        }

        private void UpdateGame()
        {
            if()
        }

        private void Button1_Click(object sender, EventArgs e)
        {                    
            DrawMap(graphics, pen, map);

            foreach (var stack in gm.playerStacks)
                DrawCreature(graphics, map.Field[stack.Key.Item1, stack.Key.Item2], stack.Value.Creature);

            button1.Enabled = false;
            button5.Enabled = true;
        }

        private void DrawCreature(Graphics graphics, Hexagon hexagon, Creature creature)
        {
            graphics.DrawImage(creature.Bitmap, hexagon.Center.X - 20, hexagon.Center.Y - 59, new Rectangle(new Point(0, 0), new Size(52, 96)), GraphicsUnit.Pixel);
        }

        public static void DrawMap(Graphics graphics, Pen pen, Map map)
        {
            for (int y = 0; y < map.CountY; y++)
                for (int x = 0; x < map.CountX; x++)
                {
                    var hexagon = map.Field[x, y].GetHexCorner();
                    graphics.DrawLines(pen, hexagon);
                    if (map.Field[x, y].activ)
                        graphics.FillPolygon(brush, hexagon);
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var coord = gm.playerStacks.Keys.First();
            var a = gm.GetHexagonsForMove(coord.Item1, coord.Item2, gm.playerStacks.Values.First().Creature.Move);
            foreach (var b in a)
                map.Field[b.Item1, b.Item2].activ = true;
            DrawMap(graphics, pen, map);
            DrawCreature(graphics, map.Field[coord.Item1, coord.Item2], gm.playerStacks.Values.First().Creature);
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
