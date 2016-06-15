namespace GoldenTechSolution
{
    partial class ForgotPassword
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
            this.btnsms = new System.Windows.Forms.Button();
            this.btnemail = new System.Windows.Forms.Button();
            this.btnsecurityquestions = new System.Windows.Forms.Button();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlSecurityQuestion = new System.Windows.Forms.Panel();
            this.lblError2 = new System.Windows.Forms.Label();
            this.lblError1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRetype2 = new System.Windows.Forms.TextBox();
            this.txtRetype1 = new System.Windows.Forms.TextBox();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.pnlSms = new System.Windows.Forms.Panel();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.btnSendSms = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlEmail.SuspendLayout();
            this.pnlSecurityQuestion.SuspendLayout();
            this.pnlSms.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpUser.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsms
            // 
            this.btnsms.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnsms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsms.Location = new System.Drawing.Point(10, 23);
            this.btnsms.Name = "btnsms";
            this.btnsms.Size = new System.Drawing.Size(150, 42);
            this.btnsms.TabIndex = 0;
            this.btnsms.Text = "Using Sms";
            this.btnsms.UseVisualStyleBackColor = false;
            this.btnsms.Click += new System.EventHandler(this.btnsms_Click);
            // 
            // btnemail
            // 
            this.btnemail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemail.Location = new System.Drawing.Point(10, 92);
            this.btnemail.Name = "btnemail";
            this.btnemail.Size = new System.Drawing.Size(145, 42);
            this.btnemail.TabIndex = 1;
            this.btnemail.Text = "Using e-mail";
            this.btnemail.UseVisualStyleBackColor = false;
            this.btnemail.Click += new System.EventHandler(this.btnemail_Click);
            // 
            // btnsecurityquestions
            // 
            this.btnsecurityquestions.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnsecurityquestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsecurityquestions.Location = new System.Drawing.Point(15, 176);
            this.btnsecurityquestions.Name = "btnsecurityquestions";
            this.btnsecurityquestions.Size = new System.Drawing.Size(145, 42);
            this.btnsecurityquestions.TabIndex = 2;
            this.btnsecurityquestions.Text = "Using secuirty question";
            this.btnsecurityquestions.UseVisualStyleBackColor = false;
            this.btnsecurityquestions.Click += new System.EventHandler(this.btnsecurityquestions_Click);
            // 
            // pnlEmail
            // 
            this.pnlEmail.Controls.Add(this.lblEmail);
            this.pnlEmail.Controls.Add(this.btnSendEmail);
            this.pnlEmail.Controls.Add(this.label6);
            this.pnlEmail.Location = new System.Drawing.Point(166, 35);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(474, 172);
            this.pnlEmail.TabIndex = 3;
            this.pnlEmail.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEmail.Location = new System.Drawing.Point(117, 73);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(130, 18);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email Address";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.Location = new System.Drawing.Point(131, 111);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(116, 26);
            this.btnSendEmail.TabIndex = 4;
            this.btnSendEmail.Text = "Click to send";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(470, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "The password would be sent as an E-mail to your Email Address";
            // 
            // pnlSecurityQuestion
            // 
            this.pnlSecurityQuestion.Controls.Add(this.lblError2);
            this.pnlSecurityQuestion.Controls.Add(this.lblError1);
            this.pnlSecurityQuestion.Controls.Add(this.label7);
            this.pnlSecurityQuestion.Controls.Add(this.label8);
            this.pnlSecurityQuestion.Controls.Add(this.label3);
            this.pnlSecurityQuestion.Controls.Add(this.label2);
            this.pnlSecurityQuestion.Controls.Add(this.txtRetype2);
            this.pnlSecurityQuestion.Controls.Add(this.txtRetype1);
            this.pnlSecurityQuestion.Controls.Add(this.lblQuestion2);
            this.pnlSecurityQuestion.Controls.Add(this.lblQuestion1);
            this.pnlSecurityQuestion.Controls.Add(this.btnSubmit);
            this.pnlSecurityQuestion.Controls.Add(this.txtAnswer2);
            this.pnlSecurityQuestion.Controls.Add(this.txtAnswer1);
            this.pnlSecurityQuestion.Location = new System.Drawing.Point(188, 14);
            this.pnlSecurityQuestion.Name = "pnlSecurityQuestion";
            this.pnlSecurityQuestion.Size = new System.Drawing.Size(439, 215);
            this.pnlSecurityQuestion.TabIndex = 4;
            this.pnlSecurityQuestion.Visible = false;
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.ForeColor = System.Drawing.Color.Red;
            this.lblError2.Location = new System.Drawing.Point(273, 161);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(74, 13);
            this.lblError2.TabIndex = 12;
            this.lblError2.Text = "Error message";
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.ForeColor = System.Drawing.Color.Red;
            this.lblError1.Location = new System.Drawing.Point(273, 58);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(74, 13);
            this.lblError1.TabIndex = 11;
            this.lblError1.Text = "Error message";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Re-type Answer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Answer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Re-type Answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Answer";
            // 
            // txtRetype2
            // 
            this.txtRetype2.Enabled = false;
            this.txtRetype2.Location = new System.Drawing.Point(96, 173);
            this.txtRetype2.Name = "txtRetype2";
            this.txtRetype2.Size = new System.Drawing.Size(155, 20);
            this.txtRetype2.TabIndex = 6;
            this.txtRetype2.TextChanged += new System.EventHandler(this.txtRetype2_TextChanged);
            // 
            // txtRetype1
            // 
            this.txtRetype1.Enabled = false;
            this.txtRetype1.Location = new System.Drawing.Point(96, 72);
            this.txtRetype1.Name = "txtRetype1";
            this.txtRetype1.Size = new System.Drawing.Size(155, 20);
            this.txtRetype1.TabIndex = 5;
            this.txtRetype1.TextChanged += new System.EventHandler(this.txtRetype1_TextChanged);
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.AutoSize = true;
            this.lblQuestion2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion2.Location = new System.Drawing.Point(8, 118);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(82, 16);
            this.lblQuestion2.TabIndex = 4;
            this.lblQuestion2.Text = "Question2";
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.AutoSize = true;
            this.lblQuestion1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion1.Location = new System.Drawing.Point(8, 16);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(82, 16);
            this.lblQuestion1.TabIndex = 3;
            this.lblQuestion1.Text = "Question1";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(304, 184);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 28);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(96, 139);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(155, 20);
            this.txtAnswer2.TabIndex = 1;
            this.txtAnswer2.TextChanged += new System.EventHandler(this.txtAnswer2_TextChanged);
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Location = new System.Drawing.Point(96, 37);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(155, 20);
            this.txtAnswer1.TabIndex = 0;
            this.txtAnswer1.TextChanged += new System.EventHandler(this.txtAnswer1_TextChanged);
            // 
            // pnlSms
            // 
            this.pnlSms.Controls.Add(this.lblMobileNumber);
            this.pnlSms.Controls.Add(this.btnSendSms);
            this.pnlSms.Controls.Add(this.label4);
            this.pnlSms.Location = new System.Drawing.Point(201, 0);
            this.pnlSms.Name = "pnlSms";
            this.pnlSms.Size = new System.Drawing.Size(471, 172);
            this.pnlSms.TabIndex = 5;
            this.pnlSms.Visible = false;
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMobileNumber.Location = new System.Drawing.Point(115, 85);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(138, 18);
            this.lblMobileNumber.TabIndex = 2;
            this.lblMobileNumber.Text = "Mobile number";
            // 
            // btnSendSms
            // 
            this.btnSendSms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendSms.Location = new System.Drawing.Point(132, 112);
            this.btnSendSms.Name = "btnSendSms";
            this.btnSendSms.Size = new System.Drawing.Size(100, 28);
            this.btnSendSms.TabIndex = 1;
            this.btnSendSms.Text = "Click to send";
            this.btnSendSms.UseVisualStyleBackColor = true;
            this.btnSendSms.Click += new System.EventHandler(this.btnSendSms_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(465, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "The password would be sent as an Sms to your mobile number:";
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(571, 309);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(81, 29);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlEmail);
            this.pnlMain.Controls.Add(this.pnlSms);
            this.pnlMain.Controls.Add(this.pnlSecurityQuestion);
            this.pnlMain.Controls.Add(this.btnsms);
            this.pnlMain.Controls.Add(this.btnemail);
            this.pnlMain.Controls.Add(this.btnsecurityquestions);
            this.pnlMain.Location = new System.Drawing.Point(12, 74);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(684, 232);
            this.pnlMain.TabIndex = 7;
            this.pnlMain.Visible = false;
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.btnValidate);
            this.grpUser.Controls.Add(this.txtUserName);
            this.grpUser.Controls.Add(this.label5);
            this.grpUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUser.Location = new System.Drawing.Point(145, 9);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(401, 56);
            this.grpUser.TabIndex = 8;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "Validate User";
            // 
            // btnValidate
            // 
            this.btnValidate.Enabled = false;
            this.btnValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(280, 21);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(82, 30);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(133, 28);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(119, 22);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter username";
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Location = new System.Drawing.Point(91, 12);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(499, 56);
            this.pnlStatus.TabIndex = 6;
            this.pnlStatus.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 16);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "status";
            // 
            // ForgotPassword
            // 
            this.AcceptButton = this.btnValidate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 341);
            this.Controls.Add(this.grpUser);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlStatus);
            this.MaximizeBox = false;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.pnlSecurityQuestion.ResumeLayout(false);
            this.pnlSecurityQuestion.PerformLayout();
            this.pnlSms.ResumeLayout(false);
            this.pnlSms.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsms;
        private System.Windows.Forms.Button btnemail;
        private System.Windows.Forms.Button btnsecurityquestions;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Panel pnlSecurityQuestion;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.Panel pnlSms;
        private System.Windows.Forms.Button btnSendSms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label lblMobileNumber;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpUser;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRetype2;
        private System.Windows.Forms.TextBox txtRetype1;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.Label lblError2;
    }
}