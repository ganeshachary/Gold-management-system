using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace GoldenTechSolution
{
    public partial class BIllBalanceReport : Form
    {
        ReportDocument rd;
        SqlConnection con;
        public BIllBalanceReport()
        {
            InitializeComponent();
            rd = new ReportDocument();
            con = new SqlConnection(@"Data Source=Ganesh-Hp;Initial Catalog=GoldenTechData;Integrated Security=True");
        }

        private void BIllBalanceReport_Load(object sender, EventArgs e)
        {
            string query = "select DISTINCT id, custid, cust_name, amount, downpayment, balance from BillBalanceView";
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "BillBalanceView");
            rd.Load(@"C:\Users\GANESH\documents\visual studio 2010\Projects\GoldenTechSolution\GoldenTechSolution\BillBalaceReport.rpt");
            rd.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rd;
            con.Close();
        }
    }
}
