using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
// this namespace is used to access the web.config file.

using System.Data.SqlClient;
// this namespace is used to connect to the MS SQL database server and to execute the SQL statements

using System.Data;
// this namespace is used to store the records fetched from the MS SQL database server

namespace dwa_chk1
{
    public partial class AdminViewClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            displayClassList();
        }

        private void displayClassList()
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM TuitionClass", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            conn.Open();
            da.Fill(ds, "Class");
            conn.Close();
            gvClass.DataSource = ds.Tables["Class"];
            gvClass.DataBind();

            if (ds.Tables["Class"].Rows.Count > 0)
            {
                lblMessage.Text = "There are a total number of " + ds.Tables["Class"].Rows.Count + " tuition class";
            }

            else
            {
                lblMessage.Text = "There are no tuition class to display";
            }

        }

        protected void gvClass_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // Set the page index to the page clicked by user.

            gvClass.PageIndex = e.NewPageIndex;

            // Display records on the new page.

            gvClass.DataBind();
        }
    }
}