using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test
{
    /*
     测试文本框
     */
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            csByTextBox result  = new csByTextBox();
            result.data = this.txtEditorContents.Text;
            db.csByTextBox.InsertOnSubmit(result);
            db.SubmitChanges();
            Response.Redirect("WebForm2.aspx");
        }
    }
}