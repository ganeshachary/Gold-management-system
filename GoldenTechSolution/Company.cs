using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace GoldenTechSolution
{
    public partial class Company : Form
    {
        string imgloc;
        string imgloc2;
        string searchid="";
        string searchvalue="";
        SqlDataReader rd;
        SqlConnection con;
  
        int emp_id = 0;
        public Company()
        {
            InitializeComponent();
           
            con = new SqlConnection("Data Source=GANESH-HP;Initial Catalog=GoldenTechData;Integrated Security=True");
        }
        public Company(Form f, int tabindex)
        {
            InitializeComponent();
            this.MdiParent = f;
            this.Dock = DockStyle.Fill;
            tabCompany.SelectedIndex = tabindex;
            con = new SqlConnection("Data Source=GANESH-HP;Initial Catalog=GoldenTechData;Integrated Security=True");

            getID1();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void Company_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allEnterpriseDetailsDataSet.AllEnterpriseDetailsView' table. You can move, or remove it, as needed.
            this.allEnterpriseDetailsViewTableAdapter.Fill(this.allEnterpriseDetailsDataSet.AllEnterpriseDetailsView);
            // TODO: This line of code loads data into the 'allEnterpriseDetailsViewDataSet.AllEnterpriseDetailsView' table. You can move, or remove it, as needed.
        
         
            // TODO: This line of code loads data into the 'goldenTechDataDataSet5.EnterpriseDetails' table. You can move, or remove it, as needed.

            grpCompanyDetails2.Enabled = false;
            grpType2.Enabled = false;
            grpAddress2.Enabled = false;
            getID1();

            this.allEnterpriseDetailsViewTableAdapter.Fill(this.allEnterpriseDetailsDataSet.AllEnterpriseDetailsView);
  
        }
        public void getID1()
        {
            con.Open();
            SqlCommand comm1 = new SqlCommand("select IDENT_CURRENT('EnterpriseDetails')", con);
            SqlCommand comm2 = new SqlCommand("select * from EnterpriseDetails", con);
            emp_id = Convert.ToInt32(comm1.ExecuteScalar());
            SqlDataReader reader = comm2.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                emp_id++;
            }
            txtCompanyId1.Text = emp_id.ToString();
            con.Close();

        }
        public void getID2()
        {
            con.Open();
            SqlCommand comm1 = new SqlCommand("select IDENT_CURRENT('EnterpriseDetails')", con);
            SqlCommand comm2 = new SqlCommand("select * from EnterpriseDetails", con);
            emp_id = Convert.ToInt32(comm1.ExecuteScalar());
            SqlDataReader reader = comm2.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                emp_id++;
            }
            txtCompanyId2.Text = emp_id.ToString().Trim();
            con.Close();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            clear();
        }
        public void clear()
        {
            txtCompanyName1.Clear();
            txtContactNo1.Clear();
            txtDescription1.Clear();
            txtEmailAddress1.Clear();
            txtLandmark1.Clear();
            txtPincode1.Clear();
            txtRoomNo1.Clear();
            txtState1.Clear();
            txtStreet1.Clear();
            txtCity1.Clear();
            txtAlternateNumber1.Clear();
            chkBank1.Checked = false;
            chkShop1.Checked = false;
            chkCustomer1.Checked = false;
            chkSupplier1.Checked = false;
            txtCompanyId1.Select();
        
        }
        public void clear2()
        {
            txtCompanyId1.Clear();
            txtCompanyName2.Clear();
            txtContactNumber.Clear();
            txtDescription2.Clear();
            txtEmailAddress2.Clear();
            txtLandmark2.Clear();
            txtPincode2.Clear();
            txtRoomNo2.Clear();
            txtState2.Clear();
            txtStreet2.Clear();
            txtCity2.Clear();
            txtAlternateNumber2.Clear();
            chkBank2.Checked = false;
            chkShop2.Checked = false;
            chkCustomer2.Checked = false;
            chkSupplier2.Checked = false;
            txtCompanyId2.Select();

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            
            String bank="",customer="",shop="",supplier="";
            if(chkBank1.Checked==true)
            {
               bank="bank"; 
            }
            else
                bank="";
            
            if(chkSupplier1.Checked==true)
            {
               supplier="supplier"; 
            }
            else
                supplier="";

            if(chkCustomer1.Checked==true)
            {
              customer="customer"; 
            }
            else
                customer="";

            if(chkShop1.Checked==true)
            {
               shop="shop"; 
            }
            else
                shop="";
            try
            {
                byte[] img = null;
                if (imgloc2 == null)
                {
                    FileStream fs = new FileStream(picboxCompany1.ImageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                }
                else {
                    FileStream fs = new FileStream(imgloc2, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                }
                con.Open();
                String imagequery = "insert into Companyimage values('"+txtCompanyId1.Text.Trim()+"',@img)";

                String detailQuery = "insert into EnterpriseDetails(ent_name,ent_contact_no,ent_alt_contact_no,ent_email_id,ent_decsription) values('" + txtCompanyName1.Text.Trim() + "','" + txtContactNo1.Text.Trim() + "','" + txtAlternateNumber1.Text.Trim() + "','" + txtEmailAddress1.Text.Trim() + "','" + txtDescription1.Text.Trim() + "')";
                String addressQuery = "insert into EnterpriseAddress values('" + txtCompanyId1.Text.Trim() + "','" + txtRoomNo1.Text.Trim() + "','" + txtStreet1.Text.Trim() + "','" + txtLandmark1.Text.Trim() + "','" + txtCity1.Text.Trim() + "','" + txtState1.Text.Trim() + "','" + txtPincode1.Text.Trim() + "') ";
                String typeQuery = "insert into EnterpriseType values('" + txtCompanyId1.Text.Trim() + "','" + supplier.Trim() + "','" + customer.Trim() + "','" + bank.Trim() + "','" + shop.Trim() + "')";
                SqlCommand comm = new SqlCommand(detailQuery, con);
                SqlCommand comm2 = new SqlCommand(addressQuery,con);
              
                 SqlCommand comm3 = new SqlCommand(typeQuery,con);
                 SqlCommand comm4 = new SqlCommand(imagequery,con);
                 comm4.Parameters.Add(new SqlParameter("@img",img));
                comm.ExecuteNonQuery();
                comm2.ExecuteNonQuery();
                comm3.ExecuteNonQuery();
                comm4.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfuly created company: "+txtCompanyName1.Text+"with id "+txtCompanyId1.Text);
                clear();
                getID1();
                this.allEnterpriseDetailsViewTableAdapter.Fill(this.allEnterpriseDetailsDataSet.AllEnterpriseDetailsView);
                  }
            catch (SystemException se)
            {
                MessageBox.Show(se.Message);
                con.Close();
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            disablecontrols2();
            String bank = "", customer = "", shop = "", supplier = "";
            if (chkBank1.Checked == true)
            {
                bank = "bank";
            }
            else
                bank = "";

            if (chkSupplier1.Checked == true)
            {
                supplier = "supplier";
            }
            else
                supplier = "";

            if (chkCustomer1.Checked == true)
            {
                customer = "customer";
            }
            else
                customer = "";

            if (chkShop1.Checked == true)
            {
                shop = "shop";
            }
            else
                shop = "";
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgloc2, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                
                con.Open();
                String imagequery = "update  Companyimage set image = @img where ent_id='"+txtCompanyId2.Text+"'";

                String detailQuery = "update EnterpriseDetails set ent_name='" + txtCompanyName2.Text.Trim() + "'," + "ent_contact_no='" + txtContactNumber.Text.Trim() + "'," + "ent_alt_contact_no='" + txtAlternateNumber2.Text.Trim() + "'," + "ent_email_id='" + txtEmailAddress2.Text.Trim() + "'," + "ent_decsription='" + txtDescription2.Text.Trim() + "'" + "  where ent_id='" + txtCompanyId2.Text.Trim()+"'";
                String addressQuery = "update EnterpriseAddress set room_no='" + txtRoomNo2.Text.Trim() + "',street='" + txtStreet2.Text.Trim() + "',landmark='" + txtLandmark2.Text.Trim() + "',city='" + txtCity2.Text.Trim() + "',state='" + txtState2.Text.Trim() + "',pincode='" + txtPincode2.Text.Trim() + "' where ent_id='" + txtCompanyId2.Text.Trim() + "'";
                String typeQuery = "update EnterpriseType set supplier='" + supplier.Trim() + "',customer='" + customer.Trim() + "',bank='" + bank.Trim() + "',shop='" + shop.Trim() + "' where ent_id='" + txtCompanyId2.Text.Trim() + "'"; 
                SqlCommand comm2 = new SqlCommand(addressQuery, con);
                SqlCommand comm = new SqlCommand(detailQuery, con);
                SqlCommand comm3 = new SqlCommand(typeQuery, con);
                SqlCommand comm4 = new SqlCommand(imagequery, con);
                comm4.Parameters.AddWithValue("@img", img);
                comm.ExecuteNonQuery();
                comm2.ExecuteNonQuery();
                comm3.ExecuteNonQuery();
                comm4.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfuly update company: " + txtCompanyName2.Text + "with id " + txtCompanyId2.Text);
                clear();
                this.allEnterpriseDetailsViewTableAdapter.Fill(this.allEnterpriseDetailsDataSet.AllEnterpriseDetailsView);

           

            }
            catch (SystemException se)
            {
                MessageBox.Show(se.Message);
                con.Close();
            }
        }

        private void txtDescrption_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChange2_Click(object sender, EventArgs e)
        {
            enablecontrols2();
        }

        public void enablecontrols2()
        {
            btnSave2.Enabled = true;
            btnDelete2.Enabled = true;
            btnChange2.Enabled = true;
            grpCompanyDetails2.Enabled = true; ;
            grpType2.Enabled = true;
            grpAddress2.Enabled = true;
        }
        public void disablecontrols2()
        {
            btnSave2.Enabled = false;
            btnChange2.Enabled = false;
            btnDelete2.Enabled = false;
            btnChange2.Enabled = false;
            grpCompanyDetails2.Enabled = false; ;
            grpType2.Enabled = false;
            grpAddress2.Enabled = false;
        }
        private void btnDelete2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String detailQuery = "delete from EnterpriseDetails where ent_id='" + txtCompanyId2.Text.Trim() + "'";
                String addressQuery = "delete from EnterpriseAddress where ent_id='" + txtCompanyId2.Text.Trim() + "'";
                String typeQuery = "delete from  EnterpriseType where ent_id='" + txtCompanyId2.Text.Trim() + "'";
                SqlCommand comm2 = new SqlCommand(addressQuery, con);
                SqlCommand comm = new SqlCommand(detailQuery, con);
                SqlCommand comm3 = new SqlCommand(typeQuery, con);
                
                comm2.ExecuteNonQuery();
                comm3.ExecuteNonQuery();
                comm.ExecuteNonQuery();
               
                con.Close();
                disablecontrols2();
                clear2();
                this.allEnterpriseDetailsViewTableAdapter.Fill(this.allEnterpriseDetailsDataSet.AllEnterpriseDetailsView);
            }
            catch(Exception ae)
            {
                MessageBox.Show(ae.Message);
                con.Close();
            }
        }

        private void dgvComapanyDetails2_Click(object sender, EventArgs e)
        {
            //String detailQuery = "select * from EnterpriseDetails where'"+dgvComapanyDetails2.SelectedRows[0].Cells[0].ToString()+"'";
            //String addressQuery = "select * from EnterpriseAddress where'"+dgvComapanyDetails2.SelectedRows[0].Cells[0].ToString()+"'";
            //String typeQuery = "select * from EnterpriseType where'" + dgvComapanyDetails2.SelectedRows[0].Cells[0].ToString() + "'";
            //SqlCommand comm2 = new SqlCommand(addressQuery, con);
            //SqlCommand comm = new SqlCommand(detailQuery, con);
            //SqlCommand comm3 = new SqlCommand(typeQuery, con);
            //SqlDataReader readdetails = comm.ExecuteReader();
            //SqlDataReader readaddress = comm2.ExecuteReader();
            //SqlDataReader readtype = comm3.ExecuteReader();
      if(dgvComapanyDetails2.SelectedRows.Count>0)
      {
          try
          {
              byte[] img = null;
              disableonclickdgv();
              con.Open();
              String imageretrivequery = "select * from Companyimage where ent_id='" + dgvComapanyDetails2.SelectedRows[0].Cells[0].Value.ToString().Trim() + "'";
              SqlCommand comm = new SqlCommand(imageretrivequery, con);
              SqlDataReader reader = comm.ExecuteReader();
              reader.Read();
              if (reader.HasRows)
              {
                  img = (byte[])(reader[1]);
                  if (img == null)
                  {
                      pictureComapany2.Image = null;
                  }
                  else
                  {
                      MemoryStream ms = new MemoryStream(img);
                      pictureComapany2.Image = Image.FromStream(ms);
                  }
              }
              else
              {
                  pictureComapany2.Image = null;
              }
              con.Close();
              {
                  txtCompanyId2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[0].Value.ToString().Trim();
                  txtCompanyName2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[1].Value.ToString().Trim();
                  txtContactNumber.Text = dgvComapanyDetails2.SelectedRows[0].Cells[2].Value.ToString().Trim();
                  txtAlternateNumber2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[3].Value.ToString().Trim();
                  txtEmailAddress2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[4].Value.ToString().Trim();
                  txtDescription2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[5].Value.ToString().Trim();



              }

              {
                  txtCity2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[6].Value.ToString().Trim();
                  txtState2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[7].Value.ToString().Trim();
                  txtPincode2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[8].Value.ToString().Trim();
                  txtLandmark2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[9].Value.ToString().Trim();
                  txtStreet2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[10].Value.ToString().Trim();
                  txtRoomNo2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[11].Value.ToString().Trim();





              }

              if (dgvComapanyDetails2.SelectedRows[0].Cells[12].Value.ToString() == "supplier")
                  chkSupplier2.Checked = true;
              else
                  chkSupplier2.Checked = false;

              if (dgvComapanyDetails2.SelectedRows[0].Cells[13].Value.ToString() == "customer")
                  chkCustomer2.Checked = true;
              else
                  chkCustomer2.Checked = false;

              if (dgvComapanyDetails2.SelectedRows[0].Cells[14].Value.ToString() == "bank")
                  chkBank2.Checked = true;
              else
                  chkBank2.Checked = false;
              if (dgvComapanyDetails2.SelectedRows[0].Cells[15].Value.ToString() == "shop")
                  chkShop2.Checked = true;
              else
                  chkShop2.Checked = false;

          }
          catch(Exception ae)
          {
              MessageBox.Show(ae.Message);
              con.Close();
          }
                                           
      }
        }
        public void disableonclickdgv()
        {
           //cmbFind.Enabled = false;
           //txtFind2.Enabled = false;
           //btnFind2.Enabled = false;
            btnChange2.Enabled = true;
        
        }

        private void cmbFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFind2.Enabled = true;
          
            if (cmbFind.SelectedIndex >= 0)
            {
                if (cmbFind.SelectedItem.ToString().Trim().Equals("CompanyId"))
                {

                    searchid = "ent_id";

                }
                else
                {
                    searchid = "";

                    if (cmbFind.SelectedItem.ToString().Trim() == "CompanyName")
                    {
                        searchid = "ent_name";
                      
                    }
                    else
                    {
                        searchid = "";
                        if (cmbFind.SelectedItem.ToString().Trim() == "ContactNumber")
                        {
                            searchid = "ent_contact_no";
                          
                        }
                        else
                            searchid = "";
                    }
                }
              
            }
        }

        private void txtFind2_TextChanged(object sender, EventArgs e)
        {
            if (txtFind2.Text == "")
            {
                btnFind2.Enabled = false;
                this.allEnterpriseDetailsViewTableAdapter.Fill(this.allEnterpriseDetailsDataSet.AllEnterpriseDetailsView);
                dgvComapanyDetails2.DataSource = allEnterpriseDetailsDataSet;
                dgvComapanyDetails2.DataMember = "AllEnterpriseDetailsView";
                
            }
            else
            {
                btnFind2.Enabled = true;

                try
                {
                    con.Open();
                    searchvalue = txtFind2.Text.Trim();

                    SqlDataAdapter adapt = new SqlDataAdapter("select * from AllEnterpriseDetailsView  where " + searchid + " Like '" + searchvalue + "%'", con);
                    DataSet t = new DataSet();
                    con.Close();
                    adapt.Fill(t, "AllEnterpriseDetailsView");
                    dgvComapanyDetails2.DataSource = t;
                    dgvComapanyDetails2.DataMember = "AllEnterpriseDetailsView";
                    con.Close();
                }

                catch (Exception ae)
                {
                    MessageBox.Show(ae.Message);
                    con.Close();
                }
            }

        }

        private void btnShowAll2_Click(object sender, EventArgs e)
        {

            this.allEnterpriseDetailsViewTableAdapter.Fill(this.allEnterpriseDetailsDataSet.AllEnterpriseDetailsView);
            dgvComapanyDetails2.DataSource = allEnterpriseDetailsDataSet;
            dgvComapanyDetails2.DataMember = "AllEnterpriseDetailsView";
        }

        private void btnFind2_Click(object sender, EventArgs e)
        {
          try
            {
                con.Open();
                searchvalue = txtFind2.Text.Trim();
               
                SqlDataAdapter adapt = new SqlDataAdapter("select * from AllEnterpriseDetailsView  where "+searchid+"='"+searchvalue+"'", con);
                DataSet t = new DataSet();
                adapt.Fill(t,"AllEnterpriseDetailsView");
                dgvComapanyDetails2.DataSource = t;
                dgvComapanyDetails2.DataMember = "AllEnterpriseDetailsView";
                con.Close();
            }

          catch (Exception ae)
          {
              MessageBox.Show(ae.Message);
              con.Close();
          }

        }

        private void grpFind2_Enter(object sender, EventArgs e)
        {
            disablecontrols2();
        }

        private void dgvComapanyDetails2_SelectionChanged(object sender, EventArgs e)
        {
            disablecontrols2();

            if (dgvComapanyDetails2.SelectedRows.Count > 0)
            {
                try
                {
                    byte[] img = null;
                    disableonclickdgv();
                    con.Open();
                    String imageretrivequery = "select * from Companyimage where ent_id='" + dgvComapanyDetails2.SelectedRows[0].Cells[0].Value.ToString().Trim() + "'";
                    SqlCommand comm = new SqlCommand(imageretrivequery, con);
                    SqlDataReader reader = comm.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        img = (byte[])(reader[1]);
                        if (img == null)
                        {
                            pictureComapany2.ImageLocation="C:\\Users\\GANESH\\documents\\visual studio 2010\\Projects\\GoldenTechSolution\\GoldenTechSolution\\Resources\\Koala.jpg";
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            pictureComapany2.Image = Image.FromStream(ms);
                            con.Close();
                        }
                    }

                    else
                    {
                         pictureComapany2.ImageLocation="C:\\Users\\GANESH\\documents\\visual studio 2010\\Projects\\GoldenTechSolution\\GoldenTechSolution\\Resources\\Koala.jpg";
                    }
                    con.Close();
                    {
                        txtCompanyId2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[0].Value.ToString().Trim();
                        txtCompanyName2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[1].Value.ToString().Trim();
                        txtContactNumber.Text = dgvComapanyDetails2.SelectedRows[0].Cells[2].Value.ToString().Trim();
                        txtAlternateNumber2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[3].Value.ToString().Trim();
                        txtEmailAddress2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[4].Value.ToString().Trim();
                        txtDescription2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[5].Value.ToString().Trim();



                    }

                    {
                        txtCity2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[6].Value.ToString().Trim();
                        txtState2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[7].Value.ToString().Trim();
                        txtPincode2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[8].Value.ToString().Trim();
                        txtLandmark2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[9].Value.ToString().Trim();
                        txtStreet2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[10].Value.ToString().Trim();
                        txtRoomNo2.Text = dgvComapanyDetails2.SelectedRows[0].Cells[11].Value.ToString().Trim();





                    }

                    if (dgvComapanyDetails2.SelectedRows[0].Cells[12].Value.ToString() == "supplier")
                        chkSupplier2.Checked = true;
                    else
                        chkSupplier2.Checked = false;

                    if (dgvComapanyDetails2.SelectedRows[0].Cells[13].Value.ToString() == "customer")
                        chkCustomer2.Checked = true;
                    else
                        chkCustomer2.Checked = false;

                    if (dgvComapanyDetails2.SelectedRows[0].Cells[14].Value.ToString() == "bank")
                        chkBank2.Checked = true;
                    else
                        chkBank2.Checked = false;
                    if (dgvComapanyDetails2.SelectedRows[0].Cells[15].Value.ToString() == "shop")
                        chkShop2.Checked = true;
                    else
                        chkShop2.Checked = false;

                }
                catch (Exception ae)
                {
                    MessageBox.Show("in selectionchanged");
                    con.Close();
                }

            }
        }

        private void linkChooseImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
            openFileDialogImageCompany.ShowDialog();
            openFileDialogImageCompany.Title= "Choose the image";
            openFileDialogImageCompany.Filter = "*.Bitmap|*.bmp|*.jpeg|*.jpg";
           openFileDialogImageCompany.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures";
            //if (openFileDialogImageCompany.ShowDialog() == DialogResult.OK)
            {
              imgloc = openFileDialogImageCompany.FileName;
                picboxCompany1.ImageLocation = imgloc;
            }
            

        }

        private void linklblImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialogImageCompany.ShowDialog();
            openFileDialogImageCompany.Title = "Choose the image";
          //  openFileDialogImageCompany.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures";
            if (openFileDialogImageCompany.ShowDialog() == DialogResult.OK)
            {
                imgloc2 = openFileDialogImageCompany.FileName;
                pictureComapany2.ImageLocation = imgloc2;
            }
        }

        
     
       
      

     

       
      
    

      
     
      
       

       

        

       
      
      
       
        

       
    
    }
}
