using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class ListClasses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //code created by Christine Bittle, modified by Christopher Jones, initially accessed on November 15th, 2019
            //blanking results set, in case of search bar function rerunning rendering process
            classes_result.InnerHtml = "";
            //set the searchkey to be blank
            string searchkey = "";
            //if the page is postback, check to see if something was entered into the search field
            if(Page.IsPostBack)
            {
                //this method opens up the risk of sql injection, but we will use it for the purpose of this assignment
                searchkey = class_search.Text;
            }
            //set the default query to grab all columns from the CLASSES table
            string query = "select CLASSES.*, CONCAT(teachers.teacherfname, ' ', teachers.teacherlname) as `teachers full name` from CLASSES inner join TEACHERS on CLASSES.teacherid = TEACHERS.teacherid";
            //if the searchkey isn't a blank string, create a search query for 3 column conditions
            if (searchkey != "")
            {
                query += " WHERE CLASSCODE like '%" + searchkey + "%' ";
                query += " or CLASSNAME like '%" + searchkey + "%' ";
                query += " or STARTDATE like '%" + searchkey + "%' ";
            }
            //create a rendering loop using Christine Bittle's design to output the data gathered from the database into a webpage
            var db = new SCHOOLDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                classes_result.InnerHtml += "<div class=\"listitem\">";
                //grab the classid to act as a unique selector id, we do not need to render it
                string classid = row["CLASSID"];
                //grab the teacherid to act as the unique identifier for that as well
                string teacherid = row["TEACHERID"];

                string classcode = row["CLASSCODE"];
                //create a link for a viewpage to view the class info on a different page
                //classes_result.InnerHtml += "<div class=\"col6\"><a href=\"ShowClass.aspx?classid=" + classid + "\">" + classcode + "</a></div>";
                classes_result.InnerHtml += "<div class=\"col6\">" + classcode + "</div>";
                string teachername = row["teachers full name"];
                //selector to view the teacher's page
                classes_result.InnerHtml += "<div class=\"col6\"><a href=\"ShowTeacher.aspx?teacherid=" + teacherid + "\">" + teachername + "</a></div>";

                string startdate = row["STARTDATE"];
                classes_result.InnerHtml += "<div class=\"col6\">" + startdate + "</div>";

                string finishdate = row["FINISHDATE"];
                classes_result.InnerHtml += "<div class=\"col6\">" + finishdate + "</div>";

                string classname = row["CLASSNAME"];
                classes_result.InnerHtml += "<div class=\"col6\">" + classname + "</div>";

                classes_result.InnerHtml += "<div class=\"col6last\">" + "<a href =\"UpdateClass.aspx?classid=" + classid + "\">" + "Update" + "</a>" + " " + " " + " " + "<a href =\"DeleteClass.aspx?classid=" + classid + "\">" + "Delete" + "</a>" + " " + " " + " " + "<a href=\"ShowClass.aspx?classid=" + classid + "\">" + "View" + "</a></div>";

                classes_result.InnerHtml += "</div>";
            }

        }
    }
}