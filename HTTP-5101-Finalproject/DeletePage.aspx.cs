using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_5101_Finalproject
{
    public partial class DeletePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }
   

       protected void Delete_Page(object sender, EventArgs e)
        {
            pageDB db = new pageDB();
            string pageid = Request.QueryString["pageid"];

            db.DeletePage(Int32.Parse(pageid));
            Response.Redirect("ListOfPages.aspx");


        }
    }
}