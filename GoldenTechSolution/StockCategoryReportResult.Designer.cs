namespace GoldenTechSolution
{
    partial class StockCategoryReportResult
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.goldenTechDataDataSet21 = new GoldenTechSolution.GoldenTechDataDataSet21();
            this.stockDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockDetailsTableAdapter = new GoldenTechSolution.GoldenTechDataDataSet21TableAdapters.StockDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 51);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(851, 477);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.stockDetailsBindingSource;
            this.comboBox1.DisplayMember = "item_category";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "item_category";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // goldenTechDataDataSet21
            // 
            this.goldenTechDataDataSet21.DataSetName = "GoldenTechDataDataSet21";
            this.goldenTechDataDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockDetailsBindingSource
            // 
            this.stockDetailsBindingSource.DataMember = "StockDetails";
            this.stockDetailsBindingSource.DataSource = this.goldenTechDataDataSet21;
            // 
            // stockDetailsTableAdapter
            // 
            this.stockDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // StockCategoryReportResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 586);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "StockCategoryReportResult";
            this.Text = "StockCategoryReportResult";
            this.Load += new System.EventHandler(this.StockCategoryReportResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goldenTechDataDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private GoldenTechDataDataSet21 goldenTechDataDataSet21;
        private System.Windows.Forms.BindingSource stockDetailsBindingSource;
        private GoldenTechDataDataSet21TableAdapters.StockDetailsTableAdapter stockDetailsTableAdapter;
    }
}