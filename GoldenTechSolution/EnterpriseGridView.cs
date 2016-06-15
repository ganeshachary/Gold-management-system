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
    public partial class EnterpriseGridView : Form
    {
        int id = 0;
        public EnterpriseGridView()
        {
            InitializeComponent();
        }
        GoldenTech.StockDetails sd = null;
        public EnterpriseGridView(GoldenTech.StockDetails sd)
        {
            InitializeComponent();
            this.sd = sd;
        }

        private void EnterpriseGridView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enterpriseDetailsDataSet.EnterpriseDetails' table. You can move, or remove it, as needed.
            this.enterpriseDetailsTableAdapter.Fill(this.enterpriseDetailsDataSet.EnterpriseDetails);
            // TODO: This line of code loads data into the 'enterpriseGridViewDataSet.AllEnterpriseDetailsView' table. You can move, or remove it, as needed.
           // this.allEnterpriseDetailsViewTableAdapter.Fill(this.enterpriseGridViewDataSet.AllEnterpriseDetailsView);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex>=0)
            {
                textBox1.Enabled = true;
            }
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
                        MessageBox.Show("Value of ID should be an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    enterpriseDetailsBindingSource.Filter = "ent_id=" + id;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    enterpriseDetailsBindingSource.Filter = "ent_name LIKE '" + textBox1.Text.Trim() + "%'";

                }
            if (comboBox1.SelectedIndex == 2)
            {
                enterpriseDetailsBindingSource.Filter = "ent_contact_no LIKE '" + textBox1.Text.Trim() + "%' OR ent_alt_contact_no LIKE '" + textBox1.Text.Trim() + "%'";
                  enterpriseDetailsBindingSource.Filter = "ent_alt_contact_no LIKE '" + textBox1.Text + "%'";

            }
            if (comboBox1.SelectedIndex == 2)
            //{

                //    enterpriseDetailsBindingSource.Filter = "ent_alt_contact_no LIKE '" + textBox1.Text + "%'";
                //}
                if (comboBox1.SelectedIndex == 3)
                {

                    enterpriseDetailsBindingSource.Filter = "ent_email_id LIKE '" + textBox1.Text.Trim() + "%'";
                }
            }
            else {
                enterpriseDetailsBindingSource.RemoveFilter();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count> 0)
            {
                sd.txtEnterpriseId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                sd.cmbEnterpriseName.SelectedItem = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
            Dispose();
        }
    }
}
