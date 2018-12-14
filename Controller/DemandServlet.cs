using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAO;
namespace Controller
{
    public class DemandServlet
    {
        private UserDAO userDao = UserDAO.getUserDAOInstance();
        private DemandServlet()
        {
            ;
        }
        public static DemandServlet getDemandServletInstance()
        {
            return new DemandServlet();
        }

        /*判断是否存在需求分析的字段*/
        public bool exitRecording(string mark)
        {
            var result =  userDao.getDemandByMark(mark);
            if(result == null)
            {
                // 返回空 表示没有查询到
                return true;
            }
            else
            {
                return false;//表示已经存在页面了
            }
        }
    }
}