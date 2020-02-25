using DASInvoice.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.dao
{
    class InvoiceDao : BaseDao
    {
        public static Invoice Select(String invoiceID)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT * FROM tbl_invoice WHERE invoice_id=@invoiceID";
                command.Parameters.Add("invoiceID", System.Data.DbType.String).Value = invoiceID;
                SQLiteDataReader dr = command.ExecuteReader();
                Invoice m = null;
                if (dr.Read())
                {
                    m = new Invoice();
                    m.Id = GetValue<int>(dr["id"]);
                    m.InvoiceID = GetValue<String>(dr["invoice_id"]);
                    m.ClientID = GetValue<String>(dr["client_id"]);
                    m.InvoiceDate = ParseDateString(GetValue<String>(dr["invoice_date"]));
                    m.DueDate = ParseDateString(GetValue<String>(dr["due_date"]));
                    m.Status = GetValue<String>(dr["status"]);
                    m.Send2Client = GetValue<String>(dr["send2client"]);
                    m.VATPercent = GetValue<Decimal>(dr["vat_percent"]);
                    m.Comments = GetValue<String>(dr["comment"]);
                    m.NextDays = GetValue<int>(dr["next_days"]);
                    m.DueDays = GetValue<int>(dr["due_days"]);
                    m.TimeRegistered = ParseDateTimeString(GetValue<String>(dr["time_registered"]));
                }
                return m;
            }
        }

        public static List<String> SelectIDAll()
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT invoice_id FROM tbl_invoice";
                SQLiteDataReader dr = command.ExecuteReader();
                List<String> list = new List<String>();
                while (dr.Read())
                {
                    list.Add(GetValue<String>(dr[0]));
                }
                return list;
            }
        }

        public static List<Invoice> Select(String invoiceID, String clientName, String status, DateTime? dateFrom, DateTime? dateTo, DateTime? dateDue, Boolean onlyRecurring = false, Boolean desc = false, int limit = 0)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                String commandText = @"SELECT tbl_invoice.*,tbl_client.firstname,tbl_client.lastname,tbl_client.company,tbl_client.currency FROM tbl_invoice LEFT JOIN tbl_client ON tbl_invoice.client_id=tbl_client.client_id";
                String where = "";
                if (invoiceID != null)
                {
                    where += @" AND invoice_id like @invoiceID";
                    command.Parameters.Add("invoiceID", System.Data.DbType.String).Value = '%' + invoiceID + '%';
                }
                if (clientName != null)
                {
                    where += @" AND firstname||' '|| lastname like @clientName";
                    command.Parameters.Add("clientName", System.Data.DbType.String).Value = '%' + clientName + '%';
                }
                if (status != null)
                {
                    where += @" AND status=@status";
                    command.Parameters.Add("status", System.Data.DbType.String).Value = status;
                }
                if (dateFrom != null)
                {
                    where += @" AND invoice_date>=@dateFrom";
                    command.Parameters.Add("dateFrom", System.Data.DbType.String).Value = ToDateString((DateTime)dateFrom);
                }
                if (dateTo != null)
                {
                    where += @" AND invoice_date<=@dateTo";
                    command.Parameters.Add("dateTo", System.Data.DbType.String).Value = ToDateString((DateTime)dateTo);
                }
                if (dateDue != null)
                {
                    where += @" AND due_date<=@dateDue";
                    command.Parameters.Add("dateDue", System.Data.DbType.String).Value = ToDateString((DateTime)dateDue);
                }
                if (onlyRecurring)
                {
                    where += @" AND next_days>0";
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
                List<Invoice> list = new List<Invoice>();
                while (dr.Read())
                {
                    Invoice m = new Invoice();
                    m.Id = GetValue<int>(dr["id"]);
                    m.InvoiceID = GetValue<String>(dr["invoice_id"]);
                    m.ClientID = GetValue<String>(dr["client_id"]);
                    m.InvoiceDate = ParseDateString(GetValue<String>(dr["invoice_date"]));
                    m.DueDate = ParseDateString(GetValue<String>(dr["due_date"]));
                    m.Status = GetValue<String>(dr["status"]);
                    m.Send2Client = GetValue<String>(dr["send2client"]);
                    m.VATPercent = GetValue<Decimal>(dr["vat_percent"]);
                    m.Comments = GetValue<String>(dr["comment"]);
                    m.NextDays = GetValue<int>(dr["next_days"]);
                    m.DueDays = GetValue<int>(dr["due_days"]);
                    m.TimeRegistered = ParseDateTimeString(GetValue<String>(dr["time_registered"]));
                    Client c = new Client();
                    c.FirstName = GetValue<String>(dr["firstname"]);
                    c.LastName = GetValue<String>(dr["lastname"]);
                    c.Company = GetValue<String>(dr["company"]);
                    c.Currency = GetValue<String>(dr["currency"]);
                    m.ClientObject = c;
                    list.Add(m);
                }
                return list;
            }
        }

        public static String SelectMaxID(String assign)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT MAX(invoice_id) FROM tbl_invoice WHERE invoice_id like @assign";
                command.Parameters.Add("assign", System.Data.DbType.String).Value = assign + '%';
                SQLiteDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    return GetValue<String>(dr[0]);
                }
                return null;
            }
        }

        public static int Insert(Invoice m)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"INSERT INTO tbl_invoice(invoice_id,client_id,invoice_date,due_date,status,send2client,vat_percent,comment,next_days,due_days,time_registered) VALUES(@InvoiceID,@ClientID,@InvoiceDate,@DueDate,@Status,@Send2Client,@VATPercent,@Comment,@NextDays,@DueDays,@TimeRegistered)";
                command.Parameters.Add("InvoiceID", System.Data.DbType.String).Value = m.InvoiceID;
                command.Parameters.Add("ClientID", System.Data.DbType.String).Value = m.ClientID;
                command.Parameters.Add("InvoiceDate", System.Data.DbType.String).Value = ToDateString(m.InvoiceDate);
                command.Parameters.Add("DueDate", System.Data.DbType.String).Value = ToDateString(m.DueDate);
                command.Parameters.Add("Status", System.Data.DbType.String).Value = m.Status;
                command.Parameters.Add("Send2Client", System.Data.DbType.String).Value = m.Send2Client;
                command.Parameters.Add("VATPercent", System.Data.DbType.Decimal).Value = m.VATPercent;
                command.Parameters.Add("Comment", System.Data.DbType.String).Value = m.Comments;
                command.Parameters.Add("NextDays", System.Data.DbType.Int32).Value = m.NextDays;
                command.Parameters.Add("DueDays", System.Data.DbType.Int32).Value = m.DueDays;
                command.Parameters.Add("TimeRegistered", System.Data.DbType.String).Value = ToDateTimeString(m.TimeRegistered);
                return command.ExecuteNonQuery();
            }
        }

        public static int Delete(String invoiceID)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"DELETE FROM tbl_invoice WHERE invoice_id=@invoiceID";
                command.Parameters.Add("invoiceID", System.Data.DbType.String).Value = invoiceID;
                return command.ExecuteNonQuery();
            }
        }

        public static int DeleteByClient(String clientID)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"DELETE FROM tbl_invoice WHERE client_id=@clientID";
                command.Parameters.Add("clientID", System.Data.DbType.String).Value = clientID;
                return command.ExecuteNonQuery();
            }
        }

    }
}
