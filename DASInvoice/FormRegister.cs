using DASInvoice.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DASInvoice
{
    public partial class FormRegister : Form
    {
        private String verificationCode = null;

        public FormRegister()
        {
            InitializeComponent();
        }

        private void linkLabel_BackToLoginPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoFormLogin();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            String loginID = textBox_LoginID.Text.Trim();
            String password = textBox_Password.Text;
            String passwordConfirm = textBox_PasswordConfirm.Text;
            String email = textBox_Email.Text.Trim();
            String verificationCode = textBox_VerificationCode.Text.Trim();
            if (loginID == "")
            {
                MessageBox.Show("Please input your Login ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_LoginID.Focus();
            }
            else if (password == "")
            {
                MessageBox.Show("Please input your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Password.Focus();
            }
            else if (password != passwordConfirm)
            {
                MessageBox.Show("Password does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Password.Focus();
            }
            else if (email == "")
            {
                MessageBox.Show("Please input your Email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Email.Focus();
            }
            else if (!Util.IsValidEmail(email))
            {
                MessageBox.Show("Your Email address is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Email.Focus();
            }
            else if (verificationCode == "")
            {
                MessageBox.Show("Please input your Verification Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_VerificationCode.Focus();
            }
            else if (UserService.IsExist(loginID))
            {
                MessageBox.Show("Your Login ID has already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_LoginID.Focus();
            }
            else
            {
                int result= UserService.Insert(loginID, password, email);
                MessageBox.Show("You have registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoFormLogin();
            }
        }

        private void linkLabel_SendVerificationCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String email = textBox_Email.Text.Trim();
            if (email == "")
            {
                MessageBox.Show("Please input your Email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (verificationCode == null)
            {
                Random random = new Random(email.GetHashCode());
                verificationCode = random.Next(999999).ToString("D6");
            }
            try
            {
                string from = "email-verification-noreply@dasinvoice.com";
                string to = email;
                String subject = "Verify your account.";
                String body = @"Welcome to DASInvoice.
Your Verification Code is " + verificationCode;
                Boolean success = StmpService.Send(from, to, subject, body);
                if (success)
                    MessageBox.Show("Your Verification Code is sent to your email address.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send to your email address.\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            GoFormLogin();
        }

        private void GoFormLogin()
        {
            this.Close();
            this.Dispose();
            FormMain.formLogin.Show();
        }
    }
}
