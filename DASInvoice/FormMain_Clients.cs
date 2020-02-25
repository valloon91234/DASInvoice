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
        private void Initialize_Client()
        {
            // 
            // Clients / Search Clients
            //
            comboBox_Clients_SearchClients_Country.Items.AddRange(CONST.COUNTRY_NAME_ARRAY);
            //comboBox_Clients_SearchClients_Country.Text = CONST.COUNTRY_NAME_PLACEHOLDER;
            comboBox_Clients_SearchClients_ClientStatus.Items.Add("");
            comboBox_Clients_SearchClients_ClientStatus.Items.AddRange(Client.STATUS_ARRAY);
            // 
            // Clients / Create Client
            //
            comboBox_CreateClient_Country.Items.AddRange(CONST.COUNTRY_NAME_ARRAY);
            //comboBox_CreateClient_Country.Text = CONST.COUNTRY_NAME_PLACEHOLDER;
            comboBox_CreateClient_ClientStatus.Items.AddRange(Client.STATUS_ARRAY);
            comboBox_CreateClient_InvoiceTemplate.SelectedIndex = 0;
            comboBox_CreateClient_Currency.Items.AddRange(CONST.CURRENCY_NAME_ARRAY);
            //label_CreateClient_Message.Visible = false;
            reset_CreateClient();
            // 
            // Clients / Edit Client
            //
            comboBox_EditClient_Country.Items.AddRange(CONST.COUNTRY_NAME_ARRAY);
            //comboBox_EditClient_Country.Text = CONST.COUNTRY_NAME_PLACEHOLDER;
            comboBox_EditClient_ClientStatus.Items.AddRange(Client.STATUS_ARRAY);
            comboBox_EditClient_InvoiceTemplate.SelectedIndex = 0;
            comboBox_EditClient_Currency.Items.AddRange(CONST.CURRENCY_NAME_ARRAY);
            //label_CreateClient_Message.Visible = false;
            reset_EditClient();
        }

        private void reset_CreateClient()
        {
            textBox_CreateClient_FirstName.Text = "";
            textBox_CreateClient_LastName.Text = "";
            textBox_CreateClient_Company.Text = "";
            textBox_CreateClient_TIN.Text = "";
            textBox_CreateClient_VAT.Text = "";
            textBox_CreateClient_Phone.Text = "";
            textBox_CreateClient_Email.Text = "";
            textBox_CreateClient_Address1.Text = "";
            textBox_CreateClient_Address2.Text = "";
            textBox_CreateClient_City.Text = "";
            textBox_CreateClient_State.Text = "";
            textBox_CreateClient_PostalCode.Text = "";
            comboBox_CreateClient_Country.SelectedIndex = -1;
            comboBox_CreateClient_ClientStatus.SelectedIndex = -1;
            comboBox_CreateClient_ClientIDAssign.Items.Clear();
            foreach (String id in Client.ID_ASSIGN_ARRAY)
                comboBox_CreateClient_ClientIDAssign.Items.Add("Assign ID Serial # " + id);
            comboBox_CreateClient_InvoiceIDAssign.Items.Clear();
            foreach (String id in Invoice.ID_ASSIGN_ARRAY)
                comboBox_CreateClient_InvoiceIDAssign.Items.Add("Invoice ID Serial # " + id);
            comboBox_CreateClient_InvoiceTemplate.SelectedIndex = 0;
            radioButton_CreateClient_VATApplicable_Yes.Checked = false;
            radioButton_CreateClient_VATApplicable_No.Checked = true;
            numericUpDown_CreateClient_VATPercent.Value = 0;
            comboBox_CreateClient_Currency.SelectedIndex = -1;
            textBox_CreateClient_Notes.Text = "";
        }

        private void reset_EditClient()
        {
            textBox_EditClient_FirstName.Text = "";
            textBox_EditClient_LastName.Text = "";
            textBox_EditClient_Company.Text = "";
            textBox_EditClient_TIN.Text = "";
            textBox_EditClient_VAT.Text = "";
            textBox_EditClient_Phone.Text = "";
            textBox_EditClient_Email.Text = "";
            textBox_EditClient_Address1.Text = "";
            textBox_EditClient_Address2.Text = "";
            textBox_EditClient_City.Text = "";
            textBox_EditClient_State.Text = "";
            textBox_EditClient_PostalCode.Text = "";
            comboBox_EditClient_Country.SelectedIndex = -1;
            comboBox_EditClient_ClientStatus.SelectedIndex = -1;
            comboBox_EditClient_InvoiceTemplate.SelectedIndex = 0;
            radioButton_EditClient_VATApplicable_Yes.Checked = false;
            radioButton_EditClient_VATApplicable_No.Checked = true;
            numericUpDown_EditClient_VATPercent.Value = 0;
            comboBox_EditClient_Currency.SelectedIndex = -1;
            textBox_EditClient_Notes.Text = "";
        }

        #region CreateClient
        private void radioButton_CreateClient_VATApplicable_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                numericUpDown_CreateClient_VATPercent.Enabled = true;
            }
            else
            {
                numericUpDown_CreateClient_VATPercent.Value = 0;
                numericUpDown_CreateClient_VATPercent.Enabled = false;
            }

        }
        private void button_CreateClient_Save_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.FirstName = textBox_CreateClient_FirstName.Text.Trim();
            client.LastName = textBox_CreateClient_LastName.Text.Trim();
            client.Company = textBox_CreateClient_Company.Text.Trim();
            client.TIN = textBox_CreateClient_TIN.Text.Trim();
            client.VAT = textBox_CreateClient_VAT.Text.Trim();
            client.Phone = textBox_CreateClient_Phone.Text.Trim();
            client.Email = textBox_CreateClient_Email.Text.Trim();
            client.Address1 = textBox_CreateClient_Address1.Text.Trim();
            client.Address2 = textBox_CreateClient_Address2.Text.Trim();
            client.City = textBox_CreateClient_City.Text.Trim();
            client.State = textBox_CreateClient_State.Text.Trim();
            client.PostalCode = textBox_CreateClient_PostalCode.Text.Trim();
            client.Country = comboBox_CreateClient_Country.Text;
            client.ClientStatus = comboBox_CreateClient_ClientStatus.Text;
            client.ClientIDAssign = Util.RemoveNonNumeric(comboBox_CreateClient_ClientIDAssign.Text);
            client.InvoiceIDAssign = Util.RemoveNonNumeric(comboBox_CreateClient_InvoiceIDAssign.Text);
            client.InvoiceTemplate = comboBox_CreateClient_InvoiceTemplate.Text;
            if (radioButton_CreateClient_VATApplicable_Yes.Checked)
                client.VATApplicable = Client.VAT_APPLICABLE_YES;
            else if (radioButton_CreateClient_VATApplicable_No.Checked)
                client.VATApplicable = Client.VAT_APPLICABLE_NO;
            client.VATPercent = (int)numericUpDown_CreateClient_VATPercent.Value;
            client.Currency = comboBox_CreateClient_Currency.Text;
            client.Notes = textBox_CreateClient_Notes.Text;
            Boolean validated = true;
            if (String.IsNullOrWhiteSpace(client.FirstName))
            {
                toolTipValidation1.Show("Please input First Name.", textBox_CreateClient_FirstName, VALIDATION_X, VALIDATION_Y, VALIDATION_DURATION);
                //MessageBox.Show("Please input client's First Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_CreateClient_FirstName.Focus();
                validated = false;
            }
            if (String.IsNullOrWhiteSpace(client.LastName))
            {
                toolTipValidation2.Show("Please input Last Name.", textBox_CreateClient_LastName, VALIDATION_X, VALIDATION_Y, VALIDATION_DURATION);
                //MessageBox.Show("Please input client's Last Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_CreateClient_LastName.Focus();
                validated = false;
            }
            if (String.IsNullOrWhiteSpace(client.Company))
            {
                toolTipValidation3.Show("Please input Company Name.", textBox_CreateClient_Company, VALIDATION_X, VALIDATION_Y, VALIDATION_DURATION);
                //MessageBox.Show("Please input client's Company Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_CreateClient_Company.Focus();
                validated = false;
            }
            if (String.IsNullOrWhiteSpace(client.Country))
            {
                toolTipValidation4.Show("Please select Country.", comboBox_CreateClient_Country, VALIDATION_X, VALIDATION_Y, VALIDATION_DURATION);
                //MessageBox.Show("Please select Country.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_CreateClient_Country.Focus();
                validated = false;
            }
            if (String.IsNullOrWhiteSpace(client.ClientStatus))
            {
                toolTipValidation5.Show("Please select Client Status.", comboBox_CreateClient_ClientStatus, VALIDATION_X, VALIDATION_Y, VALIDATION_DURATION);
                //MessageBox.Show("Please select Client Status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_CreateClient_ClientStatus.Focus();
                validated = false;
            }
            if (String.IsNullOrWhiteSpace(client.ClientIDAssign))
            {
                toolTipValidation6.Show("Please select Client ID.", comboBox_CreateClient_ClientIDAssign, VALIDATION_X, VALIDATION_Y, VALIDATION_DURATION);
                //MessageBox.Show("Please select Client ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_CreateClient_ClientIDAssign.Focus();
                validated = false;
            }
            if (String.IsNullOrWhiteSpace(client.InvoiceIDAssign))
            {
                toolTipValidation7.Show("Please select Invoice ID.", comboBox_CreateClient_InvoiceIDAssign, VALIDATION_X, VALIDATION_Y, VALIDATION_DURATION);
                //MessageBox.Show("Please select Invoice ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_CreateClient_InvoiceIDAssign.Focus();
                validated = false;
            }
            if (String.IsNullOrWhiteSpace(client.VATApplicable))
            {
                toolTipValidation8.Show("Please select VAT Applicable.", radioButton_CreateClient_VATApplicable_Yes, VALIDATION_X, VALIDATION_Y, VALIDATION_DURATION);
                //MessageBox.Show("Please select VAT Applicable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                radioButton_CreateClient_VATApplicable_Yes.Focus();
                radioButton_CreateClient_VATApplicable_Yes.Checked = false;
                validated = false;
            }
            if (String.IsNullOrWhiteSpace(client.Currency))
            {
                toolTipValidation9.Show("Please select Currency.", comboBox_CreateClient_Currency, VALIDATION_X, VALIDATION_Y, VALIDATION_DURATION);
                //MessageBox.Show("Please select Currency.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_CreateClient_Currency.Focus();
                validated = false;
            }
            if (ClientService.IsExist(client.FirstName, client.LastName))
            {
                MessageBox.Show("This client already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_CreateClient_FirstName.Focus();
                validated = false;
            }
            if (!validated) return;
            try
            {
                ClientService.Insert(client);
                //label_CreateClient_Message.Visible = true;
                //label_CreateClient_Message.ForeColor = System.Drawing.Color.Green;
                //label_CreateClient_Message.Text = "Client saved successfully!";
                MessageBox.Show("Client saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetCilentList();
                reset_CreateClient();
            }
            catch (Exception ex)
            {
                ExceptionLogService.Log(ex);
                //label_CreateClient_Message.Visible = true;
                //label_CreateClient_Message.ForeColor = System.Drawing.Color.Red;
                //label_CreateClient_Message.Text = "There was an error!";
                MessageBox.Show("There was an error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion



        #region SearchClients
        private void button_SearchClients_Search_Click(object sender, EventArgs e)
        {
            String clientName = textBox_Clients_SearchClients_ClientName.Text;
            String company = textBox_Clients_SearchClients_Company.Text;
            String email = textBox_Clients_SearchClients_Email.Text;
            String clientID = textBox_Clients_SearchClients_ClientID.Text;
            String country = comboBox_Clients_SearchClients_Country.Text;
            //if (country == CONST.COUNTRY_NAME_PLACEHOLDER) country = null;
            String clientStatus = comboBox_Clients_SearchClients_ClientStatus.Text;
            var rows = dataGridView_SearchClient.Rows;
            rows.Clear();
            List<Client> list = ClientService.Select(clientName, company, email, clientID, country, clientStatus);
            foreach (Client m in list)
            {
                rows.Add(new String[] { m.ClientID, m.FullName, m.Company, ToDateString(m.TimeRegistered), m.ClientStatus, "View", "Edit", "Delete" });
            }
            int count = list.Count;
            if (count == 0)
                label_Clients_SearchClients_Result.Text = "[0] Client.";
            else if (count == 1)
                label_Clients_SearchClients_Result.Text = "[1] Client.";
            else
                label_Clients_SearchClients_Result.Text = String.Format("[{0}] Clients.", count);
            dataGridView_SearchClient.ClearSelection();
        }

        #endregion SearchClients



        #region EditClients
        private void dataGridView_SearchClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = (DataGridViewCell)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (!(cell.OwningColumn is DataGridViewLinkColumn)) return;
            if (cell.Value == "View" || cell.Value == "Edit" || e.ColumnIndex == 0)
            {
                reset_EditClient();
                if (!tabControl_Clients.TabPages.Contains(tabPage_EditClient))
                    tabControl_Clients.TabPages.Insert(1, tabPage_EditClient);
                tabControl_Clients.SelectTab(tabPage_EditClient);
                String clientID = (String)dataGridView_SearchClient[0, cell.RowIndex].Value;
                Client c = ClientService.Get(clientID);

                textBox_EditClient_FirstName.Text = c.FirstName;
                textBox_EditClient_LastName.Text = c.LastName;
                textBox_EditClient_Company.Text = c.Company;
                textBox_EditClient_TIN.Text = c.TIN;
                textBox_EditClient_VAT.Text = c.VAT;
                textBox_EditClient_Phone.Text = c.Phone;
                textBox_EditClient_Email.Text = c.Email;
                textBox_EditClient_Address1.Text = c.Address1;
                textBox_EditClient_Address2.Text = c.Address2;
                textBox_EditClient_City.Text = c.City;
                textBox_EditClient_State.Text = c.State;
                textBox_EditClient_PostalCode.Text = c.PostalCode;
                comboBox_EditClient_Country.Text = c.Country;
                comboBox_EditClient_ClientStatus.Text = c.ClientStatus;
                textBox_EditClient_ClientID.Text = c.ClientID;
                textBox_EditClient_InvoiceIDAssign.Text = c.InvoiceIDAssign;
                comboBox_EditClient_InvoiceTemplate.Text = c.InvoiceTemplate;
                if (c.VATApplicable == Client.VAT_APPLICABLE_YES)
                    radioButton_EditClient_VATApplicable_Yes.Checked = true;
                else
                    radioButton_EditClient_VATApplicable_No.Checked = true;

                numericUpDown_EditClient_VATPercent.Value = c.VATPercent;
                comboBox_EditClient_Currency.Text = c.Currency;
                textBox_EditClient_Notes.Text = c.Notes;

            }
            else if (cell.Value == "Delete")
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to permanently delete this client?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    String clientID = (String)dataGridView_SearchClient[0, cell.RowIndex].Value;
                    InvoiceService.DeleteByClient(clientID);
                    ClientService.Delete(clientID);
                    button_SearchClients_Search_Click(null, null);
                }
            }
        }

        private void button_EditClient_Save_Click(object sender, EventArgs e)
        {
            String clientID = textBox_EditClient_ClientID.Text;
            Client client = ClientService.Get(clientID);
            if (client == null)
            {
                MessageBox.Show("This original client does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reset_EditClient();
                tabControl_Clients.TabPages.Remove(tabPage_EditClient);
                return;
            }
            client.FirstName = textBox_EditClient_FirstName.Text.Trim();
            client.LastName = textBox_EditClient_LastName.Text.Trim();
            client.Company = textBox_EditClient_Company.Text.Trim();
            client.TIN = textBox_EditClient_TIN.Text.Trim();
            client.VAT = textBox_EditClient_VAT.Text.Trim();
            client.Phone = textBox_EditClient_Phone.Text.Trim();
            client.Email = textBox_EditClient_Email.Text.Trim();
            client.Address1 = textBox_EditClient_Address1.Text.Trim();
            client.Address2 = textBox_EditClient_Address2.Text.Trim();
            client.City = textBox_EditClient_City.Text.Trim();
            client.State = textBox_EditClient_State.Text.Trim();
            client.PostalCode = textBox_EditClient_PostalCode.Text.Trim();
            client.Country = comboBox_EditClient_Country.Text;
            client.ClientStatus = comboBox_EditClient_ClientStatus.Text;
            client.InvoiceTemplate = comboBox_EditClient_InvoiceTemplate.Text;
            if (radioButton_EditClient_VATApplicable_Yes.Checked)
                client.VATApplicable = Client.VAT_APPLICABLE_YES;
            else if (radioButton_EditClient_VATApplicable_No.Checked)
                client.VATApplicable = Client.VAT_APPLICABLE_NO;
            client.VATPercent = (int)numericUpDown_EditClient_VATPercent.Value;
            client.Currency = comboBox_EditClient_Currency.Text;
            client.Notes = textBox_EditClient_Notes.Text;
            Boolean validated = true;
            if (String.IsNullOrWhiteSpace(client.FirstName))
            {
                toolTipValidation1.Show("Please input First Name.", textBox_EditClient_FirstName, VALIDATION_X, VALIDATION_Y, VALIDATION_DURATION);
                //MessageBox.Show("Please input client's First Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_EditClient_FirstName.Focus();
                validated = false;
            }
            if (String.IsNullOrWhiteSpace(client.LastName))
            {
                toolTipValidation2.Show("Please input Last Name.", textBox_EditClient_LastName, VALIDATION_X, VALIDATION_Y, VALIDATION_DURATION);
                //MessageBox.Show("Please input client's Last Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_EditClient_LastName.Focus();
                validated = false;
            }
            if (String.IsNullOrWhiteSpace(client.Company))
            {
                toolTipValidation3.Show("Please input Company Name.", textBox_EditClient_Company, VALIDATION_X, VALIDATION_Y, VALIDATION_DURATION);
                //MessageBox.Show("Please input client's Company Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_EditClient_Company.Focus();
                validated = false;
            }
            if (String.IsNullOrWhiteSpace(client.Country))
            {
                toolTipValidation4.Show("Please select Country.", comboBox_EditClient_Country, VALIDATION_X, VALIDATION_Y, VALIDATION_DURATION);
                //MessageBox.Show("Please select Country.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_EditClient_Country.Focus();
                validated = false;
            }
            if (String.IsNullOrWhiteSpace(client.ClientStatus))
            {
                toolTipValidation5.Show("Please select Client Status.", comboBox_EditClient_ClientStatus, VALIDATION_X, VALIDATION_Y, VALIDATION_DURATION);
                //MessageBox.Show("Please select Client Status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_EditClient_ClientStatus.Focus();
                validated = false;
            }
            if (String.IsNullOrWhiteSpace(client.VATApplicable))
            {
                toolTipValidation8.Show("Please select VAT Applicable.", radioButton_EditClient_VATApplicable_Yes, VALIDATION_X, VALIDATION_Y, VALIDATION_DURATION);
                //MessageBox.Show("Please select VAT Applicable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                radioButton_EditClient_VATApplicable_Yes.Focus();
                radioButton_EditClient_VATApplicable_Yes.Checked = false;
                validated = false;
            }
            if (String.IsNullOrWhiteSpace(client.Currency))
            {
                toolTipValidation9.Show("Please select Currency.", comboBox_EditClient_Currency, VALIDATION_X, VALIDATION_Y, VALIDATION_DURATION);
                //MessageBox.Show("Please select Currency.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_EditClient_Currency.Focus();
                validated = false;
            }
            if (!validated) return;
            using (var transaction = dao.BaseDao.connection.BeginTransaction())
                try
                {
                    ClientService.Update(client);
                    MessageBox.Show("Client saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetCilentList();
                    reset_EditClient();
                    transaction.Commit();
                    tabControl_Clients.TabPages.Remove(tabPage_EditClient);
                    button_SearchClients_Search_Click(null, null);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    ExceptionLogService.Log(ex);
                    MessageBox.Show("There was an error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        #endregion EditClient
    }
}
