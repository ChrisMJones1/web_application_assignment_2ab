using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class ListTeachers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            teachers_result.InnerHtml = "";

            string search = "";

            if (Page.IsPostBack)
            {
                search = teacher_search.Text;
            }

            string query = "SELECT * FROM TEACHERS";

            if (search != "")
            {
                query += " WHERE TEACHERFNAME LIKE '%" + search + "%' ";
                query += " OR TEACHERLNAME LIKE '%" + search + "%' ";
                query += " OR TEACHERID =" + search;
            }

            //sql_debugger.InnerHtml = query;

            var db = new SCHOOLDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            /* 
                author: Christine ;
                site: https://github.com/christinebittle/crud_essentials ;
                date accessed: Nov 16 2019 ;
                using purpose: to access the school database;
            */

            foreach (Dictionary<String, String> row in rs)
            {
                teachers_result.InnerHtml += "<div class=\"listitem\">";

                string teacherid = row["TEACHERID"];
                teachers_result.InnerHtml += "<div class=\"col7\">" + teacherid + "</div>";

                string teacherfirstname = row["TEACHERFNAME"];
                teachers_result.InnerHtml += "<div class=\"col7\"><a href=\"ShowTeacher.aspx?teacherid=" + teacherid + "\">" + teacherfirstname + "</a></div>";

                string teacherlastname = row["TEACHERLNAME"];
                teachers_result.InnerHtml += "<div class=\"col7\">" + teacherlastname + "</div>";

                string employeenumber = row["EMPLOYEENUMBER"];
                teachers_result.InnerHtml += "<div class=\"col7\">" + employeenumber + "</div>";

                string hiredate = row["HIREDATE"];
                teachers_result.InnerHtml += "<div class=\"col7\">" + hiredate + "</div>";

                string salary = row["SALARY"];
                teachers_result.InnerHtml += "<div class=\"col7\">" + salary + "</div>";

                teachers_result.InnerHtml += "<div class=\"col7last\">" + "<a href=\"UpdateTeacher.aspx?teacherid=" + teacherid + "\"> Update </a>" + "<a href=\"DeleteTeacher.aspx?teacherid=" + teacherid + "\"> Delete </a>" + "<a href=\"ShowTeacher.aspx?teacherid=" + teacherid + "\"> View </a>" + "</div>";

                teachers_result.InnerHtml += "</div>";
            }
        }
    }
}