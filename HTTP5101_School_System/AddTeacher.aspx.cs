using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class Add_Teacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    string Add_TeacherFname = add_teacherfname.Text.ToString();
                    string Add_TeacherLname = add_teacherlname.Text.ToString();
                    string Add_EmployeeNumber = add_employeenumber.Text.ToString();
                    string Add_HireDate = add_hiredate.Text.ToString();
                    double Add_Salary = Convert.ToDouble(add_salary.Text);
                    /*  
                     *  author: Microsoft;
                     *  site: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number;
                     *  date accessed: Nov 19 2019;
                     *  using purpose: to convert string(salary) to a double type number;
                     */
                     /* show the user added information summary: */
                    Add_Summary.InnerHtml = "You have added the following teacher in the system: <br>";
                    Add_Summary.InnerHtml += "First name: " + Add_TeacherFname + "<br>";
                    Add_Summary.InnerHtml += "Last name: " + Add_TeacherLname + "<br>";
                    Add_Summary.InnerHtml += "Employee number: " + Add_EmployeeNumber + "<br>";
                    Add_Summary.InnerHtml += "Teacher hire date: " + Add_HireDate + "<br>";
                    Add_Summary.InnerHtml += "Teacher salary: " + Add_Salary + "<br>";

                    /* try to modify the added data into the database table, and make it show in the teacher list interface: 

                    string query = "insert into teachers (TEACHERFNAME, TEACHERLNAME, EMPLOYEENUMBER, HIREDATE) values (";

                    query += "'" + Add_TeacherFname + "'" + ", ";
                    query += "'" + Add_TeacherLname + "'" + ", ";
                    query += "'" + Add_EmployeeNumber + "'" + ", ";
                    query += "'" + Add_HireDate + "'" + ",";
                    query += "'" + Add_Salary + "'" + ")";


                    sql_debugger.InnerHtml = query;

                    var db = new SCHOOLDB();
                    List<Dictionary<String, String>> rs = db.List_Query(query);
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

                        teachers_result.InnerHtml += "<div class=\"col7last\">" + "<a href=\"UpdateTeacher.aspx?teacherid=" + teacherid + "\"> Update </a>" + "<a href=\"ShowTeacher.aspx?teacherid=" + teacherid + "\"> Delete </a>" + "<a href=\"ShowTeacher.aspx?teacherid=" + teacherid + "\"> View </a>" + "</div>";

                        teachers_result.InnerHtml += "</div>";
                    }
                    */
                }
            }
        }
    }
}