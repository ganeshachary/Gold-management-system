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
    public partial class ChangePassword : Form
    {
        String uname = "";
        public ChangePassword()
        {
            InitializeComponent();
        }
        
        public ChangePassword(String uname)
        {
            InitializeComponent();
            this.uname = uname;
            txtOldPassword.Select();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            String oldpass = txtOldPassword.Text;
            String newpass = txtNewPassword.Text;
            SqlConnection con = new SqlConnection("Data Source=Ganesh-Hp;Initial Catalog=GoldenTechData;Integrated Security=True");
            SqlCommand comm1 = new SqlCommand("select password from Login where username='" + uname + "'", con);
            con.Open();
            String password = comm1.ExecuteScalar().ToString();
            con.Close();
            String updateQuery = "update Login set password='" + newpass + "' where username='" + uname + "'";
            SqlCommand comm2 = new SqlCommand(updateQuery, con);
            if (txtOldPassword.TextLength != 0 && txtNewPassword.TextLength != 0)
            {
                if (password.ToUpper().Equals(oldpass.ToUpper()))
                {
                    con.Open();
                    comm2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your password has been successfully changed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Please enter correct old password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter some text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtOldPassword.TextLength > 0 && txtNewPassword.TextLength > 0 && txtReenter.TextLength > 0)
            {
                btnChangePass.Enabled = true;
            }
            else
            {
                btnChangePass.Enabled = false;
            }

            if (txtNewPassword.TextLength > 0)
            {
                txtReenter.Enabled = true;
            }
            else txtReenter.Enabled = false;
        }

        private void txtReenter_TextChanged(object sender, EventArgs e)
        {
            if (txtOldPassword.TextLength > 0 && txtNewPassword.TextLength > 0 && txtReenter.TextLength > 0)
            {
                if (txtNewPassword.Text.ToUpper().Equals(txtReenter.Text.ToUpper()))
                {
                    btnChangePass.Enabled = true;
                }
                else
                {
                    btnChangePass.Enabled = false;
                }
            }
            else
            {
                btnChangePass.Enabled = false;
            }
        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtOldPassword.TextLength > 0 && txtNewPassword.TextLength > 0 && txtReenter.TextLength > 0)
            {
                btnChangePass.Enabled = true;
            }
            else
            {
                btnChangePass.Enabled = false;
            }
        }
    }
}
