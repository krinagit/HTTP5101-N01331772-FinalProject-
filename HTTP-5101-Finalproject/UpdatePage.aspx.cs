using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_5101_Finalproject
{
    public partial class UpdatePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
              
                pageDB db = new pageDB();
                ShowPageInfo(db);
            }
        }

        protected void Update_Page(object sender, EventArgs e)
        {

         
            pageDB db = new pageDB();

            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            Debug.WriteLine("Pageid" + pageid);
            if (String.IsNullOrEmpty(pageid)) valid = false;
            if (valid)
            {
                HTTP_Page new_page = new HTTP_Page();
                //set that student data
                new_page.SetPageTitle(page_title.Text);
                new_page.SetPageBody(page_body.Text);
                Debug.WriteLine("New Page Class" + new_page);
                //add the student to the database
                try
                {
                    db.UpdatePage(Int32.Parse(pageid), new_page);
                    Response.Redirect("ViewPage.aspx?pageid=" + pageid);
                }
                catch
                {
                    valid = false;
                }

            }

            if (!valid)
            {
                update_page.InnerHtml = "There was an error updating that page.";
            }

        }

        protected void ShowPageInfo(pageDB db)
        {

            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

           
            if (valid)
            {

                HTTP_Page page_record = db.FindPage(Int32.Parse(pageid));
                update_page.InnerHtml = page_record.GetPageTitle();
                page_title.Text = page_record.GetPageTitle();
                page_body.Text = page_record.GetPageBody();
            }

            if (!valid)
            {
                update_page.InnerHtml = "There was an error finding that page.";
            }
        }
    }
}