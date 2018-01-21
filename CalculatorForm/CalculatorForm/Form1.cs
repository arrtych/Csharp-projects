using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double a = double.Parse(valueA.Text);
            double b = double.Parse(valueB.Text);
            double result = 0;

            ExtendedCalculator calculator = new ExtendedCalculator(a,b,result);
       
            // + method
            if (radioButton1.Checked == true)
            {
                double b1 = calculator.Add();
                calculator.Result = b1;
                resultLabel.Text = calculator.Result.ToString();
            }
            // - method
            else if (radioButton2.Checked == true)
            {

                calculator.Result = calculator.Subtract();
                resultLabel.Text = calculator.GetResult().ToString();
            }
            // / method
            else if (radioButton3.Checked == true)
            {

                calculator.Result = calculator.Divide();
                resultLabel.Text = calculator.GetResult().ToString();
            } 
            // * method
            else if (radioButton4.Checked == true)
            {

                calculator.Result = calculator.Multiply();
                resultLabel.Text = calculator.GetResult().ToString();
            }

            //labelT.Text += "A:" + a + ", B:" + b + ", R:" + calculator.GetResult();

        }

    }
    

  
}
