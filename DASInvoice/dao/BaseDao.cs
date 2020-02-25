using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.dao
{
    abstract class BaseDao
    {
        public const String DB_FILENAME = @"data.db";
        const String DB_PASSWORD = @"SELECT * FROM user WHERE id=@id AND deleted=0";
        const String DATE_FORMAT = @"yyyy-MM-dd";
        const String DATETIME_FORMAT = @"yyyy-MM-dd HH:mm:ss";
        public static SQLiteConnection connection { get; }
        public static Boolean Encrypted;

        static BaseDao()
        {
            FileInfo fileInfo = new FileInfo(DB_FILENAME);
            if (!fileInfo.Exists) throw new FileNotFoundException("Can not find database file - " + DB_FILENAME);
            try
            {
                String connectionString = @"Data Source=" + DB_FILENAME + ";Password=" + DB_PASSWORD + ";Version=3";
                SQLiteConnection con = new SQLiteConnection(connectionString);
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText = "PRAGMA encoding";
                    object result = command.ExecuteScalar();
                }
                Encrypted = true;
                connection = con;
            }
            catch
            {
                String connectionString = @"Data Source=" + DB_FILENAME + ";Version=3";
                SQLiteConnection con = new SQLiteConnection(connectionString);
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText = "PRAGMA encoding";
                    object result = command.ExecuteScalar();
                }
                Encrypted = false;
                connection = con;
            }
#if DEBUG
            Console.WriteLine("Connection has created.");
#endif
        }

        public static Boolean Close()
        {
            try
            {
                connection.Close();
                connection.Dispose();
                return true;
            }
            catch { }
            return false;
        }

        public static void Encrypt()
        {
            connection.ChangePassword(DB_PASSWORD);
        }

        public static void Decrypt()
        {
            connection.ChangePassword("");
        }

        public static T GetValue<T>(object obj)
        {
            Type type = typeof(T);
            if (obj == null || obj == DBNull.Value)
            {
                return default(T); // returns the default value for the type
            }
            else if (type == typeof(DateTime))
            {
                return (T)(Object)DateTime.ParseExact((String)obj, DATETIME_FORMAT, CultureInfo.CurrentCulture);
            }
            else
            {
                return (T)Convert.ChangeType(obj, typeof(T));
            }
        }

        public static String ToDateString(DateTime dt)
        {
            return dt.ToString(DATE_FORMAT);
        }

        public static DateTime ParseDateString(String s)
        {
            return DateTime.ParseExact(s, DATE_FORMAT, CultureInfo.CurrentCulture);
        }

        public static String ToDateTimeString(DateTime dt)
        {
            return dt.ToString(DATETIME_FORMAT);
        }

        public static DateTime ParseDateTimeString(String s)
        {
            return DateTime.ParseExact(s, DATETIME_FORMAT, CultureInfo.CurrentCulture);
        }
    }
}
