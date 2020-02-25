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
        private String OldInvoiceID = null;

        private void Initialize_Invoice()
        {
            // 
            // Invoices / Search Invoice
            //
            comboBox_SearchInvoice_InvoiceStatus.Items.Add("");
            comboBox_SearchInvoice_InvoiceStatus.Items.AddRange(Invoice.STATUS_ARRAY);
            comboBox_SearchInvoice_InvoiceStatus.SelectedIndex = 0;
            dataGridView_SearchInvoice.Columns["dataGridViewColumn_SearchInvoice_Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_SearchInvoice.Columns["dataGridViewColumn_SearchInvoice_Created"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_SearchInvoice.Columns["dataGridViewColumn_SearchInvoice_DueDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // 
            // Invoices / Edit Invoice
            //
            comboBox_EditInvoice_Status.Items.AddRange(Invoice.STATUS_ARRAY);
            comboBox_EditInvoice_Status.SelectedIndex = 0;
            reset_EditInvoice();
            // 
            // Invoices / Create Invoice
            //
            comboBox_CreateInvoice_Status.Items.AddRange(Invoice.STATUS_ARRAY);
            comboBox_CreateInvoice_Status.SelectedIndex = 0;
            reset_CreateInvoice();
            // 
            // Invoices / Create Recurring Invoice
            //
            comboBox_CreateRecurringInvoice_Status.Items.AddRange(Invoice.STATUS_ARRAY);
            comboBox_CreateRecurringInvoice_Status.SelectedIndex = 0;
            reset_CreateRecurringInvoice();
            // 
            // Invoices / Pending Invoices
            //
            dataGridView_PendingInvoices.Columns["dataGridViewColumn_PendingInvoices_Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_PendingInvoices.Columns["dataGridViewColumn_PendingInvoices_Created"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_PendingInvoices.Columns["dataGridViewColumn_PendingInvoices_DueDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // 
            // Invoices / Recurring Invoices
            //
            dataGridView_RecurringInvoices.Columns["dataGridViewColumn_RecurringInvoices_Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_RecurringInvoices.Columns["dataGridViewColumn_RecurringInvoices_Created"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_RecurringInvoices.Columns["dataGridViewColumn_RecurringInvoices_NextDays"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_RecurringInvoices.Columns["dataGridViewColumn_RecurringInvoices_DueDays"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // 
            // Invoices / Edit Recurring Invoice
            //
            comboBox_EditRecurringInvoice_Status.Items.AddRange(Invoice.STATUS_ARRAY);
            comboBox_EditRecurringInvoice_Status.SelectedIndex = 0;
            reset_EditRecurringInvoice();
        }

        private void reset_EditInvoice(Boolean resetClient = true, Boolean resetValue = false)
        {
            if (resetClient)
            {
                panel_EditInvoice_SelectClient.Visible = true;
                textBox_EditInvoice_ClientDetail.Visible = false;
                button_EditInvoice_ChangeClient.Visible = false;
                splitContainer_EditInvoice_Root.Panel2.Enabled = false;
                splitContainer_EditInvoice_Client.Panel2.Enabled = false;
                textBox_EditInvoice_InvoiceID.Text = "";
            }
            if (resetValue)
            {
                comboBox_EditInvoice_Status.SelectedIndex = 0;
                radioButton_EditInvoice_Send2Client_Yes.Checked = true;
                radioButton_EditInvoice_Send2Client_No.Checked = false;
                gridView_EditInvoice_InvoiceItem.Rows.Clear();
                textBox_EditInvoice_Comments.Text = "";
                textBox_EditInvoice_SubTotal.Text = "0";
                numericUpDown_EditInvoice_VAT_Percent.Value = 0;
                textBox_EditInvoice_Payments.Text = "$0.00";
                textBox_EditInvoice_AmountDue.Text = "$0.00";
            }
        }

        private void reset_CreateInvoice(Boolean resetClient = true, Boolean resetValue = false)
        {
            if (resetClient)
            {
                panel_CreateInvoice_SelectClient.Visible = true;
                textBox_CreateInvoice_ClientDetail.Visible = false;
                button_CreateInvoice_ChangeClient.Visible = false;
                splitContainer_CreateInvoice_Root.Panel2.Enabled = false;
                splitContainer_CreateInvoice_Client.Panel2.Enabled = false;
                textBox_CreateInvoice_InvoiceID.Text = "";
            }
            if (resetValue)
            {
                comboBox_CreateInvoice_Status.SelectedIndex = 0;
                radioButton_CreateInvoice_Send2Client_Yes.Checked = true;
                radioButton_CreateInvoice_Send2Client_No.Checked = false;
                gridView_CreateInvoice_InvoiceItem.Rows.Clear();
                textBox_CreateInvoice_Comments.Text = "";
                textBox_CreateInvoice_SubTotal.Text = "0";
                numericUpDown_CreateInvoice_VAT_Percent.Value = 0;
                textBox_CreateInvoice_Payments.Text = "$0.00";
                textBox_CreateInvoice_AmountDue.Text = "$0.00";
            }
        }

        private void reset_CreateRecurringInvoice(Boolean resetClient = true, Boolean resetValue = false)
        {
            if (resetClient)
            {
                panel_CreateRecurringInvoice_SelectClient.Visible = true;
                textBox_CreateRecurringInvoice_ClientDetail.Visible = false;
                button_CreateRecurringInvoice_ChangeClient.Visible = false;
                splitContainer_CreateRecurringInvoice_Root.Panel2.Enabled = false;
                splitContainer_CreateRecurringInvoice_Client.Panel2.Enabled = false;
                textBox_CreateRecurringInvoice_InvoiceID.Text = "";
            }
            if (resetValue)
            {
                comboBox_CreateRecurringInvoice_Status.SelectedIndex = 0;
                radioButton_CreateRecurringInvoice_Send2Client_Yes.Checked = true;
                radioButton_CreateRecurringInvoice_Send2Client_No.Checked = false;
                gridView_CreateRecurringInvoice_InvoiceItem.Rows.Clear();
                textBox_CreateRecurringInvoice_Comments.Text = "";
                textBox_CreateRecurringInvoice_SubTotal.Text = "0";
                numericUpDown_CreateInvoice_VAT_Percent.Value = 0;
            }
        }

        private void reset_EditRecurringInvoice(Boolean resetClient = true, Boolean resetValue = false)
        {
            if (resetClient)
            {
                panel_EditRecurringInvoice_SelectClient.Visible = true;
                textBox_EditRecurringInvoice_ClientDetail.Visible = false;
                button_EditRecurringInvoice_ChangeClient.Visible = false;
                splitContainer_EditRecurringInvoice_Root.Panel2.Enabled = false;
                splitContainer_EditRecurringInvoice_Client.Panel2.Enabled = false;
                textBox_EditRecurringInvoice_InvoiceID.Text = "";
            }
            if (resetValue)
            {
                comboBox_EditRecurringInvoice_Status.SelectedIndex = 0;
                radioButton_EditRecurringInvoice_Send2Client_Yes.Checked = true;
                radioButton_EditRecurringInvoice_Send2Client_No.Checked = false;
                gridView_EditRecurringInvoice_InvoiceItem.Rows.Clear();
                textBox_EditRecurringInvoice_Comments.Text = "";
                textBox_EditRecurringInvoice_SubTotal.Text = "0";
                numericUpDown_EditInvoice_VAT_Percent.Value = 0;
            }
        }

        private void openEditInvoice(String invoiceID)
        {
            OldInvoiceID = invoiceID;
            Invoice invoice = InvoiceService.Get(invoiceID);
            Client c = ClientService.Get(invoice.ClientID);
            String clientDetail = c.Company;
            if (!String.IsNullOrWhiteSpace(c.TIN)) clientDetail += "\r\nTIN # " + c.TIN;
            if (!String.IsNullOrWhiteSpace(c.VAT)) clientDetail += "\r\nVAT # " + c.VAT;
            if (!String.IsNullOrWhiteSpace(c.Address1)) clientDetail += "\r\n" + c.Address1;
            if (!String.IsNullOrWhiteSpace(c.Address2)) clientDetail += ", " + c.Address2;
            if (!String.IsNullOrWhiteSpace(c.City) && !String.IsNullOrWhiteSpace(c.State)) clientDetail += "\r\n" + c.City + ", " + c.State;
            else if (!String.IsNullOrWhiteSpace(c.City)) clientDetail += "\r\n" + c.City;
            else if (!String.IsNullOrWhiteSpace(c.State)) clientDetail += "\r\n" + c.State;
            if (!String.IsNullOrWhiteSpace(c.Country)) clientDetail += "\r\n" + c.Country;
            if (!invoice.IsRecurring)
            {
                reset_EditInvoice();
                tabControl_Root.SelectTab(tabPage_Invoices);
                if (!tabControl_Invoices.TabPages.Contains(tabPage_Invoices_EditInvoice))
                    tabControl_Invoices.TabPages.Insert(1, tabPage_Invoices_EditInvoice);
                tabControl_Invoices.SelectTab(tabPage_Invoices_EditInvoice);
                comboBox_EditInvoice_SelectClient.Text = c.FullName;
                panel_EditInvoice_SelectClient.Visible = false;
                textBox_EditInvoice_ClientDetail.Text = clientDetail;
                textBox_EditInvoice_ClientDetail.Visible = true;
                button_EditInvoice_ChangeClient.Visible = true;
                splitContainer_EditInvoice_Root.Panel2.Enabled = true;
                splitContainer_EditInvoice_Client.Panel2.Enabled = true;
                textBox_EditInvoice_InvoiceID.Text = invoiceID;
                dateTimePicker_EditInvoice_InvoiceDate.Value = invoice.InvoiceDate;
                dateTimePicker_EditInvoice_DueDate.Value = invoice.DueDate;
                comboBox_EditInvoice_Status.Text = invoice.Status;
                if (invoice.Send2Client == Invoice.SEND2CLIENT_YES)
                    radioButton_EditInvoice_Send2Client_Yes.Checked = true;
                else if (invoice.Send2Client == Invoice.SEND2CLIENT_NO)
                    radioButton_EditInvoice_Send2Client_No.Checked = true;
                numericUpDown_EditInvoice_VAT_Percent.Value = invoice.VATPercent;
                textBox_EditInvoice_Comments.Text = invoice.Comments;
                textBox_EditInvoice_Payments.Text = c.CurrencySymbol + PaymentService.GetSumPayment(invoiceID).ToString("N2");
                gridView_EditInvoice_InvoiceItem.Rows.Clear();
                List<InvoiceItem> invoiceItemList = InvoiceService.SelectItem(invoiceID);
                foreach (InvoiceItem m in invoiceItemList)
                {
                    gridView_EditInvoice_InvoiceItem.Rows.Add(m.Description, m.Quanitity, m.UnitPrice, m.Total);
                }
                try
                {
                    Decimal subTotal = 0;
                    for (int i = 0; i < gridView_EditInvoice_InvoiceItem.RowCount; i++)
                    {
                        Decimal quantity = Convert.ToInt32(gridView_EditInvoice_InvoiceItem[1, i].Value);
                        Decimal unitPrice = Convert.ToDecimal(gridView_EditInvoice_InvoiceItem[2, i].Value);
                        subTotal += quantity * unitPrice;
                    }
                    textBox_EditInvoice_SubTotal.Text = subTotal.ToString();
                }
                catch
                {
                    textBox_EditInvoice_SubTotal.Text = "0";
                }
            }
            else
            {
                reset_EditRecurringInvoice();
                if (!tabControl_Invoices.TabPages.Contains(tabPage_Invoices_EditRecurringInvoice))
                    tabControl_Invoices.TabPages.Add(tabPage_Invoices_EditRecurringInvoice);
                tabControl_Invoices.SelectTab(tabPage_Invoices_EditRecurringInvoice);
                comboBox_EditRecurringInvoice_SelectClient.Text = c.FullName;
                panel_EditRecurringInvoice_SelectClient.Visible = false;
                textBox_EditRecurringInvoice_ClientDetail.Text = clientDetail;
                textBox_EditRecurringInvoice_ClientDetail.Visible = true;
                button_EditRecurringInvoice_ChangeClient.Visible = true;
                splitContainer_EditRecurringInvoice_Root.Panel2.Enabled = true;
                splitContainer_EditRecurringInvoice_Client.Panel2.Enabled = true;
                textBox_EditRecurringInvoice_InvoiceID.Text = invoiceID;
                dateTimePicker_EditRecurringInvoice_InvoiceDate.Value = invoice.InvoiceDate;
                dateTimePicker_EditRecurringInvoice_DueDate.Value = invoice.DueDate;
                comboBox_EditRecurringInvoice_Status.Text = invoice.Status;
                if (invoice.Send2Client == Invoice.SEND2CLIENT_YES)
                    radioButton_EditRecurringInvoice_Send2Client_Yes.Checked = true;
                else if (invoice.Send2Client == Invoice.SEND2CLIENT_NO)
                    radioButton_EditRecurringInvoice_Send2Client_No.Checked = true;
                numericUpDown_EditRecurringInvoice_NextDays.Value = invoice.NextDays;
                numericUpDown_EditRecurringInvoice_DueDays.Value = invoice.DueDays;
                numericUpDown_EditRecurringInvoice_VAT_Percent.Value = invoice.VATPercent;
                textBox_EditRecurringInvoice_Comments.Text = invoice.Comments;
                //textBox_EditRecurringInvoice_Payments.Text = c.CurrencySymbol + PaymentService.GetSumPayment(invoiceID).ToString("N2");
                gridView_EditRecurringInvoice_InvoiceItem.Rows.Clear();
                List<InvoiceItem> invoiceItemList = InvoiceService.SelectItem(invoiceID);
                foreach (InvoiceItem m in invoiceItemList)
                {
                    gridView_EditRecurringInvoice_InvoiceItem.Rows.Add(m.Description, m.Quanitity, m.UnitPrice, m.Total);
                }
                try
                {
                    Decimal subTotal = 0;
                    for (int i = 0; i < gridView_EditRecurringInvoice_InvoiceItem.RowCount; i++)
                    {
                        Decimal quantity = Convert.ToInt32(gridView_EditRecurringInvoice_InvoiceItem[1, i].Value);
                        Decimal unitPrice = Convert.ToDecimal(gridView_EditRecurringInvoice_InvoiceItem[2, i].Value);
                        subTotal += quantity * unitPrice;
                    }
                    textBox_EditRecurringInvoice_SubTotal.Text = subTotal.ToString();
                }
                catch
                {
                    textBox_EditRecurringInvoice_SubTotal.Text = "0";
                }
            }
        }

        #region SearchInvoice
        private void button_SearchInvoice_Search_Click(object sender, EventArgs e)
        {
            String invoiceID = textBox_SearchInvoice_InvoiceID.Text;
            String clientName = comboBox_SearchInvoice_Client.Text;
            String status = comboBox_SearchInvoice_InvoiceStatus.Text;
            DateTime dateFrom = dateTimePicker_SearchInvoice_DateFrom.Value;
            DateTime dateTo = dateTimePicker_SearchInvoice_DateTo.Value;
            var rows = dataGridView_SearchInvoice.Rows;
            rows.Clear();
            List<Invoice> list = InvoiceService.Select(invoiceID, clientName, status, dateFrom, dateTo, null, false, true);
            foreach (Invoice m in list)
            {
                rows.Add(new String[] { m.InvoiceID, m.ClientObject.Company, m.Comments, m.Total.ToString("N") + " " + m.ClientObject.CurrencySymbol, ToDateString(m.InvoiceDate), ToDateString(m.DueDate), m.Status, "View", "Print", "Delete" });
            }
            int count = list.Count;
            if (count == 0)
                label_SearchInvoice_Result.Text = "[0] Invoice.";
            else if (count == 1)
                label_SearchInvoice_Result.Text = "[1] Invoice.";
            else
                label_SearchInvoice_Result.Text = String.Format("[{0}] Invoices.", count);
            dataGridView_SearchInvoice.ClearSelection();
        }

        #endregion SearchInvoice



        #region EditInvoice
        private void dataGridView_SearchInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = (DataGridViewCell)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (!(cell.OwningColumn is DataGridViewLinkColumn)) return;
            if (cell.Value == "View" || e.ColumnIndex == 0)
            {
                String invoiceID = (String)dataGridView_SearchInvoice[0, cell.RowIndex].Value;
                openEditInvoice(invoiceID);
            }
            else if (cell.Value == "Delete")
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to permanently delete this invoice?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    String invoiceID = (String)dataGridView_SearchInvoice[0, cell.RowIndex].Value;
                    InvoiceService.Delete(invoiceID);
                    button_SearchInvoice_Search_Click(null, null);
                }
            }
        }

        private void button_EditInvoice_SelectClient_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox_EditInvoice_SelectClient.SelectedIndex;
            if (selectedIndex < 0)
            {
                MessageBox.Show("Please select a client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Client c = clientList[selectedIndex];
            panel_EditInvoice_SelectClient.Visible = false;
            String text = c.FullName;
            if (!String.IsNullOrWhiteSpace(c.TIN)) text += "\r\nTIN #: " + c.TIN;
            if (!String.IsNullOrWhiteSpace(c.VAT)) text += "\r\nVAT #: " + c.VAT;
            if (!String.IsNullOrWhiteSpace(c.Address1)) text += "\r\n: " + c.Address1;
            if (!String.IsNullOrWhiteSpace(c.Address2)) text += "\r\n: " + c.Address2;
            if (!String.IsNullOrWhiteSpace(c.City) && !String.IsNullOrWhiteSpace(c.State)) text += "\r\n" + c.City + ", " + c.State;
            else if (!String.IsNullOrWhiteSpace(c.City)) text += "\r\n" + c.City;
            else if (!String.IsNullOrWhiteSpace(c.State)) text += "\r\n" + c.State;
            if (!String.IsNullOrWhiteSpace(c.Country)) text += "\r\n" + c.Country;
            textBox_EditInvoice_ClientDetail.Text = text;
            textBox_EditInvoice_ClientDetail.Visible = true;
            button_EditInvoice_ChangeClient.Visible = true;
            splitContainer_EditInvoice_Root.Panel2.Enabled = true;
            splitContainer_EditInvoice_Client.Panel2.Enabled = true;
            textBox_EditInvoice_InvoiceID.Text = InvoiceService.GetNextInvoiceID(c.InvoiceIDAssign);
            if (c.VATApplicable == Client.VAT_APPLICABLE_YES) numericUpDown_EditInvoice_VAT_Percent.Value = c.VATPercent;
            label_EditInvoice_Total.Text = "Total " + c.CurrencyWithSymbol;
        }

        private void button_EditInvoice_ChangeClient_Click(object sender, EventArgs e)
        {
            reset_EditInvoice();
        }

        private void gridView_EditInvoice_InvoiceItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 1 || e.ColumnIndex == 2))
            {
                var obj = ((GridViewCustom)sender);
                try
                {
                    Decimal quantity = Convert.ToDecimal(obj[1, e.RowIndex].Value);
                    Decimal unitPrice = Convert.ToDecimal(obj[2, e.RowIndex].Value);
                    ((GridViewCustom)sender)[3, e.RowIndex].Value = (quantity * unitPrice).ToString();
                }
                catch
                {
                    ((GridViewCustom)sender)[3, e.RowIndex].Value = "";
                }
                try
                {
                    Decimal subTotal = 0;
                    for (int i = 0; i < obj.RowCount; i++)
                    {
                        Decimal quantity = Convert.ToInt32(obj[1, i].Value);
                        Decimal unitPrice = Convert.ToDecimal(obj[2, i].Value);
                        subTotal += quantity * unitPrice;
                    }
                    textBox_EditInvoice_SubTotal.Text = subTotal.ToString();
                }
                catch
                {
                    textBox_EditInvoice_SubTotal.Text = "0";
                }
            }
        }

        private void textBox_EditInvoice_SubTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Decimal subTotal = Convert.ToDecimal(textBox_EditInvoice_SubTotal.Text);
                Decimal vatPercent = numericUpDown_EditInvoice_VAT_Percent.Value;
                Decimal vatValue = subTotal * vatPercent / 100;
                textBox_EditInvoice_VAT_Value.Text = vatValue.ToString();
                textBox_EditInvoice_GrandTotal.Text = (subTotal + vatValue).ToString();
                Decimal payment = Decimal.Parse(textBox_EditInvoice_Payments.Text.Substring(1));
                String currency = clientList[comboBox_EditInvoice_SelectClient.SelectedIndex].CurrencySymbol;
                textBox_EditInvoice_AmountDue.Text = currency + (subTotal + vatValue - payment).ToString("N2");
            }
            catch
            {
                textBox_EditInvoice_VAT_Value.Text = "0";
                textBox_EditInvoice_GrandTotal.Text = "$0.00";
                textBox_EditInvoice_AmountDue.Text = "$0.00";
            }
        }

        private void numericUpDown_EditInvoice_VAT_Percent_ValueChanged(object sender, EventArgs e)
        {
            textBox_EditInvoice_SubTotal_TextChanged(sender, e);
        }

        private void button_EditInvoice_SaveInvoice_Click(object sender, EventArgs e)
        {
            int count = gridView_EditInvoice_InvoiceItem.RowCount;
            if (count < 2)
            {
                MessageBox.Show("No invoice item to save.\r\nPlease input invoice items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i < count; i++)
            {
                if (gridView_EditInvoice_InvoiceItem[1, i].Value == null && gridView_EditInvoice_InvoiceItem[2, i].Value == null) continue;
                if (!Decimal.TryParse(gridView_EditInvoice_InvoiceItem[1, i].Value.ToString(), out _) || !Decimal.TryParse(gridView_EditInvoice_InvoiceItem[2, i].Value.ToString(), out _))
                {
                    MessageBox.Show("Some Qty or Unit Price values are invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            Client client = clientList[comboBox_EditInvoice_SelectClient.SelectedIndex];
            String invoiceID = textBox_EditInvoice_InvoiceID.Text;
            using (var transaction = dao.BaseDao.connection.BeginTransaction())
                try
                {
                    if (OldInvoiceID != null)
                    {
                        InvoiceService.Delete(OldInvoiceID);
                        OldInvoiceID = null;
                    }
                    else
                    {
                        Console.WriteLine("OldInvoiceID is null");
                    }
                    invoiceID = InvoiceService.GetNextInvoiceID(client.InvoiceIDAssign);
                    int countItem = 0;
                    for (int i = 0; i < count; i++)
                    {
                        if (gridView_EditInvoice_InvoiceItem[1, i].Value == null && gridView_EditInvoice_InvoiceItem[2, i].Value == null) continue;
                        InvoiceItem m = new InvoiceItem();
                        m.InvoiceID = invoiceID;
                        m.Description = Convert.ToString(gridView_EditInvoice_InvoiceItem[0, i].Value);
                        m.Quanitity = Convert.ToDecimal(gridView_EditInvoice_InvoiceItem[1, i].Value);
                        m.UnitPrice = Convert.ToDecimal(gridView_EditInvoice_InvoiceItem[2, i].Value);
                        if (m.Quanitity == 0) continue;
                        InvoiceService.InsertItem(m);
                        countItem++;
                    }
                    if (countItem == 0)
                    {
                        transaction.Rollback();
                        MessageBox.Show("No invoice item to save.\r\nPlease input invoice items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    {
                        Invoice m = new Invoice();
                        m.InvoiceID = invoiceID;
                        m.ClientObject = client;
                        m.InvoiceDate = dateTimePicker_EditInvoice_InvoiceDate.Value;
                        m.DueDate = dateTimePicker_EditInvoice_DueDate.Value;
                        m.Status = comboBox_EditInvoice_Status.Text;
                        if (radioButton_EditInvoice_Send2Client_Yes.Checked)
                            m.Send2Client = Invoice.SEND2CLIENT_YES;
                        else if (radioButton_EditInvoice_Send2Client_No.Checked)
                            m.Send2Client = Invoice.SEND2CLIENT_NO;
                        m.VATPercent = numericUpDown_EditInvoice_VAT_Percent.Value;
                        m.Comments = textBox_EditInvoice_Comments.Text;
                        InvoiceService.Insert(m);
                    }
                    MessageBox.Show("Invoice saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetInvoiceList();
                    tabControl_Invoices.TabPages.Remove(tabPage_Invoices_EditInvoice);
                    //reset_EditInvoice(false, true);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    ExceptionLogService.Log(ex);
                    MessageBox.Show("There was an error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        #endregion EditInvoice


        #region CreateInvoice

        private void button_CreateInvoice_SelectClient_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox_CreateInvoice_SelectClient.SelectedIndex;
            if (selectedIndex < 0)
            {
                MessageBox.Show("Please select a client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Client c = clientList[selectedIndex];
            panel_CreateInvoice_SelectClient.Visible = false;
            String text = c.FullName;
            if (!String.IsNullOrWhiteSpace(c.TIN)) text += "\r\nTIN #: " + c.TIN;
            if (!String.IsNullOrWhiteSpace(c.VAT)) text += "\r\nVAT #: " + c.VAT;
            if (!String.IsNullOrWhiteSpace(c.Address1)) text += "\r\n: " + c.Address1;
            if (!String.IsNullOrWhiteSpace(c.Address2)) text += "\r\n: " + c.Address2;
            if (!String.IsNullOrWhiteSpace(c.City) && !String.IsNullOrWhiteSpace(c.State)) text += "\r\n" + c.City + ", " + c.State;
            else if (!String.IsNullOrWhiteSpace(c.City)) text += "\r\n" + c.City;
            else if (!String.IsNullOrWhiteSpace(c.State)) text += "\r\n" + c.State;
            if (!String.IsNullOrWhiteSpace(c.Country)) text += "\r\n" + c.Country;
            textBox_CreateInvoice_ClientDetail.Text = text;
            textBox_CreateInvoice_ClientDetail.Visible = true;
            button_CreateInvoice_ChangeClient.Visible = true;
            splitContainer_CreateInvoice_Root.Panel2.Enabled = true;
            splitContainer_CreateInvoice_Client.Panel2.Enabled = true;
            textBox_CreateInvoice_InvoiceID.Text = InvoiceService.GetNextInvoiceID(c.InvoiceIDAssign);
            if (c.VATApplicable == Client.VAT_APPLICABLE_YES) numericUpDown_CreateInvoice_VAT_Percent.Value = c.VATPercent;
            label_CreateInvoice_Total.Text = "Total " + c.CurrencyWithSymbol;
        }

        private void button_CreateInvoice_ChangeClient_Click(object sender, EventArgs e)
        {
            reset_CreateInvoice();
        }

        private void gridView_CreateInvoice_InvoiceItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 1 || e.ColumnIndex == 2))
            {
                var obj = ((GridViewCustom)sender);
                try
                {
                    Decimal quantity = Convert.ToDecimal(obj[1, e.RowIndex].Value);
                    Decimal unitPrice = Convert.ToDecimal(obj[2, e.RowIndex].Value);
                    ((GridViewCustom)sender)[3, e.RowIndex].Value = (quantity * unitPrice).ToString();
                }
                catch
                {
                    ((GridViewCustom)sender)[3, e.RowIndex].Value = "";
                }
                try
                {
                    Decimal subTotal = 0;
                    for (int i = 0; i < obj.RowCount; i++)
                    {
                        Decimal quantity = Convert.ToInt32(obj[1, i].Value);
                        Decimal unitPrice = Convert.ToDecimal(obj[2, i].Value);
                        subTotal += quantity * unitPrice;
                    }
                    textBox_CreateInvoice_SubTotal.Text = subTotal.ToString();
                }
                catch
                {
                    textBox_CreateInvoice_SubTotal.Text = "0";
                }
            }
        }

        private void textBox_CreateInvoice_SubTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Decimal subTotal = Convert.ToDecimal(textBox_CreateInvoice_SubTotal.Text);
                Decimal vatPercent = numericUpDown_CreateInvoice_VAT_Percent.Value;
                Decimal vatValue = subTotal * vatPercent / 100;
                textBox_CreateInvoice_VAT_Value.Text = vatValue.ToString();
                textBox_CreateInvoice_GrandTotal.Text = (subTotal + vatValue).ToString();
                Decimal payment = 0;
                String currency = clientList[comboBox_CreateInvoice_SelectClient.SelectedIndex].CurrencySymbol;
                textBox_CreateInvoice_AmountDue.Text = currency + (subTotal + vatValue - payment).ToString("N2");
            }
            catch
            {
                textBox_CreateInvoice_VAT_Value.Text = "0";
                textBox_CreateInvoice_GrandTotal.Text = "$0.00";
                textBox_CreateInvoice_AmountDue.Text = "$0.00";
            }
        }

        private void numericUpDown_CreateInvoice_VAT_Percent_ValueChanged(object sender, EventArgs e)
        {
            textBox_CreateInvoice_SubTotal_TextChanged(sender, e);
        }

        private void button_CreateInvoice_SaveInvoice_Click(object sender, EventArgs e)
        {
            int count = gridView_CreateInvoice_InvoiceItem.RowCount;
            if (count < 2)
            {
                MessageBox.Show("No invoice item to save.\r\nPlease input invoice items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gridView_CreateInvoice_InvoiceItem.Focus();
                return;
            }
            for (int i = 0; i < count; i++)
            {
                if (gridView_CreateInvoice_InvoiceItem[1, i].Value == null && gridView_CreateInvoice_InvoiceItem[2, i].Value == null) continue;
                if (!Decimal.TryParse(gridView_CreateInvoice_InvoiceItem[1, i].Value.ToString(), out _) || !Decimal.TryParse(gridView_CreateInvoice_InvoiceItem[2, i].Value.ToString(), out _))
                {
                    MessageBox.Show("Some Qty or Unit Price values are invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gridView_CreateInvoice_InvoiceItem.Focus();
                    return;
                }
            }
            Client client = clientList[comboBox_CreateInvoice_SelectClient.SelectedIndex];
            String invoiceID = InvoiceService.GetNextInvoiceID(client.InvoiceIDAssign);
            using (var transaction = dao.BaseDao.connection.BeginTransaction())
                try
                {
                    int countItem = 0;
                    for (int i = 0; i < count; i++)
                    {
                        if (gridView_CreateInvoice_InvoiceItem[1, i].Value == null && gridView_CreateInvoice_InvoiceItem[2, i].Value == null) continue;
                        InvoiceItem m = new InvoiceItem();
                        m.InvoiceID = invoiceID;
                        m.Description = Convert.ToString(gridView_CreateInvoice_InvoiceItem[0, i].Value);
                        m.Quanitity = Convert.ToDecimal(gridView_CreateInvoice_InvoiceItem[1, i].Value);
                        m.UnitPrice = Convert.ToDecimal(gridView_CreateInvoice_InvoiceItem[2, i].Value);
                        if (m.Quanitity == 0) continue;
                        InvoiceService.InsertItem(m);
                        countItem++;
                    }
                    if (countItem == 0)
                    {
                        MessageBox.Show("No invoice item to save.\r\nPlease input invoice items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    {
                        Invoice m = new Invoice();
                        m.InvoiceID = invoiceID;
                        m.ClientObject = client;
                        m.InvoiceDate = dateTimePicker_CreateInvoice_InvoiceDate.Value;
                        m.DueDate = dateTimePicker_CreateInvoice_DueDate.Value;
                        m.Status = comboBox_CreateInvoice_Status.Text;
                        if (radioButton_CreateInvoice_Send2Client_Yes.Checked)
                            m.Send2Client = Invoice.SEND2CLIENT_YES;
                        else if (radioButton_CreateInvoice_Send2Client_No.Checked)
                            m.Send2Client = Invoice.SEND2CLIENT_NO;
                        m.VATPercent = numericUpDown_CreateInvoice_VAT_Percent.Value;
                        m.Comments = textBox_CreateInvoice_Comments.Text;
                        InvoiceService.Insert(m);
                    }
                    MessageBox.Show("Invoice saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetInvoiceList();
                    reset_CreateInvoice(false, true);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    ExceptionLogService.Log(ex);
                    MessageBox.Show("There was an error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        #endregion CreateInvoice



        #region CreateRecurringInvoice

        private void button_CreateRecurringInvoice_SelectClient_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox_CreateRecurringInvoice_SelectClient.SelectedIndex;
            if (selectedIndex < 0)
            {
                MessageBox.Show("Please select a client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Client c = clientList[selectedIndex];
            panel_CreateRecurringInvoice_SelectClient.Visible = false;
            String text = c.FullName;
            if (!String.IsNullOrWhiteSpace(c.TIN)) text += "\r\nTIN #: " + c.TIN;
            if (!String.IsNullOrWhiteSpace(c.VAT)) text += "\r\nVAT #: " + c.VAT;
            if (!String.IsNullOrWhiteSpace(c.Address1)) text += "\r\n: " + c.Address1;
            if (!String.IsNullOrWhiteSpace(c.Address2)) text += "\r\n: " + c.Address2;
            if (!String.IsNullOrWhiteSpace(c.City) && !String.IsNullOrWhiteSpace(c.State)) text += "\r\n" + c.City + ", " + c.State;
            else if (!String.IsNullOrWhiteSpace(c.City)) text += "\r\n" + c.City;
            else if (!String.IsNullOrWhiteSpace(c.State)) text += "\r\n" + c.State;
            if (!String.IsNullOrWhiteSpace(c.Country)) text += "\r\n" + c.Country;
            textBox_CreateRecurringInvoice_ClientDetail.Text = text;
            textBox_CreateRecurringInvoice_ClientDetail.Visible = true;
            button_CreateRecurringInvoice_ChangeClient.Visible = true;
            splitContainer_CreateRecurringInvoice_Root.Panel2.Enabled = true;
            splitContainer_CreateRecurringInvoice_Client.Panel2.Enabled = true;
            textBox_CreateRecurringInvoice_InvoiceID.Text = InvoiceService.GetNextInvoiceID(c.InvoiceIDAssign);
            if (c.VATApplicable == Client.VAT_APPLICABLE_YES) numericUpDown_CreateRecurringInvoice_VAT_Percent.Value = c.VATPercent;
            label_CreateRecurringInvoice_Total.Text = "Total " + c.CurrencyWithSymbol;
        }

        private void button_CreateRecurringInvoice_ChangeClient_Click(object sender, EventArgs e)
        {
            reset_CreateRecurringInvoice();
        }

        private void gridView_CreateRecurringInvoice_InvoiceItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 1 || e.ColumnIndex == 2))
            {
                var obj = ((GridViewCustom)sender);
                try
                {
                    Decimal quantity = Convert.ToDecimal(obj[1, e.RowIndex].Value);
                    Decimal unitPrice = Convert.ToDecimal(obj[2, e.RowIndex].Value);
                    ((GridViewCustom)sender)[3, e.RowIndex].Value = (quantity * unitPrice).ToString();
                }
                catch
                {
                    ((GridViewCustom)sender)[3, e.RowIndex].Value = "";
                }
                try
                {
                    Decimal subTotal = 0;
                    for (int i = 0; i < obj.RowCount; i++)
                    {
                        Decimal quantity = Convert.ToInt32(obj[1, i].Value);
                        Decimal unitPrice = Convert.ToDecimal(obj[2, i].Value);
                        subTotal += quantity * unitPrice;
                    }
                    textBox_CreateRecurringInvoice_SubTotal.Text = subTotal.ToString();
                }
                catch
                {
                    textBox_CreateRecurringInvoice_SubTotal.Text = "0";
                }
            }
        }

        private void textBox_CreateRecurringInvoice_SubTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Decimal subTotal = Convert.ToDecimal(textBox_CreateRecurringInvoice_SubTotal.Text);
                Decimal vatPercent = numericUpDown_CreateRecurringInvoice_VAT_Percent.Value;
                Decimal vatValue = subTotal * vatPercent / 100;
                textBox_CreateRecurringInvoice_VAT_Value.Text = vatValue.ToString();
                textBox_CreateRecurringInvoice_GrandTotal.Text = (subTotal + vatValue).ToString();
            }
            catch
            {
                textBox_CreateRecurringInvoice_VAT_Value.Text = "0";
                textBox_CreateRecurringInvoice_GrandTotal.Text = "0";
            }
        }

        private void numericUpDown_CreateRecurringInvoice_VAT_Percent_ValueChanged(object sender, EventArgs e)
        {
            textBox_CreateRecurringInvoice_SubTotal_TextChanged(sender, e);
        }

        private void button_CreateRecurringInvoice_SaveInvoice_Click(object sender, EventArgs e)
        {
            int count = gridView_CreateRecurringInvoice_InvoiceItem.RowCount;
            if (count < 2)
            {
                MessageBox.Show("No invoice item to save.\r\nPlease input invoice items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i < count; i++)
            {
                if (gridView_CreateRecurringInvoice_InvoiceItem[1, i].Value == null && gridView_CreateRecurringInvoice_InvoiceItem[2, i].Value == null) continue;
                if (!Decimal.TryParse(gridView_CreateRecurringInvoice_InvoiceItem[1, i].Value.ToString(), out _) || !Decimal.TryParse(gridView_CreateRecurringInvoice_InvoiceItem[2, i].Value.ToString(), out _))
                {
                    MessageBox.Show("Some Qty or Unit Price values are invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            Client client = clientList[comboBox_CreateRecurringInvoice_SelectClient.SelectedIndex];
            String invoiceID = InvoiceService.GetNextInvoiceID(client.InvoiceIDAssign);
            using (var transaction = dao.BaseDao.connection.BeginTransaction())
                try
                {
                    int countItem = 0;
                    for (int i = 0; i < count; i++)
                    {
                        if (gridView_CreateRecurringInvoice_InvoiceItem[1, i].Value == null && gridView_CreateRecurringInvoice_InvoiceItem[2, i].Value == null) continue;
                        InvoiceItem m = new InvoiceItem();
                        m.InvoiceID = invoiceID;
                        m.Description = Convert.ToString(gridView_CreateRecurringInvoice_InvoiceItem[0, i].Value);
                        m.Quanitity = Convert.ToDecimal(gridView_CreateRecurringInvoice_InvoiceItem[1, i].Value);
                        m.UnitPrice = Convert.ToDecimal(gridView_CreateRecurringInvoice_InvoiceItem[2, i].Value);
                        if (m.Quanitity == 0) continue;
                        InvoiceService.InsertItem(m);
                        countItem++;
                    }
                    if (countItem == 0)
                    {
                        MessageBox.Show("No invoice item to save.\r\nPlease input invoice items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    {
                        Invoice m = new Invoice();
                        m.InvoiceID = invoiceID;
                        m.ClientObject = client;
                        m.InvoiceDate = dateTimePicker_CreateRecurringInvoice_InvoiceDate.Value;
                        m.DueDate = dateTimePicker_CreateRecurringInvoice_DueDate.Value;
                        m.Status = comboBox_CreateRecurringInvoice_Status.Text;
                        if (radioButton_CreateRecurringInvoice_Send2Client_Yes.Checked)
                            m.Send2Client = Invoice.SEND2CLIENT_YES;
                        else if (radioButton_CreateRecurringInvoice_Send2Client_No.Checked)
                            m.Send2Client = Invoice.SEND2CLIENT_NO;
                        m.VATPercent = numericUpDown_CreateRecurringInvoice_VAT_Percent.Value;
                        m.Comments = textBox_CreateRecurringInvoice_Comments.Text;
                        m.NextDays = (int)numericUpDown_CreateRecurringInvoice_NextDays.Value;
                        m.DueDays = (int)numericUpDown_CreateRecurringInvoice_DueDays.Value;
                        InvoiceService.Insert(m);
                    }
                    MessageBox.Show("Recurring Invoice saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetInvoiceList();
                    reset_CreateRecurringInvoice(false, true);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    ExceptionLogService.Log(ex);
                    MessageBox.Show("There was an error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        #endregion CreateRecurringInvoice



        #region PendingInvoices
        private void button_PendingInvoices_Search_Click(object sender, EventArgs e)
        {
            String invoiceID = textBox_PendingInvoices_InvoiceID.Text;
            String clientName = comboBox_PendingInvoices_Client.Text;
            String status = "Pending";
            DateTime dateFrom = dateTimePicker_PendingInvoices_DateFrom.Value;
            DateTime dateTo = dateTimePicker_PendingInvoices_DateTo.Value;
            var rows = dataGridView_PendingInvoices.Rows;
            rows.Clear();
            List<Invoice> list = InvoiceService.Select(invoiceID, clientName, status, dateFrom, dateTo, null, false, true);
            foreach (Invoice m in list)
            {
                rows.Add(new String[] { m.InvoiceID, m.ClientObject.Company, m.Comments, m.Total.ToString("N") + " " + m.ClientObject.CurrencySymbol, ToDateString(m.InvoiceDate), ToDateString(m.DueDate), m.Status, "View", "Print", "Delete" });
            }
            int count = list.Count;
            if (count == 0)
                label_PendingInvoices_Result.Text = "[0] Invoice.";
            else if (count == 1)
                label_PendingInvoices_Result.Text = "[1] Invoice.";
            else
                label_PendingInvoices_Result.Text = String.Format("[{0}] Invoices.", count);
            dataGridView_PendingInvoices.ClearSelection();
        }

        #endregion PendingInvoices



        #region RecurringInvoices
        private void button_RecurringInvoices_Search_Click(object sender, EventArgs e)
        {
            String clientName = comboBox_RecurringInvoices_Client.Text;
            var rows = dataGridView_RecurringInvoices.Rows;
            rows.Clear();
            List<Invoice> list = InvoiceService.Select(null, clientName, null, null, null, null, true, true);
            foreach (Invoice m in list)
            {
                rows.Add(new String[] { m.InvoiceID, m.ClientObject.Company, m.Comments, m.Total.ToString("N") + " " + m.ClientObject.CurrencySymbol, ToDateString(m.InvoiceDate), m.NextDays.ToString(), m.DueDays.ToString(), "View", "Print", "Delete" });
            }
            int count = list.Count;
            if (count == 0)
                label_RecurringInvoices_Result.Text = "[0] Recurring Invoice.";
            else if (count == 1)
                label_RecurringInvoices_Result.Text = "[1] Recurring Invoice.";
            else
                label_RecurringInvoices_Result.Text = String.Format("[{0}] Recurring Invoices.", count);
            dataGridView_RecurringInvoices.ClearSelection();
        }
        #endregion RecurringInvoices


        #region EditRecurringInvoice
        private void dataGridView_RecurringInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = (DataGridViewCell)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (!(cell.OwningColumn is DataGridViewLinkColumn)) return;
            if (cell.Value == "View" || e.ColumnIndex == 0)
            {
                String invoiceID = (String)dataGridView_RecurringInvoices[0, cell.RowIndex].Value;
                openEditInvoice(invoiceID);
            }
            else if (cell.Value == "Delete")
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to permanently delete this recurring invoice?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    String invoiceID = (String)dataGridView_RecurringInvoices[0, cell.RowIndex].Value;
                    InvoiceService.Delete(invoiceID);
                    button_RecurringInvoices_Search_Click(null, null);
                }
            }
        }

        private void button_EditRecurringInvoice_SelectClient_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox_EditRecurringInvoice_SelectClient.SelectedIndex;
            if (selectedIndex < 0)
            {
                MessageBox.Show("Please select a client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Client c = clientList[selectedIndex];
            panel_EditRecurringInvoice_SelectClient.Visible = false;
            String text = c.FullName;
            if (!String.IsNullOrWhiteSpace(c.TIN)) text += "\r\nTIN #: " + c.TIN;
            if (!String.IsNullOrWhiteSpace(c.VAT)) text += "\r\nVAT #: " + c.VAT;
            if (!String.IsNullOrWhiteSpace(c.Address1)) text += "\r\n: " + c.Address1;
            if (!String.IsNullOrWhiteSpace(c.Address2)) text += "\r\n: " + c.Address2;
            if (!String.IsNullOrWhiteSpace(c.City) && !String.IsNullOrWhiteSpace(c.State)) text += "\r\n" + c.City + ", " + c.State;
            else if (!String.IsNullOrWhiteSpace(c.City)) text += "\r\n" + c.City;
            else if (!String.IsNullOrWhiteSpace(c.State)) text += "\r\n" + c.State;
            if (!String.IsNullOrWhiteSpace(c.Country)) text += "\r\n" + c.Country;
            textBox_EditRecurringInvoice_ClientDetail.Text = text;
            textBox_EditRecurringInvoice_ClientDetail.Visible = true;
            button_EditRecurringInvoice_ChangeClient.Visible = true;
            splitContainer_EditRecurringInvoice_Root.Panel2.Enabled = true;
            splitContainer_EditRecurringInvoice_Client.Panel2.Enabled = true;
            textBox_EditRecurringInvoice_InvoiceID.Text = InvoiceService.GetNextInvoiceID(c.InvoiceIDAssign);
            if (c.VATApplicable == Client.VAT_APPLICABLE_YES) numericUpDown_EditRecurringInvoice_VAT_Percent.Value = c.VATPercent;
            //label_EditRecurringInvoice_Total.Text = "Total " + c.CurrencyWithSymbol;
        }

        private void button_EditRecurringInvoice_ChangeClient_Click(object sender, EventArgs e)
        {
            reset_EditRecurringInvoice();
        }

        private void gridView_EditRecurringInvoice_InvoiceItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 1 || e.ColumnIndex == 2))
            {
                var obj = ((GridViewCustom)sender);
                try
                {
                    Decimal quantity = Convert.ToDecimal(obj[1, e.RowIndex].Value);
                    Decimal unitPrice = Convert.ToDecimal(obj[2, e.RowIndex].Value);
                    ((GridViewCustom)sender)[3, e.RowIndex].Value = (quantity * unitPrice).ToString();
                }
                catch
                {
                    ((GridViewCustom)sender)[3, e.RowIndex].Value = "";
                }
                try
                {
                    Decimal subTotal = 0;
                    for (int i = 0; i < obj.RowCount; i++)
                    {
                        Decimal quantity = Convert.ToInt32(obj[1, i].Value);
                        Decimal unitPrice = Convert.ToDecimal(obj[2, i].Value);
                        subTotal += quantity * unitPrice;
                    }
                    textBox_EditRecurringInvoice_SubTotal.Text = subTotal.ToString();
                }
                catch
                {
                    textBox_EditRecurringInvoice_SubTotal.Text = "0";
                }
            }
        }

        private void textBox_EditRecurringInvoice_SubTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Decimal subTotal = Convert.ToDecimal(textBox_EditRecurringInvoice_SubTotal.Text);
                Decimal vatPercent = numericUpDown_EditRecurringInvoice_VAT_Percent.Value;
                Decimal vatValue = subTotal * vatPercent / 100;
                textBox_EditRecurringInvoice_VAT_Value.Text = vatValue.ToString();
                textBox_EditRecurringInvoice_GrandTotal.Text = (subTotal + vatValue).ToString();
                //Decimal payment = Decimal.Parse(textBox_EditRecurringInvoice_Payments.Text.Substring(1));
                //String currency = clientList[comboBox_EditRecurringInvoice_SelectClient.SelectedIndex].CurrencySymbol;
                //textBox_EditRecurringInvoice_AmountDue.Text = currency + (subTotal + vatValue - payment).ToString("N2");
            }
            catch
            {
                textBox_EditRecurringInvoice_VAT_Value.Text = "0";
                textBox_EditRecurringInvoice_GrandTotal.Text = "$0.00";
                //textBox_EditRecurringInvoice_AmountDue.Text = "$0.00";
            }
        }

        private void numericUpDown_EditRecurringInvoice_VAT_Percent_ValueChanged(object sender, EventArgs e)
        {
            textBox_EditRecurringInvoice_SubTotal_TextChanged(sender, e);
        }

        private void button_EditRecurringInvoice_SaveInvoice_Click(object sender, EventArgs e)
        {
            int count = gridView_EditRecurringInvoice_InvoiceItem.RowCount;
            if (count < 2)
            {
                MessageBox.Show("No invoice item to save.\r\nPlease input invoice items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i < count; i++)
            {
                if (gridView_EditRecurringInvoice_InvoiceItem[1, i].Value == null && gridView_EditRecurringInvoice_InvoiceItem[2, i].Value == null) continue;
                if (!Decimal.TryParse(gridView_EditRecurringInvoice_InvoiceItem[1, i].Value.ToString(), out _) || !Decimal.TryParse(gridView_EditRecurringInvoice_InvoiceItem[2, i].Value.ToString(), out _))
                {
                    MessageBox.Show("Some Qty or Unit Price values are invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            Client client = clientList[comboBox_EditRecurringInvoice_SelectClient.SelectedIndex];
            String invoiceID = textBox_EditRecurringInvoice_InvoiceID.Text;
            using (var transaction = dao.BaseDao.connection.BeginTransaction())
                try
                {
                    if (OldInvoiceID != null)
                    {
                        InvoiceService.Delete(OldInvoiceID);
                        OldInvoiceID = null;
                    }
                    else
                    {
                        Console.WriteLine("OldInvoiceID is null");
                    }
                    invoiceID = InvoiceService.GetNextInvoiceID(client.InvoiceIDAssign);
                    int countItem = 0;
                    for (int i = 0; i < count; i++)
                    {
                        if (gridView_EditRecurringInvoice_InvoiceItem[1, i].Value == null && gridView_EditRecurringInvoice_InvoiceItem[2, i].Value == null) continue;
                        InvoiceItem m = new InvoiceItem();
                        m.InvoiceID = invoiceID;
                        m.Description = Convert.ToString(gridView_EditRecurringInvoice_InvoiceItem[0, i].Value);
                        m.Quanitity = Convert.ToDecimal(gridView_EditRecurringInvoice_InvoiceItem[1, i].Value);
                        m.UnitPrice = Convert.ToDecimal(gridView_EditRecurringInvoice_InvoiceItem[2, i].Value);
                        if (m.Quanitity == 0) continue;
                        InvoiceService.InsertItem(m);
                        countItem++;
                    }
                    if (countItem == 0)
                    {
                        transaction.Rollback();
                        MessageBox.Show("No invoice item to save.\r\nPlease input invoice items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    {
                        Invoice m = new Invoice();
                        m.InvoiceID = invoiceID;
                        m.ClientObject = client;
                        m.InvoiceDate = dateTimePicker_EditRecurringInvoice_InvoiceDate.Value;
                        m.DueDate = dateTimePicker_EditRecurringInvoice_DueDate.Value;
                        m.Status = comboBox_EditRecurringInvoice_Status.Text;
                        if (radioButton_EditRecurringInvoice_Send2Client_Yes.Checked)
                            m.Send2Client = Invoice.SEND2CLIENT_YES;
                        else if (radioButton_EditRecurringInvoice_Send2Client_No.Checked)
                            m.Send2Client = Invoice.SEND2CLIENT_NO;
                        m.VATPercent = numericUpDown_EditRecurringInvoice_VAT_Percent.Value;
                        m.Comments = textBox_EditRecurringInvoice_Comments.Text;
                        m.NextDays = (int)numericUpDown_EditRecurringInvoice_NextDays.Value;
                        m.DueDays = (int)numericUpDown_EditRecurringInvoice_DueDays.Value;
                        InvoiceService.Insert(m);
                    }
                    MessageBox.Show("Invoice saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetInvoiceList();
                    tabControl_Invoices.TabPages.Remove(tabPage_Invoices_EditRecurringInvoice);
                    //reset_EditRecurringInvoice(false, true);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    ExceptionLogService.Log(ex);
                    MessageBox.Show("There was an error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        #endregion EditRecurringInvoice

    }
}
