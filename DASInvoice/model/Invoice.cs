using DASInvoice.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.model
{
    class Invoice
    {
        public static readonly String[] ID_ASSIGN_ARRAY = new String[]
        {
            "019",
            "020",
            "021"
        };
        public static readonly String[] STATUS_ARRAY = new String[]{
            "Pending",
            "Draft",
            "Completed",
            "Canceled"
        };
        public const String SEND2CLIENT_YES = "YES";
        public const String SEND2CLIENT_NO = "NO";
        public const String TYPE_RECURRING = "RECURRING";

        public int Id { get; set; }
        public String InvoiceID { get; set; }
        public String ClientID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public String Status { get; set; }
        public String Send2Client { get; set; }
        public Decimal Total
        {
            get
            {
                return InvoiceService.SelectTotal(this.InvoiceID);
            }
        }
        public Decimal VATPercent { get; set; }
        public String Comments { get; set; }
        public String Type { get; set; }
        public int NextDays { get; set; }
        public int DueDays { get; set; }
        public DateTime TimeRegistered { get; set; }
        public Client ClientObject { get; set; }
        public Boolean IsRecurring
        {
            get
            {
                return NextDays > 0;
            }
        }
    }
}
