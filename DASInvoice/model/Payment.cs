using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.model
{
    class Payment
    {
        public static readonly String[] PAYMENT_TYPE_ARRAY = new String[]
        {
            "Bank wire",
            "Cash",
            "Check",
            "Paypal"
        };

        public int Id { get; set; }
        public String PaymentID { get; set; }
        public String InvoiceID { get; set; }
        public String PaymentType { get; set; }
        public DateTime PaymentDate { get; set; }
        public Decimal Amount { get; set; }
        public String Notes { get; set; }
        public DateTime TimeRegistered { get; set; }
    }
}
