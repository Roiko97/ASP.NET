using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using DAO;
namespace Controller
{
    public class CreateTeamMark
    {
        RandomMark randomMark = RandomMark.getRandomMarkInstance();
        /*
         获取Mark,并且进行验证,和保存.
         */
        public string getMark()
        {
            string tmpMark = randomMark.getRandom();
            UserDAO userDao = UserDAO.getUserDAOInstance();
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

    }
}