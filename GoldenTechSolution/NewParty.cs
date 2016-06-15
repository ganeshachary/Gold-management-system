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
    public partial class NewParty : Form
    {
        SqlConnection con;
        StockDetails temp;
        public NewParty()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=Ganesh-Hp;Initial Catalog=GoldenTechData;Integrated Security=True");
        }

        public NewParty(StockDetails sd)
        {
            InitializeComponent();
            this.temp = sd;
            con = new SqlConnection(@"Data Source=Ganesh-Hp;Initial Catalog=GoldenTechData;Integrated Security=True");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtDescription.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEnterprise_Click(object sender, EventArgs e)
        {
            int ent_id = System.Convert.ToInt32(txtId.Text);
            String ent_name = txtName.Text;
            String description = txtDescription.Text;
            SqlCommand comm1 = new SqlCommand("INSERT INTO EnterpriseDetails(ent_name,ent_description) values('"+ent_name + "','" + description + "')", con);
            SqlCommand comm2 = new SqlCommand("INSERT INTO EnterpriseAddress(ent_id) values(" + ent_id + ")", con);
            con.Open();
            comm1.ExecuteNonQuery();
            comm2.ExecuteNonQuery();
            con.Close();
            // immediately update the enterprise names
            temp.LoadEnterpriseNames();
            MessageBox.Show("Successfully added to Enterprise", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void NewParty_Load(object sender, EventArgs e)
        {
            this.Load_Identity();
        }

        public void Load_Identity()
        {
            con.Open();
            SqlCommand comm1 = new SqlCommand("select IDENT_CURRENT('EnterpriseDetails')", con);
            SqlCommand comm2 = new SqlCommand("select * from EnterpriseDetails", con);
            int emp_id = Convert.ToInt32(comm1.ExecuteScalar());
            SqlDataReader reader = comm2.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                emp_id++;
            }
            txtId.Text = emp_id.ToString();
            con.Close();
        }
    }
}
