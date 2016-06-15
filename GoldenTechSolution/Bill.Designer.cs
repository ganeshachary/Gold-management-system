namespace GoldenTechSolution
{
    partial class Bill
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvBillItems = new System.Windows.Forms.DataGridView();
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
            this.stockForBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goldenTechDataDataSet19 = new GoldenTechSolution.GoldenTechDataDataSet19();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddToBill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.stockDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goldenTechDataDataSet15 = new GoldenTechSolution.GoldenTechDataDataSet15();
            this.stockDetailsTableAdapter = new GoldenTechSolution.GoldenTechDataDataSet15TableAdapters.StockDetailsTableAdapter();
            this.goldenTechDataDataSet16 = new GoldenTechSolution.GoldenTechDataDataSet16();
            this.customerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDetailsTableAdapter = new GoldenTechSolution.GoldenTechDataDataSet16TableAdapters.CustomerDetailsTableAdapter();
            this.txtStockId = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.stockForBillTableAdapter = new GoldenTechSolution.GoldenTechDataDataSet19TableAdapters.StockForBillTableAdapter();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.lblCustomerDetails = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpergramcost = new System.Windows.Forms.TextBox();
            this.txtbilldate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtotalcost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWorkingCharge = new System.Windows.Forms.TextBox();
            this.downPayment = new System.Windows.Forms.Label();
            this.txtdownpayment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockForBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(690, 489);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(134, 29);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print Bill";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvBillItems
            // 
            this.dgvBillItems.AutoGenerateColumns = false;
            this.dgvBillItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvBillItems.DataSource = this.stockForBillBindingSource;
            this.dgvBillItems.Location = new System.Drawing.Point(13, 168);
            this.dgvBillItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvBillItems.MultiSelect = false;
            this.dgvBillItems.Name = "dgvBillItems";
            this.dgvBillItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillItems.Size = new System.Drawing.Size(914, 154);
            this.dgvBillItems.TabIndex = 1;
            this.dgvBillItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillItems_CellContentClick);
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
            // 
            // itemmetalDataGridViewTextBoxColumn
            // 
            this.itemmetalDataGridViewTextBoxColumn.DataPropertyName = "item_metal";
            this.itemmetalDataGridViewTextBoxColumn.HeaderText = "item_metal";
            this.itemmetalDataGridViewTextBoxColumn.Name = "itemmetalDataGridViewTextBoxColumn";
            // 
            // itemgrossweightDataGridViewTextBoxColumn
            // 
            this.itemgrossweightDataGridViewTextBoxColumn.DataPropertyName = "item_gross_weight";
            this.itemgrossweightDataGridViewTextBoxColumn.HeaderText = "item_gross_weight";
            this.itemgrossweightDataGridViewTextBoxColumn.Name = "itemgrossweightDataGridViewTextBoxColumn";
            // 
            // itemnetweightDataGridViewTextBoxColumn
            // 
            this.itemnetweightDataGridViewTextBoxColumn.DataPropertyName = "item_net_weight";
            this.itemnetweightDataGridViewTextBoxColumn.HeaderText = "item_net_weight";
            this.itemnetweightDataGridViewTextBoxColumn.Name = "itemnetweightDataGridViewTextBoxColumn";
            // 
            // itemfineweightDataGridViewTextBoxColumn
            // 
            this.itemfineweightDataGridViewTextBoxColumn.DataPropertyName = "item_fine_weight";
            this.itemfineweightDataGridViewTextBoxColumn.HeaderText = "item_fine_weight";
            this.itemfineweightDataGridViewTextBoxColumn.Name = "itemfineweightDataGridViewTextBoxColumn";
            // 
            // itemkaratDataGridViewTextBoxColumn
            // 
            this.itemkaratDataGridViewTextBoxColumn.DataPropertyName = "item_karat";
            this.itemkaratDataGridViewTextBoxColumn.HeaderText = "item_karat";
            this.itemkaratDataGridViewTextBoxColumn.Name = "itemkaratDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // dateofentryDataGridViewTextBoxColumn
            // 
            this.dateofentryDataGridViewTextBoxColumn.DataPropertyName = "date_of_entry";
            this.dateofentryDataGridViewTextBoxColumn.HeaderText = "date_of_entry";
            this.dateofentryDataGridViewTextBoxColumn.Name = "dateofentryDataGridViewTextBoxColumn";
            // 
            // itemdescriptionDataGridViewTextBoxColumn
            // 
            this.itemdescriptionDataGridViewTextBoxColumn.DataPropertyName = "item_description";
            this.itemdescriptionDataGridViewTextBoxColumn.HeaderText = "item_description";
            this.itemdescriptionDataGridViewTextBoxColumn.Name = "itemdescriptionDataGridViewTextBoxColumn";
            // 
            // stockForBillBindingSource
            // 
            this.stockForBillBindingSource.DataMember = "StockForBill";
            this.stockForBillBindingSource.DataSource = this.goldenTechDataDataSet19;
            // 
            // goldenTechDataDataSet19
            // 
            this.goldenTechDataDataSet19.DataSetName = "GoldenTechDataDataSet19";
            this.goldenTechDataDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter StockID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddToBill
            // 
            this.btnAddToBill.Enabled = false;
            this.btnAddToBill.Location = new System.Drawing.Point(116, 87);
            this.btnAddToBill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddToBill.Name = "btnAddToBill";
            this.btnAddToBill.Size = new System.Drawing.Size(100, 24);
            this.btnAddToBill.TabIndex = 4;
            this.btnAddToBill.Text = "Add to Bill";
            this.btnAddToBill.UseVisualStyleBackColor = true;
            this.btnAddToBill.Click += new System.EventHandler(this.btnAddToBill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bill No";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Enabled = false;
            this.txtBillNo.Location = new System.Drawing.Point(116, 16);
            this.txtBillNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(132, 21);
            this.txtBillNo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(540, 60);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 24);
            this.button3.TabIndex = 10;
            this.button3.Text = "New";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // stockDetailsBindingSource
            // 
            this.stockDetailsBindingSource.DataMember = "StockDetails";
            this.stockDetailsBindingSource.DataSource = this.goldenTechDataDataSet15;
            // 
            // goldenTechDataDataSet15
            // 
            this.goldenTechDataDataSet15.DataSetName = "GoldenTechDataDataSet15";
            this.goldenTechDataDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockDetailsTableAdapter
            // 
            this.stockDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // goldenTechDataDataSet16
            // 
            this.goldenTechDataDataSet16.DataSetName = "GoldenTechDataDataSet16";
            this.goldenTechDataDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerDetailsBindingSource
            // 
            this.customerDetailsBindingSource.DataMember = "CustomerDetails";
            this.customerDetailsBindingSource.DataSource = this.goldenTechDataDataSet16;
            // 
            // customerDetailsTableAdapter
            // 
            this.customerDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // txtStockId
            // 
            this.txtStockId.Location = new System.Drawing.Point(120, 60);
            this.txtStockId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStockId.Name = "txtStockId";
            this.txtStockId.Size = new System.Drawing.Size(132, 21);
            this.txtStockId.TabIndex = 14;
            this.txtStockId.TextChanged += new System.EventHandler(this.txtStockId_TextChanged);
            this.txtStockId.DoubleClick += new System.EventHandler(this.txtStockId_DoubleClick);
            this.txtStockId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockId_KeyPress);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(392, 63);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(132, 21);
            this.txtCustomer.TabIndex = 15;
            this.txtCustomer.TextChanged += new System.EventHandler(this.txtCustomer_TextChanged);
            this.txtCustomer.DoubleClick += new System.EventHandler(this.txtCustomer_DoubleClick);
            this.txtCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomer_KeyPress);
            // 
            // stockForBillTableAdapter
            // 
            this.stockForBillTableAdapter.ClearBeforeFill = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(168, 328);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(110, 29);
            this.btncancel.TabIndex = 16;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(19, 328);
            this.btnremove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(110, 29);
            this.btnremove.TabIndex = 17;
            this.btnremove.Text = "Remove Item";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // lblCustomerDetails
            // 
            this.lblCustomerDetails.AutoSize = true;
            this.lblCustomerDetails.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerDetails.Location = new System.Drawing.Point(389, 87);
            this.lblCustomerDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerDetails.Name = "lblCustomerDetails";
            this.lblCustomerDetails.Size = new System.Drawing.Size(127, 16);
            this.lblCustomerDetails.TabIndex = 18;
            this.lblCustomerDetails.Text = "CustomerDetails";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Per Gram Cost";
            // 
            // txtpergramcost
            // 
            this.txtpergramcost.Location = new System.Drawing.Point(280, 386);
            this.txtpergramcost.Name = "txtpergramcost";
            this.txtpergramcost.Size = new System.Drawing.Size(100, 21);
            this.txtpergramcost.TabIndex = 20;
            this.txtpergramcost.TextChanged += new System.EventHandler(this.txtpergramcost_TextChanged);
            this.txtpergramcost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpergramcost_KeyPress);
            // 
            // txtbilldate
            // 
            this.txtbilldate.Enabled = false;
            this.txtbilldate.Location = new System.Drawing.Point(392, 15);
            this.txtbilldate.Name = "txtbilldate";
            this.txtbilldate.Size = new System.Drawing.Size(104, 21);
            this.txtbilldate.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "TotalCost";
            // 
            // txtotalcost
            // 
            this.txtotalcost.Enabled = false;
            this.txtotalcost.Location = new System.Drawing.Point(280, 451);
            this.txtotalcost.Name = "txtotalcost";
            this.txtotalcost.Size = new System.Drawing.Size(100, 21);
            this.txtotalcost.TabIndex = 24;
            this.txtotalcost.TextChanged += new System.EventHandler(this.txtotalcost_TextChanged);
            this.txtotalcost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtotalcost_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Working Charge";
            // 
            // txtWorkingCharge
            // 
            this.txtWorkingCharge.Location = new System.Drawing.Point(579, 386);
            this.txtWorkingCharge.Name = "txtWorkingCharge";
            this.txtWorkingCharge.Size = new System.Drawing.Size(100, 21);
            this.txtWorkingCharge.TabIndex = 26;
            this.txtWorkingCharge.TextChanged += new System.EventHandler(this.txtWorkingCharge_TextChanged);
            this.txtWorkingCharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWorkingCharge_KeyPress);
            // 
            // downPayment
            // 
            this.downPayment.AutoSize = true;
            this.downPayment.Location = new System.Drawing.Point(437, 451);
            this.downPayment.Name = "downPayment";
            this.downPayment.Size = new System.Drawing.Size(99, 13);
            this.downPayment.TabIndex = 27;
            this.downPayment.Text = "DownPayment";
            // 
            // txtdownpayment
            // 
            this.txtdownpayment.Location = new System.Drawing.Point(579, 443);
            this.txtdownpayment.Name = "txtdownpayment";
            this.txtdownpayment.Size = new System.Drawing.Size(100, 21);
            this.txtdownpayment.TabIndex = 28;
            this.txtdownpayment.TextChanged += new System.EventHandler(this.txtdownpayment_TextChanged);
            this.txtdownpayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdownpayment_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(745, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(827, 440);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 21);
            this.txtBalance.TabIndex = 30;
            this.txtBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBalance_KeyPress);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 696);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdownpayment);
            this.Controls.Add(this.downPayment);
            this.Controls.Add(this.txtWorkingCharge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtotalcost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbilldate);
            this.Controls.Add(this.txtpergramcost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCustomerDetails);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtStockId);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddToBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBillItems);
            this.Controls.Add(this.btnPrint);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bill_FormClosing);
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockForBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvBillItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private GoldenTechDataDataSet15 goldenTechDataDataSet15;
        private System.Windows.Forms.BindingSource stockDetailsBindingSource;
        private GoldenTechDataDataSet15TableAdapters.StockDetailsTableAdapter stockDetailsTableAdapter;
        private GoldenTechDataDataSet16 goldenTechDataDataSet16;
        private System.Windows.Forms.BindingSource customerDetailsBindingSource;
        private GoldenTechDataDataSet16TableAdapters.CustomerDetailsTableAdapter customerDetailsTableAdapter;
        public System.Windows.Forms.TextBox txtStockId;
        public System.Windows.Forms.TextBox txtCustomer;
        private GoldenTechDataDataSet19 goldenTechDataDataSet19;
        private System.Windows.Forms.BindingSource stockForBillBindingSource;
        private GoldenTechDataDataSet19TableAdapters.StockForBillTableAdapter stockForBillTableAdapter;
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
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Label lblCustomerDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpergramcost;
        private System.Windows.Forms.TextBox txtbilldate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtotalcost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWorkingCharge;
        private System.Windows.Forms.Label downPayment;
        private System.Windows.Forms.TextBox txtdownpayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBalance;

    }
}