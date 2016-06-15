namespace GoldenTechSolution
{
    partial class CustomerCityForm
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.goldenTechDataDataSet20 = new GoldenTechSolution.GoldenTechDataDataSet20();
            this.customerAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerAddressTableAdapter = new GoldenTechSolution.GoldenTechDataDataSet20TableAdapters.CustomerAddressTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAddressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 38);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1136, 574);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select City";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.customerAddressBindingSource;
            this.comboBox1.DisplayMember = "city";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "city";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // goldenTechDataDataSet20
            // 
            this.goldenTechDataDataSet20.DataSetName = "GoldenTechDataDataSet20";
            this.goldenTechDataDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerAddressBindingSource
            // 
            this.customerAddressBindingSource.DataMember = "CustomerAddress";
            this.customerAddressBindingSource.DataSource = this.goldenTechDataDataSet20;
            // 
            // customerAddressTableAdapter
            // 
            this.customerAddressTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "View all";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "CustomerCityForm";
            this.Text = "CustomerCityForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerCityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAddressBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private GoldenTechDataDataSet20 goldenTechDataDataSet20;
        private System.Windows.Forms.BindingSource customerAddressBindingSource;
        private GoldenTechDataDataSet20TableAdapters.CustomerAddressTableAdapter customerAddressTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}