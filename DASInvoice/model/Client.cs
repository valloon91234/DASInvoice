using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.model
{
    class Client
    {
        public static readonly String[] ID_ASSIGN_ARRAY = new String[]
        {
            "012",
            "013",
            "014"
        };
        public static readonly String[] STATUS_ARRAY = new String[]{
            "Active",
            "Inactive",
            "Pending"
        };
        public const String VAT_APPLICABLE_YES = "YES";
        public const String VAT_APPLICABLE_NO = "NO";

        public int ID { get; set; }
        public String ClientID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String FullName { get { return FirstName + ' ' + LastName; } }
        public String Company { get; set; }
        public String TIN { get; set; }
        public String VAT { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String PostalCode { get; set; }
        public String Country { get; set; }
        public String ClientStatus { get; set; }
        public String ClientIDAssign { get; set; }
        public String InvoiceIDAssign { get; set; }
        public String InvoiceTemplate { get; set; }
        public String VATApplicable { get; set; }
        public int VATPercent { get; set; }
        public String Currency { get; set; }
        public String CurrencySymbol { get { return CONST.GetCurrencySymbol(this.Currency); } }
        public String CurrencyWithSymbol { get { return CONST.GetCurrencySymbol(this.Currency) + this.Currency; } }
        public String Notes { get; set; }
        public DateTime TimeRegistered { get; set; }
    }
}
