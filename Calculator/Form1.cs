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
    

    public partial class Form1 : Form
    {
        public double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void Operation()
        {
            if (result != 0)
                BtnEgal.PerformClick();
            else
            {
                result = double.Parse(TxtDisplay1.Text);
            }
            if (TxtDisplay1.Text != "0" )
            {
                TxtDisplay2.Text = fstNum = $"{result} {operation}";
                TxtDisplay1.Text = string.Empty;
            }
        }
           
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtDisplay1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0" || enterValue)
                TxtDisplay1.Text = string.Empty;
            enterValue = false;
            TxtDisplay1.Text += Btn0.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0" || enterValue)
                TxtDisplay1.Text = string.Empty;
            enterValue = false;
            TxtDisplay1.Text += Btn2.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0" || enterValue)
                TxtDisplay1.Text = string.Empty;
            enterValue = false;
            TxtDisplay1.Text += Btn5.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0" || enterValue)
                TxtDisplay1.Text = string.Empty;
            enterValue = false;
            TxtDisplay1.Text += Btn8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            TxtDisplay1.Text = "0";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text.Contains("."))
            {
                return;
            }
            else
            {
                TxtDisplay1.Text += BtnPoint.Text;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0" || enterValue)
                TxtDisplay1.Text = string.Empty;
            enterValue = false;
            TxtDisplay1.Text += Btn1.Text;
        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            operation = "+";
            Operation();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0" || enterValue)
                TxtDisplay1.Text = string.Empty;
            enterValue = false;
            TxtDisplay1.Text += Btn3.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            secNum = TxtDisplay1.Text;
            TxtDisplay2.Text = $"{TxtDisplay2.Text} {TxtDisplay1.Text}=";
            if (TxtDisplay1.Text != string.Empty)
            {
                if (TxtDisplay1.Text == "0")
                    TxtDisplay2.Text = string.Empty;
                switch (operation)
                {
                    case "+":
                        TxtDisplay1.Text = (result + Double.Parse(TxtDisplay1.Text)).ToString();
                        break;
                    case "-":
                        TxtDisplay1.Text = (result - Double.Parse(TxtDisplay1.Text)).ToString();
                        break;
                    case "x":
                        TxtDisplay1.Text = (result * Double.Parse(TxtDisplay1.Text)).ToString();
                        break;
                    case "÷":
                        TxtDisplay1.Text = (result / Double.Parse(TxtDisplay1.Text)).ToString();
                        break;
              //      default: TxtDisplay2.Text = $"{TxtDisplay1.Text}";

                }

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operation = "-";
            Operation();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0" || enterValue)
                TxtDisplay1.Text = string.Empty;
            enterValue = false;
            TxtDisplay1.Text += Btn6.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0" || enterValue)
                TxtDisplay1.Text = string.Empty;
            enterValue = false;
            TxtDisplay1.Text += Btn4.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operation = "x";
            Operation();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0" || enterValue)
                TxtDisplay1.Text = string.Empty;
            enterValue = false;
            TxtDisplay1.Text += Btn9.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0" || enterValue)
                TxtDisplay1.Text = string.Empty;
            enterValue = false;
            TxtDisplay1.Text += Btn7.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            operation = "÷";
            Operation();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text.Length > 0)
            {
                TxtDisplay1.Text = TxtDisplay1.Text.Remove(TxtDisplay1.Text.Length - 1);
            }
            if (TxtDisplay1.Text == string.Empty)
                TxtDisplay1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TxtDisplay1.Text = "0";
            TxtDisplay2.Text = "";
            result = 0;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void TxtDisplay2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
