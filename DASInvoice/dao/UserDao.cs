using DASInvoice.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.dao
{
    class UserDao : BaseDao
    {
        public static Boolean IsExist(String id)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT COUNT(*) count FROM tbl_user WHERE id=@id";
                command.Parameters.Add("id", System.Data.DbType.String).Value = id;
                SQLiteDataReader dr = command.ExecuteReader();
                dr.Read();
                int count = Convert.ToInt32(dr["count"]);
                return count > 0;
            }
        }

        public static String GetPassword(String id)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT password FROM tbl_user WHERE id=@id";
                command.Parameters.Add("id", System.Data.DbType.String).Value = id;
                SQLiteDataReader dr = command.ExecuteReader();
                String password = null;
                if (dr.Read())
                {
                    password = (String)dr["password"];
                }
                return password;
            }
        }

        public static List<User> SelectAll()
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT * FROM tbl_user";
                SQLiteDataReader dr = command.ExecuteReader();
                List<User> list = new List<User>();
                while (dr.Read())
                {
                    User m = new User();
                    m.ID = GetValue<String>(dr["id"]);
                    m.Password = GetValue<String>(dr["password"]);
                    m.Email = GetValue<String>(dr["email"]);
                    m.TimeRegistered = ParseDateTimeString(GetValue<String>(dr["time_registered"]));
                    m.Active = GetValue<String>(dr["active"]);
                    list.Add(m);
                }
                return list;
            }
        }

        public static int Insert(User e)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"INSERT INTO tbl_user(id,password,email,time_registered,active) VALUES(@id,@password,@email,@time_registered,@active)";
                command.Parameters.Add("id", System.Data.DbType.String).Value = e.ID;
                command.Parameters.Add("password", System.Data.DbType.String).Value = e.Password;
                command.Parameters.Add("email", System.Data.DbType.String).Value = e.Email;
                command.Parameters.Add("time_registered", System.Data.DbType.String).Value = ToDateTimeString(e.TimeRegistered);
                command.Parameters.Add("active", System.Data.DbType.String).Value = e.Active;
                return command.ExecuteNonQuery();
            }
        }

        public static int Delete(String id)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"DELETE FROM tbl_user WHERE id=@id";
                command.Parameters.Add("id", System.Data.DbType.String).Value = id;
                return command.ExecuteNonQuery();
            }
        }

    }
}
