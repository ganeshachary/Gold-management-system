namespace GoldenTechSolution
{
    partial class addCustomersID
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goldenTechDataDataSet14 = new GoldenTechSolution.GoldenTechDataDataSet14();
            this.customerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDetailsTableAdapter = new GoldenTechSolution.GoldenTechDataDataSet14TableAdapters.CustomerDetailsTableAdapter();
            this.custidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custcontactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custaltcontactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custdobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custidDataGridViewTextBoxColumn,
            this.custnameDataGridViewTextBoxColumn,
            this.custcontactnoDataGridViewTextBoxColumn,
            this.custaltcontactnoDataGridViewTextBoxColumn,
            this.custgenderDataGridViewTextBoxColumn,
            this.custdobDataGridViewTextBoxColumn,
            this.custemailDataGridViewTextBoxColumn,
            this.custageDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerDetailsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(284, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // goldenTechDataDataSet14
            // 
            this.goldenTechDataDataSet14.DataSetName = "GoldenTechDataDataSet14";
            this.goldenTechDataDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerDetailsBindingSource
            // 
            this.customerDetailsBindingSource.DataMember = "CustomerDetails";
            this.customerDetailsBindingSource.DataSource = this.goldenTechDataDataSet14;
            // 
            // customerDetailsTableAdapter
            // 
            this.customerDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // custidDataGridViewTextBoxColumn
            // 
            this.custidDataGridViewTextBoxColumn.DataPropertyName = "cust_id";
            this.custidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.custidDataGridViewTextBoxColumn.Name = "custidDataGridViewTextBoxColumn";
            this.custidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custnameDataGridViewTextBoxColumn
            // 
            this.custnameDataGridViewTextBoxColumn.DataPropertyName = "cust_name";
            this.custnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.custnameDataGridViewTextBoxColumn.Name = "custnameDataGridViewTextBoxColumn";
            this.custnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custcontactnoDataGridViewTextBoxColumn
            // 
            this.custcontactnoDataGridViewTextBoxColumn.DataPropertyName = "cust_contact_no";
            this.custcontactnoDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            this.custcontactnoDataGridViewTextBoxColumn.Name = "custcontactnoDataGridViewTextBoxColumn";
            this.custcontactnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custaltcontactnoDataGridViewTextBoxColumn
            // 
            this.custaltcontactnoDataGridViewTextBoxColumn.DataPropertyName = "cust_alt_contact_no";
            this.custaltcontactnoDataGridViewTextBoxColumn.HeaderText = "cust_alt_contact_no";
            this.custaltcontactnoDataGridViewTextBoxColumn.Name = "custaltcontactnoDataGridViewTextBoxColumn";
            this.custaltcontactnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custgenderDataGridViewTextBoxColumn
            // 
            this.custgenderDataGridViewTextBoxColumn.DataPropertyName = "cust_gender";
            this.custgenderDataGridViewTextBoxColumn.HeaderText = "cust_gender";
            this.custgenderDataGridViewTextBoxColumn.Name = "custgenderDataGridViewTextBoxColumn";
            this.custgenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custdobDataGridViewTextBoxColumn
            // 
            this.custdobDataGridViewTextBoxColumn.DataPropertyName = "cust_dob";
            this.custdobDataGridViewTextBoxColumn.HeaderText = "cust_dob";
            this.custdobDataGridViewTextBoxColumn.Name = "custdobDataGridViewTextBoxColumn";
            this.custdobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custemailDataGridViewTextBoxColumn
            // 
            this.custemailDataGridViewTextBoxColumn.DataPropertyName = "cust_email";
            this.custemailDataGridViewTextBoxColumn.HeaderText = "cust_email";
            this.custemailDataGridViewTextBoxColumn.Name = "custemailDataGridViewTextBoxColumn";
            this.custemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custageDataGridViewTextBoxColumn
            // 
            this.custageDataGridViewTextBoxColumn.DataPropertyName = "cust_age";
            this.custageDataGridViewTextBoxColumn.HeaderText = "cust_age";
            this.custageDataGridViewTextBoxColumn.Name = "custageDataGridViewTextBoxColumn";
            this.custageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addCustomersID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "addCustomersID";
            this.Text = "addCustomersID";
            this.Load += new System.EventHandler(this.addCustomersID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GoldenTechDataDataSet14 goldenTechDataDataSet14;
        private System.Windows.Forms.BindingSource customerDetailsBindingSource;
        private GoldenTechDataDataSet14TableAdapters.CustomerDetailsTableAdapter customerDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custcontactnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custaltcontactnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custdobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}