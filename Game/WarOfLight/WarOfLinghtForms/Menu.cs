using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarOfLightModule;

namespace WarOfLinghtForms
{
    public partial class Menu : Form
    {
        private readonly Levels levels = new Levels();
        private readonly Map map;
        private readonly GameManager gm;

        public Menu()
        {
            InitializeComponent();
            button1.Text = "Level 1";
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Level1 = new BattleTable(1);
            Level1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Level2 = new BattleTable(2);
            Level2.Show();
            this.Hide();
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    for (int y = 0; y < map.CountY; y++)
        //        for (int x = 0; x < map.CountX; x++)
        //        {
        //            mapButtons[x, y] = new PolygonButton();

        //            PolygonButton butt = new PolygonButton
        //            {
        //                Location = new Point(map.Field[x, y].Center.X - size, map.Field[x, y].Center.Y - size),
        //                Size = new Size(2 * size, 2 * size)
        //            };

        //            butt.BackColor = Color.ForestGreen;
        //            this.Controls.Add(butt);
        //            butt.Enabled = false;

        //            mapButtons[x, y] = butt;
        //            mapButtons[x, y].Click += OnFigurePress;
        //        }               
        //}
    }
}
