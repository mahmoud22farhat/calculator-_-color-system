using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace الاله_الحاسبه
{
    public partial class Form1 : Form
    {
        double number1, number2, result;
        char op;

        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //txtcalc.Text += "0";
            Button but = (Button)sender;
            if (txtcalc.Text == "0") { txtcalc.Clear(); }
            if (but.Text == ",")
            {
                if (!txtcalc.Text.Contains(",")) { txtcalc.Text = txtcalc.Text + but.Text; }
            }
            else { txtcalc.Text = txtcalc.Text + but.Text; }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtcalc.Text);
            op = '-';
            txtcalc.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtcalc.Text);
            op = '*';
            txtcalc.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtcalc.Text);
            op = '/';
            txtcalc.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(txtcalc.Text);
            switch(op)
            {
                case '+':
                    result = number1 + number2 ;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = number1 / number2;
                    break;


            }
            txtcalc.Text = Convert.ToString(result);      }

        private void button9_Click(object sender, EventArgs e)
        {
            txtcalc.Clear();
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            lbldate.Text = DateTime.Now.ToShortDateString();


            Button btn = new Button();

            btn.BackColor = button1.BackColor;
            button1.BackColor = button8.BackColor;

            button8.BackColor = btn.BackColor;



            btn.BackColor = button12.BackColor;
            button12.BackColor = button3.BackColor;

            button3.BackColor = btn.BackColor;


            btn.BackColor = button6.BackColor;
            button6.BackColor = button10.BackColor;

            button10.BackColor = btn.BackColor;


            btn.BackColor = button2.BackColor;
            button2.BackColor = button7.BackColor;

            button7.BackColor = btn.BackColor;

            btn.BackColor = button11.BackColor;
            button11.BackColor = button4.BackColor;

            button4.BackColor = btn.BackColor;



            btn.BackColor = button5.BackColor;
            button5.BackColor = button17.BackColor;

            button17.BackColor = btn.BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtcalc.Text += ",";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtcalc.Text);
            op = '+';
            txtcalc.Clear();
        }
    }
}
