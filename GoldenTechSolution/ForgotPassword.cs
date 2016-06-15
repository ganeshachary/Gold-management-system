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
using System.Net.Mail;

namespace GoldenTechSolution
{
    public partial class ForgotPassword : Form
    {
        String FirstName, LastName, ValidatedUsername;
        MailMessage mail;
        SmtpClient client;
        String password = "";
        String MobileNumber = "", EmailId = "", q1 = "", q2 = "", ans1 = "", ans2 = "";
        String username = "";
        SqlConnection con;
        
        public ForgotPassword()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=GANESH-HP;Initial Catalog=GoldenTechData;Integrated Security=True");
            txtUserName.Select();
        }

        private void btnsms_Click(object sender, EventArgs e)
        {
            pnlSecurityQuestion.Visible = false;
            pnlEmail.Visible = false;
            pnlSms.Visible = true;
        }

        private void btnemail_Click(object sender, EventArgs e)
        {
            pnlSecurityQuestion.Visible = false;
            pnlEmail.Visible = true;
            pnlSms.Visible = false;
        }

        private void btnsecurityquestions_Click(object sender, EventArgs e)
        {
            pnlSecurityQuestion.Visible = true;
            pnlEmail.Visible = false;
            pnlSms.Visible = false;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            username = txtUserName.Text;
            String queryValidate = "SELECT * from Login WHERE username='" + username + "'";
            SqlCommand comm = new SqlCommand(queryValidate, con);
            con.Open();
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    // get values from database
                    FirstName = reader[0].ToString();
                    LastName = reader[1].ToString();
                    ValidatedUsername = reader[6].ToString();
                    password = reader[7].ToString();
                    MobileNumber = reader[4].ToString();
                    EmailId = reader[5].ToString();
                    q1 = reader[8].ToString();
                    q2 = reader[10].ToString();
                    ans1 = reader[9].ToString();
                    ans2 = reader[11].ToString();

                    // load values into panel controls
                    lblMobileNumber.Text = MobileNumber;
                    lblEmail.Text = EmailId;
                    lblQuestion1.Text = q1;
                    lblQuestion2.Text = q2;


                    lblStatus.Text = "Username " + username.ToUpper() + " \nhas been successfully validated. Choose the following options..";
                    grpUser.Hide();
                    pnlStatus.Visible = true;
                    pnlMain.Visible = true;
                }
            }
            else MessageBox.Show("No such user found.\nPlease enter a valid username", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String a1, r1, a2, r2;
            a1 = txtAnswer1.Text.Trim();
            r1 = txtRetype1.Text.Trim();
            a2 = txtAnswer2.Text.Trim();
            r2 = txtRetype2.Text.Trim();
            if (a1.Equals(r1) && a2.Equals(r2))
            {
                bool b1 = ans1.Trim().ToUpper().Equals(txtAnswer1.Text.ToUpper());
                bool b2 = ans2.Trim().ToUpper().Equals(txtAnswer2.Text.ToUpper());
                if (b1 && b2)
                {
                    this.Hide();
                    new ResetPassword(username).ShowDialog();
                    this.Close();
                }
                else
                {
                    if (!b1 && !b2)
                    {
                        MessageBox.Show("Please provide correct answers!");
                    }
                    else
                    {
                        if (!b1)
                        {
                            MessageBox.Show("The first answer you entered is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (!b2)
                        {
                            MessageBox.Show("The second answer you entered is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else MessageBox.Show("The values do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtRetype1_TextChanged(object sender, EventArgs e)
        {
            if (txtAnswer1.Text.Trim().ToUpper().Equals(txtRetype1.Text.Trim().ToUpper()))
            {
                lblError1.ForeColor = System.Drawing.Color.Green;
                lblError1.Text = "Matched successfully";
            }
            else
            {
                lblError1.ForeColor = System.Drawing.Color.Red;
                lblError1.Text = "Match not found";
            }
        }

        private void txtAnswer1_TextChanged(object sender, EventArgs e)
        {

            if (txtAnswer1.TextLength > 0)
            {
                txtRetype1.Enabled = true;
                if (txtAnswer1.Text.Trim().ToUpper().Equals(txtRetype1.Text.Trim().ToUpper()))
                {
                    lblError1.ForeColor = System.Drawing.Color.Green;
                    lblError1.Text = "Matched successfully";
                }
                else
                {
                    lblError1.ForeColor = System.Drawing.Color.Red;
                    lblError1.Text = "Match not found";
                }
            }
            else
            {
                txtRetype1.Clear();
                txtRetype1.Enabled = false;
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            lblError1.Text = "";
            lblError2.Text = "";
        }

        private void txtAnswer2_TextChanged(object sender, EventArgs e)
        {
            if (txtAnswer2.TextLength > 0)
            {
                txtRetype2.Enabled = true;
                if (txtAnswer2.Text.Trim().ToUpper().Equals(txtRetype2.Text.Trim().ToUpper()))
                {
                    lblError2.ForeColor = System.Drawing.Color.Green;
                    lblError2.Text = "Matched successfully";
                }
                else
                {
                    lblError2.ForeColor = System.Drawing.Color.Red;
                    lblError2.Text = "Match not found";
                }
            }
            else
            {
                txtRetype2.Clear();
                txtRetype2.Enabled = false;
            }
        }

        private void txtRetype2_TextChanged(object sender, EventArgs e)
        {
            if (txtAnswer2.Text.Trim().ToUpper().Equals(txtRetype2.Text.Trim().ToUpper()))
            {
                lblError2.ForeColor = System.Drawing.Color.Green;
                lblError2.Text = "Matched successfully";
            }
            else
            {
                lblError2.ForeColor = System.Drawing.Color.Red;
                lblError2.Text = "Match not found";
            }
        }

        private void btnSendSms_Click(object sender, EventArgs e)
        {
            String Message="Dear "+FirstName+" "+LastName+",\n\t\tWe have received a request for password recovery from your username: '"+ValidatedUsername+"'. Password is meant to be kept concealed and not disclosed to anybody.\n\nYour password is "+password+".\nRegards,\nSrinivas and Ganesh.";
            try
            {
                WebClient client = new WebClient();
                // String baseurl = "http://api.clickatell.com/http/sendmsg?user=psganesh&password=psganesh2014&api_id=3460754&to=08080593361&text=ganesh hi";
                String baseurl = "http://api.clickatell.com/http/sendmsg?user=psganesh&password=psganesh2014&api_id=3465289&to='91" + MobileNumber + "'&text='" + Message + "'";
                client.OpenRead(baseurl);
                MessageBox.Show("Succesfully sent to " + MobileNumber);
                new LoginForm().CheckBalance();
                this.Dispose();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.ToString());
            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            
            String Message = "Dear " + FirstName + " " + LastName + ",\n\t\tWe have received a request for password recovery from your username: '" + ValidatedUsername + "'. Password is meant to be kept concealed and not disclosed to anybody.\n\n\nYour password is " + password + ".\nRegards,\nSrinivas and Ganesh.";
            try
            {
                mail = new MailMessage("srinivas.cherku@gmail.com", EmailId, "Password Recovery Mail", Message);
                client = new SmtpClient();
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("acharya.ganesh2@gmail.com", "psganesh2014");
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.Send(mail);
                MessageBox.Show("Mail has been succeesfully sent to "+EmailId);
                this.Dispose();
            }

            catch (SmtpFailedRecipientsException ex)
            {
                for (int i = 0; i < ex.InnerExceptions.Length; i++)
                {
                    SmtpStatusCode status = ex.InnerExceptions[i].StatusCode;

                    if (status == SmtpStatusCode.MailboxBusy ||
                        status == SmtpStatusCode.MailboxUnavailable || status == SmtpStatusCode.GeneralFailure)
                    {
                        Console.WriteLine("Delivery failed - retry later.");
                    }
                    else
                    {
                        Console.WriteLine("Failed to deliver message. Check your internet connection, email id or password",
                            ex.InnerExceptions[i].FailedRecipient);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check your internet connection or email id specified is wrong or password was wrong");
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.TextLength > 0)
            {
                btnValidate.Enabled = true;
            }
            else
            {
                btnValidate.Enabled = false;
            }
        }
    }
}
