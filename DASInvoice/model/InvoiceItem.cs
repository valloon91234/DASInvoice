using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.model
{
    class InvoiceItem
    {
        public String InvoiceID { get; set; }
        public String Description { get; set; }
        public Decimal Quanitity { get; set; }
        public Decimal UnitPrice { get; set; }
        public Decimal Total { get { return Quanitity * UnitPrice; } }
    }
}
