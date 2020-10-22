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
            operation = '+';

            tbMain.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tbMain.Text += "0";
            //tbMain.Text = tbMain.Text  + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!tbMain.Text.Contains(","))
            {
                //if (tbMain.Text=="")
                if (string.IsNullOrEmpty(tbMain.Text))
                {
                    tbMain.Text += "0,";
                }
                else
                {
                    tbMain.Text += ",";
                }
                
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbMain.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbMain.Text += "6";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbMain.Text += "7";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbMain.Text += "8";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            tbMain.Text += "9";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            tbMain.Text = "";
            operation = ' ';
            num1 = 0;
            num2 = 0;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string str = tbMain.Text;
            if (str.Length>0)
            {
                //1234
                tbMain.Text= str.Substring(0, str.Length - 1);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (tbMain.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a number.");
                return;
            }
            // "12,34" + "567"
            //1234567
            num1 = float.Parse(tbMain.Text);
            operation = '-';
            tbMain.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (tbMain.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a number.");
                return;
            }

            num1 = float.Parse(tbMain.Text);
            operation = '/';
            tbMain.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (tbMain.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a number.");
                return;
            }

            num1 = float.Parse(tbMain.Text);
            operation = 'x';
            tbMain.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operation==' ')
            {
                MessageBox.Show("Please select Operation.");
                return;
            }

            if (tbMain.Text=="")
            {
                MessageBox.Show("Please select Number 2.");
                return;
            }

            num2 = float.Parse(tbMain.Text);

            // num1 + num2

            switch (operation)
            {
                case '+':
                    tbMain.Text =  (num1 + num2).ToString();
                    break;
                case '-':
                    tbMain.Text = (num1 - num2).ToString();
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by 2.");
                        tbMain.Text = "";
                    }
                    else
                    {
                        tbMain.Text = (num1 / num2).ToString();
                    }
                    break;
                case 'x':
                    tbMain.Text = (num1 * num2).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            // 5! = 5 x 4 x 3 x 2 x 1 = 
            //-
            if (tbMain.Text=="")
            {
                MessageBox.Show("Please enter a number.");
                return;
            }
            tbMain.Text = CacFactorial(int.Parse(tbMain.Text))
                                                   .ToString();

        }

        private long CacFactorial(int n)
        {
            if (n<0)
            {
                return -1;
            }
            else
            {
                if (n<=1)
                {
                    return 1;
                }
                long result = 1;
                for (int i = n; i >=1; i--)
                {
                    //result = result * i;
                    result *= i;
                }
                return result;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (tbMain.Text!="")
            {
                int num = int.Parse(tbMain.Text)*(-1);
                //"-", "+"
                tbMain.Text = num.ToString();
            }
        }
    }
}
