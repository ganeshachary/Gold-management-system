namespace GoldenTech
{
    partial class NewParty
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
            this.txtEnterpriseId = new System.Windows.Forms.Label();
            this.txtEnterpriseName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEnterpriseDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddEnterprise = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEnterpriseId
            // 
            this.txtEnterpriseId.AutoSize = true;
            this.txtEnterpriseId.Location = new System.Drawing.Point(8, 37);
            this.txtEnterpriseId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEnterpriseId.Name = "txtEnterpriseId";
            this.txtEnterpriseId.Size = new System.Drawing.Size(102, 16);
            this.txtEnterpriseId.TabIndex = 0;
            this.txtEnterpriseId.Text = "Enterprise Id";
            // 
            // txtEnterpriseName
            // 
            this.txtEnterpriseName.AutoSize = true;
            this.txtEnterpriseName.Location = new System.Drawing.Point(8, 78);
            this.txtEnterpriseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEnterpriseName.Name = "txtEnterpriseName";
            this.txtEnterpriseName.Size = new System.Drawing.Size(128, 16);
            this.txtEnterpriseName.TabIndex = 1;
            this.txtEnterpriseName.Text = "Enterprise name";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(178, 30);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 23);
            this.txtId.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(178, 71);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 23);
            this.txtName.TabIndex = 3;
            // 
            // txtEnterpriseDescription
            // 
            this.txtEnterpriseDescription.AutoSize = true;
            this.txtEnterpriseDescription.Location = new System.Drawing.Point(8, 123);
            this.txtEnterpriseDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEnterpriseDescription.Name = "txtEnterpriseDescription";
            this.txtEnterpriseDescription.Size = new System.Drawing.Size(168, 16);
            this.txtEnterpriseDescription.TabIndex = 4;
            this.txtEnterpriseDescription.Text = "Enterprise description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(178, 120);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(263, 57);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEnterpriseId);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtEnterpriseName);
            this.groupBox1.Controls.Add(this.txtEnterpriseDescription);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(458, 184);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new enterprise";
            // 
            // btnAddEnterprise
            // 
            this.btnAddEnterprise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddEnterprise.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEnterprise.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddEnterprise.Location = new System.Drawing.Point(28, 211);
            this.btnAddEnterprise.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddEnterprise.Name = "btnAddEnterprise";
            this.btnAddEnterprise.Size = new System.Drawing.Size(180, 32);
            this.btnAddEnterprise.TabIndex = 7;
            this.btnAddEnterprise.Text = "Add enterprise";
            this.btnAddEnterprise.UseVisualStyleBackColor = true;
            this.btnAddEnterprise.Click += new System.EventHandler(this.btnAddEnterprise_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(216, 211);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 32);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(346, 211);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 32);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewParty
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 248);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddEnterprise);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NewParty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewParty";
            this.Load += new System.EventHandler(this.NewParty_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtEnterpriseId;
        private System.Windows.Forms.Label txtEnterpriseName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label txtEnterpriseDescription;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddEnterprise;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
    }
}