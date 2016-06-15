using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GoldenTechSolution
{
    public partial class popupCustomer : Form
    {
        int id = 0;
        Bill b;
        public popupCustomer()
        {
            InitializeComponent();
        }
        public popupCustomer(Bill b)
        {
            InitializeComponent();
            this.b = b;
        }

        private void popupCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goldenTechDataDataSet17.CustomerDetails' table. You can move, or remove it, as needed.
            this.customerDetailsTableAdapter.Fill(this.goldenTechDataDataSet17.CustomerDetails);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox1.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = System.Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            b.txtCustomer.Text = id.ToString();
            Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox1.TextLength > 0)
            {

                if (comboBox1.SelectedIndex == 0)
                {
                    
                    try
                    {
                        id = System.Convert.ToInt32(textBox1.Text);
                    }
                    catch (SystemException se)
                    {
                        MessageBox.Show("Id should be an integer");
                    }
                    customerDetailsBindingSource.Filter = "cust_id =" + id;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    customerDetailsBindingSource.Filter = "cust_name LIKE '" + textBox1.Text + "%'";
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    customerDetailsBindingSource.Filter = "cust_contact_no LIKE '" + textBox1.Text + "%'";
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    customerDetailsBindingSource.Filter = "cust_email LIKE '" + textBox1.Text + "%'";
                }
            }
            else {
                customerDetailsBindingSource.RemoveFilter();
            }
        }
    }
}
