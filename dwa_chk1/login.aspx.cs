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

            loginID = Request.Form["LoginID"]; //Textbox: LoginID
            password = Request.Form["Password"]; //Textbox: Password
            string userType = Request.Form["User"]; //Radio Button Group: User
            string pw = "";

            pw = getParentPass(loginID);
            int id = getParentID(loginID);
           
            if (password == pw && userType == "Parent")
            {
                
                //session variable are global variables and can be accessed
                //in any page

                Session["LoginID"] = loginID;
                Session["ParentID"] = id;
                Session["DT"] = DateTime.Now;

                //redirect the user to the specific page or URL
                // Redirect user to Main.aspx page
                Response.Redirect("ParentMain.aspx");
            }
            else
            {
                // Display error message
                lblError.Text = "Invalid Login Credentials!";

            }
        }
        public static string getParentPass(string loginID)
        {
            string pw = "";
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("SELECT PPassword from Parent WHERE PEmailAddr='" + loginID + "' ", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                pw = reader[0].ToString();
            }
            conn.Close();
            return pw;
        }

        public static int getParentID(string loginID)
        {
            int id = 0;
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("SELECT ParentID from Parent WHERE PEmailAddr='" + loginID + "' ", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = Convert.ToInt32(reader[0].ToString());
            }
            conn.Close();
            return id;
        }
        }
    }

    

            
            