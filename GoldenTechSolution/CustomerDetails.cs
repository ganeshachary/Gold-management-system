using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GoldenTechSolution
{
    public partial class CustomerDetails : Form
    {
        int CustomerId = 0;
        SqlConnection con;
        public CustomerDetails()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=GANESH-HP;Initial Catalog=GoldenTechData;Integrated Security=True");
            this.tabCustomers.TabIndex=0;
        }
        public CustomerDetails(Form parent,int tabindex)
        {
            InitializeComponent();
            this.MdiParent = parent;
            this.Dock = DockStyle.Fill;
            tabCustomers.SelectedIndex = tabindex;
            con = new SqlConnection(@"Data Source=GANESH-HP;Initial Catalog=GoldenTechData;Integrated Security=True");
        }
        public void EnableControls()
        {
            groupCustomerAddress.Enabled = true;
            groupCustomerDetails.Enabled = true;
            groupCustomerNarration.Enabled = true;
            groupCustomerType.Enabled = true;
        }
        public void DisableControls()
        {
            groupCustomerAddress.Enabled = false;
            groupCustomerDetails.Enabled = false;
            groupCustomerNarration.Enabled = false;
            groupCustomerType.Enabled = false;
        }
        public void LoadDataGridView()
        {
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * from CustomerAllDetailsView", con);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "CustomerAllDetailsView");
            dgvCustomers.DataSource = ds;
            dgvCustomers.DataMember = "CustomerAllDetailsView";
        }
        public void ClearControlsPage1()
        {
            txtCustomerName.Clear();
            txtBirthday.Clear();
            txtAge.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtContactNo.Clear();
            txtAlternateNumber.Clear();
            txtEmailAddress.Clear();
            txtRoomNo.Clear();
            txtCity.Clear();
            txtStreet.Clear();
            txtPincode.Clear();
            txtLandmark.Clear();
            txtState.Clear();
            chkOrder.Checked = false;
            chkRepair.Checked = false;
            chkLoan.Checked = false;
            txtDescription.Clear();
        }
        public void ClearControlsPage2()
        {
            textCustomerId.Clear();
            textCustomerName.Clear();
            textBirthday.Clear();
            textAge.Clear();
            radioMale.Checked = false;
            radioFemale.Checked = false;
            textContactNumber.Clear();
            textAlternateContactNumber.Clear();
            textEmailId.Clear();
            textRoom.Clear();
            textCity.Clear();
            textStreet.Clear();
            textPincode.Clear();
            textLandmark.Clear();
            textState.Clear();
            checkOrder.Checked = false;
            checkRepair.Checked = false;
            checkLoan.Checked = false;
            textDescription.Clear();
        }
        public void DisplayCurrentIdentity()
        {
            SqlCommand comm1 = new SqlCommand("SELECT IDENT_CURRENT('CustomerDetails')", con);
            SqlCommand comm2 = new SqlCommand("SELECT * from CustomerDetails", con);
            con.Open();
            CustomerId = System.Convert.ToInt32(comm1.ExecuteScalar());
            SqlDataReader reader = comm2.ExecuteReader();
            if (reader.HasRows)
                CustomerId++;
            txtCustomerId.Text = CustomerId.ToString();
            con.Close();
        }
        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            DisplayCurrentIdentity();
            LoadDataGridView();
           
                
           
        }
        
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                String order = "", repair = "", loan = "";
                String gender = "";
                if (rdoMale.Checked)
                    gender = "Male";
                else gender = "Female";
                if (chkOrder.Checked)
                    order = "Order";
                if (chkRepair.Checked)
                    repair = "Repair";
                if (chkLoan.Checked)
                    loan = "Loan";
                String DetailsQuery = "INSERT INTO CustomerDetails(cust_name,cust_age,cust_gender,cust_dob,cust_contact_no,cust_alt_contact_no,cust_email,description) values('" + txtCustomerName.Text + "','" + txtAge.Text + "','" + gender + "','" + txtBirthday.Text + "','" + txtContactNo.Text + "','" + txtAlternateNumber.Text + "','" + txtEmailAddress.Text + "','" + txtDescription.Text + "')";
                String AddressQuery = "INSERT INTO CustomerAddress(cust_id,room_no,street,landmark,city,state,pincode) values(" + int.Parse(txtCustomerId.Text) + ",'" + txtRoomNo.Text + "','" + txtStreet.Text + "','" + txtLandmark.Text + "','" + txtCity.Text + "','" + txtState.Text + "','" + txtPincode.Text + "')";
                String CategoryQuery = "INSERT INTO CustomerCategory(cust_id,cust_order,cust_repair,cust_loan) values(" + int.Parse(txtCustomerId.Text) + ",'" + order + "','" + repair + "','" + loan + "')";
                SqlCommand comm1 = new SqlCommand(DetailsQuery, con);
                SqlCommand comm2 = new SqlCommand(AddressQuery, con);
                SqlCommand comm3 = new SqlCommand(CategoryQuery, con);
                con.Open();
                comm1.ExecuteNonQuery();
                comm2.ExecuteNonQuery();
                comm3.ExecuteNonQuery();
                con.Close();   
                MessageBox.Show("Success");
                txtCustomerId.Clear();
                ClearControlsPage1();
                DisplayCurrentIdentity();
                LoadDataGridView();
            }
            catch (SystemException se)
            {
                con.Close();
                MessageBox.Show(se.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControlsPage1();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void txtEnterValue_TextChanged(object sender, EventArgs e)
        {
            if (txtEnterValue.TextLength > 0)
            {
                String category = cmbCategory.SelectedItem.ToString();
                String value = txtEnterValue.Text;
                String query = "SELECT * from CustomerAllDetailsView WHERE " + category + " LIKE '" + value + "%'";
                SqlDataAdapter adapt = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adapt.Fill(ds, "CustomerAllDetailsView");
                dgvCustomers.DataSource = ds;
                dgvCustomers.DataMember = "CustomerAllDetailsView";
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEnterValue.Enabled = true;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            cmbCategory.SelectedIndex = -1;
            txtEnterValue.Clear();
            txtEnterValue.Enabled = false;
        }

        private void dgvCustomers_Click(object sender, EventArgs e)
        {
            //if (dgvCustomers.RowCount > 0)
            //{
            //    btnChange.Enabled = true;
            //    String gender = "", order = "", repair = "", loan = "";
            //    int id = System.Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
            //    String query = "SELECT * FROM CustomerAllDetailsView where cust_id=" + id;
            //    SqlCommand comm = new SqlCommand(query, con);
            //    con.Open();
            //    SqlDataReader reader = comm.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        textCustomerId.Text = reader[0].ToString();
            //        textCustomerName.Text = reader[1].ToString();
            //        textAge.Text = reader[2].ToString();
            //        gender = reader[3].ToString().Trim().ToUpper();
            //        if (gender.Equals("MALE"))
            //            radioMale.Checked = true;
            //        else radioFemale.Checked = true;
            //        textBirthday.Text = reader[4].ToString();
            //        textContactNumber.Text = reader[5].ToString();
            //        textAlternateContactNumber.Text = reader[6].ToString();
            //        textEmailId.Text = reader[7].ToString();
            //        textDescription.Text = reader[8].ToString();
            //        textRoom.Text = reader[9].ToString();
            //        textStreet.Text = reader[10].ToString();
            //        textLandmark.Text = reader[11].ToString();
            //        textCity.Text = reader[12].ToString();
            //        textState.Text = reader[13].ToString();
            //        textPincode.Text = reader[14].ToString();
            //        order = reader[15].ToString();
            //        repair = reader[16].ToString();
            //        loan = reader[17].ToString();
            //        if (order.ToUpper().Equals("ORDER"))
            //            checkOrder.Checked = true;
            //        else checkOrder.Checked = false;
            //        if (repair.ToUpper().Equals("REPAIR"))
            //            checkRepair.Checked = true;
            //        else checkRepair.Checked = false;
            //        if (loan.ToUpper().Equals("LOAN"))
            //            checkLoan.Checked = true;
            //        else checkLoan.Checked = false;
            //    }
            //    con.Close();                
            //}
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            String gender = "";
            String order = "", repair = "", loan = "";

            if (checkOrder.Checked)
                order = "Order";
            if (checkRepair.Checked)
                repair = "Repair";
            if (checkLoan.Checked)
                loan = "Loan";

            if (rdoMale.Checked)
                gender = "Male";
            else gender = "Female";

            String detailsUpdate = "UPDATE CustomerDetails SET cust_name='" + textCustomerName.Text + "', cust_age='" + textAge.Text + "', cust_gender='" + gender + "', cust_dob='" + textBirthday.Text + "', cust_contact_no='" + textContactNumber.Text + "', cust_alt_contact_no='" + textAlternateContactNumber.Text + "', cust_email='" + textEmailId.Text + "', description='" + textDescription.Text + "' WHERE cust_id=" + textCustomerId.Text;
            String addressUpdate = "UPDATE CustomerAddress SET room_no='" + textRoom.Text + "', street='" + textStreet.Text + "', landmark='" + textLandmark.Text + "', city='" + textCity.Text + "', state='" + textState.Text + "', pincode='" + textPincode.Text + "' WHERE cust_id=" + textCustomerId.Text;
            String categoryUpdate = "UPDATE CustomerCategory SET cust_order='" + order + "', cust_repair='" + repair + "', cust_loan='" + loan + "' WHERE cust_id=" + textCustomerId.Text;
            SqlCommand comm1 = new SqlCommand(detailsUpdate, con);
            SqlCommand comm2 = new SqlCommand(addressUpdate, con);
            SqlCommand comm3 = new SqlCommand(categoryUpdate, con);
            con.Open();
            comm1.ExecuteNonQuery();
            comm2.ExecuteNonQuery();
            comm3.ExecuteNonQuery();
            con.Close();   
            btnSaveChanges.Enabled = false;
            btnDelete.Enabled = false;
            DisableControls();
            LoadDataGridView();
            MessageBox.Show("Details have been successfully updated!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            cmbCategory.SelectedIndex = -1;
            txtEnterValue.Clear();
            txtEnterValue.Enabled = false;

            btnSaveChanges.Enabled = true;
            btnDelete.Enabled = true;
            EnableControls();
        }

        private void dgvCustomers_DataSourceChanged(object sender, EventArgs e)
        {
            ClearControlsPage2();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = System.Convert.ToInt32(textCustomerId.Text);
            String addressDelete = "delete from CustomerAddress where cust_id=" + id;
            String categoryDelete = "delete from CustomerCategory where cust_id=" + id;
            String detailsDelete = "delete from CustomerDetails where cust_id=" + id;
            SqlCommand comm1 = new SqlCommand(addressDelete, con);
            SqlCommand comm2 = new SqlCommand(categoryDelete, con);
            SqlCommand comm3 = new SqlCommand(detailsDelete, con);
            con.Open();
            comm1.ExecuteNonQuery();
            comm2.ExecuteNonQuery();
            comm3.ExecuteNonQuery();
            con.Close();
            btnSaveChanges.Enabled = false;
            btnDelete.Enabled = false;
            DisableControls();
            LoadDataGridView();
            MessageBox.Show("Successfully deleted");
        }

        private void cmbCategory_Enter(object sender, EventArgs e)
        {
            btnChange.Enabled = false;
            btnSaveChanges.Enabled = false;
            btnDelete.Enabled = false;
            DisableControls();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(dgvCustomers.SelectedRows.Count>0)
                {
                    btnChange.Enabled = true;
                    String gender = "", order = "", repair = "", loan = "";
                    int id = System.Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
                    String query = "SELECT * FROM CustomerAllDetailsView where cust_id=" + id;
                    SqlCommand comm = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = comm.ExecuteReader();
                    if (reader.Read())
                    {
                        textCustomerId.Text = reader[0].ToString();
                        textCustomerName.Text = reader[1].ToString();
                        textAge.Text = reader[2].ToString();
                        gender = reader[3].ToString().Trim().ToUpper();
                        if (gender.Equals("MALE"))
                            radioMale.Checked = true;
                        else radioFemale.Checked = true;
                        textBirthday.Text = reader[4].ToString();
                        textContactNumber.Text = reader[5].ToString();
                        textAlternateContactNumber.Text = reader[6].ToString();
                        textEmailId.Text = reader[7].ToString();
                        textDescription.Text = reader[8].ToString();
                        textRoom.Text = reader[9].ToString();
                        textStreet.Text = reader[10].ToString();
                        textLandmark.Text = reader[11].ToString();
                        textCity.Text = reader[12].ToString();
                        textState.Text = reader[13].ToString();
                        textPincode.Text = reader[14].ToString();
                        order = reader[15].ToString();
                        repair = reader[16].ToString();
                        loan = reader[17].ToString();
                        if (order.ToUpper().Equals("ORDER"))
                            checkOrder.Checked = true;
                        else checkOrder.Checked = false;
                        if (repair.ToUpper().Equals("REPAIR"))
                            checkRepair.Checked = true;
                        else checkRepair.Checked = false;
                        if (loan.ToUpper().Equals("LOAN"))
                            checkLoan.Checked = true;
                        else checkLoan.Checked = false;
                    }
                    con.Close();
                }
            }
            catch(Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void tabCustomers_Selected(object sender, TabControlEventArgs e)
        {
            if (tabCustomers.SelectedTab == tabCustomerChange)
            {
                dgvCustomers.Select();
            }
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

       
    }
}
