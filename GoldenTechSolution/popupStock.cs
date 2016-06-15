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
    public partial class popupStock : Form
    {
        int id = 0;
        Bill b;
        public popupStock()
        {
            InitializeComponent();
        }
        public popupStock(Bill b)
        {
            InitializeComponent();
            this.b = b;
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
                    stockDetailsBindingSource.Filter = "item_id=" + id;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    stockDetailsBindingSource.Filter = "item_category LIKE '" + textBox1.Text + "%'";
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    stockDetailsBindingSource.Filter = "item_metal LIKE '" + textBox1.Text + "%'";
                }
            }
            else
            {
                stockDetailsBindingSource.RemoveFilter();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;      
        }

        private void popupStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goldenTechDataDataSet18.StockDetails' table. You can move, or remove it, as needed.
            this.stockDetailsTableAdapter.Fill(this.goldenTechDataDataSet18.StockDetails);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = System.Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            b.txtStockId.Text = id.ToString();
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
