using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class AddClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    string ClassCode = classcode.Text.ToString();
                    string TeacherId = teacherid.Text.ToString();
                    string StartDate = startdate.Text.ToString();
                    string FinishDate = finishdate.Text.ToString();
                    string ClassName = classname.Text.ToString();
                    string query = "INSERT INTO classes (CLASSCODE, TEACHERID, STARTDATE, FINISHDATE, CLASSNAME) values ('" + ClassCode + "'," + TeacherId + ",'" + StartDate + "','" + FinishDate + "','" + ClassName + "');";
                    var db = new SCHOOLDB();
                    int add = db.Modify_Query(query);
                    Response.Redirect("~/ListClasses.aspx");

                }
            }
        }
    }
}