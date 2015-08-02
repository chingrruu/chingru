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
    public partial class viewinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            displayTutorinfo();
        }
        private void displayTutorinfo()
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tutor where TutorID=1", conn);
            cmd.Parameters.AddWithValue("@tutorid", 1);
            SqlDataAdapter daTutorInfo = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            conn.Open();
            daTutorInfo.Fill(ds, "TutorInfo");
            conn.Close();

            lblTutorID.Text = Convert.ToString(ds.Tables["TutorInfo"].Rows[0]["TutorID"]);
            lblName.Text = Convert.ToString(ds.Tables["TutorInfo"].Rows[0]["TName"]);
            lblSalutation.Text = Convert.ToString(ds.Tables["TutorInfo"].Rows[0]["TSalutation"]);
            lblContactNo.Text = Convert.ToString(ds.Tables["TutorInfo"].Rows[0]["TTelNo"]);
            lblEmailAddr.Text = Convert.ToString(ds.Tables["TutorInfo"].Rows[0]["TEmailAddr"]);
            lblPass.Text = Convert.ToString(ds.Tables["TutorInfo"].Rows[0]["TPassword"]);
            lblFreeDay.Text = Convert.ToString(ds.Tables["TutorInfo"].Rows[0]["FreeDayOfWeek"]);
            lblTimeSlot.Text = Convert.ToString(ds.Tables["TutorInfo"].Rows[0]["FreeTimeSlot"]);
            lblExperience.Text = Convert.ToString(ds.Tables["TutorInfo"].Rows[0]["TExperience"]);
        }

        protected void btnedit_Click(object sender, EventArgs e)
        {

            Response.Redirect("updatetutorinfo.aspx?tutorid=" + lblTutorID.Text);

        }
    }
}