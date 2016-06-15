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
    public partial class ResetPassword : Form
    {
        String username = "";
        SqlConnection con;
        public ResetPassword(String username)
        {
            InitializeComponent();
            this.username = username;
            con = new SqlConnection("Data Source=GANESH-HP;Initial Catalog=GoldenTechData;Integrated Security=True");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtEnterPassword.TextLength == 0 || txtConfirmPassword.TextLength == 0)
            {
                MessageBox.Show("Please enter some text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtEnterPassword.Text.Trim().ToUpper().Equals(txtConfirmPassword.Text.Trim().ToUpper()))
                {
                    String updateQuery = "UPDATE Login SET password='" + txtEnterPassword.Text + "' WHERE username='" + username + "'";
                    SqlCommand comm = new SqlCommand(updateQuery, con);
                    con.Open();
                    comm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Password has been successfully reset for user " + username.ToUpper()+".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose(true);
                }
                else MessageBox.Show("Match not found.\nPlease enter matching passwords.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
