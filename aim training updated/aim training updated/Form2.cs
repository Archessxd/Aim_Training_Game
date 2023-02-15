using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aim_training_updated
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            
            Data d = new Data();
            if (d.Mode == 1)
            {
                if (d.Dif == "easy")
                {
                    button1.Height = 100;
                    button1.Width = 100;
                }
                else if (d.Dif == "med")
                {
                    button1.Height = 50;
                    button1.Width = 50;
                }
                else if (d.Dif == "hard")
                {
                    button1.Height = 20;
                    button1.Width = 20;
                }
                oyna();
            }

            else if (d.Mode == 2)
            {
                if (d.Dif == "easy")
                {
                    button1.Height = 100;
                    button1.Width = 100;
                    button2.Visible = true;
                    button2.Height = 100;
                    button2.Width = 100;
                    button3.Visible = false;
                    b2oyna();
                    oyna();
                }
                else if (d.Dif == "med")
                {
                    button1.Height = 50;
                    button1.Width = 50;
                    button2.Width = 50;
                    button2.Height = 50;
                    button2.Visible = true;
                    button3.Visible = false;
                    b2oyna();
                }
                else if (d.Dif == "hard")
                {
                    button1.Height = 20;
                    button1.Width = 20;
                    button2.Width = 20;
                    button2.Height = 20;
                    button3.Width = 20;
                    button3.Height = 20;
                    button2.Visible = true;
                    button3.Visible = true;
                    oyna();
                    b2oyna();
                    b3oyna();
                }
            }
        }

        private void oyna()
        {
            Random r = new Random();
            int xpos = r.Next(1260);
            int ypos = r.Next(600);
            button1.Location = new Point(xpos, ypos);
        }
        private void b2oyna()
        {
            Random r = new Random();
            int xpos = r.Next(1260);
            int ypos = r.Next(600);
            button2.Location = new Point(xpos, ypos);
        }
        private void b3oyna()
        {
            Random r = new Random();
            int xpos = r.Next(1260);
            int ypos = r.Next(600);
            button3.Location = new Point(xpos, ypos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oyna();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b2oyna();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b3oyna();
        }
    }
}
