namespace GoldenTech
{
    partial class SaleBill
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
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBillNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.dgvAddedItems = new System.Windows.Forms.DataGridView();
            this.btnClearItems = new System.Windows.Forms.Button();
            this.grpSelectItems = new System.Windows.Forms.GroupBox();
            this.btnDoneAddingitems = new System.Windows.Forms.Button();
            this.grpSelectedItems = new System.Windows.Forms.GroupBox();
            this.grpForCustomer = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedItems)).BeginInit();
            this.grpSelectItems.SuspendLayout();
            this.grpSelectedItems.SuspendLayout();
            this.grpForCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(13, 22);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(675, 150);
            this.dgvStock.TabIndex = 0;
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBill.Location = new System.Drawing.Point(147, 283);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(113, 32);
            this.btnCreateBill.TabIndex = 1;
            this.btnCreateBill.Text = "Create bill";
            this.btnCreateBill.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(438, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bill No.";
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Enabled = false;
            this.txtBillNumber.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNumber.Location = new System.Drawing.Point(79, 32);
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(134, 26);
            this.txtBillNumber.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select the items below that you want to add to your bill.";
            // 
            // btnAddItems
            // 
            this.btnAddItems.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.Location = new System.Drawing.Point(97, 179);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(225, 27);
            this.btnAddItems.TabIndex = 7;
            this.btnAddItems.Text = "Add selected items to bill";
            this.btnAddItems.UseVisualStyleBackColor = true;
            // 
            // dgvAddedItems
            // 
            this.dgvAddedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddedItems.Location = new System.Drawing.Point(13, 22);
            this.dgvAddedItems.Name = "dgvAddedItems";
            this.dgvAddedItems.Size = new System.Drawing.Size(1016, 150);
            this.dgvAddedItems.TabIndex = 8;
            // 
            // btnClearItems
            // 
            this.btnClearItems.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearItems.Location = new System.Drawing.Point(277, 283);
            this.btnClearItems.Name = "btnClearItems";
            this.btnClearItems.Size = new System.Drawing.Size(145, 32);
            this.btnClearItems.TabIndex = 9;
            this.btnClearItems.Text = "Clear all items";
            this.btnClearItems.UseVisualStyleBackColor = true;
            // 
            // grpSelectItems
            // 
            this.grpSelectItems.Controls.Add(this.btnDoneAddingitems);
            this.grpSelectItems.Controls.Add(this.dgvStock);
            this.grpSelectItems.Controls.Add(this.btnAddItems);
            this.grpSelectItems.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelectItems.Location = new System.Drawing.Point(356, 24);
            this.grpSelectItems.Name = "grpSelectItems";
            this.grpSelectItems.Size = new System.Drawing.Size(700, 218);
            this.grpSelectItems.TabIndex = 10;
            this.grpSelectItems.TabStop = false;
            this.grpSelectItems.Text = "Select Items";
            // 
            // btnDoneAddingitems
            // 
            this.btnDoneAddingitems.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneAddingitems.Location = new System.Drawing.Point(338, 179);
            this.btnDoneAddingitems.Name = "btnDoneAddingitems";
            this.btnDoneAddingitems.Size = new System.Drawing.Size(225, 27);
            this.btnDoneAddingitems.TabIndex = 8;
            this.btnDoneAddingitems.Text = "Done adding items";
            this.btnDoneAddingitems.UseVisualStyleBackColor = true;
            // 
            // grpSelectedItems
            // 
            this.grpSelectedItems.Controls.Add(this.grpForCustomer);
            this.grpSelectedItems.Controls.Add(this.dgvAddedItems);
            this.grpSelectedItems.Controls.Add(this.btnClearItems);
            this.grpSelectedItems.Controls.Add(this.btnCreateBill);
            this.grpSelectedItems.Controls.Add(this.btnCancel);
            this.grpSelectedItems.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelectedItems.Location = new System.Drawing.Point(15, 248);
            this.grpSelectedItems.Name = "grpSelectedItems";
            this.grpSelectedItems.Size = new System.Drawing.Size(1041, 337);
            this.grpSelectedItems.TabIndex = 11;
            this.grpSelectedItems.TabStop = false;
            this.grpSelectedItems.Text = "Selected Items";
            // 
            // grpForCustomer
            // 
            this.grpForCustomer.Controls.Add(this.textBox3);
            this.grpForCustomer.Controls.Add(this.textBox2);
            this.grpForCustomer.Controls.Add(this.label6);
            this.grpForCustomer.Controls.Add(this.label5);
            this.grpForCustomer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpForCustomer.Location = new System.Drawing.Point(13, 191);
            this.grpForCustomer.Name = "grpForCustomer";
            this.grpForCustomer.Size = new System.Drawing.Size(675, 77);
            this.grpForCustomer.TabIndex = 12;
            this.grpForCustomer.TabStop = false;
            this.grpForCustomer.Text = "Customer Details";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(413, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(254, 23);
            this.textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 23);
            this.textBox2.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Customer Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Customer Id";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(79, 71);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(134, 26);
            this.txtDate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date";
            // 
            // SaleBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 606);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpSelectedItems);
            this.Controls.Add(this.grpSelectItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBillNumber);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SaleBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleBill";
            this.Load += new System.EventHandler(this.SaleBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedItems)).EndInit();
            this.grpSelectItems.ResumeLayout(false);
            this.grpSelectedItems.ResumeLayout(false);
            this.grpForCustomer.ResumeLayout(false);
            this.grpForCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBillNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.DataGridView dgvAddedItems;
        private System.Windows.Forms.Button btnClearItems;
        private System.Windows.Forms.GroupBox grpSelectItems;
        private System.Windows.Forms.GroupBox grpSelectedItems;
        private System.Windows.Forms.Button btnDoneAddingitems;
        private System.Windows.Forms.GroupBox grpForCustomer;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label7;
        //private GoldenTechDbDataSet12 goldenTechDbDataSet12;
        //private System.Windows.Forms.BindingSource employeeBindingSource;
        //private GoldenTechDbDataSet12TableAdapters.EmployeeTableAdapter employeeTableAdapter;

    }
}