using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_library
{
    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void CheckPassword(string userPassword, string repeatPassword)
        {
            if (userPassword != repeatPassword)
            {
                throw new PasswordDoesNotMatch();
            }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CheckPassword(userPassword.Text, repeatPassword.Text);
                Library.clientsList.Add(new Client("Krasi", "Martinchev", userEmail.Text, userPassword.Text, "Geo Milev", "0883651729"));
            }
            catch (PasswordDoesNotMatch)
            {
                MessageBox.Show("Password does not match.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Invalid email");
            }
            MessageBox.Show("New Client has been registered.");
        }

        public void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginMenu login = new LoginMenu();
            login.Show();
        }

        private void userEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void userPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void repeatPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
