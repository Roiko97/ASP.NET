using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAO
{
    public class UserDAO
    {
        private CoordinationDataContext db = new CoordinationDataContext();
        private UserDAO()
        {
            ;
        }
        // 获得DAO 实例
        public static UserDAO getUserDAOInstance(){
            return new UserDAO();
        }

        //以 学号 + 密码的形式进行登录
        public bool userLogin(string std_id,string std_pwd)
        {
            var result = db.users.Where(info => info.student_id == std_id&&info.password == std_pwd);

            if (result == null)
                return false;
            else
                return true;
        }
        

    }
}