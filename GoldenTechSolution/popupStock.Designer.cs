namespace GoldenTechSolution
{
    partial class popupStock
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.goldenTechDataDataSet18 = new GoldenTechSolution.GoldenTechDataDataSet18();
            this.stockDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockDetailsTableAdapter = new GoldenTechSolution.GoldenTechDataDataSet18TableAdapters.StockDetailsTableAdapter();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemmetalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemgrossweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnetweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemfineweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemkaratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofentryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(55, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Category",
            "Metal"});
            this.comboBox1.Location = new System.Drawing.Point(54, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemidDataGridViewTextBoxColumn,
            this.itemcategoryDataGridViewTextBoxColumn,
            this.itemmetalDataGridViewTextBoxColumn,
            this.itemgrossweightDataGridViewTextBoxColumn,
            this.itemnetweightDataGridViewTextBoxColumn,
            this.itemfineweightDataGridViewTextBoxColumn,
            this.itemkaratDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.dateofentryDataGridViewTextBoxColumn,
            this.itemdescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(316, 182);
            this.dataGridView1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // goldenTechDataDataSet18
            // 
            this.goldenTechDataDataSet18.DataSetName = "GoldenTechDataDataSet18";
            this.goldenTechDataDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockDetailsBindingSource
            // 
            this.stockDetailsBindingSource.DataMember = "StockDetails";
            this.stockDetailsBindingSource.DataSource = this.goldenTechDataDataSet18;
            // 
            // stockDetailsTableAdapter
            // 
            this.stockDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "item_id";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "item_id";
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            this.itemidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemcategoryDataGridViewTextBoxColumn
            // 
            this.itemcategoryDataGridViewTextBoxColumn.DataPropertyName = "item_category";
            this.itemcategoryDataGridViewTextBoxColumn.HeaderText = "item_category";
            this.itemcategoryDataGridViewTextBoxColumn.Name = "itemcategoryDataGridViewTextBoxColumn";
            this.itemcategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemmetalDataGridViewTextBoxColumn
            // 
            this.itemmetalDataGridViewTextBoxColumn.DataPropertyName = "item_metal";
            this.itemmetalDataGridViewTextBoxColumn.HeaderText = "item_metal";
            this.itemmetalDataGridViewTextBoxColumn.Name = "itemmetalDataGridViewTextBoxColumn";
            this.itemmetalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemgrossweightDataGridViewTextBoxColumn
            // 
            this.itemgrossweightDataGridViewTextBoxColumn.DataPropertyName = "item_gross_weight";
            this.itemgrossweightDataGridViewTextBoxColumn.HeaderText = "item_gross_weight";
            this.itemgrossweightDataGridViewTextBoxColumn.Name = "itemgrossweightDataGridViewTextBoxColumn";
            this.itemgrossweightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemnetweightDataGridViewTextBoxColumn
            // 
            this.itemnetweightDataGridViewTextBoxColumn.DataPropertyName = "item_net_weight";
            this.itemnetweightDataGridViewTextBoxColumn.HeaderText = "item_net_weight";
            this.itemnetweightDataGridViewTextBoxColumn.Name = "itemnetweightDataGridViewTextBoxColumn";
            this.itemnetweightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemfineweightDataGridViewTextBoxColumn
            // 
            this.itemfineweightDataGridViewTextBoxColumn.DataPropertyName = "item_fine_weight";
            this.itemfineweightDataGridViewTextBoxColumn.HeaderText = "item_fine_weight";
            this.itemfineweightDataGridViewTextBoxColumn.Name = "itemfineweightDataGridViewTextBoxColumn";
            this.itemfineweightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemkaratDataGridViewTextBoxColumn
            // 
            this.itemkaratDataGridViewTextBoxColumn.DataPropertyName = "item_karat";
            this.itemkaratDataGridViewTextBoxColumn.HeaderText = "item_karat";
            this.itemkaratDataGridViewTextBoxColumn.Name = "itemkaratDataGridViewTextBoxColumn";
            this.itemkaratDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateofentryDataGridViewTextBoxColumn
            // 
            this.dateofentryDataGridViewTextBoxColumn.DataPropertyName = "date_of_entry";
            this.dateofentryDataGridViewTextBoxColumn.HeaderText = "date_of_entry";
            this.dateofentryDataGridViewTextBoxColumn.Name = "dateofentryDataGridViewTextBoxColumn";
            this.dateofentryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemdescriptionDataGridViewTextBoxColumn
            // 
            this.itemdescriptionDataGridViewTextBoxColumn.DataPropertyName = "item_description";
            this.itemdescriptionDataGridViewTextBoxColumn.HeaderText = "item_description";
            this.itemdescriptionDataGridViewTextBoxColumn.Name = "itemdescriptionDataGridViewTextBoxColumn";
            this.itemdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // popupStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "popupStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "popupStock";
            this.Load += new System.EventHandler(this.popupStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private GoldenTechDataDataSet18 goldenTechDataDataSet18;
        private System.Windows.Forms.BindingSource stockDetailsBindingSource;
        private GoldenTechDataDataSet18TableAdapters.StockDetailsTableAdapter stockDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemmetalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemgrossweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnetweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemfineweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemkaratDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofentryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdescriptionDataGridViewTextBoxColumn;
    }
}