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
    public partial class Bill : Form
    {
        int bill_id;
        double netweigh = 0;
        SqlConnection con;
        double totalcost=0;
        double downpayemnt = 0;
        public Bill()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=Ganesh-Hp;Initial Catalog=GoldenTechData;Integrated Security=True");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void DisplayIdentity()
        {
            SqlCommand BillCommand = new SqlCommand("SELECT IDENT_CURRENT('salebill')", con);
            SqlCommand CheckItemRows = new SqlCommand("SELECT * from salebill", con);
            con.Open();
            // set bill id
            bill_id = System.Convert.ToInt32(BillCommand.ExecuteScalar());
            SqlDataReader rd1 = CheckItemRows.ExecuteReader();
            if (rd1.HasRows)
            {
                bill_id++;
            }
            con.Close();
            txtBillNo.Text = bill_id.ToString();
        }
        private void Bill_Load(object sender, EventArgs e)
        {
            txtbilldate.Text = System.DateTime.Today.Date.ToString();
            // TODO: This line of code loads data into the 'goldenTechDataDataSet19.StockForBill' table. You can move, or remove it, as needed.
            this.stockForBillTableAdapter.Fill(this.goldenTechDataDataSet19.StockForBill);
            // TODO: This line of code loads data into the 'goldenTechDataDataSet16.CustomerDetails' table. You can move, or remove it, as needed.
            this.customerDetailsTableAdapter.Fill(this.goldenTechDataDataSet16.CustomerDetails);
            // TODO: This line of code loads data into the 'goldenTechDataDataSet15.StockDetails' table. You can move, or remove it, as needed.
            this.stockDetailsTableAdapter.Fill(this.goldenTechDataDataSet15.StockDetails);
            DisplayIdentity();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtStockId_DoubleClick(object sender, EventArgs e)
        {
            popupStock stck = new popupStock(this);
            stck.ShowDialog();
        }

        private void txtCustomer_DoubleClick(object sender, EventArgs e)
        {
            popupCustomer cst = new popupCustomer(this);
            cst.ShowDialog();
        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            bool state = false;
            for (int i = 0; i < dgvBillItems.Rows.Count-1; i++)
            {
                if (dgvBillItems.Rows[i].Cells[0].Value.ToString().Trim().Equals(txtStockId.Text.Trim()))
                {
                    MessageBox.Show("Item already exists in the Bill list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    state = true;
                    break;

                }



            }
            if(state==false)
            {
                int id = System.Convert.ToInt32(txtStockId.Text);
                String q = "select * from StockDetails WHERE item_id=" + id;
                SqlCommand command = new SqlCommand(q, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    con.Close();
                    String query = "INSERT into StockForBill SELECT * from StockDetails WHERE item_id=" + id;
                    SqlCommand comm = new SqlCommand(query, con);
                    con.Open();
                    comm.ExecuteNonQuery();
                    con.Close();
                    this.stockForBillTableAdapter.Fill(this.goldenTechDataDataSet19.StockForBill);
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Stock Id doesnt exist!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            
            
          
        }

        private void txtStockId_TextChanged(object sender, EventArgs e)
        {
            if (txtStockId.TextLength == 0)
            {
                btnAddToBill.Enabled = false;
            }
            else btnAddToBill.Enabled = true;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            int id = System.Convert.ToInt32(dgvBillItems.SelectedRows[0].Cells[0].Value);
            String query = "delete from StockForBill where item_id=" + id;
            SqlCommand comm = new SqlCommand(query, con);
            con.Open();
            comm.ExecuteNonQuery();
            con.Close();
            this.stockForBillTableAdapter.Fill(this.goldenTechDataDataSet19.StockForBill);
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomer.TextLength > 0)
            {
                con.Open();
                string query = "select * from CustomerDetails where cust_id=" + txtCustomer.Text;
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader r = com.ExecuteReader();
                r.Read();
                if (r.HasRows)
                {
                    String id = r[0].ToString();
                    String name = r[1].ToString();
                    string conatct = r[5].ToString() + r[6].ToString();
                    string email = r[7].ToString();
                    lblCustomerDetails.ForeColor = Color.Green;
                    lblCustomerDetails.Text = "Customer Details \nID:" + id + "\nName:" + name + "\nContact:" + conatct + "\nemail:" + email;
                    con.Close();
                }
                else
                {
                    lblCustomerDetails.ForeColor = Color.Red;
                    lblCustomerDetails.Text = "Customer Id Does not Exist";
                    con.Close();
                }
               //con.Close();


            }
            else
            {
                lblCustomerDetails.Text = "";
            
            }
        }

        private void txtCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsNumber(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Number Only !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);


            }
        }

        private void txtStockId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsNumber(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Number Only !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void dgvBillItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Cancel_All_Items()
        {
            String query = "DELETE FROM StockForBill";
            SqlCommand comm = new SqlCommand(query, con);
            con.Open();
            comm.ExecuteNonQuery();
            con.Close();
            Dispose();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to cancel this transaction?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr.ToString().ToUpper().Equals("YES"))
            {
                Cancel_All_Items();
            }

        }

        public void calculate()
        {
            //bool state = false;

            for (int i = 0; i < dgvBillItems.Rows.Count - 1; i++)
            {
                netweigh = System.Convert.ToDouble(dgvBillItems.Rows[i].Cells[4].Value.ToString()) + netweigh;




            }
            if (txtpergramcost.TextLength > 0 && txtWorkingCharge.TextLength > 0)
            {
                double pergram = System.Convert.ToDouble(txtpergramcost.Text);
                double workingcharge = System.Convert.ToDouble(txtWorkingCharge.Text);
                txtotalcost.Text = (pergram * netweigh + workingcharge).ToString();

            }
            else if(txtpergramcost.TextLength == 0 || txtWorkingCharge.TextLength == 0)
            {
                txtotalcost.Text = "";
            }

        }
        public void netweight()
        {

            for (int i = 0; i < dgvBillItems.Rows.Count - 1; i++)
            {
                netweigh = System.Convert.ToDouble(dgvBillItems.Rows[i].Cells[4].Value.ToString()) + netweigh;




            }
        }
        private void txtpergramcost_TextChanged(object sender, EventArgs e)
        {
            netweigh = 0;
            calculate();
        }

        private void txtWorkingCharge_TextChanged(object sender, EventArgs e)
        {
            netweigh = 0;
            calculate();
        }

        public void calculatebalance()
        {
            
        if(txtotalcost.TextLength>0 && txtdownpayment.TextLength>0 )
        {
            totalcost = System.Convert.ToDouble(txtotalcost.Text);
            downpayemnt = System.Convert.ToDouble(txtdownpayment.Text);
            txtBalance.Text = System.Convert.ToString(totalcost - downpayemnt);
        }
        else
            if (txtotalcost.TextLength == 0 && txtdownpayment.TextLength == 0)
            {
                txtBalance.Text = "";
            }
        }

        private void txtdownpayment_TextChanged(object sender, EventArgs e)
        {
            calculatebalance();
        }

        public void DataInsert()
        {
            String q1 = "insert into salebill(amount, downpayment, balance, date, custid) values('" + txtotalcost.Text + "','" + txtdownpayment.Text + "','" + txtBalance.Text + "','" + txtbilldate.Text + "'," + int.Parse(txtCustomer.Text) + ")";
            SqlCommand comm1 = new SqlCommand(q1, con);
            SqlCommand comm2;
            con.Open();
            comm1.ExecuteNonQuery();
            con.Close();
            String q2 = "";
            for (int i = 0; i < dgvBillItems.Rows.Count - 1; i++)
            {   
                q2 = "insert into billstock values(" + int.Parse(txtBillNo.Text) + "," + int.Parse(dgvBillItems.Rows[i].Cells[0].Value.ToString()) + ")";
                comm2 = new SqlCommand(q2, con);
                con.Open();
                comm2.ExecuteNonQuery();
                con.Close();
            }

            Cancel_All_Items();
            
            new PrintingBill(bill_id.ToString()).ShowDialog();
            
        }
        private void txtotalcost_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            emptyValidate();
            //BillPrint bp = new BillPrint(txtBillNo.Text);
            //bp.Show();
        }
        public void emptyValidate()
        {
            if (dgvBillItems.RowCount < 0)
            {
                MessageBox.Show("Select item to bill", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
        if(txtStockId.TextLength==0)
        {
            MessageBox.Show("Stock ID cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
            else if(txtCustomer.TextLength==0)
            {

                MessageBox.Show("Customer Id can not be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtpergramcost.TextLength==0)
        {
            MessageBox.Show("Pergram cost can not cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        else if(txtWorkingCharge.TextLength==0)
        {
            MessageBox.Show("working charge cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        
        }
        else if(txtotalcost.TextLength==0)
        {
            MessageBox.Show("TotalCost cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        
        }
        else if(txtdownpayment.TextLength==0)
        {
            MessageBox.Show("Downpayment cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        }
        else
            if (txtBalance.TextLength == 0)
            {
                MessageBox.Show("Balance cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            else {
                DataInsert();
            }
       
        }
        private void Bill_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cancel_All_Items();
        }

        private void txtpergramcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsNumber(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Number Only !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void txtWorkingCharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsNumber(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Number Only !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void txtotalcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsNumber(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Number Only !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void txtdownpayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsNumber(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Number Only !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsNumber(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Enter Number Only !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CustomerDetails().ShowDialog();
        }

     
    }
}
