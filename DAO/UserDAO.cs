using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
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
        /*通过studentId 获得mark
         成功返回mark
         * 失败返回null
         */
        public string getMarkByStudentId(string stdId)
        {
            var result = db.users.Where(info => info.student_id == stdId).First();
            if (result != null)
            {
                return result.mark;
            }
            return null;
        }
        
        /*修改用户的标记 By userId 成功返回true 失败返回false
          适用范围：部分组员的增加，部分组员的删除
         */
        public bool updateUserMark(string userId, string mark)
        {
            var result = from user in db.users
                         where user.student_id == userId
                         select user;
            if (result.Count() > 0)
            {
                foreach (users u in result)
                {
                    u.mark = mark;
                }
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        /*修改(设置）小组的题目
         * 修改（设置）进度
         * By mark*/
        public bool updateTeamHeading(string mark =null,int schedule =0)
        {
            var result = from t in db.team
                         where t.mark == mark
                         select t;
            if (result.Count() > 0)
            {
                foreach (team t in result)
                {
                    if(mark!=null)
                    {
                        t.mark = mark;
                    }
                    if (schedule != 0)
                    {
                        t.schedule = schedule;
                    }
                }
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        /*
         获取小组的信息
         */
        public Object getTeam(string mark)
        {
            return db.team.Where(info => info.mark == mark).First();
        }

        /*解散小组
            通过mark 找到user表中的数据，修改mark字段为-1
         *  通过mark 找到team表中的数据，删除
         */
        public bool deleteTeam(string mark) {

            var findUserByMark = from u in db.users
                                 where u.mark == mark
                                 select u;
            if (findUserByMark.Count() > 0)
            {
                foreach (users u in findUserByMark)
                {
                    u.mark = "-1";
                }
                db.SubmitChanges();
                var deleteTeamByMark = from t in db.team
                                       where t.mark == mark
                                       select t;
                db.team.DeleteAllOnSubmit(deleteTeamByMark);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        /*模糊查询, 用于搜索人员*/
        public Object fuzzyLookUpByName(string userName)
        {
            var result = from u in db.users
                         where System.Data.Linq.SqlClient.SqlMethods.Like(u.student_name, "%" + userName + "%")
                         select u;
            return result;
        }
        /*
         搜索小组中的所有成员
         */
        public Object selectMember(string mark)
        {
            var result = from u in db.users
                         where u.mark == mark
                         select new
                         {
                            学号 = u.student_id,
                            姓名 = u.student_name,
                            职责 = u.position
                            
                         };
         //   var result = db.users.Where(info => info.mark == mark);
            return result;
        }
        
        /*
         * 检索小组的需求分析说明书
         * 需求分析说明书 有且仅有一份
         */
        public Object getDemandByMark(string mark)
        {
            var result = db.demand.Where(info => info.mark == mark);
            return result;
        }
        /*
         * 修改用户的需求说明书
         * 通过mark来检索
         * 修改成功,返回true
         * 失败返回false
         */
        public bool updateDemanByMark(string mark,string newData)
        {
            var result = db.demand.Where(info => info.mark == mark);
            if (result.Count() > 0) {
                foreach (demand d in result)
                {
                    d.data = newData;
                }
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        
        /*
         * 修改小组组员的职责
         * 通过学号（userID）来查找
         * 将职责（pst）赋予position来完成权限的修改
         * 成功返回true
         * 失败返回false
         */
        public bool updatePosition(string userId,string pst)
        {
            var result = db.users.Where(info => info.student_id == userId);
            if (result.Count() > 0)
            {
                foreach (users u in result)
                {
                    u.position = pst;
                }
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        /*
         插入测试需求表单
         */
        public bool insertTestForm(TestForm tf)
        {

            if (tf != null)
            {
                testform t = new testform();
                if (tf.field != null)
                {
                    t.field = tf.field;
                }
                t.complete = tf.complete;
                db.testform.InsertOnSubmit(t);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        /*
         插入交互字段
         */
        public bool insertCoopeartion(Cooperation cp)
        {
            cooperation c = new cooperation();
            if (cp != null)
            {
                c.mark = cp.mark;
                c.announcer = cp.announcer;
                c.data = cp.data;
                db.cooperation.InsertOnSubmit(c);
                db.SubmitChanges();
                return true;
            }
            return false;       
        }
    }
}