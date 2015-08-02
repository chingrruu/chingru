using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_chk1
{
    public partial class Parent : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginID"] == null)
            {
                Response.Redirect("Index.html");
            }
            else
            {
                lblLoginID.Text = Convert.ToString(Session["LoginID"]);
                lblDateTime.Text = "You have logged in since: " + Convert.ToString(Session["DT"]);

                lblTotalUsers.Text = "there are currently " + Convert.ToString(Application["CU"]) + " users";
            }
        }
    }
}