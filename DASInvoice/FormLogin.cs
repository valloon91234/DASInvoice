using DASInvoice.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DASInvoice
{
    public partial class FormLogin : Form
    {
        private Boolean LoginSuccess = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void linkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            this.Hide();
            formRegister.ShowDialog();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!LoginSuccess)
                FormMain.Exit();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            String loginID = textBox_LoginID.Text;
            String password = textBox_Password.Text;
            if (loginID == "")
            {
                MessageBox.Show("Please input your Login ID", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_LoginID.Focus();
                textBox_LoginID.SelectAll();
            }
            else if (password == "")
            {
                MessageBox.Show("Please input your Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Password.Focus();
            }
            else if (password != UserService.GetPassword(loginID))
            {
                MessageBox.Show("Woring password. Try again.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Password.Focus();
                textBox_Password.SelectAll();
            }
            else
            {
                LoginSuccess = true;
                FormMain.UserName = loginID;
                this.Close();
            }
        }
    }
}
