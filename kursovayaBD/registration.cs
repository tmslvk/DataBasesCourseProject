using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovayaBD
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationAsCustomerForm registrationAsCustomerForm = new registrationAsCustomerForm();
            registrationAsCustomerForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationAsManagerForm registrationAsManagerForm = new registrationAsManagerForm();
            registrationAsManagerForm.Show();
        }

        private void registration_Load(object sender, EventArgs e)
        {

        }
    }
}
