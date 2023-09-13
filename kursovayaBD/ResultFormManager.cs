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
    public partial class ResultFormManager : Form
    {
        List<ResultOrder> reports;
        public ResultFormManager()
        {
            InitializeComponent();
        }

        private void ResultFormManager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertiseKursovayaDataSet.resultOfWork". При необходимости она может быть перемещена или удалена.
            this.resultOfWorkTableAdapter.Fill(this.advertiseKursovayaDataSet.resultOfWork);

            this.resultOfWorkTableAdapter.Fill(advertiseKursovayaDataSet.resultOfWork);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("result", resultOfWorkBindingSource));
            reportViewer1.RefreshReport();
            

        }
        //public List<ResultOrder> GetDataFromDB()
        //{
        //    string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

        //    SqlConnection con = new SqlConnection(connectionString);
        //    con.Open();

        //    SqlCommand command = new SqlCommand($"select * from resultOfWork", con);
        //    SqlDataReader reader = command.ExecuteReader();


        //    if (reader.HasRows)
        //    {
        //        List<ResultOrder> reports = new List<ResultOrder>();
        //        while (reader.Read()) // построчно считываем данные
        //        {
        //            ResultOrder resultOrder = new ResultOrder();

        //            string name = reader.GetValue(0).ToString();
        //            int numberOfOrders = reader.GetInt32(1);
        //            int numberOfUniqueCustomers = reader.GetInt32(2);
        //            int amountOfEarnedMoney = reader.GetInt32(3);

        //            resultOrder.amountOfMoney = amountOfEarnedMoney;
        //            resultOrder.numOfOrders = numberOfOrders;
        //            resultOrder.numOfCustomers = numberOfUniqueCustomers;
        //            resultOrder.name = name;

        //            reports.Add(resultOrder);
        //        }
        //        return reports;
        //    }
        //    reader.Close();
        //    con.Close();
        //    return reports;
        //}

        private void FilterButton_Click(object sender, EventArgs e)
        {
            //List<ResultOrder> resultOrder = reports;
            
            //if (numberOfOrdersCheckBox.Checked == true & numberOfUniqueCustomersCheckBox.Checked == false & amountOfEarnedMoneyCheckBox.Checked == false)
            //{
            //    resultOrder = resultOrder.OrderBy(report => report.numOfOrders).ToList();
                
            //}
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

    }
    public class ResultOrder 
    {
        public string name { get; set; }
        public int numOfOrders { get; set; }
        public int numOfCustomers { get; set; }
        public int amountOfMoney { get; set; }
    }

}
