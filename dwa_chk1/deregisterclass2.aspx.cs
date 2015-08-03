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

            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("Update TuitionClass Set TutorID=Null WHERE TuitionClassID=@TuitionClassID", conn);
            cmd.Parameters.AddWithValue("@TuitionClassID", Request.QueryString["tuitionClassID"]);
            SqlDataAdapter daClass = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            conn.Open();
            daClass.Fill(ds, "TuitionClass");
            conn.Close();

    
                lblMessage.Text = "Tuition Class is succesfully deregistered.";
            
          
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewclassestaken.aspx");
        }

    }
}