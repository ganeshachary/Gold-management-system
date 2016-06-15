namespace GoldenTechSolution
{
    partial class Stocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stocks));
            this.tabEdit = new System.Windows.Forms.TabControl();
            this.tabStocksIn = new System.Windows.Forms.TabPage();
            this.grpboxAction = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpControlsEdit = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.grpToDate = new System.Windows.Forms.GroupBox();
            this.dtPickerTo = new System.Windows.Forms.DateTimePicker();
            this.grpFromDate = new System.Windows.Forms.GroupBox();
            this.dtPickerFrom = new System.Windows.Forms.DateTimePicker();
            this.grpboxDisplayCategory = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnFindCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpboxFind = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindId = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.grpStocksDetails = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabEdit.SuspendLayout();
            this.tabStocksIn.SuspendLayout();
            this.grpboxAction.SuspendLayout();
            this.grpControlsEdit.SuspendLayout();
            this.grpToDate.SuspendLayout();
            this.grpFromDate.SuspendLayout();
            this.grpboxDisplayCategory.SuspendLayout();
            this.grpboxFind.SuspendLayout();
            this.grpStocksDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEdit
            // 
            this.tabEdit.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabEdit.Controls.Add(this.tabStocksIn);
            this.tabEdit.Controls.Add(this.tabPage2);
            this.tabEdit.Controls.Add(this.tabPage1);
            this.tabEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEdit.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEdit.Location = new System.Drawing.Point(0, 0);
            this.tabEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.SelectedIndex = 0;
            this.tabEdit.Size = new System.Drawing.Size(1096, 579);
            this.tabEdit.TabIndex = 0;
            // 
            // tabStocksIn
            // 
            this.tabStocksIn.BackColor = System.Drawing.Color.White;
            this.tabStocksIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabStocksIn.Controls.Add(this.grpboxAction);
            this.tabStocksIn.Controls.Add(this.grpControlsEdit);
            this.tabStocksIn.Controls.Add(this.grpToDate);
            this.tabStocksIn.Controls.Add(this.grpFromDate);
            this.tabStocksIn.Controls.Add(this.grpboxDisplayCategory);
            this.tabStocksIn.Controls.Add(this.grpboxFind);
            this.tabStocksIn.Controls.Add(this.grpStocksDetails);
            this.tabStocksIn.Location = new System.Drawing.Point(4, 25);
            this.tabStocksIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabStocksIn.Name = "tabStocksIn";
            this.tabStocksIn.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabStocksIn.Size = new System.Drawing.Size(1088, 550);
            this.tabStocksIn.TabIndex = 0;
            this.tabStocksIn.Text = " new";
            // 
            // grpboxAction
            // 
            this.grpboxAction.Controls.Add(this.label4);
            this.grpboxAction.Controls.Add(this.label3);
            this.grpboxAction.Controls.Add(this.btnEdit);
            this.grpboxAction.Controls.Add(this.btnSearch);
            this.grpboxAction.Location = new System.Drawing.Point(17, 14);
            this.grpboxAction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpboxAction.Name = "grpboxAction";
            this.grpboxAction.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpboxAction.Size = new System.Drawing.Size(114, 98);
            this.grpboxAction.TabIndex = 12;
            this.grpboxAction.TabStop = false;
            this.grpboxAction.Text = "Action";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Change";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search";
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(8, 56);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(28, 29);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(8, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 34);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // grpControlsEdit
            // 
            this.grpControlsEdit.Controls.Add(this.btnAddUser);
            this.grpControlsEdit.Controls.Add(this.btnUpdate);
            this.grpControlsEdit.Controls.Add(this.btnDeleteUser);
            this.grpControlsEdit.Location = new System.Drawing.Point(9, 236);
            this.grpControlsEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpControlsEdit.Name = "grpControlsEdit";
            this.grpControlsEdit.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpControlsEdit.Size = new System.Drawing.Size(114, 163);
            this.grpControlsEdit.TabIndex = 11;
            this.grpControlsEdit.TabStop = false;
            this.grpControlsEdit.Text = "Edit";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(8, 22);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(86, 31);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(8, 72);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 31);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.Image")));
            this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.Location = new System.Drawing.Point(8, 119);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(86, 33);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // grpToDate
            // 
            this.grpToDate.Controls.Add(this.dtPickerTo);
            this.grpToDate.Location = new System.Drawing.Point(424, 14);
            this.grpToDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpToDate.Name = "grpToDate";
            this.grpToDate.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpToDate.Size = new System.Drawing.Size(118, 42);
            this.grpToDate.TabIndex = 10;
            this.grpToDate.TabStop = false;
            this.grpToDate.Text = "To";
            // 
            // dtPickerTo
            // 
            this.dtPickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerTo.Location = new System.Drawing.Point(8, 14);
            this.dtPickerTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtPickerTo.Name = "dtPickerTo";
            this.dtPickerTo.Size = new System.Drawing.Size(102, 19);
            this.dtPickerTo.TabIndex = 0;
            // 
            // grpFromDate
            // 
            this.grpFromDate.Controls.Add(this.dtPickerFrom);
            this.grpFromDate.Location = new System.Drawing.Point(301, 14);
            this.grpFromDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpFromDate.Name = "grpFromDate";
            this.grpFromDate.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpFromDate.Size = new System.Drawing.Size(115, 42);
            this.grpFromDate.TabIndex = 9;
            this.grpFromDate.TabStop = false;
            this.grpFromDate.Text = "From";
            // 
            // dtPickerFrom
            // 
            this.dtPickerFrom.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerFrom.Location = new System.Drawing.Point(8, 14);
            this.dtPickerFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtPickerFrom.Name = "dtPickerFrom";
            this.dtPickerFrom.Size = new System.Drawing.Size(89, 19);
            this.dtPickerFrom.TabIndex = 0;
            // 
            // grpboxDisplayCategory
            // 
            this.grpboxDisplayCategory.Controls.Add(this.comboBox1);
            this.grpboxDisplayCategory.Controls.Add(this.btnFindCategory);
            this.grpboxDisplayCategory.Controls.Add(this.label2);
            this.grpboxDisplayCategory.Location = new System.Drawing.Point(561, 14);
            this.grpboxDisplayCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpboxDisplayCategory.Name = "grpboxDisplayCategory";
            this.grpboxDisplayCategory.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpboxDisplayCategory.Size = new System.Drawing.Size(320, 42);
            this.grpboxDisplayCategory.TabIndex = 8;
            this.grpboxDisplayCategory.TabStop = false;
            this.grpboxDisplayCategory.Text = "Display";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Chain",
            "Ear Ring",
            "Rings",
            "Payal",
            "Nose Ring",
            "Ear Chain"});
            this.comboBox1.Location = new System.Drawing.Point(86, 13);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // btnFindCategory
            // 
            this.btnFindCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindCategory.BackgroundImage")));
            this.btnFindCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindCategory.Location = new System.Drawing.Point(254, 12);
            this.btnFindCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFindCategory.Name = "btnFindCategory";
            this.btnFindCategory.Size = new System.Drawing.Size(29, 20);
            this.btnFindCategory.TabIndex = 7;
            this.btnFindCategory.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category";
            // 
            // grpboxFind
            // 
            this.grpboxFind.Controls.Add(this.btnCancel);
            this.grpboxFind.Controls.Add(this.textBox1);
            this.grpboxFind.Controls.Add(this.label1);
            this.grpboxFind.Controls.Add(this.btnFindId);
            this.grpboxFind.Controls.Add(this.btnShowAll);
            this.grpboxFind.Location = new System.Drawing.Point(8, 128);
            this.grpboxFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpboxFind.Name = "grpboxFind";
            this.grpboxFind.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpboxFind.Size = new System.Drawing.Size(223, 93);
            this.grpboxFind.TabIndex = 3;
            this.grpboxFind.TabStop = false;
            this.grpboxFind.Text = "Find";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Location = new System.Drawing.Point(179, 63);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(36, 27);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 19);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // btnFindId
            // 
            this.btnFindId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindId.BackgroundImage")));
            this.btnFindId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindId.Location = new System.Drawing.Point(141, 63);
            this.btnFindId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFindId.Name = "btnFindId";
            this.btnFindId.Size = new System.Drawing.Size(30, 27);
            this.btnFindId.TabIndex = 1;
            this.btnFindId.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(12, 63);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(100, 27);
            this.btnShowAll.TabIndex = 0;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            // 
            // grpStocksDetails
            // 
            this.grpStocksDetails.Controls.Add(this.dataGridView1);
            this.grpStocksDetails.Location = new System.Drawing.Point(257, 62);
            this.grpStocksDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpStocksDetails.Name = "grpStocksDetails";
            this.grpStocksDetails.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpStocksDetails.Size = new System.Drawing.Size(807, 448);
            this.grpStocksDetails.TabIndex = 2;
            this.grpStocksDetails.TabStop = false;
            this.grpStocksDetails.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(799, 430);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1088, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1088, 550);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Change";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Stocks
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1096, 579);
            this.Controls.Add(this.tabEdit);
            this.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Italic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Stocks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabEdit.ResumeLayout(false);
            this.tabStocksIn.ResumeLayout(false);
            this.grpboxAction.ResumeLayout(false);
            this.grpboxAction.PerformLayout();
            this.grpControlsEdit.ResumeLayout(false);
            this.grpToDate.ResumeLayout(false);
            this.grpFromDate.ResumeLayout(false);
            this.grpboxDisplayCategory.ResumeLayout(false);
            this.grpboxDisplayCategory.PerformLayout();
            this.grpboxFind.ResumeLayout(false);
            this.grpboxFind.PerformLayout();
            this.grpStocksDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEdit;
        private System.Windows.Forms.TabPage tabStocksIn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpboxFind;
        private System.Windows.Forms.Button btnFindCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindId;
        private System.Windows.Forms.GroupBox grpStocksDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox grpboxDisplayCategory;
        private System.Windows.Forms.GroupBox grpControlsEdit;
        private System.Windows.Forms.GroupBox grpToDate;
        private System.Windows.Forms.DateTimePicker dtPickerTo;
        private System.Windows.Forms.GroupBox grpFromDate;
        private System.Windows.Forms.DateTimePicker dtPickerFrom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpboxAction;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabPage tabPage1;
    }
}