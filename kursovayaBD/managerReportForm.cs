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
    public partial class managerReportForm : Form
    {
        MainForm mainForm;
        public int managerID;
        List<ManagerReportOrder> reports;
        public managerReportForm(MainForm form, int managerID)
        {
            InitializeComponent();
            mainForm = form;
            this.managerID = managerID;
        }

        private void managerReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertiseKursovayaDataSet.viewGetOrderForManagers". При необходимости она может быть перемещена или удалена.
            this.viewGetOrderForManagersTableAdapter1.Fill(this.advertiseKursovayaDataSet.viewGetOrderForManagers);
            this.reports = GetOrders();
            managerOrderBox.Items.AddRange(reports.Select((ManagerReportOrder report) => report.orderID).ToArray());
        }

        public List<ManagerReportOrder> GetOrders()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand getOrderIDCommand = new SqlCommand($"select * from orders where managerID='{this.managerID}'", con);
            SqlDataReader readerOrderID = getOrderIDCommand.ExecuteReader();


            if (readerOrderID.HasRows)
            {
                List<ManagerReportOrder> reports = new List<ManagerReportOrder>();
                while (readerOrderID.Read()) // построчно считываем данные
                {
                    ManagerReportOrder orderReport = new ManagerReportOrder();
                    int id = (int)readerOrderID.GetValue(0);
                    int serviceID = (int)readerOrderID.GetValue(1);
                    DateTime dateAdFrom = (DateTime)readerOrderID.GetValue(2);
                    DateTime dateAdTo = (DateTime)readerOrderID.GetValue(3);
                    int managerID = (int)readerOrderID.GetValue(4);
                    int placeID = (int)readerOrderID.GetValue(6);


                    ManagerDTO customerInfo = GetCustomer(managerID);
                    PlaceForAdDTO placeInfo = GetPlaceById(placeID);
                    ServiceDTO serviceInfo = GetServiceById(serviceID);

                    orderReport.orderID = id.ToString();
                    orderReport.service = serviceInfo.ToString();
                    orderReport.typeOfAd = placeInfo.typeOfAd.ToString();
                    orderReport.customerName = customerInfo.name;
                    orderReport.customerEmail = customerInfo.email;
                    

                    orderReport.reportDateAdFrom = dateAdFrom.ToString();
                    orderReport.reportDateAdTo = dateAdTo.ToString();

                    orderReport.serviceDescription = serviceInfo.serviceDescription.ToString();
                    

                    reports.Add(orderReport);

                    //reportViewer1.LocalReport.SetParameters(new ReportParameter[] { GetOrderID(), service, typeOfAd, managerFullName, GetManagerEmail(), dateAdFrom, dateAdTo, rentPrice });
                }
                return reports;
            }
            readerOrderID.Close();
            con.Close();

            return null;
        }

        public ManagerDTO GetCustomer(int userID)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand getOrderIDCommand = new SqlCommand($"select lastname, firstname, middlename, email from customer where userID='{userID}'", con);
            SqlDataReader reader = getOrderIDCommand.ExecuteReader();

            if (reader.HasRows)
            {
                ManagerDTO customer = new ManagerDTO();
                while (reader.Read()) // построчно считываем данные
                {
                    string lastname = reader.GetString(0);
                    string firstname = reader.GetString(1);
                    string middlename = reader.GetString(2);

                    customer.email = reader.GetString(3);
                    

                    customer.name = lastname + " " + firstname + " " + middlename;

                    return customer;
                }
                return null;
            }
            reader.Close();
            con.Close();
            return null;
        }

        public ServiceDTO GetServiceById(int serviceID)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand getOrderIDCommand = new SqlCommand($"select service, serviceDescription from adServices where serviceID='{serviceID}'", con);
            SqlDataReader reader = getOrderIDCommand.ExecuteReader();

            if (reader.HasRows)
            {
                ServiceDTO serviceDTO = new ServiceDTO();
                while (reader.Read()) // построчно считываем данные
                {
                    serviceDTO.service = reader.GetString(0).ToString(); ;
                    serviceDTO.serviceDescription = reader.GetString(1).ToString();


                    return serviceDTO;
                }
                return null;
            }
            reader.Close();
            con.Close();
            return null;
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

        private void managerOrderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagerReportOrder order = reports.First(report => report.orderID == managerOrderBox.SelectedItem.ToString());

            ReportParameter orderID = new ReportParameter("orderID", order.orderID);



            ReportParameter dateAdFrom = new ReportParameter("dateAdFrom", order.reportDateAdFrom);

            ReportParameter dateAdTo = new ReportParameter("dateAdTo", order.reportDateAdTo);

            ReportParameter customerName = new ReportParameter("customerName", order.customerName);
            ReportParameter customerEmail = new ReportParameter("customerEmail", order.customerEmail);

            ReportParameter service = new ReportParameter("service", order.service);

            ReportParameter typeOfAd = new ReportParameter("typeOfAd", order.typeOfAd);

            ReportParameter serviceDescription = new ReportParameter("serviceDescription", order.serviceDescription);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { orderID, service, typeOfAd, customerName, customerEmail, dateAdFrom, dateAdTo, serviceDescription });

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("managerReport", viewGetOrderForManagersBindingSource));

            reportViewer1.RefreshReport();
        }
    }
    public class ManagerReportOrder
    {
        public string orderID;
        public string service;
        public string typeOfAd;
        public string customerName;
        public string customerEmail;
        public string reportDateAdFrom;
        public string reportDateAdTo;
        public string serviceDescription;
    }
    public class ServiceDTO
    {
        public string service { get; set; }
        public string serviceDescription { get; set; }
    }
}

