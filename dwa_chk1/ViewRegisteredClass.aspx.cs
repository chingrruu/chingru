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
    public partial class ViewRegisteredClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            displayRegisteredClass();
        }

        private void displayRegisteredClass()
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);


            SqlConnection conn = new SqlConnection(strConn);


            SqlCommand cmd = new SqlCommand("SELECT * From ClassStudent inner join TuitionClass on ClassStudent.TuitionClassID = TuitionClass.TuitionClassID inner join Tutor on Tutor.TutorID = TuitionClass.TutorID where ParentID = @parentid", conn);
            cmd.Parameters.AddWithValue("@parentid", Convert.ToInt32(Session["ParentID"]));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();


            conn.Open();


            da.Fill(ds, "ClassStudent");


            conn.Close();


            gvRegisteredClass.DataSource = ds.Tables["ClassStudent"];
            //specify the source of data
            gvRegisteredClass.DataBind();
        }

        protected void gvRegisteredClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}