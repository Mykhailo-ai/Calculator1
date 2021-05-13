using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Window : Form
    {
        public bool dot = false, sqrt = false, num2 = false;
        public double sqrtNum = 0, num1 = 0, memory = 0;
        public string firstOperation, operation;

        public Window()
        {
            InitializeComponent();
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (Input.Text == "0")
            {
                sqrt = true;
                Sqrt.BackColor = System.Drawing.Color.DarkCyan;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (sqrt == true)
            {
                sqrt = false;
                Sqrt.BackColor = System.Drawing.Color.Silver;
            }

            num1 = 0;
            Input.Text = "0";
            num2 = false;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Input.Text.Length - 1 < 1) Input.Text = "0";
            else if (Input.Text.Length - 1 >= 1)
            {
                string num = Input.Text.Remove(Input.Text.Length - 1);
                Input.Text = num;
            }
        }

        private void buttonNumbers_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (Input.Text == "0") Input.Text = button.Text;
            else Input.Text += button.Text;
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (dot == true) Input.Text = Input.Text;
            else
            {
                Input.Text += ".";
                dot = true;
            }
        }

        private void Operations(object sender, EventArgs e)
        {
            if (sqrt == false)
            {
                Button button = (Button)sender;
                operation = button.Text;

                if (num2 == true)
                {
                    if (firstOperation == "+") num1 += Convert.ToDouble(Input.Text);
                    if (firstOperation == "-") num1 -= Convert.ToDouble(Input.Text);
                    if (firstOperation == "x") num1 *= Convert.ToDouble(Input.Text);
                    if (firstOperation == "/") num1 /= Convert.ToDouble(Input.Text);

                    firstOperation = operation;

                    Input.Text = "0";
                }
                else 
                {
                    num1 = Convert.ToDouble(Input.Text);
                    firstOperation = operation;
                    Input.Text = "0";
                    num2 = true;
                }
            }
        }

        private void Result_Click(object sender, EventArgs e)
        {
            if(sqrt == true)
            {
                sqrtNum = Math.Sqrt(Convert.ToDouble(Input.Text));
                sqrt = false;
                Sqrt.BackColor = System.Drawing.Color.Silver;
                Input.Text = sqrtNum.ToString();
            }
            else
            {
                double result = 0;

                if(operation == "+") result = num1 + Convert.ToDouble(Input.Text);
                if (operation == "-") result = num1 - Convert.ToDouble(Input.Text);
                if (operation == "x") result = num1 * Convert.ToDouble(Input.Text);
                if (operation == "/") result = num1 / Convert.ToDouble(Input.Text);

                Input.Text = result.ToString();
                num2 = false;
            }
        }

        private void MPlus_Click(object sender, EventArgs e)
        {
            if(num2 == false)
            {
                if (Input.Text != "0")
                {
                    memory += Convert.ToDouble(Input.Text);
                    Input.Text = "0";
                }
            }
        }

        private void MMinus_Click(object sender, EventArgs e)
        {
            if(num2 == false)
            {
                if(Input.Text != "0")
                {
                    memory -= Convert.ToDouble(Input.Text);
                    Input.Text = "0";
                }
            }
        }

        private void MR_Click(object sender, EventArgs e)
        {
            Input.Text = memory.ToString();
        }

        private void MC_Click(object sender, EventArgs e)
        {
            memory = 0;
        }
    }
}
