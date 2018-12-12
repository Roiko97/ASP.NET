using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAO;
namespace Controller
{
    public class UserSignInServlet
    {

       
        private UserSignInServlet()
        { }
        public static UserSignInServlet getUserSignInservletInstance()
        {
            return new UserSignInServlet();
        }
        public bool userSignIn(string userName,string userPwd)
        {
            UserDAO userDao = UserDAO.getUserDAOInstance();
            bool isTrue = userDao.userLogin(userName,userPwd);
            return isTrue;
        }

    
    }
}