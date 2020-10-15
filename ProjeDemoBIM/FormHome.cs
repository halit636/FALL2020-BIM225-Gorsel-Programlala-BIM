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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            button1.BackColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Red;
            if (this.BackColor==lblMessage.ForeColor)
            {
                this.BackColor = Color.White;
            }
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Blue;

            if (this.BackColor == lblMessage.ForeColor)
            {
                this.BackColor = Color.White;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Green;
            if (this.BackColor == lblMessage.ForeColor)
            {
                this.BackColor = Color.White;
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value>=18)
            {
                richTextBox1.Text ="You are Older than 18," +
                    textBox1.Text;
            }
            else
            {
                richTextBox1.Text = "You are younger than 18 years," +
                    textBox1.Text;
            }
        }
    }
}
