using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace John_Tran_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PerformOperation(new Adder());
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            PerformOperation(new Subtractor());
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation(new Multiplier());
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            PerformOperation(new Divider());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PerformOperation(BaseOperation operation)
        {
            string input1 = textBox1.Text;
            string input2 = textBox2.Text;

            if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
            {
                try
                {
                    // .Calculate() works differently depending on which class was passed in
                    double result = operation.Calculate(number1, number2);
                    lblResult.Text = "Result: " + result.ToString();
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message, "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both input fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
