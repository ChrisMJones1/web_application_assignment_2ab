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
                    //string Adding_StudentEnrolmentDate = adding_studentenrolmentdate.Text.ToString();

                    Adding_Summary.InnerHtml = "You have added the following student in the system: <br>";
                    Adding_Summary.InnerHtml += "First Name: " + Adding_StudentFname + "<br>";
                    Adding_Summary.InnerHtml += "Last Name: " + Adding_StudentLname + "<br>";
                    Adding_Summary.InnerHtml += "Student Number: " + Adding_StudentNumber + "<br>";
                    Adding_Summary.InnerHtml += "Please go back to " + "<a href=\"ListStudents.aspx\">" + "Students page " + "</a>" + "to check.";
                    //Adding_Summary.InnerHtml += "Student Enrolment Date: " + Adding_StudentEnrolmentDate + "<br>";
                    
                    string query = "insert into students (STUDENTFNAME, STUDENTLNAME, STUDENTNUMBER) values (";


                    query += "'" + Adding_StudentFname + "'" + ", ";
                    query += "'" + Adding_StudentLname + "'" + ", ";
                    query += "'" + Adding_StudentNumber + "'" + ")";
                    //query += "'" + Adding_StudentEnrolmentDate + "'" + ")";

                    sql_debugger.InnerHtml = query;
                    var db = new SCHOOLDB();
                    int add = db.Modify_Query(query);                    
                    List<Dictionary<String, String>> rs = db.List_Query(query);
                }

            }
            
                

               





            
        }
    }
}
