namespace GoldenTechSolution
{
    partial class SMSapplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contactnumberDataSet = new GoldenTechSolution.ContactnumberDataSet();
            this.customerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDetailsTableAdapter = new GoldenTechSolution.ContactnumberDataSetTableAdapters.CustomerDetailsTableAdapter();
            this.goldenTechDataDataSet13 = new GoldenTechSolution.GoldenTechDataDataSet13();
            this.customerNumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_numbersTableAdapter = new GoldenTechSolution.GoldenTechDataDataSet13TableAdapters.customer_numbersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.contactnumberDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNumbersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.customerNumbersBindingSource;
            this.listBox1.DisplayMember = "number";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(42, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "number";
            // 
            // contactnumberDataSet
            // 
            this.contactnumberDataSet.DataSetName = "ContactnumberDataSet";
            this.contactnumberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerDetailsBindingSource
            // 
            this.customerDetailsBindingSource.DataMember = "CustomerDetails";
            this.customerDetailsBindingSource.DataSource = this.contactnumberDataSet;
            // 
            // customerDetailsTableAdapter
            // 
            this.customerDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // goldenTechDataDataSet13
            // 
            this.goldenTechDataDataSet13.DataSetName = "GoldenTechDataDataSet13";
            this.goldenTechDataDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerNumbersBindingSource
            // 
            this.customerNumbersBindingSource.DataMember = "customer numbers";
            this.customerNumbersBindingSource.DataSource = this.goldenTechDataDataSet13;
            // 
            // customer_numbersTableAdapter
            // 
            this.customer_numbersTableAdapter.ClearBeforeFill = true;
            // 
            // SMSapplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 400);
            this.Controls.Add(this.listBox1);
            this.Name = "SMSapplication";
            this.Text = "SMSapplication";
            this.Load += new System.EventHandler(this.SMSapplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactnumberDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNumbersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private ContactnumberDataSet contactnumberDataSet;
        private System.Windows.Forms.BindingSource customerDetailsBindingSource;
        private ContactnumberDataSetTableAdapters.CustomerDetailsTableAdapter customerDetailsTableAdapter;
        private GoldenTechDataDataSet13 goldenTechDataDataSet13;
        private System.Windows.Forms.BindingSource customerNumbersBindingSource;
        private GoldenTechDataDataSet13TableAdapters.customer_numbersTableAdapter customer_numbersTableAdapter;
    }
}