using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class DeletingStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool valid = true;
            string studentid = Request.QueryString["studentid"];
            if (String.IsNullOrEmpty(studentid)) valid = false;

            if (valid)
            {
                var db = new SCHOOLDB();
                Dictionary<String, String> student_record = db.FindStudent(Int32.Parse(studentid));

                if (student_record.Count > 0)
                {
                    student_fullname.InnerHtml = student_record["STUDENTFNAME"] + " " + student_record["STUDENTLNAME"];
                    student_fname.InnerHtml = student_record["STUDENTFNAME"];
                    student_lname.InnerHtml = student_record["STUDENTLNAME"];
                    student_number.InnerHtml = student_record["STUDENTNUMBER"];
                    enrolment_date.InnerHtml = student_record["ENROLMENTDATE"];
                }
                else
                {
                    valid = false;
                }
                if (Page.IsPostBack)
                {
                    Page.Validate();
                    if (Page.IsValid)
                    {
                        deleting_summary.InnerHtml = "You have successfully deleted the following student: <br>";
                        deleting_summary.InnerHtml += "First name: " + student_fname.InnerHtml + "<br>";
                        deleting_summary.InnerHtml += "Last name: " + student_lname.InnerHtml + "<br>";
                        deleting_summary.InnerHtml += "Student number: " + student_number.InnerHtml + "<br>";
                        deleting_summary.InnerHtml += "Enrolment date: " + enrolment_date.InnerHtml + "<br>";
                        deleting_summary.InnerHtml += "Please go back to "+ "<a href=\"ListStudents.aspx\">" + "Students page " + "</a>" + "to check.";

                        string query = "Delete from students where studentid = " + studentid;
                        sql_debugger.InnerHtml = query;

                        
                        int delete = db.Modify_Query(query);
                    }
                }
            }

           
        }
    }
}