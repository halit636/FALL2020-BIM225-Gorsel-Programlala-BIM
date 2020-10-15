using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeDemoBIM
{
    public partial class FormCalc : Form
    {
        float num1 = 0;
        float num2 = 0;
        char operation = ' ';

        public FormCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // tbMain.Text = tbMain.Text + "1";
            tbMain.Text +=  "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbMain.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbMain.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            tbMain.Text += "4";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (tbMain.Text.Trim()=="")
            {
                MessageBox.Show("Please enter a number.");
                return;
            }

            num1 = float.Parse( tbMain.Text);
            tbMain.Text = "";
        }
    }
}
