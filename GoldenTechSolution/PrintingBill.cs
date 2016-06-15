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
    public partial class PrintingBill : Form
    {
        public int id;
        public PrintingBill()
        {
            InitializeComponent();
        }
        public PrintingBill(String s)
        {
            InitializeComponent();
            id = Convert.ToInt32(s);
        }
        private void PrintingBill_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            SqlConnection con = new SqlConnection(@"Data Source=Ganesh-Hp;Initial Catalog=GoldenTechData;Integrated Security=True");
            string query = "select * from BillView WHERE id=" + id;
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "BillView");
            rd.Load(@"C:\Users\GANESH\documents\visual studio 2010\Projects\GoldenTechSolution\GoldenTechSolution\BillReport.rpt");
            rd.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rd;
            con.Close();
        }
    }
}
