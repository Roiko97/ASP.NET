using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;
namespace test
{
    public partial class TeamManagement : System.Web.UI.Page
    {
        TeamOperatingServlet tos = TeamOperatingServlet.TeamOperatingServletInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            //测试字段
            Session["mark"] = "cs123";

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Team_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        {

        }

    }
}