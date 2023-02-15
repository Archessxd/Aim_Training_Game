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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {


                Data data = new Data();
                if (firstMode_RBT.Checked)
                {
                    data.Mode = 1;
                    if (m1_easy_RBT.Checked)
                    {
                        data.Dif = "easy";
                        Form2 f2 = new Form2();
                        f2.Show();
                    }
                    else if (m1_med_RBT.Checked)
                    {
                        data.Dif = "med";
                        Form2 f2 = new Form2();
                        f2.Show();
                    }
                    else if (m1_hard_RBT.Checked)
                    {
                        data.Dif = "hard";
                        Form2 f2 = new Form2();
                        f2.Show();
                    }
                    else
                    {
                        MessageBox.Show("please be sure about selected all options");
                    }
                }
                else if (secondMode_RBT.Checked)
                {
                    data.Mode = 2;
                    
                    if (m2_easy_RBT.Checked)
                    {
                        data.Dif = "easy";
                        Form2 f2 = new Form2();
                        f2.Show();
                    }
                    else if (m2_med_RBT.Checked)
                    {
                        data.Dif = "med";
                        Form2 f2 = new Form2();
                        f2.Show();
                    }
                    else if (m2_hard_RBT.Checked)
                    {
                        data.Dif = "hard";
                        Form2 f2 = new Form2();
                        f2.Show();
                    }
                    else
                    {
                        MessageBox.Show("please be sure about selected all options");
                    }
                }
                

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FirstMode()
        {
            groupBox2.Enabled = false;
            groupBox1.Enabled = true;
            secondMode_RBT.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
        }
        private void SecondMode()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            firstMode_RBT.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void firstMode_RBT_CheckedChanged(object sender, EventArgs e)
        {
            FirstMode();
        }

        private void secondMode_RBT_CheckedChanged(object sender, EventArgs e)
        {
            SecondMode();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            button1.Enabled = false;
        }
    }
}
