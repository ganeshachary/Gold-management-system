namespace GoldenTech
{
    partial class StockDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpAddStock = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpBoxMode = new System.Windows.Forms.GroupBox();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.dtpBoughtDate = new System.Windows.Forms.DateTimePicker();
            this.cmbEnterpriseName = new System.Windows.Forms.ComboBox();
            this.lnklblVerify = new System.Windows.Forms.LinkLabel();
            this.label23 = new System.Windows.Forms.Label();
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
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpAddStock.SuspendLayout();
            this.grpBoxMode.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(1246, 590);
            this.splitContainer1.SplitterDistance = 427;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpAddStock
            // 
            this.grpAddStock.BackColor = System.Drawing.Color.White;
            this.grpAddStock.Controls.Add(this.btnAddStock);
            this.grpAddStock.Controls.Add(this.btnDelete);
            this.grpAddStock.Controls.Add(this.btnUpdate);
            this.grpAddStock.Controls.Add(this.grpBoxMode);
            this.grpAddStock.Controls.Add(this.label1);
            this.grpAddStock.Controls.Add(this.btnNext);
            this.grpAddStock.Controls.Add(this.btnPrevious);
            this.grpAddStock.Controls.Add(this.btnCancel);
            this.grpAddStock.Controls.Add(this.btnClear);
            this.grpAddStock.Controls.Add(this.grpDetails);
            this.grpAddStock.Controls.Add(this.txtDate);
            this.grpAddStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAddStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddStock.Location = new System.Drawing.Point(0, 0);
            this.grpAddStock.Name = "grpAddStock";
            this.grpAddStock.Size = new System.Drawing.Size(1242, 423);
            this.grpAddStock.TabIndex = 0;
            this.grpAddStock.TabStop = false;
            this.grpAddStock.Text = "Add stock details";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(175, 296);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 28);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpBoxMode
            // 
            this.grpBoxMode.Controls.Add(this.cmbMode);
            this.grpBoxMode.Controls.Add(this.label2);
            this.grpBoxMode.Location = new System.Drawing.Point(695, 3);
            this.grpBoxMode.Name = "grpBoxMode";
            this.grpBoxMode.Size = new System.Drawing.Size(275, 61);
            this.grpBoxMode.TabIndex = 30;
            this.grpBoxMode.TabStop = false;
            this.grpBoxMode.Text = "Mode";
            // 
            // cmbMode
            // 
            this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "Entry",
            "Update"});
            this.cmbMode.Location = new System.Drawing.Point(127, 26);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(142, 21);
            this.cmbMode.TabIndex = 29;
            this.cmbMode.SelectedIndexChanged += new System.EventHandler(this.cmbMode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Change mode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Date of entry";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(822, 296);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 25);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next>>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(676, 296);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 25);
            this.btnPrevious.TabIndex = 25;
            this.btnPrevious.Text = "<<Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(323, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 28);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(166, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 28);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.White;
            this.btnAddStock.Location = new System.Drawing.Point(12, 296);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(108, 28);
            this.btnAddStock.TabIndex = 20;
            this.btnAddStock.Text = "Add stock";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
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
            this.grpDetails.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.Location = new System.Drawing.Point(6, 58);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(964, 232);
            this.grpDetails.TabIndex = 23;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details";
            // 
            // dtpBoughtDate
            // 
            this.dtpBoughtDate.Location = new System.Drawing.Point(712, 129);
            this.dtpBoughtDate.Name = "dtpBoughtDate";
            this.dtpBoughtDate.Size = new System.Drawing.Size(224, 21);
            this.dtpBoughtDate.TabIndex = 28;
            // 
            // cmbEnterpriseName
            // 
            this.cmbEnterpriseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnterpriseName.FormattingEnabled = true;
            this.cmbEnterpriseName.Location = new System.Drawing.Point(130, 115);
            this.cmbEnterpriseName.Name = "cmbEnterpriseName";
            this.cmbEnterpriseName.Size = new System.Drawing.Size(155, 21);
            this.cmbEnterpriseName.TabIndex = 27;
            this.cmbEnterpriseName.SelectedIndexChanged += new System.EventHandler(this.cmbEnterpriseName_SelectedIndexChanged);
            // 
            // lnklblVerify
            // 
            this.lnklblVerify.AutoSize = true;
            this.lnklblVerify.Enabled = false;
            this.lnklblVerify.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblVerify.Location = new System.Drawing.Point(213, 65);
            this.lnklblVerify.Name = "lnklblVerify";
            this.lnklblVerify.Size = new System.Drawing.Size(64, 13);
            this.lnklblVerify.TabIndex = 26;
            this.lnklblVerify.TabStop = true;
            this.lnklblVerify.Text = "Verify Id";
            this.lnklblVerify.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblVerify_LinkClicked);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 119);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(115, 13);
            this.label23.TabIndex = 23;
            this.label23.Text = "Enterprise name";
            // 
            // lnklblNewParty
            // 
            this.lnklblNewParty.AutoSize = true;
            this.lnklblNewParty.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblNewParty.Location = new System.Drawing.Point(213, 88);
            this.lnklblNewParty.Name = "lnklblNewParty";
            this.lnklblNewParty.Size = new System.Drawing.Size(73, 13);
            this.lnklblNewParty.TabIndex = 22;
            this.lnklblNewParty.TabStop = true;
            this.lnklblNewParty.Text = "New party";
            this.lnklblNewParty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblNewParty_LinkClicked);
            // 
            // txtEnterpriseId
            // 
            this.txtEnterpriseId.Location = new System.Drawing.Point(130, 65);
            this.txtEnterpriseId.Name = "txtEnterpriseId";
            this.txtEnterpriseId.Size = new System.Drawing.Size(77, 21);
            this.txtEnterpriseId.TabIndex = 21;
            this.txtEnterpriseId.TextChanged += new System.EventHandler(this.txtEnterpriseId_TextChanged);
            this.txtEnterpriseId.DoubleClick += new System.EventHandler(this.txtEnterpriseId_DoubleClick);
            this.txtEnterpriseId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterpriseId_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 73);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(93, 13);
            this.label24.TabIndex = 20;
            this.label24.Text = "Enterprise Id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Item Id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Category";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(317, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Metal";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(699, 167);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(237, 58);
            this.txtDescription.TabIndex = 19;
            this.txtDescription.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(317, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Gross Weight";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(317, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Net weight";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(712, 80);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(147, 21);
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
            this.label16.Location = new System.Drawing.Point(317, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Fine weight";
            // 
            // txtKarat
            // 
            this.txtKarat.Location = new System.Drawing.Point(712, 32);
            this.txtKarat.Name = "txtKarat";
            this.txtKarat.Size = new System.Drawing.Size(147, 21);
            this.txtKarat.TabIndex = 16;
            this.txtKarat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKarat_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(614, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Karat";
            // 
            // txtFineWeight
            // 
            this.txtFineWeight.Location = new System.Drawing.Point(416, 170);
            this.txtFineWeight.Name = "txtFineWeight";
            this.txtFineWeight.Size = new System.Drawing.Size(155, 21);
            this.txtFineWeight.TabIndex = 15;
            this.txtFineWeight.TextChanged += new System.EventHandler(this.txtFineWeight_TextChanged);
            this.txtFineWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFineWeight_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(614, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Quantity";
            // 
            // txtNetWeight
            // 
            this.txtNetWeight.Location = new System.Drawing.Point(416, 122);
            this.txtNetWeight.Name = "txtNetWeight";
            this.txtNetWeight.Size = new System.Drawing.Size(155, 21);
            this.txtNetWeight.TabIndex = 14;
            this.txtNetWeight.TextChanged += new System.EventHandler(this.txtNetWeight_TextChanged);
            this.txtNetWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNetWeight_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(614, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Bought date";
            // 
            // txtGrossWeight
            // 
            this.txtGrossWeight.Location = new System.Drawing.Point(416, 73);
            this.txtGrossWeight.Name = "txtGrossWeight";
            this.txtGrossWeight.Size = new System.Drawing.Size(155, 21);
            this.txtGrossWeight.TabIndex = 13;
            this.txtGrossWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrossWeight_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(614, 176);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 13);
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
            this.cmbMetal.Location = new System.Drawing.Point(416, 27);
            this.cmbMetal.Name = "cmbMetal";
            this.cmbMetal.Size = new System.Drawing.Size(155, 21);
            this.cmbMetal.TabIndex = 12;
            // 
            // txtItemId
            // 
            this.txtItemId.Enabled = false;
            this.txtItemId.Location = new System.Drawing.Point(130, 19);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(77, 21);
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
            this.cmbCategory.Location = new System.Drawing.Point(130, 157);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(155, 21);
            this.cmbCategory.TabIndex = 11;
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(461, 22);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(132, 21);
            this.txtDate.TabIndex = 18;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(0, 0);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(1242, 153);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.SelectionChanged += new System.EventHandler(this.dgvStock_SelectionChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(28, 296);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 28);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // StockDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1246, 590);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "StockDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockDetails";
            this.Load += new System.EventHandler(this.StockDetails_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpAddStock.ResumeLayout(false);
            this.grpAddStock.PerformLayout();
            this.grpBoxMode.ResumeLayout(false);
            this.grpBoxMode.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpAddStock;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDate;
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
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.LinkLabel lnklblVerify;
        private System.Windows.Forms.LinkLabel lnklblNewParty;
        private System.Windows.Forms.DateTimePicker dtpBoughtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBoxMode;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.TextBox txtEnterpriseId;
        public System.Windows.Forms.ComboBox cmbEnterpriseName;
    }
}