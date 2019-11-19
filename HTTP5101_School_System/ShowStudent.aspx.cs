using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class ShowStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            classes_header.InnerHtml = "";
            classes_result.InnerHtml = "";
            //This code is provided by Christine Bittle, modified by Paul Tran
            bool valid = true;
            string studentid = Request.QueryString["studentid"];
            //string classid = Request.QueryString["classid"];
            if (String.IsNullOrEmpty(studentid)) valid = false;

            //We will attempt to get the record we need
            if (valid)
            {
                var db = new SCHOOLDB();
                Dictionary<String, String> student_record = db.FindStudent(Int32.Parse(studentid));

                if (student_record.Count > 0)
                {
                    student_title_fname.InnerHtml = student_record["STUDENTFNAME"] + " " + student_record["STUDENTLNAME"];
                    student_fname.InnerHtml = student_record["STUDENTFNAME"];
                    student_lname.InnerHtml = student_record["STUDENTLNAME"];
                    student_number.InnerHtml = student_record["STUDENTNUMBER"];
                    enrolment_date.InnerHtml = student_record["ENROLMENTDATE"];
                    //WHAT IF user want to see which class the student enrolled  in
                    //enrolled_class.InnerHtml = "";
                    //string query = "SELECT classes.classname, classes.classcode from classes inner join studentsxclasses on classes.classid = studentsxclasses.classid inner join students on studentsxclasses.studentid = students.studentid where students.studentid = " + studentid;
                    if (Page.IsPostBack)
                    {
                        string query = "SELECT classes.* from classes inner join studentsxclasses on classes.classid = studentsxclasses.classid inner join students on studentsxclasses.studentid = students.studentid where students.studentid =" + studentid;
                        List<Dictionary<String, String>> rs = db.List_Query(query);
                        foreach (Dictionary<String, String> row in rs)
                        {
                            classes_result.InnerHtml += "<div class=\"_table\">";

                            string classid = row["CLASSID"];              

                            string classcode = row["CLASSCODE"];                         
                            classes_result.InnerHtml += "<div class=\"col4\">" + classcode + "</div>"; 
                            
                            string classname = row["CLASSNAME"];
                            classes_result.InnerHtml += "<div class=\"col4\">" + classname + "</div>";                
   
                            string startdate = row["STARTDATE"];
                            classes_result.InnerHtml += "<div class=\"col4\">" + startdate + "</div>";

                            string finishdate = row["FINISHDATE"];
                            classes_result.InnerHtml += "<div class=\"col4last\">" + finishdate + "</div>";
                            //To test this, I add myself in the database and enrolled me in a class and the code actually show I am a student                         

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
                student.InnerHtml = "There was an error finding that student.";
            }
        }
    }
}