using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hes_mak
{
    public partial class Form1 : Form
    {
        double sayi1;
        bool ekrantemizlencekmi;
        char islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            if (ekrantemizlencekmi == true)
            {
                label1.Text = "";
                ekrantemizlencekmi = false;
            }
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            if (ekrantemizlencekmi == true)
            {
                label1.Text = "";
                ekrantemizlencekmi = false;
            }
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            if (ekrantemizlencekmi == true)
            {
                label1.Text = "";
                ekrantemizlencekmi = false;
            }
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            if (ekrantemizlencekmi == true)
            {
                label1.Text = "";
                ekrantemizlencekmi = false;
            }
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            if (ekrantemizlencekmi == true)
            {
                label1.Text = "";
                ekrantemizlencekmi = false;
            }
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            if (ekrantemizlencekmi == true)
            {
                label1.Text = "";
                ekrantemizlencekmi = false;
            }
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            if (ekrantemizlencekmi == true)
            {
                label1.Text = "";
                ekrantemizlencekmi = false;
            }
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            if (ekrantemizlencekmi == true)
            {
                label1.Text = "";
                ekrantemizlencekmi = false;
            }
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            if (ekrantemizlencekmi == true)
            {
                label1.Text = "";
                ekrantemizlencekmi = false;
            }
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            if (ekrantemizlencekmi == true)
            {
                label1.Text = "";
                ekrantemizlencekmi = false;
            }
            label1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ekrantemizlencekmi = true;
            islem = '+';
            sayi1 = Convert.ToDouble(label1.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ekrantemizlencekmi = true;
            islem = '-';
            sayi1 = Convert.ToDouble(label1.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ekrantemizlencekmi = true;
            islem = '/';
            sayi1 = Convert.ToDouble(label1.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ekrantemizlencekmi = true;
            islem = '*';
            sayi1 = Convert.ToDouble(label1.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double sayi2 = Convert.ToDouble(label1.Text);
            switch (islem)
            {
                case '+':
                    label1.Text = Convert.ToString(sayi1 + sayi2);
                    break;
                case '-':
                    label1.Text = Convert.ToString(sayi1 - sayi2);
                    break;
                case '/':
                    try
                    {
                        label1.Text = Convert.ToString(sayi1 / sayi2);
                    }
                    catch (DivideByZeroException)
                    {
                        label1.Text = "ERROR";
                    }
                    break;
                case '*':
                    label1.Text = Convert.ToString(sayi1 * sayi2);
                    break;
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
    }
}
