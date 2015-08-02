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
    public partial class viewclasstakenbytutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string tc = Request.QueryString["classStudentID"];
                
                string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand cmd = new SqlCommand("Select * from Attendance a INNER JOIN ClassStudent cs ON a.ClassStudentID = cs.ClassStudentID WHERE TuitionClassID=1", conn);
                SqlCommand cmdSD = new SqlCommand("Select StartDate , TimeSlot, NumSession from TuitionClass WHERE TutorID=1 AND TuitionClassID = @classStudentID", conn);
                cmdSD.Parameters.AddWithValue("@TutorID", 1);
                cmdSD.Parameters.AddWithValue("@classStudentID", tc);
                SqlDataAdapter daClass = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                SqlDataAdapter daSD = new SqlDataAdapter(cmdSD);
                DataSet dsSD = new DataSet();
                conn.Open();
                daClass.Fill(ds, "AttendanceDetails");
                daSD.Fill(dsSD, "GetAttendanceDetails");
                conn.Close();
                gvAttendance.DataSource = ds.Tables["AttendanceDetails"];
                gvAttendance.DataBind();

                string timeSlot = Convert.ToString(dsSD.Tables["GetAttendanceDetails"].Rows[0]["TimeSlot"]);
                DateTime StartDate;
                StartDate = Convert.ToDateTime(dsSD.Tables["GetAttendanceDetails"].Rows[0]["StartDate"]);
                StartDate = StartDate.Date;
                int NumSession = Convert.ToInt32(dsSD.Tables["GetAttendanceDetails"].Rows[0]["NumSession"]);
                DateTime[] sessionDateArray = new DateTime[NumSession];
                sessionDateArray[0] = StartDate.AddDays(-7);
                
                for (int i = 1; i < sessionDateArray.Length; i++)
                {
                    sessionDateArray[i] = sessionDateArray[i - 1].AddDays(7);
                    sessionDateArray[i] = sessionDateArray[i].Date;
                    ddlSD.Items.Add(sessionDateArray[i].ToString());
                }

           }
        }

        private void displayViewClassTakenByTutor()
        {

            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("Select * from TuitionClass where TutorID = @TutorID and TuitionClassID = @TutionClassID", conn);
            cmd.Parameters.AddWithValue("@TutorID", 1);
            SqlDataAdapter daClass = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            conn.Open();
            daClass.Fill(ds, "AttendanceDetails");
            conn.Close();

            gvAttendance.DataSource = ds.Tables["AttendanceDetails"];
            gvAttendance.DataBind();
            for (int i = 0; i < ds.Tables["AttendanceDetails"].Rows.Count; i++)
            {
                if (Convert.ToString(ds.Tables["AttendanceDetails"].Rows[i]["Status"]) == "P")
                {   
                    DropDownList ddlS = (DropDownList)(gvAttendance.Rows[i].FindControl("ddlStatus"));    
                }
                else if(Convert.ToString(ds.Tables["AttendanceDetails"].Rows[i]["Status"]) == "A")
                {
                    DropDownList ddlS = (DropDownList)(gvAttendance.Rows[i].FindControl("ddlStatus"));    
                }
            }
        }
        public string displayAorP(Boolean status)
        {
            if (status == true)
                return "P";
            else
                return "A";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvAttendance_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "UpdateRemarks")
            {
                int i = Convert.ToInt32(e.CommandArgument);
                TextBox txtRM = (TextBox)(gvAttendance.Rows[i].FindControl("txtRemarks"));
                int attendanceID = Convert.ToInt32(gvAttendance.Rows[i].Cells[1].Text);
                Attendance objAttendance = new Attendance();

                int errorcode = objAttendance.updateRemarks(attendanceID, txtRM.Text);
                DropDownList ddlS = (DropDownList)(gvAttendance.Rows[i].FindControl("ddlStatus"));

                objAttendance.attendanceID = attendanceID;
                objAttendance.status = Convert.ToChar(ddlS.SelectedValue);
                errorcode = objAttendance.updateStatus();
                if (errorcode == 0)
                lblMessage.Text = "Status and Remarks is successfully updated";
            }
        }

        protected void ddlTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayViewClassTakenByTutor();
        }

        protected void ddlSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("Select * from TuitionClass tc INNER JOIN ClassStudent cs ON tc.TuitionClassID=cs.TuitionClassID INNER JOIN Attendance a ON a.ClassStudentID = cs.ClassStudentID WHERE TutorID = 1 AND ClassSessionDate=@startdate AND tc.TuitionClassID = 1", conn);
            cmd.Parameters.AddWithValue("@selectedstartDate", Convert.ToDateTime(ddlSD.SelectedValue));
            cmd.Parameters.AddWithValue("@TutorID", 1);
            cmd.Parameters.AddWithValue("@tuitionClassID", Request.QueryString["classStudentID"]);
            cmd.Parameters.AddWithValue("@startdate",ddlSD.SelectedValue);
            SqlDataAdapter daClass = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            conn.Open();
            daClass.Fill(ds, "AttendanceDetails");
            conn.Close();

        
        }
    }
}
