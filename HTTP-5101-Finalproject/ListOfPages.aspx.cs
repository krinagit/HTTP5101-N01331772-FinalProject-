using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_5101_Finalproject
{
    public partial class ListOfPages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            page_result.InnerHtml = "";

            string searchkey = "";

           string query = "select * from page";

            if (searchkey != "")
            {
                query += " WHERE pageid like '%" + searchkey + "%' ";
                query += " or pagetitle like '%" + searchkey + "%' ";
                query += " or pagebody like '%" + searchkey + "%' ";
            }
          //  sql_debugger.InnerHtml = query;

            var db = new pageDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                page_result.InnerHtml += "<div class=\"listitem\">";
                string pageid = row["pageid"];

                string pagetitle = row["pagetitle"];
                page_result.InnerHtml += "<div class=\"col4\"><a href=\"ViewPage.aspx?pageid=" + pageid + "\">" + pagetitle + "</a></div>";

                string pagebody = row["pagebody"];
                page_result.InnerHtml += "<div class=\"col4\">" + pagebody + "</div>";

                page_result.InnerHtml += "</div>";
                page_list.InnerHtml += "<a href=\"ViewPage.aspx?pageid=" + pageid + "\">" + pagetitle + "</a>";
            }


        }

    }
}