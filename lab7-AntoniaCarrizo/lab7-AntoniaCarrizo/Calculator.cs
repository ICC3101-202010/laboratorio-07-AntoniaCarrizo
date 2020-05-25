using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7_AntoniaCarrizo
{
    public partial class Calculator : Form
    {
        List<Panel> stackPanels = new List<Panel>();
        private decimal firstNum;
        private decimal secondNum;
        private string operation;
        private string resultOp;
        Operations oper = new Operations();
        public Calculator()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultados.Text = resultOp;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                secondNum = decimal.Parse(resultados.Text);
     
                switch (operation)
                {
                    case "+":
                        try
                        {
                            decimal result = oper.Sum(firstNum, secondNum);
                            resultados.Text = result.ToString();
                            resultOp = resultados.Text;
                            operation = "";
                        }
                        catch
                        {
                            resultados.Text = "Syntax ERROR";
                        }
                        break;
                    case "-":
                        try
                        {
                            decimal result = oper.Subtract(firstNum, secondNum);
                            resultados.Text = result.ToString();
                            resultOp = resultados.Text;
                            operation = "";
                        }
                        catch
                        {
                            resultados.Text = "Syntax ERROR";
                        }
                        break;
                    case "x":
                        try
                        {
                            decimal result = oper.Multiplication(firstNum, secondNum);
                            resultados.Text = result.ToString();
                            resultOp = resultados.Text;
                            operation = "";
                        }
                        catch
                        {
                            resultados.Text = "Syntax ERROR";
                        }
                        break;
                    case "÷":
                        try
                        {
                            decimal result = oper.Division(firstNum, secondNum);

                            resultados.Text = result.ToString();
                            resultOp = resultados.Text;
                            operation = "";
                        }
                        catch (DivideByZeroException)
                        {
                            resultados.Text = "Math Error";
                        }

                        catch (SystemException)
                        {
                            resultados.Text = "Syntax ERROR";
                        }
                        break;

                    default:
                        try
                        {
                            decimal result = decimal.Parse(resultados.Text);
                            resultados.Text = result.ToString();
                            resultOp = resultados.Text;
                        }
                        catch
                        {
                            resultados.Text = "Syntax ERROR";
                        }
                        break;

                        ;
                }
            }
            catch
            {
                resultados.Text = "Syntax ERROR";
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            resultados.Text += "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultados.Text += "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            resultados.Text += "7";
        }

        

        private void num0_Click(object sender, EventArgs e)
        {
            resultados.Text += "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            resultados.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            resultados.Text += "2";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            resultados.Text +="5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            resultados.Text += "6";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            resultados.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            resultados.Text += "9";
        }

        private void punto_Click(object sender, EventArgs e)
        {
            resultados.Text += ",";
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void suma_Click(object sender, EventArgs e)
        {
            operation = "+";
            try
            {
                firstNum = decimal.Parse(resultados.Text);
           
                resultados.Clear();
                


            }
            catch
            {
                resultados.Text = "Syntax ERROR";
            }

        }

        private void resta_Click(object sender, EventArgs e)
        {
            operation = "-";
            try
            {
                firstNum = decimal.Parse(resultados.Text);
                resultados.Clear();
            }
            catch
            {
                resultados.Text = "Syntax ERROR";
            }

        }

        private void multi_Click(object sender, EventArgs e)
        {
            operation = "x";
            try
            {
                firstNum = decimal.Parse(resultados.Text);
                resultados.Clear();
            }
            catch
            {
                resultados.Text = "Syntax ERROR";
            }


        }
        private void button10_Click(object sender, EventArgs e)
        {
            operation = "÷";

            try
            {
                firstNum = decimal.Parse(resultados.Text);
                resultados.Clear();
            }
            catch
            {
                resultados.Text = "Syntax ERROR";
            }
        }
        private void ac_Click(object sender, EventArgs e)
        {
            resultados.Clear();
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (resultados.Text.Length == 1)
            {
                resultados.Text = "";
            }
            else
            {
                resultados.Text = resultados.Text.Substring(0,resultados.Text.Length - 1);
            }
        }

       
       
    }
}
