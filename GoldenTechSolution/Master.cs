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
    public partial class Master : Form
    {
        public static String LoggedUsername = "";
        public Master(String Uname)
        {
            InitializeComponent();
            LoggedUsername = Uname;
        }
        //for testing purpose
        public Master()
        {
            InitializeComponent();
        }

        private void detailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new CustomerDetails().Show();

        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void Master_Load(object sender, EventArgs e)
        {

        }

     
       

       
        
      

      

      

        
      

       

      
    }
}
