using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.IO;

namespace GoldenTechSolution
{
    public partial class LoginForm : Form
    {
    public String admin;
       public  int Accountcounter = 0;
       public int Actioncounter = 0;
       string Username = "";
       ForgotPassword f1;
       EmployeeDetails f2;
       CustomerDetails f3;
       Users f4;
       Company f5;
       Order f6;
       OrderAndItemUpdate f7;
       Bill f8;
       GoldenTech.StockDetails f9;
       
      
       

        public void CheckBalance()
        {
            //LoginProgress lp = null;
            try
            {
                WebClient client = new WebClient();
                Stream data;
                StreamReader reader;
                String baseurl = "http://api.clickatell.com/http/getbalance?api_id=3465289&user=psganesh&password=psganesh2014";
                data = client.OpenRead(baseurl);
                reader = new StreamReader(data);
                lblSmsBalance.ForeColor = Color.Green;
                //lp= new LoginProgress();
                //lp.LoginTimer.Start();
                //lp.Show();
                lblSmsBalance.Text = "SMS Balance: " + reader.ReadToEnd();
                //lp.LoginTimer.Stop();
                //lp.Close();
            }
            catch (Exception ea)
            {
                lblSmsBalance.ForeColor = Color.Red;
                lblSmsBalance.Text = "No internet connection!";
                //lp.LoginTimer.Stop();
                //lp.Close();

            }
        }
        public LoginForm()
        {
            InitializeComponent();
            
        }

   
       

       
      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String UserName = txtUserName.Text;
            String Password = txtPassword.Text;
            
            if (UserName.Equals("") || Password.Equals(""))
            {
                MessageBox.Show("You cannot leave the textboxes empty!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=GANESH-HP;Initial Catalog=GoldenTechData;Integrated Security=True");
                    SqlCommand comm = new SqlCommand("SELECT * from Login WHERE username='" + UserName + "'", con);
                    con.Open();
                    SqlDataReader reader = comm.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["password"].ToString().Equals(Password))
                        {
                            admin=reader[15].ToString();
                            Username = UserName;// store the username
                            lblWelcome.Text = "Welcome " + UserName.ToUpper();
                            toolStripMasterControl.Enabled = true;
                            PnlLogin.Visible = false;
                            //MessageBox.Show(admin.ToString());
                            adminvalidate();
                            pnlLogout.Visible = true;
                           CheckBalance();
                        }
                        else MessageBox.Show("Incorrect password!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("No such user found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                catch (SystemException se)
                {
                    MessageBox.Show(se.Message);
                }
                
            }
            
        }

      

    public void adminvalidate()
    {
    if(admin=="admin")
    {
        usersToolStripMenuItem.Enabled= true;
       usersToolStripMenuItem.ToolTipText = "User Details";

        btnReports.Enabled = true;
    
    }
    else
    {
    usersToolStripMenuItem.Enabled=false;
        usersToolStripMenuItem.ToolTipText="only admin Have Access";

        btnReports.Enabled = false;
    }
    
    }

      
        private void Datetime_Tick(object sender, EventArgs e)
        {
          lbldatetime.Text=System.DateTime.Now.ToString();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lbldatetime.Text = System.DateTime.Now.ToString();
            //CheckBalance();
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            
            new Stocks(this).Show();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form[] f = this.MdiChildren;
            foreach (Form f1 in f)
            {
                f1.Close();
            }
            toolStripMasterControl.Enabled = false;
            pnlLogout.Visible = false;
            txtUserName.Select();
            txtPassword.Text = "";
            txtUserName.Text = "";
            PnlLogin.Visible = true;
            MessageBox.Show("You have successfully logged out", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linklblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
           new ForgotPassword().ShowDialog();
        }

      

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddWorkers_Click(object sender, EventArgs e)
        {
             int tabindex = 0;
            bool state = false;
            foreach(Form f in Application.OpenForms)
            {
                if (f.Name == "EmployeeDetails")
                {
                    state = true;
                    f2.Activate();

                }
            }
                if(state==false)
                {
                    f2 = new EmployeeDetails(this, tabindex);
                    f2.MdiParent = this;
                    f2.Dock = DockStyle.Fill;
                    f2.Show();

                
                }
            
            
           
            //new EmployeeDetails(this, tabindex).Show();
          
        }

        private void btnChangeWorkers_Click(object sender, EventArgs e)
        {
            int tabindex = 1;
            new EmployeeDetails(this, tabindex).Show();
           
        }

        private void btnAddCompanies_Click(object sender, EventArgs e)
        {
            Form[] f = this.MdiChildren;
            foreach (Form f1 in f)
            {
                f1.Close();
            } 
            
            int tabindex = 0;
            new Company(this,tabindex).Show();
           
        }

        private void btnAddCustomers_Click(object sender, EventArgs e)
        {
            new CustomerDetails(this, 0).Show();
           
        }

        private void btnChangeCustomers_Click(object sender, EventArgs e)
        {
            new CustomerDetails(this, 1).Show();
            
        }

        private void btnChangeCompanies_Click(object sender, EventArgs e)
        {
            int tabindex = 1;
            new Company(this, tabindex).Show();
           
        }

      
      

       

        private void MouseLeaveHandler(object sender, EventArgs e)
        {
            if (sender == btnAccount)
            {
                //btnAccount.BackColor = Color.White;
                btnAccount.ForeColor = Color.Black ;
                //menuStripAccounts.Visible = false;

            }
            else if (sender == btnAction)
            {
                //btnAction.BackColor = Color.white;
                btnAction.ForeColor = Color.Black;
               // menuStripAction.Visible = false;

            }
            else if (sender == btnTools)
            {
               // btnTools.BackColor = Color.DimGray;
                btnTools.ForeColor = Color.Black;
              
            }


            else if (sender == btnReports)
            {
                //btnReports.BackColor = Color.DimGray;
                btnReports.ForeColor = Color.Black;
                //menuStripReport.Visible = false;
            }
            //else if (sender == btnDashBoard)
            //{
            //    //btnSummary.BackColor = Color.DimGray;
            //    btnDashBoard.ForeColor = Color.Black;
            //}
           
            else if (sender == btnLogin)
            {
                //btnFile.BackColor = Color.DimGray;
                btnLogin.ForeColor = Color.Black;

            }
            else if (sender == btnLogout)
            {
                //btnFile.BackColor = Color.DimGray;
                btnLogout.ForeColor = Color.Black;
            }
            else if (sender == linklblForgotPassword)
            {
                //btnFile.BackColor = Color.DimGray;
                linklblForgotPassword.LinkColor = Color.Blue
                    ;
            }
            else if (sender == linkLabellogout)
            {
                //btnFile.BackColor = Color.DimGray;
                linkLabellogout.LinkColor = Color.Blue;
            }
            
        }

        private void MouseEnterHandler(object sender, EventArgs e)
        {
            if (sender == btnAccount)
            {
                //btnAccount.BackColor = Color.;
                btnAccount.ForeColor = Color.Red;
                menuStripAccounts.Visible = true;
                menuStripAction.Visible = false;
                menuStripReport.Visible = false;
                
            }

            else if (sender == btnTools)
            {
              //btnTools.BackColor = Color.LightGray;
                btnTools.ForeColor = Color.Red;
                menuStriptool.Visible = true;
                menuStripReport.Visible = false;
                menuStripAction.Visible = false;
                menuStripAccounts.Visible = false;

            }

            else if (sender == btnAction)
            {
              //  btnAccount.BackColor = Color.LightGray;
                btnAction.ForeColor = Color.Red;
                menuStripAction.Visible = true;
                menuStripAccounts.Visible = false; ;
                //menuStripAction.Visible = false;
                menuStripReport.Visible = false;
                menuStriptool.Visible = false;
            }

            else if (sender == btnReports)
            {
                // btnReports.BackColor = Color.LightGray;
                btnReports.ForeColor = Color.Red;
                menuStripReport.Visible = true;
                menuStripAccounts.Visible = false;
                menuStripAction.Visible = false;
                //menuStripReport.Visible = false;
                menuStriptool.Visible = false;
            }
            //else if (sender == btnDashBoard)
            //{
            //    // btnSummary.BackColor = Color.LightGray;
            //    btnDashBoard.ForeColor = Color.Red;
            //}
           
          
            else if (sender == linklblForgotPassword)
            {
                //btnFile.BackColor = Color.DimGray;
                linklblForgotPassword.LinkColor = Color.Green;
            }
            else if (sender == linkLabellogout)
            {
                //btnFile.BackColor = Color.DimGray;
                linkLabellogout.LinkColor = Color.Green;
            }
        }

        private void btnclick(object sender, EventArgs e)
        {
            if (sender == btnAction)
            {
                menuStripAction.Visible = true;

            }
            else if(sender==btnAccount)
            {
                menuStripAccounts.Visible = true;
            }
            else if (sender == btnReports)
            {
                menuStripReport.Visible = true;
            }
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

          //  int tabindex = 0;
            bool state = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Users")
                {
                    state = true;
                    f4.tabCreateNewAccount.SelectTab("tabPage1");
                    f4.Activate();

                }
            }
            if (state == false)
            {
                f4 = new Users(this, 0);
                f4.MdiParent = this;
                f4.Dock = DockStyle.Fill;
                f4.Show();


            }
          
            //new Users(this, tabindex).Show();

           
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int tabindex = 1;
            bool state = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Users")
                {
                    state = true;
                    f4.tabCreateNewAccount.SelectTab("tabPage2");
                    f4.Activate();

                }
            }
            if (state == false)
            {
                f4 = new Users(this, 1);
                f4.MdiParent = this;
                f4.Dock = DockStyle.Fill;
                f4.Show();


            }
            //new Users(this, tabindex).Show();

           
        }

        private void dealersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewDealerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool state = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Company")
                {
                    state = true;
                    f5.tabCompany.SelectTab("Add");
                    f5.Activate();

                }
            }
            if (state == false)
            {
                f5 = new Company(this, 0);
                f5.MdiParent = this;
                f5.Dock = DockStyle.Fill;
                f5.Show();


            }
            //Form[] f = this.MdiChildren;
            //foreach (Form f1 in f)
            //{
            //    f1.Close();
            //} int tabindex = 0;
            //new Company(this, tabindex).Show();
           
        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            bool state = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Company")
                {
                    state = true;
                    f5.tabCompany.SelectTab("tabPage2");
                    f5.Activate();

                }
            }
            if (state == false)
            {
                f5 = new Company(this, 1);
                f5.MdiParent = this;
                f5.Dock = DockStyle.Fill;
                f5.Show();


            }
            //int tabindex = 1;
            //new Company(this, tabindex).Show();
            
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new Order(this).Show();
            bool state = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Order")
                {
                    state = true;
                    //f6.tabCompany.SelectTab("Add");
                    f6.Activate();

                }
            }
            if (state == false)
            {
                f6 = new Order(this);
                f6.MdiParent = this;
                f6.Dock = DockStyle.Fill;
                f6.Show();


            }
        }

        private void updateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // new OrderAndItemUpdate(this).Show();
            bool state = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "OrderAndItemUpdate")
                {
                    state = true;
                    //f6.tabCompany.SelectTab("Add");
                    f7.Activate();

                }
            }
            if (state == false)
            {
                f7 = new OrderAndItemUpdate(this);
                f7.MdiParent = this;
                f7.Dock = DockStyle.Fill;
                f7.Show();


            }
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new CustomerDetails(this, 0).Show();
           // int tabindex = 0;
            bool state = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "CustomerDetails")
                {
                    state = true;
                    f3.tabCustomers.SelectTab("tabCustomerAdd");
                    f3.Activate();

                }
            }
            if (state == false)
            {
                f3 = new CustomerDetails(this, 0);
                f3.MdiParent = this;
                f3.Dock = DockStyle.Fill;
                f3.Show();


            }
            
           
        }

        private void btnViewMyAccount_Click(object sender, EventArgs e)
        {

        }

        private void addNewWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tabindex = 0;
            bool state = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "EmployeeDetails")
                {
                    state = true;
                    f2.tabEmployeeDetails.SelectTab("tabPage1");
                    f2.Activate();
                   

                }
            }
            if (state == false)
            {
                f2 = new EmployeeDetails(this, tabindex);
                f2.MdiParent = this;
                f2.Dock = DockStyle.Fill;
                f2.Show();


            }



            //new EmployeeDetails(this, tabindex).Show();
          
           // int tabindex = 0;
           // new EmployeeDetails(this, tabindex).Show();
           
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            int tabindex = 1;
            bool state = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "EmployeeDetails")
                {
                    state = true;
                    f2.tabEmployeeDetails.SelectTab("tabPage2");
                    f2.Activate();
                 

                }
            }
            if (state == false)
            {
                f2 = new EmployeeDetails(this, tabindex);
                f2.MdiParent = this;
                f2.Dock = DockStyle.Fill;
                f2.Show();


            }
           // new EmployeeDetails(this, tabindex).Show();
            
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            //new CustomerDetails(this, 1).Show();
           // int tabindex = 0;
            bool state = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "CustomerDetails")
                {
                    state = true;
                    f3.tabCustomers.SelectTab("tabCustomerChange");
                    f3.Activate();

                }
            }
            if (state == false)
            {
                f3 = new CustomerDetails(this,1);
                f3.MdiParent = this;
                f3.Dock = DockStyle.Fill;
                f3.Show();


            }
            
           
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void systemCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void linkLabellogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword cp = new ChangePassword(this.Username);
            cp.Show();
        }

        private void workersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool state = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "StockDetails")
                {
                    state = true;
                    //f3.tabCustomers.SelectTab("tabCustomerChange");
                    f9.Activate();

                }
            }
            if (state == false)
            {
                f9 = new GoldenTech.StockDetails(); ;
                f9.MdiParent = this;
                f9.Dock = DockStyle.Fill;
                f9.Show();


            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            DashBoard d= new DashBoard();
            d.MdiParent = this;
            d.Dock = DockStyle.Fill;
            d.Show();
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool state = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Bill")
                {
                    state = true;
                    //f3.tabCustomers.SelectTab("tabCustomerChange");
                    f8.Activate();

                }
            }
            if (state == false)
            {
                f8 = new Bill(); ;
                f8.MdiParent = this;
                f8.Dock = DockStyle.Fill;
                f8.Show();


            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            menuStripReport.Visible = false;
            menuStripAction.Visible = false;
            menuStripAccounts.Visible = false;
            menuStriptool.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbldatetime_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cityWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerCityForm ccf = new CustomerCityForm();
            ccf.ShowDialog();
        }

        private void typeWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerTypeReport ctp = new CustomerTypeReport();
            ctp.ShowDialog();
        }

        private void categoryWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockCategoryReportResult srr = new StockCategoryReportResult();
            srr.ShowDialog();
        }

        

        

       
      

    
    

      

       

       

        

       
        
      

    

      
      
        
       
        
     
       

        

       

       

     

      

      


       

       

       
    }
}
