using Microsoft.Reporting.WinForms;
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
    public partial class orderReportForm : Form
    {
        MainForm mainForm;
        public int userID;
        List<OrderReport> reports;
        public orderReportForm(MainForm form, int userID)
        {
            InitializeComponent();
            mainForm = form;
            this.userID = userID;
            
        }

        private void orderReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertiseKursovayaDataSet.orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.advertiseKursovayaDataSet.orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertiseKursovayaDataSet.viewGetOrderForCustomers". При необходимости она может быть перемещена или удалена.
            this.viewGetOrderForCustomersTableAdapter.Fill(this.advertiseKursovayaDataSet.viewGetOrderForCustomers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertiseKursovayaDataSet.viewGetOrderForManagers". При необходимости она может быть перемещена или удалена.

            
            
            this.reports = GetOrders();
            orderBox.Items.AddRange(reports.Select((OrderReport report) => report.orderID).ToArray());

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        public List<OrderReport> GetOrders()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand getOrderIDCommand = new SqlCommand($"select * from orders where userID='{this.userID}'", con);
            SqlDataReader readerOrderID = getOrderIDCommand.ExecuteReader();


            if (readerOrderID.HasRows)
            {
                List <OrderReport> reports = new List <OrderReport>();
                while (readerOrderID.Read()) // построчно считываем данные
                {
                    OrderReport orderReport = new OrderReport();
                    int id = (int)readerOrderID.GetValue(0);
                    int serviceID = (int)readerOrderID.GetValue(1);
                    DateTime dateAdFrom = (DateTime)readerOrderID.GetValue(2);
                    DateTime dateAdTo= (DateTime)readerOrderID.GetValue(3);
                    int managerID = (int)readerOrderID.GetValue(5);
                    int placeID = (int)readerOrderID.GetValue(6);


                    ManagerDTO managerInfo = GetManager(managerID);
                    PlaceForAdDTO placeInfo = GetPlaceById(placeID);
                    string serviceInfo = GetServiceById(serviceID);

                    orderReport.orderID = id.ToString();
                    orderReport.service = serviceInfo.ToString();
                    orderReport.typeOfAd = placeInfo.typeOfAd.ToString();
                    orderReport.managerFullname =managerInfo.name;
                    orderReport.managerEmail = managerInfo.email;

                    orderReport.reportDateAdFrom = dateAdFrom.ToString();
                    orderReport.reportDateAdTo = dateAdTo.ToString();
                    int price = Int32.Parse(placeInfo.rentPrice);
                    
                    orderReport.fullPrice =((dateAdTo.Month-dateAdFrom.Month)*price).ToString();

                    reports.Add(orderReport);

                    //reportViewer1.LocalReport.SetParameters(new ReportParameter[] { GetOrderID(), service, typeOfAd, managerFullName, GetManagerEmail(), dateAdFrom, dateAdTo, rentPrice });
                }
                return reports;
            }
            readerOrderID.Close();
            con.Close();

            return null;
        }

        public ManagerDTO GetManager(int managerID)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand getOrderIDCommand = new SqlCommand($"select lastname, firstname, middlename, email, phoneNumber from manager where managerID='{managerID}'", con);
            SqlDataReader reader = getOrderIDCommand.ExecuteReader();

            if (reader.HasRows)
            {
                ManagerDTO manager = new ManagerDTO();
                while (reader.Read()) // построчно считываем данные
                {
                    string lastname = reader.GetString(0);
                    string firstname = reader.GetString(1);
                    string middlename = reader.GetString(2);

                    manager.email = reader.GetString(3);
                    manager.phoneNumber = reader.GetInt32(4).ToString();
                    

                    manager.name = lastname + " " + firstname + " " + middlename;
                    
                    return manager;
                }
                return null;
            }
            reader.Close();
            con.Close();
            return null;
        }

        public string GetServiceById(int serviceID)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand getOrderIDCommand = new SqlCommand($"select service from adServices where serviceID='{serviceID}'", con);
            SqlDataReader reader = getOrderIDCommand.ExecuteReader();

            if (reader.HasRows)
            {
                
                while (reader.Read()) // построчно считываем данные
                {
                    string service = reader.GetString(0);
                    
                    
                    return service;
                }
                return "";
            }
            reader.Close();
            con.Close();
            return "";
        }

        public PlaceForAdDTO GetPlaceById(int placeID)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand getOrderIDCommand = new SqlCommand($"select typeOfAd, rentPrice from placeOfAdvertisement where placeID='{placeID}'", con);
            SqlDataReader reader = getOrderIDCommand.ExecuteReader();

            if (reader.HasRows)
            {
                PlaceForAdDTO place = new PlaceForAdDTO();
                while (reader.Read()) // построчно считываем данные
                {
                    place.typeOfAd = reader.GetString(0);
                    place.rentPrice = reader.GetInt32(1).ToString();


                    return place;
                }
                return null;
            }
            reader.Close();
            con.Close();
            return null;
        }

        private void orderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderReport order = reports.First(report => report.orderID == orderBox.SelectedItem.ToString());

            ReportParameter orderID = new ReportParameter("orderID", order.orderID);
            


            ReportParameter dateAdFrom = new ReportParameter("dateAdFrom", order.reportDateAdFrom);

            ReportParameter dateAdTo = new ReportParameter("dateAdTo", order.reportDateAdTo);

            ReportParameter managerFullName = new ReportParameter("managerFullName", order.managerFullname);
            ReportParameter managerEmail = new ReportParameter("managerEmail", order.managerEmail);

            ReportParameter service = new ReportParameter("service", order.service);

            ReportParameter typeOfAd = new ReportParameter("typeOfAd", order.typeOfAd);

            ReportParameter rentPrice = new ReportParameter("rentPrice", order.fullPrice);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { orderID, service, typeOfAd, managerFullName, managerEmail, dateAdFrom, dateAdTo, rentPrice });

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("reportOrderForCustomer", viewGetOrderForCustomersBindingSource));

            reportViewer1.RefreshReport();
        }
    }
    public class ManagerDTO
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
    }

    public class PlaceForAdDTO
    {
        public string typeOfAd { get; set; }
        public string rentPrice { get; set; }
    }

    public class OrderReport
    {
        public string orderID;
        public string service;
        public string typeOfAd;
        public string managerFullname;
        public string managerEmail;
        public string reportDateAdFrom;
        public string reportDateAdTo;
        public string fullPrice;
    }
}
