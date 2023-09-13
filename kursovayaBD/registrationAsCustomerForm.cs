using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovayaBD
{
    public partial class registrationAsCustomerForm : Form
    {
        public registrationAsCustomerForm()
        {
            InitializeComponent();
            


        }
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrationAsCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("add_customer", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@lastname", lastnameTextBox.Text);
            cmd.Parameters.AddWithValue("@firstname", firstnameTextBox.Text);
            cmd.Parameters.AddWithValue("@middlename", middlenameTextBox.Text);
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
            cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int, 4));
            cmd.Parameters["@userID"].Direction = ParameterDirection.Output;
            con.Open();

            try
            {
                cmd.ExecuteNonQuery();

                int cuID = (int)cmd.Parameters["@userID"].Value;
                this.infoLabel.Text = "Вы были успешно зарегестрированы! Ваш ID= " + cuID;


            }
            finally
            {
                con.Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            registration registration = new registration();
            registration.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";
            string sqlStr = "SELECT * FROM customer";
            SqlConnection con = new SqlConnection(connectionString);
            // Создание объекта DataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, con);
            // Создание объекта Dataset
            DataSet ds = new DataSet();
            // Заполняем Dataset
            adapter.Fill(ds, "customer");
            // Отображаем данные
            dataGridView1.DataSource = ds.Tables[0];

            
        }
    }
}
