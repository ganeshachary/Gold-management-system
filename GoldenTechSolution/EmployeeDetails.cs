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
    public partial class EmployeeDetails : Form
    {
        SqlConnection con;
        int emp_id;
        public EmployeeDetails()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=GANESH-HP;Initial Catalog=GoldenTechData;Integrated Security=True");
        }
        public EmployeeDetails(Form f,int tabindex)
        {
            
            InitializeComponent();
            this.MdiParent = f;
            this.Dock = DockStyle.Fill;
            tabEmployeeDetails.SelectedIndex = tabindex;
            con = new SqlConnection(@"Data Source=GANESH-HP;Initial Catalog=GoldenTechData;Integrated Security=True");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        public void DisplayCurrentIdentity()
        {
            con.Open();
            SqlCommand comm1 = new SqlCommand("SELECT IDENT_CURRENT('EmployeeDetails')", con);
            SqlCommand comm2 = new SqlCommand("SELECT * from EmployeeDetails", con);
            emp_id = System.Convert.ToInt32(comm1.ExecuteScalar());
            SqlDataReader reader = comm2.ExecuteReader();
            if (reader.HasRows == true)
            {
                emp_id++;
            }
            txtEmployeeId.Text = emp_id.ToString();
            con.Close();
        }
        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDetailsViewDataSet.EmployeeAllDetailsView' table. You can move, or remove it, as needed.
            this.employeeAllDetailsViewTableAdapter.Fill(this.allDetailsViewDataSet.EmployeeAllDetailsView);     
            this.DisplayCurrentIdentity();
        }
        public void ClearControlsPage1()
        {
            txtEmployeeName.Clear();
            txtBirthday.Clear();
            txtAge.Clear();
            rdMale.Checked = false;
            rdFemale.Checked = false;
            txtContactNumber.Clear();
            txtAlternateNumber.Clear();
            txtEmailAddress.Clear();
            txtDescription.Clear();
            txtRoomNo.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            txtLandmark.Clear();
            txtPincode.Clear();
            txtState.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbDesignation.SelectedIndex = -1;
        }
        public void ClearControlsPage2()
        {
            textEmpId.Clear();
            textEmpName.Clear();
            textAge.Clear();
            radioMale.Checked = false;
            radioFemale.Checked = false;
            textBirthday.Clear();
            textEmail.Clear();
            textContactNumber.Clear();
            textAlternarteContactNumber.Clear();
            textDescription.Clear();
            comboDesignation.SelectedIndex = -1;
            comboCategory.SelectedIndex = -1;
            textRoom.Clear();
            textStreet.Clear();
            textLandmark.Clear();
            textCity.Clear();
            textState.Clear();
            textPincode.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControlsPage1();
        }

        public void EnableControls()
        {
            grpbAddress.Enabled = true;
            grpbDetails.Enabled = true;
            grpbNarration.Enabled = true;
            grpbType.Enabled = true;
            btnDelete.Enabled = true;
            btnSaveChanges.Enabled = true;
        }

        public void DisableControls()
        {
            grpbAddress.Enabled = false;
            grpbDetails.Enabled = false;
            grpbNarration.Enabled = false;
            grpbType.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveChanges.Enabled = false;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            String gender = "";
            if (rdMale.Checked)
                gender = "Male";
            else gender = "Female";
            try
            {
                String detailQuery = "INSERT INTO EmployeeDetails(emp_name,emp_age,emp_gender,emp_dob,emp_email,emp_contact_no,emp_alt_contact_no,emp_description,emp_designation,emp_category) values('" + txtEmployeeName.Text + "','" + txtAge.Text + "','" + gender + "','" + txtBirthday.Text + "','" + txtEmailAddress.Text + "','" + txtContactNumber.Text + "','" + txtAlternateNumber.Text + "','" + txtDescription.Text + "','" + cmbDesignation.SelectedItem.ToString() + "','"+cmbCategory.SelectedItem.ToString()+"')";
                String addressQuery = "INSERT INTO EmployeeAddress(emp_id,room_no,street,landmark,city,state,pincode) values("+int.Parse(txtEmployeeId.Text)+",'"+txtRoomNo.Text+"','"+txtStreet.Text+"','"+txtLandmark.Text+"','"+txtCity.Text+"','"+txtState.Text+"','"+txtPincode.Text+"')";
                SqlCommand comm1 = new SqlCommand(detailQuery, con);
                SqlCommand comm2 = new SqlCommand(addressQuery, con);
                con.Open();
                comm1.ExecuteNonQuery();
                comm2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Account successfully created");
                //clear the details
                ClearControlsPage1();
                txtEmployeeId.Clear();
                this.employeeAllDetailsViewTableAdapter.Fill(this.allDetailsViewDataSet.EmployeeAllDetailsView);
                //clear the details
                btnCreateAccount.Enabled = false;
                             
            } 
            catch (SystemException se)
            {
                con.Close();
                MessageBox.Show(se.Message);
            }
        }

        private void cmbFind_Click(object sender, EventArgs e)
        {
            btnChange.Enabled = false;
            DisableControls();
        }

        private void cmbFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFind.Enabled = true;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
            btnDelete.Enabled = true;
            EnableControls();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.TextLength > 0)
                btnSearchUser.Enabled = true;
            else btnSearchUser.Enabled = false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            String gender = "";
            if (radioMale.Checked)
                gender = "Male";
            else gender = "Female";
            try
            {
                String detailsQuery = "UPDATE EmployeeDetails SET emp_name='" + textEmpName.Text + "', emp_age='" + textAge.Text + "', emp_gender='" + gender + "', emp_dob='" + textBirthday.Text + "', emp_email='" + textEmail.Text + "', emp_contact_no='" + textContactNumber.Text + "', emp_alt_contact_no='" + textAlternarteContactNumber.Text + "', emp_description='" + textDescription.Text + "', emp_designation='" + comboDesignation.SelectedItem.ToString() + "', emp_category='" + comboCategory.SelectedItem.ToString() + "' where emp_id=" + textEmpId.Text;
                String addressQuery = "UPDATE EmployeeAddress SET room_no='" + textRoom.Text + "', street='" + textStreet.Text + "', landmark='" + textLandmark.Text + "', city='" + textCity.Text + "', state='" + textState.Text + "', pincode='" + textPincode.Text + "' where emp_id=" + textEmpId.Text;
                SqlCommand comm1 = new SqlCommand(detailsQuery, con);
                SqlCommand comm2 = new SqlCommand(addressQuery, con);
                con.Open();
                comm1.ExecuteNonQuery();
                comm2.ExecuteNonQuery();          
                con.Close();
                this.employeeAllDetailsViewTableAdapter.Fill(this.allDetailsViewDataSet.EmployeeAllDetailsView);
                MessageBox.Show("Success");
            }
            catch (SystemException se)
            {
                con.Close();
                MessageBox.Show(se.Message);
            }

            DisableControls();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete ?\nOnce deleted, the Employee id cannot be reused.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr.ToString().ToUpper().Equals("YES"))
                {
                    int emp_id = int.Parse(textEmpId.Text);
                    String addressQuery = "delete from EmployeeAddress where emp_id=" + emp_id;
                    String detailsQuery = "delete from EmployeeDetails where emp_id=" + emp_id;
                    SqlCommand comm1 = new SqlCommand(addressQuery, con);
                    SqlCommand comm2 = new SqlCommand(detailsQuery, con);
                    con.Open();
                    comm1.ExecuteNonQuery();
                    comm2.ExecuteNonQuery();
                    con.Close();
                    this.employeeAllDetailsViewTableAdapter.Fill(this.allDetailsViewDataSet.EmployeeAllDetailsView);
                    MessageBox.Show("Success");
                    DisableControls();
                }
            }
            catch (SystemException se)
            {
                con.Close();
                MessageBox.Show(se.Message);
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            String col = cmbFind.SelectedItem.ToString();
            String findValue = txtFind.Text;
            String query = "select * from EmployeeAlldetailsView where " + col + "='" + findValue + "'";
            SqlCommand comm = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows==false)
            {
                MessageBox.Show("No records found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            SqlDataAdapter adapt = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "EmployeeAllDetailsView");
            dgvEmployee.DataSource = ds;
            dgvEmployee.DataMember = "EmployeeAllDetailsView";
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            cmbFind.SelectedIndex = -1;
            txtFind.Clear();
            dgvEmployee.DataSource = allDetailsViewDataSet;
            dgvEmployee.DataMember = "EmployeeAllDetailsView";
        }

        private void dgvEmployee_DataSourceChanged(object sender, EventArgs e)
        {
            ClearControlsPage2();
        }

       
        private void lnkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DisplayCurrentIdentity();
            btnCreateAccount.Enabled = true;
        }

        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvEmployee_Click(object sender, EventArgs e)
        {
            btnChange.Enabled = true;
            String gender = "", designation = "", category = "";
            int emp_id = System.Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells[0].Value);
            String query = "select * from EmployeeAllDetailsView where emp_id=" + emp_id;
            con.Open();
            SqlCommand comm = new SqlCommand(query, con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                textEmpId.Text = reader[0].ToString();
                textEmpName.Text = reader[1].ToString();
                textAge.Text = reader[2].ToString();
                gender = reader[3].ToString();
                if (gender.ToUpper().Equals("MALE"))
                {
                    radioMale.Checked = true;
                }
                else
                {
                    radioFemale.Checked = true;
                }
                textBirthday.Text = reader[4].ToString();
                textEmail.Text = reader[5].ToString();
                textContactNumber.Text = reader[6].ToString();
                textAlternarteContactNumber.Text = reader[7].ToString();
                textDescription.Text = reader[8].ToString();
                designation = reader[9].ToString();
                for (int i = 0; i < comboDesignation.Items.Count; i++)
                {
                    if (designation.Equals(comboDesignation.Items[i].ToString()))
                    {
                        comboDesignation.SelectedIndex = i;
                    }
                }
                category = reader[10].ToString();
                for (int i = 0; i < comboCategory.Items.Count; i++)
                {
                    if (category.Equals(comboCategory.Items[i].ToString()))
                    {
                        comboCategory.SelectedIndex = i;
                    }
                }
                textRoom.Text = reader[11].ToString();
                textStreet.Text = reader[12].ToString();
                textLandmark.Text = reader[13].ToString();
                textCity.Text = reader[14].ToString();
                textState.Text = reader[15].ToString();
                textPincode.Text = reader[16].ToString();
            }
            con.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
