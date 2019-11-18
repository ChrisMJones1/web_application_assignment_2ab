using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class ShowClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //blank the students table on load
            students_header.InnerHtml = "";
            students_result.InnerHtml = "";
            //using modification of code written by Christine Bittle for HTTP5101, modified on Nov. 18 2019 by Christopher Jones for educational purposes
            bool valid = true;
            string classid = Request.QueryString["classid"];
            if (String.IsNullOrEmpty(classid)) valid = false;

            //We will attempt to get the record we need
            if (valid)
            {
                var db = new SCHOOLDB();
                Dictionary<String, String> class_record = db.FindClass(Int32.Parse(classid));

                if (class_record.Count > 0)
                {
                    classcode_title.InnerHtml = class_record["CLASSCODE"];
                    classcode_display.InnerHtml = class_record["CLASSCODE"];
                    teacherid.InnerHtml = "<a href=\"ShowTeacher.aspx?teacherid=" + class_record["TEACHERID"] + "\">" + class_record["TEACHERID"] + "</a>";
                    startdate.InnerHtml = class_record["STARTDATE"];
                    finishdate.InnerHtml = class_record["FINISHDATE"];
                    classname.InnerHtml = class_record["CLASSNAME"];

                    //create render loop for postback if the button is clicked, and the classid is valid
                    if (Page.IsPostBack)
                    {
                        //setup the header for the table
                        students_header.InnerHtml = "<div class=\"listitem\"> <div class=\"col4\">FIRST NAME</div> <div class=\"col4\">LAST NAME</div> <div class=\"col4\">STUDENT NUMBER</div> <div class=\"col4last\">ENROLMENT DATE</div> </div>";
                        string query = "SELECT STUDENTS.* from STUDENTS inner join studentsxclasses on students.studentid = studentsxclasses.studentid inner join classes on studentsxclasses.classid = classes.classid where classes.classid = " + classid;

                        var studentdb = new SCHOOLDB();
                        List<Dictionary<String, String>> rs = studentdb.List_Query(query);
                        foreach (Dictionary<String, String> row in rs)
                        {
                            students_result.InnerHtml += "<div class=\"listitem\">";
                            //grab the studentid to act as a unique id for linking directly to the view student as well
                            string studentid = row["STUDENTID"];

                            string studentfirstname = row["STUDENTFNAME"];
                            students_result.InnerHtml += "<div class=\"col4\"><a href=\"ShowStudent.aspx?studentid=" + studentid + "\">" + studentfirstname + "</a></div>";

                            string studentlastname = row["STUDENTLNAME"];
                            students_result.InnerHtml += "<div class=\"col4\">" + studentlastname + "</div>";

                            string studentnumber = row["STUDENTNUMBER"];
                            students_result.InnerHtml += "<div class=\"col4\">" + studentnumber + "</div>";

                            string enrolmentdate = row["ENROLMENTDATE"];
                            students_result.InnerHtml += "<div class=\"col4last\">" + enrolmentdate + "</div>";

                            //future steps: add CRUD control to this page, allowing students to be added or dropped from classes

                            students_result.InnerHtml += "</div>";
                        }
                    }
                }
                else
                {
                    valid = false;
                }
            }

            if (!valid)
            {
                schoolclass.InnerHtml = "There was an error finding that class.";
            }
            
        }
    }
}