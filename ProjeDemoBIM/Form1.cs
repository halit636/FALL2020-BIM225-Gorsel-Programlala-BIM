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
    public partial class Form1 : Form
    {
        //constructor
        // default constructor
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();

            // imleç
            lblMessage.Text = "";

            // debug : bug=hata
            string x = "   Pak   istan   ";
            string y = x.Trim();

             //trim()
             //ilk ve son boşlu silecek

            if (email == "")
            {
                lblMessage.Text = "Please enter your email.";
                lblMessage.ForeColor = Color.Red;
                tbEmail.Focus();
                return;// donmek

            }

            if (password == "")
            {
                lblMessage.Text = "Please enter your password.";
                lblMessage.ForeColor = Color.Red;
                tbPassword.Focus();
                return;
            }

            if (email=="admin" && password=="123")
            {
                //lblMessage.Text = "Hosgeldin," + email;
                //lblMessage.ForeColor = Color.Green;
                //this.Hide();

                FormHome form = new FormHome();
                form.ShowDialog();

               

            }
            else
            {
                lblMessage.Text = "Email or Password is wrong";
                lblMessage.ForeColor = Color.Red;
            }



            //if (email == "")
            //{
            //    lblMessage.Text = "Please enter your email.";
            //    lblMessage.ForeColor = Color.Red;
            //}
            //else
            //{
            //    if (password == "")
            //    {
            //        lblMessage.Text = "Please enter your password.";
            //        lblMessage.ForeColor = Color.Red;
            //    }
            //    else
            //    {
            //        lblMessage.Text = "";
            //    }
            //}



            //if (email == "" || password == "")
            //{
            //    lblMessage.Text = "Please enter your email/password.";
            //}

            // ctrl + k + C
            // Ctrl + k + u
            //if (email == "")
            //{
            //    lblMessage.Text = "Please enter your email.";
            //}

            //if (password == "")
            //{
            //    lblMessage.Text = "Please enter your password.";
            //}



        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            cbRemember.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            cbRemember.Checked = false;
        }
    }
}
