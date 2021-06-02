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
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Level1 = new BattleTable(1);
            Level1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Level2 = new BattleTable(2);
            Level2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Level3 = new BattleTable(3);
            Level3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Level4 = new BattleTable(4);
            Level4.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var Level5 = new BattleTable(5);
            Level5.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var Level6 = new BattleTable(6);
            Level6.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var Level7 = new BattleTable(7);
            Level7.Show();
            this.Hide();
        }
    }
}
