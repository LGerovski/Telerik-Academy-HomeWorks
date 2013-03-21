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
    public partial class PasswordRecovery : Form
    {

        public PasswordRecovery()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private User GetEmail(string email)
        {
            var user = Library.clientsList.Find(x => x.Email == email);
            if (user == null)
            {
                throw new InvalidEmail();
            }
            else
            {
                return user;
            }
        }
        private void Retrieve_Click(object sender, EventArgs e)
        {
            try
            {
                var user = GetEmail(textBox1.Text);
                MessageBox.Show("Message with your password has been sent to your email address ");
            }
            catch (InvalidEmail)
            {
                MessageBox.Show("Invalid email");
            }
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
