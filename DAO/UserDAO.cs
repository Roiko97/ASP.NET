using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAO
{
    public class UserDAO
    {
        private CoordinationDataContext db = new CoordinationDataContext();
        public static UserDAO getUserDAOInstance()
        {
            return new UserDAO();
        }
        public bool userLogin(string std_id, string std_pwd)
        {
            var result = db.users.Where(info => info.student_id == std_id && info.password == std_pwd);

            if (result.Count()  == 0)
                return false;
            else
                return true;
        }
    }
}