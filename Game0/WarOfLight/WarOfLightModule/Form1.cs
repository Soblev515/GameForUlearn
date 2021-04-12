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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void OnPain()
        {
            Graphics e = CreateGraphics();
            var pen = new Pen(Color.Black);
            //e.DrawLines(pen, )
        }

    }
}
