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
    public partial class confirmupdatetutorinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTutorID.Text = Request.QueryString["TutorID"];
            lblName.Text = Request.QueryString["Name"];
            lblSalutation.Text = Request.QueryString["Salutation"];
            lblTelNo.Text = Request.QueryString["TelNo"];
            lblNewEmailAddr.Text = Request.QueryString["NewEmailAddr"];
            lblCfmNewEmailAddr.Text = Request.QueryString["CfmNewEmailAddr"];
            lblNewPass.Text = Request.QueryString["NewPass"];
            lblCfmPass.Text = Request.QueryString["CfmPass"];
            lblFreeDay.Text = Request.QueryString["FreeDay"];
            lblTimeSlot.Text = Request.QueryString["TimeSlot"];
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("Update Tutor set TName=@name WHERE TutorID=@tutorid", conn);
            cmd.Parameters.AddWithValue("@Name", lblName.Text);
            cmd.Parameters.AddWithValue("@Salutation", lblSalutation.Text);
            cmd.Parameters.AddWithValue("@TelNo", lblTelNo.Text);
            cmd.Parameters.AddWithValue("@NewEmailAddr", lblNewEmailAddr.Text);
            cmd.Parameters.AddWithValue("@NewPass", lblNewPass.Text);
            cmd.Parameters.AddWithValue("@FreeDay", lblFreeDay.Text);
            cmd.Parameters.AddWithValue("@TimeSlot", lblTimeSlot.Text);
            
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            
            lblMessage.Text = "Tutor infromation is updated successfully.";

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            string strValues;

            strValues = "?TelNo=" + lblTelNo.Text;
            strValues += "&NewEmailAddr=" + lblNewEmailAddr.Text;
            strValues += "&CfmNewEmailAddr=" + lblCfmNewEmailAddr.Text;
            strValues += "&NewPass=" + lblNewPass.Text;
            strValues += "&CfmPass=" + lblCfmPass.Text;
            strValues += "&FreeDay=" + lblFreeDay.Text;
            strValues += "&TimeSlot=" + lblTimeSlot.Text;

            Response.Redirect("updatetutorinfo.aspx?" + strValues);
        }
    }
}