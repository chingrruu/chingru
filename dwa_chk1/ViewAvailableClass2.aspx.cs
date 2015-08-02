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
    public partial class RegisterAvailableClass2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTC"]);


            SqlConnection conn = new SqlConnection(strConn);


            SqlCommand cmd = new SqlCommand("SELECT * From TuitionClass inner join Tutor on TuitionClass.TutorID = Tutor.TutorID", conn);


            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataSet ds = new DataSet();


            conn.Open();

            da.Fill(ds, "TuitionClass");


            conn.Close();


            gvAvailableClass.DataSource = ds.Tables["TuitionClass"];
            //specify the source of data
            gvAvailableClass.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}