using DASInvoice.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.dao
{
    class InvoiceItemDao : BaseDao
    {
        public static List<InvoiceItem> Select(String invoiceID)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT * FROM tbl_invoice_item WHERE invoice_id=@invoiceID";
                command.Parameters.Add("invoiceID", System.Data.DbType.String).Value = invoiceID;
                SQLiteDataReader dr = command.ExecuteReader();
                List<InvoiceItem> list = new List<InvoiceItem>();
                while (dr.Read())
                {
                    InvoiceItem m = new InvoiceItem();
                    m.InvoiceID = GetValue<String>(dr["invoice_id"]);
                    m.Description = GetValue<String>(dr["description"]);
                    m.Quanitity = GetValue<int>(dr["quantity"]);
                    m.UnitPrice = GetValue<Decimal>(dr["unit_price"]);
                    list.Add(m);
                }
                return list;
            }
        }

        public static Decimal SelectTotal(String invoiceID)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT IFNULL(SUM(quantity*unit_price),0) FROM tbl_invoice_item WHERE invoice_id=@invoiceID";
                command.Parameters.Add("invoiceID", System.Data.DbType.String).Value = invoiceID;
                SQLiteDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    return GetValue<Decimal>(dr[0]);
                }
                return 0;
            }
        }

        public static int Insert(InvoiceItem m)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"INSERT INTO tbl_invoice_item(invoice_id,description,quantity,unit_price) VALUES(@InvoiceID,@Description,@Quantity,@UnitPrice)";
                command.Parameters.Add("InvoiceID", System.Data.DbType.String).Value = m.InvoiceID;
                command.Parameters.Add("Description", System.Data.DbType.String).Value = m.Description;
                command.Parameters.Add("Quantity", System.Data.DbType.Decimal).Value = m.Quanitity;
                command.Parameters.Add("UnitPrice", System.Data.DbType.Decimal).Value = m.UnitPrice;
                return command.ExecuteNonQuery();
            }
        }

        public static int Delete(String invoiceID)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"DELETE FROM tbl_invoice_item WHERE invoice_id=@invoiceID";
                command.Parameters.Add("invoiceID", System.Data.DbType.String).Value = invoiceID;
                return command.ExecuteNonQuery();
            }
        }

        public static int DeleteByClient(String clientID)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"DELETE FROM tbl_invoice_item
WHERE invoice_id IN (
  SELECT tbl_invoice_item.invoice_id FROM tbl_invoice_item
  INNER JOIN tbl_invoice ON tbl_invoice_item.invoice_id=tbl_invoice.invoice_id
  WHERE tbl_invoice.client_id=@clientID
);";
                command.Parameters.Add("clientID", System.Data.DbType.String).Value = clientID;
                return command.ExecuteNonQuery();
            }
        }

    }
}
