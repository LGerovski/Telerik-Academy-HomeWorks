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
    public partial class LoginMenu : Form
    {

        public LoginMenu()
        {
            InitializeComponent();
        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private User GetUser(string email, string password)
        {
            var user = Library.clientsList.Find(x => x.Email == email && x.Password == password);
            if (user == null)
            {
                throw new InvalidUserNameOrPassword();
            }
            else
            {
                return user;
            }
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                var user = GetUser(UserName.Text, Password.Text);
                user.Interact();
            }
            catch (InvalidUserNameOrPassword)
            {
                MessageBox.Show("Invalid user name or password.");
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register registerNewClient = new Register();
            registerNewClient.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordRecovery newRecovery = new PasswordRecovery();
            newRecovery.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
