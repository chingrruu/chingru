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
    public partial class viewavailclass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            displayAvailClass();
        }
        private void displayAvailClass()
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM TuitionClass WHERE TutorID IS NULL ORDER BY TuitionClassID", conn);
            SqlDataAdapter daClass = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            conn.Open();
            daClass.Fill(ds, "TuitionClassDetails");
            conn.Close();

            gvTC.DataSource = ds.Tables["TuitionClassDetails"];
            gvTC.DataBind();

            if (ds.Tables["TuitionClassDetails"].Rows.Count > 0)
            {
                lblMessage.Text = " There are a total number of:" + ds.Tables["TuitionClassDetails"].Rows.Count + "  classes.";
            }
            else
            {
                lblMessage.Text = "There are no classes to display.";
            }
        }

        
        protected void gvTC_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

    } 
}