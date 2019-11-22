using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class DeleteTeacher : System.Web.UI.Page
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
                        delete_summary.InnerHtml = "The current teacher record has been deleted.";
                    }
                }
            }
            /* 
                author: Christine ;
                site: https://github.com/christinebittle/crud_essentials ;
                date accessed: Nov 18 2019 ;
                using purpose: to access the selected information from school database;
            */
        }
    }
}