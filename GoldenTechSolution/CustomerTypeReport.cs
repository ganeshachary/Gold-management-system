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
    public partial class CustomerTypeReport : Form
    {
        ReportDocument rd;
        SqlConnection con;
        public CustomerTypeReport()
        {
            InitializeComponent();
            rd = new ReportDocument();
            con = new SqlConnection(@"Data Source=Ganesh-Hp;Initial Catalog=GoldenTechData;Integrated Security=True");
        }

        private void CustomerTypeReport_Load(object sender, EventArgs e)
        {
            
            string query = "select * from CustomerAllDetailsView";
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "CustomerAllDetailsView");
            rd.Load(@"C:\Users\GANESH\documents\visual studio 2010\Projects\GoldenTechSolution\GoldenTechSolution\CustomerType.rpt");
            rd.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rd;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                string query = "select * from CustomerAllDetailsView where cust_repair = 'Repair'";
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adapt.Fill(ds, "CustomerAllDetailsView");
                rd.Load(@"C:\Users\GANESH\documents\visual studio 2010\Projects\GoldenTechSolution\GoldenTechSolution\CustomerType.rpt");
                rd.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rd;
                con.Close();

            }
            if(comboBox1.SelectedIndex==1)
            {

                string query = "select * from CustomerAllDetailsView where cust_order='Order'";
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adapt.Fill(ds, "CustomerAllDetailsView");
                rd.Load(@"C:\Users\GANESH\documents\visual studio 2010\Projects\GoldenTechSolution\GoldenTechSolution\CustomerType.rpt");
                rd.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rd;
                con.Close();
            }
            if(comboBox1.SelectedIndex==2)
            {

                string query = "select * from CustomerAllDetailsView where cust_loan='Loan'";
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adapt.Fill(ds, "CustomerAllDetailsView");
                rd.Load(@"C:\Users\GANESH\documents\visual studio 2010\Projects\GoldenTechSolution\GoldenTechSolution\CustomerType.rpt");
                rd.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rd;
                con.Close();
            
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            string query = "select * from CustomerAllDetailsView";
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "CustomerAllDetailsView");
            rd.Load(@"C:\Users\GANESH\documents\visual studio 2010\Projects\GoldenTechSolution\GoldenTechSolution\CustomerType.rpt");
            rd.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rd;
            con.Close();
        }
    }
}
