using DASInvoice.dao;
using DASInvoice.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.service
{
    static class ExceptionLogService
    {
        public static void Log(Exception exception, String note = null)
        {
#if DEBUG
            Console.WriteLine(exception);
#endif
            try
            {
                ExceptionLog e = new ExceptionLog();
                e.Message = exception.Message;
                e.StackTrace = exception.StackTrace;
                e.TimeRegistered = DateTime.Now;
                e.Note = note;
                ExceptionLogDao.Insert(e);
            }
            catch (Exception ex)
            {
#if DEBUG
                Console.WriteLine(ex);
#endif
            }
        }
    }
}
