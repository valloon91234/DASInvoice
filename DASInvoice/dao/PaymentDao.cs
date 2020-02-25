using DASInvoice.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.dao
{
    class PaymentDao : BaseDao
    {
        public static Payment Select(String paymentID)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT * FROM tbl_payment WHERE payment_id=@paymentID";
                command.Parameters.Add("paymentID", System.Data.DbType.String).Value = paymentID;
                SQLiteDataReader dr = command.ExecuteReader();
                Payment m = null;
                if (dr.Read())
                {
                    m = new Payment();
                    m.Id = GetValue<int>(dr["id"]);
                    m.PaymentID = GetValue<String>(dr["payment_id"]);
                    m.InvoiceID = GetValue<String>(dr["invoice_id"]);
                    m.PaymentDate = ParseDateString(GetValue<String>(dr["payment_date"]));
                    m.Amount = GetValue<Decimal>(dr["amount"]);
                    m.Notes = GetValue<String>(dr["notes"]);
                    m.TimeRegistered = ParseDateTimeString(GetValue<String>(dr["time_registered"]));
                }
                return m;
            }
        }
        public static List<Payment> Select(String paymentID, String invoiceID, String clientName, DateTime? dateFrom, DateTime? dateTo, Boolean desc = false, int limit = 0)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                String commandText = @"SELECT tbl_payment.* FROM tbl_payment INNER JOIN tbl_invoice ON tbl_payment.invoice_id=tbl_invoice.invoice_id INNER JOIN tbl_client ON tbl_invoice.client_id=tbl_client.client_id";
                String where = "";
                if (paymentID != null)
                {
                    where += @" AND tbl_payment.payment_id like @paymentID";
                    command.Parameters.Add("paymentID", System.Data.DbType.String).Value = '%' + paymentID + '%';
                }
                if (invoiceID != null)
                {
                    where += @" AND tbl_payment.invoice_id like @invoiceID";
                    command.Parameters.Add("invoiceID", System.Data.DbType.String).Value = '%' + invoiceID + '%';
                }
                if (clientName != null)
                {
                    where += @" AND tbl_client.firstname||' '|| tbl_client.lastname like @clientName";
                    command.Parameters.Add("clientName", System.Data.DbType.String).Value = '%' + clientName + '%';
                }
                if (dateFrom != null)
                {
                    where += @" AND tbl_payment.payment_date>=@dateFrom";
                    command.Parameters.Add("dateFrom", System.Data.DbType.String).Value = ToDateString((DateTime)dateFrom);
                }
                if (dateTo != null)
                {
                    where += @" AND tbl_payment.payment_date<=@dateTo";
                    command.Parameters.Add("dateTo", System.Data.DbType.String).Value = ToDateString((DateTime)dateTo);
                }
                if (where.StartsWith(" AND")) commandText += " WHERE" + where.Substring(4);
                if (desc) commandText += " ORDER BY id DESC";
                if (limit > 0)
                {
                    commandText += " LIMIT @limit";
                    command.Parameters.Add("limit", System.Data.DbType.Int32).Value = limit;
                }
                command.CommandText = commandText;
                SQLiteDataReader dr = command.ExecuteReader();
                List<Payment> list = new List<Payment>();
                while (dr.Read())
                {
                    Payment m = new Payment();
                    m.Id = GetValue<int>(dr["id"]);
                    m.PaymentID = GetValue<String>(dr["payment_id"]);
                    m.InvoiceID = GetValue<String>(dr["invoice_id"]);
                    m.PaymentDate = ParseDateString(GetValue<String>(dr["payment_date"]));
                    m.Amount = GetValue<Decimal>(dr["amount"]);
                    m.Notes = GetValue<String>(dr["notes"]);
                    m.TimeRegistered = ParseDateTimeString(GetValue<String>(dr["time_registered"]));
                    list.Add(m);
                }
                return list;
            }
        }

        public static String SelectMaxID(String invoiceID)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT MAX(payment_id) FROM tbl_payment WHERE payment_id like @invoiceID";
                command.Parameters.Add("invoiceID", System.Data.DbType.String).Value = invoiceID + '%';
                SQLiteDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    return GetValue<String>(dr[0]);
                }
                return null;
            }
        }

        public static int SumPayment(String invoiceID)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT SUM(amount) FROM tbl_payment WHERE invoice_id=@invoiceID";
                command.Parameters.Add("invoiceID", System.Data.DbType.String).Value = invoiceID;
                SQLiteDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    return GetValue<int>(dr[0]);
                }
                return 0;
            }
        }

        public static int Insert(Payment m)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"INSERT INTO tbl_payment(payment_id,invoice_id,payment_type,payment_date,amount,notes,time_registered) VALUES(@PaymentID,@InvoiceID,@PaymentType,@PaymentDate,@Amount,@Notes,@TimeRegistered)";
                command.Parameters.Add("PaymentID", System.Data.DbType.String).Value = m.PaymentID;
                command.Parameters.Add("InvoiceID", System.Data.DbType.String).Value = m.InvoiceID;
                command.Parameters.Add("PaymentType", System.Data.DbType.String).Value = m.PaymentType;
                command.Parameters.Add("PaymentDate", System.Data.DbType.String).Value = ToDateString(m.PaymentDate);
                command.Parameters.Add("Amount", System.Data.DbType.Decimal).Value = m.Amount;
                command.Parameters.Add("Notes", System.Data.DbType.String).Value = m.Notes;
                command.Parameters.Add("TimeRegistered", System.Data.DbType.String).Value = ToDateTimeString(m.TimeRegistered);
                return command.ExecuteNonQuery();
            }
        }

        public static int Delete(String paymentID)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"DELETE FROM tbl_payment WHERE payment_id=@paymentID";
                command.Parameters.Add("paymentID", System.Data.DbType.String).Value = paymentID;
                return command.ExecuteNonQuery();
            }
        }

    }
}
