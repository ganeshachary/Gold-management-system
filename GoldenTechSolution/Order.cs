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
    public partial class Order : Form
    {
        SqlConnection con;
        int orderid=0;

        public Order()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=Ganesh-Hp;Initial Catalog=GoldenTechData;Integrated Security=True");
        }
        public Order(Form f)
        {
            InitializeComponent();
            this.MdiParent = f;
           this.Dock = DockStyle.Fill;

            con = new SqlConnection(@"Data Source=Ganesh-Hp;Initial Catalog=GoldenTechData;Integrated Security=True");
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddMoreItems_Click(object sender, EventArgs e)
        {
            //AddMoreItems a = new AddMoreItems();
          //  a.ShowDialog();
            try
            {
                SqlCommand com = new SqlCommand("INSERT INTO OrderDetails (cust_id ,bill_no,bill_amount,recieved,balance,orderdate,deliverydate,oldgold,goldrate) values('" + comboBoxCustID.SelectedValue.ToString().Trim() + "','" + txtBillNo.Text + "','" + txtTotalAmount.Text + "','" + txtRecievedAmount.Text + "','" + txtBalance + "','" + txtDate.Text + "','" + txtdeliverydate.Text + "','" + OldGoldwgt.Text + "','" + txtGoldRate.Text + "')", con);
                SqlCommand com2 = new SqlCommand("insert into OrderItemDetails (order_id,item_metal,item_karat,item_type,item_units,item_grossweight,item_netweight,description) values('" + txtOrderId.Text + "','" + comboBoxMetalType.SelectedValue.ToString().Trim() + "','" + comboBoxKarat.SelectedValue.ToString() + "','" + comboBoxType.SelectedValue.ToString() + "','" + txtUnits.Text + "','" + txtGrosswgt.Text + "','" + txtNetWgt.Text + "','" + txtDescription.Text + "')", con);
                con.Open();
                com.ExecuteNonQuery();
                com2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Previous entry Saved Add More item To same Order");
                clearonsave();
                updateorderid();
            }
            catch (Exception ae)
            {
                con.Close();
                MessageBox.Show(ae.Message);
            }
        }

        public void clearonsave()
        {
            txtBalance.Text="";
            txtTotalAmount.Text = "";
            txtRecievedAmount.Text="";
            txtDate.Text = "";
            txtDescription.Text = "";
            txtGrosswgt.Text = "";
            txtNetWgt.Text = "";
            txtdeliverydate.Text = "";
            txtUnits.Text = "";
            
        
        }

        public void  updateorderid()
        {
            try
            {


                con.Open();
                SqlCommand comm1 = new SqlCommand("select IDENT_CURRENT('OrderDetails')", con);
                SqlCommand comm2 = new SqlCommand("select * from OrderDetails", con);
                orderid = Convert.ToInt32(comm1.ExecuteScalar());
                SqlDataReader reader = comm2.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    orderid++;
                }
                txtOrderId.Text = orderid.ToString();
                con.Close();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message.ToString());
            }

        
        }
        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goldenTechDataDataSet10.OrderItemDetails' table. You can move, or remove it, as needed.
            this.orderItemDetailsTableAdapter.Fill(this.goldenTechDataDataSet10.OrderItemDetails);
            //for geting current order id
            try
            {


                con.Open();
                SqlCommand comm1 = new SqlCommand("select IDENT_CURRENT('OrderDetails')", con);
                SqlCommand comm2 = new SqlCommand("select * from OrderDetails", con);
                orderid = Convert.ToInt32(comm1.ExecuteScalar());
                SqlDataReader reader = comm2.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    orderid++;
                }
                txtOrderId.Text = orderid.ToString();
                con.Close();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message.ToString());
            }





            // TODO: This line of code loads data into the 'goldenTechDataDataSet9.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.goldenTechDataDataSet9.OrderDetails);
            // TODO: This line of code loads data into the 'goldenTechDataDataSet8.karat' table. You can move, or remove it, as needed.
            this.karatTableAdapter.Fill(this.goldenTechDataDataSet8.karat);
            // TODO: This line of code loads data into the 'goldenTechDataDataSet7.typeofitems' table. You can move, or remove it, as needed.
            this.typeofitemsTableAdapter.Fill(this.goldenTechDataDataSet7.typeofitems);
            // TODO: This line of code loads data into the 'metalTypeDataSet.metaltype' table. You can move, or remove it, as needed.
            this.metaltypeTableAdapter.Fill(this.metalTypeDataSet.metaltype);
            // TODO: This line of code loads data into the 'orderItemDetails._OrderItemDetails' table. You can move, or remove it, as needed.
            //  this.orderItemDetailsTableAdapter.Fill(this.orderItemDetails._OrderItemDetails);
            txtDate.Text = System.DateTime.Today.Date.ToString("dd-MM-yyyy");
            // TODO: This line of code loads data into the 'customerIDDataSet.CustomerDetails' table. You can move, or remove it, as needed.
            this.customerDetailsTableAdapter.Fill(this.customerIDDataSet.CustomerDetails);
            // TODO: This line of code loads data into the 'orderIDDataSet.OrderDetails' table. You can move, or remove it, as needed.
            // this.orderDetailsTableAdapter.Fill(this.orderIDDataSet.OrderDetails);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtDate.Text = dateTimePicker1.Value.ToString("dd-MM-yyyy");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("INSERT INTO OrderDetails (cust_id ,bill_no,bill_amount,recieved,balance,orderdate,deliverydate,oldgold,goldrate) values('" + comboBoxCustID.SelectedValue.ToString().Trim() + "','" + txtBillNo.Text.Trim() + "','" + txtTotalAmount.Text.Trim() + "','" + txtRecievedAmount.Text.Trim() + "','" + txtBalance.Text.Trim() + "','" + txtDate.Text.Trim() + "','" + txtdeliverydate.Text.Trim() + "','" + OldGoldwgt.Text.Trim() + "','" + txtGoldRate.Text.Trim() + "')", con);
                SqlCommand com2 = new SqlCommand("insert into OrderItemDetails (order_id,item_metal,item_karat,item_type,item_units,item_grossweight,item_netweight,description) values('"+txtOrderId.Text.Trim()+"','" + comboBoxMetalType.SelectedValue.ToString().Trim() +"','"+comboBoxKarat.SelectedValue.ToString().Trim()+ "','" + comboBoxType.SelectedValue.ToString().Trim() + "','" + txtUnits.Text.Trim() + "','" + txtGrosswgt.Text.Trim() + "','" + txtNetWgt.Text.Trim() + "','" + txtDescription.Text.Trim() + "')", con);
                con.Open();
                com.ExecuteNonQuery();
                com2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("saved successfully");
            }
            catch(Exception ae)
            {
                con.Close();
                MessageBox.Show(ae.Message);
            }
    }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txtdeliverydate.Text = dateTimePicker2.Value.ToString("dd-MM-yyyy");
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
           
            balance();
        }

        public void balance()
        {
            if (txtTotalAmount.TextLength > 0 && txtRecievedAmount.Text.Length > 0)
            {

                double amount = Convert.ToDouble(txtTotalAmount.Text.Trim());
                double recieved = Convert.ToDouble(txtRecievedAmount.Text.Trim());
                if (amount > recieved)
                {
                    txtBalance.Text = (amount - recieved).ToString();
                }
                else
                {
                    txtBalance.Text = "";
                }
            }
        }

        private void txtRecievedAmount_TextChanged(object sender, EventArgs e)
        {
            balance();
        }

        private void btnCancelOrders_Click(object sender, EventArgs e)
        {
            txtBalance.Text = "";
            txtTotalAmount.Text = "";
            txtRecievedAmount.Text = "";
            txtDate.Text = "";
            txtDescription.Text = "";
            txtGrosswgt.Text = "";
            txtNetWgt.Text = "";
            txtdeliverydate.Text = "";
            txtUnits.Text = "";
            comboBoxCustID.Text = "";
            txtBillNo.Text = "";
            txtGoldRate.Text = "";
            OldGoldwgt.Text = "";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        


    }
}
