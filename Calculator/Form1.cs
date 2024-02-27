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
        double SecondeValue = 0;
        double thirdValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnStringToDouble("7");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SecondeValue = double.Parse(display.Text);

            // firstvalue 연산자 secondvalue 변수에 데이터들이 저장이 되어있습니다.

            if(currentOperator == Operators.Add)
            {

            }
            else if(currentOperator == Operators.Subtract)
            {

            }
            else if (currentOperator == Operators.Multiply)
            {

            }
            else if(currentOperator == Operators.Divide)
            {
                if(SecondeValue == 0)
                {
                    MessageBox.Show("0으로는 숫자를 나눌수 없습니다.", "나누기의 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                firstValue /= SecondeValue;
                display.Text = firstValue.ToString();
            }
            else if(currentOperator == Operators.Result)
            {
                // 기존의 계산기 같은 경우에는 


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReturnStringToDouble("8");
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            ReturnStringToDouble("9");
        }

        private void button_Plus_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;

            explain.Text = display.Text + "＋";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            ReturnStringToDouble("4");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            ReturnStringToDouble("5");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            ReturnStringToDouble("6");
        }

        private void button_Minus_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            ReturnStringToDouble("1");
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            ReturnStringToDouble("2");
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            ReturnStringToDouble("3");
        }

        private void button_Multiply_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void button_AllClear_Click(object sender, EventArgs e)
        {
            firstValue = 0;
            SecondeValue = 0;
            currentOperator = Operators.None;
            display.Text = "0";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if(operatorChangeFlag == true)
            {
                display.Text = "0";
                operatorChangeFlag = false;
            }



        }

        private void button_Dot_Click(object sender, EventArgs e)
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

        private void button_Divide_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        private void ReturnStringToDouble(string stringNumber)
        {
            if (operatorChangeFlag)
            {
                // 연산자 처리만 이루어 져야 되기 때문에
                operatorChangeFlag = false;
            }

            string result = display.Text += stringNumber;
            display.Text = double.Parse(result).ToString();

        }

        private void explain_Click(object sender, EventArgs e)
        {

        }
    }
}
