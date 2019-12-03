using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_5101_Finalproject
{
    public partial class AddPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Page(object sender, EventArgs e)
        {
           pageDB db = new pageDB();
           HTTP_Page new_page = new HTTP_Page();
            
            new_page.SetPageTitle(page_title.Text);
            new_page.SetPageBody(page_body.Text);

            db.AddPage(new_page);
            Response.Redirect("ListOfPages.aspx");
        }
    }
}