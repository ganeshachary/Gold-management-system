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
    public partial class SMSapplication : Form
    {
        public SMSapplication()
        {
            InitializeComponent();
        }

        private void SMSapplication_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goldenTechDataDataSet13.customer_numbers' table. You can move, or remove it, as needed.
            this.customer_numbersTableAdapter.Fill(this.goldenTechDataDataSet13.customer_numbers);
            // TODO: This line of code loads data into the 'contactnumberDataSet.CustomerDetails' table. You can move, or remove it, as needed.
            this.customerDetailsTableAdapter.Fill(this.contactnumberDataSet.CustomerDetails);

        }
    }
}
