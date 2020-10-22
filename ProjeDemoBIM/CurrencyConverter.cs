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
    public partial class CurrencyConverter : Form
    {
        public CurrencyConverter()
        {
            InitializeComponent();
        }

        private void cbInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInput.Text=  cbInput.SelectedItem.ToString(); 
        }

        private void cbOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblOutput.Text = cbInput.SelectedItem.ToString();

        }
    }
}
