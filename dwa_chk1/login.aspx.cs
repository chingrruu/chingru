using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace dwa_chk1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string loginID = Request.Form["LoginID"];
            string password = Request.Form["password"];
            string user = Request.Form["user"];
            if (loginID == "Admin@gmail.com" && password == "passAdmin" && user == "Admin")
            {
                Session["LoginID"] = loginID;
                Session["DT"] = DateTime.Now;

                Response.Redirect("AdminMain.aspx");
            }
            if (loginID == "dominic@nptc.com" || loginID == "Elizabeth@nptc.com" || loginID == "Audrey@nptc.com" || loginID == "Chin.Chong@nptc.com" && password == "passTutor" && user == "Tutor")
            {
                Session["LoginID"] = loginID;
                Session["DT"] = DateTime.Now;

                Response.Redirect("TutorMain.aspx");
            }
            if (loginID == "john.tan@gmail.com" && password == "john1234" && user == "Parent")
            {
                Session["LoginID"] = loginID;
                Session["DT"] = DateTime.Now;

                Response.Redirect("ParentMain.aspx");
            }
        }
    }
}

    

            
            