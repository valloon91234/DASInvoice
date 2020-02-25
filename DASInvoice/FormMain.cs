using DASInvoice.control;
using DASInvoice.dao;
using DASInvoice.model;
using DASInvoice.service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DASInvoice
{
    public partial class FormMain : Form
    {
        public const int VALIDATION_X = 16;
        public const int VALIDATION_Y = 8;
        public const int VALIDATION_DURATION = 3000;

        public static String UserName = null;
        public static FormLogin formLogin = new FormLogin();
        private List<Client> clientList = null;
        private List<String> invoiceList = null;

        public FormMain()
        {
            InitializeComponent();
            saveFileDialog_PDF.InitialDirectory = Application.StartupPath;
            if (!new FileInfo(BaseDao.DB_FILENAME).Exists)
            {
                MessageBox.Show($"The database file \"{BaseDao.DB_FILENAME}\" not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Exit();
            }
            // 
            // Dashboard / Summary
            //
            dataGridView_Summary_RecentInvoices.Columns["dataGridViewColumn_Dashboard_Summary_RecentInvoices_Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_Summary_RecentInvoices.Columns["dataGridViewColumn_Dashboard_Summary_RecentInvoices_Created"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_Summary_PastDueInvoices.Columns["dataGridViewColumn_Dashboard_Summary_PastDueInvoices_AmountDue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_Summary_PastDueInvoices.Columns["dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DueDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            Initialize_Client();
            Initialize_Invoice();
            Initialize_Settings();
            // 
            // Payments / Create Payment
            //
            comboBox_PostPayment_PaymentType.Items.AddRange(Payment.PAYMENT_TYPE_ARRAY);
            reset_PostPayment();
            //
            // Final
            //
            ResetCilentList();
            ResetInvoiceList();
            tabControl_Root_SelectedIndexChanged(tabControl_Root, null);
            tabControl_Clients.TabPages.Remove(tabPage_EditClient);
            tabControl_Invoices.TabPages.Remove(tabPage_Invoices_EditInvoice);
            tabControl_Invoices.TabPages.Remove(tabPage_Invoices_EditRecurringInvoice);
            tabControl_Payments.TabPages.Remove(tabPage_Payments_EditPayment);
        }

        public static void Exit()
        {
            Process.GetCurrentProcess().Kill();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            formLogin.ShowDialog(); //TODO
            tabPage_Dashboard_Summary_Enter(null, null);
        }

        private static String ToDateString(DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }


        #region Reset
        private void ResetComboBoxClientList(ComboBox comboBox, Boolean preserveValue = false)
        {
            if (clientList == null) clientList = ClientService.GetAll();
            String originalValue = comboBox.Text;
            var items = comboBox.Items;
            items.Clear();
            int i = 0;
            int selected = -1;
            foreach (Client e in clientList)
            {
                String value = e.FullName;
                items.Add(value);
                if (preserveValue && originalValue == value)
                    selected = i;
                i++;
            }
            if (selected >= 0) comboBox.SelectedIndex = selected;
        }

        private void ResetComboBoxInvoiceList(ComboBox comboBox, Boolean preserveValue = false)
        {
            if (invoiceList == null) invoiceList = InvoiceService.GetIDALL();
            String originalValue = comboBox.Text;
            var items = comboBox.Items;
            items.Clear();
            int i = 0;
            int selected = -1;
            foreach (String e in invoiceList)
            {
                items.Add(e);
                if (preserveValue && originalValue == e)
                    selected = i;
                i++;
            }
            if (selected >= 0) comboBox.SelectedIndex = selected;
        }

        private void ResetCilentList()
        {
            clientList = ClientService.GetAll();
            ResetComboBoxClientList(comboBox_EditInvoice_SelectClient, true);
            ResetComboBoxClientList(comboBox_CreateInvoice_SelectClient, true);
            ResetComboBoxClientList(comboBox_SearchInvoice_Client, true);
            ResetComboBoxClientList(comboBox_CreateRecurringInvoice_SelectClient, true);
            ResetComboBoxClientList(comboBox_PendingInvoices_Client, true);
            ResetComboBoxClientList(comboBox_RecurringInvoices_Client, true);
            ResetComboBoxClientList(comboBox_EditRecurringInvoice_SelectClient, true);
        }

        private void ResetInvoiceList()
        {
            invoiceList = InvoiceService.GetIDALL();
            ResetComboBoxInvoiceList(comboBox_PostPayment_InvoiceID, true);
            dataGridView_SearchInvoice.Rows.Clear();
            dataGridView_RecurringInvoices.Rows.Clear();
        }

        private void reset_PostPayment()
        {
            comboBox_PostPayment_InvoiceID.Text = "";
            comboBox_PostPayment_PaymentType.SelectedIndex = -1;
            //dateTimePicker_PostPayment_PaymentDate.Value = DateTime.Now;
            textBox_PostPayment_Amount.Text = "";
            label_PostPayment_Currency.Text = "";
            textBox_PostPayment_Notes.Text = "";
        }

        #endregion Reset

        private void tabControl_Root_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage currentTab = (sender as TabControl).SelectedTab;
            if (currentTab.Text == "Dashboard")
            {
                this.tabPage_Dashboard_SearchInvoice.Controls.Add(this.splitContainer_SearchInvoice_Root);
                this.tabPage_Dashboard_CreateInvoice.Controls.Add(this.splitContainer_CreateInvoice_Root);
                this.tabPage_Dashboard_PostPayment.Controls.Add(this.groupBox_PostPayment);
            }
            else
            {
                this.tabPage_Invoices_SearchInvoice.Controls.Add(this.splitContainer_SearchInvoice_Root);
                this.tabPage_Invoices_CreateInvoice.Controls.Add(this.splitContainer_CreateInvoice_Root);
                this.tabPage_Payments_PostPayment.Controls.Add(this.groupBox_PostPayment);
            }
        }


        #region PostPayment
        private void comboBox_PostPayment_InvoiceID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String invoiceID = comboBox_PostPayment_InvoiceID.Text;
                if (String.IsNullOrEmpty(invoiceID)) goto goto_comboBox_PostPayment_InvoiceID_0;
                Invoice invoice = InvoiceService.Get(invoiceID);
                if (invoice == null) goto goto_comboBox_PostPayment_InvoiceID_0;
                Client client = ClientService.Get(invoice.ClientID);
                label_PostPayment_Currency.Text = client.CurrencyWithSymbol;
                return;
            }
            catch { }
        goto_comboBox_PostPayment_InvoiceID_0:
            label_PostPayment_Currency.Text = "";
        }

        private void button_PostPayment_PostPayment_Click(object sender, EventArgs e)
        {
            String invoiceID = comboBox_PostPayment_InvoiceID.Text;
            Invoice invoice = InvoiceService.Get(invoiceID);
            if (invoice == null)
            {
                MessageBox.Show("Can not find Invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_PostPayment_InvoiceID.Focus();
                return;
            }
            String paymentType = comboBox_PostPayment_PaymentType.Text;
            if (String.IsNullOrWhiteSpace(paymentType))
            {
                MessageBox.Show("Please select payment type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_PostPayment_PaymentType.Focus();
                return;
            }
            DateTime paymentDate = dateTimePicker_PostPayment_PaymentDate.Value;
            Decimal amount;
            if (!Decimal.TryParse(textBox_PostPayment_Amount.Text, out amount))
            {
                MessageBox.Show("Amount value is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_PostPayment_Amount.Focus();
                return;
            }
            String notes = textBox_PostPayment_Notes.Text;
            try
            {
                Payment m = new Payment();
                m.InvoiceID = invoiceID;
                m.PaymentType = paymentType;
                m.PaymentDate = paymentDate;
                m.Amount = amount;
                m.Notes = notes;
                PaymentService.Insert(m);
                MessageBox.Show("You have posted a payment.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset_PostPayment();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to post a payment.\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion PostPayment


        #region SearchPayment
        private void button_SearchPayment_Search_Click(object sender, EventArgs e)
        {
            String paymentID = textBox_SearchPayment_PaymentID.Text;
            String invoiceID = textBox_SearchPayment_InvoiceID.Text;
            String clientName = comboBox_SearchPayment_Client.Text;
            DateTime dateFrom = dateTimePicker_SearchPayment_DateFrom.Value;
            DateTime dateTo = dateTimePicker_SearchPayment_DateTo.Value;
            var rows = dataGridView_SearchPayment.Rows;
            rows.Clear();
            List<Payment> list = PaymentService.Select(paymentID, invoiceID, clientName, dateFrom, dateTo, true);
            foreach (Payment m in list)
            {
                rows.Add(new String[] { m.PaymentID, m.InvoiceID, m.Amount.ToString(), m.Notes, ToDateString(m.TimeRegistered), "View", "Print", "Delete" });
            }
            int count = list.Count;
            if (count == 0)
                label_SearchPayment_Result.Text = "[0] Payment.";
            else if (count == 1)
                label_SearchPayment_Result.Text = "[1] Payment.";
            else
                label_SearchPayment_Result.Text = String.Format("[{0}] Payments.", count);
            dataGridView_SearchPayment.ClearSelection();
        }
        #endregion SearchPayment


        #region Summary
        private void tabPage_Dashboard_Summary_Enter(object sender, EventArgs e)
        {
            {
                var rows = dataGridView_Summary_RecentInvoices.Rows;
                rows.Clear();
                List<Invoice> list = InvoiceService.Select(null, null, null, null, null, null, false, true, 10);
                foreach (Invoice m in list)
                {
                    rows.Add(new String[] { m.InvoiceID, m.ClientObject.Company, m.Total.ToString("N") + " " + m.ClientObject.CurrencySymbol, ToDateString(m.TimeRegistered), m.Status });
                }
                dataGridView_Summary_RecentInvoices.ClearSelection();
            }
            {
                var rows = dataGridView_Summary_PastDueInvoices.Rows;
                rows.Clear();
                List<Invoice> list = InvoiceService.Select(null, null, null, null, null, DateTime.Now, false, true, 10);
                foreach (Invoice m in list)
                {
                    rows.Add(new String[] { m.InvoiceID, m.ClientObject.Company, m.Total.ToString("N") + " " + m.ClientObject.CurrencySymbol, ToDateString(m.DueDate), (m.DueDate - m.InvoiceDate).Days + " days" });
                }
                dataGridView_Summary_PastDueInvoices.ClearSelection();
            }
            {
                FileInfo fileInfo = new FileInfo(BaseDao.DB_FILENAME);
                String systemDate = ToDateString(DateTime.Now);
                String smtpServer = "Not Set";
                String fileSize = (fileInfo.Length / 1024d / 1024d).ToString("N");
                int emailSent = 0;
                textBox_Summary_UserStatus.Text = String.Format(@"User: {0}
System Date: {1}
SMTP Server: {2}
Database Size: {3} MB
Emails sent this session: {4}", UserName, systemDate, smtpServer, fileSize, emailSent);
            }
        }

        #endregion Summary

    }
}
