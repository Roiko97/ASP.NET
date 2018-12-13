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
        /*用户登录*/
        public bool userLogin(string std_id, string std_pwd)
        {
            var result = db.users.Where(info => info.student_id == std_id && info.password == std_pwd);

            if (result.Count()  == 0)
                return false;
            else
                return true;
        }
        /*用户修改密码*/
        public bool userModifyPwd(string std_id, string std_pwd)
        {
            var result = db.users.Where(info => info.student_id == std_id).First();
            if (result != null)
            {
                Console.Write("1");
                result.password = std_pwd;
                db.SubmitChanges();
                return true;
            }
            Console.Write("2");
            return false;

        }
        /*检查小组标记号是否存在*/
        public bool checkRepeatMark(string mark)
        {
            var result = db.team.Where(info => info.mark == mark).First();
            if (result == null) //代表不存在
                return true;
            else
                return false;
        }
        /*保存标记*/
        public void saveMark(string mark)
        {
            team t = new team();
            t.mark = mark.Trim();
            db.team.InsertOnSubmit(t);
            db.SubmitChanges();
        }
    }
}