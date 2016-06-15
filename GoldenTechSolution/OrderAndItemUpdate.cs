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
    public partial class OrderAndItemUpdate : Form
    {
        public OrderAndItemUpdate()
        {
            InitializeComponent();
        }
        public OrderAndItemUpdate(Form f)
        {
            InitializeComponent();
            this.MdiParent = f;
            this.Dock = DockStyle.Fill;
        }

        private void OrderAndItemUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goldenTechDataDataSet12.OrderItemDetails' table. You can move, or remove it, as needed.
            this.orderItemDetailsTableAdapter.Fill(this.goldenTechDataDataSet12.OrderItemDetails);
            // TODO: This line of code loads data into the 'goldenTechDataDataSet11.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.goldenTechDataDataSet11.OrderDetails);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMetalType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    txtOrderId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim();
                    txtCustId.Text= dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();
                    txtBillNo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim();
                    txtTotalAmount.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString().Trim();
                    txtRecievedAmount.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Trim();
                    txtBalance.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString().Trim();
                    txtDate.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString().Trim(); ;
                    txtdeliverydate.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString().Trim();
                    OldGoldwgt.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString().Trim(); 
                    txtGoldRate.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString().Trim(); 

                }
                    
                
            }
            catch (Exception ae)
            {
              
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                  
                    txtMetal.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString().Trim();
                   txtKarat.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString().Trim();
                    txtType.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString().Trim();
                    txtUnits.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString().Trim();
                    txtGrosswgt.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString().Trim(); ;
                   txtNetWgt.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString().Trim();
                   txtDesCirption.Text= dataGridView2.SelectedRows[0].Cells[8].Value.ToString().Trim(); ;

                }


            }
            catch (Exception ae)
            {

            }
        }
    }
}
