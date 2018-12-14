using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;
namespace View
{
    public partial class Home : System.Web.UI.Page
    {
        string getStudentIdByCookie = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["studentInfo"];
            if (cookie != null)
            {
                getStudentIdByCookie = cookie["studentId"];
                userName.Value = getStudentIdByCookie;
            }
        }

        protected void signIn_Click(object sender, EventArgs e)
        {
            string _userName = userName.Value.Trim();
            string _userPaw = userPaw.Value.Trim();
            UserSignInServlet userSignInservlet = UserSignInServlet.getUserSignInservletInstance();
            bool isTrue = userSignInservlet.userSignIn(_userName, _userPaw);
            if (isTrue)
            {
                Session["studentId"] = _userName;
                Response.Write("<script>alert('success')</script>");
                HttpCookie cookie = new HttpCookie("studentInfo");
                cookie["studentId"] = _userName;
                cookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(cookie);
                if (_userPaw == "123456")
                {
                    Response.Redirect("Exchange.aspx");
                }
                else
                {
                    // 如果密码安全
                    Response.Redirect("Summarize.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('账号或密码错误,请重新尝试')</script>");
                userName.Value = userPaw.Value = "";
            }
        }
    }
}