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
        enum Operators {None, Add, Subtract, Multiply, Divide, Result}

        Operators currentOperator = Operators.None;

        bool operatorChangeFlag = false;
        double firstValue = 0;
        double secondValue = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReturnStringToDouble("7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReturnStringToDouble("8");
        }

        private void buttonresult_Click(object sender, EventArgs e)
        {
            secondValue = double.Parse(display.Text);

            if(currentOperator == Operators.Add)
            {
                firstValue += secondValue;
                display.Text = firstValue.ToString();
            }
            else if(currentOperator == Operators.Subtract)
            {
                firstValue -= secondValue;
                display.Text = firstValue.ToString();
            }
            else if(currentOperator == Operators.Multiply)
            {
                firstValue *= secondValue;
                display.Text = firstValue.ToString();
            }
            else if(currentOperator == Operators.Divide)
            {
                if(secondValue == 0)
                {
                    MessageBox.Show("0으로 나눌 수 없습니다", "나누기 에러", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return;
                }
                else
                {
                    firstValue /= secondValue;
                    display.Text = firstValue.ToString();
                }
            }
            else if(currentOperator == Operators.Result)
            {
                MessageBox.Show("현재 버전에서는 결과 버튼으로 이전 데이터를 불러 올 수 없습니다", "연속된 결과 사용 불가능", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            currentOperator = Operators.Result;

            explain.Text = firstValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnStringToDouble("1");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ReturnStringToDouble("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReturnStringToDouble("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReturnStringToDouble("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReturnStringToDouble("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReturnStringToDouble("6");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ReturnStringToDouble("9");
        }

        private void ReturnStringToDouble(string number)
        {
            if (operatorChangeFlag)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            string result = display.Text += number;

            display.Text = double.Parse(result).ToString();
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (display.Text.Contains("."))
            {
                return;
            }
            else
            {
                display.Text += ".";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;

            explain.Text = display.Text + "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;

            explain.Text = display.Text + "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;

            explain.Text = display.Text + "×";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;

            explain.Text = display.Text + "÷";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(operatorChangeFlag == true || display.Text =="0")
            {
                display.Text = "0";
                operatorChangeFlag = false;
            }
            else
            {
                display.Text += "0";
            }

        }
    }
}
