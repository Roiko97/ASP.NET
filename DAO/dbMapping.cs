using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAO
{
    public class dbMapping
    {
        CoordinationDataContext db = new CoordinationDataContext();
        private dbMapping()
        {
            
        }
        public static dbMapping getInstance()
        {
            return new dbMapping();
        }

        // 通过用户名来查找相应用户的信息 返回为一条
        public Object getUsers(string username) 
        {
            var uses = db.users.Where(us =>us.name == username);
            return uses;
        }
        // 通过组号来查找Team
        public Object getTeam(int id)
        {
            //需要进行数据解析,理论上返回的是多个数值
            var team = db.teams.Where(ti => ti.mark == id); 
            return team;
        }
    }
}