using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var result = from r in db.csByTextBox
                         select r;
            foreach (var i in result)
            {
              //  Response.Write(i.data);//
                this.doc.InnerHtml = i.data;
                
                // TextBox1.Text = i.data;
            }
            
        }
    }
}