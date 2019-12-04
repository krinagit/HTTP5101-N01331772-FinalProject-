using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_5101_Finalproject
{
    public partial class MainNav : System.Web.UI.UserControl
    {
            protected void Page_Load(object sender, EventArgs e)
            {
                pageDB db = new pageDB();
                ListOfNavbarLinks(db);
            }

            protected void ListOfNavbarLinks(pageDB db)
            {
                //query the most popular classes (most students)
                string query = "select * from page";
                List<Dictionary<String, String>> rs = db.List_Query(query);

                foreach (Dictionary<String, String> row in rs)
                {
                string pageid = row["pageid"];

                string pagetitle = row["pagetitle"];
               
                
                nav.InnerHtml += "</div>";
               
                nav.InnerHtml +="<a href=\"ViewPage.aspx?pageid=" + pageid + "\">" + pagetitle + "</a>";

              


            }
            }
        
    }
}