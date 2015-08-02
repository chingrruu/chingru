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
    public partial class viewclassestaken : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand cmd = new SqlCommand("SELECT * from TuitionClass WHERE TutorID= 1", conn);
                cmd.Parameters.AddWithValue("@TutorID", 1);
                SqlDataAdapter daClass = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                conn.Open();
                daClass.Fill(ds, "TuitionClass");
                conn.Close();
                ddlTC.DataTextField = "TuitionClassID";
                ddlTC.DataValueField = "TuitionClassID";
                ddlTC.DataSource = ds.Tables["TuitionClass"];
                ddlTC.DataBind();

                
            }
            
        }

        protected void ddlTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tuitionClassID = Convert.ToInt32(ddlTC.SelectedValue);
            TuitionClass objTuitionClass = new TuitionClass();
            objTuitionClass.tuitionClassID = tuitionClassID;
            DataSet ds = new DataSet();         
            objTuitionClass.getTuitionDetails(ref ds);
            gvCT.DataSource = ds.Tables["tuitionclassdetails"];
            gvCT.DataBind();
            
        }

        protected void gvCT_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}