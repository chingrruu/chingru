using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace dwa_chk1
{
    public partial class ConfirmClassRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblClassid.Text = Request.QueryString["TuitionClassID"];
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("SELECT * From TuitionClass where TuitionClassID = @TuitionClass", conn);
            cmd.Parameters.AddWithValue("@TuitionClass", lblClassid.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            conn.Open();
            da.Fill(ds, "TuitionClass");
            conn.Close();

            lblSubject.Text = Convert.ToString(ds.Tables["TuitionClass"].Rows[0]["Subject"]);
            lblTerm.Text = Convert.ToString(ds.Tables["TuitionClass"].Rows[0]["Term"]);
            lblStartdate.Text = Convert.ToString(ds.Tables["TuitionClass"].Rows[0]["StartDate"]);
            lblDayofweek.Text = Convert.ToString(ds.Tables["TuitionClass"].Rows[0]["DayOfWeek"]);
            lblTimeslot.Text = Convert.ToString(ds.Tables["TuitionClass"].Rows[0]["TimeSlot"]);
            lblSession.Text = Convert.ToString(ds.Tables["TuitionClass"].Rows[0]["NumSession"]);
            lblClassroom.Text = Convert.ToString(ds.Tables["TuitionClass"].Rows[0]["Classroom"]);
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {

            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("Insert into ClassStudent(StudentName, ParentID, TuitionClassID) values (@studentname, @parentid, @tuitionclassid)", conn);
           
            cmd.Parameters.AddWithValue("@tuitionclassid", lblClassid.Text);
            cmd.Parameters.AddWithValue("@parentid", Convert.ToInt32(Session["ParentID"]));
            cmd.Parameters.AddWithValue("@studentname", txtSname.Text);

            lblMessage.Text = "Successfully Register Class";
            lblMessage3.Text = "Please wait while we redirect you to view your registered class details";

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.AddHeader("REFRESH", "5;URL=ViewRegisteredClass.aspx?");
                  
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            string strValues;

            strValues = "&classid=" + lblClassid.Text;
            strValues += "&subject=" + lblSubject.Text;
            strValues = "term=" + lblTerm.Text;
            strValues += "&startdate=" + lblStartdate.Text;
            strValues += "&dayofweek=" + lblDayofweek.Text;
            strValues += "&timeslot=" + lblTimeslot.Text;
            strValues += "&session=" + lblSession.Text;


            Response.Redirect("ViewAvailableClass2.aspx?" + strValues);
        }
    }
}