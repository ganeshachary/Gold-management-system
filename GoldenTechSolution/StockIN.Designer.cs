namespace GoldenTechSolution
{
    partial class StockIN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpBoughtDate = new System.Windows.Forms.DateTimePicker();
            this.cmbEnterpriseName = new System.Windows.Forms.ComboBox();
            this.lnklblVerify = new System.Windows.Forms.LinkLabel();
            this.label23 = new System.Windows.Forms.Label();
            this.grpAddStock = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lnklblNewParty = new System.Windows.Forms.LinkLabel();
            this.txtEnterpriseId = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.txtKarat = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFineWeight = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNetWeight = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtGrossWeight = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbMetal = new System.Windows.Forms.ComboBox();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.grpAddStock.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpBoughtDate
            // 
            this.dtpBoughtDate.Location = new System.Drawing.Point(853, 107);
            this.dtpBoughtDate.Name = "dtpBoughtDate";
            this.dtpBoughtDate.Size = new System.Drawing.Size(224, 23);
            this.dtpBoughtDate.TabIndex = 28;
            // 
            // cmbEnterpriseName
            // 
            this.cmbEnterpriseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnterpriseName.FormattingEnabled = true;
            this.cmbEnterpriseName.Location = new System.Drawing.Point(157, 121);
            this.cmbEnterpriseName.Name = "cmbEnterpriseName";
            this.cmbEnterpriseName.Size = new System.Drawing.Size(155, 24);
            this.cmbEnterpriseName.TabIndex = 27;
            // 
            // lnklblVerify
            // 
            this.lnklblVerify.AutoSize = true;
            this.lnklblVerify.Enabled = false;
            this.lnklblVerify.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblVerify.Location = new System.Drawing.Point(240, 79);
            this.lnklblVerify.Name = "lnklblVerify";
            this.lnklblVerify.Size = new System.Drawing.Size(64, 13);
            this.lnklblVerify.TabIndex = 26;
            this.lnklblVerify.TabStop = true;
            this.lnklblVerify.Text = "Verify Id";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(23, 124);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(128, 16);
            this.label23.TabIndex = 23;
            this.label23.Text = "Enterprise name";
            // 
            // grpAddStock
            // 
            this.grpAddStock.BackColor = System.Drawing.Color.White;
            this.grpAddStock.Controls.Add(this.label1);
            this.grpAddStock.Controls.Add(this.btnNext);
            this.grpAddStock.Controls.Add(this.btnPrevious);
            this.grpAddStock.Controls.Add(this.btnCancel);
            this.grpAddStock.Controls.Add(this.btnClear);
            this.grpAddStock.Controls.Add(this.btnAddStock);
            this.grpAddStock.Controls.Add(this.grpDetails);
            this.grpAddStock.Controls.Add(this.txtDate);
            this.grpAddStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAddStock.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddStock.Location = new System.Drawing.Point(0, 0);
            this.grpAddStock.Name = "grpAddStock";
            this.grpAddStock.Size = new System.Drawing.Size(1358, 451);
            this.grpAddStock.TabIndex = 0;
            this.grpAddStock.TabStop = false;
            this.grpAddStock.Text = "Add stock details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Date of entry";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(968, 319);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(115, 25);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next>>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(822, 319);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(115, 25);
            this.btnPrevious.TabIndex = 25;
            this.btnPrevious.Text = "<<Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(504, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 33);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(347, 310);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 33);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.White;
            this.btnAddStock.Location = new System.Drawing.Point(193, 310);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(108, 33);
            this.btnAddStock.TabIndex = 20;
            this.btnAddStock.Text = "Add stock";
            this.btnAddStock.UseVisualStyleBackColor = false;
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.dtpBoughtDate);
            this.grpDetails.Controls.Add(this.cmbEnterpriseName);
            this.grpDetails.Controls.Add(this.lnklblVerify);
            this.grpDetails.Controls.Add(this.label23);
            this.grpDetails.Controls.Add(this.lnklblNewParty);
            this.grpDetails.Controls.Add(this.txtEnterpriseId);
            this.grpDetails.Controls.Add(this.label24);
            this.grpDetails.Controls.Add(this.label11);
            this.grpDetails.Controls.Add(this.label12);
            this.grpDetails.Controls.Add(this.label13);
            this.grpDetails.Controls.Add(this.txtDescription);
            this.grpDetails.Controls.Add(this.label14);
            this.grpDetails.Controls.Add(this.label15);
            this.grpDetails.Controls.Add(this.nudQuantity);
            this.grpDetails.Controls.Add(this.label16);
            this.grpDetails.Controls.Add(this.txtKarat);
            this.grpDetails.Controls.Add(this.label17);
            this.grpDetails.Controls.Add(this.txtFineWeight);
            this.grpDetails.Controls.Add(this.label18);
            this.grpDetails.Controls.Add(this.txtNetWeight);
            this.grpDetails.Controls.Add(this.label19);
            this.grpDetails.Controls.Add(this.txtGrossWeight);
            this.grpDetails.Controls.Add(this.label20);
            this.grpDetails.Controls.Add(this.cmbMetal);
            this.grpDetails.Controls.Add(this.txtItemId);
            this.grpDetails.Controls.Add(this.cmbCategory);
            this.grpDetails.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.Location = new System.Drawing.Point(6, 58);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(1098, 245);
            this.grpDetails.TabIndex = 23;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details";
            // 
            // lnklblNewParty
            // 
            this.lnklblNewParty.AutoSize = true;
            this.lnklblNewParty.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblNewParty.Location = new System.Drawing.Point(240, 102);
            this.lnklblNewParty.Name = "lnklblNewParty";
            this.lnklblNewParty.Size = new System.Drawing.Size(73, 13);
            this.lnklblNewParty.TabIndex = 22;
            this.lnklblNewParty.TabStop = true;
            this.lnklblNewParty.Text = "New party";
            // 
            // txtEnterpriseId
            // 
            this.txtEnterpriseId.Location = new System.Drawing.Point(157, 71);
            this.txtEnterpriseId.Name = "txtEnterpriseId";
            this.txtEnterpriseId.Size = new System.Drawing.Size(77, 23);
            this.txtEnterpriseId.TabIndex = 21;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(23, 78);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(102, 16);
            this.label24.TabIndex = 20;
            this.label24.Text = "Enterprise Id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Item Id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Category";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(412, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Metal";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(853, 142);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(237, 77);
            this.txtDescription.TabIndex = 19;
            this.txtDescription.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(412, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Gross Weight";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(412, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Net weight";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(853, 62);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(147, 23);
            this.nudQuantity.TabIndex = 17;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(412, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "Fine weight";
            // 
            // txtKarat
            // 
            this.txtKarat.Location = new System.Drawing.Point(853, 22);
            this.txtKarat.Name = "txtKarat";
            this.txtKarat.Size = new System.Drawing.Size(147, 23);
            this.txtKarat.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(745, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 16);
            this.label17.TabIndex = 6;
            this.label17.Text = "Karat";
            // 
            // txtFineWeight
            // 
            this.txtFineWeight.Location = new System.Drawing.Point(527, 167);
            this.txtFineWeight.Name = "txtFineWeight";
            this.txtFineWeight.Size = new System.Drawing.Size(155, 23);
            this.txtFineWeight.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(745, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 16);
            this.label18.TabIndex = 7;
            this.label18.Text = "Quantity";
            // 
            // txtNetWeight
            // 
            this.txtNetWeight.Location = new System.Drawing.Point(527, 119);
            this.txtNetWeight.Name = "txtNetWeight";
            this.txtNetWeight.Size = new System.Drawing.Size(155, 23);
            this.txtNetWeight.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(745, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 16);
            this.label19.TabIndex = 8;
            this.label19.Text = "Bought date";
            // 
            // txtGrossWeight
            // 
            this.txtGrossWeight.Location = new System.Drawing.Point(527, 70);
            this.txtGrossWeight.Name = "txtGrossWeight";
            this.txtGrossWeight.Size = new System.Drawing.Size(155, 23);
            this.txtGrossWeight.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(745, 145);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 16);
            this.label20.TabIndex = 9;
            this.label20.Text = "Description";
            // 
            // cmbMetal
            // 
            this.cmbMetal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetal.FormattingEnabled = true;
            this.cmbMetal.Items.AddRange(new object[] {
            "Gold",
            "Diamond",
            "Silver",
            "Platinum"});
            this.cmbMetal.Location = new System.Drawing.Point(527, 24);
            this.cmbMetal.Name = "cmbMetal";
            this.cmbMetal.Size = new System.Drawing.Size(155, 24);
            this.cmbMetal.TabIndex = 12;
            // 
            // txtItemId
            // 
            this.txtItemId.Enabled = false;
            this.txtItemId.Location = new System.Drawing.Point(157, 25);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(77, 23);
            this.txtItemId.TabIndex = 10;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Ring",
            "Chain",
            "Necklace",
            "Anklet"});
            this.cmbCategory.Location = new System.Drawing.Point(157, 163);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(155, 24);
            this.cmbCategory.TabIndex = 11;
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(461, 22);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(132, 26);
            this.txtDate.TabIndex = 18;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpAddStock);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvStock);
            this.splitContainer1.Size = new System.Drawing.Size(1362, 750);
            this.splitContainer1.SplitterDistance = 455;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(0, 0);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(1358, 285);
            this.dgvStock.TabIndex = 0;
            // 
            // StockIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 750);
            this.Controls.Add(this.splitContainer1);
            this.Name = "StockIN";
            this.Text = "StockIN";
            this.grpAddStock.ResumeLayout(false);
            this.grpAddStock.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBoughtDate;
        private System.Windows.Forms.ComboBox cmbEnterpriseName;
        private System.Windows.Forms.LinkLabel lnklblVerify;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox grpAddStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.LinkLabel lnklblNewParty;
        private System.Windows.Forms.TextBox txtEnterpriseId;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtKarat;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFineWeight;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNetWeight;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtGrossWeight;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbMetal;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvStock;
    }
}