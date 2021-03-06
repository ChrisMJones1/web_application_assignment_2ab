﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class UpdateClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
                    teacherid.InnerHtml = class_record["TEACHERID"];
                    startdate.InnerHtml = class_record["STARTDATE"].Substring(0, 10);
                    finishdate.InnerHtml = class_record["FINISHDATE"].Substring(0, 10);
                    classname.InnerHtml = class_record["CLASSNAME"];
                    if (Page.IsPostBack)
                    {
                        string ClassCode = new_classcode.Text.ToString();
                        string TeacherId = new_teacherid.Text.ToString();
                        string StartDate = new_startdate.Text.ToString();
                        string FinishDate = new_finishdate.Text.ToString();
                        string ClassName = new_classname.Text.ToString();
                        //should probably do the handling with a function or a loop (nesting the data within a list and incremeting to check for blank input)
                        if (ClassCode == "")
                        {
                            ClassCode =  class_record["CLASSCODE"];
                        }
                        if (TeacherId == "")
                        {
                            TeacherId = class_record["TEACHERID"];
                        }
                        if (StartDate == "")
                        {
                            StartDate = class_record["STARTDATE"].Substring(0, 10);
                        }
                        if (FinishDate == "")
                        {
                            FinishDate = class_record["FINISHDATE"].Substring(0, 10);
                        }
                        if (ClassName == "")
                        {
                            ClassName = class_record["CLASSNAME"];
                        }
                        string query = "UPDATE classes SET CLASSCODE ='" + ClassCode + "', TEACHERID =" + TeacherId + ", STARTDATE='" + StartDate + "', FINISHDATE='" + FinishDate + "', CLASSNAME='" + ClassName + "' WHERE CLASSID = " + classid;
                        var edit = new SCHOOLDB();
                        int add = edit.Modify_Query(query);
                        Response.Redirect("~/ShowClass.aspx?classid=" + classid);
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