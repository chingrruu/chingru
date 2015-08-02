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
    public partial class viewtutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                displayTutor();
            }
        }
        private void displayTutor()
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tutor ORDER BY TutorID", conn);
            SqlDataAdapter daTutor = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            conn.Open();
            daTutor.Fill(ds, "Tutor");
            conn.Close();

            gvTutor.DataSource = ds.Tables["Tutor"];
            gvTutor.DataBind();
        }

        protected void gvTutor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}