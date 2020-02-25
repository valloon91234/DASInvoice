using DASInvoice.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.dao
{
    class ExceptionLogDao : BaseDao
    {
        public static int Insert(ExceptionLog e)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"INSERT INTO tbl_exception_log(message,stack,time_registered,note) VALUES(@message,@stack,@time_registered,@note)";
                command.Parameters.Add("message", System.Data.DbType.String).Value = e.Message;
                command.Parameters.Add("stack", System.Data.DbType.String).Value = e.StackTrace;
                command.Parameters.Add("time_registered", System.Data.DbType.String).Value = ToDateTimeString(e.TimeRegistered);
                command.Parameters.Add("note", System.Data.DbType.String).Value = e.Note;
                return command.ExecuteNonQuery();
            }
        }

    }
}
