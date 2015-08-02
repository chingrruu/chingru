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
    public partial class deregisterclass2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTCID.Text = Request.QueryString["tuitionClassID"];          
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            TuitionClass objTuitionClass = new TuitionClass();
            objTuitionClass.tuitionClassID = Convert.ToInt32(Request.QueryString["tuitionClassID"]);
            int errorcode = objTuitionClass.delete();

            if (errorcode == 0)
                lblMessage.Text = "Class succesfully deregistered.";
            if (errorcode == 1)
                lblMessage.Text = "Class is not deregister.";
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewclassestaken.aspx");
        }

    }
}