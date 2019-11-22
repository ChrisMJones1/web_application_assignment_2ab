using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class UpdateTeacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            bool valid = true;
            string teacherid = Request.QueryString["teacherid"];
            if (String.IsNullOrEmpty(teacherid)) valid = false;

            if (valid)
            {
                var db = new SCHOOLDB();
                Dictionary<String, String> teacher_record = db.FindTeacher(Int32.Parse(teacherid));

                if (teacher_record.Count > 0)
                {
                    teacher_fullname.InnerHtml = teacher_record["TEACHERFNAME"] + " " + teacher_record["TEACHERLNAME"];
                    teacher_fname.InnerHtml = teacher_record["TEACHERFNAME"];
                    teacher_lname.InnerHtml = teacher_record["TEACHERLNAME"];
                    teacher_employeenumber.InnerHtml = teacher_record["EMPLOYEENUMBER"];
                    teacher_hiredate.InnerHtml = teacher_record["HIREDATE"];
                    teacher_salary.InnerHtml = teacher_record["SALARY"];
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
                        string Update_Teacherfname = update_teacherfname.Text.ToString();
                        string Update_Teacherlname = update_teacherlname.Text.ToString();
                        string Update_Employeenumber = update_employeenumber.Text.ToString();
                        string Update_Hiredate = update_hiredate.Text.ToString();
                        string Update_Salary = update_salary.Text.ToString();

                        update_summary.InnerHtml = "You have changed the following information about " + teacher_fullname.InnerHtml + ":<br>";

                        if (Update_Teacherfname != "")
                        {
                            update_summary.InnerHtml += "First name: " + Update_Teacherfname + "<br>";
                        }
                        else
                        {
                            update_summary.InnerHtml += "First name unchanged <br>";
                        }
                        if (Update_Teacherlname != "")
                        {
                            update_summary.InnerHtml += "Last name: " + Update_Teacherlname + "<br>";
                        }
                        else
                        {
                            update_summary.InnerHtml += "Last name unchanged <br>";
                        }
                        if (Update_Employeenumber != "")
                        {
                            update_summary.InnerHtml += "Employee number: " + Update_Employeenumber + "<br>";
                        }
                        else
                        {
                            update_summary.InnerHtml += "Employee number unchanged <br>";
                        }
                        if (Update_Hiredate != "")
                        {
                            update_summary.InnerHtml += "Hire date: " + Update_Hiredate + "<br>";
                        }
                        else
                        {
                            update_summary.InnerHtml += "Hire date unchanged <br>";
                        }
                        if (Update_Salary != "")
                        {
                            update_summary.InnerHtml += "Salary: " + Update_Salary + "<br>";
                        }
                        else
                        {
                            update_summary.InnerHtml += "Salary unchanged <br>";
                        }
                    }
                }
            }
        }
    }
}