using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace kursovayaBD
{
    public partial class MainForm : Form
    {
        public string managerIDFormBuf;
        public string customerIDFormBuf;
        public int month = 1;
        public int userID;
        public string loginDB;
        public EditServiceForm editService;
        public string userType;

        public MainForm(string userType,string login , int id)
        {
            InitializeComponent();
            labelNameOfCustomer.Text = "";
            this.userID = id;
            this.userType = userType;
            OldDataTextBoxes();
            InitializeComboBoxListManager();
            InitializeComboBoxServiceList();
            InitializeComboBoxRentList();
            InitializeFilterBoxByService();
            
            InitializeAdServices(serviceEditOrder);
            InitializeManagerForEditOrder(managerEditOrder);
            InitializePlaceOfAdForEditOrder(rentPlaceEditOrder);
            InitializeManagerForEditOrder(managerFilterComboBox);

            GetOrderID();
            DataView viewForCustomers = new DataView(advertiseKursovayaDataSet1.viewGetOrderForCustomers);
            viewForCustomers.RowFilter = $"userID={userID}";


            viewGetOrderForCustomersDataGridView.DataSource = viewForCustomers;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            if (userType == "customer")
            {
                greetingsLabel.Text = "Вы зашли как заказчик";
                addServiceButton.Visible = false;
                addPlaceOfAdButton.Visible = false;

                addServiceGroupBox.Visible = false;
                makeAnOrderGroupBox.Visible = false;
                getOrderGroupBox.Visible = false;
                addAPlaceOfAdGroupBox.Visible = false;
                EditOrderGroupBox.Visible = false;
                reportOrderForManagersButton.Visible = false;
                showByServicesGetOrders.Visible = false;
                filterButtonForManagers.Visible = false;
                filterButtonForCustomers.Visible = true;
                reportOrderFromCustomers.Visible = true;
                viewGetOrderForCustomersDataGridView.Visible = true;
                viewGetOrderForManagersDataGridView.Visible = false;
                reportOrderForManagersButton.Visible = false;
                editOrdersButton.Visible = false;
                filterByDateGroupbox.Visible = true;
                ChangeDataGroupBox.Visible = false;

                SqlCommand cmd = new SqlCommand($"select userID from {userType} where email = '{login}'", con);
                SqlDataReader readerCustomer = cmd.ExecuteReader();
                if (readerCustomer.HasRows)
                {
                    while (readerCustomer.Read()) // построчно считываем данные
                    {
                        this.customerIDFormBuf = readerCustomer.GetValue(0).ToString();

                    }

                    return;
                }
                readerCustomer.Close();
                con.Close();
            }
            else
            {
                viewGetOrderForManagersDataGridView.Visible = true;
                reportOrderForManagersButton.Visible = false;
                makeOrderButton.Visible = false;
                showByServicesGetOrders.Visible = true;
                viewGetOrderForCustomersDataGridView.Visible = false;
                reportOrderForManagersButton.Visible = true;
                filterButtonForManagers.Visible = true;
                filterButtonForCustomers.Visible = false;
                reportOrderFromCustomers.Visible = false;
                editOrdersButton.Visible = true;
                execReportOfResultsButton.Visible = true;
                ChangeDataGroupBox.Visible = false;

                addServiceGroupBox.Visible = false;
                makeAnOrderGroupBox.Visible = false;
                getOrderGroupBox.Visible = false;
                addAPlaceOfAdGroupBox.Visible = false;
                EditOrderGroupBox.Visible = false;
                

                greetingsLabel.Text = "Вы зашли как менеджер";
                SqlCommand cmd = new SqlCommand($"select managerID from {userType} where email = '{login}'", con);
                SqlDataReader readerManager = cmd.ExecuteReader();
                if (readerManager.HasRows)
                {
                    while (readerManager.Read()) // построчно считываем данные
                    {
                        this.managerIDFormBuf = readerManager.GetValue(0).ToString();

                    }
                    return;
                }
                readerManager.Close();
                con.Close();
            }
            con.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertiseKursovayaDataSet1.placeOfAdvertisement". При необходимости она может быть перемещена или удалена.
            this.placeOfAdvertisementTableAdapter.Fill(this.advertiseKursovayaDataSet1.placeOfAdvertisement);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertiseKursovayaDataSet1.adServices". При необходимости она может быть перемещена или удалена.
            this.adServicesTableAdapter.Fill(this.advertiseKursovayaDataSet1.adServices);
            this.viewGetOrderForManagersTableAdapter1.Fill(this.advertiseKursovayaDataSet1.viewGetOrderForManagers);
            this.viewGetOrderForCustomersTableAdapter1.Fill(this.advertiseKursovayaDataSet1.viewGetOrderForCustomers);
        }

        private void previousAdServiceButton_Click(object sender, EventArgs e)
        {
            adServicesBindingSource.MovePrevious();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizationForm form = new AuthorizationForm();
            form.Show();
        }

        private void firstAdServiceButton_Click(object sender, EventArgs e)
        {
            adServicesBindingSource.MoveFirst();
        }

        private void nextAdServiceButton_Click(object sender, EventArgs e)
        {
            adServicesBindingSource.MoveNext();
        }

        private void lastAdServiceButton_Click(object sender, EventArgs e)
        {
            adServicesBindingSource.MoveLast();
        }

        private void addAdServiceButton_Click(object sender, EventArgs e)
        {
            adServicesBindingSource.AddNew();
        }

        private void deleteAdServiceButton_Click(object sender, EventArgs e)
        {
            adServicesBindingSource.RemoveCurrent();
        }

        private void saveAdServiceButton_Click(object sender, EventArgs e)
        {
            adServicesBindingSource.EndEdit();
            adServicesTableAdapter.Update(advertiseKursovayaDataSet1);
        }

        private void cancelAdServiceButton_Click(object sender, EventArgs e)
        {
            adServicesBindingSource.CancelEdit();
        }

        private void showByServicesGetOrders_Click(object sender, EventArgs e)
        {
            DataView viewForManagers = new DataView(advertiseKursovayaDataSet1.viewGetOrderForManagers);
            viewForManagers.RowFilter = $"managerID = {managerIDFormBuf}";
            viewGetOrderForManagersDataGridView.DataSource = viewForManagers;
        }
        
        private void dropDownMenuManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dropDownMenuService_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dropDownMenuRent_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (ComboBoxItemForRent)dropDownMenuRent.SelectedItem;
            fullPriceLabel.Text = (item.RentPrice * month).ToString();
            
        }

        private void InitializeComboBoxListManager()
        {
            this.InitializeManagerForEditOrder(dropDownMenuManager);
        }

        public void InitializeManagerForEditOrder(ComboBox comboBox)
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
            comboBox.DataSource = managerInfo;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
        }

        private void InitializeComboBoxServiceList()
        {
            this.InitializeAdServices(dropDownMenuService);
        }

        public void InitializeAdServices(ComboBox comboBox)
        {
            List<ComboBoxItem> serviceInfo = new List<ComboBoxItem> { };

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand($"select serviceID, service from adServices", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read()) // построчно считываем данные
                {
                    int id = (int)reader.GetValue(0);
                    var service = reader.GetValue(1).ToString();
                    serviceInfo.Add(new ComboBoxItem { Id = id, Name = $"{service}" });
                }
            }
            reader.Close();
            con.Close();
            comboBox.DataSource = serviceInfo;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
        }

        private void InitializeComboBoxRentList()
        {
            this.InitializePlaceOfAdForEditOrder(dropDownMenuRent);
        }

        public void InitializePlaceOfAdForEditOrder(ComboBox comboBox)
        {
            List<ComboBoxItemForRent> rentInfo = new List<ComboBoxItemForRent> { };

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand($"select * from placeOfAdvertisement", con);
            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read()) // построчно считываем данные
                {

                    int id = (int)reader.GetValue(0);
                    var typeOfAd = reader.GetValue(2).ToString();
                    var rentPricePerMonth = (int)reader.GetValue(1);

                    rentInfo.Add(new ComboBoxItemForRent { Id = id, Name = $"{typeOfAd}", RentPrice = rentPricePerMonth });

                }
            }
            reader.Close();
            con.Close();
            comboBox.DataSource = rentInfo;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
        }

        private void InitializeFilterBoxByService()
        {
            List<ComboBoxItem> rentInfo = new List<ComboBoxItem> { };

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand($"select service, serviceID from adServices", con);
            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read()) // построчно считываем данные
                {
                    var service = reader.GetValue(0).ToString();
                    int id = (int)reader.GetValue(1);                 
                    rentInfo.Add(new ComboBoxItem { Id = id, Name = $"{service}" });
                }
            }
            reader.Close();
            con.Close();
            filterBoxByService.DataSource = rentInfo;
            filterBoxByService.DisplayMember = "Name";
            filterBoxByService.ValueMember = "Id";
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            month = (int)numericUpDown1.Value;
            var item = (ComboBoxItemForRent)dropDownMenuRent.SelectedItem;
            fullPriceLabel.Text = (item.RentPrice * month).ToString();
        }

        private void comleteOrderButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            
            SqlCommand cmd = new SqlCommand("add_order", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@serviceID", dropDownMenuService.SelectedValue);
            cmd.Parameters.AddWithValue("@dateAdFrom", DateTime.Today);
            cmd.Parameters.AddWithValue("@dateAdTo", DateTime.Today.AddMonths((int)numericUpDown1.Value));
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@managerID", dropDownMenuManager.SelectedValue);
            cmd.Parameters.AddWithValue("@placeID", dropDownMenuRent.SelectedValue);

            cmd.Parameters.Add(new SqlParameter("@orderID", SqlDbType.Int, 4));
            
            cmd.Parameters["@orderID"].Direction = ParameterDirection.Output;

            try
            {
                cmd.ExecuteNonQuery();
                SqlCommand getInfoFromManager = new SqlCommand($"select email, phoneNumber from manager", con);
                SqlDataReader reader = getInfoFromManager.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        var email = reader.GetValue(0);
                        var phoneNumber = reader.GetValue(1);
                        int orderId = (int)cmd.Parameters["@orderID"].Value;
                        this.checkOfOrderTextBox.Text =
                            "Спасибо, что выбрали нас в качетсве своего рекламного агентства." + Environment.NewLine +
                            "Ваш номер заказа: " + orderId + Environment.NewLine +
                            "Ваш менеджер: " + $"{dropDownMenuManager.Text}" + Environment.NewLine +
                            "Контакты менеджера: " + Environment.NewLine +
                            "\tПочта: " + email.ToString() + Environment.NewLine +
                            "\tТелефон: " + phoneNumber.ToString() + Environment.NewLine +
                            "Услуга: " + $"{dropDownMenuService.Text}" + Environment.NewLine +
                            "Арендоместо: " + Environment.NewLine +
                            $"{dropDownMenuRent.Text}" + Environment.NewLine +
                            "Дата начала аренды: " + DateTime.Today.ToString() + Environment.NewLine +
                            "Дата окончания аренды: " + DateTime.Today.AddMonths((int)numericUpDown1.Value).ToString() + Environment.NewLine +
                            "Полная цена аренды: " + fullPriceLabel.Text;
                    }
                }
                reader.Close();
            }
            finally
            {
                con.Close();
            }
        }

        private void rentAddButton_Click(object sender, EventArgs e)
        {
            placeOfAdvertisementBindingSource.AddNew();
        }

        private void rentDeleteButton_Click(object sender, EventArgs e)
        {
            placeOfAdvertisementBindingSource.RemoveCurrent();
        }

        private void rentSaveButton_Click(object sender, EventArgs e)
        {
            placeOfAdvertisementBindingSource.EndEdit();
            placeOfAdvertisementTableAdapter.Update(advertiseKursovayaDataSet1);
        }

        private void rentCancelButton_Click(object sender, EventArgs e)
        {
            placeOfAdvertisementBindingSource.CancelEdit();
        }

        private void rentGetFirstButton_Click(object sender, EventArgs e)
        {
            placeOfAdvertisementBindingSource.MoveFirst();
        }

        private void rentGetPreviousButton_Click(object sender, EventArgs e)
        {
            placeOfAdvertisementBindingSource.MovePrevious();
        }

        private void rentGetNextButton_Click(object sender, EventArgs e)
        {
            placeOfAdvertisementBindingSource.MoveNext();
        }

        private void rentGetLastButton_Click(object sender, EventArgs e)
        {
            placeOfAdvertisementBindingSource.MoveLast();
        }

        private void viewGetOrderForManagersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void makeAnOrderButton_Click(object sender, EventArgs e)
        {
            makeAnOrderGroupBox.Visible = true;

            getOrderGroupBox.Visible = false;
            addServiceGroupBox.Visible = false;
            addAPlaceOfAdGroupBox.Visible = false;
            EditOrderGroupBox.Visible = false;
            ChangeDataGroupBox.Visible = false;
        }

        private void getOrderButton_Click(object sender, EventArgs e)
        {

            this.viewGetOrderForManagersTableAdapter1.Fill(this.advertiseKursovayaDataSet1.viewGetOrderForManagers);
            this.viewGetOrderForCustomersTableAdapter1.Fill(this.advertiseKursovayaDataSet1.viewGetOrderForCustomers);
            getOrderGroupBox.Visible = true;

            makeAnOrderGroupBox.Visible = false;
            addAPlaceOfAdGroupBox.Visible = false;
            addServiceGroupBox.Visible = false;
            EditOrderGroupBox.Visible = false;
            ChangeDataGroupBox.Visible = false;
        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            addServiceGroupBox.Visible = true;

            getOrderGroupBox.Visible = false;
            makeAnOrderGroupBox.Visible = false;
            addAPlaceOfAdGroupBox.Visible = false;
            EditOrderGroupBox.Visible = false;
            ChangeDataGroupBox.Visible = false;
        }

        private void addPlaceOfAdButton_Click_1(object sender, EventArgs e)
        {
            addAPlaceOfAdGroupBox.Visible = true;

            addServiceGroupBox.Visible = false;
            makeAnOrderGroupBox.Visible = false;
            getOrderGroupBox.Visible = false;
            EditOrderGroupBox.Visible = false;
            ChangeDataGroupBox.Visible = false;
        }

        private void checkOfOrderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filterButtonForManagers_Click(object sender, EventArgs e)
        {
            var item = (ComboBoxItem)filterBoxByService.SelectedItem;
            DateTime dateFromPicker = dateTimePickerFrom.Value;
            DateTime dateToPicker = dateTimePickerTo.Value;
            var filterManagerComboBox = (ComboBoxItem)managerFilterComboBox.SelectedItem;
            if (dateCheckBox.Checked == true && serviceCheckBox.Checked == false && filterManagerCheckBox.Checked == false)
            {
                var query = from customer in advertiseKursovayaDataSet1.viewGetOrderForManagers
                            where customer.dateAdFrom > dateFromPicker &
                            customer.dateAdTo < dateToPicker
                            select customer;

                DataTable tblClone = advertiseKursovayaDataSet1.viewGetOrderForManagers.Clone();
                foreach (DataRow datRow in query)
                {
                    tblClone.ImportRow(datRow);
                }
                DataView viewFilterForManagers = new DataView(tblClone);

                viewGetOrderForManagersDataGridView.DataSource = viewFilterForManagers;
            }
            else if(item.Name != null && serviceCheckBox.Checked == true && dateCheckBox.Checked == false && filterManagerCheckBox.Checked == false)
            {
                var query = from manager in advertiseKursovayaDataSet1.viewGetOrderForManagers
                            where manager.service == item.Name
                            select manager;

                DataTable tblClone = advertiseKursovayaDataSet1.viewGetOrderForManagers.Clone();
                foreach (DataRow datRow in query)
                { 
                    tblClone.ImportRow(datRow);
                }
                DataView viewFilterForManagers = new DataView(tblClone);

                viewGetOrderForManagersDataGridView.DataSource = viewFilterForManagers;
            }
            else if (item.Name != null && serviceCheckBox.Checked == true && dateCheckBox.Checked == true && filterManagerCheckBox.Checked == false)
            {

                var query = from customer in advertiseKursovayaDataSet1.viewGetOrderForManagers
                            where customer.service == item.Name &
                            customer.dateAdFrom > dateFromPicker &
                            customer.dateAdTo < dateToPicker
                            select customer;

                DataTable tblClone = advertiseKursovayaDataSet1.viewGetOrderForManagers.Clone();
                foreach (DataRow datRow in query)
                {
                    tblClone.ImportRow(datRow);
                }
                DataView viewFilterForManagers = new DataView(tblClone);

                viewGetOrderForManagersDataGridView.DataSource = viewFilterForManagers;
            }
            else if (item.Name != null && serviceCheckBox.Checked == false && dateCheckBox.Checked == false && filterManagerCheckBox.Checked == true)
            {

                var query = from customer in advertiseKursovayaDataSet1.viewGetOrderForManagers
                            where customer.managerID == filterManagerComboBox.Id
                            select customer;

                DataTable tblClone = advertiseKursovayaDataSet1.viewGetOrderForManagers.Clone();
                foreach (DataRow datRow in query)
                {
                    tblClone.ImportRow(datRow);
                }
                DataView viewFilterForManagers = new DataView(tblClone);

                viewGetOrderForManagersDataGridView.DataSource = viewFilterForManagers;
            }
            else if (item.Name != null && serviceCheckBox.Checked == true && dateCheckBox.Checked == false && filterManagerCheckBox.Checked == true)
            {

                var query = from customer in advertiseKursovayaDataSet1.viewGetOrderForManagers
                            where customer.service == item.Name &
                            customer.managerID == filterManagerComboBox.Id
                            select customer;

                DataTable tblClone = advertiseKursovayaDataSet1.viewGetOrderForManagers.Clone();
                foreach (DataRow datRow in query)
                {
                    tblClone.ImportRow(datRow);
                }
                DataView viewFilterForManagers = new DataView(tblClone);

                viewGetOrderForManagersDataGridView.DataSource = viewFilterForManagers;
            }
            else if (item.Name != null && serviceCheckBox.Checked == false && dateCheckBox.Checked == true && filterManagerCheckBox.Checked == true)
            {
                var query = from customer in advertiseKursovayaDataSet1.viewGetOrderForManagers
                            where customer.dateAdFrom > dateFromPicker &
                            customer.dateAdTo < dateToPicker &
                            customer.managerID == filterManagerComboBox.Id
                            select customer;

                DataTable tblClone = advertiseKursovayaDataSet1.viewGetOrderForManagers.Clone();
                foreach (DataRow datRow in query)
                {
                    tblClone.ImportRow(datRow);
                }
                DataView viewFilterForManagers = new DataView(tblClone);

                viewGetOrderForManagersDataGridView.DataSource = viewFilterForManagers;
            }
            else if (item.Name != null && serviceCheckBox.Checked == true && dateCheckBox.Checked == true && filterManagerCheckBox.Checked == true)
            {

                var query = from customer in advertiseKursovayaDataSet1.viewGetOrderForManagers
                            where customer.service == item.Name &
                            customer.managerID == filterManagerComboBox.Id &
                            customer.dateAdFrom > dateFromPicker &
                            customer.dateAdTo < dateToPicker
                            select customer;

                DataTable tblClone = advertiseKursovayaDataSet1.viewGetOrderForManagers.Clone();
                foreach (DataRow datRow in query)
                {
                    tblClone.ImportRow(datRow);
                }
                DataView viewFilterForManagers = new DataView(tblClone);

                viewGetOrderForManagersDataGridView.DataSource = viewFilterForManagers;
            }
        }

        private void filterButtonForCustomers_Click(object sender, EventArgs e)
        {
            var item = (ComboBoxItem)filterBoxByService.SelectedItem;
            DateTime dateFromPickerForCustomers = dateTimePickerFrom.Value;
            DateTime dateToPickerForCustomers = dateTimePickerTo.Value;
            

            if (dateCheckBox.Checked == true && serviceCheckBox.Checked == false)
            {

                var query = from customer in advertiseKursovayaDataSet1.viewGetOrderForCustomers
                            where customer.dateAdFrom > dateFromPickerForCustomers & 
                            customer.userID == this.userID &
                            customer.dateAdTo < dateToPickerForCustomers
                            select customer;

                DataTable tblClone = advertiseKursovayaDataSet1.viewGetOrderForCustomers.Clone();
                foreach (DataRow datRow in query)
                {
                    tblClone.ImportRow(datRow);
                }
                DataView viewFilterForCustomers = new DataView(tblClone);

                viewGetOrderForCustomersDataGridView.DataSource = viewFilterForCustomers;
            }
            else if (item.Name != null && serviceCheckBox.Checked == true && dateCheckBox.Checked == false)
            {
                var query = from customer in advertiseKursovayaDataSet1.viewGetOrderForCustomers
                            where customer.service == item.Name &
                            customer.userID == this.userID
                            select customer;

                DataTable tblClone = advertiseKursovayaDataSet1.viewGetOrderForCustomers.Clone();
                foreach (DataRow datRow in query)
                {
                    tblClone.ImportRow(datRow);
                }
                DataView viewFilterForCustomers = new DataView(tblClone);

                viewGetOrderForCustomersDataGridView.DataSource = viewFilterForCustomers;
            }
            else if (item.Name != null && serviceCheckBox.Checked == true && dateCheckBox.Checked == true)
            {
                var query = from customer in advertiseKursovayaDataSet1.viewGetOrderForCustomers
                            where customer.service == item.Name & customer.userID == this.userID &
                            customer.dateAdFrom > dateFromPickerForCustomers &
                            customer.dateAdTo < dateToPickerForCustomers
                            select customer;

                DataTable tblClone = advertiseKursovayaDataSet1.viewGetOrderForCustomers.Clone();
                foreach (DataRow datRow in query)
                {
                    tblClone.ImportRow(datRow);
                }
                DataView viewFilterForCustomers = new DataView(tblClone);

                viewGetOrderForCustomersDataGridView.DataSource = viewFilterForCustomers;
            }
        }

        private void reportOrderForCustomers_Click(object sender, EventArgs e)
        {
            orderReportForm form = new orderReportForm(this, userID);
            form.Show();
        }

        private void GetOrderForManagersButton_Click(object sender, EventArgs e)
        {
            managerReportForm form = new managerReportForm(this, userID);
            form.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           

        }

        public void GetOrderID()
        {


            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand($"select orderID from orders", con);
            SqlDataReader reader = cmd.ExecuteReader();

            List<int> idArray = new List<int>();
            if (reader.HasRows)
            {
                while (reader.Read()) // построчно считываем данные
                {

                    int id = (int)reader.GetValue(0);
                    idArray.Add(id);

                }

            }

            reader.Close();
            con.Close();
            orderIDEditOrder.DataSource = idArray;
        }

        private void orderIDEditOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int item = (int)orderIDEditOrder.SelectedValue;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand($"select * from orders where orderID = '{item}'", con);
            SqlDataReader reader = cmd.ExecuteReader();

            
            if (reader.HasRows)
            {
                while (reader.Read()) // построчно считываем данные
                {

                    int serviceID = (int)reader.GetValue(1);
                    DateTime dateAdFrom = (DateTime)reader.GetValue(2);
                    DateTime dateAdTo = (DateTime)reader.GetValue(3);
                    int month = dateAdTo.Month - dateAdFrom.Month;
                    int userID = (int)reader.GetValue(4);
                    int managerID = (int)reader.GetValue(5);
                    int placeID = (int)reader.GetValue(6);

                    var selectedService = serviceEditOrder.Items.Cast<ComboBoxItem>().First<ComboBoxItem>(service=>service.Id == serviceID);
                    serviceEditOrder.SelectedItem = selectedService;

                    var selectedManager = managerEditOrder.Items.Cast<ComboBoxItem>().First<ComboBoxItem>(manager => manager.Id == managerID);
                    managerEditOrder.SelectedItem = selectedManager;

                    var selectedPlace = rentPlaceEditOrder.Items.Cast<ComboBoxItem>().First<ComboBoxItem>(place => place.Id == placeID);
                    rentPlaceEditOrder.SelectedItem = selectedPlace;

                    numericUpDownEditOrder.Value = month;

                    
                }

                LabelCustomerChanged();
            }
        }

        private void serviceEditOrder_Click(object sender, EventArgs e)
        {
            this.InitializeAdServices(serviceEditOrder);
        }

        private void orderIDEditOrder_Click(object sender, EventArgs e)
        {
            this.GetOrderID();
        }

        public void LabelCustomerChanged()
        {
            int item = (int)orderIDEditOrder.SelectedValue;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand($"select customersLastname, customersFirstname, customersMiddlename from viewGetOrderForManagers where orderID = '{item}'", con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read()) // построчно считываем данные
                {
                    string lastname = reader.GetString(0);
                    string firstname = reader.GetString(1);
                    string middlename = reader.GetString(2);

                    var name = $"{lastname} {firstname} {middlename}";
                    labelNameOfCustomer.Text = name;
                }
            }
            reader.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editService = new EditServiceForm();
            editService.Show();
        }

        private void updateOrderButton_Click(object sender, EventArgs e)
        {
            int newManagerID = (int)managerEditOrder.SelectedValue;
            int newServiceID = (int)serviceEditOrder.SelectedValue;
            int newPlaceID = (int)rentPlaceEditOrder.SelectedValue;
            int newNumOfMonth = (int)numericUpDownEditOrder.Value;
            int orderID = (int)orderIDEditOrder.SelectedValue;

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand($"update orders set " +
                $"serviceID = '{newServiceID}'," +
                $"managerID = '{newManagerID}'," +
                $"placeID = '{newPlaceID}'," +
                $"dateAdTo = DATEADD (mm, {newNumOfMonth}, dateAdFrom) where orderID = {orderID}", con);
            cmd.ExecuteNonQuery();
            con.Close();

            completeChangesLabel.Visible = true;
        }

        private void numericUpDownEditOrder_ValueChanged(object sender, EventArgs e)
        {
            month = (int)numericUpDownEditOrder.Value;
            var item = (ComboBoxItemForRent)rentPlaceEditOrder.SelectedItem;
            editedFullPrice.Text = (item.RentPrice * month).ToString();
        }

        private void editTypeOfAdButton_Click(object sender, EventArgs e)
        {
            EditTypeOfAdForm form = new EditTypeOfAdForm();
            form.Show();
        }

        private void rentPlaceEditOrder_Click(object sender, EventArgs e)
        {
            this.InitializePlaceOfAdForEditOrder(rentPlaceEditOrder);
        }

        private void editOrdersButton_Click(object sender, EventArgs e)
        {
            EditOrderGroupBox.Visible = true;

            addAPlaceOfAdGroupBox.Visible = false;

            addServiceGroupBox.Visible = false;
            makeAnOrderGroupBox.Visible = false;
            getOrderGroupBox.Visible = false;
        }

        private void execReportOfResultsButton_Click(object sender, EventArgs e)
        {
            ResultFormManager form = new ResultFormManager();
            form.Show();
            
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";
            int id = (int)orderIDEditOrder.SelectedItem;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand($"DELETE from orders where orderID='{id}'",con);

            cmd.ExecuteNonQuery();
            con.Close();
            deleteLabel.Text = "Заказ №: " + id.ToString() + " был аннулирован";
            orderIDEditOrder.SelectedItem = 1000;
            
        }

        private void serviceEditOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rentPlaceEditOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submitChangesButton_Click(object sender, EventArgs e)
        {
            string info = "";
            if (this.userType == "customer")
            {
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";
                
                SqlConnection con = new SqlConnection(connectionString);
                DataContext db = new DataContext(connectionString);
                customer user = db.GetTable<customer>().First(u => u.userID == this.userID);
                //запрос на обновдение               
                if(changeOnlyPasswordCheckBox.Checked == true)
                {
                    user.password = newPasswordTextBox.Text;
                    user.email = oldEmailTextBox.Text;
                    info = "Ваш новый пароль: " + newPasswordTextBox.Text;
                    changesInfoListBox.Items.Add(info);
                }
                else if(changeOnlyMailCheckBox.Checked == true)
                {
                    user.password = oldPasswordTextBox.Text;
                    user.email = newEmailTextBox.Text;
                    info = "Ваша новая почта: " + newEmailTextBox.Text;
                    changesInfoListBox.Items.Add(info);
                }
                else if (changeAllDataCheckBox.Checked == true)
                {
                    user.password = newPasswordTextBox.Text;
                    user.email = newEmailTextBox.Text;
                    info = "Ваша новая почта: " + newEmailTextBox.Text + "\t\nВаш новый пароль: " + newPasswordTextBox.Text;
                    changesInfoListBox.Items.Add(info);
                }
                

                //Сохранение данных в базе данных 
                db.SubmitChanges();
                

            }
            else
            {
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

                SqlConnection con = new SqlConnection(connectionString);
                DataContext db = new DataContext(connectionString);
                manager user = db.GetTable<manager>().First(u => u.managerID == this.userID);
                //запрос на обновдение               
                
                if (changeOnlyPasswordCheckBox.Checked == true)
                {
                    user.password = newPasswordTextBox.Text;
                    user.email = oldEmailTextBox.Text;
                    info = "Ваш новый пароль: " + newPasswordTextBox.Text;
                    changesInfoListBox.Items.Add(info);
                }
                else if (changeOnlyMailCheckBox.Checked == true)
                {
                    user.password = oldPasswordTextBox.Text;
                    user.email = newEmailTextBox.Text;
                    info = "Ваша новая почта: " + newEmailTextBox.Text;
                    changesInfoListBox.Items.Add(info);
                }
                else if (changeAllDataCheckBox.Checked == true)
                {
                    user.password = newPasswordTextBox.Text;
                    user.email = newEmailTextBox.Text;
                    info = "Ваша новая почта: " + newEmailTextBox.Text + "\t\nВаш новый пароль" + newPasswordTextBox.Text;
                    changesInfoListBox.Items.Add(info);
                }

                //Сохранение данных в базе данных 
                db.SubmitChanges();
                
            }
        }
        private void OldDataTextBoxes()
        {
            if(this.userType == "customer")
            {
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand($"select email, password from customer where userID = '{this.userID}'", con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        string email = reader.GetValue(0).ToString();
                        string password = reader.GetValue(1).ToString();
                        oldEmailTextBox.Text = email;
                        oldPasswordTextBox.Text = password;
                    }
                }
                reader.Close();
                con.Close();
            }
            else
            {
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand($"select email, password from manager where managerID = '{this.userID}'", con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        string email = reader.GetValue(0).ToString();
                        string password = reader.GetValue(1).ToString();
                        oldEmailTextBox.Text = email;
                        oldPasswordTextBox.Text = password;
                    }
                }
                reader.Close();
                con.Close();
            }
        }

        private void changeOnlyPasswordCheckBox_Click(object sender, EventArgs e)
        {
            changeOnlyMailCheckBox.Checked = false;
            changeOnlyPasswordCheckBox.Checked = true;
            changeAllDataCheckBox.Checked = false;
            newEmailTextBox.ReadOnly = true;
            newPasswordTextBox.ReadOnly = false;
        }

        private void changeOnlyMailCheckBox_Click(object sender, EventArgs e)
        {
            changeOnlyMailCheckBox.Checked = true;
            changeOnlyPasswordCheckBox.Checked = false;
            changeAllDataCheckBox.Checked = false;
            newEmailTextBox.ReadOnly = false;
            newPasswordTextBox.ReadOnly = true;
        }

        private void changeAllDataCheckBox_Click(object sender, EventArgs e)
        {
            changeOnlyMailCheckBox.Checked = false;
            changeOnlyPasswordCheckBox.Checked = false;
            changeAllDataCheckBox.Checked = true;
            newEmailTextBox.ReadOnly = false;
            newPasswordTextBox.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OldDataTextBoxes();
            ChangeDataGroupBox.Visible = true;

            makeAnOrderGroupBox.Visible = false;
            getOrderGroupBox.Visible = false;
            addServiceGroupBox.Visible = false;
            addAPlaceOfAdGroupBox.Visible = false;
            EditOrderGroupBox.Visible = false;
        }

        private void agencyReportButton_Click(object sender, EventArgs e)
        {
            string filterService = filterBoxByService.GetItemText(filterBoxByService.SelectedItem);
            
            string filterManager = managerFilterComboBox.GetItemText(managerFilterComboBox.SelectedItem);
            DateTime dateAdFrom = dateTimePickerFrom.Value;
            DateTime dateAdTo = dateTimePickerTo.Value;

            bool managerCheckB = filterManagerCheckBox.Checked;
            bool serviceCheckB = serviceCheckBox.Checked;
            bool dateCheck = dateCheckBox.Checked;

            AdvertiseAgencyResult advertiseAgencyResultForm = new AdvertiseAgencyResult(filterService,filterManager,managerCheckB,serviceCheckB,dateCheck,dateAdFrom,dateAdTo);
            advertiseAgencyResultForm.Show();

        }

        private void managerFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class ComboBoxItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class ComboBoxItemForRent : ComboBoxItem
    {
        public int RentPrice { get; set; }
    }

    

}
