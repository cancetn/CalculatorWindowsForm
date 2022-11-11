using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsForm
{
    public partial class Form1 : MaterialForm
    {


        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;



        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
                Accent.LightBlue200, TextShade.WHITE);

        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;


            }
            else
            textBox1.Text = textBox1.Text + button.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                buttonEqual.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }



        }

        private void buttonAllDeleteFunc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {

                case "+":

                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":

                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":

                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":

                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;

                case "1/X":

                    textBox1.Text = (1 / resultValue).ToString();
                    break;


                default:
                    break;




            }

            resultValue = Double.Parse(textBox1.Text);
            labelCurrentOperation.Text = "";

        }

        private void denominator_click(object sender, EventArgs e)
        {
            resultValue = double.Parse(textBox1.Text);
            resultValue = 1 / resultValue;
            textBox1.Text = resultValue.ToString();

        }

        private void square_click(object sender, EventArgs e)
        {
            resultValue = double.Parse(textBox1.Text);
            resultValue = Math.Pow(resultValue, 2);
            textBox1.Text = resultValue.ToString();
        }

        private void squareRoot_click(object sender, EventArgs e)
        {
            resultValue = double.Parse(textBox1.Text);
            resultValue = Math.Sqrt(resultValue);
            textBox1.Text = resultValue.ToString();
        }

        private void percent_click(object sender, EventArgs e)
        {
            resultValue = double.Parse(textBox1.Text);
            resultValue = resultValue / 100;
            textBox1.Text = resultValue.ToString();
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked)
            {
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;

            }else
                TManager.Theme = MaterialSkinManager.Themes.DARK;
        }
    }
}
