using DASInvoice.control;
using DASInvoice.model;
using DASInvoice.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DASInvoice
{
    public partial class FormMain
    {
        const String CLIENT_NAME= @"{client-name}";
        const String CLIENT_REPRESENTATIVE = @"{client-name}";
        const String CLIENT_EMAIL = @"{client-name}";
        const String CLIENT_INVOICE_ID = @"{client-name}";

        private void Initialize_Settings()
        {
            // 
            // Settings / Email Templates
            //
            richTextBox_EmailTemplate_Variables.AppendText(CLIENT_NAME);
            richTextBox_EmailTemplate_Variables.AppendText(" = ");
            richTextBox_EmailTemplate_Variables.SelectionColor = System.Drawing.Color.Red;
            richTextBox_EmailTemplate_Variables.AppendText("Client Company Name");
            richTextBox_EmailTemplate_Variables.SelectionColor = System.Drawing.Color.Black;
            richTextBox_EmailTemplate_Variables.AppendText("\r\n");
            richTextBox_EmailTemplate_Variables.AppendText(CLIENT_REPRESENTATIVE);
            richTextBox_EmailTemplate_Variables.AppendText(" = ");
            richTextBox_EmailTemplate_Variables.SelectionColor = System.Drawing.Color.Red;
            richTextBox_EmailTemplate_Variables.AppendText("Client First Name Last Name");
            richTextBox_EmailTemplate_Variables.SelectionColor = System.Drawing.Color.Black;
            richTextBox_EmailTemplate_Variables.AppendText("\r\n");
            richTextBox_EmailTemplate_Variables.AppendText(CLIENT_EMAIL);
            richTextBox_EmailTemplate_Variables.AppendText(" = ");
            richTextBox_EmailTemplate_Variables.SelectionColor = System.Drawing.Color.Red;
            richTextBox_EmailTemplate_Variables.AppendText("Client Company Email");
            richTextBox_EmailTemplate_Variables.SelectionColor = System.Drawing.Color.Black;
            richTextBox_EmailTemplate_Variables.AppendText("\r\n");
            richTextBox_EmailTemplate_Variables.AppendText(CLIENT_INVOICE_ID);
            richTextBox_EmailTemplate_Variables.AppendText(" = ");
            richTextBox_EmailTemplate_Variables.SelectionColor = System.Drawing.Color.Red;
            richTextBox_EmailTemplate_Variables.AppendText("Invoice number");
            richTextBox_EmailTemplate_Variables.SelectionColor = System.Drawing.Color.Black;
            richTextBox_EmailTemplate_Variables.AppendText("\r\n");

            //
            // Settings / Manage Users
            //
            dataGridView_ManageUsers.Columns["dataGridViewColumn_ManageUsers_Active"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_ManageUsers.Columns["dataGridViewColumn_ManageUsers_Active"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_ManageUsers.Columns["dataGridViewColumn_ManageUsers_Created"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_ManageUsers.Columns["dataGridViewColumn_ManageUsers_Created"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_ManageUsers.Columns["dataGridViewColumn_ManageUsers_PasswordRecovery"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_ManageUsers.Columns["dataGridViewColumn_ManageUsers_PasswordRecovery"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void RefreshList()
        {
            try
            {
                List<User> list = UserService.SelectAll();
                dataGridView_ManageUsers.Rows.Clear();
                foreach (User m in list)
                {
                    dataGridView_ManageUsers.Rows.Add(m.ID, m.Active, ToDateString(m.TimeRegistered), "Recover Password", "Delete");
                }
                dataGridView_ManageUsers.ClearSelection();
                int count = list.Count;
                if (count <= 1)
                    label_ManageUsers_Result.Text = $"[{count}] User.";
                else
                    label_ManageUsers_Result.Text = $"[{count}] Users.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage_Settings_ManageUsers_Enter(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void dataGridView_ManageUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = (DataGridViewCell)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (!(cell.OwningColumn is DataGridViewLinkColumn)) return;
            if (cell.Value == "Delete")
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to permanently delete this user?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    String id = (String)dataGridView_RecurringInvoices[0, cell.RowIndex].Value;
                    UserService.Delete(id);
                    RefreshList();
                }
            }
        }

    }
}
