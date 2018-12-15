using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
<<<<<<< HEAD

=======
using Controller;
>>>>>>> 290257720829554fd4189531515e80d3e484600a
namespace test
{
    public partial class TeamManagement : System.Web.UI.Page
    {
<<<<<<< HEAD
        protected void Page_Load(object sender, EventArgs e)
        {
=======
        TeamOperatingServlet tos = TeamOperatingServlet.TeamOperatingServletInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            //测试字段
            Session["mark"] = "cs123";
>>>>>>> 290257720829554fd4189531515e80d3e484600a

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Team_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        {

        }
<<<<<<< HEAD
=======

>>>>>>> 290257720829554fd4189531515e80d3e484600a
    }
}