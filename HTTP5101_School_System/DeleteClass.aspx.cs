using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class DeleteClass : System.Web.UI.Page
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
                    startdate.InnerHtml = class_record["STARTDATE"];
                    finishdate.InnerHtml = class_record["FINISHDATE"];
                    classname.InnerHtml = class_record["CLASSNAME"];

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