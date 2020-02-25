using DASInvoice.dao;
using DASInvoice.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.service
{
    static class PaymentService
    {

        public static Payment Get(String paymentID)
        {
            return PaymentDao.Select(paymentID);
        }

        public static List<Payment> Select(String paymentID, String invoiceID, String clientName, DateTime? dateFrom, DateTime? dateTo, Boolean desc = false, int limit = 0)
        {
            if (String.IsNullOrWhiteSpace(paymentID)) paymentID = null;
            if (String.IsNullOrWhiteSpace(invoiceID)) invoiceID = null;
            if (String.IsNullOrWhiteSpace(clientName)) clientName = null;
            return PaymentDao.Select(paymentID, invoiceID, clientName, dateFrom, dateTo, desc, limit);
        }

        public static String GetNextPaymentID(String invoiceID)
        {
            String maxID = PaymentDao.SelectMaxID(invoiceID);
            if (maxID == null) return invoiceID + "0001";
            int nextSerial = Convert.ToInt32(maxID.Substring(invoiceID.Length)) + 1;
            return invoiceID + nextSerial.ToString("D4");
        }

        public static int GetSumPayment(String invoiceID)
        {
            return PaymentDao.SumPayment(invoiceID);
        }

        public static int Insert(Payment m)
        {
            if (String.IsNullOrWhiteSpace(m.PaymentID))
            {
                m.PaymentID = GetNextPaymentID(m.InvoiceID);
            }
            if (String.IsNullOrWhiteSpace(m.InvoiceID))
            {
                throw new NullReferenceException("InvoiceID is null.");
            }
            if (String.IsNullOrWhiteSpace(m.PaymentType))
            {
                throw new NullReferenceException("PaymentType is null.");
            }
            // m.Amount is int
            if (String.IsNullOrWhiteSpace(m.Notes)) m.Notes = null;
            m.TimeRegistered = DateTime.Now;
            return PaymentDao.Insert(m);
        }

        public static int Delete(String paymentID)
        {
            if (String.IsNullOrWhiteSpace(paymentID))
            {
                throw new NullReferenceException("PaymentID is null.");
            }
            return PaymentDao.Delete(paymentID);
        }

    }
}
