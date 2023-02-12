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
    public partial class Form1 : Form
    {
        string dif;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Class1 c = new Class1();
                if (radioButton1.Checked)
                {
                    dif = "e";
                    c.Dif = dif;
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else if (radioButton2.Checked)
                {
                    dif = "m";
                    c.Dif = dif;
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else if (radioButton3.Checked)
                {
                    dif = "h";
                    c.Dif = dif;
                    Form2 f2 = new Form2();
                    f2.Show();
                }

                else
                {
                    MessageBox.Show("plz select a difficulty");
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
