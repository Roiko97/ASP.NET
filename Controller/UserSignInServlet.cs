using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAO;
namespace Controller
{
    public class UserSignInServlet
    {

        private UserDAO userDao = UserDAO.getUserDAOInstance();
        private UserSignInServlet()
        { }
        public static UserSignInServlet getUserSignInservletInstance()
        {
            return new UserSignInServlet();
        }
        public bool userSignIn(string userName,string userPwd)
        {
            bool isTrue = userDao.userLogin(userName,userPwd);
            return isTrue;
        }

        public bool userModifyPwd(string userName,string userPwd)
        {
            bool isTrue = userDao.userModifyPwd(userName, userPwd);
            if (isTrue)
                return true;
            else
                return false;
        }
    }
}