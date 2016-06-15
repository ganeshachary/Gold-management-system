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
    public partial class StockDetails : Form
    {
        SqlConnection con;

        public StockDetails()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=Ganesh-Hp;Initial Catalog=GoldenTechData;Integrated Security=True");
        }

        public void LoadDataGridView()
        {
            String query = "SELECT * from StockView";
            SqlDataAdapter adapt = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "StockView");
            dgvStock.DataSource = ds;
            dgvStock.DataMember = "StockView";
        }

        public void LoadEnterpriseNames()
        {
            // load enterprise names
            cmbEnterpriseName.Items.Clear();
            cmbEnterpriseName.Items.Add("--None--");
            SqlCommand EnterpriseNames = new SqlCommand("SELECT ent_name from EnterpriseDetails", con);
            con.Open();
            SqlDataReader rd2 = EnterpriseNames.ExecuteReader();
            while (rd2.Read())
            {
                cmbEnterpriseName.Items.Add(rd2[0]);
            }
            con.Close();
            cmbEnterpriseName.SelectedIndex = 0;
            // load the gridview
            LoadDataGridView();
        }

        public void DisplayIdentity()
        {
            SqlCommand ItemCommand = new SqlCommand("SELECT IDENT_CURRENT('StockDetails')", con);
            SqlCommand CheckItemRows = new SqlCommand("SELECT * from StockDetails", con);
            con.Open();
            // set item id
            int item_id = System.Convert.ToInt32(ItemCommand.ExecuteScalar());
            SqlDataReader rd1 = CheckItemRows.ExecuteReader();
            if (rd1.HasRows)
            {
                item_id++;
            }
            con.Close();
            txtItemId.Text = item_id.ToString();
        }

        private void StockDetails_Load(object sender, EventArgs e)
        {
            txtEnterpriseId.Select();
            txtDate.Text = System.DateTime.Now.ToString("dd-MM-yyyy");
            DisplayIdentity();
            cmbMode.SelectedIndex = 0;
            LoadEnterpriseNames();

        }

        public void ClearDetails()
        {
            txtEnterpriseId.Clear();
            cmbEnterpriseName.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            cmbMetal.SelectedIndex = -1;
            txtGrossWeight.Clear();
            txtNetWeight.Clear();
            txtFineWeight.Clear();
            txtKarat.Clear();
            nudQuantity.Value = 1;
            dtpBoughtDate.ResetText();
            txtDescription.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDetails();
        }

        private void txtEnterpriseId_TextChanged(object sender, EventArgs e)
        {
            if (txtEnterpriseId.TextLength == 0)
            {
                cmbEnterpriseName.SelectedIndex = 0;
            }
            if (txtEnterpriseId.TextLength > 0)
            {
                lnklblVerify.Enabled = true;
            }
            else
            {
                lnklblVerify.Enabled = false;
            }
        }

        private void cmbEnterpriseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // print the ent_id
            if (cmbEnterpriseName.SelectedIndex != -1)
            {
                //txtEnterpriseId.Enabled = false;
                String ent_name = cmbEnterpriseName.SelectedItem.ToString();
                SqlCommand comm = new SqlCommand("SELECT * from EnterpriseDetails where ent_name='" + ent_name + "'", con);
                con.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    txtEnterpriseId.Text = reader[0].ToString();
                }
                con.Close();
            }
            else
            {
                txtEnterpriseId.Enabled = true;
                txtEnterpriseId.Clear();
            }
        }

        private void lnklblVerify_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String ent_name = "";
            int ent_id = int.Parse(txtEnterpriseId.Text);
            SqlCommand comm = new SqlCommand("SELECT * from EnterpriseDetails where ent_id=" + ent_id, con);
            con.Open();
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    ent_name = reader[1].ToString();
                }
                MessageBox.Show("Enterprise Id: " + ent_id + " found successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Enterprise Id: " + ent_id + " not found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            cmbEnterpriseName.Text = ent_name;// this opens a new connection
        }

        private void lnklblNewParty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new NewParty(this).ShowDialog();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (txtEnterpriseId.TextLength == 0)
            {
                MessageBox.Show("Enterprise Id cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbEnterpriseName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Enterprise name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Category!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMetal.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Metal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtGrossWeight.TextLength == 0)
            {
                MessageBox.Show("Gross weight cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNetWeight.TextLength == 0)
            {
                MessageBox.Show("Net weight cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtFineWeight.TextLength == 0)
            {
                MessageBox.Show("Fine weight cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtKarat.TextLength == 0)
            {
                MessageBox.Show("Karat value cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nudQuantity.Value <= 0)
            {
                MessageBox.Show("Quantity cannot be zero or less than zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataInsert();
            }
        }

        public void DataInsert()
        {
            String ent_name = cmbEnterpriseName.SelectedItem.ToString();
            String category = cmbCategory.SelectedItem.ToString();
            String metal = cmbMetal.SelectedItem.ToString();
            String quantity = nudQuantity.Value.ToString();
            String bought_date = dtpBoughtDate.Value.Date.ToString("dd-MM-yyyy");
            String date_of_entry = txtDate.Text.ToString();
            String Stock_Query = "INSERT INTO StockDetails(item_category, item_metal, item_gross_weight, item_net_weight, item_fine_weight, item_karat, quantity, date_of_entry, item_description) values('" + category + "','" + metal + "','" + txtGrossWeight.Text + "','" + txtNetWeight.Text + "','" + txtFineWeight.Text + "','" + txtKarat.Text + "','" + quantity + "','" + date_of_entry + "','" + txtDescription.Text + "')";
            String Stock_In_Query = "INSERT INTO StockIn values(" + int.Parse(txtItemId.Text) + "," + int.Parse(txtEnterpriseId.Text) + ",'" + bought_date + "')";
            SqlCommand comm1 = new SqlCommand(Stock_Query, con);
            SqlCommand comm2 = new SqlCommand(Stock_In_Query, con);
            con.Open();
            comm1.ExecuteNonQuery();
            comm2.ExecuteNonQuery();
            con.Close();
            LoadDataGridView();
            MessageBox.Show("Item added successfully to the Stocks.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearDetails();
            DisplayIdentity();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int row_num = dgvStock.SelectedRows[0].Index;
            if (row_num > 0)
            {
                row_num--;
            }
            dgvStock.Rows[row_num].Selected = true;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int row_num = dgvStock.SelectedRows[0].Index;
            if (row_num < dgvStock.Rows.Count - 1)
            {
                row_num++;
            }
            dgvStock.Rows[row_num].Selected = true;
        }

        private void cmbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMode.SelectedItem.ToString().Equals("Entry"))
            {
                ClearDetails();
                DisplayIdentity();
                btnAddStock.Visible = true;
                btnClear.Visible = true;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
            else
            {
                txtItemId.Clear();
                ClearDetails();
                btnAddStock.Visible = false;
                btnClear.Visible = false;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                dgvStock_SelectionChanged(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEnterpriseId.TextLength == 0)
            {
                MessageBox.Show("Enterprise Id cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbEnterpriseName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Enterprise name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Category!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMetal.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Metal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtGrossWeight.TextLength == 0)
            {
                MessageBox.Show("Gross weight cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNetWeight.TextLength == 0)
            {
                MessageBox.Show("Net weight cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtFineWeight.TextLength == 0)
            {
                MessageBox.Show("Fine weight cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtKarat.TextLength == 0)
            {
                MessageBox.Show("Karat value cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nudQuantity.Value <= 0)
            {
                MessageBox.Show("Quantity cannot be zero or less than zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                datachange();
            }

        }

        public void datachange()
        {

            try
            {
                int item_id = Convert.ToInt32(txtItemId.Text.Trim());
                String Stock_Query = "UPDATE StockDetails SET item_category='" + cmbCategory.SelectedItem.ToString() + "', item_metal='" + cmbMetal.SelectedItem.ToString() + "', item_gross_weight='" + txtGrossWeight.Text + "', item_net_weight='" + txtNetWeight.Text + "', item_fine_weight='" + txtFineWeight.Text + "', item_karat='" + txtKarat.Text + "', quantity='" + nudQuantity.Value.ToString() + "', item_description='" + txtDescription.Text + "' WHERE item_id=" + item_id;
                SqlCommand comm = new SqlCommand(Stock_Query, con);
                con.Open();
                comm.ExecuteNonQuery();
                con.Close();
                LoadDataGridView();
                MessageBox.Show("Success updated");
            }
            catch (SystemException se)
            {
                con.Close();
                MessageBox.Show(se.Message);
            }

        }
        private void dgvStock_SelectionChanged(object sender, EventArgs e)
        {
            if (cmbMode.SelectedItem.ToString().Equals("Update"))
            {
                if (dgvStock.SelectedRows.Count > 0)
                {
                    txtItemId.Text = dgvStock.SelectedRows[0].Cells[0].Value.ToString();
                    txtEnterpriseId.Text = dgvStock.SelectedRows[0].Cells[1].Value.ToString();
                    //cmbEnterpriseName.Text = dgvStock.SelectedRows[0].Cells[3].Value.ToString();
                    cmbCategory.SelectedItem = dgvStock.SelectedRows[0].Cells[2].Value.ToString();
                    cmbMetal.SelectedItem = dgvStock.SelectedRows[0].Cells[3].Value.ToString();
                    txtGrossWeight.Text = dgvStock.SelectedRows[0].Cells[4].Value.ToString();
                    txtNetWeight.Text = dgvStock.SelectedRows[0].Cells[5].Value.ToString();
                    txtFineWeight.Text = dgvStock.SelectedRows[0].Cells[6].Value.ToString();
                    txtKarat.Text = dgvStock.SelectedRows[0].Cells[7].Value.ToString();
                    nudQuantity.Value = Convert.ToDecimal((dgvStock.SelectedRows[0].Cells[8].Value));
                    txtDate.Text = dgvStock.SelectedRows[0].Cells[9].Value.ToString();
                    dtpBoughtDate.Text = dgvStock.SelectedRows[0].Cells[10].Value.ToString();
                    txtDescription.Text = dgvStock.SelectedRows[0].Cells[11].Value.ToString();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to permanently delete this item", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr.ToString().ToUpper().Equals("YES"))
            {
                if (dgvStock.SelectedRows.Count > 0)
                {
                    int id = System.Convert.ToInt32(dgvStock.SelectedRows[0].Cells[0].Value.ToString());
                    String query1 = "delete from StockIn where item_id=" + id;
                    String query2 = "delete from StockDetails where item_id=" + id;
                    SqlCommand comm1 = new SqlCommand(query1, con);
                    SqlCommand comm2 = new SqlCommand(query2, con);
                    con.Open();
                    comm1.ExecuteNonQuery();
                    comm2.ExecuteNonQuery();
                    con.Close();
                    LoadDataGridView();
                    MessageBox.Show("Item deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtEnterpriseId_DoubleClick(object sender, EventArgs e)
        {
            GoldenTechSolution.EnterpriseGridView eg = new GoldenTechSolution.EnterpriseGridView(this);
            eg.ShowDialog();
        }

        private void txtEnterpriseId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Number Only !");


            }
        }

        private void txtGrossWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar!='.' && char.IsNumber(e.KeyChar) == false &&char.IsControl(e.KeyChar)==false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Number Only !");

            }
        }

        private void txtNetWeight_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtNetWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Number Only !");
            }
        }

        private void txtFineWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFineWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Number Only !");
            }
        }

        private void txtKarat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Number Only !");
            }
        }
    }
}
