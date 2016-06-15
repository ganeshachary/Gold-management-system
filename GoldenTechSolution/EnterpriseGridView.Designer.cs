namespace GoldenTechSolution
{
    partial class EnterpriseGridView
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
            this.enterpriseDetailsDataSet = new GoldenTechSolution.EnterpriseDetailsDataSet();
            this.enterpriseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterpriseDetailsTableAdapter = new GoldenTechSolution.EnterpriseDetailsDataSetTableAdapters.EnterpriseDetailsTableAdapter();
            this.entidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entcontactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entaltcontactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entemailidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDetailsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entidDataGridViewTextBoxColumn,
            this.entnameDataGridViewTextBoxColumn,
            this.entcontactnoDataGridViewTextBoxColumn,
            this.entaltcontactnoDataGridViewTextBoxColumn,
            this.entemailidDataGridViewTextBoxColumn,
            this.entdescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.enterpriseDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 59);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(325, 159);
            this.dataGridView1.TabIndex = 0;
            // 
            // enterpriseDetailsDataSet
            // 
            this.enterpriseDetailsDataSet.DataSetName = "EnterpriseDetailsDataSet";
            this.enterpriseDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enterpriseDetailsBindingSource
            // 
            this.enterpriseDetailsBindingSource.DataMember = "EnterpriseDetails";
            this.enterpriseDetailsBindingSource.DataSource = this.enterpriseDetailsDataSet;
            // 
            // enterpriseDetailsTableAdapter
            // 
            this.enterpriseDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // entidDataGridViewTextBoxColumn
            // 
            this.entidDataGridViewTextBoxColumn.DataPropertyName = "ent_id";
            this.entidDataGridViewTextBoxColumn.HeaderText = "ent_id";
            this.entidDataGridViewTextBoxColumn.Name = "entidDataGridViewTextBoxColumn";
            this.entidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entnameDataGridViewTextBoxColumn
            // 
            this.entnameDataGridViewTextBoxColumn.DataPropertyName = "ent_name";
            this.entnameDataGridViewTextBoxColumn.HeaderText = "ent_name";
            this.entnameDataGridViewTextBoxColumn.Name = "entnameDataGridViewTextBoxColumn";
            this.entnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entcontactnoDataGridViewTextBoxColumn
            // 
            this.entcontactnoDataGridViewTextBoxColumn.DataPropertyName = "ent_contact_no";
            this.entcontactnoDataGridViewTextBoxColumn.HeaderText = "ent_contact_no";
            this.entcontactnoDataGridViewTextBoxColumn.Name = "entcontactnoDataGridViewTextBoxColumn";
            this.entcontactnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entaltcontactnoDataGridViewTextBoxColumn
            // 
            this.entaltcontactnoDataGridViewTextBoxColumn.DataPropertyName = "ent_alt_contact_no";
            this.entaltcontactnoDataGridViewTextBoxColumn.HeaderText = "ent_alt_contact_no";
            this.entaltcontactnoDataGridViewTextBoxColumn.Name = "entaltcontactnoDataGridViewTextBoxColumn";
            this.entaltcontactnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entemailidDataGridViewTextBoxColumn
            // 
            this.entemailidDataGridViewTextBoxColumn.DataPropertyName = "ent_email_id";
            this.entemailidDataGridViewTextBoxColumn.HeaderText = "ent_email_id";
            this.entemailidDataGridViewTextBoxColumn.Name = "entemailidDataGridViewTextBoxColumn";
            this.entemailidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entdescriptionDataGridViewTextBoxColumn
            // 
            this.entdescriptionDataGridViewTextBoxColumn.DataPropertyName = "ent_description";
            this.entdescriptionDataGridViewTextBoxColumn.HeaderText = "ent_description";
            this.entdescriptionDataGridViewTextBoxColumn.Name = "entdescriptionDataGridViewTextBoxColumn";
            this.entdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Name",
            "ContactNumber",
            "Email Id"});
            this.comboBox1.Location = new System.Drawing.Point(85, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(85, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(69, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(169, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EnterpriseGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EnterpriseGridView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnterpriseGridView";
            this.Load += new System.EventHandler(this.EnterpriseGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDetailsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EnterpriseDetailsDataSet enterpriseDetailsDataSet;
        private System.Windows.Forms.BindingSource enterpriseDetailsBindingSource;
        private EnterpriseDetailsDataSetTableAdapters.EnterpriseDetailsTableAdapter enterpriseDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn entidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entcontactnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entaltcontactnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entemailidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}