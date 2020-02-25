namespace DASInvoice
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.label_Login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_LoginID = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_PasswordConfirm = new System.Windows.Forms.TextBox();
            this.linkLabel_SendVerificationCode = new System.Windows.Forms.LinkLabel();
            this.textBox_VerificationCode = new System.Windows.Forms.TextBox();
            this.button_Register = new System.Windows.Forms.Button();
            this.linkLabel_BackToLoginPage = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(12, 15);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(66, 19);
            this.label_Login.TabIndex = 0;
            this.label_Login.Text = "Login ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Verication Code:";
            // 
            // textBox_LoginID
            // 
            this.textBox_LoginID.Location = new System.Drawing.Point(94, 12);
            this.textBox_LoginID.Name = "textBox_LoginID";
            this.textBox_LoginID.Size = new System.Drawing.Size(200, 27);
            this.textBox_LoginID.TabIndex = 0;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(94, 111);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(200, 27);
            this.textBox_Email.TabIndex = 3;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(94, 45);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '●';
            this.textBox_Password.Size = new System.Drawing.Size(200, 27);
            this.textBox_Password.TabIndex = 1;
            // 
            // textBox_PasswordConfirm
            // 
            this.textBox_PasswordConfirm.Location = new System.Drawing.Point(94, 78);
            this.textBox_PasswordConfirm.Name = "textBox_PasswordConfirm";
            this.textBox_PasswordConfirm.PasswordChar = '●';
            this.textBox_PasswordConfirm.Size = new System.Drawing.Size(200, 27);
            this.textBox_PasswordConfirm.TabIndex = 2;
            // 
            // linkLabel_SendVerificationCode
            // 
            this.linkLabel_SendVerificationCode.AutoSize = true;
            this.linkLabel_SendVerificationCode.Location = new System.Drawing.Point(143, 144);
            this.linkLabel_SendVerificationCode.Name = "linkLabel_SendVerificationCode";
            this.linkLabel_SendVerificationCode.Size = new System.Drawing.Size(151, 19);
            this.linkLabel_SendVerificationCode.TabIndex = 4;
            this.linkLabel_SendVerificationCode.TabStop = true;
            this.linkLabel_SendVerificationCode.Text = "Send verification code";
            this.linkLabel_SendVerificationCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_SendVerificationCode_LinkClicked);
            // 
            // textBox_VerificationCode
            // 
            this.textBox_VerificationCode.Location = new System.Drawing.Point(147, 170);
            this.textBox_VerificationCode.Name = "textBox_VerificationCode";
            this.textBox_VerificationCode.Size = new System.Drawing.Size(147, 27);
            this.textBox_VerificationCode.TabIndex = 5;
            // 
            // button_Register
            // 
            this.button_Register.BackColor = System.Drawing.Color.Black;
            this.button_Register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Register.ForeColor = System.Drawing.Color.White;
            this.button_Register.Location = new System.Drawing.Point(166, 203);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(128, 36);
            this.button_Register.TabIndex = 6;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = false;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // linkLabel_BackToLoginPage
            // 
            this.linkLabel_BackToLoginPage.AutoSize = true;
            this.linkLabel_BackToLoginPage.Location = new System.Drawing.Point(9, 212);
            this.linkLabel_BackToLoginPage.Name = "linkLabel_BackToLoginPage";
            this.linkLabel_BackToLoginPage.Size = new System.Drawing.Size(129, 19);
            this.linkLabel_BackToLoginPage.TabIndex = 7;
            this.linkLabel_BackToLoginPage.TabStop = true;
            this.linkLabel_BackToLoginPage.Text = "Back to login page";
            this.linkLabel_BackToLoginPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_BackToLoginPage_LinkClicked);
            // 
            // FormRegister
            // 
            this.AcceptButton = this.button_Register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 249);
            this.Controls.Add(this.linkLabel_BackToLoginPage);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.textBox_VerificationCode);
            this.Controls.Add(this.linkLabel_SendVerificationCode);
            this.Controls.Add(this.textBox_PasswordConfirm);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_LoginID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Login);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegister_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_LoginID;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_PasswordConfirm;
        private System.Windows.Forms.LinkLabel linkLabel_SendVerificationCode;
        private System.Windows.Forms.TextBox textBox_VerificationCode;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.LinkLabel linkLabel_BackToLoginPage;
    }
}