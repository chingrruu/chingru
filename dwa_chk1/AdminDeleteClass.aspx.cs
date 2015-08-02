using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_chk1
{
    public partial class AdminDeleteClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblClassID.Text = Request.QueryString["cid"];
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            TuitionClass objClass = new TuitionClass();
            objClass.classid = Convert.ToInt32(Request.QueryString["cid"]);
            int errorcode = objClass.delete();

            if (errorcode == 1)
                lblMessage.Text = "Class successfully deleted";
            if (errorcode == 0)
                lblMessage.Text = "Class was not deleted";
        }

        protected void btnNo_Click1(object sender, EventArgs e)
        {
            Response.Redirect("AdminViewClass.aspx");
        }
    }
}