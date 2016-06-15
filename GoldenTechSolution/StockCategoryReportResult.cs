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
            
    public partial class StockCategoryReportResult : Form
    {
        ReportDocument rd;
        SqlConnection con;
        public StockCategoryReportResult()
        {
            InitializeComponent();
             rd = new ReportDocument();
            con = new SqlConnection(@"Data Source=Ganesh-Hp;Initial Catalog=GoldenTechData;Integrated Security=True");
           
        }

        private void StockCategoryReportResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goldenTechDataDataSet21.StockDetails' table. You can move, or remove it, as needed.
            this.stockDetailsTableAdapter.Fill(this.goldenTechDataDataSet21.StockDetails);

            string query = "select * from StockView";
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "StockView");
            rd.Load(@"C:\Users\GANESH\documents\visual studio 2010\Projects\GoldenTechSolution\GoldenTechSolution\StockCategoryReport.rpt");
            rd.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rd;
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from StockView where item_category='"+comboBox1.SelectedValue.ToString()+"'";
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "StockView");
            rd.Load(@"C:\Users\GANESH\documents\visual studio 2010\Projects\GoldenTechSolution\GoldenTechSolution\StockCategoryReport.rpt");
            rd.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rd;
            con.Close();
        }
    }
}
