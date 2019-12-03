using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_5101_Finalproject
{
    public partial class ViewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pageDB db = new pageDB();
            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            Debug.WriteLine("Pageid" + pageid);
            if (String.IsNullOrEmpty(pageid)) valid = false;
            if (valid)
            {

                HTTP_Page page_record = db.FindPage(Int32.Parse(pageid));
                page_title.InnerHtml = page_record.GetPageTitle();
                page_body.InnerHtml = page_record.GetPageBody();

                updatepage.InnerHtml += "<a href=\"UpdatePage.aspx?pageid=" + pageid + "\">" +"Update"  + "</a>";
                updatepage.InnerHtml += "<a href=\"DeletePage.aspx?pageid=" + pageid + "\">" + "Delete" + "</a>";
                               
            }
            else
            {
                valid = false;
            }
            if (!valid)
            {
                http_page.InnerHtml = "There was an error finding that page.";
            }
        }
    }
}