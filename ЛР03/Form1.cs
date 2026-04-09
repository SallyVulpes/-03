using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
                        bool rez1 = double.TryParse(textBox2.Text, out a);
            if (rez1 == false) 
            {               
                MessageBox.Show("Неверный формат числа " + textBox2.Text + "!");
                return; 
            }
                       bool rez2 = double.TryParse(textBox1.Text, out b);
            if (rez2 == false) 
            {                  
                MessageBox.Show("Неверный формат числа " + textBox1.Text + "!");
                return; 
            }
            double aRad = a * Math.PI / 180.0;
            double bRad = b * Math.PI / 180.0;
            c = (3 * Math.Sin(aRad) + 6 * Math.Cos(bRad)) / 2;
            string cStr = c.ToString();
            label4.Text = cStr;
            return;
            }

        }

    }
    

