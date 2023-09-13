using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovayaBD
{
    public partial class registrationAsManagerForm : Form
    {
        public registrationAsManagerForm()
        {
            InitializeComponent();
            
            List<ComboBoxItem> managerInfo = new List<ComboBoxItem> { };

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand($"select managerID, lastname, firstname, middlename from manager", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read()) // построчно считываем данные
                {
                    int id = (int)reader.GetValue(0);
                    var lastname = reader.GetValue(1).ToString();
                    var firstname = reader.GetValue(2).ToString();
                    var middlename = reader.GetValue(3).ToString();

                    managerInfo.Add(new ComboBoxItem { Id = id, Name = $"{lastname} {firstname} {middlename}" });

                }
            }
            reader.Close();
            con.Close();
            fireManagerComboBox.DataSource = managerInfo;
            fireManagerComboBox.DisplayMember = "Name";
            fireManagerComboBox.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создание строки подключения
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            
            // Создание команды
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM manager";

            string result = "";
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            // Проход в цикле по записям 
            while (reader.Read())
            {
                result = reader.GetValue(1) + " " + reader.GetValue(2) + " " + reader.GetValue(3) + Environment.NewLine;
                listBox1.Items.Add(result);

            }
            // Закрыттие DataReader
            reader.Close();
            

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            SqlCommand sqlCommand = new SqlCommand("SELECT dbo.count_managers()", con);

            string result = "";
            con.Open();
            int i = (int)sqlCommand.ExecuteScalar();
            result = "Количество менеджеров: " + i;
            managerCounter.Visible = true;
            managerCounter.Text = result.ToString();

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";
            DataContext db = new DataContext(connectionString);

            Table<manager> users = db.GetTable<manager>();

            manager newuser = new manager();
            newuser.lastname = lastnameTextBox.Text;
            newuser.firstname = firstnameTextBox.Text;
            newuser.middlename = middlenameTextBox.Text;
            newuser.phoneNumber = int.Parse(phoneNumberTextBox.Text);
            newuser.email = emailTextBox.Text;
            newuser.password = passwordTextBox.Text;
            
            //Добавление  нового пользователя в базу данных
            users.InsertOnSubmit(newuser);
            //Сохранение данных
            db.SubmitChanges();
            //очистка списка
            listBox1.Items.Clear();
            //Обновление списка
            foreach (var user in users)
            {
                listBox1.Items.Add(user.lastname + " " + user.firstname + " " + user.middlename);
            }

            //string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            //SqlConnection con = new SqlConnection(connectionString);

            //SqlCommand cmd = new SqlCommand("add_manager", con);
            //cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@lastname", lastnameTextBox.Text);
            //cmd.Parameters.AddWithValue("@firstname", firstnameTextBox.Text);
            //cmd.Parameters.AddWithValue("@middlename", middlenameTextBox.Text);
            //cmd.Parameters.AddWithValue("@phoneNumber", phoneNumberTextBox.Text);
            //cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            //cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
            //cmd.Parameters.Add(new SqlParameter("@managerID", SqlDbType.Int, 4));
            //cmd.Parameters["@managerID"].Direction = ParameterDirection.Output;
            //con.Open();

            //try
            //{
            //    cmd.ExecuteNonQuery();

            //    int mgId = (int)cmd.Parameters["@managerID"].Value;
            //    this.label7.Text = "Был добавлен новый клиент, его ID = " + mgId;


            //}
            //finally
            //{
            //    con.Close();
            //}

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            registration registration = new registration();
            registration.Show();
        }

        private void registrationAsManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertiseKursovayaDataSet.manager". При необходимости она может быть перемещена или удалена.
            this.managerTableAdapter.Fill(this.advertiseKursovayaDataSet.manager);

        }

        private void fireManagerButton_Click(object sender, EventArgs e)
        {

            int item = (int)fireManagerComboBox.SelectedValue;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";
            
            DataContext db = new DataContext(connectionString);
            
            Table<manager> users = db.GetTable<manager>();
            //выбор удаляемой записи
            manager user = db.GetTable<manager>().First(u=>u.managerID == item);
            //Удаление выбранной записи
            db.GetTable<manager>().DeleteOnSubmit(user);
            //Сохранение данных
            db.SubmitChanges();
            //очистка списка
            item = 1000;
        }

        private void fireManagerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void managerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.managerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.advertiseKursovayaDataSet);

        }

        private void fireManagerComboBox_Click(object sender, EventArgs e)
        {
            List<ComboBoxItem> managerInfo = new List<ComboBoxItem> { };

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand($"select managerID, lastname, firstname, middlename from manager", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read()) // построчно считываем данные
                {
                    int id = (int)reader.GetValue(0);
                    var lastname = reader.GetValue(1).ToString();
                    var firstname = reader.GetValue(2).ToString();
                    var middlename = reader.GetValue(3).ToString();

                    managerInfo.Add(new ComboBoxItem { Id = id, Name = $"{lastname} {firstname} {middlename}" });

                }
            }
            reader.Close();
            con.Close();
            fireManagerComboBox.DataSource = managerInfo;
            fireManagerComboBox.DisplayMember = "Name";
            fireManagerComboBox.ValueMember = "Id";
        }
    }

}

