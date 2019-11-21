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
            /*
                An alternate way to fetch data without the SCHOOLDB.cs class
                https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-sql-command.html
            */

            //resets the result set window
            animal_result.InnerHtml = "";

            string searchkey = "";

            /*if (Page.IsPostBack)
            {
                //WARNING: This technique is vulnerable to SQL injections
                //read more about SQL injections
                //https://www.csoonline.com/article/3257429/what-is-sql-injection-how-sqli-attacks-work-and-how-to-prevent-them.html
                //we will learn to defend against these attacks next semester
                searchkey = student_search.Text;
            }
            */

            string query = "select * from animallovers";

            if (searchkey != "")
            {
                query += " WHERE animalid like '%" + searchkey + "%' ";
                query += " or animalname like '%" + searchkey + "%' ";

            }
            sql_debugger.InnerHtml = query;

            var db = new Class1();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                animal_result.InnerHtml += "<div class=\"listitem\">";
                string animalid = row["animalid"];

                string animalname = row["animalname"];
                animal_result.InnerHtml += "<div class=\"col4\"><a href=\"ShowStudent.aspx?studentid=" + animalid + "\">" + animalname + "</a></div>";

                string aboutanimal = row["aboutanimal"];
                animal_result.InnerHtml += "<div class=\"col4\">" + aboutanimal + "</div>";

                animal_result.InnerHtml += "</div>";
            }


        }

    }
}