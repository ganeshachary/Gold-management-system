using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Imaging;

namespace GoldenTechSolution
{
    public partial class Users : Form
    {
        SqlConnection con1;
        public bool search_flag = false;
        public string imgloc;
        bool main_flag = false;

        public Users(Form f,int tabindex)
        {
            InitializeComponent();
            this.MdiParent = f;
            this.Dock = DockStyle.Fill;
            tabCreateNewAccount.SelectedIndex = tabindex;
             con1 = new SqlConnection("Data Source=GANESH-HP;Initial Catalog=GoldenTechData;Integrated Security=True");
        }
        public Users()
        {
            InitializeComponent();
         con1 = new SqlConnection("Data Source=GANESH-HP;Initial Catalog=GoldenTechData;Integrated Security=True");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtAns1.ToString());
            //Dispose();
        }

      

        private void cmbQuestion1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAnswer1.Enabled = true;
        }

        private void cmbQuestion2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAnswer2.Enabled = true;
        }

        
        private void AllTextboxValidation(object sender, CancelEventArgs e)
       {
          
               //TextBox temp = (TextBox)sender;
               ////if (temp.TextLength == 0)
               ////{
               ////    temp.Select();
               ////}
               //String txtControlName = temp.Name;
               //if (temp.TextLength == 0)
               //{
               //    main_flag = false;
               //    errorProvider1.SetError(temp, "Enter some text");
               //}
               //else
               //{
               //    main_flag = true;
               //    errorProvider1.Clear();
               //    switch (txtControlName)
               //    {
               //        case "txtFirstName":
               //            {
               //                break;
               //            }
               //        case "txtLastName":
               //            {
               //                break;
               //            }
               //        case "txtUserName":
               //            {
               //                break;
               //            }
               //        case "txtPassword":
               //            {
               //                break;
               //            }
               //        case "txtReenterPassword":
               //            {
               //                break;
               //            }
               //        case "txtContact":
               //            {
               //                break;
               //            }
               //        case "txtEmailAddress2":
               //            {

               //                //if (Regex.Match(txtEmailAddress2.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*").Success)
               //                //{

               //                //}
               //                //else
               //                //{
               //                //    errorProvider1.SetError(temp,"Invalid Email");
               //                //}
               //                break;
               //            }

               //    }
               //}
           
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.DataInsert();
        }

        //datainsert method to insert value in database for new user account
        public void DataInsert()
        {
            String change="";
            String delete="";
            String view="";

            try
            {
                SqlConnection con = new SqlConnection("Data Source=GANESH-HP;Initial Catalog=GoldenTechData;Integrated Security=True");
                con.Open();
                DateTime birthdaydate = Convert.ToDateTime(dtpBirthday2.Value.ToString("dd-MM-yyyy"));
                String gender = "";
                if (rdMale2.Checked == true)
                    gender = "Male";
                else gender = "Female";
                if (chkChange2.Checked==true)
                {
                    change="admin";
                }
                else           
                {
                    change="";
                }
                if (chkDelete2.Checked == true)
                {
                    delete = "others";

                }
                else
                {
                    delete = "";
                }
                if (chkView2.Checked == true)
                {
                    view = "view";

                }
                else
                {
                    view = "";
                }

                String query = "INSERT INTO Login values('" + txtFirstName2.Text + "','" + txtLastName2.Text + "','" +
                    birthdaydate.ToString() + "','" + gender + "','" + txtContactNumber2.Text + "','" + txtEmailAddress2.Text + "','" + txtUserName2.Text + "','" + txtPassword2.Text + "','" + cmbQuestion1.SelectedItem.ToString()
                     + "','" + txtAnswer1.Text + "','" + cmbQuestion2.SelectedItem.ToString() + "','" + txtAnswer2.Text + "','" + System.DateTime.Now.ToString() + "','" + Master.LoggedUsername.ToString() + "','" + txtDesignation2.Text + "','" + change.ToString() +"','" + delete.ToString() + "','" + view.ToString() + "')";
                SqlCommand comm = new SqlCommand(query, con);
                comm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Inserted successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
          
            }
           catch (SystemException se)
            {
              MessageBox.Show(se.Message);
            }

        }


        public void DataChange(String usernameChange)
        {

            //loginBindingSource.ResetBindings(false);
            String change = "";
            String delete = "";
            String view = "";

            try
            {
                SqlConnection con = new SqlConnection("Data Source=GANESH-HP;Initial Catalog=GoldenTechData;Integrated Security=True");
                con.Open();
                DateTime birthdaydate = Convert.ToDateTime(dtpBirthday1.Value.ToString("dd-MM-yyyy"));
                String gender = "";
                if (rdMale1.Checked == true)
                    gender = "Male";
                else gender = "Female";
                if (chkChange1.Checked == true)
                {
                    change = "admin";
                }
                else
                {
                    change = "";
                }
                if (chkDelete1.Checked == true)
                {
                    delete = "others";

                }
                else
                {
                    delete = "";
                }
                if (chkView1.Checked == true)
                {
                    view = "view";

                }
                else
                {
                    view = "";
                }
              //  String querydelete = "delete from Login where username='"+usernameChange +"'";
               // SqlCommand deleteuser = new SqlCommand(querydelete, con);
               // deleteuser.ExecuteNonQuery();
                String query = "update Login set firstname='" + txtFirstName1.Text + "',lastname='" + txtLastName1.Text + "',birthday='" +
                    birthdaydate.ToString() + "',gender='" + gender + "',contact_number='" + txtContactNumber1.Text + "',email_address='" + txtEmailAddress1.Text + "',password='"+ txtPassword1.Text + "',question1='" + cmbQ1.SelectedItem.ToString()
                     + "',answer1='" + txtAns1.Text + "',question2='" + cmbQ2.SelectedItem.ToString() + "',answer2='" + txtAns2.Text + "',created_date_time='" + System.DateTime.Now.ToString() + "',admin='" + Master.LoggedUsername.ToString() + "',description='" + txtDescription1.Text + "',change_power='" + change.ToString() + "',view_power='" + view.ToString() + "',delete_power='" + delete.ToString() +"' where username='"+usernameChange+"'";
                SqlCommand comm = new SqlCommand(query, con);
                comm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Details have been successfully updated","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                 loginBindingSource.ResetBindings(false);
               this.loginTableAdapter.Fill(this.goldenTechDataDataSet2.Login);
            }
            catch (SystemException se)
            {
                MessageBox.Show(se.Message);
            }

        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            Enable_Controls();
        }

        private void btnCreateAccount_Click_1(object sender, EventArgs e)
        {
             
            //try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                BinaryReader br = new BinaryReader(ms);
                byte[] photo = new byte[ms.Length];
                photo = br.ReadBytes((int)ms.Length);
                //ms.Position = 0;
                //ms.Read(photo, 0, photo.Length);
                //con = new SqlConnection("Data Source=GANESH-HP;Initial Catalog=GoldenTechData;Integrated Security=True");
                con1.Open();
                String query ="insert into userimage values('"+txtUserName2.Text+"','"+photo+"')";
                SqlCommand com= new SqlCommand(query,con1);
                com.ExecuteNonQuery();
                //MessageBox.Show("success");
                con1.Close();

            
            }

            //catch (Exception ae)
            {

               // MessageBox.Show(ae.Message);
                con1.Close();
            }
            
            if (txtFirstName2.TextLength == 0)
            {
                MessageBox.Show("Enter firstname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLastName2.TextLength == 0)
            {
                MessageBox.Show("Enter lastname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtContactNumber2.TextLength == 0)
            {
                MessageBox.Show("Enter contact number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEmailAddress2.TextLength == 0)
            {
                MessageBox.Show("Enter email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDesignation2.TextLength == 0)
            {
                MessageBox.Show("Enter designation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUserName2.TextLength == 0)
            {
                MessageBox.Show("Enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUserName2.TextLength < 4)
            {
                MessageBox.Show("Username Cant be Less Than 4 Aphabet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                
                if (txtPassword2.TextLength == 0)
            {
                MessageBox.Show("Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                else
                    if (txtPassword2.TextLength <4 )
                    {
                        MessageBox.Show("Password Cant be Less Than 4 Aphabet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            else if (txtReenterPassword2.TextLength == 0)
            {
                MessageBox.Show("Re-Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                    else if (txtReenterPassword2.Text.Trim()!=(txtPassword2.Text.Trim()))
                    {


                        MessageBox.Show("Password Doesnt Match ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    }
                    else

                        
                        if (cmbQuestion1.SelectedIndex == -1)
            {
                MessageBox.Show("Select the question1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAnswer1.TextLength == 0)
            {
                MessageBox.Show("Enter Answer1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbQuestion2.SelectedIndex == -1)
            {
                MessageBox.Show("Enter the question2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAnswer2.TextLength == 0)
            {
                MessageBox.Show("Enter Answer2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
            else
            {
                DataInsert();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName2.Clear();
            txtLastName2.Clear();
            txtPassword2.Clear();
            txtReenterPassword2.Clear();
            txtUserName2.Clear();
            txtEmailAddress2.Clear();
            txtDesignation2.Clear();
            txtContactNumber2.Clear();
            txtAnswer2.Clear();
            txtAnswer1.Clear();
            cmbQuestion2.SelectedIndex = 0;
            cmbQuestion1.SelectedIndex = 0;

        }

        private void CreateAccount_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goldenTechDataDataSet2.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.goldenTechDataDataSet2.Login);
            if (dgvUsers.Rows.Count == 0)
            {
                MessageBox.Show("No records have been entered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // disable the controls on form load
            Disable_Controls();
            // Set the focus on the textbox when the form loads
            txtFirstName2.Select();

        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName1.TextLength == 0)
            {
                MessageBox.Show("Enter firstname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLastName1.TextLength == 0)
            {
                MessageBox.Show("Enter lastname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtContactNumber1.TextLength == 0)
            {
                MessageBox.Show("Enter contact number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEmailAddress1.TextLength == 0)
            {
                MessageBox.Show("Enter email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDescription1.TextLength == 0)
            {
                MessageBox.Show("Enter designation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUserName1.TextLength == 0)
            {
                MessageBox.Show("Enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword1.TextLength == 0)
            {
                MessageBox.Show("Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtReenterPassword1.TextLength == 0)
            {
                MessageBox.Show("Re-Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbQ1.SelectedIndex == -1)
            {
                MessageBox.Show("Select the question1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAns1.TextLength == 0)
            {
                MessageBox.Show("Enter Answer1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbQ2.SelectedIndex == -1)
            {
                MessageBox.Show("Enter the question2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAns2.TextLength == 0)
            {
                MessageBox.Show("Enter Answer2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                String usernamechange= txtUserName1.Text;
            DataChange(usernamechange);
            Disable_Controls();
        }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Disable_Controls();
            String change = "";
            String delete = "";
            String view = "";
            try
            {
                SqlConnection con = new SqlConnection("Data Source=GANESH-HP;Initial Catalog=GoldenTechData;Integrated Security=True");
                con.Open();
               
                String querydelete = "delete from Login where username='"+txtUserName1.Text+"'";
                SqlCommand deleteuser = new SqlCommand(querydelete, con);
                deleteuser.ExecuteNonQuery();
                con.Close();
                this.loginTableAdapter.Fill(this.goldenTechDataDataSet2.Login);
                MessageBox.Show("Data Deleted successfully");

            }
            catch (SystemException se)
            {
                MessageBox.Show(se.Message);
            }    
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            //Disable_Controls();
            //String searchId = cmbFind.SelectedItem.ToString();
            //String searchvalue = txtFind.Text.ToLower(); ;

            //try
            //{
            //    //SqlConnection con = new SqlConnection("Data Source=GANESH-HP;Initial Catalog=GoldenTechData;Integrated Security=True");
            //    //SqlDataAdapter adapt = new SqlDataAdapter("select * from Login where " + searchId + "LIKE '" + searchvalue + "%'", con);
            //    //DataSet ds = new DataSet();
            //    //adapt.Fill(ds, "Login");
            //    //dgvUsers.DataSource = ds;
            //    //dgvUsers.DataMember = "Login";
            //    //if (ds.Tables["Login"].Rows.Count == 0)
            //    //{
            //    //    MessageBox.Show("No records found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //}
            //    if(cmbFind.SelectedItem=="FirstName")

            //    {
            //    loginBindingSource.Filter = "firstname LIKE '" + txtFind.Text.Trim()+"%'";
            //    }
            //    if(cmbFind.SelectedItem=="LastName")
            //    {
            //    loginBindingSource.Filter = "lastname LIKE '" + txtFind.Text.Trim()+"%'";
            //    }
            //    if(cmbFind.SelectedItem=="Birthday")
            //    {
            //    loginBindingSource.Filter = "birthday LIKE '" + txtFind.Text.Trim()+"%'";
            //    }
            //    if(cmbFind.SelectedItem=="Contact")

            //    {
            //    loginBindingSource.Filter = "contact LIKE '" + txtFind.Text.Trim()+"%'";
            //    }
            //    if(cmbFind.SelectedItem=="username")

            //    {
            //    loginBindingSource.Filter = "username LIKE '" + txtFind.Text.Trim()+"%'";
            //    }
            //}
            //catch (Exception finde)
            //{
            //    MessageBox.Show(finde.ToString());
            //}

        }

        private void cmbFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFind.Enabled = true;
            Disable_Controls();       
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
          
            try
            {
               
                if (cmbFind.SelectedItem == "FirstName")
                {
                    loginBindingSource.Filter = "firstname LIKE '" + txtFind.Text.Trim() + "%'";
                }
                if (cmbFind.SelectedItem == "LastName")
                {
                    loginBindingSource.Filter = "lastname LIKE '" + txtFind.Text.Trim() + "%'";
                }
                if (cmbFind.SelectedItem == "Birthday")
                {
                    loginBindingSource.Filter = "birthday LIKE '" + txtFind.Text.Trim() + "%'";
                }
                if (cmbFind.SelectedItem == "Contact")
                {
                    loginBindingSource.Filter = "contact_number LIKE '" + txtFind.Text.Trim() + "%'";
                }
                if (cmbFind.SelectedItem == "username")
                {
                    loginBindingSource.Filter = "username LIKE '" + txtFind.Text.Trim() + "%'";
                }
            }
            catch (Exception finde)
            {
                MessageBox.Show(finde.ToString());
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Disable_Controls();
            loginBindingSource.RemoveFilter();
        }

        public void refreshDGV()
        {

            dgvUsers.DataSource = this.goldenTechDataDataSet2;
            dgvUsers.DataMember = "Login";
            cmbFind.SelectedIndex = -1;
            txtFind.Clear();
        }
        private void dgvUsers_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvUsers_DataSourceChanged(object sender, EventArgs e)
        {
            // Whenever the datasource is changed, the previous details on the controls should be erased.
            txtFirstName1.Clear();
            txtLastName1.Clear();
            txtPassword1.Clear();
            txtReenterPassword1.Clear();
            txtUserName1.Clear();
            txtEmailAddress1.Clear();
            txtDescription1.Clear();
            txtContactNumber1.Clear();
            txtAns1.Clear();
            txtAns2.Clear();
            cmbQ1.SelectedIndex = 0;
            cmbQ2.SelectedIndex = 0;
        }

        public void Enable_Controls()
        {
            grpPersonal1.Enabled = true;
            grpRole1.Enabled = true;
            grpLogin1.Enabled = true;
            grpSecurity1.Enabled = true;
            btnChange.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
        }
        public void Disable_Controls()
        {
            grpPersonal1.Enabled = false;
            grpRole1.Enabled = false;
            grpLogin1.Enabled = false;
            grpSecurity1.Enabled = false;
            btnChange.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void txtFind_MouseClick(object sender, MouseEventArgs e)
        {
            Disable_Controls();
        }

        private void txtContactNumber2_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(txtContactNumber2.Text , @"^[7-9]\d{9}$").Success)
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(txtContactNumber2, "Invalid contact number");
            }
        
        }

        private void txtEmailAddress2_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(txtEmailAddress2.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*").Success)
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(txtEmailAddress2, "Invalid Email");
            }
           
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsers_SelectionChanged_1(object sender, EventArgs e)
        {
            btnChange.Enabled = true;
           
            if (dgvUsers.SelectedRows.Count > 0)
            {
                //if (btnChange.Enabled == false)
                //{

                //    btnChange.Enabled = true;
                //}
                //else {
                //    btnChange.Enabled = false;
                //}
               try
               {
              //      {

              //          con1.Open();
              //          string query = "select * from userimage where id ='"+dgvUsers.SelectedRows[0].Cells[6].Value.ToString()+"'";
              //          SqlCommand com = new SqlCommand(query,con1);
              //          SqlDataReader r = com.ExecuteReader();
              //          r.Read();
                      
              //          if(r.HasRows)
              //          {
              //              byte[] image = (byte[])r[1];
              //              if (image != null)
              //              {
              //                  MemoryStream ms = new MemoryStream(image);
              //                  pictureBox2.Image =Bitmap.FromStream(ms);
              //              }
              //              else
              //              {}
                          
              //              con1.Close();
                        
              //          }
              //          con1.Close();
                        
              //      }
                    txtFirstName1.Text = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
                    txtLastName1.Text = dgvUsers.SelectedRows[0].Cells[1].Value.ToString();
                    String birthday = dgvUsers.SelectedRows[0].Cells[2].Value.ToString();
                    //DateTime dt = System.Convert.ToDateTime(birthday);
                    //dtpBirthday1.Value = dt;
                    String gender = dgvUsers.SelectedRows[0].Cells[3].Value.ToString();
                    if (gender.ToUpper().Equals("MALE"))
                    {
                        rdMale1.Checked = true;
                    }
                    else rdFemale1.Checked = true;
                    txtContactNumber1.Text = dgvUsers.SelectedRows[0].Cells[4].Value.ToString();
                    txtEmailAddress1.Text = dgvUsers.SelectedRows[0].Cells[5].Value.ToString();
                    txtUserName1.Text = dgvUsers.SelectedRows[0].Cells[6].Value.ToString();
                    txtPassword1.Text = dgvUsers.SelectedRows[0].Cells[7].Value.ToString();
                    txtReenterPassword1.Text = dgvUsers.SelectedRows[0].Cells[7].Value.ToString();
                    String q1 = dgvUsers.SelectedRows[0].Cells[8].Value.ToString();
                    for (int i = 0; i < cmbQ1.Items.Count; i++)
                    {
                        if (cmbQ1.Items[i].ToString().Equals(q1))
                        {
                            cmbQ1.SelectedIndex = i;
                        }
                    }
                    txtAns1.Text = dgvUsers.SelectedRows[0].Cells[9].Value.ToString();
                    String q2 = dgvUsers.SelectedRows[0].Cells[10].Value.ToString();
                    for (int i = 0; i < cmbQ2.Items.Count; i++)
                    {
                        if (cmbQ2.Items[i].ToString().Equals(q2))
                        {
                            cmbQ2.SelectedIndex = i;
                        }
                    }
                    txtAns2.Text = dgvUsers.SelectedRows[0].Cells[11].Value.ToString();
                    txtDescription1.Text = dgvUsers.SelectedRows[0].Cells[14].Value.ToString();
                    String change = dgvUsers.SelectedRows[0].Cells[15].Value.ToString().Trim().ToUpper();
                    String view = dgvUsers.SelectedRows[0].Cells[16].Value.ToString().Trim().ToUpper();
                    String delete = dgvUsers.SelectedRows[0].Cells[17].Value.ToString().Trim().ToUpper();

                    if (change.ToUpper().Equals("CHANGE"))
                    {
                        chkChange1.Checked = true;
                    }
                    else chkChange1.Checked = false;
                    if (delete.ToUpper().Equals("DELETE"))
                    {
                        chkDelete1.Checked = true;
                    }
                    else chkDelete1.Checked = false;
                    if (view.ToUpper().Equals("VIEW"))
                    {
                        chkView1.Checked = true;
                    }
                    else chkView1.Checked = false;

                }
             catch (SystemException se)
                {
                    MessageBox.Show(se.Message);
                    con1.Close();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Title = "Choose the image";
            openFileDialog1.Filter = "*.Bitmap|*.bmp|*.jpeg|*.jpg";
            openFileDialog1.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures";
            //if (openFileDialogImageCompany.ShowDialog() == DialogResult.OK)
            {
                imgloc = openFileDialog1.FileName;
               pictureBox1.ImageLocation = imgloc;
            }
        }

        private void txtFirstName2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }

        private void txtFirstName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsControl(e.KeyChar)==false && char.IsLetter(e.KeyChar)==false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Alphabet Only !");
            
            
            }
        }

        private void txtLastName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsLetter(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Alphabet Only !");


            }
        }

        private void txtContactNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsNumber(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Number Only !");


            }
        }

        private void txtDesignation2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsLetter(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Alphabet Only !");


            }
        }

        private void txtAnswer1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsLetter(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Alphabet Only !");


            }
        }

        private void txtAnswer2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsLetter(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Alphabet Only !");


            }
        }

        private void txtUserName2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=Ganesh-Hp;Initial Catalog=GoldenTechData;Integrated Security=True");
            con2.Open();
            String query="select * from Login where username ='"+ txtUserName2.Text.Trim()+"'" ;
            SqlCommand com = new SqlCommand(query,con2);
            SqlDataReader r = com.ExecuteReader();
            if (txtUserName2.TextLength > 0)
            {
                r.Read();
                if (r.HasRows)
                {
                    lblusername.ForeColor = Color.Red;
                    lblusername.Text = "Username already Exits";
                    con2.Close();
                }
                else
                {
                    lblusername.ForeColor = Color.Green;
                    lblusername.Text = "Username Available";
                    con2.Close();
                }
            }
            else 
            
            {
                lblusername.ForeColor = Color.Black;
                lblusername.Text = "";
            }
            con2.Close();
        }

        
      
        


       
        

    

       
       

       
      
      
    

    

      
    }
}
