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

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var Level1 = new BattleTable(1);
            Level1.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var Level2 = new BattleTable(2);
            Level2.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var Level3 = new BattleTable(3);
            Level3.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var Level4 = new BattleTable(4);
            Level4.Show();
            this.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var Level5 = new BattleTable(5);
            Level5.Show();
            this.Hide();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            var Level6 = new BattleTable(6);
            Level6.Show();
            this.Hide();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            var Level7 = new BattleTable(7);
            Level7.Show();
            this.Hide();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            var Level8 = new BattleTable(8);
            Level8.Show();
            this.Hide();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            var Level9 = new BattleTable(9);
            Level9.Show();
            this.Hide();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            var Level10 = new BattleTable(10);
            Level10.Show();
            this.Hide();
        }
    }
}
