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
    public partial class CustomerCityForm : Form
    {
        ReportDocument rd;
        SqlConnection con;
        public CustomerCityForm()
        {
            InitializeComponent();
            rd = new ReportDocument();
            con = new SqlConnection(@"Data Source=Ganesh-Hp;Initial Catalog=GoldenTechData;Integrated Security=True");
        }

        private void CustomerCityForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goldenTechDataDataSet20.CustomerAddress' table. You can move, or remove it, as needed.
            this.customerAddressTableAdapter.Fill(this.goldenTechDataDataSet20.CustomerAddress);

            string query = "select * from CustomerAllDetailsView";
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "CustomerAllDetailsView");
            rd.Load(@"C:\Users\GANESH\documents\visual studio 2010\Projects\GoldenTechSolution\GoldenTechSolution\CustomerCity.rpt");
            rd.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rd;
            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from CustomerAllDetailsView where city='" + comboBox1.SelectedValue.ToString() + "'";
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "CustomerAllDetailsView");
            rd.Load(@"C:\Users\GANESH\documents\visual studio 2010\Projects\GoldenTechSolution\GoldenTechSolution\CustomerCity.rpt");
            rd.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rd;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from CustomerAllDetailsView";
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "CustomerAllDetailsView");
            rd.Load(@"C:\Users\GANESH\documents\visual studio 2010\Projects\GoldenTechSolution\GoldenTechSolution\CustomerCity.rpt");
            rd.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rd;
            con.Close();
        }
    }
}
