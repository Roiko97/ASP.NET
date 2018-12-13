using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;
namespace View
{
    public partial class Exchange : System.Web.UI.Page
    {
        private string student_id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["studentId"] != null)
            {
                student_id = Session["studentId"].ToString();
            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }
        /*
         优化：1）密码不满足要求时, 不运行点击提交按钮 -> 前端进行判断
         *     2） 后端进行判断,截取密码,进行匹配,不满足要求这刷新页面,要求重新填写 
         */
        protected void ecBtn_Click(object sender, EventArgs e)
        {
            UserSignInServlet userSignInservlet = UserSignInServlet.getUserSignInservletInstance();
            bool isTrue = userSignInservlet.userModifyPwd(student_id, recipient_name.Value);
            if (isTrue)
            {
                //往主页面跳转
            }
            else
            {
                Response.Redirect("Exchange.aspx");
            }
        }
        
        /**/
        protected void cteBtn_Click(object sender, EventArgs e)
        {
            CreateTeamMark ctm = new CreateTeamMark();
            //获取到mark值
            string mark = ctm.getMark();
        }
    }
}