using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class AddingStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    string Adding_StudentFname = adding_studentfname.Text.ToString();
                    string Adding_StudentLname = adding_studentlname.Text.ToString();
                    string Adding_StudentNumber = adding_studentnumber.Text.ToString();
                    string Adding_StudentEnrolmentDate = adding_studentenrolmentdate.Text.ToString();

                    Adding_Summary.InnerHtml = "You have added the following student in the system: <br>";
                    Adding_Summary.InnerHtml += "Student Name: " + Adding_StudentFname + " " + Adding_StudentLname + "<br>";
                    Adding_Summary.InnerHtml += "Student Number: " + Adding_StudentNumber + "<br>";
                    Adding_Summary.InnerHtml += "Student EnrolmentDate: " + Adding_StudentEnrolmentDate + "<br>";
                    
                    string query = "insert into students (STUDENTFNAME, STUDENTLNAME, STUDENTNUMBER, ENROLMENTDATE) values (";


                    query += "'" + Adding_StudentFname + "'" + ", ";
                    query += "'" + Adding_StudentLname + "'" + ", ";
                    query += "'" + Adding_StudentNumber + "'" + ", ";
                    query += "'" + Adding_StudentEnrolmentDate + "'" + ")";



                    sql_debugger.InnerHtml = query;

                    var db = new SCHOOLDB();
                    List<Dictionary<String, String>> rs = db.List_Query(query);
                    foreach (Dictionary<String, String> row in rs)
                    {
                        students_result.InnerHtml += "<div class=\"listitem\">";

                        string studentid = row["STUDENTID"];
                        students_result.InnerHtml += "<div class=\"col6\">" + studentid + "</div>";

                        string studentfirstname = row["STUDENTFNAME"];
                        students_result.InnerHtml += "<div class=\"col6\"><a href=\"ShowStudent.aspx?studentid=" + studentid + "\">" + studentfirstname + "</a></div>";

                        string studentlastname = row["STUDENTLNAME"];
                        students_result.InnerHtml += "<div class=\"col6\">" + studentlastname + "</div>";

                        string studentnumber = row["STUDENTNUMBER"];
                        students_result.InnerHtml += "<div class=\"col6\">" + studentnumber + "</div>";

                        string enrolmentdate = row["ENROLMENTDATE"];
                        students_result.InnerHtml += "<div class=\"col6\">" + enrolmentdate + "</div>";

                        students_result.InnerHtml += "<div class=\"col6last\">" + "<a href =\"UpdateStudents.aspx\">" + "Update" + "</a>" + " " + " " + " " + "<a href =\"DeletingStudents.aspx\">" + "Delete" + "</a>" + " " + " " + " " + "<a href=\"ShowStudent.aspx?studentid=" + studentid + "\">" + "View" + "</a></div>";

                        students_result.InnerHtml += "</div>";
                    }
                }

            }
            
                

               





            
        }
    }
}
