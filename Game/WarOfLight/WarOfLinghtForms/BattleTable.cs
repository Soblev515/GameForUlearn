using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarOfLightModule
{
    public partial class BattleTable: Form
    {
        Image table;
        public BattleTable()
        {
            InitializeComponent();
            this.ClientSize = new Size(1800,900);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            table = new Bitmap("D:\\Project\\GameForUlearn\\Game\\WarOfLight\\WarOfLinghtForms\\Images\\Pikeman.png");

            Graphics graphics = CreateGraphics();
            var pen = new Pen(Color.Black);
            var map = new Map(new Point(160, 20), 40);
            var gm = new GameManager();
            gm.GeneratePlayerCreatures();
            
            DrawMap(graphics, pen, map);

            foreach (var stack in gm.playerStacks)
                DrawCreature(graphics, map.Field[stack.Key.Item1, stack.Key.Item2]);

            button5.Enabled = true;
        }

        private void DrawCreature(Graphics graphics, Hexagons hexagon)
        {
            graphics.DrawImage(table, hexagon.Center.X - 20, hexagon.Center.Y - 59, new Rectangle(new Point(0, 0), new Size(52, 96)), GraphicsUnit.Pixel);
        }

        public static void DrawMap(Graphics graphics, Pen pen, Map map)
        {
            for (int y = 0; y < map.CountY; y++)
                for (int x = 0; x < map.CountX; x++)
                    graphics.DrawLines(pen, map.Field[x, y].GetHexCorner());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var pictureBox = new PictureBox();

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
