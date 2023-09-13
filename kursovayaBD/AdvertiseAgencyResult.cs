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
    public partial class AdvertiseAgencyResult : Form
    {
        string filterService;
        string filterManager;
        bool managerCheck;
        bool serviceCheck;
        bool dateCheck;
        DateTime filterDateFrom;
        DateTime filterDateTo;

        public AdvertiseAgencyResult(string sString, string mString, bool mCheck, bool sCheck, bool dCheck, DateTime dFrom, DateTime dTo)
        {
            InitializeComponent();
            this.filterService = sString;
            this.filterManager = mString;
            this.filterDateFrom = dFrom;
            this.filterDateTo = dTo;
            this.dateCheck = dCheck;
            this.managerCheck = mCheck;
            this.serviceCheck = sCheck;
            GetReport();

        }

        private void AdvertiseAgencyResult_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertiseKursovayaDataSet.agencyResult". При необходимости она может быть перемещена или удалена.
            this.agencyResultTableAdapter.Fill(this.advertiseKursovayaDataSet.agencyResult);

            
            this.reportViewer1.RefreshReport();
            
        }

        public void GetReport()
        {
            if (dateCheck == false && serviceCheck == false && managerCheck == false)
            {
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand($"select * from agencyResult", con);
                cmd.ExecuteNonQuery();             


                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("agencyResult", agencyResultBindingSource));
                SqlCommand cmd2 = new SqlCommand($"select sum(earnedMoneyPerOrder) from agencyResult", con);

                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string getAmountOfMoney = reader.GetInt32(0).ToString();
                        ReportParameter earnedMoney = new ReportParameter("allEarnedMoney", getAmountOfMoney);
                        string firstCmd = "alltime";
                        string secondCmd = "alltime";
                        ReportParameter dateFrom = new ReportParameter("dateFromPrevForm", firstCmd);
                        ReportParameter dateTo = new ReportParameter("dateToPrevFrom", secondCmd);
                        reportViewer1.LocalReport.SetParameters(new ReportParameter[] { dateFrom, dateTo, earnedMoney });
                    }
                }
                else
                {
                    MessageBox.Show("На выбранное вами время не заказов");
                    return;
                }
                reader.Close();
                con.Close();
                
            }
            else if(dateCheck == true && serviceCheck == false && managerCheck == false)
            {
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                

                DataView viewFilteredAgency = new DataView(advertiseKursovayaDataSet.agencyResult);
                viewFilteredAgency.RowFilter = $"dateAdFrom > '{filterDateFrom}' and dateAdFrom < '{filterDateTo}'";
                agencyResultBindingSource.DataSource = viewFilteredAgency;


                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("agencyResult", viewFilteredAgency));

                //SqlCommand cmd2 = new SqlCommand($"select sum(earnedMoneyPerOrder) from agencyResult where dateAdFrom between '{filterDateFrom.ToString("MM,dd,yyyy")}' and '{filterDateTo.ToString("MM,dd,yyyy")}'", con);
                SqlCommand cmd2 = new SqlCommand($"select sum(earnedMoneyPerOrder) from agencyResult where dateAdFrom > '{filterDateFrom.ToString("MM/dd/yyyy")}' and dateAdFrom < '{filterDateTo.ToString("MM/dd/yyyy")}'", con);
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string getAmountOfMoney = reader.GetInt32(0).ToString();
                        ReportParameter earnedMoney = new ReportParameter("allEarnedMoney", getAmountOfMoney);
                        ReportParameter dateFrom = new ReportParameter("dateFromPrevForm", filterDateFrom.ToString());
                        ReportParameter dateTo = new ReportParameter("dateToPrevFrom", filterDateTo.ToString());
                        reportViewer1.LocalReport.SetParameters(new ReportParameter[] { dateFrom, dateTo, earnedMoney });
                    }
                }
                else
                {
                    MessageBox.Show("На выбранное вами время не заказов");
                    return;
                }
                reader.Close();
                con.Close();
                
            }
            else if (dateCheck == false && serviceCheck == true && managerCheck == false)
            {
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();


                DataView viewFilteredAgency = new DataView(advertiseKursovayaDataSet.agencyResult);
                viewFilteredAgency.RowFilter = $"service = '{filterService}'";
                agencyResultBindingSource.DataSource = viewFilteredAgency;


                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("agencyResult", viewFilteredAgency));

                SqlCommand cmd2 = new SqlCommand($"select sum(earnedMoneyPerOrder) from agencyResult where service = '{filterService}'", con);
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string getAmountOfMoney = reader.GetInt32(0).ToString();
                        ReportParameter earnedMoney = new ReportParameter("allEarnedMoney", getAmountOfMoney);
                        ReportParameter dateFrom = new ReportParameter("dateFromPrevForm", "All Time");
                        ReportParameter dateTo = new ReportParameter("dateToPrevFrom", "All time");
                        reportViewer1.LocalReport.SetParameters(new ReportParameter[] { dateFrom, dateTo, earnedMoney });
                    }
                }
                reader.Close();
                con.Close();
            }
            else if (dateCheck == false && serviceCheck == false && managerCheck == true)
            {
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();


                DataView viewFilteredAgency = new DataView(advertiseKursovayaDataSet.agencyResult);
                viewFilteredAgency.RowFilter = $"managerFullname = '{filterManager}'";
                agencyResultBindingSource.DataSource = viewFilteredAgency;


                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("agencyResult", viewFilteredAgency));

                SqlCommand cmd2 = new SqlCommand($"select sum(earnedMoneyPerOrder) from agencyResult where managerFullname = '{filterManager}'", con);
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string getAmountOfMoney = reader.GetInt32(0).ToString();
                        ReportParameter earnedMoney = new ReportParameter("allEarnedMoney", getAmountOfMoney);
                        ReportParameter dateFrom = new ReportParameter("dateFromPrevForm", "All Time");
                        ReportParameter dateTo = new ReportParameter("dateToPrevFrom", "All time");
                        reportViewer1.LocalReport.SetParameters(new ReportParameter[] { dateFrom, dateTo, earnedMoney });
                    }
                }
                reader.Close();
                con.Close();
            }
            else if (dateCheck == true && serviceCheck == true && managerCheck == false)
            {
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();


                DataView viewFilteredAgency = new DataView(advertiseKursovayaDataSet.agencyResult);
                viewFilteredAgency.RowFilter = $"service = '{filterService}' and dateAdFrom > '{filterDateFrom}' and dateAdFrom < '{filterDateTo}'";
                agencyResultBindingSource.DataSource = viewFilteredAgency;


                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("agencyResult", viewFilteredAgency));

                SqlCommand cmd2 = new SqlCommand($"select sum(earnedMoneyPerOrder) from agencyResult where service = '{filterService}' " +
                    $"and dateAdFrom > '{filterDateFrom.ToString("MM/dd/yyyy")}' and dateAdFrom < '{filterDateTo.ToString("MM/dd/yyyy")}'", con);
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string getAmountOfMoney = reader.GetInt32(0).ToString();
                        ReportParameter earnedMoney = new ReportParameter("allEarnedMoney", getAmountOfMoney);
                        ReportParameter dateFrom = new ReportParameter("dateFromPrevForm", filterDateFrom.ToString());
                        ReportParameter dateTo = new ReportParameter("dateToPrevFrom", filterDateTo.ToString());
                        reportViewer1.LocalReport.SetParameters(new ReportParameter[] { dateFrom, dateTo, earnedMoney });
                    }
                }
                else
                {
                    MessageBox.Show("На выбранное вами время не заказов");
                    return;
                }
                reader.Close();
                con.Close();
            }
            else if (dateCheck == false && serviceCheck == true && managerCheck == true)
            {
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();


                DataView viewFilteredAgency = new DataView(advertiseKursovayaDataSet.agencyResult);
                viewFilteredAgency.RowFilter = $"managerFullname = '{filterManager}' and service = '{filterService}'";
                agencyResultBindingSource.DataSource = viewFilteredAgency;


                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("agencyResult", viewFilteredAgency));

                SqlCommand cmd2 = new SqlCommand($"select sum(earnedMoneyPerOrder) from agencyResult where service = '{filterService}' and " +
                    $"managerFullname = '{filterManager}'", con);
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string getAmountOfMoney = reader.GetInt32(0).ToString();
                        ReportParameter earnedMoney = new ReportParameter("allEarnedMoney", getAmountOfMoney);
                        ReportParameter dateFrom = new ReportParameter("dateFromPrevForm", "All Time");
                        ReportParameter dateTo = new ReportParameter("dateToPrevFrom", "All time");
                        reportViewer1.LocalReport.SetParameters(new ReportParameter[] { dateFrom, dateTo, earnedMoney });
                    }
                }
                reader.Close();
                con.Close();
            }
            else if (dateCheck == true && serviceCheck == false && managerCheck == true)
            {
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();


                DataView viewFilteredAgency = new DataView(advertiseKursovayaDataSet.agencyResult);
                viewFilteredAgency.RowFilter = $"managerFullname = '{filterManager}' and dateAdFrom > '{filterDateFrom}' and dateAdFrom < '{filterDateTo}'";
                agencyResultBindingSource.DataSource = viewFilteredAgency;


                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("agencyResult", viewFilteredAgency));

                SqlCommand cmd2 = new SqlCommand($"select sum(earnedMoneyPerOrder) from agencyResult where service = '{filterManager}' " +
                    $"and dateAdFrom > '{filterDateFrom.ToString("MM/dd/yyyy")}' and dateAdFrom < '{filterDateTo.ToString("MM/dd/yyyy")}'", con);
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string getAmountOfMoney = reader.GetInt32(0).ToString();
                        ReportParameter earnedMoney = new ReportParameter("allEarnedMoney", getAmountOfMoney);
                        ReportParameter dateFrom = new ReportParameter("dateFromPrevForm", filterDateFrom.ToString());
                        ReportParameter dateTo = new ReportParameter("dateToPrevFrom", filterDateTo.ToString());
                        reportViewer1.LocalReport.SetParameters(new ReportParameter[] { dateFrom, dateTo, earnedMoney });
                    }
                }
                else
                {
                    MessageBox.Show("На выбранное вами время не заказов");
                    return;
                }
                reader.Close();
                con.Close();
            }
            else if (dateCheck == true && serviceCheck == true && managerCheck == true)
            {
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=advertiseKursovaya;Integrated Security=True";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();


                DataView viewFilteredAgency = new DataView(advertiseKursovayaDataSet.agencyResult);
                viewFilteredAgency.RowFilter = $"managerFullname = '{filterManager}'and service = '{filterService}' and dateAdFrom > '{filterDateFrom}' and dateAdFrom < '{filterDateTo}' ";
                agencyResultBindingSource.DataSource = viewFilteredAgency;


                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("agencyResult", viewFilteredAgency));

                SqlCommand cmd2 = new SqlCommand($"select sum(earnedMoneyPerOrder) from agencyResult where service = '{filterService}' " +
                    $"and dateAdFrom > '{filterDateFrom.ToString("MM/dd/yyyy")}' and dateAdFrom < '{filterDateTo.ToString("MM/dd/yyyy")}' and managerFullname = '{filterManager}'", con);
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                        string getAmountOfMoney = reader.GetInt32(0).ToString();
                        ReportParameter earnedMoney = new ReportParameter("allEarnedMoney", getAmountOfMoney);
                        ReportParameter dateFrom = new ReportParameter("dateFromPrevForm", filterDateFrom.ToString());
                        ReportParameter dateTo = new ReportParameter("dateToPrevFrom", filterDateTo.ToString());
                        reportViewer1.LocalReport.SetParameters(new ReportParameter[] { dateFrom, dateTo, earnedMoney });
                    }
                }
                else
                {
                    MessageBox.Show("На выбранное вами время не заказов");
                    return;
                }
                reader.Close();
                con.Close();
            }
        }        
    }
}
