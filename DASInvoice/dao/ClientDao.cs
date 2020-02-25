using DASInvoice.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.dao
{
    class ClientDao : BaseDao
    {
        public static Boolean IsExist(String firstName, String lastName)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT COUNT(*) count FROM tbl_client WHERE firstname=@firstname and lastname=@lastname";
                command.Parameters.Add("firstname", System.Data.DbType.String).Value = firstName;
                command.Parameters.Add("lastname", System.Data.DbType.String).Value = lastName;
                SQLiteDataReader dr = command.ExecuteReader();
                dr.Read();
                int count = Convert.ToInt32(dr["count"]);
                return count > 0;
            }
        }

        public static Client Select(String clientID)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT * FROM tbl_client WHERE client_id=@clientID";
                command.Parameters.Add("clientID", System.Data.DbType.String).Value = clientID;
                SQLiteDataReader dr = command.ExecuteReader();
                Client m = null;
                if (dr.Read())
                {
                    m = new Client();
                    m.ID = GetValue<int>(dr["id"]);
                    m.FirstName = (String)dr["firstname"];
                    m.LastName = (String)dr["lastname"];
                    m.Company = (String)dr["company"];
                    m.TIN = GetValue<String>(dr["tin"]);
                    m.VAT = GetValue<String>(dr["vat"]);
                    m.Phone = GetValue<String>(dr["phone"]);
                    m.Email = GetValue<String>(dr["email"]);
                    m.Address1 = GetValue<String>(dr["address1"]);
                    m.Address2 = GetValue<String>(dr["address2"]);
                    m.City = GetValue<String>(dr["city"]);
                    m.State = GetValue<String>(dr["state"]);
                    m.PostalCode = GetValue<String>(dr["postal_code"]);
                    m.Country = GetValue<String>(dr["country"]);
                    m.ClientStatus = GetValue<String>(dr["client_status"]);
                    m.ClientID = GetValue<String>(dr["client_id"]);
                    m.InvoiceIDAssign = GetValue<String>(dr["invoice_id_assign"]);
                    m.InvoiceTemplate = GetValue<String>(dr["invoice_template"]);
                    m.VATApplicable = GetValue<String>(dr["vat_applicable"]);
                    m.VATPercent = GetValue<int>(dr["vat_percent"]);
                    m.Currency = GetValue<String>(dr["currency"]);
                    m.Notes = GetValue<String>(dr["notes"]);
                    m.TimeRegistered = ParseDateTimeString(GetValue<String>(dr["time_registered"]));
                }
                return m;
            }
        }

        public static Client Select(String firstName, String lastName)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT * FROM tbl_client WHERE firstname=@firstname and lastname=@lastname";
                command.Parameters.Add("firstname", System.Data.DbType.String).Value = firstName;
                command.Parameters.Add("lastname", System.Data.DbType.String).Value = lastName;
                SQLiteDataReader dr = command.ExecuteReader();
                Client m = null;
                if (dr.Read())
                {
                    m = new Client();
                    m.ID = GetValue<int>(dr["id"]);
                    m.FirstName = (String)dr["firstname"];
                    m.LastName = (String)dr["lastname"];
                    m.Company = (String)dr["company"];
                    m.TIN = GetValue<String>(dr["tin"]);
                    m.VAT = GetValue<String>(dr["vat"]);
                    m.Phone = GetValue<String>(dr["phone"]);
                    m.Email = GetValue<String>(dr["email"]);
                    m.Address1 = GetValue<String>(dr["address1"]);
                    m.Address2 = GetValue<String>(dr["address2"]);
                    m.City = GetValue<String>(dr["city"]);
                    m.State = GetValue<String>(dr["state"]);
                    m.PostalCode = GetValue<String>(dr["postal_code"]);
                    m.Country = GetValue<String>(dr["country"]);
                    m.ClientStatus = GetValue<String>(dr["client_status"]);
                    m.ClientID = GetValue<String>(dr["client_id"]);
                    m.InvoiceIDAssign = GetValue<String>(dr["invoice_id_assign"]);
                    m.InvoiceTemplate = GetValue<String>(dr["invoice_template"]);
                    m.VATApplicable = GetValue<String>(dr["vat_applicable"]);
                    m.VATPercent = GetValue<int>(dr["vat_percent"]);
                    m.Currency = GetValue<String>(dr["currency"]);
                    m.Notes = GetValue<String>(dr["notes"]);
                    m.TimeRegistered = ParseDateTimeString(GetValue<String>(dr["time_registered"]));
                }
                return m;
            }
        }

        public static List<Client> SelectAll()
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT * FROM tbl_client";
                SQLiteDataReader dr = command.ExecuteReader();
                List<Client> list = new List<Client>();
                while (dr.Read())
                {
                    Client e = new Client();
                    e.ID = Convert.ToInt32(dr["id"]);
                    e.FirstName = (String)dr["firstname"];
                    e.LastName = (String)dr["lastname"];
                    e.Company = (String)dr["company"];
                    e.TIN = GetValue<String>(dr["tin"]);
                    e.VAT = GetValue<String>(dr["vat"]);
                    e.Phone = GetValue<String>(dr["phone"]);
                    e.Email = GetValue<String>(dr["email"]);
                    e.Address1 = GetValue<String>(dr["address1"]);
                    e.Address2 = GetValue<String>(dr["address2"]);
                    e.City = GetValue<String>(dr["city"]);
                    e.State = GetValue<String>(dr["state"]);
                    e.PostalCode = GetValue<String>(dr["postal_code"]);
                    e.Country = GetValue<String>(dr["country"]);
                    e.ClientStatus = GetValue<String>(dr["client_status"]);
                    e.ClientID = GetValue<String>(dr["client_id"]);
                    e.InvoiceIDAssign = GetValue<String>(dr["invoice_id_assign"]);
                    e.InvoiceTemplate = GetValue<String>(dr["invoice_template"]);
                    e.VATApplicable = GetValue<String>(dr["vat_applicable"]);
                    e.VATPercent = GetValue<int>(dr["vat_percent"]);
                    e.Currency = GetValue<String>(dr["currency"]);
                    e.Notes = GetValue<String>(dr["notes"]);
                    e.TimeRegistered = ParseDateTimeString(GetValue<String>(dr["time_registered"]));
                    list.Add(e);
                }
                return list;
            }
        }

        public static List<Client> Select(String clientName, String company, String email, String clientID, String country, String clientStatus)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                String commandText = @"SELECT * FROM tbl_client";
                String where = "";
                if (clientName != null)
                {
                    where += @" AND firstname||' '|| lastname like @clientName";
                    command.Parameters.Add("clientName", System.Data.DbType.String).Value = '%' + clientName + '%';
                }
                if (company != null)
                {
                    where += @" AND company like @company";
                    command.Parameters.Add("company", System.Data.DbType.String).Value = '%' + company + '%';
                }
                if (email != null)
                {
                    where += @" AND email like @email";
                    command.Parameters.Add("email", System.Data.DbType.String).Value = '%' + email + '%';
                }
                if (clientID != null)
                {
                    where += @" AND client_id like @clientID";
                    command.Parameters.Add("clientID", System.Data.DbType.String).Value = '%' + clientID + '%';
                }
                if (country != null)
                {
                    where += @" AND country like @country";
                    command.Parameters.Add("country", System.Data.DbType.String).Value = '%' + country + '%';
                }
                if (clientStatus != null)
                {
                    where += @" AND client_status like @clientStatus";
                    command.Parameters.Add("clientStatus", System.Data.DbType.String).Value = '%' + clientStatus + '%';
                }
                if (where.StartsWith(" AND")) commandText += " WHERE" + where.Substring(4);
                //commandText += " LIMIT 100";
                command.CommandText = commandText;
                SQLiteDataReader dr = command.ExecuteReader();
                List<Client> list = new List<Client>();
                while (dr.Read())
                {
                    Client e = new Client();
                    e = new Client();
                    e.ID = Convert.ToInt32(dr["id"]);
                    e.FirstName = (String)dr["firstname"];
                    e.LastName = (String)dr["lastname"];
                    e.Company = (String)dr["company"];
                    e.TIN = GetValue<String>(dr["tin"]);
                    e.VAT = GetValue<String>(dr["vat"]);
                    e.Phone = GetValue<String>(dr["phone"]);
                    e.Email = GetValue<String>(dr["email"]);
                    e.Address1 = GetValue<String>(dr["address1"]);
                    e.Address2 = GetValue<String>(dr["address2"]);
                    e.City = GetValue<String>(dr["city"]);
                    e.State = GetValue<String>(dr["state"]);
                    e.PostalCode = GetValue<String>(dr["postal_code"]);
                    e.Country = GetValue<String>(dr["country"]);
                    e.ClientStatus = GetValue<String>(dr["client_status"]);
                    e.ClientID = GetValue<String>(dr["client_id"]);
                    e.InvoiceIDAssign = GetValue<String>(dr["invoice_id_assign"]);
                    e.InvoiceTemplate = GetValue<String>(dr["invoice_template"]);
                    e.VATApplicable = GetValue<String>(dr["vat_applicable"]);
                    e.VATPercent = GetValue<int>(dr["vat_percent"]);
                    e.Currency = GetValue<String>(dr["currency"]);
                    e.Notes = GetValue<String>(dr["notes"]);
                    e.TimeRegistered = ParseDateTimeString(GetValue<String>(dr["time_registered"]));
                    list.Add(e);
                }
                return list;
            }
        }

        public static String SelectMaxID(String assign)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT MAX(client_id) FROM tbl_client WHERE client_id like @assign";
                command.Parameters.Add("assign", System.Data.DbType.String).Value = assign + '%';
                SQLiteDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    return GetValue<String>(dr[0]);
                }
                return null;
            }
        }

        public static int Insert(Client e)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"INSERT INTO tbl_client(firstname,lastname,company,tin,vat,phone,email,address1,address2,city,state,postal_code,country,client_status,client_id,invoice_id_assign,invoice_template,vat_applicable,vat_percent,currency,notes,time_registered) VALUES(@firstname,@lastname,@company,@tin,@vat,@phone,@email,@address1,@address2,@city,@state,@postal_code,@country,@client_status,@client_id,@invoice_id_assign,@invoice_template,@vat_applicable,@vat_percent,@currency,@notes,@time_registered)";
                command.Parameters.Add("firstname", System.Data.DbType.String).Value = e.FirstName;
                command.Parameters.Add("lastname", System.Data.DbType.String).Value = e.LastName;
                command.Parameters.Add("company", System.Data.DbType.String).Value = e.Company;
                command.Parameters.Add("tin", System.Data.DbType.String).Value = e.TIN;
                command.Parameters.Add("vat", System.Data.DbType.String).Value = e.VAT;
                command.Parameters.Add("phone", System.Data.DbType.String).Value = e.Phone;
                command.Parameters.Add("email", System.Data.DbType.String).Value = e.Email;
                command.Parameters.Add("address1", System.Data.DbType.String).Value = e.Address1;
                command.Parameters.Add("address2", System.Data.DbType.String).Value = e.Address2;
                command.Parameters.Add("city", System.Data.DbType.String).Value = e.City;
                command.Parameters.Add("state", System.Data.DbType.String).Value = e.State;
                command.Parameters.Add("postal_code", System.Data.DbType.String).Value = e.PostalCode;
                command.Parameters.Add("country", System.Data.DbType.String).Value = e.Country;
                command.Parameters.Add("client_status", System.Data.DbType.String).Value = e.ClientStatus;
                command.Parameters.Add("client_id", System.Data.DbType.String).Value = e.ClientID;
                command.Parameters.Add("invoice_id_assign", System.Data.DbType.String).Value = e.InvoiceIDAssign;
                command.Parameters.Add("invoice_template", System.Data.DbType.String).Value = e.InvoiceTemplate;
                command.Parameters.Add("vat_applicable", System.Data.DbType.String).Value = e.VATApplicable;
                command.Parameters.Add("vat_percent", System.Data.DbType.Int32).Value = e.VATPercent;
                command.Parameters.Add("currency", System.Data.DbType.String).Value = e.Currency;
                command.Parameters.Add("notes", System.Data.DbType.String).Value = e.Notes;
                command.Parameters.Add("time_registered", System.Data.DbType.String).Value = ToDateTimeString(e.TimeRegistered);
                return command.ExecuteNonQuery();
            }
        }

        public static int Update(Client e)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"UPDATE tbl_client SET 
firstname=@FirstName,
lastname=@LastName,
company=@Company,
tin=@TIN,
vat=@VAT,
phone=@Phone,
email=@Email,
address1=@Address1,
address2=@Address2,
city=@City,
state=@State,
postal_code=@PostalCode,
country=@Country,
client_status=@ClientStatus,
invoice_template=@InvoiceTemplate,
vat_applicable=@VATApplicable,
vat_percent=@VATPercent,
currency=@Currency,
notes=@Notes
WHERE client_id=@ClientID";
                command.Parameters.Add("ClientID", System.Data.DbType.String).Value = e.ClientID;
                command.Parameters.Add("FirstName", System.Data.DbType.String).Value = e.FirstName;
                command.Parameters.Add("LastName", System.Data.DbType.String).Value = e.LastName;
                command.Parameters.Add("Company", System.Data.DbType.String).Value = e.Company;
                command.Parameters.Add("TIN", System.Data.DbType.String).Value = e.TIN;
                command.Parameters.Add("VAT", System.Data.DbType.String).Value = e.VAT;
                command.Parameters.Add("Phone", System.Data.DbType.String).Value = e.Phone;
                command.Parameters.Add("Email", System.Data.DbType.String).Value = e.Email;
                command.Parameters.Add("Address1", System.Data.DbType.String).Value = e.Address1;
                command.Parameters.Add("Address2", System.Data.DbType.String).Value = e.Address2;
                command.Parameters.Add("City", System.Data.DbType.String).Value = e.City;
                command.Parameters.Add("State", System.Data.DbType.String).Value = e.State;
                command.Parameters.Add("PostalCode", System.Data.DbType.String).Value = e.PostalCode;
                command.Parameters.Add("Country", System.Data.DbType.String).Value = e.Country;
                command.Parameters.Add("ClientStatus", System.Data.DbType.String).Value = e.ClientStatus;
                command.Parameters.Add("InvoiceTemplate", System.Data.DbType.String).Value = e.InvoiceTemplate;
                command.Parameters.Add("VATApplicable", System.Data.DbType.String).Value = e.VATApplicable;
                command.Parameters.Add("VATPercent", System.Data.DbType.Int32).Value = e.VATPercent;
                command.Parameters.Add("Currency", System.Data.DbType.String).Value = e.Currency;
                command.Parameters.Add("Notes", System.Data.DbType.String).Value = e.Notes;
                //command.Parameters.Add("time_registered", System.Data.DbType.String).Value = ToDateTimeString(e.TimeRegistered);
                return command.ExecuteNonQuery();
            }
        }

        public static int Delete(String clientID)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"DELETE FROM tbl_client WHERE client_id=@clientID";
                command.Parameters.Add("clientID", System.Data.DbType.String).Value = clientID;
                return command.ExecuteNonQuery();
            }
        }

    }
}
