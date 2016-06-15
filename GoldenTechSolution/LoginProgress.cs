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
    public partial class LoginProgress : Form
    {
        public LoginProgress()
        {
            InitializeComponent();
        }

        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            label1.Text = "Loading components. Please wait .....";
        }

        private void LoginProgress_Load(object sender, EventArgs e)
        {

        }
    }
}
