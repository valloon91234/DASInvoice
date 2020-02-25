namespace DASInvoice
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl_Root = new TradeWright.UI.Forms.TabControlExtra();
            this.tabPage_Dashboard = new System.Windows.Forms.TabPage();
            this.tabControl_Dashboard = new TradeWright.UI.Forms.TabControlExtra();
            this.tabPage_Dashboard_Summary = new System.Windows.Forms.TabPage();
            this.splitContainer_Dashboard_Summary_2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer_Dashboard_Summary_1 = new System.Windows.Forms.SplitContainer();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Summary_RecentInvoices = new System.Windows.Forms.DataGridView();
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Summary_PastDueInvoices = new System.Windows.Forms.DataGridView();
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_AmountDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DaysDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer_Dashboard_Summary_3 = new System.Windows.Forms.SplitContainer();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox_Summary_SystemStatus = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBox_Summary_UserStatus = new System.Windows.Forms.TextBox();
            this.tabPage_Dashboard_CreateInvoice = new System.Windows.Forms.TabPage();
            this.tabPage_Dashboard_SearchInvoice = new System.Windows.Forms.TabPage();
            this.tabPage_Dashboard_PostPayment = new System.Windows.Forms.TabPage();
            this.tabPage_Dashboard_InvoiceReport = new System.Windows.Forms.TabPage();
            this.tabPage_Dashboard_PaymentReport = new System.Windows.Forms.TabPage();
            this.tabPage_Clients = new System.Windows.Forms.TabPage();
            this.tabControl_Clients = new TradeWright.UI.Forms.TabControlExtra();
            this.tabPage_SearchClients = new System.Windows.Forms.TabPage();
            this.splitContainer_Clients_SearchClients = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox_Clients_SearchClients_ClientName = new System.Windows.Forms.TextBox();
            this.textBox_Clients_SearchClients_ClientID = new System.Windows.Forms.TextBox();
            this.textBox_Clients_SearchClients_Company = new System.Windows.Forms.TextBox();
            this.textBox_Clients_SearchClients_Email = new System.Windows.Forms.TextBox();
            this.comboBox_Clients_SearchClients_Country = new System.Windows.Forms.ComboBox();
            this.comboBox_Clients_SearchClients_ClientStatus = new System.Windows.Forms.ComboBox();
            this.button_Clients_SearchClients_Search = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer_Clients_SearchClients_Clients = new System.Windows.Forms.SplitContainer();
            this.label_Clients_SearchClients_Result = new System.Windows.Forms.Label();
            this.dataGridView_SearchClient = new System.Windows.Forms.DataGridView();
            this.column_Clients_ClientID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.column_Clients_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Clients_Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Clients_Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Clients_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Clients_View = new System.Windows.Forms.DataGridViewLinkColumn();
            this.column_Clients_Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.column_Clients_Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabPage_EditClient = new System.Windows.Forms.TabPage();
            this.groupBox_EditClient = new System.Windows.Forms.GroupBox();
            this.groupBox36 = new System.Windows.Forms.GroupBox();
            this.label66 = new System.Windows.Forms.Label();
            this.button_EditClient_Save = new System.Windows.Forms.Button();
            this.textBox_EditClient_Notes = new System.Windows.Forms.TextBox();
            this.label94 = new System.Windows.Forms.Label();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.comboBox_EditClient_ClientStatus = new System.Windows.Forms.ComboBox();
            this.comboBox_EditClient_InvoiceTemplate = new System.Windows.Forms.ComboBox();
            this.comboBox_EditClient_Currency = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_EditClient_VATApplicable_Yes = new System.Windows.Forms.RadioButton();
            this.radioButton_EditClient_VATApplicable_No = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
            this.numericUpDown_EditClient_VATPercent = new System.Windows.Forms.NumericUpDown();
            this.label103 = new System.Windows.Forms.Label();
            this.textBox_EditClient_ClientID = new System.Windows.Forms.TextBox();
            this.textBox_EditClient_InvoiceIDAssign = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_EditClient_LastName = new System.Windows.Forms.TextBox();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.textBox_EditClient_FirstName = new System.Windows.Forms.TextBox();
            this.label106 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.textBox_EditClient_Company = new System.Windows.Forms.TextBox();
            this.textBox_EditClient_TIN = new System.Windows.Forms.TextBox();
            this.textBox_EditClient_VAT = new System.Windows.Forms.TextBox();
            this.textBox_EditClient_Phone = new System.Windows.Forms.TextBox();
            this.textBox_EditClient_Email = new System.Windows.Forms.TextBox();
            this.textBox_EditClient_Address1 = new System.Windows.Forms.TextBox();
            this.textBox_EditClient_Address2 = new System.Windows.Forms.TextBox();
            this.textBox_EditClient_City = new System.Windows.Forms.TextBox();
            this.textBox_EditClient_State = new System.Windows.Forms.TextBox();
            this.textBox_EditClient_PostalCode = new System.Windows.Forms.TextBox();
            this.comboBox_EditClient_Country = new System.Windows.Forms.ComboBox();
            this.tabPage_CreateClient = new System.Windows.Forms.TabPage();
            this.groupBox_CreateClient_createClient = new System.Windows.Forms.GroupBox();
            this.groupBox_CreateClient_ClientSettings = new System.Windows.Forms.GroupBox();
            this.label_CreateClient_Message = new System.Windows.Forms.Label();
            this.button_CreateClient_Save = new System.Windows.Forms.Button();
            this.textBox_CreateClient_Notes = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_CreateClient_ClientSettings = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox_CreateClient_ClientStatus = new System.Windows.Forms.ComboBox();
            this.comboBox_CreateClient_ClientIDAssign = new System.Windows.Forms.ComboBox();
            this.comboBox_CreateClient_InvoiceIDAssign = new System.Windows.Forms.ComboBox();
            this.comboBox_CreateClient_InvoiceTemplate = new System.Windows.Forms.ComboBox();
            this.comboBox_CreateClient_Currency = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_CreateClient_VATApplicable_Yes = new System.Windows.Forms.RadioButton();
            this.radioButton_CreateClient_VATApplicable_No = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.numericUpDown_CreateClient_VATPercent = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Clients_CreateClient = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_CreateClient_LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_CreateClient_FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_CreateClient_Company = new System.Windows.Forms.TextBox();
            this.textBox_CreateClient_TIN = new System.Windows.Forms.TextBox();
            this.textBox_CreateClient_VAT = new System.Windows.Forms.TextBox();
            this.textBox_CreateClient_Phone = new System.Windows.Forms.TextBox();
            this.textBox_CreateClient_Email = new System.Windows.Forms.TextBox();
            this.textBox_CreateClient_Address1 = new System.Windows.Forms.TextBox();
            this.textBox_CreateClient_Address2 = new System.Windows.Forms.TextBox();
            this.textBox_CreateClient_City = new System.Windows.Forms.TextBox();
            this.textBox_CreateClient_State = new System.Windows.Forms.TextBox();
            this.textBox_CreateClient_PostalCode = new System.Windows.Forms.TextBox();
            this.comboBox_CreateClient_Country = new System.Windows.Forms.ComboBox();
            this.tabPage_Invoices = new System.Windows.Forms.TabPage();
            this.tabControl_Invoices = new TradeWright.UI.Forms.TabControlExtra();
            this.tabPage_Invoices_SearchInvoice = new System.Windows.Forms.TabPage();
            this.splitContainer_SearchInvoice_Root = new System.Windows.Forms.SplitContainer();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_SearchInvoice_InvoiceID = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.button_SearchInvoice_Search = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.comboBox_SearchInvoice_Client = new System.Windows.Forms.ComboBox();
            this.comboBox_SearchInvoice_InvoiceStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_SearchInvoice_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_SearchInvoice_DateTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label_SearchInvoice_Result = new System.Windows.Forms.Label();
            this.dataGridView_SearchInvoice = new DASInvoice.control.GridViewCustom();
            this.dataGridViewColumn_SearchInvoice_Invoice = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewColumn_SearchInvoice_Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_SearchInvoice_Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_SearchInvoice_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_SearchInvoice_Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_SearchInvoice_DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_SearchInvoice_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_SearchInvoice_View = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewColumn_SearchInvoice_Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewColumn_SearchInvoice_Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabPage_Invoices_EditInvoice = new System.Windows.Forms.TabPage();
            this.splitContainer_EditInvoice_Root = new System.Windows.Forms.SplitContainer();
            this.splitContainer_EditInvoice_Client = new System.Windows.Forms.SplitContainer();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button_EditInvoice_ChangeClient = new System.Windows.Forms.Button();
            this.panel_EditInvoice_SelectClient = new System.Windows.Forms.Panel();
            this.button_EditInvoice_SelectClient = new System.Windows.Forms.Button();
            this.comboBox_EditInvoice_SelectClient = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.textBox_EditInvoice_ClientDetail = new System.Windows.Forms.TextBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.textBox_EditInvoice_InvoiceID = new System.Windows.Forms.TextBox();
            this.dateTimePicker_EditInvoice_InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_EditInvoice_DueDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_EditInvoice_Status = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_EditInvoice_Send2Client_Yes = new System.Windows.Forms.RadioButton();
            this.radioButton_EditInvoice_Send2Client_No = new System.Windows.Forms.RadioButton();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.gridView_EditInvoice_InvoiceItem = new DASInvoice.control.GridViewCustom();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer13 = new System.Windows.Forms.SplitContainer();
            this.splitContainer14 = new System.Windows.Forms.SplitContainer();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.textBox_EditInvoice_Comments = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label60 = new System.Windows.Forms.Label();
            this.label_EditInvoice_Total = new System.Windows.Forms.Label();
            this.textBox_EditInvoice_SubTotal = new System.Windows.Forms.TextBox();
            this.textBox_EditInvoice_VAT_Value = new System.Windows.Forms.TextBox();
            this.textBox_EditInvoice_GrandTotal = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label68 = new System.Windows.Forms.Label();
            this.numericUpDown_EditInvoice_VAT_Percent = new System.Windows.Forms.NumericUpDown();
            this.label69 = new System.Windows.Forms.Label();
            this.textBox_EditInvoice_AmountDue = new System.Windows.Forms.TextBox();
            this.textBox_EditInvoice_Payments = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.button_EditInvoice_ViewPDF = new System.Windows.Forms.Button();
            this.button_EditInvoice_SendEmail = new System.Windows.Forms.Button();
            this.button_EditInvoice_SaveInvoice = new System.Windows.Forms.Button();
            this.tabPage_Invoices_CreateInvoice = new System.Windows.Forms.TabPage();
            this.splitContainer_CreateInvoice_Root = new System.Windows.Forms.SplitContainer();
            this.splitContainer_CreateInvoice_Client = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_CreateInvoice_ChangeClient = new System.Windows.Forms.Button();
            this.panel_CreateInvoice_SelectClient = new System.Windows.Forms.Panel();
            this.button_CreateInvoice_SelectClient = new System.Windows.Forms.Button();
            this.comboBox_CreateInvoice_SelectClient = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox_CreateInvoice_ClientDetail = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox_CreateInvoice_InvoiceID = new System.Windows.Forms.TextBox();
            this.dateTimePicker_CreateInvoice_InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_CreateInvoice_DueDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_CreateInvoice_Status = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_CreateInvoice_Send2Client_Yes = new System.Windows.Forms.RadioButton();
            this.radioButton_CreateInvoice_Send2Client_No = new System.Windows.Forms.RadioButton();
            this.splitContainer_Dashboard_CreateInvoice_Bottom = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gridView_CreateInvoice_InvoiceItem = new DASInvoice.control.GridViewCustom();
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer11 = new System.Windows.Forms.SplitContainer();
            this.splitContainer12 = new System.Windows.Forms.SplitContainer();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.textBox_CreateInvoice_Comments = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label71 = new System.Windows.Forms.Label();
            this.label_CreateInvoice_Total = new System.Windows.Forms.Label();
            this.textBox_CreateInvoice_SubTotal = new System.Windows.Forms.TextBox();
            this.textBox_CreateInvoice_VAT_Value = new System.Windows.Forms.TextBox();
            this.textBox_CreateInvoice_GrandTotal = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label73 = new System.Windows.Forms.Label();
            this.numericUpDown_CreateInvoice_VAT_Percent = new System.Windows.Forms.NumericUpDown();
            this.label74 = new System.Windows.Forms.Label();
            this.textBox_CreateInvoice_AmountDue = new System.Windows.Forms.TextBox();
            this.textBox_CreateInvoice_Payments = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.button_CreateInvoice_ViewPDF = new System.Windows.Forms.Button();
            this.button_CreateInvoice_SendEmail = new System.Windows.Forms.Button();
            this.button_CreateInvoice_SaveInvoice = new System.Windows.Forms.Button();
            this.tabPage_Invoices_CreateRecurringInvoice = new System.Windows.Forms.TabPage();
            this.splitContainer_CreateRecurringInvoice_Root = new System.Windows.Forms.SplitContainer();
            this.splitContainer_CreateRecurringInvoice_Client = new System.Windows.Forms.SplitContainer();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.button_CreateRecurringInvoice_ChangeClient = new System.Windows.Forms.Button();
            this.panel_CreateRecurringInvoice_SelectClient = new System.Windows.Forms.Panel();
            this.button_CreateRecurringInvoice_SelectClient = new System.Windows.Forms.Button();
            this.comboBox_CreateRecurringInvoice_SelectClient = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox_CreateRecurringInvoice_ClientDetail = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_CreateRecurringInvoice_Send2Client_Yes = new System.Windows.Forms.RadioButton();
            this.radioButton_CreateRecurringInvoice_Send2Client_No = new System.Windows.Forms.RadioButton();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.textBox_CreateRecurringInvoice_InvoiceID = new System.Windows.Forms.TextBox();
            this.dateTimePicker_CreateRecurringInvoice_DueDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_CreateRecurringInvoice_Status = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_CreateRecurringInvoice_InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label81 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.numericUpDown_CreateRecurringInvoice_NextDays = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CreateRecurringInvoice_DueDays = new System.Windows.Forms.NumericUpDown();
            this.splitContainer_CreateRecurringInvoice_Bottom = new System.Windows.Forms.SplitContainer();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.gridView_CreateRecurringInvoice_InvoiceItem = new DASInvoice.control.GridViewCustom();
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.textBox_CreateRecurringInvoice_Comments = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label35 = new System.Windows.Forms.Label();
            this.label_CreateRecurringInvoice_Total = new System.Windows.Forms.Label();
            this.textBox_CreateRecurringInvoice_SubTotal = new System.Windows.Forms.TextBox();
            this.textBox_CreateRecurringInvoice_VAT_Value = new System.Windows.Forms.TextBox();
            this.textBox_CreateRecurringInvoice_GrandTotal = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label36 = new System.Windows.Forms.Label();
            this.numericUpDown_CreateRecurringInvoice_VAT_Percent = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button_CreateRecurringInvoice_SaveInvoice = new System.Windows.Forms.Button();
            this.tabPage_Invoices_PendingInvoices = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_PendingInvoices_InvoiceID = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.comboBox_PendingInvoices_Client = new System.Windows.Forms.ComboBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.dateTimePicker_PendingInvoices_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_PendingInvoices_DateTo = new System.Windows.Forms.DateTimePicker();
            this.button_PendingInvoices_Search = new System.Windows.Forms.Button();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.label_PendingInvoices_Result = new System.Windows.Forms.Label();
            this.dataGridView_PendingInvoices = new DASInvoice.control.GridViewCustom();
            this.dataGridViewColumn_PendingInvoices_InvoiceID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewColumn_PendingInvoices_Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_PendingInvoices_Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_PendingInvoices_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_PendingInvoices_Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_PendingInvoices_DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_PendingInvoices_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_PendingInvoices_View = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewColumn_PendingInvoices_Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewColumn_PendingInvoices_Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabPage_Invoices_RecurringInvoices = new System.Windows.Forms.TabPage();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label62 = new System.Windows.Forms.Label();
            this.button_RecurringInvoices_Search = new System.Windows.Forms.Button();
            this.comboBox_RecurringInvoices_Client = new System.Windows.Forms.ComboBox();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.splitContainer10 = new System.Windows.Forms.SplitContainer();
            this.label_RecurringInvoices_Result = new System.Windows.Forms.Label();
            this.dataGridView_RecurringInvoices = new DASInvoice.control.GridViewCustom();
            this.dataGridViewColumn_RecurringInvoices_InvoiceID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewColumn_RecurringInvoices_Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_RecurringInvoices_Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_RecurringInvoices_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_RecurringInvoices_Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_RecurringInvoices_NextDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_RecurringInvoices_DueDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_RecurringInvoices_View = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewColumn_RecurringInvoices_Print = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewColumn_RecurringInvoices_Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabPage_Invoices_EditRecurringInvoice = new System.Windows.Forms.TabPage();
            this.splitContainer_EditRecurringInvoice_Root = new System.Windows.Forms.SplitContainer();
            this.splitContainer_EditRecurringInvoice_Client = new System.Windows.Forms.SplitContainer();
            this.groupBox35 = new System.Windows.Forms.GroupBox();
            this.button_EditRecurringInvoice_ChangeClient = new System.Windows.Forms.Button();
            this.panel_EditRecurringInvoice_SelectClient = new System.Windows.Forms.Panel();
            this.button_EditRecurringInvoice_SelectClient = new System.Windows.Forms.Button();
            this.comboBox_EditRecurringInvoice_SelectClient = new System.Windows.Forms.ComboBox();
            this.label117 = new System.Windows.Forms.Label();
            this.textBox_EditRecurringInvoice_ClientDetail = new System.Windows.Forms.TextBox();
            this.groupBox37 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_EditRecurringInvoice_Send2Client_Yes = new System.Windows.Forms.RadioButton();
            this.radioButton_EditRecurringInvoice_Send2Client_No = new System.Windows.Forms.RadioButton();
            this.label118 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.textBox_EditRecurringInvoice_InvoiceID = new System.Windows.Forms.TextBox();
            this.dateTimePicker_EditRecurringInvoice_DueDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_EditRecurringInvoice_Status = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_EditRecurringInvoice_InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label123 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.numericUpDown_EditRecurringInvoice_NextDays = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_EditRecurringInvoice_DueDays = new System.Windows.Forms.NumericUpDown();
            this.splitContainer22 = new System.Windows.Forms.SplitContainer();
            this.groupBox38 = new System.Windows.Forms.GroupBox();
            this.gridView_EditRecurringInvoice_InvoiceItem = new DASInvoice.control.GridViewCustom();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer23 = new System.Windows.Forms.SplitContainer();
            this.splitContainer24 = new System.Windows.Forms.SplitContainer();
            this.groupBox39 = new System.Windows.Forms.GroupBox();
            this.textBox_EditRecurringInvoice_Comments = new System.Windows.Forms.TextBox();
            this.groupBox40 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.label125 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.textBox_EditRecurringInvoice_SubTotal = new System.Windows.Forms.TextBox();
            this.textBox_EditRecurringInvoice_VAT_Value = new System.Windows.Forms.TextBox();
            this.textBox_EditRecurringInvoice_GrandTotal = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel15 = new System.Windows.Forms.FlowLayoutPanel();
            this.label127 = new System.Windows.Forms.Label();
            this.numericUpDown_EditRecurringInvoice_VAT_Percent = new System.Windows.Forms.NumericUpDown();
            this.label128 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button_EditRecurringInvoice_ViewPDF = new System.Windows.Forms.Button();
            this.button_EditRecurringInvoice_SendEmail = new System.Windows.Forms.Button();
            this.button_EditRecurringInvoice_SaveInvoice = new System.Windows.Forms.Button();
            this.tabPage_Payments = new System.Windows.Forms.TabPage();
            this.tabControl_Payments = new TradeWright.UI.Forms.TabControlExtra();
            this.tabPage_Payments_PostPayment = new System.Windows.Forms.TabPage();
            this.groupBox_PostPayment = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_PostPayment = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker_PostPayment_PaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label37 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.button_PostPayment_PostPayment = new System.Windows.Forms.Button();
            this.textBox_PostPayment_Notes = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_PostPayment_Amount = new System.Windows.Forms.TextBox();
            this.label_PostPayment_Currency = new System.Windows.Forms.Label();
            this.comboBox_PostPayment_PaymentType = new System.Windows.Forms.ComboBox();
            this.comboBox_PostPayment_InvoiceID = new System.Windows.Forms.ComboBox();
            this.tabPage_Payments_EditPayment = new System.Windows.Forms.TabPage();
            this.splitContainer15 = new System.Windows.Forms.SplitContainer();
            this.splitContainer16 = new System.Windows.Forms.SplitContainer();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label82 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.splitContainer17 = new System.Windows.Forms.SplitContainer();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.gridViewCustom3 = new DASInvoice.control.GridViewCustom();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer18 = new System.Windows.Forms.SplitContainer();
            this.splitContainer19 = new System.Windows.Forms.SplitContainer();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.groupBox34 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.label90 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label91 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.tabPage_Payments_SearchPayment = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_SearchPayment_PaymentID = new System.Windows.Forms.TextBox();
            this.textBox_SearchPayment_InvoiceID = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.button_SearchPayment_Search = new System.Windows.Forms.Button();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.dateTimePicker_SearchPayment_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_SearchPayment_DateTo = new System.Windows.Forms.DateTimePicker();
            this.comboBox_SearchPayment_Client = new System.Windows.Forms.ComboBox();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label_SearchPayment_Result = new System.Windows.Forms.Label();
            this.dataGridView_SearchPayment = new DASInvoice.control.GridViewCustom();
            this.dataGridViewColumn5 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn6 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewColumn7 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewColumn8 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabPage_Settings = new System.Windows.Forms.TabPage();
            this.tabControl_Settings = new TradeWright.UI.Forms.TabControlExtra();
            this.tabPage_Settings_General = new System.Windows.Forms.TabPage();
            this.groupBox49 = new System.Windows.Forms.GroupBox();
            this.button27 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label150 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label151 = new System.Windows.Forms.Label();
            this.label152 = new System.Windows.Forms.Label();
            this.flowLayoutPanel21 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox48 = new System.Windows.Forms.GroupBox();
            this.button26 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label149 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label148 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.flowLayoutPanel20 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox47 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel19 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label146 = new System.Windows.Forms.Label();
            this.flowLayoutPanel18 = new System.Windows.Forms.FlowLayoutPanel();
            this.label144 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.flowLayoutPanel17 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label143 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.flowLayoutPanel16 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label142 = new System.Windows.Forms.Label();
            this.tabPage_Settings_EmailTemplates = new System.Windows.Forms.TabPage();
            this.groupBox42 = new System.Windows.Forms.GroupBox();
            this.splitContainer21 = new System.Windows.Forms.SplitContainer();
            this.label135 = new System.Windows.Forms.Label();
            this.groupBox43 = new System.Windows.Forms.GroupBox();
            this.richTextBox_EmailTemplate_Variables = new System.Windows.Forms.RichTextBox();
            this.label134 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label133 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label132 = new System.Windows.Forms.Label();
            this.splitContainer25 = new System.Windows.Forms.SplitContainer();
            this.codeView_EmailTemplates = new Zeroit.Framework.CodeEditor.TextEditor.CodeView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage_Settings_InvoiceTemplates = new System.Windows.Forms.TabPage();
            this.splitContainer26 = new System.Windows.Forms.SplitContainer();
            this.groupBox44 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox45 = new System.Windows.Forms.GroupBox();
            this.label137 = new System.Windows.Forms.Label();
            this.textBox_InvoiceTemplates_PaymentDetails = new System.Windows.Forms.TextBox();
            this.label136 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label131 = new System.Windows.Forms.Label();
            this.textBox_Settings_InvoiceTemplates_CompanyName = new System.Windows.Forms.TextBox();
            this.label130 = new System.Windows.Forms.Label();
            this.textBox_InvoiceTemplates_CompanyDetails = new System.Windows.Forms.TextBox();
            this.groupBox46 = new System.Windows.Forms.GroupBox();
            this.splitContainer27 = new System.Windows.Forms.SplitContainer();
            this.label138 = new System.Windows.Forms.Label();
            this.splitContainer28 = new System.Windows.Forms.SplitContainer();
            this.codeView1 = new Zeroit.Framework.CodeEditor.TextEditor.CodeView();
            this.button25 = new System.Windows.Forms.Button();
            this.tabPage_Settings_ManageUsers = new System.Windows.Forms.TabPage();
            this.groupBox_ManageUsers = new System.Windows.Forms.GroupBox();
            this.splitContainer20 = new System.Windows.Forms.SplitContainer();
            this.label_ManageUsers_Result = new System.Windows.Forms.Label();
            this.dataGridView_ManageUsers = new System.Windows.Forms.DataGridView();
            this.dataGridViewColumn_ManageUsers_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_ManageUsers_Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_ManageUsers_Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumn_ManageUsers_PasswordRecovery = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewColumn_ManageUsers_Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabPage_Settings_SMTPServer = new System.Windows.Forms.TabPage();
            this.groupBox41 = new System.Windows.Forms.GroupBox();
            this.tabPage_Import = new System.Windows.Forms.TabPage();
            this.tabPage_Reports = new System.Windows.Forms.TabPage();
            this.tabPage_Help = new System.Windows.Forms.TabPage();
            this.tabControl_Help = new TradeWright.UI.Forms.TabControlExtra();
            this.tabPage_AboutUs = new System.Windows.Forms.TabPage();
            this.tabPage_Licence = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog_PDF = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTipValidation1 = new DASInvoice.control.ToolTipValidation();
            this.toolTipValidation2 = new DASInvoice.control.ToolTipValidation();
            this.toolTipValidation3 = new DASInvoice.control.ToolTipValidation();
            this.toolTipValidation4 = new DASInvoice.control.ToolTipValidation();
            this.toolTipValidation5 = new DASInvoice.control.ToolTipValidation();
            this.toolTipValidation6 = new DASInvoice.control.ToolTipValidation();
            this.toolTipValidation7 = new DASInvoice.control.ToolTipValidation();
            this.toolTipValidation8 = new DASInvoice.control.ToolTipValidation();
            this.toolTipValidation9 = new DASInvoice.control.ToolTipValidation();
            this.toolTipValidation10 = new DASInvoice.control.ToolTipValidation();
            this.toolTipValidation11 = new DASInvoice.control.ToolTipValidation();
            this.toolTipValidation12 = new DASInvoice.control.ToolTipValidation();
            this.tabControl_Root.SuspendLayout();
            this.tabPage_Dashboard.SuspendLayout();
            this.tabControl_Dashboard.SuspendLayout();
            this.tabPage_Dashboard_Summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Dashboard_Summary_2)).BeginInit();
            this.splitContainer_Dashboard_Summary_2.Panel1.SuspendLayout();
            this.splitContainer_Dashboard_Summary_2.Panel2.SuspendLayout();
            this.splitContainer_Dashboard_Summary_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Dashboard_Summary_1)).BeginInit();
            this.splitContainer_Dashboard_Summary_1.Panel1.SuspendLayout();
            this.splitContainer_Dashboard_Summary_1.Panel2.SuspendLayout();
            this.splitContainer_Dashboard_Summary_1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Summary_RecentInvoices)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Summary_PastDueInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Dashboard_Summary_3)).BeginInit();
            this.splitContainer_Dashboard_Summary_3.Panel1.SuspendLayout();
            this.splitContainer_Dashboard_Summary_3.Panel2.SuspendLayout();
            this.splitContainer_Dashboard_Summary_3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tabPage_Clients.SuspendLayout();
            this.tabControl_Clients.SuspendLayout();
            this.tabPage_SearchClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Clients_SearchClients)).BeginInit();
            this.splitContainer_Clients_SearchClients.Panel1.SuspendLayout();
            this.splitContainer_Clients_SearchClients.Panel2.SuspendLayout();
            this.splitContainer_Clients_SearchClients.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Clients_SearchClients_Clients)).BeginInit();
            this.splitContainer_Clients_SearchClients_Clients.Panel1.SuspendLayout();
            this.splitContainer_Clients_SearchClients_Clients.Panel2.SuspendLayout();
            this.splitContainer_Clients_SearchClients_Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchClient)).BeginInit();
            this.tabPage_EditClient.SuspendLayout();
            this.groupBox_EditClient.SuspendLayout();
            this.groupBox36.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.flowLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EditClient_VATPercent)).BeginInit();
            this.tableLayoutPanel15.SuspendLayout();
            this.tabPage_CreateClient.SuspendLayout();
            this.groupBox_CreateClient_createClient.SuspendLayout();
            this.groupBox_CreateClient_ClientSettings.SuspendLayout();
            this.tableLayoutPanel_CreateClient_ClientSettings.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CreateClient_VATPercent)).BeginInit();
            this.tableLayoutPanel_Clients_CreateClient.SuspendLayout();
            this.tabPage_Invoices.SuspendLayout();
            this.tabControl_Invoices.SuspendLayout();
            this.tabPage_Invoices_SearchInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_SearchInvoice_Root)).BeginInit();
            this.splitContainer_SearchInvoice_Root.Panel1.SuspendLayout();
            this.splitContainer_SearchInvoice_Root.Panel2.SuspendLayout();
            this.splitContainer_SearchInvoice_Root.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchInvoice)).BeginInit();
            this.tabPage_Invoices_EditInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_EditInvoice_Root)).BeginInit();
            this.splitContainer_EditInvoice_Root.Panel1.SuspendLayout();
            this.splitContainer_EditInvoice_Root.Panel2.SuspendLayout();
            this.splitContainer_EditInvoice_Root.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_EditInvoice_Client)).BeginInit();
            this.splitContainer_EditInvoice_Client.Panel1.SuspendLayout();
            this.splitContainer_EditInvoice_Client.Panel2.SuspendLayout();
            this.splitContainer_EditInvoice_Client.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel_EditInvoice_SelectClient.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_EditInvoice_InvoiceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer13)).BeginInit();
            this.splitContainer13.Panel1.SuspendLayout();
            this.splitContainer13.Panel2.SuspendLayout();
            this.splitContainer13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer14)).BeginInit();
            this.splitContainer14.Panel1.SuspendLayout();
            this.splitContainer14.Panel2.SuspendLayout();
            this.splitContainer14.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EditInvoice_VAT_Percent)).BeginInit();
            this.tabPage_Invoices_CreateInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_CreateInvoice_Root)).BeginInit();
            this.splitContainer_CreateInvoice_Root.Panel1.SuspendLayout();
            this.splitContainer_CreateInvoice_Root.Panel2.SuspendLayout();
            this.splitContainer_CreateInvoice_Root.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_CreateInvoice_Client)).BeginInit();
            this.splitContainer_CreateInvoice_Client.Panel1.SuspendLayout();
            this.splitContainer_CreateInvoice_Client.Panel2.SuspendLayout();
            this.splitContainer_CreateInvoice_Client.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel_CreateInvoice_SelectClient.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Dashboard_CreateInvoice_Bottom)).BeginInit();
            this.splitContainer_Dashboard_CreateInvoice_Bottom.Panel1.SuspendLayout();
            this.splitContainer_Dashboard_CreateInvoice_Bottom.Panel2.SuspendLayout();
            this.splitContainer_Dashboard_CreateInvoice_Bottom.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CreateInvoice_InvoiceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).BeginInit();
            this.splitContainer11.Panel1.SuspendLayout();
            this.splitContainer11.Panel2.SuspendLayout();
            this.splitContainer11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer12)).BeginInit();
            this.splitContainer12.Panel1.SuspendLayout();
            this.splitContainer12.Panel2.SuspendLayout();
            this.splitContainer12.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CreateInvoice_VAT_Percent)).BeginInit();
            this.tabPage_Invoices_CreateRecurringInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_CreateRecurringInvoice_Root)).BeginInit();
            this.splitContainer_CreateRecurringInvoice_Root.Panel1.SuspendLayout();
            this.splitContainer_CreateRecurringInvoice_Root.Panel2.SuspendLayout();
            this.splitContainer_CreateRecurringInvoice_Root.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_CreateRecurringInvoice_Client)).BeginInit();
            this.splitContainer_CreateRecurringInvoice_Client.Panel1.SuspendLayout();
            this.splitContainer_CreateRecurringInvoice_Client.Panel2.SuspendLayout();
            this.splitContainer_CreateRecurringInvoice_Client.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.panel_CreateRecurringInvoice_SelectClient.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CreateRecurringInvoice_NextDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CreateRecurringInvoice_DueDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_CreateRecurringInvoice_Bottom)).BeginInit();
            this.splitContainer_CreateRecurringInvoice_Bottom.Panel1.SuspendLayout();
            this.splitContainer_CreateRecurringInvoice_Bottom.Panel2.SuspendLayout();
            this.splitContainer_CreateRecurringInvoice_Bottom.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CreateRecurringInvoice_InvoiceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CreateRecurringInvoice_VAT_Percent)).BeginInit();
            this.tabPage_Invoices_PendingInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PendingInvoices)).BeginInit();
            this.tabPage_Invoices_RecurringInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).BeginInit();
            this.splitContainer10.Panel1.SuspendLayout();
            this.splitContainer10.Panel2.SuspendLayout();
            this.splitContainer10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RecurringInvoices)).BeginInit();
            this.tabPage_Invoices_EditRecurringInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_EditRecurringInvoice_Root)).BeginInit();
            this.splitContainer_EditRecurringInvoice_Root.Panel1.SuspendLayout();
            this.splitContainer_EditRecurringInvoice_Root.Panel2.SuspendLayout();
            this.splitContainer_EditRecurringInvoice_Root.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_EditRecurringInvoice_Client)).BeginInit();
            this.splitContainer_EditRecurringInvoice_Client.Panel1.SuspendLayout();
            this.splitContainer_EditRecurringInvoice_Client.Panel2.SuspendLayout();
            this.splitContainer_EditRecurringInvoice_Client.SuspendLayout();
            this.groupBox35.SuspendLayout();
            this.panel_EditRecurringInvoice_SelectClient.SuspendLayout();
            this.groupBox37.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.flowLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EditRecurringInvoice_NextDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EditRecurringInvoice_DueDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer22)).BeginInit();
            this.splitContainer22.Panel1.SuspendLayout();
            this.splitContainer22.Panel2.SuspendLayout();
            this.splitContainer22.SuspendLayout();
            this.groupBox38.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_EditRecurringInvoice_InvoiceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer23)).BeginInit();
            this.splitContainer23.Panel1.SuspendLayout();
            this.splitContainer23.Panel2.SuspendLayout();
            this.splitContainer23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer24)).BeginInit();
            this.splitContainer24.Panel1.SuspendLayout();
            this.splitContainer24.Panel2.SuspendLayout();
            this.splitContainer24.SuspendLayout();
            this.groupBox39.SuspendLayout();
            this.groupBox40.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.flowLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EditRecurringInvoice_VAT_Percent)).BeginInit();
            this.tabPage_Payments.SuspendLayout();
            this.tabControl_Payments.SuspendLayout();
            this.tabPage_Payments_PostPayment.SuspendLayout();
            this.groupBox_PostPayment.SuspendLayout();
            this.tableLayoutPanel_PostPayment.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.tabPage_Payments_EditPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer15)).BeginInit();
            this.splitContainer15.Panel1.SuspendLayout();
            this.splitContainer15.Panel2.SuspendLayout();
            this.splitContainer15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer16)).BeginInit();
            this.splitContainer16.Panel1.SuspendLayout();
            this.splitContainer16.Panel2.SuspendLayout();
            this.splitContainer16.SuspendLayout();
            this.groupBox30.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox31.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer17)).BeginInit();
            this.splitContainer17.Panel1.SuspendLayout();
            this.splitContainer17.Panel2.SuspendLayout();
            this.splitContainer17.SuspendLayout();
            this.groupBox32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer18)).BeginInit();
            this.splitContainer18.Panel1.SuspendLayout();
            this.splitContainer18.Panel2.SuspendLayout();
            this.splitContainer18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer19)).BeginInit();
            this.splitContainer19.Panel1.SuspendLayout();
            this.splitContainer19.Panel2.SuspendLayout();
            this.splitContainer19.SuspendLayout();
            this.groupBox33.SuspendLayout();
            this.groupBox34.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage_Payments_SearchPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.groupBox29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchPayment)).BeginInit();
            this.tabPage_Settings.SuspendLayout();
            this.tabControl_Settings.SuspendLayout();
            this.tabPage_Settings_General.SuspendLayout();
            this.groupBox49.SuspendLayout();
            this.groupBox48.SuspendLayout();
            this.groupBox47.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.flowLayoutPanel19.SuspendLayout();
            this.flowLayoutPanel18.SuspendLayout();
            this.flowLayoutPanel17.SuspendLayout();
            this.flowLayoutPanel16.SuspendLayout();
            this.tabPage_Settings_EmailTemplates.SuspendLayout();
            this.groupBox42.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer21)).BeginInit();
            this.splitContainer21.Panel1.SuspendLayout();
            this.splitContainer21.Panel2.SuspendLayout();
            this.splitContainer21.SuspendLayout();
            this.groupBox43.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer25)).BeginInit();
            this.splitContainer25.Panel1.SuspendLayout();
            this.splitContainer25.Panel2.SuspendLayout();
            this.splitContainer25.SuspendLayout();
            this.tabPage_Settings_InvoiceTemplates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer26)).BeginInit();
            this.splitContainer26.Panel1.SuspendLayout();
            this.splitContainer26.Panel2.SuspendLayout();
            this.splitContainer26.SuspendLayout();
            this.groupBox44.SuspendLayout();
            this.groupBox45.SuspendLayout();
            this.groupBox46.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer27)).BeginInit();
            this.splitContainer27.Panel1.SuspendLayout();
            this.splitContainer27.Panel2.SuspendLayout();
            this.splitContainer27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer28)).BeginInit();
            this.splitContainer28.Panel1.SuspendLayout();
            this.splitContainer28.Panel2.SuspendLayout();
            this.splitContainer28.SuspendLayout();
            this.tabPage_Settings_ManageUsers.SuspendLayout();
            this.groupBox_ManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer20)).BeginInit();
            this.splitContainer20.Panel1.SuspendLayout();
            this.splitContainer20.Panel2.SuspendLayout();
            this.splitContainer20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManageUsers)).BeginInit();
            this.tabPage_Settings_SMTPServer.SuspendLayout();
            this.tabPage_Help.SuspendLayout();
            this.tabControl_Help.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Root
            // 
            this.tabControl_Root.Controls.Add(this.tabPage_Dashboard);
            this.tabControl_Root.Controls.Add(this.tabPage_Clients);
            this.tabControl_Root.Controls.Add(this.tabPage_Invoices);
            this.tabControl_Root.Controls.Add(this.tabPage_Payments);
            this.tabControl_Root.Controls.Add(this.tabPage_Settings);
            this.tabControl_Root.Controls.Add(this.tabPage_Import);
            this.tabControl_Root.Controls.Add(this.tabPage_Reports);
            this.tabControl_Root.Controls.Add(this.tabPage_Help);
            this.tabControl_Root.DisplayStyle = TradeWright.UI.Forms.TabStyle.Angled;
            // 
            // 
            // 
            this.tabControl_Root.DisplayStyleProvider.BlendStyle = TradeWright.UI.Forms.BlendStyle.Normal;
            this.tabControl_Root.DisplayStyleProvider.BorderColorDisabled = System.Drawing.SystemColors.ControlLight;
            this.tabControl_Root.DisplayStyleProvider.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControl_Root.DisplayStyleProvider.BorderColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Root.DisplayStyleProvider.BorderColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Root.DisplayStyleProvider.BorderColorUnselected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Root.DisplayStyleProvider.CloserButtonFillColorFocused = System.Drawing.Color.Empty;
            this.tabControl_Root.DisplayStyleProvider.CloserButtonFillColorFocusedActive = System.Drawing.Color.Empty;
            this.tabControl_Root.DisplayStyleProvider.CloserButtonFillColorHighlighted = System.Drawing.Color.Empty;
            this.tabControl_Root.DisplayStyleProvider.CloserButtonFillColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabControl_Root.DisplayStyleProvider.CloserButtonFillColorSelected = System.Drawing.Color.Empty;
            this.tabControl_Root.DisplayStyleProvider.CloserButtonFillColorSelectedActive = System.Drawing.Color.Empty;
            this.tabControl_Root.DisplayStyleProvider.CloserButtonFillColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Root.DisplayStyleProvider.CloserButtonOutlineColorFocused = System.Drawing.Color.Empty;
            this.tabControl_Root.DisplayStyleProvider.CloserButtonOutlineColorFocusedActive = System.Drawing.Color.Empty;
            this.tabControl_Root.DisplayStyleProvider.CloserButtonOutlineColorHighlighted = System.Drawing.Color.Empty;
            this.tabControl_Root.DisplayStyleProvider.CloserButtonOutlineColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabControl_Root.DisplayStyleProvider.CloserButtonOutlineColorSelected = System.Drawing.Color.Empty;
            this.tabControl_Root.DisplayStyleProvider.CloserButtonOutlineColorSelectedActive = System.Drawing.Color.Empty;
            this.tabControl_Root.DisplayStyleProvider.CloserButtonOutlineColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Root.DisplayStyleProvider.CloserColorFocused = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Root.DisplayStyleProvider.CloserColorFocusedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Root.DisplayStyleProvider.CloserColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Root.DisplayStyleProvider.CloserColorHighlightedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Root.DisplayStyleProvider.CloserColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Root.DisplayStyleProvider.CloserColorSelectedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Root.DisplayStyleProvider.CloserColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Root.DisplayStyleProvider.FocusTrack = false;
            this.tabControl_Root.DisplayStyleProvider.HotTrack = true;
            this.tabControl_Root.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tabControl_Root.DisplayStyleProvider.Opacity = 1F;
            this.tabControl_Root.DisplayStyleProvider.Overlap = 8;
            this.tabControl_Root.DisplayStyleProvider.Padding = new System.Drawing.Point(12, 4);
            this.tabControl_Root.DisplayStyleProvider.PageBackgroundColorDisabled = System.Drawing.SystemColors.Control;
            this.tabControl_Root.DisplayStyleProvider.PageBackgroundColorFocused = System.Drawing.SystemColors.ControlLight;
            this.tabControl_Root.DisplayStyleProvider.PageBackgroundColorHighlighted = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabControl_Root.DisplayStyleProvider.PageBackgroundColorSelected = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Root.DisplayStyleProvider.PageBackgroundColorUnselected = System.Drawing.SystemColors.Control;
            this.tabControl_Root.DisplayStyleProvider.Radius = 12;
            this.tabControl_Root.DisplayStyleProvider.SelectedTabIsLarger = true;
            this.tabControl_Root.DisplayStyleProvider.ShowTabCloser = false;
            this.tabControl_Root.DisplayStyleProvider.TabColorDisabled1 = System.Drawing.SystemColors.Control;
            this.tabControl_Root.DisplayStyleProvider.TabColorDisabled2 = System.Drawing.SystemColors.Control;
            this.tabControl_Root.DisplayStyleProvider.TabColorFocused1 = System.Drawing.Color.White;
            this.tabControl_Root.DisplayStyleProvider.TabColorFocused2 = System.Drawing.Color.White;
            this.tabControl_Root.DisplayStyleProvider.TabColorHighLighted1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabControl_Root.DisplayStyleProvider.TabColorHighLighted2 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.tabControl_Root.DisplayStyleProvider.TabColorSelected1 = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Root.DisplayStyleProvider.TabColorSelected2 = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Root.DisplayStyleProvider.TabColorUnSelected1 = System.Drawing.SystemColors.Control;
            this.tabControl_Root.DisplayStyleProvider.TabColorUnSelected2 = System.Drawing.SystemColors.Control;
            this.tabControl_Root.DisplayStyleProvider.TabPageMargin = new System.Windows.Forms.Padding(1);
            this.tabControl_Root.DisplayStyleProvider.TextColorFocused = System.Drawing.SystemColors.ControlText;
            this.tabControl_Root.DisplayStyleProvider.TextColorHighlighted = System.Drawing.SystemColors.ControlText;
            this.tabControl_Root.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.tabControl_Root.DisplayStyleProvider.TextColorUnselected = System.Drawing.SystemColors.ControlDarkDark;
            this.tabControl_Root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Root.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Root.HotTrack = true;
            this.tabControl_Root.ItemSize = new System.Drawing.Size(134, 25);
            this.tabControl_Root.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Root.Name = "tabControl_Root";
            this.tabControl_Root.RightToLeftLayout = true;
            this.tabControl_Root.SelectedIndex = 0;
            this.tabControl_Root.Size = new System.Drawing.Size(944, 681);
            this.tabControl_Root.TabIndex = 0;
            this.tabControl_Root.SelectedIndexChanged += new System.EventHandler(this.tabControl_Root_SelectedIndexChanged);
            // 
            // tabPage_Dashboard
            // 
            this.tabPage_Dashboard.Controls.Add(this.tabControl_Dashboard);
            this.tabPage_Dashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Dashboard.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Dashboard.Name = "tabPage_Dashboard";
            this.tabPage_Dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Dashboard.Size = new System.Drawing.Size(936, 647);
            this.tabPage_Dashboard.TabIndex = 0;
            this.tabPage_Dashboard.Text = "Dashboard";
            // 
            // tabControl_Dashboard
            // 
            this.tabControl_Dashboard.Controls.Add(this.tabPage_Dashboard_Summary);
            this.tabControl_Dashboard.Controls.Add(this.tabPage_Dashboard_CreateInvoice);
            this.tabControl_Dashboard.Controls.Add(this.tabPage_Dashboard_SearchInvoice);
            this.tabControl_Dashboard.Controls.Add(this.tabPage_Dashboard_PostPayment);
            this.tabControl_Dashboard.Controls.Add(this.tabPage_Dashboard_InvoiceReport);
            this.tabControl_Dashboard.Controls.Add(this.tabPage_Dashboard_PaymentReport);
            this.tabControl_Dashboard.DisplayStyle = TradeWright.UI.Forms.TabStyle.Angled;
            // 
            // 
            // 
            this.tabControl_Dashboard.DisplayStyleProvider.BlendStyle = TradeWright.UI.Forms.BlendStyle.Normal;
            this.tabControl_Dashboard.DisplayStyleProvider.BorderColorDisabled = System.Drawing.SystemColors.ControlLight;
            this.tabControl_Dashboard.DisplayStyleProvider.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControl_Dashboard.DisplayStyleProvider.BorderColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Dashboard.DisplayStyleProvider.BorderColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Dashboard.DisplayStyleProvider.BorderColorUnselected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserButtonFillColorFocused = System.Drawing.Color.Empty;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserButtonFillColorFocusedActive = System.Drawing.Color.Empty;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserButtonFillColorHighlighted = System.Drawing.Color.Empty;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserButtonFillColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserButtonFillColorSelected = System.Drawing.Color.Empty;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserButtonFillColorSelectedActive = System.Drawing.Color.Empty;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserButtonFillColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserButtonOutlineColorFocused = System.Drawing.Color.Empty;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserButtonOutlineColorFocusedActive = System.Drawing.Color.Empty;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserButtonOutlineColorHighlighted = System.Drawing.Color.Empty;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserButtonOutlineColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserButtonOutlineColorSelected = System.Drawing.Color.Empty;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserButtonOutlineColorSelectedActive = System.Drawing.Color.Empty;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserButtonOutlineColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserColorFocused = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserColorFocusedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserColorHighlightedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserColorSelectedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Dashboard.DisplayStyleProvider.CloserColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Dashboard.DisplayStyleProvider.FocusTrack = false;
            this.tabControl_Dashboard.DisplayStyleProvider.HotTrack = true;
            this.tabControl_Dashboard.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tabControl_Dashboard.DisplayStyleProvider.Opacity = 1F;
            this.tabControl_Dashboard.DisplayStyleProvider.Overlap = 8;
            this.tabControl_Dashboard.DisplayStyleProvider.Padding = new System.Drawing.Point(8, 4);
            this.tabControl_Dashboard.DisplayStyleProvider.PageBackgroundColorDisabled = System.Drawing.SystemColors.Control;
            this.tabControl_Dashboard.DisplayStyleProvider.PageBackgroundColorFocused = System.Drawing.SystemColors.ControlLight;
            this.tabControl_Dashboard.DisplayStyleProvider.PageBackgroundColorHighlighted = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabControl_Dashboard.DisplayStyleProvider.PageBackgroundColorSelected = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Dashboard.DisplayStyleProvider.PageBackgroundColorUnselected = System.Drawing.SystemColors.Control;
            this.tabControl_Dashboard.DisplayStyleProvider.Radius = 12;
            this.tabControl_Dashboard.DisplayStyleProvider.SelectedTabIsLarger = true;
            this.tabControl_Dashboard.DisplayStyleProvider.ShowTabCloser = false;
            this.tabControl_Dashboard.DisplayStyleProvider.TabColorDisabled1 = System.Drawing.SystemColors.Control;
            this.tabControl_Dashboard.DisplayStyleProvider.TabColorDisabled2 = System.Drawing.SystemColors.Control;
            this.tabControl_Dashboard.DisplayStyleProvider.TabColorFocused1 = System.Drawing.Color.White;
            this.tabControl_Dashboard.DisplayStyleProvider.TabColorFocused2 = System.Drawing.Color.White;
            this.tabControl_Dashboard.DisplayStyleProvider.TabColorHighLighted1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabControl_Dashboard.DisplayStyleProvider.TabColorHighLighted2 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.tabControl_Dashboard.DisplayStyleProvider.TabColorSelected1 = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Dashboard.DisplayStyleProvider.TabColorSelected2 = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Dashboard.DisplayStyleProvider.TabColorUnSelected1 = System.Drawing.SystemColors.Control;
            this.tabControl_Dashboard.DisplayStyleProvider.TabColorUnSelected2 = System.Drawing.SystemColors.Control;
            this.tabControl_Dashboard.DisplayStyleProvider.TabPageMargin = new System.Windows.Forms.Padding(1);
            this.tabControl_Dashboard.DisplayStyleProvider.TextColorFocused = System.Drawing.SystemColors.ControlText;
            this.tabControl_Dashboard.DisplayStyleProvider.TextColorHighlighted = System.Drawing.SystemColors.ControlText;
            this.tabControl_Dashboard.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.tabControl_Dashboard.DisplayStyleProvider.TextColorUnselected = System.Drawing.SystemColors.ControlDarkDark;
            this.tabControl_Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Dashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Dashboard.HotTrack = true;
            this.tabControl_Dashboard.Location = new System.Drawing.Point(3, 3);
            this.tabControl_Dashboard.Name = "tabControl_Dashboard";
            this.tabControl_Dashboard.SelectedIndex = 0;
            this.tabControl_Dashboard.Size = new System.Drawing.Size(930, 641);
            this.tabControl_Dashboard.TabIndex = 0;
            // 
            // tabPage_Dashboard_Summary
            // 
            this.tabPage_Dashboard_Summary.Controls.Add(this.splitContainer_Dashboard_Summary_2);
            this.tabPage_Dashboard_Summary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Dashboard_Summary.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Dashboard_Summary.Name = "tabPage_Dashboard_Summary";
            this.tabPage_Dashboard_Summary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Dashboard_Summary.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Dashboard_Summary.TabIndex = 0;
            this.tabPage_Dashboard_Summary.Text = "Summary";
            this.tabPage_Dashboard_Summary.Enter += new System.EventHandler(this.tabPage_Dashboard_Summary_Enter);
            // 
            // splitContainer_Dashboard_Summary_2
            // 
            this.splitContainer_Dashboard_Summary_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Dashboard_Summary_2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_Dashboard_Summary_2.IsSplitterFixed = true;
            this.splitContainer_Dashboard_Summary_2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_Dashboard_Summary_2.Name = "splitContainer_Dashboard_Summary_2";
            this.splitContainer_Dashboard_Summary_2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Dashboard_Summary_2.Panel1
            // 
            this.splitContainer_Dashboard_Summary_2.Panel1.Controls.Add(this.splitContainer_Dashboard_Summary_1);
            this.splitContainer_Dashboard_Summary_2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer_Dashboard_Summary_2.Panel2
            // 
            this.splitContainer_Dashboard_Summary_2.Panel2.Controls.Add(this.splitContainer_Dashboard_Summary_3);
            this.splitContainer_Dashboard_Summary_2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_Dashboard_Summary_2.Size = new System.Drawing.Size(916, 603);
            this.splitContainer_Dashboard_Summary_2.SplitterDistance = 450;
            this.splitContainer_Dashboard_Summary_2.TabIndex = 0;
            // 
            // splitContainer_Dashboard_Summary_1
            // 
            this.splitContainer_Dashboard_Summary_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Dashboard_Summary_1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Dashboard_Summary_1.Name = "splitContainer_Dashboard_Summary_1";
            this.splitContainer_Dashboard_Summary_1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Dashboard_Summary_1.Panel1
            // 
            this.splitContainer_Dashboard_Summary_1.Panel1.Controls.Add(this.groupBox8);
            this.splitContainer_Dashboard_Summary_1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer_Dashboard_Summary_1.Panel2
            // 
            this.splitContainer_Dashboard_Summary_1.Panel2.Controls.Add(this.groupBox9);
            this.splitContainer_Dashboard_Summary_1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_Dashboard_Summary_1.Size = new System.Drawing.Size(916, 450);
            this.splitContainer_Dashboard_Summary_1.SplitterDistance = 228;
            this.splitContainer_Dashboard_Summary_1.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dataGridView_Summary_RecentInvoices);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(0, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(916, 228);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Recent Invoices";
            // 
            // dataGridView_Summary_RecentInvoices
            // 
            this.dataGridView_Summary_RecentInvoices.AllowUserToAddRows = false;
            this.dataGridView_Summary_RecentInvoices.AllowUserToDeleteRows = false;
            this.dataGridView_Summary_RecentInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Summary_RecentInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_InvoiceID,
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Customer,
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Total,
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Created,
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Status});
            this.dataGridView_Summary_RecentInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Summary_RecentInvoices.Location = new System.Drawing.Point(3, 23);
            this.dataGridView_Summary_RecentInvoices.Name = "dataGridView_Summary_RecentInvoices";
            this.dataGridView_Summary_RecentInvoices.ReadOnly = true;
            this.dataGridView_Summary_RecentInvoices.RowHeadersVisible = false;
            this.dataGridView_Summary_RecentInvoices.Size = new System.Drawing.Size(910, 202);
            this.dataGridView_Summary_RecentInvoices.TabIndex = 0;
            // 
            // dataGridViewColumn_Dashboard_Summary_RecentInvoices_InvoiceID
            // 
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_InvoiceID.HeaderText = "Invoice #";
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_InvoiceID.Name = "dataGridViewColumn_Dashboard_Summary_RecentInvoices_InvoiceID";
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_InvoiceID.ReadOnly = true;
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_InvoiceID.Width = 120;
            // 
            // dataGridViewColumn_Dashboard_Summary_RecentInvoices_Customer
            // 
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Customer.HeaderText = "Customer";
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Customer.Name = "dataGridViewColumn_Dashboard_Summary_RecentInvoices_Customer";
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Customer.ReadOnly = true;
            // 
            // dataGridViewColumn_Dashboard_Summary_RecentInvoices_Total
            // 
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Total.HeaderText = "Total";
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Total.Name = "dataGridViewColumn_Dashboard_Summary_RecentInvoices_Total";
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Total.ReadOnly = true;
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Total.Width = 120;
            // 
            // dataGridViewColumn_Dashboard_Summary_RecentInvoices_Created
            // 
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Created.HeaderText = "Created";
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Created.Name = "dataGridViewColumn_Dashboard_Summary_RecentInvoices_Created";
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Created.ReadOnly = true;
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Created.Width = 120;
            // 
            // dataGridViewColumn_Dashboard_Summary_RecentInvoices_Status
            // 
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Status.HeaderText = "Status";
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Status.Name = "dataGridViewColumn_Dashboard_Summary_RecentInvoices_Status";
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Status.ReadOnly = true;
            this.dataGridViewColumn_Dashboard_Summary_RecentInvoices_Status.Width = 120;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dataGridView_Summary_PastDueInvoices);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(0, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(916, 218);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Past Due Invoices";
            // 
            // dataGridView_Summary_PastDueInvoices
            // 
            this.dataGridView_Summary_PastDueInvoices.AllowUserToAddRows = false;
            this.dataGridView_Summary_PastDueInvoices.AllowUserToDeleteRows = false;
            this.dataGridView_Summary_PastDueInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Summary_PastDueInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_InvoiceID,
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_Customer,
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_AmountDue,
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DueDate,
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DaysDue});
            this.dataGridView_Summary_PastDueInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Summary_PastDueInvoices.Location = new System.Drawing.Point(3, 23);
            this.dataGridView_Summary_PastDueInvoices.Name = "dataGridView_Summary_PastDueInvoices";
            this.dataGridView_Summary_PastDueInvoices.ReadOnly = true;
            this.dataGridView_Summary_PastDueInvoices.RowHeadersVisible = false;
            this.dataGridView_Summary_PastDueInvoices.Size = new System.Drawing.Size(910, 192);
            this.dataGridView_Summary_PastDueInvoices.TabIndex = 0;
            // 
            // dataGridViewColumn_Dashboard_Summary_PastDueInvoices_InvoiceID
            // 
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_InvoiceID.HeaderText = "Invoice #";
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_InvoiceID.Name = "dataGridViewColumn_Dashboard_Summary_PastDueInvoices_InvoiceID";
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_InvoiceID.ReadOnly = true;
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_InvoiceID.Width = 120;
            // 
            // dataGridViewColumn_Dashboard_Summary_PastDueInvoices_Customer
            // 
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_Customer.HeaderText = "Customer";
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_Customer.Name = "dataGridViewColumn_Dashboard_Summary_PastDueInvoices_Customer";
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_Customer.ReadOnly = true;
            // 
            // dataGridViewColumn_Dashboard_Summary_PastDueInvoices_AmountDue
            // 
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_AmountDue.HeaderText = "AmountDue";
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_AmountDue.Name = "dataGridViewColumn_Dashboard_Summary_PastDueInvoices_AmountDue";
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_AmountDue.ReadOnly = true;
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_AmountDue.Width = 120;
            // 
            // dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DueDate
            // 
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DueDate.HeaderText = "Due Date";
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DueDate.Name = "dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DueDate";
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DueDate.ReadOnly = true;
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DueDate.Width = 120;
            // 
            // dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DaysDue
            // 
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DaysDue.HeaderText = "Days Due";
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DaysDue.Name = "dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DaysDue";
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DaysDue.ReadOnly = true;
            this.dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DaysDue.Width = 120;
            // 
            // splitContainer_Dashboard_Summary_3
            // 
            this.splitContainer_Dashboard_Summary_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Dashboard_Summary_3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Dashboard_Summary_3.Name = "splitContainer_Dashboard_Summary_3";
            // 
            // splitContainer_Dashboard_Summary_3.Panel1
            // 
            this.splitContainer_Dashboard_Summary_3.Panel1.Controls.Add(this.groupBox10);
            this.splitContainer_Dashboard_Summary_3.Panel1.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer_Dashboard_Summary_3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer_Dashboard_Summary_3.Panel2
            // 
            this.splitContainer_Dashboard_Summary_3.Panel2.Controls.Add(this.groupBox11);
            this.splitContainer_Dashboard_Summary_3.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer_Dashboard_Summary_3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_Dashboard_Summary_3.Size = new System.Drawing.Size(916, 149);
            this.splitContainer_Dashboard_Summary_3.SplitterDistance = 458;
            this.splitContainer_Dashboard_Summary_3.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox_Summary_SystemStatus);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(3, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.groupBox10.Size = new System.Drawing.Size(452, 143);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "System Status";
            // 
            // textBox_Summary_SystemStatus
            // 
            this.textBox_Summary_SystemStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Summary_SystemStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Summary_SystemStatus.Location = new System.Drawing.Point(9, 32);
            this.textBox_Summary_SystemStatus.Multiline = true;
            this.textBox_Summary_SystemStatus.Name = "textBox_Summary_SystemStatus";
            this.textBox_Summary_SystemStatus.ReadOnly = true;
            this.textBox_Summary_SystemStatus.Size = new System.Drawing.Size(434, 99);
            this.textBox_Summary_SystemStatus.TabIndex = 0;
            this.textBox_Summary_SystemStatus.Text = "DAS Invoice AB\r\nVersion: V 1.0.0\r\nLanguage: English\r\nLicense: Active ";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.textBox_Summary_UserStatus);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(3, 3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.groupBox11.Size = new System.Drawing.Size(448, 143);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "User Status";
            // 
            // textBox_Summary_UserStatus
            // 
            this.textBox_Summary_UserStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Summary_UserStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Summary_UserStatus.Location = new System.Drawing.Point(9, 32);
            this.textBox_Summary_UserStatus.Multiline = true;
            this.textBox_Summary_UserStatus.Name = "textBox_Summary_UserStatus";
            this.textBox_Summary_UserStatus.ReadOnly = true;
            this.textBox_Summary_UserStatus.Size = new System.Drawing.Size(430, 99);
            this.textBox_Summary_UserStatus.TabIndex = 1;
            // 
            // tabPage_Dashboard_CreateInvoice
            // 
            this.tabPage_Dashboard_CreateInvoice.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Dashboard_CreateInvoice.Name = "tabPage_Dashboard_CreateInvoice";
            this.tabPage_Dashboard_CreateInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Dashboard_CreateInvoice.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Dashboard_CreateInvoice.TabIndex = 1;
            this.tabPage_Dashboard_CreateInvoice.Text = "Create Invoice";
            // 
            // tabPage_Dashboard_SearchInvoice
            // 
            this.tabPage_Dashboard_SearchInvoice.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Dashboard_SearchInvoice.Name = "tabPage_Dashboard_SearchInvoice";
            this.tabPage_Dashboard_SearchInvoice.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Dashboard_SearchInvoice.TabIndex = 2;
            this.tabPage_Dashboard_SearchInvoice.Text = "Search Invoice";
            // 
            // tabPage_Dashboard_PostPayment
            // 
            this.tabPage_Dashboard_PostPayment.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Dashboard_PostPayment.Name = "tabPage_Dashboard_PostPayment";
            this.tabPage_Dashboard_PostPayment.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Dashboard_PostPayment.TabIndex = 3;
            this.tabPage_Dashboard_PostPayment.Text = "Post a Payment";
            // 
            // tabPage_Dashboard_InvoiceReport
            // 
            this.tabPage_Dashboard_InvoiceReport.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Dashboard_InvoiceReport.Name = "tabPage_Dashboard_InvoiceReport";
            this.tabPage_Dashboard_InvoiceReport.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Dashboard_InvoiceReport.TabIndex = 4;
            this.tabPage_Dashboard_InvoiceReport.Text = "Invoice Report";
            // 
            // tabPage_Dashboard_PaymentReport
            // 
            this.tabPage_Dashboard_PaymentReport.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Dashboard_PaymentReport.Name = "tabPage_Dashboard_PaymentReport";
            this.tabPage_Dashboard_PaymentReport.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Dashboard_PaymentReport.TabIndex = 5;
            this.tabPage_Dashboard_PaymentReport.Text = "Payment Report";
            // 
            // tabPage_Clients
            // 
            this.tabPage_Clients.Controls.Add(this.tabControl_Clients);
            this.tabPage_Clients.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Clients.Name = "tabPage_Clients";
            this.tabPage_Clients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Clients.Size = new System.Drawing.Size(936, 647);
            this.tabPage_Clients.TabIndex = 1;
            this.tabPage_Clients.Text = "Clients";
            // 
            // tabControl_Clients
            // 
            this.tabControl_Clients.Controls.Add(this.tabPage_SearchClients);
            this.tabControl_Clients.Controls.Add(this.tabPage_EditClient);
            this.tabControl_Clients.Controls.Add(this.tabPage_CreateClient);
            this.tabControl_Clients.DisplayStyle = TradeWright.UI.Forms.TabStyle.Angled;
            // 
            // 
            // 
            this.tabControl_Clients.DisplayStyleProvider.BlendStyle = TradeWright.UI.Forms.BlendStyle.Normal;
            this.tabControl_Clients.DisplayStyleProvider.BorderColorDisabled = System.Drawing.SystemColors.ControlLight;
            this.tabControl_Clients.DisplayStyleProvider.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControl_Clients.DisplayStyleProvider.BorderColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Clients.DisplayStyleProvider.BorderColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Clients.DisplayStyleProvider.BorderColorUnselected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Clients.DisplayStyleProvider.CloserButtonFillColorFocused = System.Drawing.Color.Empty;
            this.tabControl_Clients.DisplayStyleProvider.CloserButtonFillColorFocusedActive = System.Drawing.Color.Empty;
            this.tabControl_Clients.DisplayStyleProvider.CloserButtonFillColorHighlighted = System.Drawing.Color.Empty;
            this.tabControl_Clients.DisplayStyleProvider.CloserButtonFillColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabControl_Clients.DisplayStyleProvider.CloserButtonFillColorSelected = System.Drawing.Color.Empty;
            this.tabControl_Clients.DisplayStyleProvider.CloserButtonFillColorSelectedActive = System.Drawing.Color.Empty;
            this.tabControl_Clients.DisplayStyleProvider.CloserButtonFillColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Clients.DisplayStyleProvider.CloserButtonOutlineColorFocused = System.Drawing.Color.Empty;
            this.tabControl_Clients.DisplayStyleProvider.CloserButtonOutlineColorFocusedActive = System.Drawing.Color.Empty;
            this.tabControl_Clients.DisplayStyleProvider.CloserButtonOutlineColorHighlighted = System.Drawing.Color.Empty;
            this.tabControl_Clients.DisplayStyleProvider.CloserButtonOutlineColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabControl_Clients.DisplayStyleProvider.CloserButtonOutlineColorSelected = System.Drawing.Color.Empty;
            this.tabControl_Clients.DisplayStyleProvider.CloserButtonOutlineColorSelectedActive = System.Drawing.Color.Empty;
            this.tabControl_Clients.DisplayStyleProvider.CloserButtonOutlineColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Clients.DisplayStyleProvider.CloserColorFocused = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Clients.DisplayStyleProvider.CloserColorFocusedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Clients.DisplayStyleProvider.CloserColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Clients.DisplayStyleProvider.CloserColorHighlightedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Clients.DisplayStyleProvider.CloserColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Clients.DisplayStyleProvider.CloserColorSelectedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Clients.DisplayStyleProvider.CloserColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Clients.DisplayStyleProvider.FocusTrack = false;
            this.tabControl_Clients.DisplayStyleProvider.HotTrack = true;
            this.tabControl_Clients.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tabControl_Clients.DisplayStyleProvider.Opacity = 1F;
            this.tabControl_Clients.DisplayStyleProvider.Overlap = 8;
            this.tabControl_Clients.DisplayStyleProvider.Padding = new System.Drawing.Point(8, 4);
            this.tabControl_Clients.DisplayStyleProvider.PageBackgroundColorDisabled = System.Drawing.SystemColors.Control;
            this.tabControl_Clients.DisplayStyleProvider.PageBackgroundColorFocused = System.Drawing.SystemColors.ControlLight;
            this.tabControl_Clients.DisplayStyleProvider.PageBackgroundColorHighlighted = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabControl_Clients.DisplayStyleProvider.PageBackgroundColorSelected = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Clients.DisplayStyleProvider.PageBackgroundColorUnselected = System.Drawing.SystemColors.Control;
            this.tabControl_Clients.DisplayStyleProvider.Radius = 12;
            this.tabControl_Clients.DisplayStyleProvider.SelectedTabIsLarger = true;
            this.tabControl_Clients.DisplayStyleProvider.ShowTabCloser = false;
            this.tabControl_Clients.DisplayStyleProvider.TabColorDisabled1 = System.Drawing.SystemColors.Control;
            this.tabControl_Clients.DisplayStyleProvider.TabColorDisabled2 = System.Drawing.SystemColors.Control;
            this.tabControl_Clients.DisplayStyleProvider.TabColorFocused1 = System.Drawing.Color.White;
            this.tabControl_Clients.DisplayStyleProvider.TabColorFocused2 = System.Drawing.Color.White;
            this.tabControl_Clients.DisplayStyleProvider.TabColorHighLighted1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabControl_Clients.DisplayStyleProvider.TabColorHighLighted2 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.tabControl_Clients.DisplayStyleProvider.TabColorSelected1 = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Clients.DisplayStyleProvider.TabColorSelected2 = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Clients.DisplayStyleProvider.TabColorUnSelected1 = System.Drawing.SystemColors.Control;
            this.tabControl_Clients.DisplayStyleProvider.TabColorUnSelected2 = System.Drawing.SystemColors.Control;
            this.tabControl_Clients.DisplayStyleProvider.TabPageMargin = new System.Windows.Forms.Padding(1);
            this.tabControl_Clients.DisplayStyleProvider.TextColorFocused = System.Drawing.SystemColors.ControlText;
            this.tabControl_Clients.DisplayStyleProvider.TextColorHighlighted = System.Drawing.SystemColors.ControlText;
            this.tabControl_Clients.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.tabControl_Clients.DisplayStyleProvider.TextColorUnselected = System.Drawing.SystemColors.ControlDarkDark;
            this.tabControl_Clients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Clients.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Clients.HotTrack = true;
            this.tabControl_Clients.Location = new System.Drawing.Point(3, 3);
            this.tabControl_Clients.Name = "tabControl_Clients";
            this.tabControl_Clients.SelectedIndex = 0;
            this.tabControl_Clients.Size = new System.Drawing.Size(930, 641);
            this.tabControl_Clients.TabIndex = 1;
            // 
            // tabPage_SearchClients
            // 
            this.tabPage_SearchClients.AutoScroll = true;
            this.tabPage_SearchClients.Controls.Add(this.splitContainer_Clients_SearchClients);
            this.tabPage_SearchClients.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_SearchClients.Location = new System.Drawing.Point(4, 28);
            this.tabPage_SearchClients.Name = "tabPage_SearchClients";
            this.tabPage_SearchClients.Size = new System.Drawing.Size(922, 609);
            this.tabPage_SearchClients.TabIndex = 1;
            this.tabPage_SearchClients.Text = "Search Clients";
            // 
            // splitContainer_Clients_SearchClients
            // 
            this.splitContainer_Clients_SearchClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Clients_SearchClients.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_Clients_SearchClients.IsSplitterFixed = true;
            this.splitContainer_Clients_SearchClients.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Clients_SearchClients.Name = "splitContainer_Clients_SearchClients";
            this.splitContainer_Clients_SearchClients.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Clients_SearchClients.Panel1
            // 
            this.splitContainer_Clients_SearchClients.Panel1.AutoScroll = true;
            this.splitContainer_Clients_SearchClients.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer_Clients_SearchClients.Panel1.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer_Clients_SearchClients.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_Clients_SearchClients.Panel1MinSize = 100;
            // 
            // splitContainer_Clients_SearchClients.Panel2
            // 
            this.splitContainer_Clients_SearchClients.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer_Clients_SearchClients.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer_Clients_SearchClients.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_Clients_SearchClients.Size = new System.Drawing.Size(922, 609);
            this.splitContainer_Clients_SearchClients.SplitterDistance = 190;
            this.splitContainer_Clients_SearchClients.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.groupBox1.Size = new System.Drawing.Size(834, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Clients";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label24, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label25, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label26, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label27, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label28, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Clients_SearchClients_ClientName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Clients_SearchClients_ClientID, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Clients_SearchClients_Company, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Clients_SearchClients_Email, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Clients_SearchClients_Country, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Clients_SearchClients_ClientStatus, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_Clients_SearchClients_Search, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 127);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 11);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 19);
            this.label22.TabIndex = 0;
            this.label22.Text = "Client Name";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 71);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 19);
            this.label24.TabIndex = 1;
            this.label24.Text = "Client ID";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(243, 11);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 19);
            this.label25.TabIndex = 2;
            this.label25.Text = "Company";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(243, 71);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 19);
            this.label26.TabIndex = 3;
            this.label26.Text = "Country";
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(483, 11);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 19);
            this.label27.TabIndex = 4;
            this.label27.Text = "Email";
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(483, 71);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(91, 19);
            this.label28.TabIndex = 5;
            this.label28.Text = "Client Status";
            // 
            // textBox_Clients_SearchClients_ClientName
            // 
            this.textBox_Clients_SearchClients_ClientName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Clients_SearchClients_ClientName.Location = new System.Drawing.Point(6, 33);
            this.textBox_Clients_SearchClients_ClientName.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBox_Clients_SearchClients_ClientName.Name = "textBox_Clients_SearchClients_ClientName";
            this.textBox_Clients_SearchClients_ClientName.Size = new System.Drawing.Size(228, 27);
            this.textBox_Clients_SearchClients_ClientName.TabIndex = 6;
            // 
            // textBox_Clients_SearchClients_ClientID
            // 
            this.textBox_Clients_SearchClients_ClientID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Clients_SearchClients_ClientID.Location = new System.Drawing.Point(6, 93);
            this.textBox_Clients_SearchClients_ClientID.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBox_Clients_SearchClients_ClientID.Name = "textBox_Clients_SearchClients_ClientID";
            this.textBox_Clients_SearchClients_ClientID.Size = new System.Drawing.Size(228, 27);
            this.textBox_Clients_SearchClients_ClientID.TabIndex = 7;
            // 
            // textBox_Clients_SearchClients_Company
            // 
            this.textBox_Clients_SearchClients_Company.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Clients_SearchClients_Company.Location = new System.Drawing.Point(246, 33);
            this.textBox_Clients_SearchClients_Company.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBox_Clients_SearchClients_Company.Name = "textBox_Clients_SearchClients_Company";
            this.textBox_Clients_SearchClients_Company.Size = new System.Drawing.Size(228, 27);
            this.textBox_Clients_SearchClients_Company.TabIndex = 8;
            // 
            // textBox_Clients_SearchClients_Email
            // 
            this.textBox_Clients_SearchClients_Email.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Clients_SearchClients_Email.Location = new System.Drawing.Point(486, 33);
            this.textBox_Clients_SearchClients_Email.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBox_Clients_SearchClients_Email.Name = "textBox_Clients_SearchClients_Email";
            this.textBox_Clients_SearchClients_Email.Size = new System.Drawing.Size(228, 27);
            this.textBox_Clients_SearchClients_Email.TabIndex = 10;
            // 
            // comboBox_Clients_SearchClients_Country
            // 
            this.comboBox_Clients_SearchClients_Country.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_Clients_SearchClients_Country.FormattingEnabled = true;
            this.comboBox_Clients_SearchClients_Country.Location = new System.Drawing.Point(246, 93);
            this.comboBox_Clients_SearchClients_Country.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.comboBox_Clients_SearchClients_Country.Name = "comboBox_Clients_SearchClients_Country";
            this.comboBox_Clients_SearchClients_Country.Size = new System.Drawing.Size(228, 27);
            this.comboBox_Clients_SearchClients_Country.TabIndex = 11;
            // 
            // comboBox_Clients_SearchClients_ClientStatus
            // 
            this.comboBox_Clients_SearchClients_ClientStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_Clients_SearchClients_ClientStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Clients_SearchClients_ClientStatus.FormattingEnabled = true;
            this.comboBox_Clients_SearchClients_ClientStatus.Location = new System.Drawing.Point(486, 93);
            this.comboBox_Clients_SearchClients_ClientStatus.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.comboBox_Clients_SearchClients_ClientStatus.Name = "comboBox_Clients_SearchClients_ClientStatus";
            this.comboBox_Clients_SearchClients_ClientStatus.Size = new System.Drawing.Size(228, 27);
            this.comboBox_Clients_SearchClients_ClientStatus.TabIndex = 12;
            // 
            // button_Clients_SearchClients_Search
            // 
            this.button_Clients_SearchClients_Search.Location = new System.Drawing.Point(723, 32);
            this.button_Clients_SearchClients_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.button_Clients_SearchClients_Search.Name = "button_Clients_SearchClients_Search";
            this.button_Clients_SearchClients_Search.Size = new System.Drawing.Size(80, 28);
            this.button_Clients_SearchClients_Search.TabIndex = 13;
            this.button_Clients_SearchClients_Search.Text = "Search";
            this.button_Clients_SearchClients_Search.UseVisualStyleBackColor = true;
            this.button_Clients_SearchClients_Search.Click += new System.EventHandler(this.button_SearchClients_Search_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer_Clients_SearchClients_Clients);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(9, 0, 9, 9);
            this.groupBox2.Size = new System.Drawing.Size(910, 403);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clients";
            // 
            // splitContainer_Clients_SearchClients_Clients
            // 
            this.splitContainer_Clients_SearchClients_Clients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Clients_SearchClients_Clients.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_Clients_SearchClients_Clients.IsSplitterFixed = true;
            this.splitContainer_Clients_SearchClients_Clients.Location = new System.Drawing.Point(9, 20);
            this.splitContainer_Clients_SearchClients_Clients.Name = "splitContainer_Clients_SearchClients_Clients";
            this.splitContainer_Clients_SearchClients_Clients.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Clients_SearchClients_Clients.Panel1
            // 
            this.splitContainer_Clients_SearchClients_Clients.Panel1.Controls.Add(this.label_Clients_SearchClients_Result);
            this.splitContainer_Clients_SearchClients_Clients.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer_Clients_SearchClients_Clients.Panel2
            // 
            this.splitContainer_Clients_SearchClients_Clients.Panel2.Controls.Add(this.dataGridView_SearchClient);
            this.splitContainer_Clients_SearchClients_Clients.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer_Clients_SearchClients_Clients.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_Clients_SearchClients_Clients.Size = new System.Drawing.Size(892, 374);
            this.splitContainer_Clients_SearchClients_Clients.SplitterDistance = 25;
            this.splitContainer_Clients_SearchClients_Clients.TabIndex = 0;
            // 
            // label_Clients_SearchClients_Result
            // 
            this.label_Clients_SearchClients_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Clients_SearchClients_Result.AutoSize = true;
            this.label_Clients_SearchClients_Result.Location = new System.Drawing.Point(3, 6);
            this.label_Clients_SearchClients_Result.Name = "label_Clients_SearchClients_Result";
            this.label_Clients_SearchClients_Result.Size = new System.Drawing.Size(73, 19);
            this.label_Clients_SearchClients_Result.TabIndex = 0;
            this.label_Clients_SearchClients_Result.Text = "[0] Client.";
            // 
            // dataGridView_SearchClient
            // 
            this.dataGridView_SearchClient.AllowUserToAddRows = false;
            this.dataGridView_SearchClient.AllowUserToDeleteRows = false;
            this.dataGridView_SearchClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SearchClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_Clients_ClientID,
            this.column_Clients_Name,
            this.column_Clients_Company,
            this.column_Clients_Created,
            this.column_Clients_Status,
            this.column_Clients_View,
            this.column_Clients_Edit,
            this.column_Clients_Delete});
            this.dataGridView_SearchClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_SearchClient.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_SearchClient.Name = "dataGridView_SearchClient";
            this.dataGridView_SearchClient.ReadOnly = true;
            this.dataGridView_SearchClient.RowHeadersVisible = false;
            this.dataGridView_SearchClient.Size = new System.Drawing.Size(880, 333);
            this.dataGridView_SearchClient.TabIndex = 0;
            this.dataGridView_SearchClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SearchClient_CellClick);
            // 
            // column_Clients_ClientID
            // 
            this.column_Clients_ClientID.HeaderText = "Client ID";
            this.column_Clients_ClientID.Name = "column_Clients_ClientID";
            this.column_Clients_ClientID.ReadOnly = true;
            this.column_Clients_ClientID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.column_Clients_ClientID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // column_Clients_Name
            // 
            this.column_Clients_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_Clients_Name.HeaderText = "Company Representative";
            this.column_Clients_Name.Name = "column_Clients_Name";
            this.column_Clients_Name.ReadOnly = true;
            // 
            // column_Clients_Company
            // 
            this.column_Clients_Company.HeaderText = "Company";
            this.column_Clients_Company.Name = "column_Clients_Company";
            this.column_Clients_Company.ReadOnly = true;
            this.column_Clients_Company.Width = 180;
            // 
            // column_Clients_Created
            // 
            this.column_Clients_Created.HeaderText = "Created";
            this.column_Clients_Created.Name = "column_Clients_Created";
            this.column_Clients_Created.ReadOnly = true;
            // 
            // column_Clients_Status
            // 
            this.column_Clients_Status.HeaderText = "Status";
            this.column_Clients_Status.Name = "column_Clients_Status";
            this.column_Clients_Status.ReadOnly = true;
            // 
            // column_Clients_View
            // 
            this.column_Clients_View.HeaderText = "";
            this.column_Clients_View.Name = "column_Clients_View";
            this.column_Clients_View.ReadOnly = true;
            this.column_Clients_View.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.column_Clients_View.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.column_Clients_View.Width = 50;
            // 
            // column_Clients_Edit
            // 
            this.column_Clients_Edit.HeaderText = "";
            this.column_Clients_Edit.Name = "column_Clients_Edit";
            this.column_Clients_Edit.ReadOnly = true;
            this.column_Clients_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.column_Clients_Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.column_Clients_Edit.Width = 50;
            // 
            // column_Clients_Delete
            // 
            this.column_Clients_Delete.HeaderText = "";
            this.column_Clients_Delete.Name = "column_Clients_Delete";
            this.column_Clients_Delete.ReadOnly = true;
            this.column_Clients_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.column_Clients_Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.column_Clients_Delete.Width = 60;
            // 
            // tabPage_EditClient
            // 
            this.tabPage_EditClient.Controls.Add(this.groupBox_EditClient);
            this.tabPage_EditClient.Location = new System.Drawing.Point(4, 28);
            this.tabPage_EditClient.Name = "tabPage_EditClient";
            this.tabPage_EditClient.Size = new System.Drawing.Size(922, 609);
            this.tabPage_EditClient.TabIndex = 3;
            this.tabPage_EditClient.Text = "Edit Client";
            // 
            // groupBox_EditClient
            // 
            this.groupBox_EditClient.Controls.Add(this.groupBox36);
            this.groupBox_EditClient.Controls.Add(this.tableLayoutPanel15);
            this.groupBox_EditClient.Location = new System.Drawing.Point(6, 6);
            this.groupBox_EditClient.Name = "groupBox_EditClient";
            this.groupBox_EditClient.Size = new System.Drawing.Size(817, 553);
            this.groupBox_EditClient.TabIndex = 1;
            this.groupBox_EditClient.TabStop = false;
            this.groupBox_EditClient.Text = "Edit Client";
            // 
            // groupBox36
            // 
            this.groupBox36.Controls.Add(this.label66);
            this.groupBox36.Controls.Add(this.button_EditClient_Save);
            this.groupBox36.Controls.Add(this.textBox_EditClient_Notes);
            this.groupBox36.Controls.Add(this.label94);
            this.groupBox36.Controls.Add(this.tableLayoutPanel14);
            this.groupBox36.Location = new System.Drawing.Point(405, 26);
            this.groupBox36.Name = "groupBox36";
            this.groupBox36.Size = new System.Drawing.Size(404, 520);
            this.groupBox36.TabIndex = 2;
            this.groupBox36.TabStop = false;
            this.groupBox36.Text = "Client Settings";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(128, 570);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(128, 13);
            this.label66.TabIndex = 6;
            this.label66.Text = "Client saved successfully!";
            // 
            // button_EditClient_Save
            // 
            this.button_EditClient_Save.Location = new System.Drawing.Point(12, 480);
            this.button_EditClient_Save.Name = "button_EditClient_Save";
            this.button_EditClient_Save.Size = new System.Drawing.Size(99, 28);
            this.button_EditClient_Save.TabIndex = 5;
            this.button_EditClient_Save.Text = "Save";
            this.button_EditClient_Save.UseVisualStyleBackColor = true;
            this.button_EditClient_Save.Click += new System.EventHandler(this.button_EditClient_Save_Click);
            // 
            // textBox_EditClient_Notes
            // 
            this.textBox_EditClient_Notes.Location = new System.Drawing.Point(13, 354);
            this.textBox_EditClient_Notes.Multiline = true;
            this.textBox_EditClient_Notes.Name = "textBox_EditClient_Notes";
            this.textBox_EditClient_Notes.Size = new System.Drawing.Size(383, 116);
            this.textBox_EditClient_Notes.TabIndex = 4;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(9, 409);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(149, 13);
            this.label94.TabIndex = 3;
            this.label94.Text = "Notes (not shown in invoices):";
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.38462F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.61539F));
            this.tableLayoutPanel14.Controls.Add(this.label95, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.label96, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.label97, 0, 2);
            this.tableLayoutPanel14.Controls.Add(this.label98, 0, 4);
            this.tableLayoutPanel14.Controls.Add(this.label99, 0, 3);
            this.tableLayoutPanel14.Controls.Add(this.label101, 0, 5);
            this.tableLayoutPanel14.Controls.Add(this.label102, 0, 6);
            this.tableLayoutPanel14.Controls.Add(this.comboBox_EditClient_ClientStatus, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.comboBox_EditClient_InvoiceTemplate, 1, 3);
            this.tableLayoutPanel14.Controls.Add(this.comboBox_EditClient_Currency, 1, 6);
            this.tableLayoutPanel14.Controls.Add(this.flowLayoutPanel12, 1, 4);
            this.tableLayoutPanel14.Controls.Add(this.flowLayoutPanel13, 1, 5);
            this.tableLayoutPanel14.Controls.Add(this.textBox_EditClient_ClientID, 1, 1);
            this.tableLayoutPanel14.Controls.Add(this.textBox_EditClient_InvoiceIDAssign, 1, 2);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(6, 27);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 3;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(390, 282);
            this.tableLayoutPanel14.TabIndex = 2;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(3, 46);
            this.label95.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(54, 13);
            this.label95.TabIndex = 2;
            this.label95.Text = "Client ID *";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(3, 6);
            this.label96.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(73, 13);
            this.label96.TabIndex = 0;
            this.label96.Text = "Client Status *";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(3, 86);
            this.label97.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(63, 13);
            this.label97.TabIndex = 4;
            this.label97.Text = "Invoice ID *";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(3, 166);
            this.label98.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(87, 13);
            this.label98.TabIndex = 6;
            this.label98.Text = "VAT Applicable *";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(3, 126);
            this.label99.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(96, 13);
            this.label99.TabIndex = 5;
            this.label99.Text = "Invoice Template *";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(3, 206);
            this.label101.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(39, 13);
            this.label101.TabIndex = 7;
            this.label101.Text = "VAT %";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(3, 246);
            this.label102.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(56, 13);
            this.label102.TabIndex = 8;
            this.label102.Text = "Currency *";
            // 
            // comboBox_EditClient_ClientStatus
            // 
            this.comboBox_EditClient_ClientStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_EditClient_ClientStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EditClient_ClientStatus.FormattingEnabled = true;
            this.comboBox_EditClient_ClientStatus.Location = new System.Drawing.Point(141, 3);
            this.comboBox_EditClient_ClientStatus.Name = "comboBox_EditClient_ClientStatus";
            this.comboBox_EditClient_ClientStatus.Size = new System.Drawing.Size(246, 21);
            this.comboBox_EditClient_ClientStatus.TabIndex = 19;
            // 
            // comboBox_EditClient_InvoiceTemplate
            // 
            this.comboBox_EditClient_InvoiceTemplate.DisplayMember = "Default Template";
            this.comboBox_EditClient_InvoiceTemplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_EditClient_InvoiceTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EditClient_InvoiceTemplate.FormattingEnabled = true;
            this.comboBox_EditClient_InvoiceTemplate.Items.AddRange(new object[] {
            "Default Template"});
            this.comboBox_EditClient_InvoiceTemplate.Location = new System.Drawing.Point(141, 123);
            this.comboBox_EditClient_InvoiceTemplate.Name = "comboBox_EditClient_InvoiceTemplate";
            this.comboBox_EditClient_InvoiceTemplate.Size = new System.Drawing.Size(246, 21);
            this.comboBox_EditClient_InvoiceTemplate.TabIndex = 22;
            // 
            // comboBox_EditClient_Currency
            // 
            this.comboBox_EditClient_Currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EditClient_Currency.FormattingEnabled = true;
            this.comboBox_EditClient_Currency.Location = new System.Drawing.Point(141, 243);
            this.comboBox_EditClient_Currency.Name = "comboBox_EditClient_Currency";
            this.comboBox_EditClient_Currency.Size = new System.Drawing.Size(92, 21);
            this.comboBox_EditClient_Currency.TabIndex = 23;
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.Controls.Add(this.radioButton_EditClient_VATApplicable_Yes);
            this.flowLayoutPanel12.Controls.Add(this.radioButton_EditClient_VATApplicable_No);
            this.flowLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel12.Location = new System.Drawing.Point(141, 163);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(246, 34);
            this.flowLayoutPanel12.TabIndex = 24;
            // 
            // radioButton_EditClient_VATApplicable_Yes
            // 
            this.radioButton_EditClient_VATApplicable_Yes.AutoSize = true;
            this.radioButton_EditClient_VATApplicable_Yes.Location = new System.Drawing.Point(6, 3);
            this.radioButton_EditClient_VATApplicable_Yes.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButton_EditClient_VATApplicable_Yes.Name = "radioButton_EditClient_VATApplicable_Yes";
            this.radioButton_EditClient_VATApplicable_Yes.Size = new System.Drawing.Size(49, 23);
            this.radioButton_EditClient_VATApplicable_Yes.TabIndex = 0;
            this.radioButton_EditClient_VATApplicable_Yes.Text = "Yes";
            this.radioButton_EditClient_VATApplicable_Yes.UseVisualStyleBackColor = true;
            // 
            // radioButton_EditClient_VATApplicable_No
            // 
            this.radioButton_EditClient_VATApplicable_No.AutoSize = true;
            this.radioButton_EditClient_VATApplicable_No.Checked = true;
            this.radioButton_EditClient_VATApplicable_No.Location = new System.Drawing.Point(64, 3);
            this.radioButton_EditClient_VATApplicable_No.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButton_EditClient_VATApplicable_No.Name = "radioButton_EditClient_VATApplicable_No";
            this.radioButton_EditClient_VATApplicable_No.Size = new System.Drawing.Size(45, 23);
            this.radioButton_EditClient_VATApplicable_No.TabIndex = 1;
            this.radioButton_EditClient_VATApplicable_No.TabStop = true;
            this.radioButton_EditClient_VATApplicable_No.Text = "No";
            this.radioButton_EditClient_VATApplicable_No.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel13
            // 
            this.flowLayoutPanel13.Controls.Add(this.numericUpDown_EditClient_VATPercent);
            this.flowLayoutPanel13.Controls.Add(this.label103);
            this.flowLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel13.Location = new System.Drawing.Point(141, 203);
            this.flowLayoutPanel13.Name = "flowLayoutPanel13";
            this.flowLayoutPanel13.Size = new System.Drawing.Size(246, 34);
            this.flowLayoutPanel13.TabIndex = 25;
            // 
            // numericUpDown_EditClient_VATPercent
            // 
            this.numericUpDown_EditClient_VATPercent.Enabled = false;
            this.numericUpDown_EditClient_VATPercent.Location = new System.Drawing.Point(3, 3);
            this.numericUpDown_EditClient_VATPercent.Name = "numericUpDown_EditClient_VATPercent";
            this.numericUpDown_EditClient_VATPercent.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown_EditClient_VATPercent.TabIndex = 0;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(72, 6);
            this.label103.Margin = new System.Windows.Forms.Padding(0, 6, 3, 0);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(15, 13);
            this.label103.TabIndex = 1;
            this.label103.Text = "%";
            // 
            // textBox_EditClient_ClientID
            // 
            this.textBox_EditClient_ClientID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_EditClient_ClientID.Location = new System.Drawing.Point(141, 43);
            this.textBox_EditClient_ClientID.Name = "textBox_EditClient_ClientID";
            this.textBox_EditClient_ClientID.ReadOnly = true;
            this.textBox_EditClient_ClientID.Size = new System.Drawing.Size(246, 20);
            this.textBox_EditClient_ClientID.TabIndex = 26;
            // 
            // textBox_EditClient_InvoiceIDAssign
            // 
            this.textBox_EditClient_InvoiceIDAssign.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_EditClient_InvoiceIDAssign.Location = new System.Drawing.Point(141, 83);
            this.textBox_EditClient_InvoiceIDAssign.Name = "textBox_EditClient_InvoiceIDAssign";
            this.textBox_EditClient_InvoiceIDAssign.ReadOnly = true;
            this.textBox_EditClient_InvoiceIDAssign.Size = new System.Drawing.Size(246, 20);
            this.textBox_EditClient_InvoiceIDAssign.TabIndex = 27;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 2;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.61111F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.38889F));
            this.tableLayoutPanel15.Controls.Add(this.textBox_EditClient_LastName, 1, 1);
            this.tableLayoutPanel15.Controls.Add(this.label104, 0, 1);
            this.tableLayoutPanel15.Controls.Add(this.label105, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.textBox_EditClient_FirstName, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.label106, 0, 2);
            this.tableLayoutPanel15.Controls.Add(this.label107, 0, 4);
            this.tableLayoutPanel15.Controls.Add(this.label108, 0, 3);
            this.tableLayoutPanel15.Controls.Add(this.label109, 0, 5);
            this.tableLayoutPanel15.Controls.Add(this.label110, 0, 6);
            this.tableLayoutPanel15.Controls.Add(this.label111, 0, 7);
            this.tableLayoutPanel15.Controls.Add(this.label112, 0, 8);
            this.tableLayoutPanel15.Controls.Add(this.label113, 0, 9);
            this.tableLayoutPanel15.Controls.Add(this.label114, 0, 10);
            this.tableLayoutPanel15.Controls.Add(this.label115, 0, 11);
            this.tableLayoutPanel15.Controls.Add(this.label116, 0, 12);
            this.tableLayoutPanel15.Controls.Add(this.textBox_EditClient_Company, 1, 2);
            this.tableLayoutPanel15.Controls.Add(this.textBox_EditClient_TIN, 1, 3);
            this.tableLayoutPanel15.Controls.Add(this.textBox_EditClient_VAT, 1, 4);
            this.tableLayoutPanel15.Controls.Add(this.textBox_EditClient_Phone, 1, 5);
            this.tableLayoutPanel15.Controls.Add(this.textBox_EditClient_Email, 1, 6);
            this.tableLayoutPanel15.Controls.Add(this.textBox_EditClient_Address1, 1, 7);
            this.tableLayoutPanel15.Controls.Add(this.textBox_EditClient_Address2, 1, 8);
            this.tableLayoutPanel15.Controls.Add(this.textBox_EditClient_City, 1, 9);
            this.tableLayoutPanel15.Controls.Add(this.textBox_EditClient_State, 1, 10);
            this.tableLayoutPanel15.Controls.Add(this.textBox_EditClient_PostalCode, 1, 11);
            this.tableLayoutPanel15.Controls.Add(this.comboBox_EditClient_Country, 1, 12);
            this.tableLayoutPanel15.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 13;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(360, 520);
            this.tableLayoutPanel15.TabIndex = 1;
            // 
            // textBox_EditClient_LastName
            // 
            this.textBox_EditClient_LastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_EditClient_LastName.Location = new System.Drawing.Point(105, 43);
            this.textBox_EditClient_LastName.Name = "textBox_EditClient_LastName";
            this.textBox_EditClient_LastName.Size = new System.Drawing.Size(252, 20);
            this.textBox_EditClient_LastName.TabIndex = 3;
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(3, 46);
            this.label104.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(65, 13);
            this.label104.TabIndex = 2;
            this.label104.Text = "Last Name *";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(3, 6);
            this.label105.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(64, 13);
            this.label105.TabIndex = 0;
            this.label105.Text = "First Name *";
            // 
            // textBox_EditClient_FirstName
            // 
            this.textBox_EditClient_FirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_EditClient_FirstName.Location = new System.Drawing.Point(105, 3);
            this.textBox_EditClient_FirstName.Name = "textBox_EditClient_FirstName";
            this.textBox_EditClient_FirstName.Size = new System.Drawing.Size(252, 20);
            this.textBox_EditClient_FirstName.TabIndex = 1;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(3, 86);
            this.label106.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(58, 13);
            this.label106.TabIndex = 4;
            this.label106.Text = "Company *";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(3, 166);
            this.label107.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(38, 13);
            this.label107.TabIndex = 6;
            this.label107.Text = "VAT #";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(3, 126);
            this.label108.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(35, 13);
            this.label108.TabIndex = 5;
            this.label108.Text = "TIN #";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(3, 206);
            this.label109.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(48, 13);
            this.label109.TabIndex = 7;
            this.label109.Text = "Phone #";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(3, 246);
            this.label110.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(32, 13);
            this.label110.TabIndex = 8;
            this.label110.Text = "Email";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(3, 286);
            this.label111.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(54, 13);
            this.label111.TabIndex = 9;
            this.label111.Text = "Address 1";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(3, 326);
            this.label112.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(54, 13);
            this.label112.TabIndex = 10;
            this.label112.Text = "Address 2";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(3, 366);
            this.label113.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(24, 13);
            this.label113.TabIndex = 11;
            this.label113.Text = "City";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(3, 406);
            this.label114.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(32, 13);
            this.label114.TabIndex = 12;
            this.label114.Text = "State";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(3, 446);
            this.label115.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(64, 13);
            this.label115.TabIndex = 13;
            this.label115.Text = "Postal Code";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(3, 486);
            this.label116.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(50, 13);
            this.label116.TabIndex = 14;
            this.label116.Text = "Country *";
            // 
            // textBox_EditClient_Company
            // 
            this.textBox_EditClient_Company.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_EditClient_Company.Location = new System.Drawing.Point(105, 83);
            this.textBox_EditClient_Company.Name = "textBox_EditClient_Company";
            this.textBox_EditClient_Company.Size = new System.Drawing.Size(252, 20);
            this.textBox_EditClient_Company.TabIndex = 15;
            // 
            // textBox_EditClient_TIN
            // 
            this.textBox_EditClient_TIN.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_EditClient_TIN.Location = new System.Drawing.Point(105, 123);
            this.textBox_EditClient_TIN.Name = "textBox_EditClient_TIN";
            this.textBox_EditClient_TIN.Size = new System.Drawing.Size(252, 20);
            this.textBox_EditClient_TIN.TabIndex = 16;
            // 
            // textBox_EditClient_VAT
            // 
            this.textBox_EditClient_VAT.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_EditClient_VAT.Location = new System.Drawing.Point(105, 163);
            this.textBox_EditClient_VAT.Name = "textBox_EditClient_VAT";
            this.textBox_EditClient_VAT.Size = new System.Drawing.Size(252, 20);
            this.textBox_EditClient_VAT.TabIndex = 17;
            // 
            // textBox_EditClient_Phone
            // 
            this.textBox_EditClient_Phone.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_EditClient_Phone.Location = new System.Drawing.Point(105, 203);
            this.textBox_EditClient_Phone.Name = "textBox_EditClient_Phone";
            this.textBox_EditClient_Phone.Size = new System.Drawing.Size(252, 20);
            this.textBox_EditClient_Phone.TabIndex = 18;
            // 
            // textBox_EditClient_Email
            // 
            this.textBox_EditClient_Email.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_EditClient_Email.Location = new System.Drawing.Point(105, 243);
            this.textBox_EditClient_Email.Name = "textBox_EditClient_Email";
            this.textBox_EditClient_Email.Size = new System.Drawing.Size(252, 20);
            this.textBox_EditClient_Email.TabIndex = 19;
            // 
            // textBox_EditClient_Address1
            // 
            this.textBox_EditClient_Address1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_EditClient_Address1.Location = new System.Drawing.Point(105, 283);
            this.textBox_EditClient_Address1.Name = "textBox_EditClient_Address1";
            this.textBox_EditClient_Address1.Size = new System.Drawing.Size(252, 20);
            this.textBox_EditClient_Address1.TabIndex = 20;
            // 
            // textBox_EditClient_Address2
            // 
            this.textBox_EditClient_Address2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_EditClient_Address2.Location = new System.Drawing.Point(105, 323);
            this.textBox_EditClient_Address2.Name = "textBox_EditClient_Address2";
            this.textBox_EditClient_Address2.Size = new System.Drawing.Size(252, 20);
            this.textBox_EditClient_Address2.TabIndex = 21;
            // 
            // textBox_EditClient_City
            // 
            this.textBox_EditClient_City.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_EditClient_City.Location = new System.Drawing.Point(105, 363);
            this.textBox_EditClient_City.Name = "textBox_EditClient_City";
            this.textBox_EditClient_City.Size = new System.Drawing.Size(252, 20);
            this.textBox_EditClient_City.TabIndex = 22;
            // 
            // textBox_EditClient_State
            // 
            this.textBox_EditClient_State.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_EditClient_State.Location = new System.Drawing.Point(105, 403);
            this.textBox_EditClient_State.Name = "textBox_EditClient_State";
            this.textBox_EditClient_State.Size = new System.Drawing.Size(252, 20);
            this.textBox_EditClient_State.TabIndex = 23;
            // 
            // textBox_EditClient_PostalCode
            // 
            this.textBox_EditClient_PostalCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_EditClient_PostalCode.Location = new System.Drawing.Point(105, 443);
            this.textBox_EditClient_PostalCode.Name = "textBox_EditClient_PostalCode";
            this.textBox_EditClient_PostalCode.Size = new System.Drawing.Size(252, 20);
            this.textBox_EditClient_PostalCode.TabIndex = 24;
            // 
            // comboBox_EditClient_Country
            // 
            this.comboBox_EditClient_Country.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_EditClient_Country.FormattingEnabled = true;
            this.comboBox_EditClient_Country.Location = new System.Drawing.Point(105, 483);
            this.comboBox_EditClient_Country.Name = "comboBox_EditClient_Country";
            this.comboBox_EditClient_Country.Size = new System.Drawing.Size(252, 21);
            this.comboBox_EditClient_Country.TabIndex = 25;
            // 
            // tabPage_CreateClient
            // 
            this.tabPage_CreateClient.AutoScroll = true;
            this.tabPage_CreateClient.Controls.Add(this.groupBox_CreateClient_createClient);
            this.tabPage_CreateClient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_CreateClient.Location = new System.Drawing.Point(4, 28);
            this.tabPage_CreateClient.Name = "tabPage_CreateClient";
            this.tabPage_CreateClient.Size = new System.Drawing.Size(922, 609);
            this.tabPage_CreateClient.TabIndex = 2;
            this.tabPage_CreateClient.Text = "Create Client";
            // 
            // groupBox_CreateClient_createClient
            // 
            this.groupBox_CreateClient_createClient.Controls.Add(this.groupBox_CreateClient_ClientSettings);
            this.groupBox_CreateClient_createClient.Controls.Add(this.tableLayoutPanel_Clients_CreateClient);
            this.groupBox_CreateClient_createClient.Location = new System.Drawing.Point(6, 6);
            this.groupBox_CreateClient_createClient.Name = "groupBox_CreateClient_createClient";
            this.groupBox_CreateClient_createClient.Size = new System.Drawing.Size(817, 553);
            this.groupBox_CreateClient_createClient.TabIndex = 0;
            this.groupBox_CreateClient_createClient.TabStop = false;
            this.groupBox_CreateClient_createClient.Text = "Create Client";
            // 
            // groupBox_CreateClient_ClientSettings
            // 
            this.groupBox_CreateClient_ClientSettings.Controls.Add(this.label_CreateClient_Message);
            this.groupBox_CreateClient_ClientSettings.Controls.Add(this.button_CreateClient_Save);
            this.groupBox_CreateClient_ClientSettings.Controls.Add(this.textBox_CreateClient_Notes);
            this.groupBox_CreateClient_ClientSettings.Controls.Add(this.label21);
            this.groupBox_CreateClient_ClientSettings.Controls.Add(this.tableLayoutPanel_CreateClient_ClientSettings);
            this.groupBox_CreateClient_ClientSettings.Location = new System.Drawing.Point(405, 26);
            this.groupBox_CreateClient_ClientSettings.Name = "groupBox_CreateClient_ClientSettings";
            this.groupBox_CreateClient_ClientSettings.Size = new System.Drawing.Size(404, 520);
            this.groupBox_CreateClient_ClientSettings.TabIndex = 2;
            this.groupBox_CreateClient_ClientSettings.TabStop = false;
            this.groupBox_CreateClient_ClientSettings.Text = "Client Settings";
            // 
            // label_CreateClient_Message
            // 
            this.label_CreateClient_Message.AutoSize = true;
            this.label_CreateClient_Message.Location = new System.Drawing.Point(117, 485);
            this.label_CreateClient_Message.Name = "label_CreateClient_Message";
            this.label_CreateClient_Message.Size = new System.Drawing.Size(177, 19);
            this.label_CreateClient_Message.TabIndex = 6;
            this.label_CreateClient_Message.Text = "Client saved successfully!";
            // 
            // button_CreateClient_Save
            // 
            this.button_CreateClient_Save.Location = new System.Drawing.Point(12, 480);
            this.button_CreateClient_Save.Name = "button_CreateClient_Save";
            this.button_CreateClient_Save.Size = new System.Drawing.Size(99, 28);
            this.button_CreateClient_Save.TabIndex = 5;
            this.button_CreateClient_Save.Text = "Save";
            this.button_CreateClient_Save.UseVisualStyleBackColor = true;
            this.button_CreateClient_Save.Click += new System.EventHandler(this.button_CreateClient_Save_Click);
            // 
            // textBox_CreateClient_Notes
            // 
            this.textBox_CreateClient_Notes.Location = new System.Drawing.Point(13, 354);
            this.textBox_CreateClient_Notes.Multiline = true;
            this.textBox_CreateClient_Notes.Name = "textBox_CreateClient_Notes";
            this.textBox_CreateClient_Notes.Size = new System.Drawing.Size(383, 116);
            this.textBox_CreateClient_Notes.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 409);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(205, 19);
            this.label21.TabIndex = 3;
            this.label21.Text = "Notes (not shown in invoices):";
            // 
            // tableLayoutPanel_CreateClient_ClientSettings
            // 
            this.tableLayoutPanel_CreateClient_ClientSettings.ColumnCount = 2;
            this.tableLayoutPanel_CreateClient_ClientSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.38462F));
            this.tableLayoutPanel_CreateClient_ClientSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.61539F));
            this.tableLayoutPanel_CreateClient_ClientSettings.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel_CreateClient_ClientSettings.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel_CreateClient_ClientSettings.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel_CreateClient_ClientSettings.Controls.Add(this.label17, 0, 4);
            this.tableLayoutPanel_CreateClient_ClientSettings.Controls.Add(this.label18, 0, 3);
            this.tableLayoutPanel_CreateClient_ClientSettings.Controls.Add(this.label19, 0, 5);
            this.tableLayoutPanel_CreateClient_ClientSettings.Controls.Add(this.label20, 0, 6);
            this.tableLayoutPanel_CreateClient_ClientSettings.Controls.Add(this.comboBox_CreateClient_ClientStatus, 1, 0);
            this.tableLayoutPanel_CreateClient_ClientSettings.Controls.Add(this.comboBox_CreateClient_ClientIDAssign, 1, 1);
            this.tableLayoutPanel_CreateClient_ClientSettings.Controls.Add(this.comboBox_CreateClient_InvoiceIDAssign, 1, 2);
            this.tableLayoutPanel_CreateClient_ClientSettings.Controls.Add(this.comboBox_CreateClient_InvoiceTemplate, 1, 3);
            this.tableLayoutPanel_CreateClient_ClientSettings.Controls.Add(this.comboBox_CreateClient_Currency, 1, 6);
            this.tableLayoutPanel_CreateClient_ClientSettings.Controls.Add(this.flowLayoutPanel1, 1, 4);
            this.tableLayoutPanel_CreateClient_ClientSettings.Controls.Add(this.flowLayoutPanel2, 1, 5);
            this.tableLayoutPanel_CreateClient_ClientSettings.Location = new System.Drawing.Point(6, 27);
            this.tableLayoutPanel_CreateClient_ClientSettings.Name = "tableLayoutPanel_CreateClient_ClientSettings";
            this.tableLayoutPanel_CreateClient_ClientSettings.RowCount = 3;
            this.tableLayoutPanel_CreateClient_ClientSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_CreateClient_ClientSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_CreateClient_ClientSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_CreateClient_ClientSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_CreateClient_ClientSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_CreateClient_ClientSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_CreateClient_ClientSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_CreateClient_ClientSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_CreateClient_ClientSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_CreateClient_ClientSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_CreateClient_ClientSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_CreateClient_ClientSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_CreateClient_ClientSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_CreateClient_ClientSettings.Size = new System.Drawing.Size(390, 282);
            this.tableLayoutPanel_CreateClient_ClientSettings.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 46);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 19);
            this.label14.TabIndex = 2;
            this.label14.Text = "Client ID *";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 6);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Client Status *";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 86);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 19);
            this.label16.TabIndex = 4;
            this.label16.Text = "Invoice ID *";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 166);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 19);
            this.label17.TabIndex = 6;
            this.label17.Text = "VAT Applicable *";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 126);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 19);
            this.label18.TabIndex = 5;
            this.label18.Text = "Invoice Template *";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 206);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 19);
            this.label19.TabIndex = 7;
            this.label19.Text = "VAT %";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 246);
            this.label20.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 19);
            this.label20.TabIndex = 8;
            this.label20.Text = "Currency *";
            // 
            // comboBox_CreateClient_ClientStatus
            // 
            this.comboBox_CreateClient_ClientStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_CreateClient_ClientStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CreateClient_ClientStatus.FormattingEnabled = true;
            this.comboBox_CreateClient_ClientStatus.Location = new System.Drawing.Point(141, 3);
            this.comboBox_CreateClient_ClientStatus.Name = "comboBox_CreateClient_ClientStatus";
            this.comboBox_CreateClient_ClientStatus.Size = new System.Drawing.Size(246, 27);
            this.comboBox_CreateClient_ClientStatus.TabIndex = 19;
            // 
            // comboBox_CreateClient_ClientIDAssign
            // 
            this.comboBox_CreateClient_ClientIDAssign.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_CreateClient_ClientIDAssign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CreateClient_ClientIDAssign.FormattingEnabled = true;
            this.comboBox_CreateClient_ClientIDAssign.Location = new System.Drawing.Point(141, 43);
            this.comboBox_CreateClient_ClientIDAssign.Name = "comboBox_CreateClient_ClientIDAssign";
            this.comboBox_CreateClient_ClientIDAssign.Size = new System.Drawing.Size(246, 27);
            this.comboBox_CreateClient_ClientIDAssign.TabIndex = 20;
            // 
            // comboBox_CreateClient_InvoiceIDAssign
            // 
            this.comboBox_CreateClient_InvoiceIDAssign.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_CreateClient_InvoiceIDAssign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CreateClient_InvoiceIDAssign.FormattingEnabled = true;
            this.comboBox_CreateClient_InvoiceIDAssign.Location = new System.Drawing.Point(141, 83);
            this.comboBox_CreateClient_InvoiceIDAssign.Name = "comboBox_CreateClient_InvoiceIDAssign";
            this.comboBox_CreateClient_InvoiceIDAssign.Size = new System.Drawing.Size(246, 27);
            this.comboBox_CreateClient_InvoiceIDAssign.TabIndex = 21;
            // 
            // comboBox_CreateClient_InvoiceTemplate
            // 
            this.comboBox_CreateClient_InvoiceTemplate.DisplayMember = "Default Template";
            this.comboBox_CreateClient_InvoiceTemplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_CreateClient_InvoiceTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CreateClient_InvoiceTemplate.FormattingEnabled = true;
            this.comboBox_CreateClient_InvoiceTemplate.Items.AddRange(new object[] {
            "Default Template"});
            this.comboBox_CreateClient_InvoiceTemplate.Location = new System.Drawing.Point(141, 123);
            this.comboBox_CreateClient_InvoiceTemplate.Name = "comboBox_CreateClient_InvoiceTemplate";
            this.comboBox_CreateClient_InvoiceTemplate.Size = new System.Drawing.Size(246, 27);
            this.comboBox_CreateClient_InvoiceTemplate.TabIndex = 22;
            // 
            // comboBox_CreateClient_Currency
            // 
            this.comboBox_CreateClient_Currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CreateClient_Currency.FormattingEnabled = true;
            this.comboBox_CreateClient_Currency.Location = new System.Drawing.Point(141, 243);
            this.comboBox_CreateClient_Currency.Name = "comboBox_CreateClient_Currency";
            this.comboBox_CreateClient_Currency.Size = new System.Drawing.Size(92, 27);
            this.comboBox_CreateClient_Currency.TabIndex = 23;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButton_CreateClient_VATApplicable_Yes);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_CreateClient_VATApplicable_No);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(141, 163);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(246, 34);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // radioButton_CreateClient_VATApplicable_Yes
            // 
            this.radioButton_CreateClient_VATApplicable_Yes.AutoSize = true;
            this.radioButton_CreateClient_VATApplicable_Yes.Location = new System.Drawing.Point(6, 3);
            this.radioButton_CreateClient_VATApplicable_Yes.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButton_CreateClient_VATApplicable_Yes.Name = "radioButton_CreateClient_VATApplicable_Yes";
            this.radioButton_CreateClient_VATApplicable_Yes.Size = new System.Drawing.Size(49, 23);
            this.radioButton_CreateClient_VATApplicable_Yes.TabIndex = 0;
            this.radioButton_CreateClient_VATApplicable_Yes.Text = "Yes";
            this.radioButton_CreateClient_VATApplicable_Yes.UseVisualStyleBackColor = true;
            this.radioButton_CreateClient_VATApplicable_Yes.CheckedChanged += new System.EventHandler(this.radioButton_CreateClient_VATApplicable_Yes_CheckedChanged);
            // 
            // radioButton_CreateClient_VATApplicable_No
            // 
            this.radioButton_CreateClient_VATApplicable_No.AutoSize = true;
            this.radioButton_CreateClient_VATApplicable_No.Checked = true;
            this.radioButton_CreateClient_VATApplicable_No.Location = new System.Drawing.Point(64, 3);
            this.radioButton_CreateClient_VATApplicable_No.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButton_CreateClient_VATApplicable_No.Name = "radioButton_CreateClient_VATApplicable_No";
            this.radioButton_CreateClient_VATApplicable_No.Size = new System.Drawing.Size(45, 23);
            this.radioButton_CreateClient_VATApplicable_No.TabIndex = 1;
            this.radioButton_CreateClient_VATApplicable_No.TabStop = true;
            this.radioButton_CreateClient_VATApplicable_No.Text = "No";
            this.radioButton_CreateClient_VATApplicable_No.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.numericUpDown_CreateClient_VATPercent);
            this.flowLayoutPanel2.Controls.Add(this.label23);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(141, 203);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(246, 34);
            this.flowLayoutPanel2.TabIndex = 25;
            // 
            // numericUpDown_CreateClient_VATPercent
            // 
            this.numericUpDown_CreateClient_VATPercent.Enabled = false;
            this.numericUpDown_CreateClient_VATPercent.Location = new System.Drawing.Point(3, 3);
            this.numericUpDown_CreateClient_VATPercent.Name = "numericUpDown_CreateClient_VATPercent";
            this.numericUpDown_CreateClient_VATPercent.Size = new System.Drawing.Size(66, 27);
            this.numericUpDown_CreateClient_VATPercent.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(72, 6);
            this.label23.Margin = new System.Windows.Forms.Padding(0, 6, 3, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 19);
            this.label23.TabIndex = 1;
            this.label23.Text = "%";
            // 
            // tableLayoutPanel_Clients_CreateClient
            // 
            this.tableLayoutPanel_Clients_CreateClient.ColumnCount = 2;
            this.tableLayoutPanel_Clients_CreateClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.61111F));
            this.tableLayoutPanel_Clients_CreateClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.38889F));
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.textBox_CreateClient_LastName, 1, 1);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.textBox_CreateClient_FirstName, 1, 0);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.label11, 0, 10);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.label12, 0, 11);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.label13, 0, 12);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.textBox_CreateClient_Company, 1, 2);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.textBox_CreateClient_TIN, 1, 3);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.textBox_CreateClient_VAT, 1, 4);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.textBox_CreateClient_Phone, 1, 5);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.textBox_CreateClient_Email, 1, 6);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.textBox_CreateClient_Address1, 1, 7);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.textBox_CreateClient_Address2, 1, 8);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.textBox_CreateClient_City, 1, 9);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.textBox_CreateClient_State, 1, 10);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.textBox_CreateClient_PostalCode, 1, 11);
            this.tableLayoutPanel_Clients_CreateClient.Controls.Add(this.comboBox_CreateClient_Country, 1, 12);
            this.tableLayoutPanel_Clients_CreateClient.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel_Clients_CreateClient.Name = "tableLayoutPanel_Clients_CreateClient";
            this.tableLayoutPanel_Clients_CreateClient.RowCount = 13;
            this.tableLayoutPanel_Clients_CreateClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Clients_CreateClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Clients_CreateClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Clients_CreateClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Clients_CreateClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Clients_CreateClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Clients_CreateClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Clients_CreateClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Clients_CreateClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Clients_CreateClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Clients_CreateClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Clients_CreateClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Clients_CreateClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Clients_CreateClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Clients_CreateClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Clients_CreateClient.Size = new System.Drawing.Size(360, 520);
            this.tableLayoutPanel_Clients_CreateClient.TabIndex = 1;
            // 
            // textBox_CreateClient_LastName
            // 
            this.textBox_CreateClient_LastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_CreateClient_LastName.Location = new System.Drawing.Point(105, 43);
            this.textBox_CreateClient_LastName.Name = "textBox_CreateClient_LastName";
            this.textBox_CreateClient_LastName.Size = new System.Drawing.Size(252, 27);
            this.textBox_CreateClient_LastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name *";
            // 
            // textBox_CreateClient_FirstName
            // 
            this.textBox_CreateClient_FirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_CreateClient_FirstName.Location = new System.Drawing.Point(105, 3);
            this.textBox_CreateClient_FirstName.Name = "textBox_CreateClient_FirstName";
            this.textBox_CreateClient_FirstName.Size = new System.Drawing.Size(252, 27);
            this.textBox_CreateClient_FirstName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Company *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "VAT #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "TIN #";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone #";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 286);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Address 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 326);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Address 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 366);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "City";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 406);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "State";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 446);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "Postal Code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 486);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 19);
            this.label13.TabIndex = 14;
            this.label13.Text = "Country *";
            // 
            // textBox_CreateClient_Company
            // 
            this.textBox_CreateClient_Company.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_CreateClient_Company.Location = new System.Drawing.Point(105, 83);
            this.textBox_CreateClient_Company.Name = "textBox_CreateClient_Company";
            this.textBox_CreateClient_Company.Size = new System.Drawing.Size(252, 27);
            this.textBox_CreateClient_Company.TabIndex = 15;
            // 
            // textBox_CreateClient_TIN
            // 
            this.textBox_CreateClient_TIN.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_CreateClient_TIN.Location = new System.Drawing.Point(105, 123);
            this.textBox_CreateClient_TIN.Name = "textBox_CreateClient_TIN";
            this.textBox_CreateClient_TIN.Size = new System.Drawing.Size(252, 27);
            this.textBox_CreateClient_TIN.TabIndex = 16;
            // 
            // textBox_CreateClient_VAT
            // 
            this.textBox_CreateClient_VAT.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_CreateClient_VAT.Location = new System.Drawing.Point(105, 163);
            this.textBox_CreateClient_VAT.Name = "textBox_CreateClient_VAT";
            this.textBox_CreateClient_VAT.Size = new System.Drawing.Size(252, 27);
            this.textBox_CreateClient_VAT.TabIndex = 17;
            // 
            // textBox_CreateClient_Phone
            // 
            this.textBox_CreateClient_Phone.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_CreateClient_Phone.Location = new System.Drawing.Point(105, 203);
            this.textBox_CreateClient_Phone.Name = "textBox_CreateClient_Phone";
            this.textBox_CreateClient_Phone.Size = new System.Drawing.Size(252, 27);
            this.textBox_CreateClient_Phone.TabIndex = 18;
            // 
            // textBox_CreateClient_Email
            // 
            this.textBox_CreateClient_Email.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_CreateClient_Email.Location = new System.Drawing.Point(105, 243);
            this.textBox_CreateClient_Email.Name = "textBox_CreateClient_Email";
            this.textBox_CreateClient_Email.Size = new System.Drawing.Size(252, 27);
            this.textBox_CreateClient_Email.TabIndex = 19;
            // 
            // textBox_CreateClient_Address1
            // 
            this.textBox_CreateClient_Address1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_CreateClient_Address1.Location = new System.Drawing.Point(105, 283);
            this.textBox_CreateClient_Address1.Name = "textBox_CreateClient_Address1";
            this.textBox_CreateClient_Address1.Size = new System.Drawing.Size(252, 27);
            this.textBox_CreateClient_Address1.TabIndex = 20;
            // 
            // textBox_CreateClient_Address2
            // 
            this.textBox_CreateClient_Address2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_CreateClient_Address2.Location = new System.Drawing.Point(105, 323);
            this.textBox_CreateClient_Address2.Name = "textBox_CreateClient_Address2";
            this.textBox_CreateClient_Address2.Size = new System.Drawing.Size(252, 27);
            this.textBox_CreateClient_Address2.TabIndex = 21;
            // 
            // textBox_CreateClient_City
            // 
            this.textBox_CreateClient_City.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_CreateClient_City.Location = new System.Drawing.Point(105, 363);
            this.textBox_CreateClient_City.Name = "textBox_CreateClient_City";
            this.textBox_CreateClient_City.Size = new System.Drawing.Size(252, 27);
            this.textBox_CreateClient_City.TabIndex = 22;
            // 
            // textBox_CreateClient_State
            // 
            this.textBox_CreateClient_State.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_CreateClient_State.Location = new System.Drawing.Point(105, 403);
            this.textBox_CreateClient_State.Name = "textBox_CreateClient_State";
            this.textBox_CreateClient_State.Size = new System.Drawing.Size(252, 27);
            this.textBox_CreateClient_State.TabIndex = 23;
            // 
            // textBox_CreateClient_PostalCode
            // 
            this.textBox_CreateClient_PostalCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_CreateClient_PostalCode.Location = new System.Drawing.Point(105, 443);
            this.textBox_CreateClient_PostalCode.Name = "textBox_CreateClient_PostalCode";
            this.textBox_CreateClient_PostalCode.Size = new System.Drawing.Size(252, 27);
            this.textBox_CreateClient_PostalCode.TabIndex = 24;
            // 
            // comboBox_CreateClient_Country
            // 
            this.comboBox_CreateClient_Country.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_CreateClient_Country.FormattingEnabled = true;
            this.comboBox_CreateClient_Country.Location = new System.Drawing.Point(105, 483);
            this.comboBox_CreateClient_Country.Name = "comboBox_CreateClient_Country";
            this.comboBox_CreateClient_Country.Size = new System.Drawing.Size(252, 27);
            this.comboBox_CreateClient_Country.TabIndex = 25;
            // 
            // tabPage_Invoices
            // 
            this.tabPage_Invoices.Controls.Add(this.tabControl_Invoices);
            this.tabPage_Invoices.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Invoices.Name = "tabPage_Invoices";
            this.tabPage_Invoices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Invoices.Size = new System.Drawing.Size(936, 647);
            this.tabPage_Invoices.TabIndex = 2;
            this.tabPage_Invoices.Text = "Invoices";
            // 
            // tabControl_Invoices
            // 
            this.tabControl_Invoices.Controls.Add(this.tabPage_Invoices_SearchInvoice);
            this.tabControl_Invoices.Controls.Add(this.tabPage_Invoices_EditInvoice);
            this.tabControl_Invoices.Controls.Add(this.tabPage_Invoices_CreateInvoice);
            this.tabControl_Invoices.Controls.Add(this.tabPage_Invoices_CreateRecurringInvoice);
            this.tabControl_Invoices.Controls.Add(this.tabPage_Invoices_PendingInvoices);
            this.tabControl_Invoices.Controls.Add(this.tabPage_Invoices_RecurringInvoices);
            this.tabControl_Invoices.Controls.Add(this.tabPage_Invoices_EditRecurringInvoice);
            this.tabControl_Invoices.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl_Invoices.DisplayStyle = TradeWright.UI.Forms.TabStyle.Angled;
            // 
            // 
            // 
            this.tabControl_Invoices.DisplayStyleProvider.BlendStyle = TradeWright.UI.Forms.BlendStyle.Normal;
            this.tabControl_Invoices.DisplayStyleProvider.BorderColorDisabled = System.Drawing.SystemColors.ControlLight;
            this.tabControl_Invoices.DisplayStyleProvider.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControl_Invoices.DisplayStyleProvider.BorderColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Invoices.DisplayStyleProvider.BorderColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Invoices.DisplayStyleProvider.BorderColorUnselected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Invoices.DisplayStyleProvider.CloserButtonFillColorFocused = System.Drawing.Color.Empty;
            this.tabControl_Invoices.DisplayStyleProvider.CloserButtonFillColorFocusedActive = System.Drawing.Color.Empty;
            this.tabControl_Invoices.DisplayStyleProvider.CloserButtonFillColorHighlighted = System.Drawing.Color.Empty;
            this.tabControl_Invoices.DisplayStyleProvider.CloserButtonFillColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabControl_Invoices.DisplayStyleProvider.CloserButtonFillColorSelected = System.Drawing.Color.Empty;
            this.tabControl_Invoices.DisplayStyleProvider.CloserButtonFillColorSelectedActive = System.Drawing.Color.Empty;
            this.tabControl_Invoices.DisplayStyleProvider.CloserButtonFillColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Invoices.DisplayStyleProvider.CloserButtonOutlineColorFocused = System.Drawing.Color.Empty;
            this.tabControl_Invoices.DisplayStyleProvider.CloserButtonOutlineColorFocusedActive = System.Drawing.Color.Empty;
            this.tabControl_Invoices.DisplayStyleProvider.CloserButtonOutlineColorHighlighted = System.Drawing.Color.Empty;
            this.tabControl_Invoices.DisplayStyleProvider.CloserButtonOutlineColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabControl_Invoices.DisplayStyleProvider.CloserButtonOutlineColorSelected = System.Drawing.Color.Empty;
            this.tabControl_Invoices.DisplayStyleProvider.CloserButtonOutlineColorSelectedActive = System.Drawing.Color.Empty;
            this.tabControl_Invoices.DisplayStyleProvider.CloserButtonOutlineColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Invoices.DisplayStyleProvider.CloserColorFocused = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Invoices.DisplayStyleProvider.CloserColorFocusedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Invoices.DisplayStyleProvider.CloserColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Invoices.DisplayStyleProvider.CloserColorHighlightedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Invoices.DisplayStyleProvider.CloserColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Invoices.DisplayStyleProvider.CloserColorSelectedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Invoices.DisplayStyleProvider.CloserColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Invoices.DisplayStyleProvider.FocusTrack = false;
            this.tabControl_Invoices.DisplayStyleProvider.HotTrack = true;
            this.tabControl_Invoices.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tabControl_Invoices.DisplayStyleProvider.Opacity = 1F;
            this.tabControl_Invoices.DisplayStyleProvider.Overlap = 8;
            this.tabControl_Invoices.DisplayStyleProvider.Padding = new System.Drawing.Point(8, 4);
            this.tabControl_Invoices.DisplayStyleProvider.PageBackgroundColorDisabled = System.Drawing.SystemColors.Control;
            this.tabControl_Invoices.DisplayStyleProvider.PageBackgroundColorFocused = System.Drawing.SystemColors.ControlLight;
            this.tabControl_Invoices.DisplayStyleProvider.PageBackgroundColorHighlighted = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabControl_Invoices.DisplayStyleProvider.PageBackgroundColorSelected = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Invoices.DisplayStyleProvider.PageBackgroundColorUnselected = System.Drawing.SystemColors.Control;
            this.tabControl_Invoices.DisplayStyleProvider.Radius = 12;
            this.tabControl_Invoices.DisplayStyleProvider.SelectedTabIsLarger = true;
            this.tabControl_Invoices.DisplayStyleProvider.ShowTabCloser = false;
            this.tabControl_Invoices.DisplayStyleProvider.TabColorDisabled1 = System.Drawing.SystemColors.Control;
            this.tabControl_Invoices.DisplayStyleProvider.TabColorDisabled2 = System.Drawing.SystemColors.Control;
            this.tabControl_Invoices.DisplayStyleProvider.TabColorFocused1 = System.Drawing.Color.White;
            this.tabControl_Invoices.DisplayStyleProvider.TabColorFocused2 = System.Drawing.Color.White;
            this.tabControl_Invoices.DisplayStyleProvider.TabColorHighLighted1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabControl_Invoices.DisplayStyleProvider.TabColorHighLighted2 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.tabControl_Invoices.DisplayStyleProvider.TabColorSelected1 = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Invoices.DisplayStyleProvider.TabColorSelected2 = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Invoices.DisplayStyleProvider.TabColorUnSelected1 = System.Drawing.SystemColors.Control;
            this.tabControl_Invoices.DisplayStyleProvider.TabColorUnSelected2 = System.Drawing.SystemColors.Control;
            this.tabControl_Invoices.DisplayStyleProvider.TabPageMargin = new System.Windows.Forms.Padding(1);
            this.tabControl_Invoices.DisplayStyleProvider.TextColorFocused = System.Drawing.SystemColors.ControlText;
            this.tabControl_Invoices.DisplayStyleProvider.TextColorHighlighted = System.Drawing.SystemColors.ControlText;
            this.tabControl_Invoices.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.tabControl_Invoices.DisplayStyleProvider.TextColorUnselected = System.Drawing.SystemColors.ControlDarkDark;
            this.tabControl_Invoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Invoices.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Invoices.HotTrack = true;
            this.tabControl_Invoices.Location = new System.Drawing.Point(3, 3);
            this.tabControl_Invoices.Name = "tabControl_Invoices";
            this.tabControl_Invoices.SelectedIndex = 0;
            this.tabControl_Invoices.Size = new System.Drawing.Size(930, 641);
            this.tabControl_Invoices.TabIndex = 2;
            // 
            // tabPage_Invoices_SearchInvoice
            // 
            this.tabPage_Invoices_SearchInvoice.Controls.Add(this.splitContainer_SearchInvoice_Root);
            this.tabPage_Invoices_SearchInvoice.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Invoices_SearchInvoice.Name = "tabPage_Invoices_SearchInvoice";
            this.tabPage_Invoices_SearchInvoice.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Invoices_SearchInvoice.TabIndex = 1;
            this.tabPage_Invoices_SearchInvoice.Text = "Search Invoice";
            // 
            // splitContainer_SearchInvoice_Root
            // 
            this.splitContainer_SearchInvoice_Root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_SearchInvoice_Root.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_SearchInvoice_Root.IsSplitterFixed = true;
            this.splitContainer_SearchInvoice_Root.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_SearchInvoice_Root.Name = "splitContainer_SearchInvoice_Root";
            this.splitContainer_SearchInvoice_Root.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_SearchInvoice_Root.Panel1
            // 
            this.splitContainer_SearchInvoice_Root.Panel1.AutoScroll = true;
            this.splitContainer_SearchInvoice_Root.Panel1.Controls.Add(this.groupBox12);
            this.splitContainer_SearchInvoice_Root.Panel1.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer_SearchInvoice_Root.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_SearchInvoice_Root.Panel1MinSize = 100;
            // 
            // splitContainer_SearchInvoice_Root.Panel2
            // 
            this.splitContainer_SearchInvoice_Root.Panel2.Controls.Add(this.groupBox13);
            this.splitContainer_SearchInvoice_Root.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer_SearchInvoice_Root.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_SearchInvoice_Root.Size = new System.Drawing.Size(922, 609);
            this.splitContainer_SearchInvoice_Root.SplitterDistance = 110;
            this.splitContainer_SearchInvoice_Root.TabIndex = 4;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.tableLayoutPanel4);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(6, 6);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.groupBox12.Size = new System.Drawing.Size(910, 98);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Search Invoice";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.Controls.Add(this.textBox_SearchInvoice_InvoiceID, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label39, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label41, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label43, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_SearchInvoice_Search, 5, 1);
            this.tableLayoutPanel4.Controls.Add(this.label42, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label44, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.comboBox_SearchInvoice_Client, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.comboBox_SearchInvoice_InvoiceStatus, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.dateTimePicker_SearchInvoice_DateFrom, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.dateTimePicker_SearchInvoice_DateTo, 4, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(898, 72);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // textBox_SearchInvoice_InvoiceID
            // 
            this.textBox_SearchInvoice_InvoiceID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_SearchInvoice_InvoiceID.Location = new System.Drawing.Point(6, 33);
            this.textBox_SearchInvoice_InvoiceID.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBox_SearchInvoice_InvoiceID.Name = "textBox_SearchInvoice_InvoiceID";
            this.textBox_SearchInvoice_InvoiceID.Size = new System.Drawing.Size(140, 20);
            this.textBox_SearchInvoice_InvoiceID.TabIndex = 15;
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(3, 17);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(52, 13);
            this.label39.TabIndex = 0;
            this.label39.Text = "Invoice #";
            // 
            // label41
            // 
            this.label41.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(155, 17);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(33, 13);
            this.label41.TabIndex = 2;
            this.label41.Text = "Client";
            // 
            // label43
            // 
            this.label43.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(307, 17);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(75, 13);
            this.label43.TabIndex = 4;
            this.label43.Text = "Invoice Status";
            // 
            // button_SearchInvoice_Search
            // 
            this.button_SearchInvoice_Search.Location = new System.Drawing.Point(763, 32);
            this.button_SearchInvoice_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.button_SearchInvoice_Search.Name = "button_SearchInvoice_Search";
            this.button_SearchInvoice_Search.Size = new System.Drawing.Size(90, 29);
            this.button_SearchInvoice_Search.TabIndex = 14;
            this.button_SearchInvoice_Search.Text = "Search";
            this.button_SearchInvoice_Search.UseVisualStyleBackColor = true;
            this.button_SearchInvoice_Search.Click += new System.EventHandler(this.button_SearchInvoice_Search_Click);
            // 
            // label42
            // 
            this.label42.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(459, 17);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(53, 13);
            this.label42.TabIndex = 18;
            this.label42.Text = "Date from";
            // 
            // label44
            // 
            this.label44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(611, 17);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(42, 13);
            this.label44.TabIndex = 19;
            this.label44.Text = "Date to";
            // 
            // comboBox_SearchInvoice_Client
            // 
            this.comboBox_SearchInvoice_Client.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_SearchInvoice_Client.FormattingEnabled = true;
            this.comboBox_SearchInvoice_Client.Location = new System.Drawing.Point(158, 33);
            this.comboBox_SearchInvoice_Client.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.comboBox_SearchInvoice_Client.Name = "comboBox_SearchInvoice_Client";
            this.comboBox_SearchInvoice_Client.Size = new System.Drawing.Size(140, 21);
            this.comboBox_SearchInvoice_Client.TabIndex = 20;
            // 
            // comboBox_SearchInvoice_InvoiceStatus
            // 
            this.comboBox_SearchInvoice_InvoiceStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_SearchInvoice_InvoiceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SearchInvoice_InvoiceStatus.FormattingEnabled = true;
            this.comboBox_SearchInvoice_InvoiceStatus.Location = new System.Drawing.Point(310, 33);
            this.comboBox_SearchInvoice_InvoiceStatus.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.comboBox_SearchInvoice_InvoiceStatus.Name = "comboBox_SearchInvoice_InvoiceStatus";
            this.comboBox_SearchInvoice_InvoiceStatus.Size = new System.Drawing.Size(140, 21);
            this.comboBox_SearchInvoice_InvoiceStatus.TabIndex = 21;
            // 
            // dateTimePicker_SearchInvoice_DateFrom
            // 
            this.dateTimePicker_SearchInvoice_DateFrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker_SearchInvoice_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_SearchInvoice_DateFrom.Location = new System.Drawing.Point(462, 33);
            this.dateTimePicker_SearchInvoice_DateFrom.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dateTimePicker_SearchInvoice_DateFrom.Name = "dateTimePicker_SearchInvoice_DateFrom";
            this.dateTimePicker_SearchInvoice_DateFrom.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker_SearchInvoice_DateFrom.TabIndex = 22;
            // 
            // dateTimePicker_SearchInvoice_DateTo
            // 
            this.dateTimePicker_SearchInvoice_DateTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker_SearchInvoice_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_SearchInvoice_DateTo.Location = new System.Drawing.Point(614, 33);
            this.dateTimePicker_SearchInvoice_DateTo.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dateTimePicker_SearchInvoice_DateTo.Name = "dateTimePicker_SearchInvoice_DateTo";
            this.dateTimePicker_SearchInvoice_DateTo.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker_SearchInvoice_DateTo.TabIndex = 23;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.splitContainer2);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox13.Location = new System.Drawing.Point(6, 6);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(9, 0, 9, 9);
            this.groupBox13.Size = new System.Drawing.Size(910, 483);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Invoices";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(9, 20);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label_SearchInvoice_Result);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView_SearchInvoice);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(892, 454);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 0;
            // 
            // label_SearchInvoice_Result
            // 
            this.label_SearchInvoice_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_SearchInvoice_Result.AutoSize = true;
            this.label_SearchInvoice_Result.Location = new System.Drawing.Point(3, 6);
            this.label_SearchInvoice_Result.Name = "label_SearchInvoice_Result";
            this.label_SearchInvoice_Result.Size = new System.Drawing.Size(60, 13);
            this.label_SearchInvoice_Result.TabIndex = 0;
            this.label_SearchInvoice_Result.Text = "[0] Invoice.";
            // 
            // dataGridView_SearchInvoice
            // 
            this.dataGridView_SearchInvoice.AllowUserToAddRows = false;
            this.dataGridView_SearchInvoice.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_SearchInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_SearchInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SearchInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewColumn_SearchInvoice_Invoice,
            this.dataGridViewColumn_SearchInvoice_Company,
            this.dataGridViewColumn_SearchInvoice_Comment,
            this.dataGridViewColumn_SearchInvoice_Amount,
            this.dataGridViewColumn_SearchInvoice_Created,
            this.dataGridViewColumn_SearchInvoice_DueDate,
            this.dataGridViewColumn_SearchInvoice_Status,
            this.dataGridViewColumn_SearchInvoice_View,
            this.dataGridViewColumn_SearchInvoice_Edit,
            this.dataGridViewColumn_SearchInvoice_Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_SearchInvoice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_SearchInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_SearchInvoice.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_SearchInvoice.Name = "dataGridView_SearchInvoice";
            this.dataGridView_SearchInvoice.ReadOnly = true;
            this.dataGridView_SearchInvoice.RowHeadersVisible = false;
            this.dataGridView_SearchInvoice.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_SearchInvoice.Size = new System.Drawing.Size(880, 413);
            this.dataGridView_SearchInvoice.TabIndex = 0;
            this.dataGridView_SearchInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SearchInvoice_CellClick);
            // 
            // dataGridViewColumn_SearchInvoice_Invoice
            // 
            this.dataGridViewColumn_SearchInvoice_Invoice.HeaderText = "Invoice #";
            this.dataGridViewColumn_SearchInvoice_Invoice.Name = "dataGridViewColumn_SearchInvoice_Invoice";
            this.dataGridViewColumn_SearchInvoice_Invoice.ReadOnly = true;
            this.dataGridViewColumn_SearchInvoice_Invoice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumn_SearchInvoice_Invoice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewColumn_SearchInvoice_Company
            // 
            this.dataGridViewColumn_SearchInvoice_Company.HeaderText = "Company";
            this.dataGridViewColumn_SearchInvoice_Company.Name = "dataGridViewColumn_SearchInvoice_Company";
            this.dataGridViewColumn_SearchInvoice_Company.ReadOnly = true;
            this.dataGridViewColumn_SearchInvoice_Company.Width = 110;
            // 
            // dataGridViewColumn_SearchInvoice_Comment
            // 
            this.dataGridViewColumn_SearchInvoice_Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumn_SearchInvoice_Comment.HeaderText = "Comment";
            this.dataGridViewColumn_SearchInvoice_Comment.Name = "dataGridViewColumn_SearchInvoice_Comment";
            this.dataGridViewColumn_SearchInvoice_Comment.ReadOnly = true;
            // 
            // dataGridViewColumn_SearchInvoice_Amount
            // 
            this.dataGridViewColumn_SearchInvoice_Amount.HeaderText = "Amount";
            this.dataGridViewColumn_SearchInvoice_Amount.Name = "dataGridViewColumn_SearchInvoice_Amount";
            this.dataGridViewColumn_SearchInvoice_Amount.ReadOnly = true;
            // 
            // dataGridViewColumn_SearchInvoice_Created
            // 
            this.dataGridViewColumn_SearchInvoice_Created.HeaderText = "Created";
            this.dataGridViewColumn_SearchInvoice_Created.Name = "dataGridViewColumn_SearchInvoice_Created";
            this.dataGridViewColumn_SearchInvoice_Created.ReadOnly = true;
            // 
            // dataGridViewColumn_SearchInvoice_DueDate
            // 
            this.dataGridViewColumn_SearchInvoice_DueDate.HeaderText = "Due Date";
            this.dataGridViewColumn_SearchInvoice_DueDate.Name = "dataGridViewColumn_SearchInvoice_DueDate";
            this.dataGridViewColumn_SearchInvoice_DueDate.ReadOnly = true;
            // 
            // dataGridViewColumn_SearchInvoice_Status
            // 
            this.dataGridViewColumn_SearchInvoice_Status.HeaderText = "Status";
            this.dataGridViewColumn_SearchInvoice_Status.Name = "dataGridViewColumn_SearchInvoice_Status";
            this.dataGridViewColumn_SearchInvoice_Status.ReadOnly = true;
            this.dataGridViewColumn_SearchInvoice_Status.Width = 90;
            // 
            // dataGridViewColumn_SearchInvoice_View
            // 
            this.dataGridViewColumn_SearchInvoice_View.HeaderText = "";
            this.dataGridViewColumn_SearchInvoice_View.Name = "dataGridViewColumn_SearchInvoice_View";
            this.dataGridViewColumn_SearchInvoice_View.ReadOnly = true;
            this.dataGridViewColumn_SearchInvoice_View.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumn_SearchInvoice_View.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewColumn_SearchInvoice_View.Width = 50;
            // 
            // dataGridViewColumn_SearchInvoice_Edit
            // 
            this.dataGridViewColumn_SearchInvoice_Edit.HeaderText = "";
            this.dataGridViewColumn_SearchInvoice_Edit.Name = "dataGridViewColumn_SearchInvoice_Edit";
            this.dataGridViewColumn_SearchInvoice_Edit.ReadOnly = true;
            this.dataGridViewColumn_SearchInvoice_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumn_SearchInvoice_Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewColumn_SearchInvoice_Edit.Width = 50;
            // 
            // dataGridViewColumn_SearchInvoice_Delete
            // 
            this.dataGridViewColumn_SearchInvoice_Delete.HeaderText = "";
            this.dataGridViewColumn_SearchInvoice_Delete.Name = "dataGridViewColumn_SearchInvoice_Delete";
            this.dataGridViewColumn_SearchInvoice_Delete.ReadOnly = true;
            this.dataGridViewColumn_SearchInvoice_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumn_SearchInvoice_Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewColumn_SearchInvoice_Delete.Width = 60;
            // 
            // tabPage_Invoices_EditInvoice
            // 
            this.tabPage_Invoices_EditInvoice.Controls.Add(this.splitContainer_EditInvoice_Root);
            this.tabPage_Invoices_EditInvoice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage_Invoices_EditInvoice.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Invoices_EditInvoice.Name = "tabPage_Invoices_EditInvoice";
            this.tabPage_Invoices_EditInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Invoices_EditInvoice.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Invoices_EditInvoice.TabIndex = 6;
            this.tabPage_Invoices_EditInvoice.Text = "Edit Invoice";
            // 
            // splitContainer_EditInvoice_Root
            // 
            this.splitContainer_EditInvoice_Root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_EditInvoice_Root.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_EditInvoice_Root.IsSplitterFixed = true;
            this.splitContainer_EditInvoice_Root.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_EditInvoice_Root.Name = "splitContainer_EditInvoice_Root";
            this.splitContainer_EditInvoice_Root.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_EditInvoice_Root.Panel1
            // 
            this.splitContainer_EditInvoice_Root.Panel1.AutoScroll = true;
            this.splitContainer_EditInvoice_Root.Panel1.Controls.Add(this.splitContainer_EditInvoice_Client);
            this.splitContainer_EditInvoice_Root.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer_EditInvoice_Root.Panel2
            // 
            this.splitContainer_EditInvoice_Root.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer_EditInvoice_Root.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_EditInvoice_Root.Size = new System.Drawing.Size(916, 603);
            this.splitContainer_EditInvoice_Root.SplitterDistance = 200;
            this.splitContainer_EditInvoice_Root.TabIndex = 4;
            // 
            // splitContainer_EditInvoice_Client
            // 
            this.splitContainer_EditInvoice_Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_EditInvoice_Client.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_EditInvoice_Client.IsSplitterFixed = true;
            this.splitContainer_EditInvoice_Client.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_EditInvoice_Client.MinimumSize = new System.Drawing.Size(780, 0);
            this.splitContainer_EditInvoice_Client.Name = "splitContainer_EditInvoice_Client";
            // 
            // splitContainer_EditInvoice_Client.Panel1
            // 
            this.splitContainer_EditInvoice_Client.Panel1.Controls.Add(this.groupBox6);
            this.splitContainer_EditInvoice_Client.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer_EditInvoice_Client.Panel2
            // 
            this.splitContainer_EditInvoice_Client.Panel2.Controls.Add(this.groupBox18);
            this.splitContainer_EditInvoice_Client.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_EditInvoice_Client.Size = new System.Drawing.Size(916, 200);
            this.splitContainer_EditInvoice_Client.SplitterDistance = 500;
            this.splitContainer_EditInvoice_Client.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button_EditInvoice_ChangeClient);
            this.groupBox6.Controls.Add(this.panel_EditInvoice_SelectClient);
            this.groupBox6.Controls.Add(this.textBox_EditInvoice_ClientDetail);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(500, 200);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Client";
            // 
            // button_EditInvoice_ChangeClient
            // 
            this.button_EditInvoice_ChangeClient.Location = new System.Drawing.Point(366, 159);
            this.button_EditInvoice_ChangeClient.Name = "button_EditInvoice_ChangeClient";
            this.button_EditInvoice_ChangeClient.Size = new System.Drawing.Size(122, 29);
            this.button_EditInvoice_ChangeClient.TabIndex = 6;
            this.button_EditInvoice_ChangeClient.Text = "Change Client";
            this.button_EditInvoice_ChangeClient.UseVisualStyleBackColor = true;
            this.button_EditInvoice_ChangeClient.Visible = false;
            this.button_EditInvoice_ChangeClient.Click += new System.EventHandler(this.button_EditInvoice_ChangeClient_Click);
            // 
            // panel_EditInvoice_SelectClient
            // 
            this.panel_EditInvoice_SelectClient.Controls.Add(this.button_EditInvoice_SelectClient);
            this.panel_EditInvoice_SelectClient.Controls.Add(this.comboBox_EditInvoice_SelectClient);
            this.panel_EditInvoice_SelectClient.Controls.Add(this.label52);
            this.panel_EditInvoice_SelectClient.Location = new System.Drawing.Point(6, 21);
            this.panel_EditInvoice_SelectClient.Name = "panel_EditInvoice_SelectClient";
            this.panel_EditInvoice_SelectClient.Size = new System.Drawing.Size(491, 42);
            this.panel_EditInvoice_SelectClient.TabIndex = 5;
            // 
            // button_EditInvoice_SelectClient
            // 
            this.button_EditInvoice_SelectClient.Location = new System.Drawing.Point(402, 7);
            this.button_EditInvoice_SelectClient.Name = "button_EditInvoice_SelectClient";
            this.button_EditInvoice_SelectClient.Size = new System.Drawing.Size(80, 29);
            this.button_EditInvoice_SelectClient.TabIndex = 7;
            this.button_EditInvoice_SelectClient.Text = "Done";
            this.button_EditInvoice_SelectClient.UseVisualStyleBackColor = true;
            this.button_EditInvoice_SelectClient.Click += new System.EventHandler(this.button_EditInvoice_SelectClient_Click);
            // 
            // comboBox_EditInvoice_SelectClient
            // 
            this.comboBox_EditInvoice_SelectClient.FormattingEnabled = true;
            this.comboBox_EditInvoice_SelectClient.Location = new System.Drawing.Point(99, 8);
            this.comboBox_EditInvoice_SelectClient.Name = "comboBox_EditInvoice_SelectClient";
            this.comboBox_EditInvoice_SelectClient.Size = new System.Drawing.Size(295, 21);
            this.comboBox_EditInvoice_SelectClient.TabIndex = 6;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(2, 11);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(66, 13);
            this.label52.TabIndex = 5;
            this.label52.Text = "Select Client";
            // 
            // textBox_EditInvoice_ClientDetail
            // 
            this.textBox_EditInvoice_ClientDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EditInvoice_ClientDetail.Location = new System.Drawing.Point(13, 33);
            this.textBox_EditInvoice_ClientDetail.Multiline = true;
            this.textBox_EditInvoice_ClientDetail.Name = "textBox_EditInvoice_ClientDetail";
            this.textBox_EditInvoice_ClientDetail.ReadOnly = true;
            this.textBox_EditInvoice_ClientDetail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_EditInvoice_ClientDetail.Size = new System.Drawing.Size(356, 152);
            this.textBox_EditInvoice_ClientDetail.TabIndex = 3;
            this.textBox_EditInvoice_ClientDetail.Visible = false;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.tableLayoutPanel7);
            this.groupBox18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox18.Location = new System.Drawing.Point(0, 0);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(412, 200);
            this.groupBox18.TabIndex = 2;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Invoice Details";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.43564F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.56435F));
            this.tableLayoutPanel7.Controls.Add(this.label55, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label56, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label57, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label58, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.label59, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.textBox_EditInvoice_InvoiceID, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.dateTimePicker_EditInvoice_InvoiceDate, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.dateTimePicker_EditInvoice_DueDate, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.comboBox_EditInvoice_Status, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.flowLayoutPanel4, 1, 4);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(7, 27);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 5;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(404, 164);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(3, 6);
            this.label55.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(52, 13);
            this.label55.TabIndex = 0;
            this.label55.Text = "Invoice #";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(3, 38);
            this.label56.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(68, 13);
            this.label56.TabIndex = 1;
            this.label56.Text = "Invoice Date";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(3, 70);
            this.label57.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(53, 13);
            this.label57.TabIndex = 2;
            this.label57.Text = "Due Date";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(3, 102);
            this.label58.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(37, 13);
            this.label58.TabIndex = 3;
            this.label58.Text = "Status";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(3, 134);
            this.label59.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(73, 13);
            this.label59.TabIndex = 4;
            this.label59.Text = "Send to Client";
            // 
            // textBox_EditInvoice_InvoiceID
            // 
            this.textBox_EditInvoice_InvoiceID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EditInvoice_InvoiceID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_EditInvoice_InvoiceID.Location = new System.Drawing.Point(133, 6);
            this.textBox_EditInvoice_InvoiceID.Margin = new System.Windows.Forms.Padding(6, 6, 3, 3);
            this.textBox_EditInvoice_InvoiceID.Name = "textBox_EditInvoice_InvoiceID";
            this.textBox_EditInvoice_InvoiceID.ReadOnly = true;
            this.textBox_EditInvoice_InvoiceID.Size = new System.Drawing.Size(268, 13);
            this.textBox_EditInvoice_InvoiceID.TabIndex = 5;
            this.textBox_EditInvoice_InvoiceID.TabStop = false;
            // 
            // dateTimePicker_EditInvoice_InvoiceDate
            // 
            this.dateTimePicker_EditInvoice_InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_EditInvoice_InvoiceDate.Location = new System.Drawing.Point(130, 35);
            this.dateTimePicker_EditInvoice_InvoiceDate.Name = "dateTimePicker_EditInvoice_InvoiceDate";
            this.dateTimePicker_EditInvoice_InvoiceDate.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker_EditInvoice_InvoiceDate.TabIndex = 6;
            // 
            // dateTimePicker_EditInvoice_DueDate
            // 
            this.dateTimePicker_EditInvoice_DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_EditInvoice_DueDate.Location = new System.Drawing.Point(130, 67);
            this.dateTimePicker_EditInvoice_DueDate.Name = "dateTimePicker_EditInvoice_DueDate";
            this.dateTimePicker_EditInvoice_DueDate.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker_EditInvoice_DueDate.TabIndex = 7;
            // 
            // comboBox_EditInvoice_Status
            // 
            this.comboBox_EditInvoice_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EditInvoice_Status.FormattingEnabled = true;
            this.comboBox_EditInvoice_Status.Location = new System.Drawing.Point(130, 99);
            this.comboBox_EditInvoice_Status.Name = "comboBox_EditInvoice_Status";
            this.comboBox_EditInvoice_Status.Size = new System.Drawing.Size(128, 21);
            this.comboBox_EditInvoice_Status.TabIndex = 8;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.radioButton_EditInvoice_Send2Client_Yes);
            this.flowLayoutPanel4.Controls.Add(this.radioButton_EditInvoice_Send2Client_No);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(130, 131);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(271, 30);
            this.flowLayoutPanel4.TabIndex = 9;
            // 
            // radioButton_EditInvoice_Send2Client_Yes
            // 
            this.radioButton_EditInvoice_Send2Client_Yes.AutoSize = true;
            this.radioButton_EditInvoice_Send2Client_Yes.Location = new System.Drawing.Point(6, 3);
            this.radioButton_EditInvoice_Send2Client_Yes.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButton_EditInvoice_Send2Client_Yes.Name = "radioButton_EditInvoice_Send2Client_Yes";
            this.radioButton_EditInvoice_Send2Client_Yes.Size = new System.Drawing.Size(49, 23);
            this.radioButton_EditInvoice_Send2Client_Yes.TabIndex = 0;
            this.radioButton_EditInvoice_Send2Client_Yes.Text = "Yes";
            this.radioButton_EditInvoice_Send2Client_Yes.UseVisualStyleBackColor = true;
            // 
            // radioButton_EditInvoice_Send2Client_No
            // 
            this.radioButton_EditInvoice_Send2Client_No.AutoSize = true;
            this.radioButton_EditInvoice_Send2Client_No.Checked = true;
            this.radioButton_EditInvoice_Send2Client_No.Location = new System.Drawing.Point(64, 3);
            this.radioButton_EditInvoice_Send2Client_No.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButton_EditInvoice_Send2Client_No.Name = "radioButton_EditInvoice_Send2Client_No";
            this.radioButton_EditInvoice_Send2Client_No.Size = new System.Drawing.Size(45, 23);
            this.radioButton_EditInvoice_Send2Client_No.TabIndex = 1;
            this.radioButton_EditInvoice_Send2Client_No.TabStop = true;
            this.radioButton_EditInvoice_Send2Client_No.Text = "No";
            this.radioButton_EditInvoice_Send2Client_No.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupBox23);
            this.splitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer13);
            this.splitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer4.Size = new System.Drawing.Size(916, 399);
            this.splitContainer4.SplitterDistance = 178;
            this.splitContainer4.TabIndex = 0;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.gridView_EditInvoice_InvoiceItem);
            this.groupBox23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox23.Location = new System.Drawing.Point(0, 0);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(916, 178);
            this.groupBox23.TabIndex = 3;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Invoice Item";
            // 
            // gridView_EditInvoice_InvoiceItem
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView_EditInvoice_InvoiceItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridView_EditInvoice_InvoiceItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_EditInvoice_InvoiceItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView_EditInvoice_InvoiceItem.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridView_EditInvoice_InvoiceItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView_EditInvoice_InvoiceItem.Location = new System.Drawing.Point(3, 23);
            this.gridView_EditInvoice_InvoiceItem.Name = "gridView_EditInvoice_InvoiceItem";
            this.gridView_EditInvoice_InvoiceItem.Size = new System.Drawing.Size(910, 152);
            this.gridView_EditInvoice_InvoiceItem.TabIndex = 0;
            this.gridView_EditInvoice_InvoiceItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_EditInvoice_InvoiceItem_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // splitContainer13
            // 
            this.splitContainer13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer13.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer13.IsSplitterFixed = true;
            this.splitContainer13.Location = new System.Drawing.Point(0, 0);
            this.splitContainer13.Name = "splitContainer13";
            this.splitContainer13.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer13.Panel1
            // 
            this.splitContainer13.Panel1.Controls.Add(this.splitContainer14);
            this.splitContainer13.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer13.Panel2
            // 
            this.splitContainer13.Panel2.Controls.Add(this.textBox_EditInvoice_AmountDue);
            this.splitContainer13.Panel2.Controls.Add(this.textBox_EditInvoice_Payments);
            this.splitContainer13.Panel2.Controls.Add(this.label75);
            this.splitContainer13.Panel2.Controls.Add(this.label77);
            this.splitContainer13.Panel2.Controls.Add(this.button_EditInvoice_ViewPDF);
            this.splitContainer13.Panel2.Controls.Add(this.button_EditInvoice_SendEmail);
            this.splitContainer13.Panel2.Controls.Add(this.button_EditInvoice_SaveInvoice);
            this.splitContainer13.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer13.Size = new System.Drawing.Size(916, 217);
            this.splitContainer13.SplitterDistance = 130;
            this.splitContainer13.TabIndex = 3;
            // 
            // splitContainer14
            // 
            this.splitContainer14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer14.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer14.IsSplitterFixed = true;
            this.splitContainer14.Location = new System.Drawing.Point(0, 0);
            this.splitContainer14.Name = "splitContainer14";
            // 
            // splitContainer14.Panel1
            // 
            this.splitContainer14.Panel1.Controls.Add(this.groupBox24);
            this.splitContainer14.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer14.Panel2
            // 
            this.splitContainer14.Panel2.Controls.Add(this.button10);
            this.splitContainer14.Panel2.Controls.Add(this.button15);
            this.splitContainer14.Panel2.Controls.Add(this.button16);
            this.splitContainer14.Panel2.Controls.Add(this.groupBox27);
            this.splitContainer14.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer14.Size = new System.Drawing.Size(916, 130);
            this.splitContainer14.SplitterDistance = 640;
            this.splitContainer14.TabIndex = 1;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.textBox_EditInvoice_Comments);
            this.groupBox24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox24.Location = new System.Drawing.Point(0, 0);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(640, 130);
            this.groupBox24.TabIndex = 4;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Comments";
            // 
            // textBox_EditInvoice_Comments
            // 
            this.textBox_EditInvoice_Comments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_EditInvoice_Comments.Location = new System.Drawing.Point(3, 23);
            this.textBox_EditInvoice_Comments.Multiline = true;
            this.textBox_EditInvoice_Comments.Name = "textBox_EditInvoice_Comments";
            this.textBox_EditInvoice_Comments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_EditInvoice_Comments.Size = new System.Drawing.Size(634, 104);
            this.textBox_EditInvoice_Comments.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(543, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 26);
            this.button10.TabIndex = 2;
            this.button10.Text = "View as PDF";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(669, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(120, 26);
            this.button15.TabIndex = 1;
            this.button15.Text = "Send eMail";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(795, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(120, 26);
            this.button16.TabIndex = 0;
            this.button16.Text = "Save Invoice";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.tableLayoutPanel9);
            this.groupBox27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox27.Location = new System.Drawing.Point(0, 0);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(272, 130);
            this.groupBox27.TabIndex = 5;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Totals";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.36636F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.63363F));
            this.tableLayoutPanel9.Controls.Add(this.label60, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.label_EditInvoice_Total, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.textBox_EditInvoice_SubTotal, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.textBox_EditInvoice_VAT_Value, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.textBox_EditInvoice_GrandTotal, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.flowLayoutPanel5, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(266, 104);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // label60
            // 
            this.label60.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(114, 6);
            this.label60.Margin = new System.Windows.Forms.Padding(3, 6, 9, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(53, 13);
            this.label60.TabIndex = 0;
            this.label60.Text = "Sub-Total";
            // 
            // label_EditInvoice_Total
            // 
            this.label_EditInvoice_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_EditInvoice_Total.AutoSize = true;
            this.label_EditInvoice_Total.Location = new System.Drawing.Point(136, 74);
            this.label_EditInvoice_Total.Margin = new System.Windows.Forms.Padding(3, 6, 9, 0);
            this.label_EditInvoice_Total.Name = "label_EditInvoice_Total";
            this.label_EditInvoice_Total.Size = new System.Drawing.Size(31, 13);
            this.label_EditInvoice_Total.TabIndex = 2;
            this.label_EditInvoice_Total.Text = "Total";
            // 
            // textBox_EditInvoice_SubTotal
            // 
            this.textBox_EditInvoice_SubTotal.Location = new System.Drawing.Point(179, 3);
            this.textBox_EditInvoice_SubTotal.Name = "textBox_EditInvoice_SubTotal";
            this.textBox_EditInvoice_SubTotal.ReadOnly = true;
            this.textBox_EditInvoice_SubTotal.Size = new System.Drawing.Size(84, 20);
            this.textBox_EditInvoice_SubTotal.TabIndex = 3;
            this.textBox_EditInvoice_SubTotal.TextChanged += new System.EventHandler(this.textBox_EditInvoice_SubTotal_TextChanged);
            // 
            // textBox_EditInvoice_VAT_Value
            // 
            this.textBox_EditInvoice_VAT_Value.Location = new System.Drawing.Point(179, 37);
            this.textBox_EditInvoice_VAT_Value.Name = "textBox_EditInvoice_VAT_Value";
            this.textBox_EditInvoice_VAT_Value.ReadOnly = true;
            this.textBox_EditInvoice_VAT_Value.Size = new System.Drawing.Size(84, 20);
            this.textBox_EditInvoice_VAT_Value.TabIndex = 4;
            // 
            // textBox_EditInvoice_GrandTotal
            // 
            this.textBox_EditInvoice_GrandTotal.Location = new System.Drawing.Point(179, 71);
            this.textBox_EditInvoice_GrandTotal.Name = "textBox_EditInvoice_GrandTotal";
            this.textBox_EditInvoice_GrandTotal.ReadOnly = true;
            this.textBox_EditInvoice_GrandTotal.Size = new System.Drawing.Size(84, 20);
            this.textBox_EditInvoice_GrandTotal.TabIndex = 5;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.label68);
            this.flowLayoutPanel5.Controls.Add(this.numericUpDown_EditInvoice_VAT_Percent);
            this.flowLayoutPanel5.Controls.Add(this.label69);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(47, 34);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(129, 26);
            this.flowLayoutPanel5.TabIndex = 6;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(3, 6);
            this.label68.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(28, 13);
            this.label68.TabIndex = 0;
            this.label68.Text = "VAT";
            // 
            // numericUpDown_EditInvoice_VAT_Percent
            // 
            this.numericUpDown_EditInvoice_VAT_Percent.Location = new System.Drawing.Point(37, 3);
            this.numericUpDown_EditInvoice_VAT_Percent.Name = "numericUpDown_EditInvoice_VAT_Percent";
            this.numericUpDown_EditInvoice_VAT_Percent.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown_EditInvoice_VAT_Percent.TabIndex = 3;
            this.numericUpDown_EditInvoice_VAT_Percent.ValueChanged += new System.EventHandler(this.numericUpDown_EditInvoice_VAT_Percent_ValueChanged);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(105, 6);
            this.label69.Margin = new System.Windows.Forms.Padding(3, 6, 9, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(15, 13);
            this.label69.TabIndex = 2;
            this.label69.Text = "%";
            // 
            // textBox_EditInvoice_AmountDue
            // 
            this.textBox_EditInvoice_AmountDue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EditInvoice_AmountDue.Location = new System.Drawing.Point(824, 24);
            this.textBox_EditInvoice_AmountDue.Name = "textBox_EditInvoice_AmountDue";
            this.textBox_EditInvoice_AmountDue.ReadOnly = true;
            this.textBox_EditInvoice_AmountDue.Size = new System.Drawing.Size(89, 13);
            this.textBox_EditInvoice_AmountDue.TabIndex = 11;
            this.textBox_EditInvoice_AmountDue.Text = "$0.00";
            // 
            // textBox_EditInvoice_Payments
            // 
            this.textBox_EditInvoice_Payments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EditInvoice_Payments.Location = new System.Drawing.Point(824, 1);
            this.textBox_EditInvoice_Payments.Name = "textBox_EditInvoice_Payments";
            this.textBox_EditInvoice_Payments.ReadOnly = true;
            this.textBox_EditInvoice_Payments.Size = new System.Drawing.Size(86, 13);
            this.textBox_EditInvoice_Payments.TabIndex = 10;
            this.textBox_EditInvoice_Payments.Text = "$0.00";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(715, 24);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(66, 13);
            this.label75.TabIndex = 9;
            this.label75.Text = "Amount Due";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(732, 2);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(53, 13);
            this.label77.TabIndex = 8;
            this.label77.Text = "Payments";
            // 
            // button_EditInvoice_ViewPDF
            // 
            this.button_EditInvoice_ViewPDF.Location = new System.Drawing.Point(543, 55);
            this.button_EditInvoice_ViewPDF.Name = "button_EditInvoice_ViewPDF";
            this.button_EditInvoice_ViewPDF.Size = new System.Drawing.Size(120, 26);
            this.button_EditInvoice_ViewPDF.TabIndex = 2;
            this.button_EditInvoice_ViewPDF.Text = "View as PDF";
            this.button_EditInvoice_ViewPDF.UseVisualStyleBackColor = true;
            // 
            // button_EditInvoice_SendEmail
            // 
            this.button_EditInvoice_SendEmail.Location = new System.Drawing.Point(669, 55);
            this.button_EditInvoice_SendEmail.Name = "button_EditInvoice_SendEmail";
            this.button_EditInvoice_SendEmail.Size = new System.Drawing.Size(120, 26);
            this.button_EditInvoice_SendEmail.TabIndex = 1;
            this.button_EditInvoice_SendEmail.Text = "Send eMail";
            this.button_EditInvoice_SendEmail.UseVisualStyleBackColor = true;
            // 
            // button_EditInvoice_SaveInvoice
            // 
            this.button_EditInvoice_SaveInvoice.Location = new System.Drawing.Point(795, 55);
            this.button_EditInvoice_SaveInvoice.Name = "button_EditInvoice_SaveInvoice";
            this.button_EditInvoice_SaveInvoice.Size = new System.Drawing.Size(120, 26);
            this.button_EditInvoice_SaveInvoice.TabIndex = 0;
            this.button_EditInvoice_SaveInvoice.Text = "Save Invoice";
            this.button_EditInvoice_SaveInvoice.UseVisualStyleBackColor = true;
            this.button_EditInvoice_SaveInvoice.Click += new System.EventHandler(this.button_EditInvoice_SaveInvoice_Click);
            // 
            // tabPage_Invoices_CreateInvoice
            // 
            this.tabPage_Invoices_CreateInvoice.Controls.Add(this.splitContainer_CreateInvoice_Root);
            this.tabPage_Invoices_CreateInvoice.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Invoices_CreateInvoice.Name = "tabPage_Invoices_CreateInvoice";
            this.tabPage_Invoices_CreateInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Invoices_CreateInvoice.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Invoices_CreateInvoice.TabIndex = 2;
            this.tabPage_Invoices_CreateInvoice.Text = "Create Invoice";
            // 
            // splitContainer_CreateInvoice_Root
            // 
            this.splitContainer_CreateInvoice_Root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_CreateInvoice_Root.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_CreateInvoice_Root.IsSplitterFixed = true;
            this.splitContainer_CreateInvoice_Root.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_CreateInvoice_Root.Name = "splitContainer_CreateInvoice_Root";
            this.splitContainer_CreateInvoice_Root.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_CreateInvoice_Root.Panel1
            // 
            this.splitContainer_CreateInvoice_Root.Panel1.AutoScroll = true;
            this.splitContainer_CreateInvoice_Root.Panel1.Controls.Add(this.splitContainer_CreateInvoice_Client);
            this.splitContainer_CreateInvoice_Root.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer_CreateInvoice_Root.Panel2
            // 
            this.splitContainer_CreateInvoice_Root.Panel2.Controls.Add(this.splitContainer_Dashboard_CreateInvoice_Bottom);
            this.splitContainer_CreateInvoice_Root.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_CreateInvoice_Root.Size = new System.Drawing.Size(916, 603);
            this.splitContainer_CreateInvoice_Root.SplitterDistance = 200;
            this.splitContainer_CreateInvoice_Root.TabIndex = 3;
            // 
            // splitContainer_CreateInvoice_Client
            // 
            this.splitContainer_CreateInvoice_Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_CreateInvoice_Client.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_CreateInvoice_Client.IsSplitterFixed = true;
            this.splitContainer_CreateInvoice_Client.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_CreateInvoice_Client.MinimumSize = new System.Drawing.Size(780, 0);
            this.splitContainer_CreateInvoice_Client.Name = "splitContainer_CreateInvoice_Client";
            // 
            // splitContainer_CreateInvoice_Client.Panel1
            // 
            this.splitContainer_CreateInvoice_Client.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer_CreateInvoice_Client.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer_CreateInvoice_Client.Panel2
            // 
            this.splitContainer_CreateInvoice_Client.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer_CreateInvoice_Client.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_CreateInvoice_Client.Size = new System.Drawing.Size(916, 200);
            this.splitContainer_CreateInvoice_Client.SplitterDistance = 500;
            this.splitContainer_CreateInvoice_Client.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_CreateInvoice_ChangeClient);
            this.groupBox3.Controls.Add(this.panel_CreateInvoice_SelectClient);
            this.groupBox3.Controls.Add(this.textBox_CreateInvoice_ClientDetail);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 200);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Client";
            // 
            // button_CreateInvoice_ChangeClient
            // 
            this.button_CreateInvoice_ChangeClient.Location = new System.Drawing.Point(366, 159);
            this.button_CreateInvoice_ChangeClient.Name = "button_CreateInvoice_ChangeClient";
            this.button_CreateInvoice_ChangeClient.Size = new System.Drawing.Size(122, 29);
            this.button_CreateInvoice_ChangeClient.TabIndex = 6;
            this.button_CreateInvoice_ChangeClient.Text = "Change Client";
            this.button_CreateInvoice_ChangeClient.UseVisualStyleBackColor = true;
            this.button_CreateInvoice_ChangeClient.Visible = false;
            this.button_CreateInvoice_ChangeClient.Click += new System.EventHandler(this.button_CreateInvoice_ChangeClient_Click);
            // 
            // panel_CreateInvoice_SelectClient
            // 
            this.panel_CreateInvoice_SelectClient.Controls.Add(this.button_CreateInvoice_SelectClient);
            this.panel_CreateInvoice_SelectClient.Controls.Add(this.comboBox_CreateInvoice_SelectClient);
            this.panel_CreateInvoice_SelectClient.Controls.Add(this.label29);
            this.panel_CreateInvoice_SelectClient.Location = new System.Drawing.Point(6, 21);
            this.panel_CreateInvoice_SelectClient.Name = "panel_CreateInvoice_SelectClient";
            this.panel_CreateInvoice_SelectClient.Size = new System.Drawing.Size(491, 42);
            this.panel_CreateInvoice_SelectClient.TabIndex = 5;
            // 
            // button_CreateInvoice_SelectClient
            // 
            this.button_CreateInvoice_SelectClient.Location = new System.Drawing.Point(402, 7);
            this.button_CreateInvoice_SelectClient.Name = "button_CreateInvoice_SelectClient";
            this.button_CreateInvoice_SelectClient.Size = new System.Drawing.Size(80, 29);
            this.button_CreateInvoice_SelectClient.TabIndex = 7;
            this.button_CreateInvoice_SelectClient.Text = "Done";
            this.button_CreateInvoice_SelectClient.UseVisualStyleBackColor = true;
            this.button_CreateInvoice_SelectClient.Click += new System.EventHandler(this.button_CreateInvoice_SelectClient_Click);
            // 
            // comboBox_CreateInvoice_SelectClient
            // 
            this.comboBox_CreateInvoice_SelectClient.FormattingEnabled = true;
            this.comboBox_CreateInvoice_SelectClient.Location = new System.Drawing.Point(99, 8);
            this.comboBox_CreateInvoice_SelectClient.Name = "comboBox_CreateInvoice_SelectClient";
            this.comboBox_CreateInvoice_SelectClient.Size = new System.Drawing.Size(295, 21);
            this.comboBox_CreateInvoice_SelectClient.TabIndex = 6;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(2, 11);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(66, 13);
            this.label29.TabIndex = 5;
            this.label29.Text = "Select Client";
            // 
            // textBox_CreateInvoice_ClientDetail
            // 
            this.textBox_CreateInvoice_ClientDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CreateInvoice_ClientDetail.Location = new System.Drawing.Point(13, 33);
            this.textBox_CreateInvoice_ClientDetail.Multiline = true;
            this.textBox_CreateInvoice_ClientDetail.Name = "textBox_CreateInvoice_ClientDetail";
            this.textBox_CreateInvoice_ClientDetail.ReadOnly = true;
            this.textBox_CreateInvoice_ClientDetail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_CreateInvoice_ClientDetail.Size = new System.Drawing.Size(356, 152);
            this.textBox_CreateInvoice_ClientDetail.TabIndex = 3;
            this.textBox_CreateInvoice_ClientDetail.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(412, 200);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Invoice Details";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.43564F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.56435F));
            this.tableLayoutPanel2.Controls.Add(this.label30, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label31, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label32, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label33, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label34, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBox_CreateInvoice_InvoiceID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker_CreateInvoice_InvoiceDate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker_CreateInvoice_DueDate, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_CreateInvoice_Status, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel7, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(404, 164);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(3, 6);
            this.label30.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(52, 13);
            this.label30.TabIndex = 0;
            this.label30.Text = "Invoice #";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 38);
            this.label31.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(68, 13);
            this.label31.TabIndex = 1;
            this.label31.Text = "Invoice Date";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 70);
            this.label32.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 13);
            this.label32.TabIndex = 2;
            this.label32.Text = "Due Date";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 102);
            this.label33.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(37, 13);
            this.label33.TabIndex = 3;
            this.label33.Text = "Status";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(3, 134);
            this.label34.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(73, 13);
            this.label34.TabIndex = 4;
            this.label34.Text = "Send to Client";
            // 
            // textBox_CreateInvoice_InvoiceID
            // 
            this.textBox_CreateInvoice_InvoiceID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CreateInvoice_InvoiceID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_CreateInvoice_InvoiceID.Location = new System.Drawing.Point(133, 6);
            this.textBox_CreateInvoice_InvoiceID.Margin = new System.Windows.Forms.Padding(6, 6, 3, 3);
            this.textBox_CreateInvoice_InvoiceID.Name = "textBox_CreateInvoice_InvoiceID";
            this.textBox_CreateInvoice_InvoiceID.ReadOnly = true;
            this.textBox_CreateInvoice_InvoiceID.Size = new System.Drawing.Size(268, 13);
            this.textBox_CreateInvoice_InvoiceID.TabIndex = 5;
            this.textBox_CreateInvoice_InvoiceID.TabStop = false;
            // 
            // dateTimePicker_CreateInvoice_InvoiceDate
            // 
            this.dateTimePicker_CreateInvoice_InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_CreateInvoice_InvoiceDate.Location = new System.Drawing.Point(130, 35);
            this.dateTimePicker_CreateInvoice_InvoiceDate.Name = "dateTimePicker_CreateInvoice_InvoiceDate";
            this.dateTimePicker_CreateInvoice_InvoiceDate.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker_CreateInvoice_InvoiceDate.TabIndex = 6;
            // 
            // dateTimePicker_CreateInvoice_DueDate
            // 
            this.dateTimePicker_CreateInvoice_DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_CreateInvoice_DueDate.Location = new System.Drawing.Point(130, 67);
            this.dateTimePicker_CreateInvoice_DueDate.Name = "dateTimePicker_CreateInvoice_DueDate";
            this.dateTimePicker_CreateInvoice_DueDate.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker_CreateInvoice_DueDate.TabIndex = 7;
            // 
            // comboBox_CreateInvoice_Status
            // 
            this.comboBox_CreateInvoice_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CreateInvoice_Status.FormattingEnabled = true;
            this.comboBox_CreateInvoice_Status.Location = new System.Drawing.Point(130, 99);
            this.comboBox_CreateInvoice_Status.Name = "comboBox_CreateInvoice_Status";
            this.comboBox_CreateInvoice_Status.Size = new System.Drawing.Size(128, 21);
            this.comboBox_CreateInvoice_Status.TabIndex = 8;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.radioButton_CreateInvoice_Send2Client_Yes);
            this.flowLayoutPanel7.Controls.Add(this.radioButton_CreateInvoice_Send2Client_No);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(130, 131);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(271, 30);
            this.flowLayoutPanel7.TabIndex = 9;
            // 
            // radioButton_CreateInvoice_Send2Client_Yes
            // 
            this.radioButton_CreateInvoice_Send2Client_Yes.AutoSize = true;
            this.radioButton_CreateInvoice_Send2Client_Yes.Location = new System.Drawing.Point(6, 3);
            this.radioButton_CreateInvoice_Send2Client_Yes.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButton_CreateInvoice_Send2Client_Yes.Name = "radioButton_CreateInvoice_Send2Client_Yes";
            this.radioButton_CreateInvoice_Send2Client_Yes.Size = new System.Drawing.Size(49, 23);
            this.radioButton_CreateInvoice_Send2Client_Yes.TabIndex = 0;
            this.radioButton_CreateInvoice_Send2Client_Yes.Text = "Yes";
            this.radioButton_CreateInvoice_Send2Client_Yes.UseVisualStyleBackColor = true;
            // 
            // radioButton_CreateInvoice_Send2Client_No
            // 
            this.radioButton_CreateInvoice_Send2Client_No.AutoSize = true;
            this.radioButton_CreateInvoice_Send2Client_No.Checked = true;
            this.radioButton_CreateInvoice_Send2Client_No.Location = new System.Drawing.Point(64, 3);
            this.radioButton_CreateInvoice_Send2Client_No.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButton_CreateInvoice_Send2Client_No.Name = "radioButton_CreateInvoice_Send2Client_No";
            this.radioButton_CreateInvoice_Send2Client_No.Size = new System.Drawing.Size(45, 23);
            this.radioButton_CreateInvoice_Send2Client_No.TabIndex = 1;
            this.radioButton_CreateInvoice_Send2Client_No.TabStop = true;
            this.radioButton_CreateInvoice_Send2Client_No.Text = "No";
            this.radioButton_CreateInvoice_Send2Client_No.UseVisualStyleBackColor = true;
            // 
            // splitContainer_Dashboard_CreateInvoice_Bottom
            // 
            this.splitContainer_Dashboard_CreateInvoice_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Dashboard_CreateInvoice_Bottom.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_Dashboard_CreateInvoice_Bottom.IsSplitterFixed = true;
            this.splitContainer_Dashboard_CreateInvoice_Bottom.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Dashboard_CreateInvoice_Bottom.Name = "splitContainer_Dashboard_CreateInvoice_Bottom";
            this.splitContainer_Dashboard_CreateInvoice_Bottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Dashboard_CreateInvoice_Bottom.Panel1
            // 
            this.splitContainer_Dashboard_CreateInvoice_Bottom.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer_Dashboard_CreateInvoice_Bottom.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer_Dashboard_CreateInvoice_Bottom.Panel2
            // 
            this.splitContainer_Dashboard_CreateInvoice_Bottom.Panel2.Controls.Add(this.splitContainer11);
            this.splitContainer_Dashboard_CreateInvoice_Bottom.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_Dashboard_CreateInvoice_Bottom.Size = new System.Drawing.Size(916, 399);
            this.splitContainer_Dashboard_CreateInvoice_Bottom.SplitterDistance = 178;
            this.splitContainer_Dashboard_CreateInvoice_Bottom.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gridView_CreateInvoice_InvoiceItem);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(916, 178);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Invoice Item";
            // 
            // gridView_CreateInvoice_InvoiceItem
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView_CreateInvoice_InvoiceItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridView_CreateInvoice_InvoiceItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_CreateInvoice_InvoiceItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_Description,
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_Quantity,
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_UnitPrice,
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_Total});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView_CreateInvoice_InvoiceItem.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridView_CreateInvoice_InvoiceItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView_CreateInvoice_InvoiceItem.Location = new System.Drawing.Point(3, 23);
            this.gridView_CreateInvoice_InvoiceItem.Name = "gridView_CreateInvoice_InvoiceItem";
            this.gridView_CreateInvoice_InvoiceItem.Size = new System.Drawing.Size(910, 152);
            this.gridView_CreateInvoice_InvoiceItem.TabIndex = 0;
            this.gridView_CreateInvoice_InvoiceItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CreateInvoice_InvoiceItem_CellValueChanged);
            // 
            // dataGridViewColumn_CreateInvoice_InvoiceItems_Description
            // 
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_Description.HeaderText = "Description";
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_Description.Name = "dataGridViewColumn_CreateInvoice_InvoiceItems_Description";
            // 
            // dataGridViewColumn_CreateInvoice_InvoiceItems_Quantity
            // 
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_Quantity.HeaderText = "Qty";
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_Quantity.Name = "dataGridViewColumn_CreateInvoice_InvoiceItems_Quantity";
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_Quantity.Width = 150;
            // 
            // dataGridViewColumn_CreateInvoice_InvoiceItems_UnitPrice
            // 
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_UnitPrice.HeaderText = "Unit Price";
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_UnitPrice.Name = "dataGridViewColumn_CreateInvoice_InvoiceItems_UnitPrice";
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_UnitPrice.Width = 150;
            // 
            // dataGridViewColumn_CreateInvoice_InvoiceItems_Total
            // 
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_Total.HeaderText = "Total";
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_Total.Name = "dataGridViewColumn_CreateInvoice_InvoiceItems_Total";
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_Total.ReadOnly = true;
            this.dataGridViewColumn_CreateInvoice_InvoiceItems_Total.Width = 150;
            // 
            // splitContainer11
            // 
            this.splitContainer11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer11.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer11.IsSplitterFixed = true;
            this.splitContainer11.Location = new System.Drawing.Point(0, 0);
            this.splitContainer11.Name = "splitContainer11";
            this.splitContainer11.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer11.Panel1
            // 
            this.splitContainer11.Panel1.Controls.Add(this.splitContainer12);
            this.splitContainer11.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer11.Panel2
            // 
            this.splitContainer11.Panel2.Controls.Add(this.textBox_CreateInvoice_AmountDue);
            this.splitContainer11.Panel2.Controls.Add(this.textBox_CreateInvoice_Payments);
            this.splitContainer11.Panel2.Controls.Add(this.label76);
            this.splitContainer11.Panel2.Controls.Add(this.label70);
            this.splitContainer11.Panel2.Controls.Add(this.button_CreateInvoice_ViewPDF);
            this.splitContainer11.Panel2.Controls.Add(this.button_CreateInvoice_SendEmail);
            this.splitContainer11.Panel2.Controls.Add(this.button_CreateInvoice_SaveInvoice);
            this.splitContainer11.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer11.Size = new System.Drawing.Size(916, 217);
            this.splitContainer11.SplitterDistance = 130;
            this.splitContainer11.TabIndex = 3;
            // 
            // splitContainer12
            // 
            this.splitContainer12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer12.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer12.IsSplitterFixed = true;
            this.splitContainer12.Location = new System.Drawing.Point(0, 0);
            this.splitContainer12.Name = "splitContainer12";
            // 
            // splitContainer12.Panel1
            // 
            this.splitContainer12.Panel1.Controls.Add(this.groupBox25);
            this.splitContainer12.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer12.Panel2
            // 
            this.splitContainer12.Panel2.Controls.Add(this.button12);
            this.splitContainer12.Panel2.Controls.Add(this.button13);
            this.splitContainer12.Panel2.Controls.Add(this.button14);
            this.splitContainer12.Panel2.Controls.Add(this.groupBox26);
            this.splitContainer12.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer12.Size = new System.Drawing.Size(916, 130);
            this.splitContainer12.SplitterDistance = 640;
            this.splitContainer12.TabIndex = 1;
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.textBox_CreateInvoice_Comments);
            this.groupBox25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox25.Location = new System.Drawing.Point(0, 0);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(640, 130);
            this.groupBox25.TabIndex = 4;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Comments";
            // 
            // textBox_CreateInvoice_Comments
            // 
            this.textBox_CreateInvoice_Comments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_CreateInvoice_Comments.Location = new System.Drawing.Point(3, 23);
            this.textBox_CreateInvoice_Comments.Multiline = true;
            this.textBox_CreateInvoice_Comments.Name = "textBox_CreateInvoice_Comments";
            this.textBox_CreateInvoice_Comments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_CreateInvoice_Comments.Size = new System.Drawing.Size(634, 104);
            this.textBox_CreateInvoice_Comments.TabIndex = 0;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(543, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(120, 26);
            this.button12.TabIndex = 2;
            this.button12.Text = "View as PDF";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(669, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(120, 26);
            this.button13.TabIndex = 1;
            this.button13.Text = "Send eMail";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(795, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(120, 26);
            this.button14.TabIndex = 0;
            this.button14.Text = "Save Invoice";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.tableLayoutPanel10);
            this.groupBox26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox26.Location = new System.Drawing.Point(0, 0);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(272, 130);
            this.groupBox26.TabIndex = 5;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Totals";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.36636F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.63363F));
            this.tableLayoutPanel10.Controls.Add(this.label71, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label_CreateInvoice_Total, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.textBox_CreateInvoice_SubTotal, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.textBox_CreateInvoice_VAT_Value, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.textBox_CreateInvoice_GrandTotal, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.flowLayoutPanel6, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(266, 104);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // label71
            // 
            this.label71.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(114, 6);
            this.label71.Margin = new System.Windows.Forms.Padding(3, 6, 9, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(53, 13);
            this.label71.TabIndex = 0;
            this.label71.Text = "Sub-Total";
            // 
            // label_CreateInvoice_Total
            // 
            this.label_CreateInvoice_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CreateInvoice_Total.AutoSize = true;
            this.label_CreateInvoice_Total.Location = new System.Drawing.Point(136, 74);
            this.label_CreateInvoice_Total.Margin = new System.Windows.Forms.Padding(3, 6, 9, 0);
            this.label_CreateInvoice_Total.Name = "label_CreateInvoice_Total";
            this.label_CreateInvoice_Total.Size = new System.Drawing.Size(31, 13);
            this.label_CreateInvoice_Total.TabIndex = 2;
            this.label_CreateInvoice_Total.Text = "Total";
            // 
            // textBox_CreateInvoice_SubTotal
            // 
            this.textBox_CreateInvoice_SubTotal.Location = new System.Drawing.Point(179, 3);
            this.textBox_CreateInvoice_SubTotal.Name = "textBox_CreateInvoice_SubTotal";
            this.textBox_CreateInvoice_SubTotal.ReadOnly = true;
            this.textBox_CreateInvoice_SubTotal.Size = new System.Drawing.Size(84, 20);
            this.textBox_CreateInvoice_SubTotal.TabIndex = 3;
            this.textBox_CreateInvoice_SubTotal.Click += new System.EventHandler(this.textBox_CreateInvoice_SubTotal_TextChanged);
            this.textBox_CreateInvoice_SubTotal.TextChanged += new System.EventHandler(this.textBox_CreateInvoice_SubTotal_TextChanged);
            // 
            // textBox_CreateInvoice_VAT_Value
            // 
            this.textBox_CreateInvoice_VAT_Value.Location = new System.Drawing.Point(179, 37);
            this.textBox_CreateInvoice_VAT_Value.Name = "textBox_CreateInvoice_VAT_Value";
            this.textBox_CreateInvoice_VAT_Value.ReadOnly = true;
            this.textBox_CreateInvoice_VAT_Value.Size = new System.Drawing.Size(84, 20);
            this.textBox_CreateInvoice_VAT_Value.TabIndex = 4;
            // 
            // textBox_CreateInvoice_GrandTotal
            // 
            this.textBox_CreateInvoice_GrandTotal.Location = new System.Drawing.Point(179, 71);
            this.textBox_CreateInvoice_GrandTotal.Name = "textBox_CreateInvoice_GrandTotal";
            this.textBox_CreateInvoice_GrandTotal.ReadOnly = true;
            this.textBox_CreateInvoice_GrandTotal.Size = new System.Drawing.Size(84, 20);
            this.textBox_CreateInvoice_GrandTotal.TabIndex = 5;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.Controls.Add(this.label73);
            this.flowLayoutPanel6.Controls.Add(this.numericUpDown_CreateInvoice_VAT_Percent);
            this.flowLayoutPanel6.Controls.Add(this.label74);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(47, 34);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(129, 26);
            this.flowLayoutPanel6.TabIndex = 6;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(3, 6);
            this.label73.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(28, 13);
            this.label73.TabIndex = 0;
            this.label73.Text = "VAT";
            // 
            // numericUpDown_CreateInvoice_VAT_Percent
            // 
            this.numericUpDown_CreateInvoice_VAT_Percent.Location = new System.Drawing.Point(37, 3);
            this.numericUpDown_CreateInvoice_VAT_Percent.Name = "numericUpDown_CreateInvoice_VAT_Percent";
            this.numericUpDown_CreateInvoice_VAT_Percent.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown_CreateInvoice_VAT_Percent.TabIndex = 3;
            this.numericUpDown_CreateInvoice_VAT_Percent.ValueChanged += new System.EventHandler(this.numericUpDown_CreateInvoice_VAT_Percent_ValueChanged);
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(105, 6);
            this.label74.Margin = new System.Windows.Forms.Padding(3, 6, 9, 0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(15, 13);
            this.label74.TabIndex = 2;
            this.label74.Text = "%";
            // 
            // textBox_CreateInvoice_AmountDue
            // 
            this.textBox_CreateInvoice_AmountDue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CreateInvoice_AmountDue.Location = new System.Drawing.Point(824, 24);
            this.textBox_CreateInvoice_AmountDue.Name = "textBox_CreateInvoice_AmountDue";
            this.textBox_CreateInvoice_AmountDue.ReadOnly = true;
            this.textBox_CreateInvoice_AmountDue.Size = new System.Drawing.Size(89, 13);
            this.textBox_CreateInvoice_AmountDue.TabIndex = 7;
            this.textBox_CreateInvoice_AmountDue.Text = "$0.00";
            // 
            // textBox_CreateInvoice_Payments
            // 
            this.textBox_CreateInvoice_Payments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CreateInvoice_Payments.Location = new System.Drawing.Point(824, 1);
            this.textBox_CreateInvoice_Payments.Name = "textBox_CreateInvoice_Payments";
            this.textBox_CreateInvoice_Payments.ReadOnly = true;
            this.textBox_CreateInvoice_Payments.Size = new System.Drawing.Size(86, 13);
            this.textBox_CreateInvoice_Payments.TabIndex = 6;
            this.textBox_CreateInvoice_Payments.Text = "$0.00";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(715, 24);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(66, 13);
            this.label76.TabIndex = 5;
            this.label76.Text = "Amount Due";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(732, 2);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(53, 13);
            this.label70.TabIndex = 3;
            this.label70.Text = "Payments";
            // 
            // button_CreateInvoice_ViewPDF
            // 
            this.button_CreateInvoice_ViewPDF.Location = new System.Drawing.Point(543, 55);
            this.button_CreateInvoice_ViewPDF.Name = "button_CreateInvoice_ViewPDF";
            this.button_CreateInvoice_ViewPDF.Size = new System.Drawing.Size(120, 26);
            this.button_CreateInvoice_ViewPDF.TabIndex = 2;
            this.button_CreateInvoice_ViewPDF.Text = "View as PDF";
            this.button_CreateInvoice_ViewPDF.UseVisualStyleBackColor = true;
            this.button_CreateInvoice_ViewPDF.Click += new System.EventHandler(this.button_CreateInvoice_ViewPDF_Click);
            // 
            // button_CreateInvoice_SendEmail
            // 
            this.button_CreateInvoice_SendEmail.Location = new System.Drawing.Point(669, 55);
            this.button_CreateInvoice_SendEmail.Name = "button_CreateInvoice_SendEmail";
            this.button_CreateInvoice_SendEmail.Size = new System.Drawing.Size(120, 26);
            this.button_CreateInvoice_SendEmail.TabIndex = 1;
            this.button_CreateInvoice_SendEmail.Text = "Send eMail";
            this.button_CreateInvoice_SendEmail.UseVisualStyleBackColor = true;
            // 
            // button_CreateInvoice_SaveInvoice
            // 
            this.button_CreateInvoice_SaveInvoice.Location = new System.Drawing.Point(795, 55);
            this.button_CreateInvoice_SaveInvoice.Name = "button_CreateInvoice_SaveInvoice";
            this.button_CreateInvoice_SaveInvoice.Size = new System.Drawing.Size(120, 26);
            this.button_CreateInvoice_SaveInvoice.TabIndex = 0;
            this.button_CreateInvoice_SaveInvoice.Text = "Save Invoice";
            this.button_CreateInvoice_SaveInvoice.UseVisualStyleBackColor = true;
            this.button_CreateInvoice_SaveInvoice.Click += new System.EventHandler(this.button_CreateInvoice_SaveInvoice_Click);
            // 
            // tabPage_Invoices_CreateRecurringInvoice
            // 
            this.tabPage_Invoices_CreateRecurringInvoice.Controls.Add(this.splitContainer_CreateRecurringInvoice_Root);
            this.tabPage_Invoices_CreateRecurringInvoice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Invoices_CreateRecurringInvoice.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Invoices_CreateRecurringInvoice.Name = "tabPage_Invoices_CreateRecurringInvoice";
            this.tabPage_Invoices_CreateRecurringInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Invoices_CreateRecurringInvoice.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Invoices_CreateRecurringInvoice.TabIndex = 3;
            this.tabPage_Invoices_CreateRecurringInvoice.Text = "Create Recurring Invoice";
            // 
            // splitContainer_CreateRecurringInvoice_Root
            // 
            this.splitContainer_CreateRecurringInvoice_Root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_CreateRecurringInvoice_Root.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_CreateRecurringInvoice_Root.IsSplitterFixed = true;
            this.splitContainer_CreateRecurringInvoice_Root.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_CreateRecurringInvoice_Root.Name = "splitContainer_CreateRecurringInvoice_Root";
            this.splitContainer_CreateRecurringInvoice_Root.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_CreateRecurringInvoice_Root.Panel1
            // 
            this.splitContainer_CreateRecurringInvoice_Root.Panel1.AutoScroll = true;
            this.splitContainer_CreateRecurringInvoice_Root.Panel1.Controls.Add(this.splitContainer_CreateRecurringInvoice_Client);
            this.splitContainer_CreateRecurringInvoice_Root.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer_CreateRecurringInvoice_Root.Panel2
            // 
            this.splitContainer_CreateRecurringInvoice_Root.Panel2.Controls.Add(this.splitContainer_CreateRecurringInvoice_Bottom);
            this.splitContainer_CreateRecurringInvoice_Root.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_CreateRecurringInvoice_Root.Size = new System.Drawing.Size(916, 603);
            this.splitContainer_CreateRecurringInvoice_Root.SplitterDistance = 260;
            this.splitContainer_CreateRecurringInvoice_Root.TabIndex = 3;
            // 
            // splitContainer_CreateRecurringInvoice_Client
            // 
            this.splitContainer_CreateRecurringInvoice_Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_CreateRecurringInvoice_Client.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_CreateRecurringInvoice_Client.IsSplitterFixed = true;
            this.splitContainer_CreateRecurringInvoice_Client.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_CreateRecurringInvoice_Client.MinimumSize = new System.Drawing.Size(780, 0);
            this.splitContainer_CreateRecurringInvoice_Client.Name = "splitContainer_CreateRecurringInvoice_Client";
            // 
            // splitContainer_CreateRecurringInvoice_Client.Panel1
            // 
            this.splitContainer_CreateRecurringInvoice_Client.Panel1.Controls.Add(this.groupBox14);
            this.splitContainer_CreateRecurringInvoice_Client.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer_CreateRecurringInvoice_Client.Panel2
            // 
            this.splitContainer_CreateRecurringInvoice_Client.Panel2.Controls.Add(this.groupBox15);
            this.splitContainer_CreateRecurringInvoice_Client.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_CreateRecurringInvoice_Client.Size = new System.Drawing.Size(916, 260);
            this.splitContainer_CreateRecurringInvoice_Client.SplitterDistance = 500;
            this.splitContainer_CreateRecurringInvoice_Client.TabIndex = 1;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.button_CreateRecurringInvoice_ChangeClient);
            this.groupBox14.Controls.Add(this.panel_CreateRecurringInvoice_SelectClient);
            this.groupBox14.Controls.Add(this.textBox_CreateRecurringInvoice_ClientDetail);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox14.Location = new System.Drawing.Point(0, 0);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(500, 260);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Client";
            // 
            // button_CreateRecurringInvoice_ChangeClient
            // 
            this.button_CreateRecurringInvoice_ChangeClient.Location = new System.Drawing.Point(366, 220);
            this.button_CreateRecurringInvoice_ChangeClient.Name = "button_CreateRecurringInvoice_ChangeClient";
            this.button_CreateRecurringInvoice_ChangeClient.Size = new System.Drawing.Size(122, 29);
            this.button_CreateRecurringInvoice_ChangeClient.TabIndex = 6;
            this.button_CreateRecurringInvoice_ChangeClient.Text = "Change Client";
            this.button_CreateRecurringInvoice_ChangeClient.UseVisualStyleBackColor = true;
            this.button_CreateRecurringInvoice_ChangeClient.Visible = false;
            this.button_CreateRecurringInvoice_ChangeClient.Click += new System.EventHandler(this.button_CreateRecurringInvoice_ChangeClient_Click);
            // 
            // panel_CreateRecurringInvoice_SelectClient
            // 
            this.panel_CreateRecurringInvoice_SelectClient.Controls.Add(this.button_CreateRecurringInvoice_SelectClient);
            this.panel_CreateRecurringInvoice_SelectClient.Controls.Add(this.comboBox_CreateRecurringInvoice_SelectClient);
            this.panel_CreateRecurringInvoice_SelectClient.Controls.Add(this.label40);
            this.panel_CreateRecurringInvoice_SelectClient.Location = new System.Drawing.Point(6, 21);
            this.panel_CreateRecurringInvoice_SelectClient.Name = "panel_CreateRecurringInvoice_SelectClient";
            this.panel_CreateRecurringInvoice_SelectClient.Size = new System.Drawing.Size(491, 42);
            this.panel_CreateRecurringInvoice_SelectClient.TabIndex = 5;
            // 
            // button_CreateRecurringInvoice_SelectClient
            // 
            this.button_CreateRecurringInvoice_SelectClient.Location = new System.Drawing.Point(402, 7);
            this.button_CreateRecurringInvoice_SelectClient.Name = "button_CreateRecurringInvoice_SelectClient";
            this.button_CreateRecurringInvoice_SelectClient.Size = new System.Drawing.Size(80, 29);
            this.button_CreateRecurringInvoice_SelectClient.TabIndex = 7;
            this.button_CreateRecurringInvoice_SelectClient.Text = "Done";
            this.button_CreateRecurringInvoice_SelectClient.UseVisualStyleBackColor = true;
            this.button_CreateRecurringInvoice_SelectClient.Click += new System.EventHandler(this.button_CreateRecurringInvoice_SelectClient_Click);
            // 
            // comboBox_CreateRecurringInvoice_SelectClient
            // 
            this.comboBox_CreateRecurringInvoice_SelectClient.FormattingEnabled = true;
            this.comboBox_CreateRecurringInvoice_SelectClient.Location = new System.Drawing.Point(99, 8);
            this.comboBox_CreateRecurringInvoice_SelectClient.Name = "comboBox_CreateRecurringInvoice_SelectClient";
            this.comboBox_CreateRecurringInvoice_SelectClient.Size = new System.Drawing.Size(295, 27);
            this.comboBox_CreateRecurringInvoice_SelectClient.TabIndex = 6;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(2, 11);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(90, 19);
            this.label40.TabIndex = 5;
            this.label40.Text = "Select Client";
            // 
            // textBox_CreateRecurringInvoice_ClientDetail
            // 
            this.textBox_CreateRecurringInvoice_ClientDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CreateRecurringInvoice_ClientDetail.Location = new System.Drawing.Point(13, 33);
            this.textBox_CreateRecurringInvoice_ClientDetail.Multiline = true;
            this.textBox_CreateRecurringInvoice_ClientDetail.Name = "textBox_CreateRecurringInvoice_ClientDetail";
            this.textBox_CreateRecurringInvoice_ClientDetail.ReadOnly = true;
            this.textBox_CreateRecurringInvoice_ClientDetail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_CreateRecurringInvoice_ClientDetail.Size = new System.Drawing.Size(356, 152);
            this.textBox_CreateRecurringInvoice_ClientDetail.TabIndex = 3;
            this.textBox_CreateRecurringInvoice_ClientDetail.Visible = false;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.tableLayoutPanel5);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox15.Location = new System.Drawing.Point(0, 0);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(412, 260);
            this.groupBox15.TabIndex = 2;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Invoice Details";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.7037F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.2963F));
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel11, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.label46, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label47, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label48, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label49, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label50, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.textBox_CreateRecurringInvoice_InvoiceID, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.dateTimePicker_CreateRecurringInvoice_DueDate, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.comboBox_CreateRecurringInvoice_Status, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.dateTimePicker_CreateRecurringInvoice_InvoiceDate, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label81, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.label100, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.numericUpDown_CreateRecurringInvoice_NextDays, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.numericUpDown_CreateRecurringInvoice_DueDays, 1, 6);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(7, 27);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 7;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(405, 228);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Controls.Add(this.radioButton_CreateRecurringInvoice_Send2Client_Yes);
            this.flowLayoutPanel11.Controls.Add(this.radioButton_CreateRecurringInvoice_Send2Client_No);
            this.flowLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel11.Location = new System.Drawing.Point(260, 131);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(142, 26);
            this.flowLayoutPanel11.TabIndex = 11;
            // 
            // radioButton_CreateRecurringInvoice_Send2Client_Yes
            // 
            this.radioButton_CreateRecurringInvoice_Send2Client_Yes.AutoSize = true;
            this.radioButton_CreateRecurringInvoice_Send2Client_Yes.Location = new System.Drawing.Point(6, 3);
            this.radioButton_CreateRecurringInvoice_Send2Client_Yes.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButton_CreateRecurringInvoice_Send2Client_Yes.Name = "radioButton_CreateRecurringInvoice_Send2Client_Yes";
            this.radioButton_CreateRecurringInvoice_Send2Client_Yes.Size = new System.Drawing.Size(49, 23);
            this.radioButton_CreateRecurringInvoice_Send2Client_Yes.TabIndex = 0;
            this.radioButton_CreateRecurringInvoice_Send2Client_Yes.Text = "Yes";
            this.radioButton_CreateRecurringInvoice_Send2Client_Yes.UseVisualStyleBackColor = true;
            // 
            // radioButton_CreateRecurringInvoice_Send2Client_No
            // 
            this.radioButton_CreateRecurringInvoice_Send2Client_No.AutoSize = true;
            this.radioButton_CreateRecurringInvoice_Send2Client_No.Checked = true;
            this.radioButton_CreateRecurringInvoice_Send2Client_No.Location = new System.Drawing.Point(64, 3);
            this.radioButton_CreateRecurringInvoice_Send2Client_No.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButton_CreateRecurringInvoice_Send2Client_No.Name = "radioButton_CreateRecurringInvoice_Send2Client_No";
            this.radioButton_CreateRecurringInvoice_Send2Client_No.Size = new System.Drawing.Size(45, 23);
            this.radioButton_CreateRecurringInvoice_Send2Client_No.TabIndex = 1;
            this.radioButton_CreateRecurringInvoice_Send2Client_No.TabStop = true;
            this.radioButton_CreateRecurringInvoice_Send2Client_No.Text = "No";
            this.radioButton_CreateRecurringInvoice_Send2Client_No.UseVisualStyleBackColor = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(3, 6);
            this.label46.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(133, 19);
            this.label46.TabIndex = 0;
            this.label46.Text = "Recurring Invoice #";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(3, 38);
            this.label47.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(90, 19);
            this.label47.TabIndex = 1;
            this.label47.Text = "Invoice Date";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(3, 70);
            this.label48.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(70, 19);
            this.label48.TabIndex = 2;
            this.label48.Text = "Due Date";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(3, 102);
            this.label49.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(49, 19);
            this.label49.TabIndex = 3;
            this.label49.Text = "Status";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(3, 134);
            this.label50.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(99, 19);
            this.label50.TabIndex = 4;
            this.label50.Text = "Send to Client";
            // 
            // textBox_CreateRecurringInvoice_InvoiceID
            // 
            this.textBox_CreateRecurringInvoice_InvoiceID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CreateRecurringInvoice_InvoiceID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_CreateRecurringInvoice_InvoiceID.Location = new System.Drawing.Point(260, 6);
            this.textBox_CreateRecurringInvoice_InvoiceID.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox_CreateRecurringInvoice_InvoiceID.Name = "textBox_CreateRecurringInvoice_InvoiceID";
            this.textBox_CreateRecurringInvoice_InvoiceID.ReadOnly = true;
            this.textBox_CreateRecurringInvoice_InvoiceID.Size = new System.Drawing.Size(142, 20);
            this.textBox_CreateRecurringInvoice_InvoiceID.TabIndex = 5;
            // 
            // dateTimePicker_CreateRecurringInvoice_DueDate
            // 
            this.dateTimePicker_CreateRecurringInvoice_DueDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker_CreateRecurringInvoice_DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_CreateRecurringInvoice_DueDate.Location = new System.Drawing.Point(260, 67);
            this.dateTimePicker_CreateRecurringInvoice_DueDate.Name = "dateTimePicker_CreateRecurringInvoice_DueDate";
            this.dateTimePicker_CreateRecurringInvoice_DueDate.Size = new System.Drawing.Size(142, 27);
            this.dateTimePicker_CreateRecurringInvoice_DueDate.TabIndex = 7;
            // 
            // comboBox_CreateRecurringInvoice_Status
            // 
            this.comboBox_CreateRecurringInvoice_Status.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_CreateRecurringInvoice_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CreateRecurringInvoice_Status.FormattingEnabled = true;
            this.comboBox_CreateRecurringInvoice_Status.Location = new System.Drawing.Point(260, 99);
            this.comboBox_CreateRecurringInvoice_Status.Name = "comboBox_CreateRecurringInvoice_Status";
            this.comboBox_CreateRecurringInvoice_Status.Size = new System.Drawing.Size(142, 27);
            this.comboBox_CreateRecurringInvoice_Status.TabIndex = 8;
            // 
            // dateTimePicker_CreateRecurringInvoice_InvoiceDate
            // 
            this.dateTimePicker_CreateRecurringInvoice_InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_CreateRecurringInvoice_InvoiceDate.Location = new System.Drawing.Point(260, 35);
            this.dateTimePicker_CreateRecurringInvoice_InvoiceDate.Name = "dateTimePicker_CreateRecurringInvoice_InvoiceDate";
            this.dateTimePicker_CreateRecurringInvoice_InvoiceDate.Size = new System.Drawing.Size(142, 27);
            this.dateTimePicker_CreateRecurringInvoice_InvoiceDate.TabIndex = 10;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(3, 166);
            this.label81.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(217, 19);
            this.label81.TabIndex = 12;
            this.label81.Text = "Create next invoice every (days)";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(3, 198);
            this.label100.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(186, 19);
            this.label100.TabIndex = 13;
            this.label100.Text = "Recurring invoice Due Date";
            this.toolTip1.SetToolTip(this.label100, "Days from issue");
            // 
            // numericUpDown_CreateRecurringInvoice_NextDays
            // 
            this.numericUpDown_CreateRecurringInvoice_NextDays.Location = new System.Drawing.Point(260, 163);
            this.numericUpDown_CreateRecurringInvoice_NextDays.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_CreateRecurringInvoice_NextDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_CreateRecurringInvoice_NextDays.Name = "numericUpDown_CreateRecurringInvoice_NextDays";
            this.numericUpDown_CreateRecurringInvoice_NextDays.Size = new System.Drawing.Size(64, 27);
            this.numericUpDown_CreateRecurringInvoice_NextDays.TabIndex = 14;
            this.numericUpDown_CreateRecurringInvoice_NextDays.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numericUpDown_CreateRecurringInvoice_DueDays
            // 
            this.numericUpDown_CreateRecurringInvoice_DueDays.Location = new System.Drawing.Point(260, 195);
            this.numericUpDown_CreateRecurringInvoice_DueDays.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_CreateRecurringInvoice_DueDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_CreateRecurringInvoice_DueDays.Name = "numericUpDown_CreateRecurringInvoice_DueDays";
            this.numericUpDown_CreateRecurringInvoice_DueDays.Size = new System.Drawing.Size(64, 27);
            this.numericUpDown_CreateRecurringInvoice_DueDays.TabIndex = 15;
            this.numericUpDown_CreateRecurringInvoice_DueDays.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // splitContainer_CreateRecurringInvoice_Bottom
            // 
            this.splitContainer_CreateRecurringInvoice_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_CreateRecurringInvoice_Bottom.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_CreateRecurringInvoice_Bottom.IsSplitterFixed = true;
            this.splitContainer_CreateRecurringInvoice_Bottom.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_CreateRecurringInvoice_Bottom.Name = "splitContainer_CreateRecurringInvoice_Bottom";
            this.splitContainer_CreateRecurringInvoice_Bottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_CreateRecurringInvoice_Bottom.Panel1
            // 
            this.splitContainer_CreateRecurringInvoice_Bottom.Panel1.Controls.Add(this.groupBox16);
            this.splitContainer_CreateRecurringInvoice_Bottom.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer_CreateRecurringInvoice_Bottom.Panel2
            // 
            this.splitContainer_CreateRecurringInvoice_Bottom.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer_CreateRecurringInvoice_Bottom.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_CreateRecurringInvoice_Bottom.Size = new System.Drawing.Size(916, 339);
            this.splitContainer_CreateRecurringInvoice_Bottom.SplitterDistance = 168;
            this.splitContainer_CreateRecurringInvoice_Bottom.TabIndex = 0;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.gridView_CreateRecurringInvoice_InvoiceItem);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox16.Location = new System.Drawing.Point(0, 0);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(916, 168);
            this.groupBox16.TabIndex = 3;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Invoice Item";
            // 
            // gridView_CreateRecurringInvoice_InvoiceItem
            // 
            this.gridView_CreateRecurringInvoice_InvoiceItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_CreateRecurringInvoice_InvoiceItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Description,
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Quantity,
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_UnitPrice,
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Total});
            this.gridView_CreateRecurringInvoice_InvoiceItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView_CreateRecurringInvoice_InvoiceItem.Location = new System.Drawing.Point(3, 23);
            this.gridView_CreateRecurringInvoice_InvoiceItem.Name = "gridView_CreateRecurringInvoice_InvoiceItem";
            this.gridView_CreateRecurringInvoice_InvoiceItem.Size = new System.Drawing.Size(910, 142);
            this.gridView_CreateRecurringInvoice_InvoiceItem.TabIndex = 1;
            this.gridView_CreateRecurringInvoice_InvoiceItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CreateRecurringInvoice_InvoiceItem_CellValueChanged);
            // 
            // dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Description
            // 
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Description.HeaderText = "Description";
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Description.Name = "dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Description";
            // 
            // dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Quantity
            // 
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Quantity.HeaderText = "Qty";
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Quantity.Name = "dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Quantity";
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Quantity.Width = 150;
            // 
            // dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_UnitPrice
            // 
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_UnitPrice.HeaderText = "Unit Price";
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_UnitPrice.Name = "dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_UnitPrice";
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_UnitPrice.Width = 150;
            // 
            // dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Total
            // 
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Total.HeaderText = "Total";
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Total.Name = "dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Total";
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Total.ReadOnly = true;
            this.dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Total.Width = 150;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.splitContainer6);
            this.splitContainer5.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.button7);
            this.splitContainer5.Panel2.Controls.Add(this.button8);
            this.splitContainer5.Panel2.Controls.Add(this.button_CreateRecurringInvoice_SaveInvoice);
            this.splitContainer5.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer5.Size = new System.Drawing.Size(916, 167);
            this.splitContainer5.SplitterDistance = 130;
            this.splitContainer5.TabIndex = 3;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.groupBox17);
            this.splitContainer6.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.groupBox7);
            this.splitContainer6.Panel2.Controls.Add(this.button6);
            this.splitContainer6.Panel2.Controls.Add(this.button5);
            this.splitContainer6.Panel2.Controls.Add(this.button4);
            this.splitContainer6.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer6.Size = new System.Drawing.Size(916, 130);
            this.splitContainer6.SplitterDistance = 640;
            this.splitContainer6.TabIndex = 1;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.textBox_CreateRecurringInvoice_Comments);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox17.Location = new System.Drawing.Point(0, 0);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(640, 130);
            this.groupBox17.TabIndex = 4;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Comment";
            // 
            // textBox_CreateRecurringInvoice_Comments
            // 
            this.textBox_CreateRecurringInvoice_Comments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_CreateRecurringInvoice_Comments.Location = new System.Drawing.Point(3, 23);
            this.textBox_CreateRecurringInvoice_Comments.Multiline = true;
            this.textBox_CreateRecurringInvoice_Comments.Name = "textBox_CreateRecurringInvoice_Comments";
            this.textBox_CreateRecurringInvoice_Comments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_CreateRecurringInvoice_Comments.Size = new System.Drawing.Size(634, 104);
            this.textBox_CreateRecurringInvoice_Comments.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel3);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(272, 130);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Totals";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.36636F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.63363F));
            this.tableLayoutPanel3.Controls.Add(this.label35, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_CreateRecurringInvoice_Total, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox_CreateRecurringInvoice_SubTotal, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox_CreateRecurringInvoice_VAT_Value, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox_CreateRecurringInvoice_GrandTotal, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(266, 104);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(98, 6);
            this.label35.Margin = new System.Windows.Forms.Padding(3, 6, 9, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(69, 19);
            this.label35.TabIndex = 0;
            this.label35.Text = "Sub-Total";
            // 
            // label_CreateRecurringInvoice_Total
            // 
            this.label_CreateRecurringInvoice_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CreateRecurringInvoice_Total.AutoSize = true;
            this.label_CreateRecurringInvoice_Total.Location = new System.Drawing.Point(126, 74);
            this.label_CreateRecurringInvoice_Total.Margin = new System.Windows.Forms.Padding(3, 6, 9, 0);
            this.label_CreateRecurringInvoice_Total.Name = "label_CreateRecurringInvoice_Total";
            this.label_CreateRecurringInvoice_Total.Size = new System.Drawing.Size(41, 19);
            this.label_CreateRecurringInvoice_Total.TabIndex = 2;
            this.label_CreateRecurringInvoice_Total.Text = "Total";
            // 
            // textBox_CreateRecurringInvoice_SubTotal
            // 
            this.textBox_CreateRecurringInvoice_SubTotal.Location = new System.Drawing.Point(179, 3);
            this.textBox_CreateRecurringInvoice_SubTotal.Name = "textBox_CreateRecurringInvoice_SubTotal";
            this.textBox_CreateRecurringInvoice_SubTotal.Size = new System.Drawing.Size(84, 27);
            this.textBox_CreateRecurringInvoice_SubTotal.TabIndex = 3;
            this.textBox_CreateRecurringInvoice_SubTotal.TextChanged += new System.EventHandler(this.textBox_CreateRecurringInvoice_SubTotal_TextChanged);
            // 
            // textBox_CreateRecurringInvoice_VAT_Value
            // 
            this.textBox_CreateRecurringInvoice_VAT_Value.Location = new System.Drawing.Point(179, 37);
            this.textBox_CreateRecurringInvoice_VAT_Value.Name = "textBox_CreateRecurringInvoice_VAT_Value";
            this.textBox_CreateRecurringInvoice_VAT_Value.Size = new System.Drawing.Size(84, 27);
            this.textBox_CreateRecurringInvoice_VAT_Value.TabIndex = 4;
            // 
            // textBox_CreateRecurringInvoice_GrandTotal
            // 
            this.textBox_CreateRecurringInvoice_GrandTotal.Location = new System.Drawing.Point(179, 71);
            this.textBox_CreateRecurringInvoice_GrandTotal.Name = "textBox_CreateRecurringInvoice_GrandTotal";
            this.textBox_CreateRecurringInvoice_GrandTotal.Size = new System.Drawing.Size(84, 27);
            this.textBox_CreateRecurringInvoice_GrandTotal.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.label36);
            this.flowLayoutPanel3.Controls.Add(this.numericUpDown_CreateRecurringInvoice_VAT_Percent);
            this.flowLayoutPanel3.Controls.Add(this.label38);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(37, 34);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(139, 33);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(3, 6);
            this.label36.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(33, 19);
            this.label36.TabIndex = 0;
            this.label36.Text = "VAT";
            // 
            // numericUpDown_CreateRecurringInvoice_VAT_Percent
            // 
            this.numericUpDown_CreateRecurringInvoice_VAT_Percent.Location = new System.Drawing.Point(42, 3);
            this.numericUpDown_CreateRecurringInvoice_VAT_Percent.Name = "numericUpDown_CreateRecurringInvoice_VAT_Percent";
            this.numericUpDown_CreateRecurringInvoice_VAT_Percent.Size = new System.Drawing.Size(62, 27);
            this.numericUpDown_CreateRecurringInvoice_VAT_Percent.TabIndex = 3;
            this.numericUpDown_CreateRecurringInvoice_VAT_Percent.ValueChanged += new System.EventHandler(this.numericUpDown_CreateRecurringInvoice_VAT_Percent_ValueChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(110, 6);
            this.label38.Margin = new System.Windows.Forms.Padding(3, 6, 9, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(20, 19);
            this.label38.TabIndex = 2;
            this.label38.Text = "%";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(543, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 26);
            this.button6.TabIndex = 2;
            this.button6.Text = "View as PDF";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(669, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 26);
            this.button5.TabIndex = 1;
            this.button5.Text = "Send eMail";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(795, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 26);
            this.button4.TabIndex = 0;
            this.button4.Text = "Save Invoice";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(543, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 26);
            this.button7.TabIndex = 2;
            this.button7.Text = "View as PDF";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(669, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 26);
            this.button8.TabIndex = 1;
            this.button8.Text = "Send eMail";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button_CreateRecurringInvoice_SaveInvoice
            // 
            this.button_CreateRecurringInvoice_SaveInvoice.Location = new System.Drawing.Point(795, 2);
            this.button_CreateRecurringInvoice_SaveInvoice.Name = "button_CreateRecurringInvoice_SaveInvoice";
            this.button_CreateRecurringInvoice_SaveInvoice.Size = new System.Drawing.Size(120, 26);
            this.button_CreateRecurringInvoice_SaveInvoice.TabIndex = 0;
            this.button_CreateRecurringInvoice_SaveInvoice.Text = "Save Invoice";
            this.button_CreateRecurringInvoice_SaveInvoice.UseVisualStyleBackColor = true;
            this.button_CreateRecurringInvoice_SaveInvoice.Click += new System.EventHandler(this.button_CreateRecurringInvoice_SaveInvoice_Click);
            // 
            // tabPage_Invoices_PendingInvoices
            // 
            this.tabPage_Invoices_PendingInvoices.Controls.Add(this.splitContainer7);
            this.tabPage_Invoices_PendingInvoices.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Invoices_PendingInvoices.Name = "tabPage_Invoices_PendingInvoices";
            this.tabPage_Invoices_PendingInvoices.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Invoices_PendingInvoices.TabIndex = 4;
            this.tabPage_Invoices_PendingInvoices.Text = "Pending Invoices";
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer7.IsSplitterFixed = true;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.AutoScroll = true;
            this.splitContainer7.Panel1.Controls.Add(this.groupBox19);
            this.splitContainer7.Panel1.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer7.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer7.Panel1MinSize = 100;
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.groupBox20);
            this.splitContainer7.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer7.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer7.Size = new System.Drawing.Size(922, 609);
            this.splitContainer7.SplitterDistance = 110;
            this.splitContainer7.TabIndex = 4;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.tableLayoutPanel6);
            this.groupBox19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox19.Location = new System.Drawing.Point(6, 6);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.groupBox19.Size = new System.Drawing.Size(910, 98);
            this.groupBox19.TabIndex = 1;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Search Invoice";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 6;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.Controls.Add(this.textBox_PendingInvoices_InvoiceID, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label45, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label51, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.comboBox_PendingInvoices_Client, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label53, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label54, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.dateTimePicker_PendingInvoices_DateFrom, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.dateTimePicker_PendingInvoices_DateTo, 3, 1);
            this.tableLayoutPanel6.Controls.Add(this.button_PendingInvoices_Search, 4, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(6, 23);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(898, 72);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // textBox_PendingInvoices_InvoiceID
            // 
            this.textBox_PendingInvoices_InvoiceID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_PendingInvoices_InvoiceID.Location = new System.Drawing.Point(6, 33);
            this.textBox_PendingInvoices_InvoiceID.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBox_PendingInvoices_InvoiceID.Name = "textBox_PendingInvoices_InvoiceID";
            this.textBox_PendingInvoices_InvoiceID.Size = new System.Drawing.Size(140, 20);
            this.textBox_PendingInvoices_InvoiceID.TabIndex = 15;
            // 
            // label45
            // 
            this.label45.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(3, 17);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(52, 13);
            this.label45.TabIndex = 0;
            this.label45.Text = "Invoice #";
            // 
            // label51
            // 
            this.label51.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(155, 17);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(33, 13);
            this.label51.TabIndex = 2;
            this.label51.Text = "Client";
            // 
            // comboBox_PendingInvoices_Client
            // 
            this.comboBox_PendingInvoices_Client.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_PendingInvoices_Client.FormattingEnabled = true;
            this.comboBox_PendingInvoices_Client.Location = new System.Drawing.Point(158, 33);
            this.comboBox_PendingInvoices_Client.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.comboBox_PendingInvoices_Client.Name = "comboBox_PendingInvoices_Client";
            this.comboBox_PendingInvoices_Client.Size = new System.Drawing.Size(140, 21);
            this.comboBox_PendingInvoices_Client.TabIndex = 20;
            // 
            // label53
            // 
            this.label53.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(307, 17);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(53, 13);
            this.label53.TabIndex = 18;
            this.label53.Text = "Date from";
            // 
            // label54
            // 
            this.label54.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(459, 17);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(42, 13);
            this.label54.TabIndex = 19;
            this.label54.Text = "Date to";
            // 
            // dateTimePicker_PendingInvoices_DateFrom
            // 
            this.dateTimePicker_PendingInvoices_DateFrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker_PendingInvoices_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_PendingInvoices_DateFrom.Location = new System.Drawing.Point(310, 33);
            this.dateTimePicker_PendingInvoices_DateFrom.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dateTimePicker_PendingInvoices_DateFrom.Name = "dateTimePicker_PendingInvoices_DateFrom";
            this.dateTimePicker_PendingInvoices_DateFrom.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker_PendingInvoices_DateFrom.TabIndex = 22;
            // 
            // dateTimePicker_PendingInvoices_DateTo
            // 
            this.dateTimePicker_PendingInvoices_DateTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker_PendingInvoices_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_PendingInvoices_DateTo.Location = new System.Drawing.Point(462, 33);
            this.dateTimePicker_PendingInvoices_DateTo.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dateTimePicker_PendingInvoices_DateTo.Name = "dateTimePicker_PendingInvoices_DateTo";
            this.dateTimePicker_PendingInvoices_DateTo.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker_PendingInvoices_DateTo.TabIndex = 23;
            // 
            // button_PendingInvoices_Search
            // 
            this.button_PendingInvoices_Search.Location = new System.Drawing.Point(611, 32);
            this.button_PendingInvoices_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.button_PendingInvoices_Search.Name = "button_PendingInvoices_Search";
            this.button_PendingInvoices_Search.Size = new System.Drawing.Size(90, 29);
            this.button_PendingInvoices_Search.TabIndex = 14;
            this.button_PendingInvoices_Search.Text = "Search";
            this.button_PendingInvoices_Search.UseVisualStyleBackColor = true;
            this.button_PendingInvoices_Search.Click += new System.EventHandler(this.button_PendingInvoices_Search_Click);
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.splitContainer8);
            this.groupBox20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox20.Location = new System.Drawing.Point(6, 6);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Padding = new System.Windows.Forms.Padding(9, 0, 9, 9);
            this.groupBox20.Size = new System.Drawing.Size(910, 483);
            this.groupBox20.TabIndex = 1;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Invoices";
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer8.IsSplitterFixed = true;
            this.splitContainer8.Location = new System.Drawing.Point(9, 20);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.label_PendingInvoices_Result);
            this.splitContainer8.Panel1.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer8.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.dataGridView_PendingInvoices);
            this.splitContainer8.Panel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer8.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer8.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer8.Size = new System.Drawing.Size(892, 454);
            this.splitContainer8.SplitterDistance = 25;
            this.splitContainer8.TabIndex = 0;
            // 
            // label_PendingInvoices_Result
            // 
            this.label_PendingInvoices_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PendingInvoices_Result.AutoSize = true;
            this.label_PendingInvoices_Result.Location = new System.Drawing.Point(3, 6);
            this.label_PendingInvoices_Result.Name = "label_PendingInvoices_Result";
            this.label_PendingInvoices_Result.Size = new System.Drawing.Size(60, 13);
            this.label_PendingInvoices_Result.TabIndex = 0;
            this.label_PendingInvoices_Result.Text = "[0] Invoice.";
            // 
            // dataGridView_PendingInvoices
            // 
            this.dataGridView_PendingInvoices.AllowUserToAddRows = false;
            this.dataGridView_PendingInvoices.AllowUserToDeleteRows = false;
            this.dataGridView_PendingInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PendingInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewColumn_PendingInvoices_InvoiceID,
            this.dataGridViewColumn_PendingInvoices_Company,
            this.dataGridViewColumn_PendingInvoices_Comment,
            this.dataGridViewColumn_PendingInvoices_Amount,
            this.dataGridViewColumn_PendingInvoices_Created,
            this.dataGridViewColumn_PendingInvoices_DueDate,
            this.dataGridViewColumn_PendingInvoices_Status,
            this.dataGridViewColumn_PendingInvoices_View,
            this.dataGridViewColumn_PendingInvoices_Edit,
            this.dataGridViewColumn_PendingInvoices_Delete});
            this.dataGridView_PendingInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_PendingInvoices.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_PendingInvoices.Name = "dataGridView_PendingInvoices";
            this.dataGridView_PendingInvoices.ReadOnly = true;
            this.dataGridView_PendingInvoices.RowHeadersVisible = false;
            this.dataGridView_PendingInvoices.Size = new System.Drawing.Size(880, 413);
            this.dataGridView_PendingInvoices.TabIndex = 1;
            // 
            // dataGridViewColumn_PendingInvoices_InvoiceID
            // 
            this.dataGridViewColumn_PendingInvoices_InvoiceID.HeaderText = "Invoice #";
            this.dataGridViewColumn_PendingInvoices_InvoiceID.Name = "dataGridViewColumn_PendingInvoices_InvoiceID";
            this.dataGridViewColumn_PendingInvoices_InvoiceID.ReadOnly = true;
            this.dataGridViewColumn_PendingInvoices_InvoiceID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumn_PendingInvoices_InvoiceID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewColumn_PendingInvoices_Company
            // 
            this.dataGridViewColumn_PendingInvoices_Company.HeaderText = "Company";
            this.dataGridViewColumn_PendingInvoices_Company.Name = "dataGridViewColumn_PendingInvoices_Company";
            this.dataGridViewColumn_PendingInvoices_Company.ReadOnly = true;
            this.dataGridViewColumn_PendingInvoices_Company.Width = 110;
            // 
            // dataGridViewColumn_PendingInvoices_Comment
            // 
            this.dataGridViewColumn_PendingInvoices_Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumn_PendingInvoices_Comment.HeaderText = "Comment";
            this.dataGridViewColumn_PendingInvoices_Comment.Name = "dataGridViewColumn_PendingInvoices_Comment";
            this.dataGridViewColumn_PendingInvoices_Comment.ReadOnly = true;
            // 
            // dataGridViewColumn_PendingInvoices_Amount
            // 
            this.dataGridViewColumn_PendingInvoices_Amount.HeaderText = "Amount";
            this.dataGridViewColumn_PendingInvoices_Amount.Name = "dataGridViewColumn_PendingInvoices_Amount";
            this.dataGridViewColumn_PendingInvoices_Amount.ReadOnly = true;
            // 
            // dataGridViewColumn_PendingInvoices_Created
            // 
            this.dataGridViewColumn_PendingInvoices_Created.HeaderText = "Created";
            this.dataGridViewColumn_PendingInvoices_Created.Name = "dataGridViewColumn_PendingInvoices_Created";
            this.dataGridViewColumn_PendingInvoices_Created.ReadOnly = true;
            // 
            // dataGridViewColumn_PendingInvoices_DueDate
            // 
            this.dataGridViewColumn_PendingInvoices_DueDate.HeaderText = "Due Date";
            this.dataGridViewColumn_PendingInvoices_DueDate.Name = "dataGridViewColumn_PendingInvoices_DueDate";
            this.dataGridViewColumn_PendingInvoices_DueDate.ReadOnly = true;
            // 
            // dataGridViewColumn_PendingInvoices_Status
            // 
            this.dataGridViewColumn_PendingInvoices_Status.HeaderText = "Status";
            this.dataGridViewColumn_PendingInvoices_Status.Name = "dataGridViewColumn_PendingInvoices_Status";
            this.dataGridViewColumn_PendingInvoices_Status.ReadOnly = true;
            this.dataGridViewColumn_PendingInvoices_Status.Width = 90;
            // 
            // dataGridViewColumn_PendingInvoices_View
            // 
            this.dataGridViewColumn_PendingInvoices_View.HeaderText = "";
            this.dataGridViewColumn_PendingInvoices_View.Name = "dataGridViewColumn_PendingInvoices_View";
            this.dataGridViewColumn_PendingInvoices_View.ReadOnly = true;
            this.dataGridViewColumn_PendingInvoices_View.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumn_PendingInvoices_View.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewColumn_PendingInvoices_View.Width = 50;
            // 
            // dataGridViewColumn_PendingInvoices_Edit
            // 
            this.dataGridViewColumn_PendingInvoices_Edit.HeaderText = "";
            this.dataGridViewColumn_PendingInvoices_Edit.Name = "dataGridViewColumn_PendingInvoices_Edit";
            this.dataGridViewColumn_PendingInvoices_Edit.ReadOnly = true;
            this.dataGridViewColumn_PendingInvoices_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumn_PendingInvoices_Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewColumn_PendingInvoices_Edit.Width = 50;
            // 
            // dataGridViewColumn_PendingInvoices_Delete
            // 
            this.dataGridViewColumn_PendingInvoices_Delete.HeaderText = "";
            this.dataGridViewColumn_PendingInvoices_Delete.Name = "dataGridViewColumn_PendingInvoices_Delete";
            this.dataGridViewColumn_PendingInvoices_Delete.ReadOnly = true;
            this.dataGridViewColumn_PendingInvoices_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumn_PendingInvoices_Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewColumn_PendingInvoices_Delete.Width = 60;
            // 
            // tabPage_Invoices_RecurringInvoices
            // 
            this.tabPage_Invoices_RecurringInvoices.Controls.Add(this.splitContainer9);
            this.tabPage_Invoices_RecurringInvoices.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage_Invoices_RecurringInvoices.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Invoices_RecurringInvoices.Name = "tabPage_Invoices_RecurringInvoices";
            this.tabPage_Invoices_RecurringInvoices.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Invoices_RecurringInvoices.TabIndex = 5;
            this.tabPage_Invoices_RecurringInvoices.Text = "Recurring Invoices";
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer9.IsSplitterFixed = true;
            this.splitContainer9.Location = new System.Drawing.Point(0, 0);
            this.splitContainer9.Name = "splitContainer9";
            this.splitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.AutoScroll = true;
            this.splitContainer9.Panel1.Controls.Add(this.groupBox21);
            this.splitContainer9.Panel1.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer9.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer9.Panel1MinSize = 100;
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.groupBox22);
            this.splitContainer9.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer9.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer9.Size = new System.Drawing.Size(922, 609);
            this.splitContainer9.SplitterDistance = 110;
            this.splitContainer9.TabIndex = 4;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.tableLayoutPanel8);
            this.groupBox21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox21.Location = new System.Drawing.Point(6, 6);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.groupBox21.Size = new System.Drawing.Size(910, 98);
            this.groupBox21.TabIndex = 1;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Search Recurring Invoice";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.Controls.Add(this.label62, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.button_RecurringInvoices_Search, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.comboBox_RecurringInvoices_Client, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(6, 23);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(898, 72);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // label62
            // 
            this.label62.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(3, 17);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(33, 13);
            this.label62.TabIndex = 2;
            this.label62.Text = "Client";
            // 
            // button_RecurringInvoices_Search
            // 
            this.button_RecurringInvoices_Search.Location = new System.Drawing.Point(155, 32);
            this.button_RecurringInvoices_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.button_RecurringInvoices_Search.Name = "button_RecurringInvoices_Search";
            this.button_RecurringInvoices_Search.Size = new System.Drawing.Size(80, 28);
            this.button_RecurringInvoices_Search.TabIndex = 14;
            this.button_RecurringInvoices_Search.Text = "Search";
            this.button_RecurringInvoices_Search.UseVisualStyleBackColor = true;
            this.button_RecurringInvoices_Search.Click += new System.EventHandler(this.button_RecurringInvoices_Search_Click);
            // 
            // comboBox_RecurringInvoices_Client
            // 
            this.comboBox_RecurringInvoices_Client.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_RecurringInvoices_Client.FormattingEnabled = true;
            this.comboBox_RecurringInvoices_Client.Location = new System.Drawing.Point(6, 33);
            this.comboBox_RecurringInvoices_Client.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.comboBox_RecurringInvoices_Client.Name = "comboBox_RecurringInvoices_Client";
            this.comboBox_RecurringInvoices_Client.Size = new System.Drawing.Size(140, 21);
            this.comboBox_RecurringInvoices_Client.TabIndex = 20;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.splitContainer10);
            this.groupBox22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox22.Location = new System.Drawing.Point(6, 6);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Padding = new System.Windows.Forms.Padding(9, 0, 9, 9);
            this.groupBox22.Size = new System.Drawing.Size(910, 483);
            this.groupBox22.TabIndex = 0;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Recurring Invoices";
            // 
            // splitContainer10
            // 
            this.splitContainer10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer10.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer10.IsSplitterFixed = true;
            this.splitContainer10.Location = new System.Drawing.Point(9, 20);
            this.splitContainer10.Name = "splitContainer10";
            this.splitContainer10.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer10.Panel1
            // 
            this.splitContainer10.Panel1.Controls.Add(this.label_RecurringInvoices_Result);
            this.splitContainer10.Panel1.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer10.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer10.Panel2
            // 
            this.splitContainer10.Panel2.Controls.Add(this.dataGridView_RecurringInvoices);
            this.splitContainer10.Panel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer10.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer10.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer10.Size = new System.Drawing.Size(892, 454);
            this.splitContainer10.SplitterDistance = 25;
            this.splitContainer10.TabIndex = 0;
            // 
            // label_RecurringInvoices_Result
            // 
            this.label_RecurringInvoices_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_RecurringInvoices_Result.AutoSize = true;
            this.label_RecurringInvoices_Result.Location = new System.Drawing.Point(3, 6);
            this.label_RecurringInvoices_Result.Name = "label_RecurringInvoices_Result";
            this.label_RecurringInvoices_Result.Size = new System.Drawing.Size(109, 13);
            this.label_RecurringInvoices_Result.TabIndex = 0;
            this.label_RecurringInvoices_Result.Text = "[0] Recurring Invoice.";
            // 
            // dataGridView_RecurringInvoices
            // 
            this.dataGridView_RecurringInvoices.AllowUserToAddRows = false;
            this.dataGridView_RecurringInvoices.AllowUserToDeleteRows = false;
            this.dataGridView_RecurringInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RecurringInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewColumn_RecurringInvoices_InvoiceID,
            this.dataGridViewColumn_RecurringInvoices_Company,
            this.dataGridViewColumn_RecurringInvoices_Comment,
            this.dataGridViewColumn_RecurringInvoices_Amount,
            this.dataGridViewColumn_RecurringInvoices_Created,
            this.dataGridViewColumn_RecurringInvoices_NextDays,
            this.dataGridViewColumn_RecurringInvoices_DueDays,
            this.dataGridViewColumn_RecurringInvoices_View,
            this.dataGridViewColumn_RecurringInvoices_Print,
            this.dataGridViewColumn_RecurringInvoices_Delete});
            this.dataGridView_RecurringInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_RecurringInvoices.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_RecurringInvoices.Name = "dataGridView_RecurringInvoices";
            this.dataGridView_RecurringInvoices.ReadOnly = true;
            this.dataGridView_RecurringInvoices.RowHeadersVisible = false;
            this.dataGridView_RecurringInvoices.Size = new System.Drawing.Size(880, 413);
            this.dataGridView_RecurringInvoices.TabIndex = 1;
            this.dataGridView_RecurringInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RecurringInvoices_CellClick);
            // 
            // dataGridViewColumn_RecurringInvoices_InvoiceID
            // 
            this.dataGridViewColumn_RecurringInvoices_InvoiceID.HeaderText = "Invoice #";
            this.dataGridViewColumn_RecurringInvoices_InvoiceID.Name = "dataGridViewColumn_RecurringInvoices_InvoiceID";
            this.dataGridViewColumn_RecurringInvoices_InvoiceID.ReadOnly = true;
            // 
            // dataGridViewColumn_RecurringInvoices_Company
            // 
            this.dataGridViewColumn_RecurringInvoices_Company.HeaderText = "Company";
            this.dataGridViewColumn_RecurringInvoices_Company.Name = "dataGridViewColumn_RecurringInvoices_Company";
            this.dataGridViewColumn_RecurringInvoices_Company.ReadOnly = true;
            // 
            // dataGridViewColumn_RecurringInvoices_Comment
            // 
            this.dataGridViewColumn_RecurringInvoices_Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumn_RecurringInvoices_Comment.HeaderText = "Comment";
            this.dataGridViewColumn_RecurringInvoices_Comment.Name = "dataGridViewColumn_RecurringInvoices_Comment";
            this.dataGridViewColumn_RecurringInvoices_Comment.ReadOnly = true;
            // 
            // dataGridViewColumn_RecurringInvoices_Amount
            // 
            this.dataGridViewColumn_RecurringInvoices_Amount.HeaderText = "Amount";
            this.dataGridViewColumn_RecurringInvoices_Amount.Name = "dataGridViewColumn_RecurringInvoices_Amount";
            this.dataGridViewColumn_RecurringInvoices_Amount.ReadOnly = true;
            // 
            // dataGridViewColumn_RecurringInvoices_Created
            // 
            this.dataGridViewColumn_RecurringInvoices_Created.HeaderText = "Created";
            this.dataGridViewColumn_RecurringInvoices_Created.Name = "dataGridViewColumn_RecurringInvoices_Created";
            this.dataGridViewColumn_RecurringInvoices_Created.ReadOnly = true;
            // 
            // dataGridViewColumn_RecurringInvoices_NextDays
            // 
            this.dataGridViewColumn_RecurringInvoices_NextDays.HeaderText = "Next Days";
            this.dataGridViewColumn_RecurringInvoices_NextDays.Name = "dataGridViewColumn_RecurringInvoices_NextDays";
            this.dataGridViewColumn_RecurringInvoices_NextDays.ReadOnly = true;
            // 
            // dataGridViewColumn_RecurringInvoices_DueDays
            // 
            this.dataGridViewColumn_RecurringInvoices_DueDays.HeaderText = "Due Days";
            this.dataGridViewColumn_RecurringInvoices_DueDays.Name = "dataGridViewColumn_RecurringInvoices_DueDays";
            this.dataGridViewColumn_RecurringInvoices_DueDays.ReadOnly = true;
            // 
            // dataGridViewColumn_RecurringInvoices_View
            // 
            this.dataGridViewColumn_RecurringInvoices_View.HeaderText = "";
            this.dataGridViewColumn_RecurringInvoices_View.Name = "dataGridViewColumn_RecurringInvoices_View";
            this.dataGridViewColumn_RecurringInvoices_View.ReadOnly = true;
            this.dataGridViewColumn_RecurringInvoices_View.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumn_RecurringInvoices_View.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewColumn_RecurringInvoices_View.Width = 50;
            // 
            // dataGridViewColumn_RecurringInvoices_Print
            // 
            this.dataGridViewColumn_RecurringInvoices_Print.HeaderText = "";
            this.dataGridViewColumn_RecurringInvoices_Print.Name = "dataGridViewColumn_RecurringInvoices_Print";
            this.dataGridViewColumn_RecurringInvoices_Print.ReadOnly = true;
            this.dataGridViewColumn_RecurringInvoices_Print.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumn_RecurringInvoices_Print.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewColumn_RecurringInvoices_Print.Width = 50;
            // 
            // dataGridViewColumn_RecurringInvoices_Delete
            // 
            this.dataGridViewColumn_RecurringInvoices_Delete.HeaderText = "";
            this.dataGridViewColumn_RecurringInvoices_Delete.Name = "dataGridViewColumn_RecurringInvoices_Delete";
            this.dataGridViewColumn_RecurringInvoices_Delete.ReadOnly = true;
            this.dataGridViewColumn_RecurringInvoices_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumn_RecurringInvoices_Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewColumn_RecurringInvoices_Delete.Width = 60;
            // 
            // tabPage_Invoices_EditRecurringInvoice
            // 
            this.tabPage_Invoices_EditRecurringInvoice.Controls.Add(this.splitContainer_EditRecurringInvoice_Root);
            this.tabPage_Invoices_EditRecurringInvoice.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Invoices_EditRecurringInvoice.Name = "tabPage_Invoices_EditRecurringInvoice";
            this.tabPage_Invoices_EditRecurringInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Invoices_EditRecurringInvoice.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Invoices_EditRecurringInvoice.TabIndex = 7;
            this.tabPage_Invoices_EditRecurringInvoice.Text = "Edit Recurring Invoice";
            // 
            // splitContainer_EditRecurringInvoice_Root
            // 
            this.splitContainer_EditRecurringInvoice_Root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_EditRecurringInvoice_Root.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_EditRecurringInvoice_Root.IsSplitterFixed = true;
            this.splitContainer_EditRecurringInvoice_Root.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_EditRecurringInvoice_Root.Name = "splitContainer_EditRecurringInvoice_Root";
            this.splitContainer_EditRecurringInvoice_Root.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_EditRecurringInvoice_Root.Panel1
            // 
            this.splitContainer_EditRecurringInvoice_Root.Panel1.AutoScroll = true;
            this.splitContainer_EditRecurringInvoice_Root.Panel1.Controls.Add(this.splitContainer_EditRecurringInvoice_Client);
            this.splitContainer_EditRecurringInvoice_Root.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer_EditRecurringInvoice_Root.Panel2
            // 
            this.splitContainer_EditRecurringInvoice_Root.Panel2.Controls.Add(this.splitContainer22);
            this.splitContainer_EditRecurringInvoice_Root.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_EditRecurringInvoice_Root.Size = new System.Drawing.Size(916, 603);
            this.splitContainer_EditRecurringInvoice_Root.SplitterDistance = 260;
            this.splitContainer_EditRecurringInvoice_Root.TabIndex = 4;
            // 
            // splitContainer_EditRecurringInvoice_Client
            // 
            this.splitContainer_EditRecurringInvoice_Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_EditRecurringInvoice_Client.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_EditRecurringInvoice_Client.IsSplitterFixed = true;
            this.splitContainer_EditRecurringInvoice_Client.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_EditRecurringInvoice_Client.MinimumSize = new System.Drawing.Size(780, 0);
            this.splitContainer_EditRecurringInvoice_Client.Name = "splitContainer_EditRecurringInvoice_Client";
            // 
            // splitContainer_EditRecurringInvoice_Client.Panel1
            // 
            this.splitContainer_EditRecurringInvoice_Client.Panel1.Controls.Add(this.groupBox35);
            this.splitContainer_EditRecurringInvoice_Client.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer_EditRecurringInvoice_Client.Panel2
            // 
            this.splitContainer_EditRecurringInvoice_Client.Panel2.Controls.Add(this.groupBox37);
            this.splitContainer_EditRecurringInvoice_Client.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_EditRecurringInvoice_Client.Size = new System.Drawing.Size(916, 260);
            this.splitContainer_EditRecurringInvoice_Client.SplitterDistance = 500;
            this.splitContainer_EditRecurringInvoice_Client.TabIndex = 1;
            // 
            // groupBox35
            // 
            this.groupBox35.Controls.Add(this.button_EditRecurringInvoice_ChangeClient);
            this.groupBox35.Controls.Add(this.panel_EditRecurringInvoice_SelectClient);
            this.groupBox35.Controls.Add(this.textBox_EditRecurringInvoice_ClientDetail);
            this.groupBox35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox35.Location = new System.Drawing.Point(0, 0);
            this.groupBox35.Name = "groupBox35";
            this.groupBox35.Size = new System.Drawing.Size(500, 260);
            this.groupBox35.TabIndex = 1;
            this.groupBox35.TabStop = false;
            this.groupBox35.Text = "Client";
            // 
            // button_EditRecurringInvoice_ChangeClient
            // 
            this.button_EditRecurringInvoice_ChangeClient.Location = new System.Drawing.Point(366, 220);
            this.button_EditRecurringInvoice_ChangeClient.Name = "button_EditRecurringInvoice_ChangeClient";
            this.button_EditRecurringInvoice_ChangeClient.Size = new System.Drawing.Size(122, 29);
            this.button_EditRecurringInvoice_ChangeClient.TabIndex = 6;
            this.button_EditRecurringInvoice_ChangeClient.Text = "Change Client";
            this.button_EditRecurringInvoice_ChangeClient.UseVisualStyleBackColor = true;
            this.button_EditRecurringInvoice_ChangeClient.Visible = false;
            this.button_EditRecurringInvoice_ChangeClient.Click += new System.EventHandler(this.button_EditRecurringInvoice_ChangeClient_Click);
            // 
            // panel_EditRecurringInvoice_SelectClient
            // 
            this.panel_EditRecurringInvoice_SelectClient.Controls.Add(this.button_EditRecurringInvoice_SelectClient);
            this.panel_EditRecurringInvoice_SelectClient.Controls.Add(this.comboBox_EditRecurringInvoice_SelectClient);
            this.panel_EditRecurringInvoice_SelectClient.Controls.Add(this.label117);
            this.panel_EditRecurringInvoice_SelectClient.Location = new System.Drawing.Point(6, 21);
            this.panel_EditRecurringInvoice_SelectClient.Name = "panel_EditRecurringInvoice_SelectClient";
            this.panel_EditRecurringInvoice_SelectClient.Size = new System.Drawing.Size(491, 42);
            this.panel_EditRecurringInvoice_SelectClient.TabIndex = 5;
            // 
            // button_EditRecurringInvoice_SelectClient
            // 
            this.button_EditRecurringInvoice_SelectClient.Location = new System.Drawing.Point(402, 7);
            this.button_EditRecurringInvoice_SelectClient.Name = "button_EditRecurringInvoice_SelectClient";
            this.button_EditRecurringInvoice_SelectClient.Size = new System.Drawing.Size(80, 29);
            this.button_EditRecurringInvoice_SelectClient.TabIndex = 7;
            this.button_EditRecurringInvoice_SelectClient.Text = "Done";
            this.button_EditRecurringInvoice_SelectClient.UseVisualStyleBackColor = true;
            this.button_EditRecurringInvoice_SelectClient.Click += new System.EventHandler(this.button_EditRecurringInvoice_SelectClient_Click);
            // 
            // comboBox_EditRecurringInvoice_SelectClient
            // 
            this.comboBox_EditRecurringInvoice_SelectClient.FormattingEnabled = true;
            this.comboBox_EditRecurringInvoice_SelectClient.Location = new System.Drawing.Point(99, 8);
            this.comboBox_EditRecurringInvoice_SelectClient.Name = "comboBox_EditRecurringInvoice_SelectClient";
            this.comboBox_EditRecurringInvoice_SelectClient.Size = new System.Drawing.Size(295, 21);
            this.comboBox_EditRecurringInvoice_SelectClient.TabIndex = 6;
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(2, 11);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(66, 13);
            this.label117.TabIndex = 5;
            this.label117.Text = "Select Client";
            // 
            // textBox_EditRecurringInvoice_ClientDetail
            // 
            this.textBox_EditRecurringInvoice_ClientDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EditRecurringInvoice_ClientDetail.Location = new System.Drawing.Point(13, 33);
            this.textBox_EditRecurringInvoice_ClientDetail.Multiline = true;
            this.textBox_EditRecurringInvoice_ClientDetail.Name = "textBox_EditRecurringInvoice_ClientDetail";
            this.textBox_EditRecurringInvoice_ClientDetail.ReadOnly = true;
            this.textBox_EditRecurringInvoice_ClientDetail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_EditRecurringInvoice_ClientDetail.Size = new System.Drawing.Size(356, 152);
            this.textBox_EditRecurringInvoice_ClientDetail.TabIndex = 3;
            this.textBox_EditRecurringInvoice_ClientDetail.Visible = false;
            // 
            // groupBox37
            // 
            this.groupBox37.Controls.Add(this.tableLayoutPanel16);
            this.groupBox37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox37.Location = new System.Drawing.Point(0, 0);
            this.groupBox37.Name = "groupBox37";
            this.groupBox37.Size = new System.Drawing.Size(412, 260);
            this.groupBox37.TabIndex = 2;
            this.groupBox37.TabStop = false;
            this.groupBox37.Text = "Invoice Details";
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 2;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.7037F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.2963F));
            this.tableLayoutPanel16.Controls.Add(this.flowLayoutPanel14, 1, 4);
            this.tableLayoutPanel16.Controls.Add(this.label118, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.label119, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.label120, 0, 2);
            this.tableLayoutPanel16.Controls.Add(this.label121, 0, 3);
            this.tableLayoutPanel16.Controls.Add(this.label122, 0, 4);
            this.tableLayoutPanel16.Controls.Add(this.textBox_EditRecurringInvoice_InvoiceID, 1, 0);
            this.tableLayoutPanel16.Controls.Add(this.dateTimePicker_EditRecurringInvoice_DueDate, 1, 2);
            this.tableLayoutPanel16.Controls.Add(this.comboBox_EditRecurringInvoice_Status, 1, 3);
            this.tableLayoutPanel16.Controls.Add(this.dateTimePicker_EditRecurringInvoice_InvoiceDate, 1, 1);
            this.tableLayoutPanel16.Controls.Add(this.label123, 0, 5);
            this.tableLayoutPanel16.Controls.Add(this.label124, 0, 6);
            this.tableLayoutPanel16.Controls.Add(this.numericUpDown_EditRecurringInvoice_NextDays, 1, 5);
            this.tableLayoutPanel16.Controls.Add(this.numericUpDown_EditRecurringInvoice_DueDays, 1, 6);
            this.tableLayoutPanel16.Location = new System.Drawing.Point(7, 27);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 7;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(405, 228);
            this.tableLayoutPanel16.TabIndex = 0;
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.Controls.Add(this.radioButton_EditRecurringInvoice_Send2Client_Yes);
            this.flowLayoutPanel14.Controls.Add(this.radioButton_EditRecurringInvoice_Send2Client_No);
            this.flowLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel14.Location = new System.Drawing.Point(260, 131);
            this.flowLayoutPanel14.Name = "flowLayoutPanel14";
            this.flowLayoutPanel14.Size = new System.Drawing.Size(142, 26);
            this.flowLayoutPanel14.TabIndex = 11;
            // 
            // radioButton_EditRecurringInvoice_Send2Client_Yes
            // 
            this.radioButton_EditRecurringInvoice_Send2Client_Yes.AutoSize = true;
            this.radioButton_EditRecurringInvoice_Send2Client_Yes.Location = new System.Drawing.Point(6, 3);
            this.radioButton_EditRecurringInvoice_Send2Client_Yes.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButton_EditRecurringInvoice_Send2Client_Yes.Name = "radioButton_EditRecurringInvoice_Send2Client_Yes";
            this.radioButton_EditRecurringInvoice_Send2Client_Yes.Size = new System.Drawing.Size(49, 23);
            this.radioButton_EditRecurringInvoice_Send2Client_Yes.TabIndex = 0;
            this.radioButton_EditRecurringInvoice_Send2Client_Yes.Text = "Yes";
            this.radioButton_EditRecurringInvoice_Send2Client_Yes.UseVisualStyleBackColor = true;
            // 
            // radioButton_EditRecurringInvoice_Send2Client_No
            // 
            this.radioButton_EditRecurringInvoice_Send2Client_No.AutoSize = true;
            this.radioButton_EditRecurringInvoice_Send2Client_No.Checked = true;
            this.radioButton_EditRecurringInvoice_Send2Client_No.Location = new System.Drawing.Point(64, 3);
            this.radioButton_EditRecurringInvoice_Send2Client_No.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButton_EditRecurringInvoice_Send2Client_No.Name = "radioButton_EditRecurringInvoice_Send2Client_No";
            this.radioButton_EditRecurringInvoice_Send2Client_No.Size = new System.Drawing.Size(45, 23);
            this.radioButton_EditRecurringInvoice_Send2Client_No.TabIndex = 1;
            this.radioButton_EditRecurringInvoice_Send2Client_No.TabStop = true;
            this.radioButton_EditRecurringInvoice_Send2Client_No.Text = "No";
            this.radioButton_EditRecurringInvoice_Send2Client_No.UseVisualStyleBackColor = true;
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(3, 6);
            this.label118.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(101, 13);
            this.label118.TabIndex = 0;
            this.label118.Text = "Recurring Invoice #";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(3, 38);
            this.label119.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(68, 13);
            this.label119.TabIndex = 1;
            this.label119.Text = "Invoice Date";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(3, 70);
            this.label120.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(53, 13);
            this.label120.TabIndex = 2;
            this.label120.Text = "Due Date";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(3, 102);
            this.label121.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(37, 13);
            this.label121.TabIndex = 3;
            this.label121.Text = "Status";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(3, 134);
            this.label122.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(73, 13);
            this.label122.TabIndex = 4;
            this.label122.Text = "Send to Client";
            // 
            // textBox_EditRecurringInvoice_InvoiceID
            // 
            this.textBox_EditRecurringInvoice_InvoiceID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EditRecurringInvoice_InvoiceID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_EditRecurringInvoice_InvoiceID.Location = new System.Drawing.Point(260, 6);
            this.textBox_EditRecurringInvoice_InvoiceID.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox_EditRecurringInvoice_InvoiceID.Name = "textBox_EditRecurringInvoice_InvoiceID";
            this.textBox_EditRecurringInvoice_InvoiceID.ReadOnly = true;
            this.textBox_EditRecurringInvoice_InvoiceID.Size = new System.Drawing.Size(142, 13);
            this.textBox_EditRecurringInvoice_InvoiceID.TabIndex = 5;
            // 
            // dateTimePicker_EditRecurringInvoice_DueDate
            // 
            this.dateTimePicker_EditRecurringInvoice_DueDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker_EditRecurringInvoice_DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_EditRecurringInvoice_DueDate.Location = new System.Drawing.Point(260, 67);
            this.dateTimePicker_EditRecurringInvoice_DueDate.Name = "dateTimePicker_EditRecurringInvoice_DueDate";
            this.dateTimePicker_EditRecurringInvoice_DueDate.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker_EditRecurringInvoice_DueDate.TabIndex = 7;
            // 
            // comboBox_EditRecurringInvoice_Status
            // 
            this.comboBox_EditRecurringInvoice_Status.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_EditRecurringInvoice_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EditRecurringInvoice_Status.FormattingEnabled = true;
            this.comboBox_EditRecurringInvoice_Status.Location = new System.Drawing.Point(260, 99);
            this.comboBox_EditRecurringInvoice_Status.Name = "comboBox_EditRecurringInvoice_Status";
            this.comboBox_EditRecurringInvoice_Status.Size = new System.Drawing.Size(142, 21);
            this.comboBox_EditRecurringInvoice_Status.TabIndex = 8;
            // 
            // dateTimePicker_EditRecurringInvoice_InvoiceDate
            // 
            this.dateTimePicker_EditRecurringInvoice_InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_EditRecurringInvoice_InvoiceDate.Location = new System.Drawing.Point(260, 35);
            this.dateTimePicker_EditRecurringInvoice_InvoiceDate.Name = "dateTimePicker_EditRecurringInvoice_InvoiceDate";
            this.dateTimePicker_EditRecurringInvoice_InvoiceDate.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker_EditRecurringInvoice_InvoiceDate.TabIndex = 10;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(3, 166);
            this.label123.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(158, 13);
            this.label123.TabIndex = 12;
            this.label123.Text = "Create next invoice every (days)";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(3, 198);
            this.label124.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(140, 13);
            this.label124.TabIndex = 13;
            this.label124.Text = "Recurring invoice Due Days";
            this.toolTip1.SetToolTip(this.label124, "Days from issue");
            // 
            // numericUpDown_EditRecurringInvoice_NextDays
            // 
            this.numericUpDown_EditRecurringInvoice_NextDays.Location = new System.Drawing.Point(260, 163);
            this.numericUpDown_EditRecurringInvoice_NextDays.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_EditRecurringInvoice_NextDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_EditRecurringInvoice_NextDays.Name = "numericUpDown_EditRecurringInvoice_NextDays";
            this.numericUpDown_EditRecurringInvoice_NextDays.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown_EditRecurringInvoice_NextDays.TabIndex = 14;
            this.numericUpDown_EditRecurringInvoice_NextDays.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numericUpDown_EditRecurringInvoice_DueDays
            // 
            this.numericUpDown_EditRecurringInvoice_DueDays.Location = new System.Drawing.Point(260, 195);
            this.numericUpDown_EditRecurringInvoice_DueDays.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_EditRecurringInvoice_DueDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_EditRecurringInvoice_DueDays.Name = "numericUpDown_EditRecurringInvoice_DueDays";
            this.numericUpDown_EditRecurringInvoice_DueDays.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown_EditRecurringInvoice_DueDays.TabIndex = 15;
            this.numericUpDown_EditRecurringInvoice_DueDays.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // splitContainer22
            // 
            this.splitContainer22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer22.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer22.IsSplitterFixed = true;
            this.splitContainer22.Location = new System.Drawing.Point(0, 0);
            this.splitContainer22.Name = "splitContainer22";
            this.splitContainer22.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer22.Panel1
            // 
            this.splitContainer22.Panel1.Controls.Add(this.groupBox38);
            this.splitContainer22.Panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer22.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer22.Panel2
            // 
            this.splitContainer22.Panel2.Controls.Add(this.splitContainer23);
            this.splitContainer22.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer22.Size = new System.Drawing.Size(916, 339);
            this.splitContainer22.SplitterDistance = 168;
            this.splitContainer22.TabIndex = 0;
            // 
            // groupBox38
            // 
            this.groupBox38.Controls.Add(this.gridView_EditRecurringInvoice_InvoiceItem);
            this.groupBox38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox38.Location = new System.Drawing.Point(0, 0);
            this.groupBox38.Name = "groupBox38";
            this.groupBox38.Size = new System.Drawing.Size(916, 168);
            this.groupBox38.TabIndex = 3;
            this.groupBox38.TabStop = false;
            this.groupBox38.Text = "Invoice Item";
            // 
            // gridView_EditRecurringInvoice_InvoiceItem
            // 
            this.gridView_EditRecurringInvoice_InvoiceItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_EditRecurringInvoice_InvoiceItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.gridView_EditRecurringInvoice_InvoiceItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView_EditRecurringInvoice_InvoiceItem.Location = new System.Drawing.Point(3, 23);
            this.gridView_EditRecurringInvoice_InvoiceItem.Name = "gridView_EditRecurringInvoice_InvoiceItem";
            this.gridView_EditRecurringInvoice_InvoiceItem.Size = new System.Drawing.Size(910, 142);
            this.gridView_EditRecurringInvoice_InvoiceItem.TabIndex = 1;
            this.gridView_EditRecurringInvoice_InvoiceItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_EditRecurringInvoice_InvoiceItem_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Total";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // splitContainer23
            // 
            this.splitContainer23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer23.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer23.IsSplitterFixed = true;
            this.splitContainer23.Location = new System.Drawing.Point(0, 0);
            this.splitContainer23.Name = "splitContainer23";
            this.splitContainer23.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer23.Panel1
            // 
            this.splitContainer23.Panel1.Controls.Add(this.splitContainer24);
            this.splitContainer23.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer23.Panel2
            // 
            this.splitContainer23.Panel2.Controls.Add(this.button_EditRecurringInvoice_ViewPDF);
            this.splitContainer23.Panel2.Controls.Add(this.button_EditRecurringInvoice_SendEmail);
            this.splitContainer23.Panel2.Controls.Add(this.button_EditRecurringInvoice_SaveInvoice);
            this.splitContainer23.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer23.Size = new System.Drawing.Size(916, 167);
            this.splitContainer23.SplitterDistance = 130;
            this.splitContainer23.TabIndex = 3;
            // 
            // splitContainer24
            // 
            this.splitContainer24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer24.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer24.IsSplitterFixed = true;
            this.splitContainer24.Location = new System.Drawing.Point(0, 0);
            this.splitContainer24.Name = "splitContainer24";
            // 
            // splitContainer24.Panel1
            // 
            this.splitContainer24.Panel1.Controls.Add(this.groupBox39);
            this.splitContainer24.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer24.Panel2
            // 
            this.splitContainer24.Panel2.Controls.Add(this.groupBox40);
            this.splitContainer24.Panel2.Controls.Add(this.button9);
            this.splitContainer24.Panel2.Controls.Add(this.button11);
            this.splitContainer24.Panel2.Controls.Add(this.button24);
            this.splitContainer24.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer24.Size = new System.Drawing.Size(916, 130);
            this.splitContainer24.SplitterDistance = 640;
            this.splitContainer24.TabIndex = 1;
            // 
            // groupBox39
            // 
            this.groupBox39.Controls.Add(this.textBox_EditRecurringInvoice_Comments);
            this.groupBox39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox39.Location = new System.Drawing.Point(0, 0);
            this.groupBox39.Name = "groupBox39";
            this.groupBox39.Size = new System.Drawing.Size(640, 130);
            this.groupBox39.TabIndex = 4;
            this.groupBox39.TabStop = false;
            this.groupBox39.Text = "Comment";
            // 
            // textBox_EditRecurringInvoice_Comments
            // 
            this.textBox_EditRecurringInvoice_Comments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_EditRecurringInvoice_Comments.Location = new System.Drawing.Point(3, 23);
            this.textBox_EditRecurringInvoice_Comments.Multiline = true;
            this.textBox_EditRecurringInvoice_Comments.Name = "textBox_EditRecurringInvoice_Comments";
            this.textBox_EditRecurringInvoice_Comments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_EditRecurringInvoice_Comments.Size = new System.Drawing.Size(634, 104);
            this.textBox_EditRecurringInvoice_Comments.TabIndex = 0;
            // 
            // groupBox40
            // 
            this.groupBox40.Controls.Add(this.tableLayoutPanel17);
            this.groupBox40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox40.Location = new System.Drawing.Point(0, 0);
            this.groupBox40.Name = "groupBox40";
            this.groupBox40.Size = new System.Drawing.Size(272, 130);
            this.groupBox40.TabIndex = 6;
            this.groupBox40.TabStop = false;
            this.groupBox40.Text = "Totals";
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 2;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.36636F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.63363F));
            this.tableLayoutPanel17.Controls.Add(this.label125, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.label126, 0, 2);
            this.tableLayoutPanel17.Controls.Add(this.textBox_EditRecurringInvoice_SubTotal, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.textBox_EditRecurringInvoice_VAT_Value, 1, 1);
            this.tableLayoutPanel17.Controls.Add(this.textBox_EditRecurringInvoice_GrandTotal, 1, 2);
            this.tableLayoutPanel17.Controls.Add(this.flowLayoutPanel15, 0, 1);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 3;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(266, 104);
            this.tableLayoutPanel17.TabIndex = 1;
            // 
            // label125
            // 
            this.label125.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(114, 6);
            this.label125.Margin = new System.Windows.Forms.Padding(3, 6, 9, 0);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(53, 13);
            this.label125.TabIndex = 0;
            this.label125.Text = "Sub-Total";
            // 
            // label126
            // 
            this.label126.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(136, 74);
            this.label126.Margin = new System.Windows.Forms.Padding(3, 6, 9, 0);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(31, 13);
            this.label126.TabIndex = 2;
            this.label126.Text = "Total";
            // 
            // textBox_EditRecurringInvoice_SubTotal
            // 
            this.textBox_EditRecurringInvoice_SubTotal.Location = new System.Drawing.Point(179, 3);
            this.textBox_EditRecurringInvoice_SubTotal.Name = "textBox_EditRecurringInvoice_SubTotal";
            this.textBox_EditRecurringInvoice_SubTotal.Size = new System.Drawing.Size(84, 20);
            this.textBox_EditRecurringInvoice_SubTotal.TabIndex = 3;
            this.textBox_EditRecurringInvoice_SubTotal.TextChanged += new System.EventHandler(this.textBox_EditRecurringInvoice_SubTotal_TextChanged);
            // 
            // textBox_EditRecurringInvoice_VAT_Value
            // 
            this.textBox_EditRecurringInvoice_VAT_Value.Location = new System.Drawing.Point(179, 37);
            this.textBox_EditRecurringInvoice_VAT_Value.Name = "textBox_EditRecurringInvoice_VAT_Value";
            this.textBox_EditRecurringInvoice_VAT_Value.Size = new System.Drawing.Size(84, 20);
            this.textBox_EditRecurringInvoice_VAT_Value.TabIndex = 4;
            // 
            // textBox_EditRecurringInvoice_GrandTotal
            // 
            this.textBox_EditRecurringInvoice_GrandTotal.Location = new System.Drawing.Point(179, 71);
            this.textBox_EditRecurringInvoice_GrandTotal.Name = "textBox_EditRecurringInvoice_GrandTotal";
            this.textBox_EditRecurringInvoice_GrandTotal.Size = new System.Drawing.Size(84, 20);
            this.textBox_EditRecurringInvoice_GrandTotal.TabIndex = 5;
            // 
            // flowLayoutPanel15
            // 
            this.flowLayoutPanel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel15.AutoSize = true;
            this.flowLayoutPanel15.Controls.Add(this.label127);
            this.flowLayoutPanel15.Controls.Add(this.numericUpDown_EditRecurringInvoice_VAT_Percent);
            this.flowLayoutPanel15.Controls.Add(this.label128);
            this.flowLayoutPanel15.Location = new System.Drawing.Point(47, 34);
            this.flowLayoutPanel15.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel15.Name = "flowLayoutPanel15";
            this.flowLayoutPanel15.Size = new System.Drawing.Size(129, 26);
            this.flowLayoutPanel15.TabIndex = 6;
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Location = new System.Drawing.Point(3, 6);
            this.label127.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(28, 13);
            this.label127.TabIndex = 0;
            this.label127.Text = "VAT";
            // 
            // numericUpDown_EditRecurringInvoice_VAT_Percent
            // 
            this.numericUpDown_EditRecurringInvoice_VAT_Percent.Location = new System.Drawing.Point(37, 3);
            this.numericUpDown_EditRecurringInvoice_VAT_Percent.Name = "numericUpDown_EditRecurringInvoice_VAT_Percent";
            this.numericUpDown_EditRecurringInvoice_VAT_Percent.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown_EditRecurringInvoice_VAT_Percent.TabIndex = 3;
            this.numericUpDown_EditRecurringInvoice_VAT_Percent.ValueChanged += new System.EventHandler(this.numericUpDown_EditRecurringInvoice_VAT_Percent_ValueChanged);
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(105, 6);
            this.label128.Margin = new System.Windows.Forms.Padding(3, 6, 9, 0);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(15, 13);
            this.label128.TabIndex = 2;
            this.label128.Text = "%";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(543, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 26);
            this.button9.TabIndex = 2;
            this.button9.Text = "View as PDF";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(669, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 26);
            this.button11.TabIndex = 1;
            this.button11.Text = "Send eMail";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(795, 3);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(120, 26);
            this.button24.TabIndex = 0;
            this.button24.Text = "Save Invoice";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button_EditRecurringInvoice_ViewPDF
            // 
            this.button_EditRecurringInvoice_ViewPDF.Location = new System.Drawing.Point(543, 2);
            this.button_EditRecurringInvoice_ViewPDF.Name = "button_EditRecurringInvoice_ViewPDF";
            this.button_EditRecurringInvoice_ViewPDF.Size = new System.Drawing.Size(120, 26);
            this.button_EditRecurringInvoice_ViewPDF.TabIndex = 2;
            this.button_EditRecurringInvoice_ViewPDF.Text = "View as PDF";
            this.button_EditRecurringInvoice_ViewPDF.UseVisualStyleBackColor = true;
            // 
            // button_EditRecurringInvoice_SendEmail
            // 
            this.button_EditRecurringInvoice_SendEmail.Location = new System.Drawing.Point(669, 2);
            this.button_EditRecurringInvoice_SendEmail.Name = "button_EditRecurringInvoice_SendEmail";
            this.button_EditRecurringInvoice_SendEmail.Size = new System.Drawing.Size(120, 26);
            this.button_EditRecurringInvoice_SendEmail.TabIndex = 1;
            this.button_EditRecurringInvoice_SendEmail.Text = "Send eMail";
            this.button_EditRecurringInvoice_SendEmail.UseVisualStyleBackColor = true;
            // 
            // button_EditRecurringInvoice_SaveInvoice
            // 
            this.button_EditRecurringInvoice_SaveInvoice.Location = new System.Drawing.Point(795, 2);
            this.button_EditRecurringInvoice_SaveInvoice.Name = "button_EditRecurringInvoice_SaveInvoice";
            this.button_EditRecurringInvoice_SaveInvoice.Size = new System.Drawing.Size(120, 26);
            this.button_EditRecurringInvoice_SaveInvoice.TabIndex = 0;
            this.button_EditRecurringInvoice_SaveInvoice.Text = "Save Invoice";
            this.button_EditRecurringInvoice_SaveInvoice.UseVisualStyleBackColor = true;
            this.button_EditRecurringInvoice_SaveInvoice.Click += new System.EventHandler(this.button_EditRecurringInvoice_SaveInvoice_Click);
            // 
            // tabPage_Payments
            // 
            this.tabPage_Payments.Controls.Add(this.tabControl_Payments);
            this.tabPage_Payments.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Payments.Name = "tabPage_Payments";
            this.tabPage_Payments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Payments.Size = new System.Drawing.Size(936, 647);
            this.tabPage_Payments.TabIndex = 3;
            this.tabPage_Payments.Text = "Payments";
            // 
            // tabControl_Payments
            // 
            this.tabControl_Payments.Controls.Add(this.tabPage_Payments_PostPayment);
            this.tabControl_Payments.Controls.Add(this.tabPage_Payments_EditPayment);
            this.tabControl_Payments.Controls.Add(this.tabPage_Payments_SearchPayment);
            this.tabControl_Payments.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl_Payments.DisplayStyle = TradeWright.UI.Forms.TabStyle.Angled;
            // 
            // 
            // 
            this.tabControl_Payments.DisplayStyleProvider.BlendStyle = TradeWright.UI.Forms.BlendStyle.Normal;
            this.tabControl_Payments.DisplayStyleProvider.BorderColorDisabled = System.Drawing.SystemColors.ControlLight;
            this.tabControl_Payments.DisplayStyleProvider.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControl_Payments.DisplayStyleProvider.BorderColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Payments.DisplayStyleProvider.BorderColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Payments.DisplayStyleProvider.BorderColorUnselected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Payments.DisplayStyleProvider.CloserButtonFillColorFocused = System.Drawing.Color.Empty;
            this.tabControl_Payments.DisplayStyleProvider.CloserButtonFillColorFocusedActive = System.Drawing.Color.Empty;
            this.tabControl_Payments.DisplayStyleProvider.CloserButtonFillColorHighlighted = System.Drawing.Color.Empty;
            this.tabControl_Payments.DisplayStyleProvider.CloserButtonFillColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabControl_Payments.DisplayStyleProvider.CloserButtonFillColorSelected = System.Drawing.Color.Empty;
            this.tabControl_Payments.DisplayStyleProvider.CloserButtonFillColorSelectedActive = System.Drawing.Color.Empty;
            this.tabControl_Payments.DisplayStyleProvider.CloserButtonFillColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Payments.DisplayStyleProvider.CloserButtonOutlineColorFocused = System.Drawing.Color.Empty;
            this.tabControl_Payments.DisplayStyleProvider.CloserButtonOutlineColorFocusedActive = System.Drawing.Color.Empty;
            this.tabControl_Payments.DisplayStyleProvider.CloserButtonOutlineColorHighlighted = System.Drawing.Color.Empty;
            this.tabControl_Payments.DisplayStyleProvider.CloserButtonOutlineColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabControl_Payments.DisplayStyleProvider.CloserButtonOutlineColorSelected = System.Drawing.Color.Empty;
            this.tabControl_Payments.DisplayStyleProvider.CloserButtonOutlineColorSelectedActive = System.Drawing.Color.Empty;
            this.tabControl_Payments.DisplayStyleProvider.CloserButtonOutlineColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Payments.DisplayStyleProvider.CloserColorFocused = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Payments.DisplayStyleProvider.CloserColorFocusedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Payments.DisplayStyleProvider.CloserColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Payments.DisplayStyleProvider.CloserColorHighlightedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Payments.DisplayStyleProvider.CloserColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Payments.DisplayStyleProvider.CloserColorSelectedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Payments.DisplayStyleProvider.CloserColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Payments.DisplayStyleProvider.FocusTrack = false;
            this.tabControl_Payments.DisplayStyleProvider.HotTrack = true;
            this.tabControl_Payments.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tabControl_Payments.DisplayStyleProvider.Opacity = 1F;
            this.tabControl_Payments.DisplayStyleProvider.Overlap = 8;
            this.tabControl_Payments.DisplayStyleProvider.Padding = new System.Drawing.Point(8, 4);
            this.tabControl_Payments.DisplayStyleProvider.PageBackgroundColorDisabled = System.Drawing.SystemColors.Control;
            this.tabControl_Payments.DisplayStyleProvider.PageBackgroundColorFocused = System.Drawing.SystemColors.ControlLight;
            this.tabControl_Payments.DisplayStyleProvider.PageBackgroundColorHighlighted = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabControl_Payments.DisplayStyleProvider.PageBackgroundColorSelected = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Payments.DisplayStyleProvider.PageBackgroundColorUnselected = System.Drawing.SystemColors.Control;
            this.tabControl_Payments.DisplayStyleProvider.Radius = 12;
            this.tabControl_Payments.DisplayStyleProvider.SelectedTabIsLarger = true;
            this.tabControl_Payments.DisplayStyleProvider.ShowTabCloser = false;
            this.tabControl_Payments.DisplayStyleProvider.TabColorDisabled1 = System.Drawing.SystemColors.Control;
            this.tabControl_Payments.DisplayStyleProvider.TabColorDisabled2 = System.Drawing.SystemColors.Control;
            this.tabControl_Payments.DisplayStyleProvider.TabColorFocused1 = System.Drawing.Color.White;
            this.tabControl_Payments.DisplayStyleProvider.TabColorFocused2 = System.Drawing.Color.White;
            this.tabControl_Payments.DisplayStyleProvider.TabColorHighLighted1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabControl_Payments.DisplayStyleProvider.TabColorHighLighted2 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.tabControl_Payments.DisplayStyleProvider.TabColorSelected1 = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Payments.DisplayStyleProvider.TabColorSelected2 = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Payments.DisplayStyleProvider.TabColorUnSelected1 = System.Drawing.SystemColors.Control;
            this.tabControl_Payments.DisplayStyleProvider.TabColorUnSelected2 = System.Drawing.SystemColors.Control;
            this.tabControl_Payments.DisplayStyleProvider.TabPageMargin = new System.Windows.Forms.Padding(1);
            this.tabControl_Payments.DisplayStyleProvider.TextColorFocused = System.Drawing.SystemColors.ControlText;
            this.tabControl_Payments.DisplayStyleProvider.TextColorHighlighted = System.Drawing.SystemColors.ControlText;
            this.tabControl_Payments.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.tabControl_Payments.DisplayStyleProvider.TextColorUnselected = System.Drawing.SystemColors.ControlDarkDark;
            this.tabControl_Payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Payments.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Payments.HotTrack = true;
            this.tabControl_Payments.Location = new System.Drawing.Point(3, 3);
            this.tabControl_Payments.Name = "tabControl_Payments";
            this.tabControl_Payments.SelectedIndex = 0;
            this.tabControl_Payments.Size = new System.Drawing.Size(930, 641);
            this.tabControl_Payments.TabIndex = 3;
            // 
            // tabPage_Payments_PostPayment
            // 
            this.tabPage_Payments_PostPayment.Controls.Add(this.groupBox_PostPayment);
            this.tabPage_Payments_PostPayment.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Payments_PostPayment.Name = "tabPage_Payments_PostPayment";
            this.tabPage_Payments_PostPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Payments_PostPayment.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Payments_PostPayment.TabIndex = 2;
            this.tabPage_Payments_PostPayment.Text = "Post a Payment";
            // 
            // groupBox_PostPayment
            // 
            this.groupBox_PostPayment.Controls.Add(this.tableLayoutPanel_PostPayment);
            this.groupBox_PostPayment.Location = new System.Drawing.Point(3, 6);
            this.groupBox_PostPayment.Name = "groupBox_PostPayment";
            this.groupBox_PostPayment.Size = new System.Drawing.Size(494, 309);
            this.groupBox_PostPayment.TabIndex = 2;
            this.groupBox_PostPayment.TabStop = false;
            this.groupBox_PostPayment.Text = "Post a Payment";
            // 
            // tableLayoutPanel_PostPayment
            // 
            this.tableLayoutPanel_PostPayment.ColumnCount = 2;
            this.tableLayoutPanel_PostPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.52101F));
            this.tableLayoutPanel_PostPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.47899F));
            this.tableLayoutPanel_PostPayment.Controls.Add(this.dateTimePicker_PostPayment_PaymentDate, 1, 2);
            this.tableLayoutPanel_PostPayment.Controls.Add(this.label37, 0, 0);
            this.tableLayoutPanel_PostPayment.Controls.Add(this.label61, 0, 1);
            this.tableLayoutPanel_PostPayment.Controls.Add(this.label63, 0, 2);
            this.tableLayoutPanel_PostPayment.Controls.Add(this.label64, 0, 3);
            this.tableLayoutPanel_PostPayment.Controls.Add(this.button_PostPayment_PostPayment, 1, 5);
            this.tableLayoutPanel_PostPayment.Controls.Add(this.textBox_PostPayment_Notes, 1, 4);
            this.tableLayoutPanel_PostPayment.Controls.Add(this.label65, 0, 4);
            this.tableLayoutPanel_PostPayment.Controls.Add(this.flowLayoutPanel10, 1, 3);
            this.tableLayoutPanel_PostPayment.Controls.Add(this.comboBox_PostPayment_PaymentType, 1, 1);
            this.tableLayoutPanel_PostPayment.Controls.Add(this.comboBox_PostPayment_InvoiceID, 1, 0);
            this.tableLayoutPanel_PostPayment.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel_PostPayment.Name = "tableLayoutPanel_PostPayment";
            this.tableLayoutPanel_PostPayment.RowCount = 6;
            this.tableLayoutPanel_PostPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel_PostPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel_PostPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel_PostPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel_PostPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_PostPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_PostPayment.Size = new System.Drawing.Size(482, 277);
            this.tableLayoutPanel_PostPayment.TabIndex = 3;
            // 
            // dateTimePicker_PostPayment_PaymentDate
            // 
            this.dateTimePicker_PostPayment_PaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_PostPayment_PaymentDate.Location = new System.Drawing.Point(135, 75);
            this.dateTimePicker_PostPayment_PaymentDate.Name = "dateTimePicker_PostPayment_PaymentDate";
            this.dateTimePicker_PostPayment_PaymentDate.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker_PostPayment_PaymentDate.TabIndex = 8;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(3, 6);
            this.label37.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(59, 13);
            this.label37.TabIndex = 0;
            this.label37.Text = "Invoice # *";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(3, 42);
            this.label61.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(78, 13);
            this.label61.TabIndex = 1;
            this.label61.Text = "Payment type *";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(3, 78);
            this.label63.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(72, 13);
            this.label63.TabIndex = 2;
            this.label63.Text = "Payment date";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(3, 114);
            this.label64.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(43, 13);
            this.label64.TabIndex = 3;
            this.label64.Text = "Amount";
            // 
            // button_PostPayment_PostPayment
            // 
            this.button_PostPayment_PostPayment.Location = new System.Drawing.Point(135, 247);
            this.button_PostPayment_PostPayment.Name = "button_PostPayment_PostPayment";
            this.button_PostPayment_PostPayment.Size = new System.Drawing.Size(120, 26);
            this.button_PostPayment_PostPayment.TabIndex = 13;
            this.button_PostPayment_PostPayment.Text = "Post Payment";
            this.button_PostPayment_PostPayment.UseVisualStyleBackColor = true;
            this.button_PostPayment_PostPayment.Click += new System.EventHandler(this.button_PostPayment_PostPayment_Click);
            // 
            // textBox_PostPayment_Notes
            // 
            this.textBox_PostPayment_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_PostPayment_Notes.Location = new System.Drawing.Point(135, 147);
            this.textBox_PostPayment_Notes.Multiline = true;
            this.textBox_PostPayment_Notes.Name = "textBox_PostPayment_Notes";
            this.textBox_PostPayment_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_PostPayment_Notes.Size = new System.Drawing.Size(344, 94);
            this.textBox_PostPayment_Notes.TabIndex = 10;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(3, 150);
            this.label65.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(35, 13);
            this.label65.TabIndex = 4;
            this.label65.Text = "Notes";
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(this.textBox_PostPayment_Amount);
            this.flowLayoutPanel10.Controls.Add(this.label_PostPayment_Currency);
            this.flowLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel10.Location = new System.Drawing.Point(132, 108);
            this.flowLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(350, 36);
            this.flowLayoutPanel10.TabIndex = 12;
            // 
            // textBox_PostPayment_Amount
            // 
            this.textBox_PostPayment_Amount.Location = new System.Drawing.Point(3, 3);
            this.textBox_PostPayment_Amount.Name = "textBox_PostPayment_Amount";
            this.textBox_PostPayment_Amount.Size = new System.Drawing.Size(82, 20);
            this.textBox_PostPayment_Amount.TabIndex = 0;
            // 
            // label_PostPayment_Currency
            // 
            this.label_PostPayment_Currency.AutoSize = true;
            this.label_PostPayment_Currency.Location = new System.Drawing.Point(91, 6);
            this.label_PostPayment_Currency.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label_PostPayment_Currency.Name = "label_PostPayment_Currency";
            this.label_PostPayment_Currency.Size = new System.Drawing.Size(36, 13);
            this.label_PostPayment_Currency.TabIndex = 1;
            this.label_PostPayment_Currency.Text = "$USD";
            // 
            // comboBox_PostPayment_PaymentType
            // 
            this.comboBox_PostPayment_PaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PostPayment_PaymentType.FormattingEnabled = true;
            this.comboBox_PostPayment_PaymentType.Location = new System.Drawing.Point(135, 39);
            this.comboBox_PostPayment_PaymentType.Name = "comboBox_PostPayment_PaymentType";
            this.comboBox_PostPayment_PaymentType.Size = new System.Drawing.Size(128, 21);
            this.comboBox_PostPayment_PaymentType.TabIndex = 7;
            // 
            // comboBox_PostPayment_InvoiceID
            // 
            this.comboBox_PostPayment_InvoiceID.FormattingEnabled = true;
            this.comboBox_PostPayment_InvoiceID.Location = new System.Drawing.Point(135, 3);
            this.comboBox_PostPayment_InvoiceID.Name = "comboBox_PostPayment_InvoiceID";
            this.comboBox_PostPayment_InvoiceID.Size = new System.Drawing.Size(128, 21);
            this.comboBox_PostPayment_InvoiceID.TabIndex = 6;
            this.comboBox_PostPayment_InvoiceID.TextChanged += new System.EventHandler(this.comboBox_PostPayment_InvoiceID_TextChanged);
            // 
            // tabPage_Payments_EditPayment
            // 
            this.tabPage_Payments_EditPayment.Controls.Add(this.splitContainer15);
            this.tabPage_Payments_EditPayment.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage_Payments_EditPayment.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Payments_EditPayment.Name = "tabPage_Payments_EditPayment";
            this.tabPage_Payments_EditPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Payments_EditPayment.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Payments_EditPayment.TabIndex = 6;
            this.tabPage_Payments_EditPayment.Text = "Edit Payment";
            // 
            // splitContainer15
            // 
            this.splitContainer15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer15.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer15.IsSplitterFixed = true;
            this.splitContainer15.Location = new System.Drawing.Point(3, 3);
            this.splitContainer15.Name = "splitContainer15";
            this.splitContainer15.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer15.Panel1
            // 
            this.splitContainer15.Panel1.AutoScroll = true;
            this.splitContainer15.Panel1.Controls.Add(this.splitContainer16);
            this.splitContainer15.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer15.Panel2
            // 
            this.splitContainer15.Panel2.Controls.Add(this.splitContainer17);
            this.splitContainer15.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer15.Size = new System.Drawing.Size(916, 603);
            this.splitContainer15.SplitterDistance = 200;
            this.splitContainer15.TabIndex = 4;
            // 
            // splitContainer16
            // 
            this.splitContainer16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer16.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer16.IsSplitterFixed = true;
            this.splitContainer16.Location = new System.Drawing.Point(0, 0);
            this.splitContainer16.MinimumSize = new System.Drawing.Size(780, 0);
            this.splitContainer16.Name = "splitContainer16";
            // 
            // splitContainer16.Panel1
            // 
            this.splitContainer16.Panel1.Controls.Add(this.groupBox30);
            this.splitContainer16.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer16.Panel2
            // 
            this.splitContainer16.Panel2.Controls.Add(this.groupBox31);
            this.splitContainer16.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer16.Size = new System.Drawing.Size(916, 200);
            this.splitContainer16.SplitterDistance = 500;
            this.splitContainer16.TabIndex = 0;
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.button2);
            this.groupBox30.Controls.Add(this.panel1);
            this.groupBox30.Controls.Add(this.textBox2);
            this.groupBox30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox30.Location = new System.Drawing.Point(0, 0);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(500, 200);
            this.groupBox30.TabIndex = 1;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Client";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Change Client";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.label82);
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 42);
            this.panel1.TabIndex = 5;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(402, 7);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(80, 29);
            this.button17.TabIndex = 7;
            this.button17.Text = "Done";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(99, 8);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(295, 21);
            this.comboBox4.TabIndex = 6;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(2, 11);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(66, 13);
            this.label82.TabIndex = 5;
            this.label82.Text = "Select Client";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(13, 33);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox2.Size = new System.Drawing.Size(356, 152);
            this.textBox2.TabIndex = 3;
            this.textBox2.Visible = false;
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.tableLayoutPanel12);
            this.groupBox31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox31.Location = new System.Drawing.Point(0, 0);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new System.Drawing.Size(412, 200);
            this.groupBox31.TabIndex = 2;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "Invoice Details";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.43564F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.56435F));
            this.tableLayoutPanel12.Controls.Add(this.label83, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.label84, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.label85, 0, 2);
            this.tableLayoutPanel12.Controls.Add(this.label86, 0, 3);
            this.tableLayoutPanel12.Controls.Add(this.label87, 0, 4);
            this.tableLayoutPanel12.Controls.Add(this.textBox3, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.dateTimePicker3, 1, 1);
            this.tableLayoutPanel12.Controls.Add(this.dateTimePicker4, 1, 2);
            this.tableLayoutPanel12.Controls.Add(this.comboBox5, 1, 3);
            this.tableLayoutPanel12.Controls.Add(this.flowLayoutPanel8, 1, 4);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(7, 27);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 5;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(404, 164);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(3, 6);
            this.label83.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(52, 13);
            this.label83.TabIndex = 0;
            this.label83.Text = "Invoice #";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(3, 38);
            this.label84.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(68, 13);
            this.label84.TabIndex = 1;
            this.label84.Text = "Invoice Date";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(3, 70);
            this.label85.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(53, 13);
            this.label85.TabIndex = 2;
            this.label85.Text = "Due Date";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(3, 102);
            this.label86.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(37, 13);
            this.label86.TabIndex = 3;
            this.label86.Text = "Status";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(3, 134);
            this.label87.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(73, 13);
            this.label87.TabIndex = 4;
            this.label87.Text = "Send to Client";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox3.Location = new System.Drawing.Point(133, 6);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 6, 3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(268, 13);
            this.textBox3.TabIndex = 5;
            this.textBox3.TabStop = false;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(130, 35);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker3.TabIndex = 6;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(130, 67);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker4.TabIndex = 7;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(130, 99);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(128, 21);
            this.comboBox5.TabIndex = 8;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.radioButton1);
            this.flowLayoutPanel8.Controls.Add(this.radioButton2);
            this.flowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(130, 131);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(271, 30);
            this.flowLayoutPanel8.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 3);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 23);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(64, 3);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 23);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // splitContainer17
            // 
            this.splitContainer17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer17.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer17.IsSplitterFixed = true;
            this.splitContainer17.Location = new System.Drawing.Point(0, 0);
            this.splitContainer17.Name = "splitContainer17";
            this.splitContainer17.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer17.Panel1
            // 
            this.splitContainer17.Panel1.Controls.Add(this.groupBox32);
            this.splitContainer17.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer17.Panel2
            // 
            this.splitContainer17.Panel2.Controls.Add(this.splitContainer18);
            this.splitContainer17.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer17.Size = new System.Drawing.Size(916, 399);
            this.splitContainer17.SplitterDistance = 178;
            this.splitContainer17.TabIndex = 0;
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.gridViewCustom3);
            this.groupBox32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox32.Location = new System.Drawing.Point(0, 0);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(916, 178);
            this.groupBox32.TabIndex = 3;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "Invoice Item";
            // 
            // gridViewCustom3
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewCustom3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridViewCustom3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCustom3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewCustom3.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridViewCustom3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewCustom3.Location = new System.Drawing.Point(3, 23);
            this.gridViewCustom3.Name = "gridViewCustom3";
            this.gridViewCustom3.Size = new System.Drawing.Size(910, 152);
            this.gridViewCustom3.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn17.HeaderText = "Description";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 150;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 150;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Total";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 150;
            // 
            // splitContainer18
            // 
            this.splitContainer18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer18.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer18.IsSplitterFixed = true;
            this.splitContainer18.Location = new System.Drawing.Point(0, 0);
            this.splitContainer18.Name = "splitContainer18";
            this.splitContainer18.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer18.Panel1
            // 
            this.splitContainer18.Panel1.Controls.Add(this.splitContainer19);
            this.splitContainer18.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer18.Panel2
            // 
            this.splitContainer18.Panel2.Controls.Add(this.textBox10);
            this.splitContainer18.Panel2.Controls.Add(this.textBox11);
            this.splitContainer18.Panel2.Controls.Add(this.label92);
            this.splitContainer18.Panel2.Controls.Add(this.label93);
            this.splitContainer18.Panel2.Controls.Add(this.button21);
            this.splitContainer18.Panel2.Controls.Add(this.button22);
            this.splitContainer18.Panel2.Controls.Add(this.button23);
            this.splitContainer18.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer18.Size = new System.Drawing.Size(916, 217);
            this.splitContainer18.SplitterDistance = 130;
            this.splitContainer18.TabIndex = 3;
            // 
            // splitContainer19
            // 
            this.splitContainer19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer19.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer19.IsSplitterFixed = true;
            this.splitContainer19.Location = new System.Drawing.Point(0, 0);
            this.splitContainer19.Name = "splitContainer19";
            // 
            // splitContainer19.Panel1
            // 
            this.splitContainer19.Panel1.Controls.Add(this.groupBox33);
            this.splitContainer19.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer19.Panel2
            // 
            this.splitContainer19.Panel2.Controls.Add(this.button18);
            this.splitContainer19.Panel2.Controls.Add(this.button19);
            this.splitContainer19.Panel2.Controls.Add(this.button20);
            this.splitContainer19.Panel2.Controls.Add(this.groupBox34);
            this.splitContainer19.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer19.Size = new System.Drawing.Size(916, 130);
            this.splitContainer19.SplitterDistance = 640;
            this.splitContainer19.TabIndex = 1;
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.textBox4);
            this.groupBox33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox33.Location = new System.Drawing.Point(0, 0);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(640, 130);
            this.groupBox33.TabIndex = 4;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "Comments";
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(3, 23);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox4.Size = new System.Drawing.Size(634, 104);
            this.textBox4.TabIndex = 0;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(543, 3);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(120, 26);
            this.button18.TabIndex = 2;
            this.button18.Text = "View as PDF";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(669, 3);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(120, 26);
            this.button19.TabIndex = 1;
            this.button19.Text = "Send eMail";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(795, 3);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(120, 26);
            this.button20.TabIndex = 0;
            this.button20.Text = "Save Invoice";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // groupBox34
            // 
            this.groupBox34.Controls.Add(this.tableLayoutPanel13);
            this.groupBox34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox34.Location = new System.Drawing.Point(0, 0);
            this.groupBox34.Name = "groupBox34";
            this.groupBox34.Size = new System.Drawing.Size(272, 130);
            this.groupBox34.TabIndex = 5;
            this.groupBox34.TabStop = false;
            this.groupBox34.Text = "Totals";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.36636F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.63363F));
            this.tableLayoutPanel13.Controls.Add(this.label88, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.label89, 0, 2);
            this.tableLayoutPanel13.Controls.Add(this.textBox7, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.textBox8, 1, 1);
            this.tableLayoutPanel13.Controls.Add(this.textBox9, 1, 2);
            this.tableLayoutPanel13.Controls.Add(this.flowLayoutPanel9, 0, 1);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 3;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(266, 104);
            this.tableLayoutPanel13.TabIndex = 1;
            // 
            // label88
            // 
            this.label88.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(114, 6);
            this.label88.Margin = new System.Windows.Forms.Padding(3, 6, 9, 0);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(53, 13);
            this.label88.TabIndex = 0;
            this.label88.Text = "Sub-Total";
            // 
            // label89
            // 
            this.label89.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(136, 74);
            this.label89.Margin = new System.Windows.Forms.Padding(3, 6, 9, 0);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(31, 13);
            this.label89.TabIndex = 2;
            this.label89.Text = "Total";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(179, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(84, 20);
            this.textBox7.TabIndex = 3;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(179, 37);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(84, 20);
            this.textBox8.TabIndex = 4;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(179, 71);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(84, 20);
            this.textBox9.TabIndex = 5;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel9.AutoSize = true;
            this.flowLayoutPanel9.Controls.Add(this.label90);
            this.flowLayoutPanel9.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel9.Controls.Add(this.label91);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(47, 34);
            this.flowLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(129, 26);
            this.flowLayoutPanel9.TabIndex = 6;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(3, 6);
            this.label90.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(28, 13);
            this.label90.TabIndex = 0;
            this.label90.Text = "VAT";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(37, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(105, 6);
            this.label91.Margin = new System.Windows.Forms.Padding(3, 6, 9, 0);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(15, 13);
            this.label91.TabIndex = 2;
            this.label91.Text = "%";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(824, 26);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(89, 13);
            this.textBox10.TabIndex = 11;
            this.textBox10.Text = "$0.00";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Location = new System.Drawing.Point(824, 3);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(86, 13);
            this.textBox11.TabIndex = 10;
            this.textBox11.Text = "$0.00";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(715, 26);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(66, 13);
            this.label92.TabIndex = 9;
            this.label92.Text = "Amount Due";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(732, 4);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(53, 13);
            this.label93.TabIndex = 8;
            this.label93.Text = "Payments";
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(543, 60);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(120, 26);
            this.button21.TabIndex = 2;
            this.button21.Text = "View as PDF";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(669, 60);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(120, 26);
            this.button22.TabIndex = 1;
            this.button22.Text = "Send eMail";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(795, 60);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(120, 26);
            this.button23.TabIndex = 0;
            this.button23.Text = "Save Invoice";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // tabPage_Payments_SearchPayment
            // 
            this.tabPage_Payments_SearchPayment.Controls.Add(this.splitContainer1);
            this.tabPage_Payments_SearchPayment.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Payments_SearchPayment.Name = "tabPage_Payments_SearchPayment";
            this.tabPage_Payments_SearchPayment.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Payments_SearchPayment.TabIndex = 1;
            this.tabPage_Payments_SearchPayment.Text = "Search Payment";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox28);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox29);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(922, 609);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.TabIndex = 4;
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.tableLayoutPanel11);
            this.groupBox28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox28.Location = new System.Drawing.Point(6, 6);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.groupBox28.Size = new System.Drawing.Size(910, 98);
            this.groupBox28.TabIndex = 1;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Search Invoice";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 6;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel11.Controls.Add(this.textBox_SearchPayment_PaymentID, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.textBox_SearchPayment_InvoiceID, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.label67, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.label72, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.label78, 2, 0);
            this.tableLayoutPanel11.Controls.Add(this.button_SearchPayment_Search, 5, 1);
            this.tableLayoutPanel11.Controls.Add(this.label79, 3, 0);
            this.tableLayoutPanel11.Controls.Add(this.label80, 4, 0);
            this.tableLayoutPanel11.Controls.Add(this.dateTimePicker_SearchPayment_DateFrom, 3, 1);
            this.tableLayoutPanel11.Controls.Add(this.dateTimePicker_SearchPayment_DateTo, 4, 1);
            this.tableLayoutPanel11.Controls.Add(this.comboBox_SearchPayment_Client, 2, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(6, 23);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(898, 72);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // textBox_SearchPayment_PaymentID
            // 
            this.textBox_SearchPayment_PaymentID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_SearchPayment_PaymentID.Location = new System.Drawing.Point(6, 33);
            this.textBox_SearchPayment_PaymentID.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBox_SearchPayment_PaymentID.Name = "textBox_SearchPayment_PaymentID";
            this.textBox_SearchPayment_PaymentID.Size = new System.Drawing.Size(140, 20);
            this.textBox_SearchPayment_PaymentID.TabIndex = 25;
            // 
            // textBox_SearchPayment_InvoiceID
            // 
            this.textBox_SearchPayment_InvoiceID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_SearchPayment_InvoiceID.Location = new System.Drawing.Point(158, 33);
            this.textBox_SearchPayment_InvoiceID.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBox_SearchPayment_InvoiceID.Name = "textBox_SearchPayment_InvoiceID";
            this.textBox_SearchPayment_InvoiceID.Size = new System.Drawing.Size(140, 20);
            this.textBox_SearchPayment_InvoiceID.TabIndex = 24;
            // 
            // label67
            // 
            this.label67.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(3, 17);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(58, 13);
            this.label67.TabIndex = 0;
            this.label67.Text = "Payment #";
            // 
            // label72
            // 
            this.label72.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(155, 17);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(52, 13);
            this.label72.TabIndex = 2;
            this.label72.Text = "Invoice #";
            // 
            // label78
            // 
            this.label78.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(307, 17);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(33, 13);
            this.label78.TabIndex = 4;
            this.label78.Text = "Client";
            // 
            // button_SearchPayment_Search
            // 
            this.button_SearchPayment_Search.Location = new System.Drawing.Point(763, 32);
            this.button_SearchPayment_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.button_SearchPayment_Search.Name = "button_SearchPayment_Search";
            this.button_SearchPayment_Search.Size = new System.Drawing.Size(90, 29);
            this.button_SearchPayment_Search.TabIndex = 14;
            this.button_SearchPayment_Search.Text = "Search";
            this.button_SearchPayment_Search.UseVisualStyleBackColor = true;
            this.button_SearchPayment_Search.Click += new System.EventHandler(this.button_SearchPayment_Search_Click);
            // 
            // label79
            // 
            this.label79.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(459, 17);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(53, 13);
            this.label79.TabIndex = 18;
            this.label79.Text = "Date from";
            // 
            // label80
            // 
            this.label80.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(611, 17);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(42, 13);
            this.label80.TabIndex = 19;
            this.label80.Text = "Date to";
            // 
            // dateTimePicker_SearchPayment_DateFrom
            // 
            this.dateTimePicker_SearchPayment_DateFrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker_SearchPayment_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_SearchPayment_DateFrom.Location = new System.Drawing.Point(462, 33);
            this.dateTimePicker_SearchPayment_DateFrom.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dateTimePicker_SearchPayment_DateFrom.Name = "dateTimePicker_SearchPayment_DateFrom";
            this.dateTimePicker_SearchPayment_DateFrom.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker_SearchPayment_DateFrom.TabIndex = 22;
            // 
            // dateTimePicker_SearchPayment_DateTo
            // 
            this.dateTimePicker_SearchPayment_DateTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker_SearchPayment_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_SearchPayment_DateTo.Location = new System.Drawing.Point(614, 33);
            this.dateTimePicker_SearchPayment_DateTo.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dateTimePicker_SearchPayment_DateTo.Name = "dateTimePicker_SearchPayment_DateTo";
            this.dateTimePicker_SearchPayment_DateTo.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker_SearchPayment_DateTo.TabIndex = 23;
            // 
            // comboBox_SearchPayment_Client
            // 
            this.comboBox_SearchPayment_Client.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_SearchPayment_Client.FormattingEnabled = true;
            this.comboBox_SearchPayment_Client.Location = new System.Drawing.Point(310, 33);
            this.comboBox_SearchPayment_Client.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.comboBox_SearchPayment_Client.Name = "comboBox_SearchPayment_Client";
            this.comboBox_SearchPayment_Client.Size = new System.Drawing.Size(140, 21);
            this.comboBox_SearchPayment_Client.TabIndex = 26;
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.splitContainer3);
            this.groupBox29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox29.Location = new System.Drawing.Point(6, 6);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Padding = new System.Windows.Forms.Padding(9, 0, 9, 9);
            this.groupBox29.Size = new System.Drawing.Size(910, 483);
            this.groupBox29.TabIndex = 0;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Payments";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(9, 20);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label_SearchPayment_Result);
            this.splitContainer3.Panel1.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridView_SearchPayment);
            this.splitContainer3.Panel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer3.Size = new System.Drawing.Size(892, 454);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 0;
            // 
            // label_SearchPayment_Result
            // 
            this.label_SearchPayment_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_SearchPayment_Result.AutoSize = true;
            this.label_SearchPayment_Result.Location = new System.Drawing.Point(3, 6);
            this.label_SearchPayment_Result.Name = "label_SearchPayment_Result";
            this.label_SearchPayment_Result.Size = new System.Drawing.Size(66, 13);
            this.label_SearchPayment_Result.TabIndex = 0;
            this.label_SearchPayment_Result.Text = "[0] Payment.";
            // 
            // dataGridView_SearchPayment
            // 
            this.dataGridView_SearchPayment.AllowUserToAddRows = false;
            this.dataGridView_SearchPayment.AllowUserToDeleteRows = false;
            this.dataGridView_SearchPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SearchPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewColumn5,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewColumn6,
            this.dataGridViewColumn7,
            this.dataGridViewColumn8});
            this.dataGridView_SearchPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_SearchPayment.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_SearchPayment.Name = "dataGridView_SearchPayment";
            this.dataGridView_SearchPayment.ReadOnly = true;
            this.dataGridView_SearchPayment.RowHeadersVisible = false;
            this.dataGridView_SearchPayment.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_SearchPayment.Size = new System.Drawing.Size(880, 413);
            this.dataGridView_SearchPayment.TabIndex = 0;
            // 
            // dataGridViewColumn5
            // 
            this.dataGridViewColumn5.HeaderText = "Payment #";
            this.dataGridViewColumn5.Name = "dataGridViewColumn5";
            this.dataGridViewColumn5.ReadOnly = true;
            this.dataGridViewColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Invoice #";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 120;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 120;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Created";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewColumn6
            // 
            this.dataGridViewColumn6.HeaderText = "";
            this.dataGridViewColumn6.Name = "dataGridViewColumn6";
            this.dataGridViewColumn6.ReadOnly = true;
            this.dataGridViewColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewColumn6.Width = 50;
            // 
            // dataGridViewColumn7
            // 
            this.dataGridViewColumn7.HeaderText = "";
            this.dataGridViewColumn7.Name = "dataGridViewColumn7";
            this.dataGridViewColumn7.ReadOnly = true;
            this.dataGridViewColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewColumn7.Width = 50;
            // 
            // dataGridViewColumn8
            // 
            this.dataGridViewColumn8.HeaderText = "";
            this.dataGridViewColumn8.Name = "dataGridViewColumn8";
            this.dataGridViewColumn8.ReadOnly = true;
            this.dataGridViewColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewColumn8.Width = 60;
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.Controls.Add(this.tabControl_Settings);
            this.tabPage_Settings.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Settings.Size = new System.Drawing.Size(936, 647);
            this.tabPage_Settings.TabIndex = 4;
            this.tabPage_Settings.Text = "Settings";
            // 
            // tabControl_Settings
            // 
            this.tabControl_Settings.Controls.Add(this.tabPage_Settings_General);
            this.tabControl_Settings.Controls.Add(this.tabPage_Settings_EmailTemplates);
            this.tabControl_Settings.Controls.Add(this.tabPage_Settings_InvoiceTemplates);
            this.tabControl_Settings.Controls.Add(this.tabPage_Settings_ManageUsers);
            this.tabControl_Settings.Controls.Add(this.tabPage_Settings_SMTPServer);
            this.tabControl_Settings.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl_Settings.DisplayStyle = TradeWright.UI.Forms.TabStyle.Angled;
            // 
            // 
            // 
            this.tabControl_Settings.DisplayStyleProvider.BlendStyle = TradeWright.UI.Forms.BlendStyle.Normal;
            this.tabControl_Settings.DisplayStyleProvider.BorderColorDisabled = System.Drawing.SystemColors.ControlLight;
            this.tabControl_Settings.DisplayStyleProvider.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControl_Settings.DisplayStyleProvider.BorderColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Settings.DisplayStyleProvider.BorderColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Settings.DisplayStyleProvider.BorderColorUnselected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Settings.DisplayStyleProvider.CloserButtonFillColorFocused = System.Drawing.Color.Empty;
            this.tabControl_Settings.DisplayStyleProvider.CloserButtonFillColorFocusedActive = System.Drawing.Color.Empty;
            this.tabControl_Settings.DisplayStyleProvider.CloserButtonFillColorHighlighted = System.Drawing.Color.Empty;
            this.tabControl_Settings.DisplayStyleProvider.CloserButtonFillColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabControl_Settings.DisplayStyleProvider.CloserButtonFillColorSelected = System.Drawing.Color.Empty;
            this.tabControl_Settings.DisplayStyleProvider.CloserButtonFillColorSelectedActive = System.Drawing.Color.Empty;
            this.tabControl_Settings.DisplayStyleProvider.CloserButtonFillColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Settings.DisplayStyleProvider.CloserButtonOutlineColorFocused = System.Drawing.Color.Empty;
            this.tabControl_Settings.DisplayStyleProvider.CloserButtonOutlineColorFocusedActive = System.Drawing.Color.Empty;
            this.tabControl_Settings.DisplayStyleProvider.CloserButtonOutlineColorHighlighted = System.Drawing.Color.Empty;
            this.tabControl_Settings.DisplayStyleProvider.CloserButtonOutlineColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabControl_Settings.DisplayStyleProvider.CloserButtonOutlineColorSelected = System.Drawing.Color.Empty;
            this.tabControl_Settings.DisplayStyleProvider.CloserButtonOutlineColorSelectedActive = System.Drawing.Color.Empty;
            this.tabControl_Settings.DisplayStyleProvider.CloserButtonOutlineColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Settings.DisplayStyleProvider.CloserColorFocused = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Settings.DisplayStyleProvider.CloserColorFocusedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Settings.DisplayStyleProvider.CloserColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Settings.DisplayStyleProvider.CloserColorHighlightedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Settings.DisplayStyleProvider.CloserColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Settings.DisplayStyleProvider.CloserColorSelectedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Settings.DisplayStyleProvider.CloserColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Settings.DisplayStyleProvider.FocusTrack = false;
            this.tabControl_Settings.DisplayStyleProvider.HotTrack = true;
            this.tabControl_Settings.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tabControl_Settings.DisplayStyleProvider.Opacity = 1F;
            this.tabControl_Settings.DisplayStyleProvider.Overlap = 8;
            this.tabControl_Settings.DisplayStyleProvider.Padding = new System.Drawing.Point(8, 4);
            this.tabControl_Settings.DisplayStyleProvider.PageBackgroundColorDisabled = System.Drawing.SystemColors.Control;
            this.tabControl_Settings.DisplayStyleProvider.PageBackgroundColorFocused = System.Drawing.SystemColors.ControlLight;
            this.tabControl_Settings.DisplayStyleProvider.PageBackgroundColorHighlighted = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabControl_Settings.DisplayStyleProvider.PageBackgroundColorSelected = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Settings.DisplayStyleProvider.PageBackgroundColorUnselected = System.Drawing.SystemColors.Control;
            this.tabControl_Settings.DisplayStyleProvider.Radius = 12;
            this.tabControl_Settings.DisplayStyleProvider.SelectedTabIsLarger = true;
            this.tabControl_Settings.DisplayStyleProvider.ShowTabCloser = false;
            this.tabControl_Settings.DisplayStyleProvider.TabColorDisabled1 = System.Drawing.SystemColors.Control;
            this.tabControl_Settings.DisplayStyleProvider.TabColorDisabled2 = System.Drawing.SystemColors.Control;
            this.tabControl_Settings.DisplayStyleProvider.TabColorFocused1 = System.Drawing.Color.White;
            this.tabControl_Settings.DisplayStyleProvider.TabColorFocused2 = System.Drawing.Color.White;
            this.tabControl_Settings.DisplayStyleProvider.TabColorHighLighted1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabControl_Settings.DisplayStyleProvider.TabColorHighLighted2 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.tabControl_Settings.DisplayStyleProvider.TabColorSelected1 = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Settings.DisplayStyleProvider.TabColorSelected2 = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Settings.DisplayStyleProvider.TabColorUnSelected1 = System.Drawing.SystemColors.Control;
            this.tabControl_Settings.DisplayStyleProvider.TabColorUnSelected2 = System.Drawing.SystemColors.Control;
            this.tabControl_Settings.DisplayStyleProvider.TabPageMargin = new System.Windows.Forms.Padding(1);
            this.tabControl_Settings.DisplayStyleProvider.TextColorFocused = System.Drawing.SystemColors.ControlText;
            this.tabControl_Settings.DisplayStyleProvider.TextColorHighlighted = System.Drawing.SystemColors.ControlText;
            this.tabControl_Settings.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.tabControl_Settings.DisplayStyleProvider.TextColorUnselected = System.Drawing.SystemColors.ControlDarkDark;
            this.tabControl_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Settings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Settings.HotTrack = true;
            this.tabControl_Settings.Location = new System.Drawing.Point(3, 3);
            this.tabControl_Settings.Name = "tabControl_Settings";
            this.tabControl_Settings.SelectedIndex = 0;
            this.tabControl_Settings.Size = new System.Drawing.Size(930, 641);
            this.tabControl_Settings.TabIndex = 2;
            // 
            // tabPage_Settings_General
            // 
            this.tabPage_Settings_General.Controls.Add(this.groupBox49);
            this.tabPage_Settings_General.Controls.Add(this.flowLayoutPanel21);
            this.tabPage_Settings_General.Controls.Add(this.groupBox48);
            this.tabPage_Settings_General.Controls.Add(this.flowLayoutPanel20);
            this.tabPage_Settings_General.Controls.Add(this.groupBox47);
            this.tabPage_Settings_General.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Settings_General.Name = "tabPage_Settings_General";
            this.tabPage_Settings_General.Padding = new System.Windows.Forms.Padding(12);
            this.tabPage_Settings_General.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Settings_General.TabIndex = 1;
            this.tabPage_Settings_General.Text = "General";
            // 
            // groupBox49
            // 
            this.groupBox49.Controls.Add(this.button27);
            this.groupBox49.Controls.Add(this.comboBox2);
            this.groupBox49.Controls.Add(this.label150);
            this.groupBox49.Controls.Add(this.textBox13);
            this.groupBox49.Controls.Add(this.label151);
            this.groupBox49.Controls.Add(this.label152);
            this.groupBox49.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox49.Location = new System.Drawing.Point(12, 408);
            this.groupBox49.Name = "groupBox49";
            this.groupBox49.Size = new System.Drawing.Size(898, 130);
            this.groupBox49.TabIndex = 5;
            this.groupBox49.TabStop = false;
            this.groupBox49.Text = "Invoice ID series";
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(478, 66);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(155, 29);
            this.button27.TabIndex = 5;
            this.button27.Text = "Create new serie";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0000 - 4 digits",
            "00000 - 5 digits",
            "000000 - 6 digits",
            "0000000 - 7 digits"});
            this.comboBox2.Location = new System.Drawing.Point(346, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 27);
            this.comboBox2.TabIndex = 4;
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.Location = new System.Drawing.Point(323, 69);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(17, 19);
            this.label150.TabIndex = 3;
            this.label150.Text = "+";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(197, 66);
            this.textBox13.MaxLength = 6;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(120, 27);
            this.textBox13.TabIndex = 2;
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.Location = new System.Drawing.Point(9, 69);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(173, 19);
            this.label151.TabIndex = 1;
            this.label151.Text = "Create new invoice Serie:";
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.Location = new System.Drawing.Point(9, 32);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(324, 19);
            this.label152.TabIndex = 0;
            this.label152.Text = "Current Client Series: 019-0000, 020-0000, ... etc";
            // 
            // flowLayoutPanel21
            // 
            this.flowLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel21.Location = new System.Drawing.Point(12, 382);
            this.flowLayoutPanel21.Name = "flowLayoutPanel21";
            this.flowLayoutPanel21.Size = new System.Drawing.Size(898, 26);
            this.flowLayoutPanel21.TabIndex = 4;
            // 
            // groupBox48
            // 
            this.groupBox48.Controls.Add(this.button26);
            this.groupBox48.Controls.Add(this.comboBox1);
            this.groupBox48.Controls.Add(this.label149);
            this.groupBox48.Controls.Add(this.textBox6);
            this.groupBox48.Controls.Add(this.label148);
            this.groupBox48.Controls.Add(this.label147);
            this.groupBox48.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox48.Location = new System.Drawing.Point(12, 252);
            this.groupBox48.Name = "groupBox48";
            this.groupBox48.Size = new System.Drawing.Size(898, 130);
            this.groupBox48.TabIndex = 3;
            this.groupBox48.TabStop = false;
            this.groupBox48.Text = "Client ID series";
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(478, 66);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(155, 29);
            this.button26.TabIndex = 5;
            this.button26.Text = "Create new serie";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0000 - 4 digits",
            "00000 - 5 digits",
            "000000 - 6 digits",
            "0000000 - 7 digits"});
            this.comboBox1.Location = new System.Drawing.Point(346, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 4;
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Location = new System.Drawing.Point(323, 69);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(17, 19);
            this.label149.TabIndex = 3;
            this.label149.Text = "+";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(197, 66);
            this.textBox6.MaxLength = 6;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(120, 27);
            this.textBox6.TabIndex = 2;
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Location = new System.Drawing.Point(9, 69);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(163, 19);
            this.label148.TabIndex = 1;
            this.label148.Text = "Create new client Serie:";
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Location = new System.Drawing.Point(9, 32);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(324, 19);
            this.label147.TabIndex = 0;
            this.label147.Text = "Current Client Series: 012-0000, 013-0000, ... etc";
            // 
            // flowLayoutPanel20
            // 
            this.flowLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel20.Location = new System.Drawing.Point(12, 226);
            this.flowLayoutPanel20.Name = "flowLayoutPanel20";
            this.flowLayoutPanel20.Size = new System.Drawing.Size(898, 26);
            this.flowLayoutPanel20.TabIndex = 2;
            // 
            // groupBox47
            // 
            this.groupBox47.Controls.Add(this.tableLayoutPanel18);
            this.groupBox47.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox47.Location = new System.Drawing.Point(12, 12);
            this.groupBox47.Name = "groupBox47";
            this.groupBox47.Size = new System.Drawing.Size(898, 214);
            this.groupBox47.TabIndex = 0;
            this.groupBox47.TabStop = false;
            this.groupBox47.Text = "Summary";
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 2;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel18.Controls.Add(this.flowLayoutPanel19, 1, 3);
            this.tableLayoutPanel18.Controls.Add(this.flowLayoutPanel18, 1, 2);
            this.tableLayoutPanel18.Controls.Add(this.flowLayoutPanel17, 1, 1);
            this.tableLayoutPanel18.Controls.Add(this.label129, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.label139, 0, 1);
            this.tableLayoutPanel18.Controls.Add(this.label140, 0, 2);
            this.tableLayoutPanel18.Controls.Add(this.label141, 0, 3);
            this.tableLayoutPanel18.Controls.Add(this.flowLayoutPanel16, 1, 0);
            this.tableLayoutPanel18.Location = new System.Drawing.Point(6, 38);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 4;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(743, 145);
            this.tableLayoutPanel18.TabIndex = 0;
            // 
            // flowLayoutPanel19
            // 
            this.flowLayoutPanel19.Controls.Add(this.linkLabel3);
            this.flowLayoutPanel19.Controls.Add(this.label146);
            this.flowLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel19.Location = new System.Drawing.Point(140, 108);
            this.flowLayoutPanel19.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel19.Name = "flowLayoutPanel19";
            this.flowLayoutPanel19.Size = new System.Drawing.Size(603, 37);
            this.flowLayoutPanel19.TabIndex = 7;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(3, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(75, 19);
            this.linkLabel3.TabIndex = 0;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "linkLabel3";
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Location = new System.Drawing.Point(84, 0);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(65, 19);
            this.label146.TabIndex = 1;
            this.label146.Text = "label146";
            // 
            // flowLayoutPanel18
            // 
            this.flowLayoutPanel18.Controls.Add(this.label144);
            this.flowLayoutPanel18.Controls.Add(this.label145);
            this.flowLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel18.Location = new System.Drawing.Point(140, 72);
            this.flowLayoutPanel18.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel18.Name = "flowLayoutPanel18";
            this.flowLayoutPanel18.Size = new System.Drawing.Size(603, 36);
            this.flowLayoutPanel18.TabIndex = 6;
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Location = new System.Drawing.Point(3, 0);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(65, 19);
            this.label144.TabIndex = 0;
            this.label144.Text = "label144";
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Location = new System.Drawing.Point(74, 0);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(65, 19);
            this.label145.TabIndex = 1;
            this.label145.Text = "label145";
            // 
            // flowLayoutPanel17
            // 
            this.flowLayoutPanel17.Controls.Add(this.linkLabel2);
            this.flowLayoutPanel17.Controls.Add(this.label143);
            this.flowLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel17.Location = new System.Drawing.Point(140, 36);
            this.flowLayoutPanel17.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel17.Name = "flowLayoutPanel17";
            this.flowLayoutPanel17.Size = new System.Drawing.Size(603, 36);
            this.flowLayoutPanel17.TabIndex = 5;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(3, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(75, 19);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "linkLabel2";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Location = new System.Drawing.Point(84, 0);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(65, 19);
            this.label143.TabIndex = 1;
            this.label143.Text = "label143";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(3, 0);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(111, 19);
            this.label129.TabIndex = 0;
            this.label129.Text = "Email template:";
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(3, 36);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(121, 19);
            this.label139.TabIndex = 1;
            this.label139.Text = "Invoice template:";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(3, 72);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(50, 19);
            this.label140.TabIndex = 2;
            this.label140.Text = "Users:";
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Location = new System.Drawing.Point(3, 108);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(93, 19);
            this.label141.TabIndex = 3;
            this.label141.Text = "SMTP server:";
            // 
            // flowLayoutPanel16
            // 
            this.flowLayoutPanel16.Controls.Add(this.linkLabel1);
            this.flowLayoutPanel16.Controls.Add(this.label142);
            this.flowLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel16.Location = new System.Drawing.Point(140, 0);
            this.flowLayoutPanel16.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel16.Name = "flowLayoutPanel16";
            this.flowLayoutPanel16.Size = new System.Drawing.Size(603, 36);
            this.flowLayoutPanel16.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 19);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Location = new System.Drawing.Point(84, 0);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(65, 19);
            this.label142.TabIndex = 1;
            this.label142.Text = "label142";
            // 
            // tabPage_Settings_EmailTemplates
            // 
            this.tabPage_Settings_EmailTemplates.Controls.Add(this.groupBox42);
            this.tabPage_Settings_EmailTemplates.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Settings_EmailTemplates.Name = "tabPage_Settings_EmailTemplates";
            this.tabPage_Settings_EmailTemplates.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Settings_EmailTemplates.TabIndex = 2;
            this.tabPage_Settings_EmailTemplates.Text = "Email Templates";
            // 
            // groupBox42
            // 
            this.groupBox42.Controls.Add(this.splitContainer21);
            this.groupBox42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox42.Location = new System.Drawing.Point(0, 0);
            this.groupBox42.Name = "groupBox42";
            this.groupBox42.Size = new System.Drawing.Size(922, 609);
            this.groupBox42.TabIndex = 0;
            this.groupBox42.TabStop = false;
            this.groupBox42.Text = "Email Template";
            // 
            // splitContainer21
            // 
            this.splitContainer21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer21.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer21.Location = new System.Drawing.Point(3, 23);
            this.splitContainer21.Name = "splitContainer21";
            this.splitContainer21.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer21.Panel1
            // 
            this.splitContainer21.Panel1.Controls.Add(this.label135);
            this.splitContainer21.Panel1.Controls.Add(this.groupBox43);
            this.splitContainer21.Panel1.Controls.Add(this.textBox5);
            this.splitContainer21.Panel1.Controls.Add(this.label133);
            this.splitContainer21.Panel1.Controls.Add(this.textBox1);
            this.splitContainer21.Panel1.Controls.Add(this.label132);
            // 
            // splitContainer21.Panel2
            // 
            this.splitContainer21.Panel2.Controls.Add(this.splitContainer25);
            this.splitContainer21.Size = new System.Drawing.Size(916, 583);
            this.splitContainer21.SplitterDistance = 268;
            this.splitContainer21.TabIndex = 0;
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Location = new System.Drawing.Point(15, 250);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(112, 19);
            this.label135.TabIndex = 5;
            this.label135.Text = "E-mail template";
            // 
            // groupBox43
            // 
            this.groupBox43.Controls.Add(this.richTextBox_EmailTemplate_Variables);
            this.groupBox43.Controls.Add(this.label134);
            this.groupBox43.Location = new System.Drawing.Point(291, 17);
            this.groupBox43.Name = "groupBox43";
            this.groupBox43.Size = new System.Drawing.Size(453, 224);
            this.groupBox43.TabIndex = 4;
            this.groupBox43.TabStop = false;
            this.groupBox43.Text = "Variables available";
            // 
            // richTextBox_EmailTemplate_Variables
            // 
            this.richTextBox_EmailTemplate_Variables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_EmailTemplate_Variables.Location = new System.Drawing.Point(10, 113);
            this.richTextBox_EmailTemplate_Variables.Name = "richTextBox_EmailTemplate_Variables";
            this.richTextBox_EmailTemplate_Variables.ReadOnly = true;
            this.richTextBox_EmailTemplate_Variables.Size = new System.Drawing.Size(437, 96);
            this.richTextBox_EmailTemplate_Variables.TabIndex = 1;
            this.richTextBox_EmailTemplate_Variables.Text = "";
            // 
            // label134
            // 
            this.label134.Location = new System.Drawing.Point(6, 33);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(441, 107);
            this.label134.TabIndex = 0;
            this.label134.Text = "Please check below the variables you can use in Email subject and the email html " +
    "code.\r\n";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(18, 130);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(240, 27);
            this.textBox5.TabIndex = 3;
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Location = new System.Drawing.Point(14, 108);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(96, 19);
            this.label133.TabIndex = 2;
            this.label133.Text = "Email subject";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Location = new System.Drawing.Point(14, 28);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(93, 19);
            this.label132.TabIndex = 0;
            this.label132.Text = "Sender email";
            // 
            // splitContainer25
            // 
            this.splitContainer25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer25.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer25.Location = new System.Drawing.Point(0, 0);
            this.splitContainer25.Name = "splitContainer25";
            this.splitContainer25.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer25.Panel1
            // 
            this.splitContainer25.Panel1.Controls.Add(this.codeView_EmailTemplates);
            this.splitContainer25.Panel1.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            // 
            // splitContainer25.Panel2
            // 
            this.splitContainer25.Panel2.Controls.Add(this.button1);
            this.splitContainer25.Size = new System.Drawing.Size(916, 311);
            this.splitContainer25.SplitterDistance = 274;
            this.splitContainer25.TabIndex = 0;
            // 
            // codeView_EmailTemplates
            // 
            this.codeView_EmailTemplates.BackColor = System.Drawing.Color.White;
            this.codeView_EmailTemplates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeView_EmailTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeView_EmailTemplates.IsReadOnly = false;
            this.codeView_EmailTemplates.Language = Zeroit.Framework.CodeEditor.TextEditor.CodeView.LanguageMode.Html;
            this.codeView_EmailTemplates.Location = new System.Drawing.Point(12, 4);
            this.codeView_EmailTemplates.Name = "codeView_EmailTemplates";
            this.codeView_EmailTemplates.SecondaryArea = null;
            this.codeView_EmailTemplates.Size = new System.Drawing.Size(892, 266);
            this.codeView_EmailTemplates.Split = false;
            this.codeView_EmailTemplates.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save template";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage_Settings_InvoiceTemplates
            // 
            this.tabPage_Settings_InvoiceTemplates.Controls.Add(this.splitContainer26);
            this.tabPage_Settings_InvoiceTemplates.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Settings_InvoiceTemplates.Name = "tabPage_Settings_InvoiceTemplates";
            this.tabPage_Settings_InvoiceTemplates.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Settings_InvoiceTemplates.TabIndex = 3;
            this.tabPage_Settings_InvoiceTemplates.Text = "Invoice Templates";
            // 
            // splitContainer26
            // 
            this.splitContainer26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer26.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer26.IsSplitterFixed = true;
            this.splitContainer26.Location = new System.Drawing.Point(0, 0);
            this.splitContainer26.Name = "splitContainer26";
            this.splitContainer26.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer26.Panel1
            // 
            this.splitContainer26.Panel1.Controls.Add(this.groupBox44);
            this.splitContainer26.Panel1.Padding = new System.Windows.Forms.Padding(12);
            // 
            // splitContainer26.Panel2
            // 
            this.splitContainer26.Panel2.Controls.Add(this.groupBox46);
            this.splitContainer26.Panel2.Padding = new System.Windows.Forms.Padding(12);
            this.splitContainer26.Size = new System.Drawing.Size(922, 609);
            this.splitContainer26.SplitterDistance = 369;
            this.splitContainer26.TabIndex = 3;
            // 
            // groupBox44
            // 
            this.groupBox44.Controls.Add(this.button3);
            this.groupBox44.Controls.Add(this.groupBox45);
            this.groupBox44.Controls.Add(this.label136);
            this.groupBox44.Controls.Add(this.textBox12);
            this.groupBox44.Controls.Add(this.label131);
            this.groupBox44.Controls.Add(this.textBox_Settings_InvoiceTemplates_CompanyName);
            this.groupBox44.Controls.Add(this.label130);
            this.groupBox44.Controls.Add(this.textBox_InvoiceTemplates_CompanyDetails);
            this.groupBox44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox44.Location = new System.Drawing.Point(12, 12);
            this.groupBox44.Name = "groupBox44";
            this.groupBox44.Size = new System.Drawing.Size(898, 345);
            this.groupBox44.TabIndex = 3;
            this.groupBox44.TabStop = false;
            this.groupBox44.Text = "Invoicing Company Details";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 27);
            this.button3.TabIndex = 9;
            this.button3.Text = "Save details";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox45
            // 
            this.groupBox45.Controls.Add(this.label137);
            this.groupBox45.Controls.Add(this.textBox_InvoiceTemplates_PaymentDetails);
            this.groupBox45.Location = new System.Drawing.Point(376, 26);
            this.groupBox45.Name = "groupBox45";
            this.groupBox45.Size = new System.Drawing.Size(511, 290);
            this.groupBox45.TabIndex = 8;
            this.groupBox45.TabStop = false;
            this.groupBox45.Text = "Payment Details";
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Location = new System.Drawing.Point(7, 33);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(387, 19);
            this.label137.TabIndex = 3;
            this.label137.Text = "Payment details block shown in generated pdf documents.";
            // 
            // textBox_InvoiceTemplates_PaymentDetails
            // 
            this.textBox_InvoiceTemplates_PaymentDetails.Location = new System.Drawing.Point(10, 96);
            this.textBox_InvoiceTemplates_PaymentDetails.Multiline = true;
            this.textBox_InvoiceTemplates_PaymentDetails.Name = "textBox_InvoiceTemplates_PaymentDetails";
            this.textBox_InvoiceTemplates_PaymentDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_InvoiceTemplates_PaymentDetails.Size = new System.Drawing.Size(492, 183);
            this.textBox_InvoiceTemplates_PaymentDetails.TabIndex = 2;
            this.textBox_InvoiceTemplates_PaymentDetails.Text = resources.GetString("textBox_InvoiceTemplates_PaymentDetails.Text");
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Location = new System.Drawing.Point(7, 170);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(117, 19);
            this.label136.TabIndex = 7;
            this.label136.Text = "Company details";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(9, 122);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(214, 27);
            this.textBox12.TabIndex = 6;
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Location = new System.Drawing.Point(7, 100);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(161, 19);
            this.label131.TabIndex = 5;
            this.label131.Text = "Company logo .jpg .png";
            // 
            // textBox_Settings_InvoiceTemplates_CompanyName
            // 
            this.textBox_Settings_InvoiceTemplates_CompanyName.Location = new System.Drawing.Point(9, 58);
            this.textBox_Settings_InvoiceTemplates_CompanyName.Name = "textBox_Settings_InvoiceTemplates_CompanyName";
            this.textBox_Settings_InvoiceTemplates_CompanyName.Size = new System.Drawing.Size(214, 27);
            this.textBox_Settings_InvoiceTemplates_CompanyName.TabIndex = 4;
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Location = new System.Drawing.Point(7, 36);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(109, 19);
            this.label130.TabIndex = 3;
            this.label130.Text = "Company name";
            // 
            // textBox_InvoiceTemplates_CompanyDetails
            // 
            this.textBox_InvoiceTemplates_CompanyDetails.Location = new System.Drawing.Point(9, 192);
            this.textBox_InvoiceTemplates_CompanyDetails.Multiline = true;
            this.textBox_InvoiceTemplates_CompanyDetails.Name = "textBox_InvoiceTemplates_CompanyDetails";
            this.textBox_InvoiceTemplates_CompanyDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_InvoiceTemplates_CompanyDetails.Size = new System.Drawing.Size(345, 112);
            this.textBox_InvoiceTemplates_CompanyDetails.TabIndex = 0;
            this.textBox_InvoiceTemplates_CompanyDetails.Text = "TIN #: 0155444212\r\nVAT #: 0155444212\r\n120 Company Street\r\nNew York NY34883, Unite" +
    "d States";
            // 
            // groupBox46
            // 
            this.groupBox46.Controls.Add(this.splitContainer27);
            this.groupBox46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox46.Location = new System.Drawing.Point(12, 12);
            this.groupBox46.Name = "groupBox46";
            this.groupBox46.Size = new System.Drawing.Size(898, 212);
            this.groupBox46.TabIndex = 0;
            this.groupBox46.TabStop = false;
            this.groupBox46.Text = "Invoice template";
            // 
            // splitContainer27
            // 
            this.splitContainer27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer27.Location = new System.Drawing.Point(3, 23);
            this.splitContainer27.Name = "splitContainer27";
            this.splitContainer27.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer27.Panel1
            // 
            this.splitContainer27.Panel1.Controls.Add(this.label138);
            // 
            // splitContainer27.Panel2
            // 
            this.splitContainer27.Panel2.Controls.Add(this.splitContainer28);
            this.splitContainer27.Size = new System.Drawing.Size(892, 186);
            this.splitContainer27.SplitterDistance = 26;
            this.splitContainer27.TabIndex = 0;
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label138.ForeColor = System.Drawing.Color.DimGray;
            this.label138.Location = new System.Drawing.Point(4, 7);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(182, 18);
            this.label138.TabIndex = 0;
            this.label138.Text = "Invoice template html code.";
            // 
            // splitContainer28
            // 
            this.splitContainer28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer28.Location = new System.Drawing.Point(0, 0);
            this.splitContainer28.Name = "splitContainer28";
            this.splitContainer28.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer28.Panel1
            // 
            this.splitContainer28.Panel1.Controls.Add(this.codeView1);
            this.splitContainer28.Panel1.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            // 
            // splitContainer28.Panel2
            // 
            this.splitContainer28.Panel2.Controls.Add(this.button25);
            this.splitContainer28.Size = new System.Drawing.Size(892, 156);
            this.splitContainer28.SplitterDistance = 120;
            this.splitContainer28.TabIndex = 0;
            // 
            // codeView1
            // 
            this.codeView1.BackColor = System.Drawing.Color.White;
            this.codeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeView1.IsReadOnly = false;
            this.codeView1.Language = Zeroit.Framework.CodeEditor.TextEditor.CodeView.LanguageMode.Csharp;
            this.codeView1.Location = new System.Drawing.Point(6, 4);
            this.codeView1.Name = "codeView1";
            this.codeView1.SecondaryArea = null;
            this.codeView1.Size = new System.Drawing.Size(880, 112);
            this.codeView1.Split = false;
            this.codeView1.TabIndex = 0;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(6, 3);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(120, 27);
            this.button25.TabIndex = 0;
            this.button25.Text = "Save template";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // tabPage_Settings_ManageUsers
            // 
            this.tabPage_Settings_ManageUsers.Controls.Add(this.groupBox_ManageUsers);
            this.tabPage_Settings_ManageUsers.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Settings_ManageUsers.Name = "tabPage_Settings_ManageUsers";
            this.tabPage_Settings_ManageUsers.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Settings_ManageUsers.TabIndex = 4;
            this.tabPage_Settings_ManageUsers.Text = "Manage Users";
            this.tabPage_Settings_ManageUsers.Enter += new System.EventHandler(this.tabPage_Settings_ManageUsers_Enter);
            // 
            // groupBox_ManageUsers
            // 
            this.groupBox_ManageUsers.Controls.Add(this.splitContainer20);
            this.groupBox_ManageUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_ManageUsers.Location = new System.Drawing.Point(0, 0);
            this.groupBox_ManageUsers.Name = "groupBox_ManageUsers";
            this.groupBox_ManageUsers.Size = new System.Drawing.Size(922, 609);
            this.groupBox_ManageUsers.TabIndex = 0;
            this.groupBox_ManageUsers.TabStop = false;
            this.groupBox_ManageUsers.Text = "Manage Users";
            // 
            // splitContainer20
            // 
            this.splitContainer20.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer20.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer20.IsSplitterFixed = true;
            this.splitContainer20.Location = new System.Drawing.Point(3, 23);
            this.splitContainer20.Name = "splitContainer20";
            this.splitContainer20.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer20.Panel1
            // 
            this.splitContainer20.Panel1.Controls.Add(this.label_ManageUsers_Result);
            this.splitContainer20.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer20.Panel2
            // 
            this.splitContainer20.Panel2.Controls.Add(this.dataGridView_ManageUsers);
            this.splitContainer20.Panel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer20.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer20.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer20.Size = new System.Drawing.Size(916, 374);
            this.splitContainer20.SplitterDistance = 25;
            this.splitContainer20.TabIndex = 1;
            // 
            // label_ManageUsers_Result
            // 
            this.label_ManageUsers_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_ManageUsers_Result.AutoSize = true;
            this.label_ManageUsers_Result.Location = new System.Drawing.Point(3, 6);
            this.label_ManageUsers_Result.Name = "label_ManageUsers_Result";
            this.label_ManageUsers_Result.Size = new System.Drawing.Size(72, 19);
            this.label_ManageUsers_Result.TabIndex = 0;
            this.label_ManageUsers_Result.Text = "[0] Users.";
            // 
            // dataGridView_ManageUsers
            // 
            this.dataGridView_ManageUsers.AllowUserToAddRows = false;
            this.dataGridView_ManageUsers.AllowUserToDeleteRows = false;
            this.dataGridView_ManageUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ManageUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewColumn_ManageUsers_Username,
            this.dataGridViewColumn_ManageUsers_Active,
            this.dataGridViewColumn_ManageUsers_Created,
            this.dataGridViewColumn_ManageUsers_PasswordRecovery,
            this.dataGridViewColumn_ManageUsers_Edit});
            this.dataGridView_ManageUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ManageUsers.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_ManageUsers.Name = "dataGridView_ManageUsers";
            this.dataGridView_ManageUsers.ReadOnly = true;
            this.dataGridView_ManageUsers.RowHeadersVisible = false;
            this.dataGridView_ManageUsers.Size = new System.Drawing.Size(904, 333);
            this.dataGridView_ManageUsers.TabIndex = 0;
            this.dataGridView_ManageUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ManageUsers_CellClick);
            // 
            // dataGridViewColumn_ManageUsers_Username
            // 
            this.dataGridViewColumn_ManageUsers_Username.HeaderText = "Username";
            this.dataGridViewColumn_ManageUsers_Username.Name = "dataGridViewColumn_ManageUsers_Username";
            this.dataGridViewColumn_ManageUsers_Username.ReadOnly = true;
            this.dataGridViewColumn_ManageUsers_Username.Width = 200;
            // 
            // dataGridViewColumn_ManageUsers_Active
            // 
            this.dataGridViewColumn_ManageUsers_Active.HeaderText = "Active";
            this.dataGridViewColumn_ManageUsers_Active.Name = "dataGridViewColumn_ManageUsers_Active";
            this.dataGridViewColumn_ManageUsers_Active.ReadOnly = true;
            // 
            // dataGridViewColumn_ManageUsers_Created
            // 
            this.dataGridViewColumn_ManageUsers_Created.HeaderText = "Created";
            this.dataGridViewColumn_ManageUsers_Created.Name = "dataGridViewColumn_ManageUsers_Created";
            this.dataGridViewColumn_ManageUsers_Created.ReadOnly = true;
            this.dataGridViewColumn_ManageUsers_Created.Width = 150;
            // 
            // dataGridViewColumn_ManageUsers_PasswordRecovery
            // 
            this.dataGridViewColumn_ManageUsers_PasswordRecovery.HeaderText = "Password Recovery";
            this.dataGridViewColumn_ManageUsers_PasswordRecovery.Name = "dataGridViewColumn_ManageUsers_PasswordRecovery";
            this.dataGridViewColumn_ManageUsers_PasswordRecovery.ReadOnly = true;
            this.dataGridViewColumn_ManageUsers_PasswordRecovery.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumn_ManageUsers_PasswordRecovery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewColumn_ManageUsers_PasswordRecovery.Width = 200;
            // 
            // dataGridViewColumn_ManageUsers_Edit
            // 
            this.dataGridViewColumn_ManageUsers_Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumn_ManageUsers_Edit.HeaderText = "Edit";
            this.dataGridViewColumn_ManageUsers_Edit.Name = "dataGridViewColumn_ManageUsers_Edit";
            this.dataGridViewColumn_ManageUsers_Edit.ReadOnly = true;
            this.dataGridViewColumn_ManageUsers_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColumn_ManageUsers_Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage_Settings_SMTPServer
            // 
            this.tabPage_Settings_SMTPServer.Controls.Add(this.groupBox41);
            this.tabPage_Settings_SMTPServer.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Settings_SMTPServer.Name = "tabPage_Settings_SMTPServer";
            this.tabPage_Settings_SMTPServer.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Settings_SMTPServer.TabIndex = 5;
            this.tabPage_Settings_SMTPServer.Text = "SMTP Server";
            // 
            // groupBox41
            // 
            this.groupBox41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox41.Location = new System.Drawing.Point(0, 0);
            this.groupBox41.Name = "groupBox41";
            this.groupBox41.Size = new System.Drawing.Size(922, 609);
            this.groupBox41.TabIndex = 0;
            this.groupBox41.TabStop = false;
            this.groupBox41.Text = "SMTP server details";
            // 
            // tabPage_Import
            // 
            this.tabPage_Import.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Import.Name = "tabPage_Import";
            this.tabPage_Import.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Import.Size = new System.Drawing.Size(936, 647);
            this.tabPage_Import.TabIndex = 5;
            this.tabPage_Import.Text = "Import";
            // 
            // tabPage_Reports
            // 
            this.tabPage_Reports.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Reports.Name = "tabPage_Reports";
            this.tabPage_Reports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Reports.Size = new System.Drawing.Size(936, 647);
            this.tabPage_Reports.TabIndex = 6;
            this.tabPage_Reports.Text = "Reports";
            // 
            // tabPage_Help
            // 
            this.tabPage_Help.Controls.Add(this.tabControl_Help);
            this.tabPage_Help.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Help.Name = "tabPage_Help";
            this.tabPage_Help.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Help.Size = new System.Drawing.Size(936, 647);
            this.tabPage_Help.TabIndex = 7;
            this.tabPage_Help.Text = "Help";
            // 
            // tabControl_Help
            // 
            this.tabControl_Help.Controls.Add(this.tabPage_AboutUs);
            this.tabControl_Help.Controls.Add(this.tabPage_Licence);
            this.tabControl_Help.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl_Help.DisplayStyle = TradeWright.UI.Forms.TabStyle.Angled;
            // 
            // 
            // 
            this.tabControl_Help.DisplayStyleProvider.BlendStyle = TradeWright.UI.Forms.BlendStyle.Normal;
            this.tabControl_Help.DisplayStyleProvider.BorderColorDisabled = System.Drawing.SystemColors.ControlLight;
            this.tabControl_Help.DisplayStyleProvider.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControl_Help.DisplayStyleProvider.BorderColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Help.DisplayStyleProvider.BorderColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Help.DisplayStyleProvider.BorderColorUnselected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Help.DisplayStyleProvider.CloserButtonFillColorFocused = System.Drawing.Color.Empty;
            this.tabControl_Help.DisplayStyleProvider.CloserButtonFillColorFocusedActive = System.Drawing.Color.Empty;
            this.tabControl_Help.DisplayStyleProvider.CloserButtonFillColorHighlighted = System.Drawing.Color.Empty;
            this.tabControl_Help.DisplayStyleProvider.CloserButtonFillColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabControl_Help.DisplayStyleProvider.CloserButtonFillColorSelected = System.Drawing.Color.Empty;
            this.tabControl_Help.DisplayStyleProvider.CloserButtonFillColorSelectedActive = System.Drawing.Color.Empty;
            this.tabControl_Help.DisplayStyleProvider.CloserButtonFillColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Help.DisplayStyleProvider.CloserButtonOutlineColorFocused = System.Drawing.Color.Empty;
            this.tabControl_Help.DisplayStyleProvider.CloserButtonOutlineColorFocusedActive = System.Drawing.Color.Empty;
            this.tabControl_Help.DisplayStyleProvider.CloserButtonOutlineColorHighlighted = System.Drawing.Color.Empty;
            this.tabControl_Help.DisplayStyleProvider.CloserButtonOutlineColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabControl_Help.DisplayStyleProvider.CloserButtonOutlineColorSelected = System.Drawing.Color.Empty;
            this.tabControl_Help.DisplayStyleProvider.CloserButtonOutlineColorSelectedActive = System.Drawing.Color.Empty;
            this.tabControl_Help.DisplayStyleProvider.CloserButtonOutlineColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Help.DisplayStyleProvider.CloserColorFocused = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Help.DisplayStyleProvider.CloserColorFocusedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Help.DisplayStyleProvider.CloserColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Help.DisplayStyleProvider.CloserColorHighlightedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Help.DisplayStyleProvider.CloserColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Help.DisplayStyleProvider.CloserColorSelectedActive = System.Drawing.SystemColors.ControlDark;
            this.tabControl_Help.DisplayStyleProvider.CloserColorUnselected = System.Drawing.Color.Empty;
            this.tabControl_Help.DisplayStyleProvider.FocusTrack = false;
            this.tabControl_Help.DisplayStyleProvider.HotTrack = true;
            this.tabControl_Help.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tabControl_Help.DisplayStyleProvider.Opacity = 1F;
            this.tabControl_Help.DisplayStyleProvider.Overlap = 8;
            this.tabControl_Help.DisplayStyleProvider.Padding = new System.Drawing.Point(8, 4);
            this.tabControl_Help.DisplayStyleProvider.PageBackgroundColorDisabled = System.Drawing.SystemColors.Control;
            this.tabControl_Help.DisplayStyleProvider.PageBackgroundColorFocused = System.Drawing.SystemColors.ControlLight;
            this.tabControl_Help.DisplayStyleProvider.PageBackgroundColorHighlighted = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabControl_Help.DisplayStyleProvider.PageBackgroundColorSelected = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Help.DisplayStyleProvider.PageBackgroundColorUnselected = System.Drawing.SystemColors.Control;
            this.tabControl_Help.DisplayStyleProvider.Radius = 12;
            this.tabControl_Help.DisplayStyleProvider.SelectedTabIsLarger = true;
            this.tabControl_Help.DisplayStyleProvider.ShowTabCloser = false;
            this.tabControl_Help.DisplayStyleProvider.TabColorDisabled1 = System.Drawing.SystemColors.Control;
            this.tabControl_Help.DisplayStyleProvider.TabColorDisabled2 = System.Drawing.SystemColors.Control;
            this.tabControl_Help.DisplayStyleProvider.TabColorFocused1 = System.Drawing.Color.White;
            this.tabControl_Help.DisplayStyleProvider.TabColorFocused2 = System.Drawing.Color.White;
            this.tabControl_Help.DisplayStyleProvider.TabColorHighLighted1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabControl_Help.DisplayStyleProvider.TabColorHighLighted2 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.tabControl_Help.DisplayStyleProvider.TabColorSelected1 = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Help.DisplayStyleProvider.TabColorSelected2 = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl_Help.DisplayStyleProvider.TabColorUnSelected1 = System.Drawing.SystemColors.Control;
            this.tabControl_Help.DisplayStyleProvider.TabColorUnSelected2 = System.Drawing.SystemColors.Control;
            this.tabControl_Help.DisplayStyleProvider.TabPageMargin = new System.Windows.Forms.Padding(1);
            this.tabControl_Help.DisplayStyleProvider.TextColorFocused = System.Drawing.SystemColors.ControlText;
            this.tabControl_Help.DisplayStyleProvider.TextColorHighlighted = System.Drawing.SystemColors.ControlText;
            this.tabControl_Help.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.tabControl_Help.DisplayStyleProvider.TextColorUnselected = System.Drawing.SystemColors.ControlDarkDark;
            this.tabControl_Help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Help.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Help.HotTrack = true;
            this.tabControl_Help.Location = new System.Drawing.Point(3, 3);
            this.tabControl_Help.Name = "tabControl_Help";
            this.tabControl_Help.SelectedIndex = 0;
            this.tabControl_Help.Size = new System.Drawing.Size(930, 641);
            this.tabControl_Help.TabIndex = 4;
            // 
            // tabPage_AboutUs
            // 
            this.tabPage_AboutUs.Location = new System.Drawing.Point(4, 28);
            this.tabPage_AboutUs.Name = "tabPage_AboutUs";
            this.tabPage_AboutUs.Size = new System.Drawing.Size(922, 609);
            this.tabPage_AboutUs.TabIndex = 0;
            this.tabPage_AboutUs.Text = "About us";
            // 
            // tabPage_Licence
            // 
            this.tabPage_Licence.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Licence.Name = "tabPage_Licence";
            this.tabPage_Licence.Size = new System.Drawing.Size(922, 609);
            this.tabPage_Licence.TabIndex = 1;
            this.tabPage_Licence.Text = "Licence";
            // 
            // saveFileDialog_PDF
            // 
            this.saveFileDialog_PDF.DefaultExt = "pdf";
            this.saveFileDialog_PDF.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            this.saveFileDialog_PDF.Title = "Save as PDF";
            // 
            // toolTipValidation1
            // 
            this.toolTipValidation1.AutoPopDelay = 5000;
            this.toolTipValidation1.InitialDelay = 500;
            this.toolTipValidation1.OwnerDraw = true;
            this.toolTipValidation1.ReshowDelay = 100;
            // 
            // toolTipValidation2
            // 
            this.toolTipValidation2.OwnerDraw = true;
            // 
            // toolTipValidation3
            // 
            this.toolTipValidation3.OwnerDraw = true;
            // 
            // toolTipValidation4
            // 
            this.toolTipValidation4.OwnerDraw = true;
            // 
            // toolTipValidation5
            // 
            this.toolTipValidation5.OwnerDraw = true;
            // 
            // toolTipValidation6
            // 
            this.toolTipValidation6.OwnerDraw = true;
            // 
            // toolTipValidation7
            // 
            this.toolTipValidation7.OwnerDraw = true;
            // 
            // toolTipValidation8
            // 
            this.toolTipValidation8.OwnerDraw = true;
            // 
            // toolTipValidation9
            // 
            this.toolTipValidation9.OwnerDraw = true;
            // 
            // toolTipValidation10
            // 
            this.toolTipValidation10.OwnerDraw = true;
            // 
            // toolTipValidation11
            // 
            this.toolTipValidation11.OwnerDraw = true;
            // 
            // toolTipValidation12
            // 
            this.toolTipValidation12.OwnerDraw = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.tabControl_Root);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAS Invoice";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl_Root.ResumeLayout(false);
            this.tabPage_Dashboard.ResumeLayout(false);
            this.tabControl_Dashboard.ResumeLayout(false);
            this.tabPage_Dashboard_Summary.ResumeLayout(false);
            this.splitContainer_Dashboard_Summary_2.Panel1.ResumeLayout(false);
            this.splitContainer_Dashboard_Summary_2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Dashboard_Summary_2)).EndInit();
            this.splitContainer_Dashboard_Summary_2.ResumeLayout(false);
            this.splitContainer_Dashboard_Summary_1.Panel1.ResumeLayout(false);
            this.splitContainer_Dashboard_Summary_1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Dashboard_Summary_1)).EndInit();
            this.splitContainer_Dashboard_Summary_1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Summary_RecentInvoices)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Summary_PastDueInvoices)).EndInit();
            this.splitContainer_Dashboard_Summary_3.Panel1.ResumeLayout(false);
            this.splitContainer_Dashboard_Summary_3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Dashboard_Summary_3)).EndInit();
            this.splitContainer_Dashboard_Summary_3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tabPage_Clients.ResumeLayout(false);
            this.tabControl_Clients.ResumeLayout(false);
            this.tabPage_SearchClients.ResumeLayout(false);
            this.splitContainer_Clients_SearchClients.Panel1.ResumeLayout(false);
            this.splitContainer_Clients_SearchClients.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Clients_SearchClients)).EndInit();
            this.splitContainer_Clients_SearchClients.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer_Clients_SearchClients_Clients.Panel1.ResumeLayout(false);
            this.splitContainer_Clients_SearchClients_Clients.Panel1.PerformLayout();
            this.splitContainer_Clients_SearchClients_Clients.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Clients_SearchClients_Clients)).EndInit();
            this.splitContainer_Clients_SearchClients_Clients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchClient)).EndInit();
            this.tabPage_EditClient.ResumeLayout(false);
            this.groupBox_EditClient.ResumeLayout(false);
            this.groupBox36.ResumeLayout(false);
            this.groupBox36.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel12.PerformLayout();
            this.flowLayoutPanel13.ResumeLayout(false);
            this.flowLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EditClient_VATPercent)).EndInit();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tabPage_CreateClient.ResumeLayout(false);
            this.groupBox_CreateClient_createClient.ResumeLayout(false);
            this.groupBox_CreateClient_ClientSettings.ResumeLayout(false);
            this.groupBox_CreateClient_ClientSettings.PerformLayout();
            this.tableLayoutPanel_CreateClient_ClientSettings.ResumeLayout(false);
            this.tableLayoutPanel_CreateClient_ClientSettings.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CreateClient_VATPercent)).EndInit();
            this.tableLayoutPanel_Clients_CreateClient.ResumeLayout(false);
            this.tableLayoutPanel_Clients_CreateClient.PerformLayout();
            this.tabPage_Invoices.ResumeLayout(false);
            this.tabControl_Invoices.ResumeLayout(false);
            this.tabPage_Invoices_SearchInvoice.ResumeLayout(false);
            this.splitContainer_SearchInvoice_Root.Panel1.ResumeLayout(false);
            this.splitContainer_SearchInvoice_Root.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_SearchInvoice_Root)).EndInit();
            this.splitContainer_SearchInvoice_Root.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchInvoice)).EndInit();
            this.tabPage_Invoices_EditInvoice.ResumeLayout(false);
            this.splitContainer_EditInvoice_Root.Panel1.ResumeLayout(false);
            this.splitContainer_EditInvoice_Root.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_EditInvoice_Root)).EndInit();
            this.splitContainer_EditInvoice_Root.ResumeLayout(false);
            this.splitContainer_EditInvoice_Client.Panel1.ResumeLayout(false);
            this.splitContainer_EditInvoice_Client.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_EditInvoice_Client)).EndInit();
            this.splitContainer_EditInvoice_Client.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel_EditInvoice_SelectClient.ResumeLayout(false);
            this.panel_EditInvoice_SelectClient.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_EditInvoice_InvoiceItem)).EndInit();
            this.splitContainer13.Panel1.ResumeLayout(false);
            this.splitContainer13.Panel2.ResumeLayout(false);
            this.splitContainer13.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer13)).EndInit();
            this.splitContainer13.ResumeLayout(false);
            this.splitContainer14.Panel1.ResumeLayout(false);
            this.splitContainer14.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer14)).EndInit();
            this.splitContainer14.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EditInvoice_VAT_Percent)).EndInit();
            this.tabPage_Invoices_CreateInvoice.ResumeLayout(false);
            this.splitContainer_CreateInvoice_Root.Panel1.ResumeLayout(false);
            this.splitContainer_CreateInvoice_Root.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_CreateInvoice_Root)).EndInit();
            this.splitContainer_CreateInvoice_Root.ResumeLayout(false);
            this.splitContainer_CreateInvoice_Client.Panel1.ResumeLayout(false);
            this.splitContainer_CreateInvoice_Client.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_CreateInvoice_Client)).EndInit();
            this.splitContainer_CreateInvoice_Client.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel_CreateInvoice_SelectClient.ResumeLayout(false);
            this.panel_CreateInvoice_SelectClient.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.splitContainer_Dashboard_CreateInvoice_Bottom.Panel1.ResumeLayout(false);
            this.splitContainer_Dashboard_CreateInvoice_Bottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Dashboard_CreateInvoice_Bottom)).EndInit();
            this.splitContainer_Dashboard_CreateInvoice_Bottom.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CreateInvoice_InvoiceItem)).EndInit();
            this.splitContainer11.Panel1.ResumeLayout(false);
            this.splitContainer11.Panel2.ResumeLayout(false);
            this.splitContainer11.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).EndInit();
            this.splitContainer11.ResumeLayout(false);
            this.splitContainer12.Panel1.ResumeLayout(false);
            this.splitContainer12.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer12)).EndInit();
            this.splitContainer12.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox26.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CreateInvoice_VAT_Percent)).EndInit();
            this.tabPage_Invoices_CreateRecurringInvoice.ResumeLayout(false);
            this.splitContainer_CreateRecurringInvoice_Root.Panel1.ResumeLayout(false);
            this.splitContainer_CreateRecurringInvoice_Root.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_CreateRecurringInvoice_Root)).EndInit();
            this.splitContainer_CreateRecurringInvoice_Root.ResumeLayout(false);
            this.splitContainer_CreateRecurringInvoice_Client.Panel1.ResumeLayout(false);
            this.splitContainer_CreateRecurringInvoice_Client.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_CreateRecurringInvoice_Client)).EndInit();
            this.splitContainer_CreateRecurringInvoice_Client.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.panel_CreateRecurringInvoice_SelectClient.ResumeLayout(false);
            this.panel_CreateRecurringInvoice_SelectClient.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CreateRecurringInvoice_NextDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CreateRecurringInvoice_DueDays)).EndInit();
            this.splitContainer_CreateRecurringInvoice_Bottom.Panel1.ResumeLayout(false);
            this.splitContainer_CreateRecurringInvoice_Bottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_CreateRecurringInvoice_Bottom)).EndInit();
            this.splitContainer_CreateRecurringInvoice_Bottom.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CreateRecurringInvoice_InvoiceItem)).EndInit();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CreateRecurringInvoice_VAT_Percent)).EndInit();
            this.tabPage_Invoices_PendingInvoices.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel1.PerformLayout();
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PendingInvoices)).EndInit();
            this.tabPage_Invoices_RecurringInvoices.ResumeLayout(false);
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.splitContainer10.Panel1.ResumeLayout(false);
            this.splitContainer10.Panel1.PerformLayout();
            this.splitContainer10.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).EndInit();
            this.splitContainer10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RecurringInvoices)).EndInit();
            this.tabPage_Invoices_EditRecurringInvoice.ResumeLayout(false);
            this.splitContainer_EditRecurringInvoice_Root.Panel1.ResumeLayout(false);
            this.splitContainer_EditRecurringInvoice_Root.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_EditRecurringInvoice_Root)).EndInit();
            this.splitContainer_EditRecurringInvoice_Root.ResumeLayout(false);
            this.splitContainer_EditRecurringInvoice_Client.Panel1.ResumeLayout(false);
            this.splitContainer_EditRecurringInvoice_Client.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_EditRecurringInvoice_Client)).EndInit();
            this.splitContainer_EditRecurringInvoice_Client.ResumeLayout(false);
            this.groupBox35.ResumeLayout(false);
            this.groupBox35.PerformLayout();
            this.panel_EditRecurringInvoice_SelectClient.ResumeLayout(false);
            this.panel_EditRecurringInvoice_SelectClient.PerformLayout();
            this.groupBox37.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.flowLayoutPanel14.ResumeLayout(false);
            this.flowLayoutPanel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EditRecurringInvoice_NextDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EditRecurringInvoice_DueDays)).EndInit();
            this.splitContainer22.Panel1.ResumeLayout(false);
            this.splitContainer22.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer22)).EndInit();
            this.splitContainer22.ResumeLayout(false);
            this.groupBox38.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_EditRecurringInvoice_InvoiceItem)).EndInit();
            this.splitContainer23.Panel1.ResumeLayout(false);
            this.splitContainer23.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer23)).EndInit();
            this.splitContainer23.ResumeLayout(false);
            this.splitContainer24.Panel1.ResumeLayout(false);
            this.splitContainer24.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer24)).EndInit();
            this.splitContainer24.ResumeLayout(false);
            this.groupBox39.ResumeLayout(false);
            this.groupBox39.PerformLayout();
            this.groupBox40.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.flowLayoutPanel15.ResumeLayout(false);
            this.flowLayoutPanel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EditRecurringInvoice_VAT_Percent)).EndInit();
            this.tabPage_Payments.ResumeLayout(false);
            this.tabControl_Payments.ResumeLayout(false);
            this.tabPage_Payments_PostPayment.ResumeLayout(false);
            this.groupBox_PostPayment.ResumeLayout(false);
            this.tableLayoutPanel_PostPayment.ResumeLayout(false);
            this.tableLayoutPanel_PostPayment.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.tabPage_Payments_EditPayment.ResumeLayout(false);
            this.splitContainer15.Panel1.ResumeLayout(false);
            this.splitContainer15.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer15)).EndInit();
            this.splitContainer15.ResumeLayout(false);
            this.splitContainer16.Panel1.ResumeLayout(false);
            this.splitContainer16.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer16)).EndInit();
            this.splitContainer16.ResumeLayout(false);
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox31.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.splitContainer17.Panel1.ResumeLayout(false);
            this.splitContainer17.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer17)).EndInit();
            this.splitContainer17.ResumeLayout(false);
            this.groupBox32.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustom3)).EndInit();
            this.splitContainer18.Panel1.ResumeLayout(false);
            this.splitContainer18.Panel2.ResumeLayout(false);
            this.splitContainer18.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer18)).EndInit();
            this.splitContainer18.ResumeLayout(false);
            this.splitContainer19.Panel1.ResumeLayout(false);
            this.splitContainer19.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer19)).EndInit();
            this.splitContainer19.ResumeLayout(false);
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            this.groupBox34.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage_Payments_SearchPayment.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox28.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.groupBox29.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchPayment)).EndInit();
            this.tabPage_Settings.ResumeLayout(false);
            this.tabControl_Settings.ResumeLayout(false);
            this.tabPage_Settings_General.ResumeLayout(false);
            this.groupBox49.ResumeLayout(false);
            this.groupBox49.PerformLayout();
            this.groupBox48.ResumeLayout(false);
            this.groupBox48.PerformLayout();
            this.groupBox47.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.flowLayoutPanel19.ResumeLayout(false);
            this.flowLayoutPanel19.PerformLayout();
            this.flowLayoutPanel18.ResumeLayout(false);
            this.flowLayoutPanel18.PerformLayout();
            this.flowLayoutPanel17.ResumeLayout(false);
            this.flowLayoutPanel17.PerformLayout();
            this.flowLayoutPanel16.ResumeLayout(false);
            this.flowLayoutPanel16.PerformLayout();
            this.tabPage_Settings_EmailTemplates.ResumeLayout(false);
            this.groupBox42.ResumeLayout(false);
            this.splitContainer21.Panel1.ResumeLayout(false);
            this.splitContainer21.Panel1.PerformLayout();
            this.splitContainer21.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer21)).EndInit();
            this.splitContainer21.ResumeLayout(false);
            this.groupBox43.ResumeLayout(false);
            this.splitContainer25.Panel1.ResumeLayout(false);
            this.splitContainer25.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer25)).EndInit();
            this.splitContainer25.ResumeLayout(false);
            this.tabPage_Settings_InvoiceTemplates.ResumeLayout(false);
            this.splitContainer26.Panel1.ResumeLayout(false);
            this.splitContainer26.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer26)).EndInit();
            this.splitContainer26.ResumeLayout(false);
            this.groupBox44.ResumeLayout(false);
            this.groupBox44.PerformLayout();
            this.groupBox45.ResumeLayout(false);
            this.groupBox45.PerformLayout();
            this.groupBox46.ResumeLayout(false);
            this.splitContainer27.Panel1.ResumeLayout(false);
            this.splitContainer27.Panel1.PerformLayout();
            this.splitContainer27.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer27)).EndInit();
            this.splitContainer27.ResumeLayout(false);
            this.splitContainer28.Panel1.ResumeLayout(false);
            this.splitContainer28.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer28)).EndInit();
            this.splitContainer28.ResumeLayout(false);
            this.tabPage_Settings_ManageUsers.ResumeLayout(false);
            this.groupBox_ManageUsers.ResumeLayout(false);
            this.splitContainer20.Panel1.ResumeLayout(false);
            this.splitContainer20.Panel1.PerformLayout();
            this.splitContainer20.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer20)).EndInit();
            this.splitContainer20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManageUsers)).EndInit();
            this.tabPage_Settings_SMTPServer.ResumeLayout(false);
            this.tabPage_Help.ResumeLayout(false);
            this.tabControl_Help.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage_Dashboard;
        private System.Windows.Forms.TabPage tabPage_Clients;
        private TradeWright.UI.Forms.TabControlExtra tabControl_Root;
        private TradeWright.UI.Forms.TabControlExtra tabControl_Dashboard;
        private System.Windows.Forms.TabPage tabPage_Dashboard_Summary;
        private System.Windows.Forms.TabPage tabPage_Dashboard_CreateInvoice;
        private System.Windows.Forms.TabPage tabPage_Dashboard_SearchInvoice;
        private System.Windows.Forms.TabPage tabPage_Dashboard_PostPayment;
        private System.Windows.Forms.TabPage tabPage_Dashboard_InvoiceReport;
        private System.Windows.Forms.TabPage tabPage_Dashboard_PaymentReport;
        private TradeWright.UI.Forms.TabControlExtra tabControl_Clients;
        private System.Windows.Forms.TabPage tabPage_SearchClients;
        private System.Windows.Forms.TabPage tabPage_CreateClient;
        private System.Windows.Forms.TabPage tabPage_Invoices;
        private System.Windows.Forms.TabPage tabPage_Payments;
        private System.Windows.Forms.TabPage tabPage_Settings;
        private System.Windows.Forms.TabPage tabPage_Import;
        private System.Windows.Forms.TabPage tabPage_Reports;
        private System.Windows.Forms.TabPage tabPage_Help;
        private System.Windows.Forms.GroupBox groupBox_CreateClient_createClient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Clients_CreateClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_CreateClient_FirstName;
        private TradeWright.UI.Forms.TabControlExtra tabControl_Invoices;
        private System.Windows.Forms.TabPage tabPage_Invoices_SearchInvoice;
        private System.Windows.Forms.TabPage tabPage_Invoices_CreateInvoice;
        private System.Windows.Forms.TabPage tabPage_Invoices_CreateRecurringInvoice;
        private System.Windows.Forms.TabPage tabPage_Invoices_PendingInvoices;
        private System.Windows.Forms.TabPage tabPage_Invoices_RecurringInvoices;
        private TradeWright.UI.Forms.TabControlExtra tabControl_Settings;
        private System.Windows.Forms.TabPage tabPage_Settings_General;
        private System.Windows.Forms.TabPage tabPage_Settings_EmailTemplates;
        private System.Windows.Forms.TabPage tabPage_Settings_InvoiceTemplates;
        private System.Windows.Forms.TabPage tabPage_Settings_ManageUsers;
        private System.Windows.Forms.TabPage tabPage_Settings_SMTPServer;
        private System.Windows.Forms.TextBox textBox_CreateClient_LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_CreateClient_Company;
        private System.Windows.Forms.TextBox textBox_CreateClient_TIN;
        private System.Windows.Forms.TextBox textBox_CreateClient_VAT;
        private System.Windows.Forms.TextBox textBox_CreateClient_Phone;
        private System.Windows.Forms.TextBox textBox_CreateClient_Email;
        private System.Windows.Forms.TextBox textBox_CreateClient_Address1;
        private System.Windows.Forms.TextBox textBox_CreateClient_Address2;
        private System.Windows.Forms.TextBox textBox_CreateClient_City;
        private System.Windows.Forms.TextBox textBox_CreateClient_State;
        private System.Windows.Forms.TextBox textBox_CreateClient_PostalCode;
        private System.Windows.Forms.ComboBox comboBox_CreateClient_Country;
        private System.Windows.Forms.GroupBox groupBox_CreateClient_ClientSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_CreateClient_ClientSettings;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox_CreateClient_ClientStatus;
        private System.Windows.Forms.ComboBox comboBox_CreateClient_ClientIDAssign;
        private System.Windows.Forms.ComboBox comboBox_CreateClient_InvoiceIDAssign;
        private System.Windows.Forms.ComboBox comboBox_CreateClient_InvoiceTemplate;
        private System.Windows.Forms.ComboBox comboBox_CreateClient_Currency;
        private System.Windows.Forms.Label label_CreateClient_Message;
        private System.Windows.Forms.Button button_CreateClient_Save;
        private System.Windows.Forms.TextBox textBox_CreateClient_Notes;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton_CreateClient_VATApplicable_Yes;
        private System.Windows.Forms.RadioButton radioButton_CreateClient_VATApplicable_No;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.NumericUpDown numericUpDown_CreateClient_VATPercent;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.SplitContainer splitContainer_Clients_SearchClients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox_Clients_SearchClients_ClientName;
        private System.Windows.Forms.TextBox textBox_Clients_SearchClients_ClientID;
        private System.Windows.Forms.TextBox textBox_Clients_SearchClients_Company;
        private System.Windows.Forms.TextBox textBox_Clients_SearchClients_Email;
        private System.Windows.Forms.ComboBox comboBox_Clients_SearchClients_Country;
        private System.Windows.Forms.ComboBox comboBox_Clients_SearchClients_ClientStatus;
        private System.Windows.Forms.Button button_Clients_SearchClients_Search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer_Clients_SearchClients_Clients;
        private System.Windows.Forms.Label label_Clients_SearchClients_Result;
        private System.Windows.Forms.DataGridView dataGridView_SearchClient;
        private System.Windows.Forms.SplitContainer splitContainer_Dashboard_Summary_2;
        private System.Windows.Forms.SplitContainer splitContainer_Dashboard_Summary_3;
        private System.Windows.Forms.SplitContainer splitContainer_Dashboard_Summary_1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dataGridView_Summary_RecentInvoices;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridView dataGridView_Summary_PastDueInvoices;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBox_Summary_SystemStatus;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBox_Summary_UserStatus;
        private System.Windows.Forms.SplitContainer splitContainer_CreateRecurringInvoice_Root;
        private System.Windows.Forms.SplitContainer splitContainer_CreateRecurringInvoice_Bottom;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Button button_RecurringInvoices_Search;
        private System.Windows.Forms.ComboBox comboBox_RecurringInvoices_Client;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.SplitContainer splitContainer10;
        private System.Windows.Forms.Label label_RecurringInvoices_Result;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox textBox_PendingInvoices_InvoiceID;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Button button_PendingInvoices_Search;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.ComboBox comboBox_PendingInvoices_Client;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.DateTimePicker dateTimePicker_PendingInvoices_DateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePicker_PendingInvoices_DateTo;
        private control.GridViewCustom gridView_CreateRecurringInvoice_InvoiceItem;
        private control.GridViewCustom dataGridView_RecurringInvoices;
        private System.Windows.Forms.SplitContainer splitContainer_CreateRecurringInvoice_Client;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button button_CreateRecurringInvoice_ChangeClient;
        private System.Windows.Forms.Panel panel_CreateRecurringInvoice_SelectClient;
        private System.Windows.Forms.Button button_CreateRecurringInvoice_SelectClient;
        private System.Windows.Forms.ComboBox comboBox_CreateRecurringInvoice_SelectClient;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBox_CreateRecurringInvoice_ClientDetail;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox textBox_CreateRecurringInvoice_InvoiceID;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CreateRecurringInvoice_DueDate;
        private System.Windows.Forms.ComboBox comboBox_CreateRecurringInvoice_Status;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TextBox textBox_CreateRecurringInvoice_Comments;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label_CreateRecurringInvoice_Total;
        private System.Windows.Forms.TextBox textBox_CreateRecurringInvoice_SubTotal;
        private System.Windows.Forms.TextBox textBox_CreateRecurringInvoice_VAT_Value;
        private System.Windows.Forms.TextBox textBox_CreateRecurringInvoice_GrandTotal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.NumericUpDown numericUpDown_CreateRecurringInvoice_VAT_Percent;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button_CreateRecurringInvoice_SaveInvoice;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.Label label_PendingInvoices_Result;
        private control.GridViewCustom dataGridView_PendingInvoices;
        private System.Windows.Forms.SplitContainer splitContainer_SearchInvoice_Root;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox textBox_SearchInvoice_InvoiceID;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button button_SearchInvoice_Search;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ComboBox comboBox_SearchInvoice_Client;
        private System.Windows.Forms.ComboBox comboBox_SearchInvoice_InvoiceStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SearchInvoice_DateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SearchInvoice_DateTo;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label_SearchInvoice_Result;
        private control.GridViewCustom dataGridView_SearchInvoice;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn_SearchInvoice_Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_SearchInvoice_Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_SearchInvoice_Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_SearchInvoice_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_SearchInvoice_Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_SearchInvoice_DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_SearchInvoice_Status;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn_SearchInvoice_View;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn_SearchInvoice_Edit;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn_SearchInvoice_Delete;
        private System.Windows.Forms.SplitContainer splitContainer_CreateInvoice_Root;
        private System.Windows.Forms.SplitContainer splitContainer_CreateInvoice_Client;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_CreateInvoice_ChangeClient;
        private System.Windows.Forms.Panel panel_CreateInvoice_SelectClient;
        private System.Windows.Forms.Button button_CreateInvoice_SelectClient;
        private System.Windows.Forms.ComboBox comboBox_CreateInvoice_SelectClient;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox_CreateInvoice_ClientDetail;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox_CreateInvoice_InvoiceID;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CreateInvoice_InvoiceDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CreateInvoice_DueDate;
        private System.Windows.Forms.ComboBox comboBox_CreateInvoice_Status;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.RadioButton radioButton_CreateInvoice_Send2Client_Yes;
        private System.Windows.Forms.RadioButton radioButton_CreateInvoice_Send2Client_No;
        private System.Windows.Forms.SplitContainer splitContainer_Dashboard_CreateInvoice_Bottom;
        private System.Windows.Forms.GroupBox groupBox5;
        private control.GridViewCustom gridView_CreateInvoice_InvoiceItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_CreateInvoice_InvoiceItems_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_CreateInvoice_InvoiceItems_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_CreateInvoice_InvoiceItems_UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_CreateInvoice_InvoiceItems_Total;
        private System.Windows.Forms.SplitContainer splitContainer11;
        private System.Windows.Forms.SplitContainer splitContainer12;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.TextBox textBox_CreateInvoice_Comments;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label_CreateInvoice_Total;
        private System.Windows.Forms.TextBox textBox_CreateInvoice_SubTotal;
        private System.Windows.Forms.TextBox textBox_CreateInvoice_VAT_Value;
        private System.Windows.Forms.TextBox textBox_CreateInvoice_GrandTotal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.NumericUpDown numericUpDown_CreateInvoice_VAT_Percent;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Button button_CreateInvoice_ViewPDF;
        private System.Windows.Forms.Button button_CreateInvoice_SendEmail;
        private System.Windows.Forms.Button button_CreateInvoice_SaveInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_CreateRecurringInvoice_InvoiceItems_Total;
        private System.Windows.Forms.TabPage tabPage_Invoices_EditInvoice;
        private System.Windows.Forms.SplitContainer splitContainer_EditInvoice_Root;
        private System.Windows.Forms.SplitContainer splitContainer_EditInvoice_Client;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button_EditInvoice_ChangeClient;
        private System.Windows.Forms.Panel panel_EditInvoice_SelectClient;
        private System.Windows.Forms.Button button_EditInvoice_SelectClient;
        private System.Windows.Forms.ComboBox comboBox_EditInvoice_SelectClient;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox textBox_EditInvoice_ClientDetail;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox textBox_EditInvoice_InvoiceID;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EditInvoice_InvoiceDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EditInvoice_DueDate;
        private System.Windows.Forms.ComboBox comboBox_EditInvoice_Status;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.RadioButton radioButton_EditInvoice_Send2Client_Yes;
        private System.Windows.Forms.RadioButton radioButton_EditInvoice_Send2Client_No;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox groupBox23;
        private control.GridViewCustom gridView_EditInvoice_InvoiceItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.SplitContainer splitContainer13;
        private System.Windows.Forms.SplitContainer splitContainer14;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.TextBox textBox_EditInvoice_Comments;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label_EditInvoice_Total;
        private System.Windows.Forms.TextBox textBox_EditInvoice_SubTotal;
        private System.Windows.Forms.TextBox textBox_EditInvoice_VAT_Value;
        private System.Windows.Forms.TextBox textBox_EditInvoice_GrandTotal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.NumericUpDown numericUpDown_EditInvoice_VAT_Percent;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Button button_EditInvoice_ViewPDF;
        private System.Windows.Forms.Button button_EditInvoice_SendEmail;
        private System.Windows.Forms.Button button_EditInvoice_SaveInvoice;
        private System.Windows.Forms.TextBox textBox_EditInvoice_AmountDue;
        private System.Windows.Forms.TextBox textBox_EditInvoice_Payments;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.TextBox textBox_CreateInvoice_AmountDue;
        private System.Windows.Forms.TextBox textBox_CreateInvoice_Payments;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label70;
        private TradeWright.UI.Forms.TabControlExtra tabControl_Payments;
        private System.Windows.Forms.TabPage tabPage_Payments_SearchPayment;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Button button_SearchPayment_Search;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SearchPayment_DateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SearchPayment_DateTo;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label_SearchPayment_Result;
        private control.GridViewCustom dataGridView_SearchPayment;
        private System.Windows.Forms.TabPage tabPage_Payments_EditPayment;
        private System.Windows.Forms.SplitContainer splitContainer15;
        private System.Windows.Forms.SplitContainer splitContainer16;
        private System.Windows.Forms.GroupBox groupBox30;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox31;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.SplitContainer splitContainer17;
        private System.Windows.Forms.GroupBox groupBox32;
        private control.GridViewCustom gridViewCustom3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.SplitContainer splitContainer18;
        private System.Windows.Forms.SplitContainer splitContainer19;
        private System.Windows.Forms.GroupBox groupBox33;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.GroupBox groupBox34;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.TabPage tabPage_Payments_PostPayment;
        private System.Windows.Forms.TextBox textBox_SearchPayment_PaymentID;
        private System.Windows.Forms.TextBox textBox_SearchPayment_InvoiceID;
        private System.Windows.Forms.ComboBox comboBox_SearchPayment_Client;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn6;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn7;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.RadioButton radioButton_CreateRecurringInvoice_Send2Client_Yes;
        private System.Windows.Forms.RadioButton radioButton_CreateRecurringInvoice_Send2Client_No;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CreateRecurringInvoice_InvoiceDate;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numericUpDown_CreateRecurringInvoice_NextDays;
        private System.Windows.Forms.NumericUpDown numericUpDown_CreateRecurringInvoice_DueDays;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn_PendingInvoices_InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_PendingInvoices_Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_PendingInvoices_Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_PendingInvoices_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_PendingInvoices_Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_PendingInvoices_DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_PendingInvoices_Status;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn_PendingInvoices_View;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn_PendingInvoices_Edit;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn_PendingInvoices_Delete;
        private control.ToolTipValidation toolTipValidation1;
        private control.ToolTipValidation toolTipValidation2;
        private control.ToolTipValidation toolTipValidation3;
        private control.ToolTipValidation toolTipValidation4;
        private control.ToolTipValidation toolTipValidation5;
        private control.ToolTipValidation toolTipValidation6;
        private control.ToolTipValidation toolTipValidation7;
        private control.ToolTipValidation toolTipValidation8;
        private control.ToolTipValidation toolTipValidation9;
        private control.ToolTipValidation toolTipValidation10;
        private control.ToolTipValidation toolTipValidation11;
        private control.ToolTipValidation toolTipValidation12;
        private TradeWright.UI.Forms.TabControlExtra tabControl_Help;
        private System.Windows.Forms.TabPage tabPage_AboutUs;
        private System.Windows.Forms.TabPage tabPage_Licence;
        private System.Windows.Forms.GroupBox groupBox_PostPayment;
        private System.Windows.Forms.DateTimePicker dateTimePicker_PostPayment_PaymentDate;
        private System.Windows.Forms.ComboBox comboBox_PostPayment_InvoiceID;
        private System.Windows.Forms.ComboBox comboBox_PostPayment_PaymentType;
        private System.Windows.Forms.TextBox textBox_PostPayment_Notes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.TextBox textBox_PostPayment_Amount;
        private System.Windows.Forms.Label label_PostPayment_Currency;
        private System.Windows.Forms.Button button_PostPayment_PostPayment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_PostPayment;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TabPage tabPage_EditClient;
        private System.Windows.Forms.GroupBox groupBox_EditClient;
        private System.Windows.Forms.GroupBox groupBox36;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Button button_EditClient_Save;
        private System.Windows.Forms.TextBox textBox_EditClient_Notes;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.ComboBox comboBox_EditClient_ClientStatus;
        private System.Windows.Forms.ComboBox comboBox_EditClient_InvoiceTemplate;
        private System.Windows.Forms.ComboBox comboBox_EditClient_Currency;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
        private System.Windows.Forms.RadioButton radioButton_EditClient_VATApplicable_Yes;
        private System.Windows.Forms.RadioButton radioButton_EditClient_VATApplicable_No;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel13;
        private System.Windows.Forms.NumericUpDown numericUpDown_EditClient_VATPercent;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.TextBox textBox_EditClient_LastName;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.TextBox textBox_EditClient_FirstName;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.TextBox textBox_EditClient_Company;
        private System.Windows.Forms.TextBox textBox_EditClient_TIN;
        private System.Windows.Forms.TextBox textBox_EditClient_VAT;
        private System.Windows.Forms.TextBox textBox_EditClient_Phone;
        private System.Windows.Forms.TextBox textBox_EditClient_Email;
        private System.Windows.Forms.TextBox textBox_EditClient_Address1;
        private System.Windows.Forms.TextBox textBox_EditClient_Address2;
        private System.Windows.Forms.TextBox textBox_EditClient_City;
        private System.Windows.Forms.TextBox textBox_EditClient_State;
        private System.Windows.Forms.TextBox textBox_EditClient_PostalCode;
        private System.Windows.Forms.ComboBox comboBox_EditClient_Country;
        private System.Windows.Forms.TabPage tabPage_Invoices_EditRecurringInvoice;
        private System.Windows.Forms.SplitContainer splitContainer_EditRecurringInvoice_Root;
        private System.Windows.Forms.SplitContainer splitContainer_EditRecurringInvoice_Client;
        private System.Windows.Forms.GroupBox groupBox35;
        private System.Windows.Forms.Button button_EditRecurringInvoice_ChangeClient;
        private System.Windows.Forms.Panel panel_EditRecurringInvoice_SelectClient;
        private System.Windows.Forms.Button button_EditRecurringInvoice_SelectClient;
        private System.Windows.Forms.ComboBox comboBox_EditRecurringInvoice_SelectClient;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.TextBox textBox_EditRecurringInvoice_ClientDetail;
        private System.Windows.Forms.GroupBox groupBox37;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel14;
        private System.Windows.Forms.RadioButton radioButton_EditRecurringInvoice_Send2Client_Yes;
        private System.Windows.Forms.RadioButton radioButton_EditRecurringInvoice_Send2Client_No;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.TextBox textBox_EditRecurringInvoice_InvoiceID;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EditRecurringInvoice_DueDate;
        private System.Windows.Forms.ComboBox comboBox_EditRecurringInvoice_Status;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EditRecurringInvoice_InvoiceDate;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.NumericUpDown numericUpDown_EditRecurringInvoice_NextDays;
        private System.Windows.Forms.NumericUpDown numericUpDown_EditRecurringInvoice_DueDays;
        private System.Windows.Forms.SplitContainer splitContainer22;
        private System.Windows.Forms.GroupBox groupBox38;
        private control.GridViewCustom gridView_EditRecurringInvoice_InvoiceItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.SplitContainer splitContainer23;
        private System.Windows.Forms.SplitContainer splitContainer24;
        private System.Windows.Forms.GroupBox groupBox39;
        private System.Windows.Forms.TextBox textBox_EditRecurringInvoice_Comments;
        private System.Windows.Forms.GroupBox groupBox40;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.TextBox textBox_EditRecurringInvoice_SubTotal;
        private System.Windows.Forms.TextBox textBox_EditRecurringInvoice_VAT_Value;
        private System.Windows.Forms.TextBox textBox_EditRecurringInvoice_GrandTotal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel15;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.NumericUpDown numericUpDown_EditRecurringInvoice_VAT_Percent;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button_EditRecurringInvoice_ViewPDF;
        private System.Windows.Forms.Button button_EditRecurringInvoice_SendEmail;
        private System.Windows.Forms.Button button_EditRecurringInvoice_SaveInvoice;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn_RecurringInvoices_InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_RecurringInvoices_Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_RecurringInvoices_Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_RecurringInvoices_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_RecurringInvoices_Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_RecurringInvoices_NextDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_RecurringInvoices_DueDays;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn_RecurringInvoices_View;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn_RecurringInvoices_Print;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn_RecurringInvoices_Delete;
        private System.Windows.Forms.TextBox textBox_EditClient_ClientID;
        private System.Windows.Forms.TextBox textBox_EditClient_InvoiceIDAssign;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_Dashboard_Summary_RecentInvoices_InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_Dashboard_Summary_RecentInvoices_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_Dashboard_Summary_RecentInvoices_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_Dashboard_Summary_RecentInvoices_Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_Dashboard_Summary_RecentInvoices_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_Dashboard_Summary_PastDueInvoices_InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_Dashboard_Summary_PastDueInvoices_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_Dashboard_Summary_PastDueInvoices_AmountDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_Dashboard_Summary_PastDueInvoices_DaysDue;
        private System.Windows.Forms.DataGridViewLinkColumn column_Clients_ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Clients_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Clients_Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Clients_Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Clients_Status;
        private System.Windows.Forms.DataGridViewLinkColumn column_Clients_View;
        private System.Windows.Forms.DataGridViewLinkColumn column_Clients_Edit;
        private System.Windows.Forms.DataGridViewLinkColumn column_Clients_Delete;
        private System.Windows.Forms.TextBox textBox_InvoiceTemplates_PaymentDetails;
        private System.Windows.Forms.TextBox textBox_InvoiceTemplates_CompanyDetails;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_PDF;
        private System.Windows.Forms.GroupBox groupBox_ManageUsers;
        private System.Windows.Forms.SplitContainer splitContainer20;
        private System.Windows.Forms.Label label_ManageUsers_Result;
        private System.Windows.Forms.DataGridView dataGridView_ManageUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_ManageUsers_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_ManageUsers_Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumn_ManageUsers_Created;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn_ManageUsers_PasswordRecovery;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewColumn_ManageUsers_Edit;
        private System.Windows.Forms.GroupBox groupBox41;
        private System.Windows.Forms.GroupBox groupBox42;
        private System.Windows.Forms.SplitContainer splitContainer21;
        private System.Windows.Forms.Label label132;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox43;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.RichTextBox richTextBox_EmailTemplate_Variables;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.SplitContainer splitContainer25;
        private System.Windows.Forms.Button button1;
        private Zeroit.Framework.CodeEditor.TextEditor.CodeView codeView_EmailTemplates;
        private System.Windows.Forms.SplitContainer splitContainer26;
        private System.Windows.Forms.GroupBox groupBox44;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.TextBox textBox_Settings_InvoiceTemplates_CompanyName;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox45;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.GroupBox groupBox46;
        private System.Windows.Forms.SplitContainer splitContainer27;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.SplitContainer splitContainer28;
        private Zeroit.Framework.CodeEditor.TextEditor.CodeView codeView1;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.GroupBox groupBox49;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label151;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel21;
        private System.Windows.Forms.GroupBox groupBox48;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel20;
        private System.Windows.Forms.GroupBox groupBox47;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel19;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel18;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel17;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel16;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label142;
    }
}

