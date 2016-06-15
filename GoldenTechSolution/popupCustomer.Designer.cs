namespace GoldenTechSolution
{
    partial class popupCustomer
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
            this.custidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custdobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custcontactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custaltcontactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goldenTechDataDataSet17 = new GoldenTechSolution.GoldenTechDataDataSet17();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerDetailsTableAdapter = new GoldenTechSolution.GoldenTechDataDataSet17TableAdapters.CustomerDetailsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet17)).BeginInit();
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
            this.custageDataGridViewTextBoxColumn,
            this.custgenderDataGridViewTextBoxColumn,
            this.custdobDataGridViewTextBoxColumn,
            this.custcontactnoDataGridViewTextBoxColumn,
            this.custaltcontactnoDataGridViewTextBoxColumn,
            this.custemailDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(303, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // custidDataGridViewTextBoxColumn
            // 
            this.custidDataGridViewTextBoxColumn.DataPropertyName = "cust_id";
            this.custidDataGridViewTextBoxColumn.HeaderText = "cust_id";
            this.custidDataGridViewTextBoxColumn.Name = "custidDataGridViewTextBoxColumn";
            this.custidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custnameDataGridViewTextBoxColumn
            // 
            this.custnameDataGridViewTextBoxColumn.DataPropertyName = "cust_name";
            this.custnameDataGridViewTextBoxColumn.HeaderText = "cust_name";
            this.custnameDataGridViewTextBoxColumn.Name = "custnameDataGridViewTextBoxColumn";
            this.custnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custageDataGridViewTextBoxColumn
            // 
            this.custageDataGridViewTextBoxColumn.DataPropertyName = "cust_age";
            this.custageDataGridViewTextBoxColumn.HeaderText = "cust_age";
            this.custageDataGridViewTextBoxColumn.Name = "custageDataGridViewTextBoxColumn";
            this.custageDataGridViewTextBoxColumn.ReadOnly = true;
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
            // custcontactnoDataGridViewTextBoxColumn
            // 
            this.custcontactnoDataGridViewTextBoxColumn.DataPropertyName = "cust_contact_no";
            this.custcontactnoDataGridViewTextBoxColumn.HeaderText = "cust_contact_no";
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
            // custemailDataGridViewTextBoxColumn
            // 
            this.custemailDataGridViewTextBoxColumn.DataPropertyName = "cust_email";
            this.custemailDataGridViewTextBoxColumn.HeaderText = "cust_email";
            this.custemailDataGridViewTextBoxColumn.Name = "custemailDataGridViewTextBoxColumn";
            this.custemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDetailsBindingSource
            // 
            this.customerDetailsBindingSource.DataMember = "CustomerDetails";
            this.customerDetailsBindingSource.DataSource = this.goldenTechDataDataSet17;
            // 
            // goldenTechDataDataSet17
            // 
            this.goldenTechDataDataSet17.DataSetName = "GoldenTechDataDataSet17";
            this.goldenTechDataDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Contact",
            "Email"});
            this.comboBox1.Location = new System.Drawing.Point(56, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(57, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Value";
            // 
            // customerDetailsTableAdapter
            // 
            this.customerDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // popupCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "popupCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "popupCustomer";
            this.Load += new System.EventHandler(this.popupCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet17)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private GoldenTechDataDataSet17 goldenTechDataDataSet17;
        private System.Windows.Forms.BindingSource customerDetailsBindingSource;
        private GoldenTechDataDataSet17TableAdapters.CustomerDetailsTableAdapter customerDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custdobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custcontactnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custaltcontactnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}