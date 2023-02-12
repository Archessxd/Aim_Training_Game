using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2___aim_training
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void oyna()
        {
            Random r = new Random();
            int xpos = r.Next(1260);
            int ypos = r.Next(600);
            button1.Location = new Point(xpos, ypos);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            string x = c.Dif;

            if (x == "e")
            {
                button1.Width = 100;
                button1.Height = 100;
            }

            if (x == "m")
            {
                button1.Width = 50;
                button1.Height = 50;
            }
            if (x == "h")
            {
                button1.Width = 20;
                button1.Height = 20;
            }
            oyna();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oyna();
        }
    }
}
