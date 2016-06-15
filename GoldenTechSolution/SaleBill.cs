using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GoldenTech
{
    public partial class SaleBill : Form
    {
        SqlConnection con;
        public SaleBill()
        {
            InitializeComponent();
            con=new SqlConnection(@"Data Source=ACER-27447C9AAC\SQLEXPRESS;Initial Catalog=GoldenTechData;Integrated Security=True");
        }

        public void LoadGridViewData()
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select * from StockDetails", con);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "StockDetails");
            dgvStock.DataSource = ds;
            dgvStock.DataMember = "StockDetails";

        }

        public void DisplayIdentity()
        {
            SqlCommand comm1 = new SqlCommand("select * from BillDetails", con);
            SqlCommand comm2 = new SqlCommand("select IDENT_CURRENT('BillDetails')", con);
            con.Open();
            int bill_no = System.Convert.ToInt32(comm2.ExecuteScalar());
            SqlDataReader reader = comm1.ExecuteReader();      
            if (reader.HasRows)
            {
                bill_no++;
            }
            txtBillNumber.Text = bill_no.ToString();
            con.Close();
        }

        private void SaleBill_Load(object sender, EventArgs e)
        {
            txtDate.Text = System.DateTime.Now.ToString("dd-MM-yyyy");
            LoadGridViewData();
            DisplayIdentity();
        }
    }
}
