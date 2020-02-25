namespace DASInvoice
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_LoginID = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.linkLabel_ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.button_Login = new System.Windows.Forms.Button();
            this.linkLabel_Register = new System.Windows.Forms.LinkLabel();
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
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(12, 53);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(75, 19);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password:";
            // 
            // textBox_LoginID
            // 
            this.textBox_LoginID.Location = new System.Drawing.Point(92, 12);
            this.textBox_LoginID.Name = "textBox_LoginID";
            this.textBox_LoginID.Size = new System.Drawing.Size(200, 27);
            this.textBox_LoginID.TabIndex = 1;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(92, 50);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '●';
            this.textBox_Password.Size = new System.Drawing.Size(200, 27);
            this.textBox_Password.TabIndex = 2;
            // 
            // linkLabel_ForgotPassword
            // 
            this.linkLabel_ForgotPassword.AutoSize = true;
            this.linkLabel_ForgotPassword.Location = new System.Drawing.Point(12, 111);
            this.linkLabel_ForgotPassword.Name = "linkLabel_ForgotPassword";
            this.linkLabel_ForgotPassword.Size = new System.Drawing.Size(123, 19);
            this.linkLabel_ForgotPassword.TabIndex = 5;
            this.linkLabel_ForgotPassword.TabStop = true;
            this.linkLabel_ForgotPassword.Text = "Forgot Password?";
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.Black;
            this.button_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Login.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.Location = new System.Drawing.Point(162, 87);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(128, 36);
            this.button_Login.TabIndex = 3;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // linkLabel_Register
            // 
            this.linkLabel_Register.AutoSize = true;
            this.linkLabel_Register.Location = new System.Drawing.Point(12, 87);
            this.linkLabel_Register.Name = "linkLabel_Register";
            this.linkLabel_Register.Size = new System.Drawing.Size(94, 19);
            this.linkLabel_Register.TabIndex = 4;
            this.linkLabel_Register.TabStop = true;
            this.linkLabel_Register.Text = "Register new";
            this.linkLabel_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Register_LinkClicked);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.button_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(302, 137);
            this.Controls.Add(this.linkLabel_Register);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.linkLabel_ForgotPassword);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_LoginID);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Login);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_LoginID;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.LinkLabel linkLabel_ForgotPassword;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.LinkLabel linkLabel_Register;
    }
}