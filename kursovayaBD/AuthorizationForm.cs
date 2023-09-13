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
    public partial class AuthorizationForm : Form
    {

        
        public AuthorizationForm()
        {
            InitializeComponent();
            authBoxEmail.Text = "";
            authBoxPassword.Text = "";
            label3.Visible = false;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string[] userTypes = new string[2] {"customer", "manager"}; 
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            
            
            string login = authBoxEmail.Text;
            string passwd = authBoxPassword.Text;

            
            con.Open();

            foreach (var userType in userTypes)
            {
                SqlCommand cmd = new SqlCommand($"select * from {userType} where email = '{login}' and password = '{passwd}'", con);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read()) // построчно считываем данные
                    { 
                        var loginDB = reader.GetValue(5).ToString();
                        var id = (int)reader.GetValue(0);
                        MainForm form = new MainForm(userType, loginDB, id);
                        form.Show();
                        this.Hide();
                    }
                    reader.Close();
                    return;
                }
                else
                {
                    label3.Visible = true;
                    reader.Close();
                }
            }
            con.Close();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {


        }
    }
}
