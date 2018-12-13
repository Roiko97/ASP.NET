using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using DAO;
namespace Controller
{
    public class TeamOperatingServlet
    {
        RandomMark randomMark = RandomMark.getRandomMarkInstance();
        UserDAO userDao = UserDAO.getUserDAOInstance();
        /*
         获取Mark,并且进行验证,和保存.
         */
        public string getMark()
        {
            string tmpMark = randomMark.getRandom();
            bool isTrue;
            while(true)
            {
                isTrue = userDao.checkRepeatMark(tmpMark);
                if (isTrue)
                    break;
                tmpMark = randomMark.getRandom();
            }
            userDao.saveMark(tmpMark);
            return tmpMark; 
        }

        /*
         更新用户的小组组号，成功返回true 失败返回false
         */
        public bool updateUserMark(string userId, string mark)
        {
            return userDao.updateUserMark(userId, mark);
           
        }
        
        /*更新小组的题目 By mark 成功返回true，失败返回false */
        public bool updateTeamMark(string mark)
        {
            return userDao.updateTeamHeading(mark);
        }

        
    }
}