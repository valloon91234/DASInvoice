using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.model
{
    class User
    {
        public const String VAT_ACTIVE_YES = "YES";
        public const String VAT_ACTIVE_NO = "NO";

        public String ID { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public DateTime TimeRegistered { get; set; }
        public String Active { get; set; }
    }
}
