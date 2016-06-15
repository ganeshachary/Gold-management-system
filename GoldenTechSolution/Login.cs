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
    public partial class Login : Form
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataAdapter adapt;
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUserName.Select();
            lblUserError.Text = "";
            lblPasswordError.Text = "";
            lblDateTime.Text = System.DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = System.DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate empty textboxes
            
                if (txtUserName.TextLength == 0)
                {
                    lblUserError.Text = "Username cannot be left blank.";
                }
                else
                {
                    lblUserError.Text = "";
                }
                if (txtPassword.TextLength == 0)
                {
                    lblPasswordError.Text = "Password cannot be left blank.";
                }
                else
                {
                    lblPasswordError.Text = "";
                }
                bool b = txtUserName.TextLength == 0 && txtPassword.TextLength == 0;
                if (!b)
                {
                    String UserName = txtUserName.Text.ToUpper();
                    String Password = txtPassword.Text.ToUpper();
                    //matching username and password

                    //After validatin the username and password
                    this.Hide();
                    new Master(UserName).Show();
                    
                }
        }


        public void Connect()
        {
            con = new SqlConnection("Data Source=GANESH-HP;Initial Catalog=GoldenTechData;Integrated Security=True");

        
        }

    }
}
