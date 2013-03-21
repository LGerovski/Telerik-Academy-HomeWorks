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
    public partial class AdminForm : Form
    {
        Administrator currentAdmin;
        public AdminForm(Administrator admin)
        {
            InitializeComponent();
            this.currentAdmin = admin;
            comboBox1.DataSource = System.Enum.GetValues(typeof(Section));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
