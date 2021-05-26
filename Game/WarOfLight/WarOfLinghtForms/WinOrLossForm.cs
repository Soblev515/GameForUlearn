using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarOfLinghtForms
{
    public partial class WinOrLossForm : Form
    {
        public WinOrLossForm(bool isWin)
        {
            InitializeComponent();
            this.ClientSize = new Size(500, 200);
            label1.Location = new Point(100, 30);
            button1.Location = new Point(150, 100);
            button1.Size = new Size(200, 30);
            button1.Text = "В меню";
            label1.Height = 30;
            label1.Width = 400;
            label1.Font = new Font("Tobota", 20, FontStyle.Italic);
            label1.Text = isWin ? "Уровень пройден!" : "Уровень не пройден!";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
