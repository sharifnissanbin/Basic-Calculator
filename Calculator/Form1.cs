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
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirst.Clear();
            textBoxSecond.Clear();
            textBoxAnswer.Clear();
            textBoxFirst.Focus();   


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirst.Text != "" && textBoxSecond.Text != "")
               {
                int num1 = int.Parse(textBoxFirst.Text);
                int num2 = int.Parse(textBoxSecond.Text);
                int Answer = num1 + num2;

                textBoxAnswer.Text = Answer.ToString();
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }

        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (textBoxFirst.Text != "" && textBoxSecond.Text != "")
            {
                int num1 = int.Parse(textBoxFirst.Text);
                int num2 = int.Parse(textBoxSecond.Text);
                int Answer = num1 - num2;

                textBoxAnswer.Text = Answer.ToString();
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            if (textBoxFirst.Text != "" && textBoxSecond.Text != "")
            {
                int num1 = int.Parse(textBoxFirst.Text);
                int num2 = int.Parse(textBoxSecond.Text);
                int Answer = num1 * num2;

                textBoxAnswer.Text = Answer.ToString();
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (textBoxFirst.Text != "" && textBoxSecond.Text != "")
            {
                int num1 = int.Parse(textBoxFirst.Text);
                int num2 = int.Parse(textBoxSecond.Text);
                int Answer = num1 / num2;

                textBoxAnswer.Text = Answer.ToString();
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void textBoxFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
