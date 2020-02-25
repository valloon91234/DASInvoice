using DASInvoice.control;
using DASInvoice.model;
using DASInvoice.service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DASInvoice
{
    public partial class FormMain
    {
        public static String ReplaceBR(String input)
        {
            return input.Replace("\r\n", "<br/>");
        }

        private void button_CreateInvoice_ViewPDF_Click(object sender, EventArgs e)
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
            List<InvoiceItem> invoiceItemList = new List<InvoiceItem>();
            try
            {
                saveFileDialog_PDF.FileName = invoiceID;
                if (DialogResult.Cancel == saveFileDialog_PDF.ShowDialog()) return;

                for (int i = 0; i < count; i++)
                {
                    if (gridView_CreateInvoice_InvoiceItem[1, i].Value == null && gridView_CreateInvoice_InvoiceItem[2, i].Value == null) continue;
                    InvoiceItem m = new InvoiceItem();
                    m.InvoiceID = invoiceID;
                    m.Description = Convert.ToString(gridView_CreateInvoice_InvoiceItem[0, i].Value);
                    m.Quanitity = Convert.ToDecimal(gridView_CreateInvoice_InvoiceItem[1, i].Value);
                    m.UnitPrice = Convert.ToDecimal(gridView_CreateInvoice_InvoiceItem[2, i].Value);
                    if (m.Quanitity == 0) continue;
                    invoiceItemList.Add(m);
                }
                int invoiceItemCount = invoiceItemList.Count;
                if (invoiceItemCount < 1)
                {
                    MessageBox.Show("No invoice item.\r\nPlease input invoice items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Invoice invoice = new Invoice();
                invoice.InvoiceID = invoiceID;
                invoice.ClientObject = client;
                invoice.InvoiceDate = dateTimePicker_CreateInvoice_InvoiceDate.Value;
                invoice.DueDate = dateTimePicker_CreateInvoice_DueDate.Value;
                invoice.Status = comboBox_CreateInvoice_Status.Text;
                if (radioButton_CreateInvoice_Send2Client_Yes.Checked)
                    invoice.Send2Client = Invoice.SEND2CLIENT_YES;
                else if (radioButton_CreateInvoice_Send2Client_No.Checked)
                    invoice.Send2Client = Invoice.SEND2CLIENT_NO;
                invoice.VATPercent = numericUpDown_CreateInvoice_VAT_Percent.Value;
                invoice.Comments = textBox_CreateInvoice_Comments.Text;
                invoice = InvoiceService.CheckInvoice(invoice);

                String html = @"<!doctype html>
<html>
<head>
    <meta charset=""utf-8"">
    <title>Invoice</title>
    
    <style>
    .invoice-box {
        max-width: 800px;
        margin: auto;
        padding: 30px;
        border: 1px solid #eee;
        box-shadow: 0 0 10px rgba(0, 0, 0, .15);
        font-size: 16px;
        line-height: 24px;
        font-family: 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif;
        color: #555;
    }
    
    .invoice-box table {
        width: 100%;
        line-height: inherit;
        text-align: left;
    }
    
    .invoice-box table td {
        padding: 5px;
        vertical-align: top;
    }
    
    .invoice-box table tr td:nth-child(2) {
        text-align: right;
    }
    
    .invoice-box table tr.top table td {
        padding-bottom: 20px;
    }
    
    .invoice-box table tr.top table td.title {
        font-size: 45px;
        line-height: 45px;
        color: #333;
    }
    
    .invoice-box table tr.information table td {
        padding-bottom: 40px;
    }
    
    .invoice-box table tr.heading td {
        background: #eee;
        border-bottom: 1px solid #ddd;
        font-weight: bold;
    }
    
    .invoice-box table tr.details td {
        padding-bottom: 20px;
    }
    
    .invoice-box table tr.item td{
        border-bottom: 1px solid #eee;
    }
    
    .invoice-box table tr.item.last td {
        border-bottom: none;
    }
    
    .invoice-box table tr.total td:nth-child(2) {
        border-top: 2px solid #eee;
        font-weight: bold;
    }
    
    @media only screen and (max-width: 600px) {
        .invoice-box table tr.top table td {
            width: 100%;
            display: block;
            text-align: center;
        }
        
        .invoice-box table tr.information table td {
            width: 100%;
            display: block;
            text-align: center;
        }
    }
    
    /** RTL **/
    .rtl {
        direction: rtl;
        font-family: Tahoma, 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif;
    }
    
    .rtl table {
        text-align: right;
    }
    
    .rtl table tr td:nth-child(2) {
        text-align: left;
    }
	.payinfo {margin-top:60px;}
    </style>
</head>

<body>
    <div class=""invoice-box"">
        <table cellpadding=""0"" cellspacing=""0"">
            <tr class=""top"">
                <td colspan=""2"">
                    <table>
                        <tr>
                            <td class=""title"">
                                <img src=""test-logo.jpg"" style=""width:100%; max-width:300px;"">
                            </td>
                            
                            <td>
                                Invoice #: " + invoice.InvoiceID + @"<br>
                                Created: " + invoice.InvoiceDate.ToString("dd/MM/yyyy") + @"<br>
                                Due: " + invoice.DueDate.ToString("dd/MM/yyyy") + @"
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            
            <tr class=""information"">
                <td colspan=""2"">
                    <table>
                        <tr>
                            <td>
                                " + textBox_Settings_InvoiceTemplates_CompanyName.Text + @"<br/>" + ReplaceBR(textBox_InvoiceTemplates_CompanyDetails.Text)
                            //                        + @"
                            //TIN #: 0155444212<br>
                            //VAT #: 0155444212<br>
                            //                        120 Company Street<br>
                            //New York NY34883, United States<br>"
                            + @"</td>
                            
                            <td>
                                " + client.Company + @"<br>
								TIN #: " + client.TIN + @"<br>
								VAT #: " + client.VAT + @"<br>
                                " + client.Address1 + (client.Address2 == null ? "" : ", " + client.Address2) + @"<br>
								" + client.City + " " + client.PostalCode + ", " + client.State + ", " + client.Country + @"<br>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            
            <tr class=""heading"">
                <td>
                    Item
                </td>
                
                <td>
                    Price
                </td>
            </tr>";
                Decimal subTotal = 0;
                for (int i = 0; i < invoiceItemCount; i++)
                {
                    InvoiceItem invoiceItem = invoiceItemList[i];
                    subTotal += invoiceItem.Total;
                    if (i < invoiceItemCount - 1)
                        html += @"<tr class=""item"">";
                    else
                        html += @"<tr class=""item last"">";
                    html += @"<td>" + invoiceItem.Description + @"</td><td>" + client.CurrencySymbol + invoiceItem.Total.ToString("N2") + @"</td></tr>";
                }
                html += @"
            <tr class=""total"">
                <td></td>
                <td>Sub-Total: " + client.CurrencySymbol + subTotal.ToString("N2") + @"</td>
            </tr>
			
			<tr class=""total"">
                <td></td>
                <td>VAT: " + invoice.VATPercent + @"%</td>
            </tr>
			
			<tr class=""total"">
                <td></td>
                <td>Total: " + client.CurrencySymbol + (subTotal * (100 + invoice.VATPercent) / 100).ToString("N2") + @"</td>
            </tr>";

                html += @"<tr><td>
		<div class=""payinfo"">
		<strong>Payment details</strong><br>";
                html += ReplaceBR(textBox_InvoiceTemplates_PaymentDetails.Text);
                html += @"
		</div></td><td></td>			
			</tr>
        </table>
    </div>
</body>
</html>";
                var Renderer = new IronPdf.HtmlToPdf();
                var PDF = Renderer.RenderHtmlAsPdf(html);
                var OutputPath = saveFileDialog_PDF.FileName;
                PDF.SaveAs(OutputPath);
                if (DialogResult.Yes == MessageBox.Show("Invoice PDF has saved. Open it now?\r\n" + OutputPath, "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                    Process.Start(OutputPath);
                //ResetInvoiceList();
                //reset_CreateInvoice(false, true);
            }
            catch (Exception ex)
            {
                ExceptionLogService.Log(ex);
                MessageBox.Show("There was an error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
