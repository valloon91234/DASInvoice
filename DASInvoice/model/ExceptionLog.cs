using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.model
{
    class ExceptionLog
    {
        public int Id { get; set; }
        public String Message { get; set; }
        public String StackTrace { get; set; }
        public DateTime TimeRegistered { get; set; }
        public String Note { get; set; }
    }
}
