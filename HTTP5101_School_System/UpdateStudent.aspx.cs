using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class UpdateStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            bool valid = true;
            string studentid = Request.QueryString["studentid"];
            if (String.IsNullOrEmpty(studentid)) valid = false;

            //We will attempt to get the record we need
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

                            string Update_Studentfname = update_studentfname.Text.ToString();
                            string Update_Studentlname = update_studentlname.Text.ToString();
                            string Update_Studentnumber = update_studentnumber.Text.ToString();
                            string Update_Studentenrolmentdate = update_studentenrolmentdate.Text.ToString();

                            updating_summary.InnerHtml = "You have changed the following information about " + student_fullname.InnerHtml + ":<br>";                            
                            //if user doesn't want to change a field it will be display as unchange
                            //if a field is change the information will be display accordingly
                            if (Update_Studentfname != "")
                            {
                                updating_summary.InnerHtml += "First name: " + Update_Studentfname + "<br>";
                            }
                            else
                            {
                                updating_summary.InnerHtml += "First name: unchange <br>";
                            }
                            if (Update_Studentlname != "")
                            {
                                updating_summary.InnerHtml += "Last name: " + Update_Studentlname + "<br>";
                            }
                            else
                            {
                                updating_summary.InnerHtml += "Last name: unchange <br>";
                            }
                            if (Update_Studentnumber !="")
                            {
                                updating_summary.InnerHtml += "Student number: " + Update_Studentnumber + "<br>";
                            }
                            else
                            {
                                updating_summary.InnerHtml += "Student number: unchange <br>";
                            }
                            if (Update_Studentenrolmentdate != "")
                            {
                                updating_summary.InnerHtml += "Enrolment date: " + Update_Studentenrolmentdate + "<br>";
                            }
                            else
                            {
                                updating_summary.InnerHtml += "Enrolment date: unchange <br>";
                            }

                        }
                    }


               



            }
        }
    }
}