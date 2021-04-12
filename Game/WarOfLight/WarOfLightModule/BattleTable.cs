using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarOfLightModule
{
    public partial class BattleTable : Form
    {
        public BattleTable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            var pen = new Pen(Color.Black);
            var map = new Map(new Point(40, 20), 40);

            DrawMap(graphics, pen, map);
            button1.Enabled = false;
        }

        private static void DrawMap(Graphics graphics, Pen pen, Map map)
        {
            for (int y = 0; y < map.CountY; y++)
                for (int x = 0; x < map.CountX; x++)
                    graphics.DrawLines(pen, map.Field[x, y].GetHexCorner());
        }
    }
}