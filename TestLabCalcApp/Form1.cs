using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLabCalcApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.label1.Text = "0";
            this.label2.Text = "";
            this.label3.Text = "";
        }

        private double GetDoubleLabel1()
        {
            double res = 0;
            try
            {
                res = Convert.ToDouble(this.label1.Text);
            } catch
            {
                res = 0;
            }


            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = GetDoubleLabel1();
            res *= 10;
            if (res >= 0) res += 1;
            else res -= 1;
            this.label1.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var res = GetDoubleLabel1();
            res *= 10;
            if (res >= 0) res += 2;
            else res -= 2;
            this.label1.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var res = GetDoubleLabel1();
            res *= 10;
            if (res >= 0) res += 3;
            else res -= 3;
            this.label1.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var res = GetDoubleLabel1();
            res *= 10;
            if (res >= 0) res += 4;
            else res -= 4;
            this.label1.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var res = GetDoubleLabel1();
            res *= 10;
            if (res >= 0) res += 5;
            else res -= 5;
            this.label1.Text = res.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var res = GetDoubleLabel1();
            res *= 10;
            if (res >= 0) res += 6;
            else res -= 6;
            this.label1.Text = res.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var res = GetDoubleLabel1();
            res *= 10;
            if (res >= 0) res += 7;
            else res -= 7;
            this.label1.Text = res.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var res = GetDoubleLabel1();
            res *= 10;
            if (res >= 0) res += 8;
            else res -= 8;
            this.label1.Text = res.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var res = GetDoubleLabel1();
            res *= 10;
            if (res >= 0) res += 9;
            else res -= 9;
            this.label1.Text = res.ToString();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            var res = GetDoubleLabel1();
            res *= 10;
            this.label1.Text = res.ToString();
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            this.label3.Text = "mult";
            this.label2.Text = GetDoubleLabel1().ToString();
            this.label1.Text = "0";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            this.label3.Text = "div";
            this.label2.Text = GetDoubleLabel1().ToString();
            this.label1.Text = "0";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            this.label3.Text = "sub";
            this.label2.Text = GetDoubleLabel1().ToString();
            this.label1.Text = "0";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.label3.Text = "add";
            this.label2.Text = GetDoubleLabel1().ToString();
            this.label1.Text = "0";
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            var op_type = this.label3.Text;
            double res=0;
            bool except = false;
            switch(op_type)
            {
                case "add":
                    var firstNum = this.label1.Text;
                    var scndNum = this.label2.Text;
                    res = Calculator.Add(Convert.ToDouble(this.label2.Text), Convert.ToDouble(this.label1.Text));
                    break;
                case "sub":
                    res = Calculator.Sub(Convert.ToDouble(this.label2.Text), Convert.ToDouble(this.label1.Text));
                    break;
                case "mult":
                    res = Calculator.Mult(Convert.ToDouble(this.label2.Text), Convert.ToDouble(this.label1.Text));
                    break;
                case "div":
                    // TODO
                    try
                    {
                        res = Calculator.Div(Convert.ToDouble(this.label2.Text), Convert.ToDouble(this.label1.Text));
                    } catch(DivideByZeroException)
                    {
                        except = true;
                    }
                    break;
                case "":
                    res = 0;
                    break;
            }
            if (except)
                this.label1.Text = "DivideByZero";
            else
                this.label1.Text = res.ToString();
            this.label2.Text = "";
            this.label3.Text = "";

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var res = GetDoubleLabel1();
            res = (res - res%10)/10;
            this.label1.Text = res.ToString();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            this.label1.Text = "0";
            this.label2.Text = "";
            this.label3.Text = "";
        }

        public string Label1CurrentValue()
        {
            return this.label1.Text;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {

        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            var res = GetDoubleLabel1();
            res = -res;
            this.label1.Text = res.ToString();
        }
    }
}
