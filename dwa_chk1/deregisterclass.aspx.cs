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
    public partial class deregisterclass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand cmd = new SqlCommand("Select tc.TuitionClassID, Subject, Term, StartDate, DayOfWeek, TimeSlot, NumSession, Classroom FROM TuitionClass tc WHERE tc.TuitionClassID NOT IN (SELECT tc.TuitionClassID from TuitionClass tc INNER JOIN ClassStudent cs ON tc.TuitionClassID = cs.TuitionClassID) AND TutorID=@tutorid", conn);
                cmd.Parameters.AddWithValue("@tutorid", 1);
                SqlDataAdapter daClass = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                conn.Open();
                daClass.Fill(ds, "TuitionClass");
                conn.Close();
                
                gvCT.DataSource = ds.Tables["TuitionClass"];
                gvCT.DataBind();
            }
        }

        protected void gvCT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

    }
}