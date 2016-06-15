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
    public partial class addCustomersID : Form
    {
        public addCustomersID()
        {
            InitializeComponent();
        }

        private void addCustomersID_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goldenTechDataDataSet14.CustomerDetails' table. You can move, or remove it, as needed.
            this.customerDetailsTableAdapter.Fill(this.goldenTechDataDataSet14.CustomerDetails);

        }
    }
}
