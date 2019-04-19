using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        private double first = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            input.Text += 8;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            input.Text += 7;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            input.Text += 9;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            input.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            input.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            input.Text += 6;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            input.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            input.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            input.Text += 3;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            input.Text += 0;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if(input.Text[0] == '-')
                history.Text = "+" + input.Text.Remove(0,1) + "-";
            else
                history.Text = "+" + input.Text;
            first = Convert.ToDouble(input.Text);
            input.Text = "";
            
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (input.Text[0] == '-')
                history.Text = "-" + input.Text.Remove(0, 1) + "-";
            history.Text = "-" + input.Text;
            first = Convert.ToDouble(input.Text);
            input.Text = "";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (input.Text[0] == '-')
                history.Text = "×" + input.Text.Remove(0, 1) + "-";
            history.Text = "×" + input.Text;
            first = Convert.ToDouble(input.Text);
            input.Text = "";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (input.Text[0] == '-')
                history.Text = "÷" + input.Text.Remove(0, 1) + "-";
            history.Text = "÷" + input.Text;
            first = Convert.ToDouble(input.Text);
            input.Text = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double second = 0;
            if(input.Text!="")
            {
                second = Convert.ToDouble(input.Text);
            }
            if (history.Text[0] == '+')
                first += second;
            if (history.Text[0] == '-')
                first -= second;
            if (history.Text[0] == '×')
                first *= second;
            if (history.Text[0] == '÷')
                first /= second;
            history.Text = "";
            input.Text = first.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input.Text = "";
            history.Text = "";
        }

        private void clear1_Click(object sender, EventArgs e)
        {
            input.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            input.Text = input.Text.Substring(0, input.Text.Length - 1);
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            if (history.Text != "")
            {
                equal_Click(sender, e);
            }
            input.Text = Math.Sqrt(Convert.ToDouble(input.Text)).ToString();
        }

        private void squared_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            if(history.Text!="")
            {
                equal_Click(sender, e);
            }
            input.Text = ((Convert.ToDouble(input.Text)) * Convert.ToDouble(input.Text)).ToString();
        }

        private void reverse_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            if (input.Text == "0")
                input.Text = "ERROR".ToString();
            if(history.Text!="")
            {
                equal_Click(sender, e);
            }
            input.Text = (1 / (Convert.ToDouble(input.Text))).ToString();
        }

        private void procent_Click(object sender, EventArgs e)
        {
            double second = 0;
            double third =0;
            if (input.Text == "")
                return;
            if (input.Text != "")
            {
                second = Convert.ToDouble(input.Text);
            }
            if (history.Text[0] == '+')
            {
                third = (first * second) / 100;
                input.Text = (first + third).ToString();
            }
            if (history.Text[0] == '-')
            {
                third = (first * second) / 100;
                input.Text = (first - third).ToString();
            }
            if (history.Text[0] == '×')
            {
                third = (first * second) / 100;
                input.Text = (first * third).ToString();
            }
            if (history.Text[0] == '÷')
            {
                third = (first * second) / 100;
                input.Text = (first / third).ToString();
            }

        }

        private void point_Click(object sender, EventArgs e)
        {
            if (input.Text == "" || input.Text.IndexOf(',') != -1)
                return;
            input.Text += ',';
        }

        private void changedSign_Click(object sender, EventArgs e)
        {
            if (input.Text.IndexOf('-') != -1)
                input.Text = input.Text.Remove(0, 1);
            else
                input.Text = "-" + input.Text;
            


        }
    }
}
