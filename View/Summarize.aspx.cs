using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;
namespace View
{
    public partial class Summarize : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Demand_Click(object sender, EventArgs e)
        {


            UserSignInServlet us = UserSignInServlet.getUserSignInservletInstance();

            //为了测试方便
            string stdId = "123";
            //string stdId = Session["studentId"].ToString();
            string mark   = us.getMarkByStudentId(stdId);
            DemandServlet dm = DemandServlet.getDemandServletInstance();
            bool isTrue  = dm.exitRecording(mark); // true 代表没有查到
            if (isTrue == true)
            {
                Response.Redirect("1#");
            }
            else
            {
                Response.Redirect("Demand.aspx");
            }
        }
    }
}