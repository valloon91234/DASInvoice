using DASInvoice.dao;
using DASInvoice.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.service
{
    static class InvoiceService
    {

        public static Invoice Get(String invoiceID)
        {
            return InvoiceDao.Select(invoiceID);
        }

        public static List<String> GetIDALL()
        {
            return InvoiceDao.SelectIDAll();
        }

        public static List<Invoice> Select(String invoiceID, String clientName, String status, DateTime? dateFrom, DateTime? dateTo, DateTime? dateDue, Boolean onlyRecurring = false, Boolean desc = false, int limit = 0)
        {
            if (String.IsNullOrWhiteSpace(invoiceID)) invoiceID = null;
            if (String.IsNullOrWhiteSpace(clientName)) clientName = null;
            if (String.IsNullOrWhiteSpace(status)) status = null;
            return InvoiceDao.Select(invoiceID, clientName, status, dateFrom, dateTo, dateDue, onlyRecurring, desc, limit);
        }

        public static String GetNextInvoiceID(String invoiceIDAssign)
        {
            String maxID = InvoiceDao.SelectMaxID(invoiceIDAssign);
            if (maxID == null) return invoiceIDAssign + "0001";
            int nextSerial = Convert.ToInt32(maxID.Substring(invoiceIDAssign.Length)) + 1;
            return invoiceIDAssign + nextSerial.ToString("D4");
        }

        public static Invoice CheckInvoice(Invoice m)
        {
            if (String.IsNullOrWhiteSpace(m.InvoiceID))
            {
                if (m.ClientObject == null || String.IsNullOrWhiteSpace(m.ClientObject.InvoiceIDAssign))
                    throw new NullReferenceException("InvoiceID and InvoiceIDAssign are null.");
                m.InvoiceID = GetNextInvoiceID(m.ClientObject.InvoiceIDAssign);
            }
            if (String.IsNullOrWhiteSpace(m.ClientID))
            {
                if (m.ClientObject == null || String.IsNullOrWhiteSpace(m.ClientObject.ClientID))
                    throw new NullReferenceException("ClientID and ClientObject are null.");
                m.ClientID = m.ClientObject.ClientID;
            }
            if (String.IsNullOrWhiteSpace(m.Status)) m.Status = null;
            if (String.IsNullOrWhiteSpace(m.Send2Client)) m.Send2Client = null;
            // m.Vat is int
            if (String.IsNullOrWhiteSpace(m.Comments)) m.Comments = null;
            m.TimeRegistered = DateTime.Now;
            return m;
        }

        public static int Insert(Invoice m)
        {
            return InvoiceDao.Insert(CheckInvoice(m));
        }

        public static int Delete(String invoicID)
        {
            if (String.IsNullOrWhiteSpace(invoicID))
            {
                throw new NullReferenceException("InvoiceID is null.");
            }
            InvoiceItemDao.Delete(invoicID);
            return InvoiceDao.Delete(invoicID);
        }

        public static int DeleteByClient(String clientID)
        {
            if (String.IsNullOrWhiteSpace(clientID))
            {
                throw new NullReferenceException("ClientID is null.");
            }
            InvoiceItemDao.DeleteByClient(clientID);
            return InvoiceDao.DeleteByClient(clientID);
        }

        public static List<InvoiceItem> SelectItem(String invoiceID)
        {
            return InvoiceItemDao.Select(invoiceID);
        }

        public static Decimal SelectTotal(String invoiceID)
        {
            return InvoiceItemDao.SelectTotal(invoiceID);
        }

        public static int InsertItem(InvoiceItem m)
        {
            if (String.IsNullOrWhiteSpace(m.InvoiceID))
            {
                throw new NullReferenceException("InvoiceID is null.");
            }
            if (String.IsNullOrWhiteSpace(m.Description)) m.Description = null;
            // m.Quanitity is int
            // m.UnitPrice is real
            return InvoiceItemDao.Insert(m);
        }

    }
}
