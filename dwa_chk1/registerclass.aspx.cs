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
    public partial class registerclass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblClassID.Text = Request.QueryString["TuitionClassID"];

            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM TuitionClass WHERE TuitionClassID=@TuitionClassID ORDER BY TuitionClassID", conn);
            cmd.Parameters.AddWithValue("@TuitionClassID", lblClassID.Text);
            SqlDataAdapter daClass = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            conn.Open();
            daClass.Fill(ds, "TuitionClassDetails");
            conn.Close();
            
            lblSubject.Text = Convert.ToString(ds.Tables["TuitionClassDetails"].Rows[0]["Subject"]);
            lblTerm.Text = Convert.ToString(ds.Tables["TuitionClassDetails"].Rows[0]["Term"]);
            lblStartDate.Text = Convert.ToString(ds.Tables["TuitionClassDetails"].Rows[0]["StartDate"]);
            lblDayOfWeek.Text = Convert.ToString(ds.Tables["TuitionClassDetails"].Rows[0]["DayOfWeek"]);
            lblTimeSlot.Text = Convert.ToString(ds.Tables["TuitionClassDetails"].Rows[0]["TimeSlot"]);
            lblNumSession.Text = Convert.ToString(ds.Tables["TuitionClassDetails"].Rows[0]["NumSession"]);
            lblClassroom.Text = Convert.ToString(ds.Tables["TuitionClassDetails"].Rows[0]["Classroom"]);
            lblTutorID.Text = "1";
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
                TuitionClass objTC = new TuitionClass();
                objTC.tutorid = 1;
                objTC.subject = lblSubject.Text;
                objTC.term = lblTerm.Text;
                objTC.startdate = Convert.ToDateTime(lblStartDate.Text);
                objTC.dayofweek = lblDayOfWeek.Text;
                objTC.timeslot = lblTimeSlot.Text;
                objTC.numsession = Convert.ToInt32(lblNumSession.Text);
                objTC.classroom = lblClassroom.Text;
                objTC.tuitionClassID = Convert.ToInt32(lblClassID.Text);
                int errorcheck = objTC.update();
                if (errorcheck == 100)
                    lblMessage.Text = "Thank You! You have successfully register the class.";
            
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewavailclass.aspx");
        }
    }
}