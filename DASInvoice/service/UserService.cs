using DASInvoice.dao;
using DASInvoice.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASInvoice.service
{
    static class UserService
    {
        public static Boolean IsExist(String id)
        {
            return UserDao.IsExist(id);
        }

        public static String GetPassword(String id)
        {
            return UserDao.GetPassword(id);
        }

        public static List<User> SelectAll()
        {
            return UserDao.SelectAll();
        }

        public static int Insert(String id, String password, String email)
        {
            User user = new User();
            user.ID = id;
            user.Password = password;
            user.Email = email;
            user.TimeRegistered = DateTime.Now;
            user.Active = User.VAT_ACTIVE_YES;  //TODO
            return UserDao.Insert(user);
        }

        public static void Delete(String id)
        {
            UserService.Delete(id);
        }
    }
}
