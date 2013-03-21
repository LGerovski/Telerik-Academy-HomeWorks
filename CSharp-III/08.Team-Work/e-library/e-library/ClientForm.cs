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
    public partial class ClientForm : Form
    {
        public User client;

        public ClientForm(User client)
        {
            InitializeComponent();
            this.client = client;
            comboBox4.DataSource = System.Enum.GetValues(typeof(Language));
            listBox1.DataSource = Library.booksList;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.client = Library.clientsList.Find(x => x.FirstName == textBox1.Text);
            if (client != null)
            {
                client.FirstName = textBox1.Text;
            }

            this.client = Library.clientsList.Find(x => x.LastName == textBox2.Text);
            if (client != null)
            {
                client.LastName = textBox2.Text;
            }

            this.client = Library.clientsList.Find(x => x.Address == textBox3.Text);
            if (client != null)
            {
                client.Address = textBox3.Text;
            }

            this.client = Library.clientsList.Find(x => x.Phone == textBox4.Text);
            if (client != null)
            {
                client.Phone = textBox4.Text;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var book = Library.booksList.Find(x => x.Title == listBox1.Text);
            client.rentedBooks.Add(book);
            RentedBookPublisher rentedBook = new RentedBookPublisher();
            RentedBookSubscriber mySubscriber = new RentedBookSubscriber(rentedBook);
            rentedBook.RaiseEvent();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
