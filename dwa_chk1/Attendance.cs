using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace dwa_chk1
{
    public class Attendance
    {
        public int attendanceID { get; set; }
        public int classStudentID { get; set; }
        public string classSessionDate { get; set; }
        public char status { get; set; }
        public string remarks { get; set; }
        public string dateCreated { get; set; }

        public int updateRemarks(int attendanceID, string rm)
        {
            string strConn = ConfigurationManager.ConnectionStrings["NPTCConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("UPDATE Attendance SET Remarks=@rm where AttendanceID=@Aid", conn);

            cmd.Parameters.AddWithValue("@rm", rm);
            cmd.Parameters.AddWithValue("@Aid", attendanceID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return 0;
        }

        public int updateStatus()
        {
            string strConn = ConfigurationManager.ConnectionStrings["NPTCConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("UPDATE Attendance SET Status=@s WHERE AttendanceID=@Aid", conn);

            cmd.Parameters.AddWithValue("@s", status);
            cmd.Parameters.AddWithValue("@Aid", attendanceID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return 0;
        }

        public int getAttendanceDetails()
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Attendance WHERE ClassStudentID=@selectedClassStudentID", conn);
            cmd.Parameters.AddWithValue("@selectedClassStudentID", classStudentID);
            cmd.Parameters.AddWithValue("@TutorID", 1);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            conn.Open();
            da.Fill(ds, "attendancedetails");
            conn.Close();

            if (ds.Tables["attendancedetails"].Rows.Count > 0)
            {
                if (!DBNull.Value.Equals(ds.Tables["attendancedetails"].Rows[0]["ClassSessionDate"].ToString()))
                    classSessionDate = Convert.ToString(ds.Tables["attendancedetails"].Rows[0]["ClassSessionDate"]);
                if (!DBNull.Value.Equals(ds.Tables["attendancedetails"].Rows[0]["Status"].ToString()))
                    status = Convert.ToChar(ds.Tables["attendancedetails"].Rows[0]["Status"]);
                if (!DBNull.Value.Equals(ds.Tables["attendancedetails"].Rows[0]["Remarks"].ToString()))
                    remarks = Convert.ToString(ds.Tables["attendancedetails"].Rows[0]["Remarks"]);
                if (!DBNull.Value.Equals(ds.Tables["attendancedetails"].Rows[0]["DateCreated"].ToString()))
                    dateCreated = Convert.ToString(ds.Tables["attendancedetails"].Rows[0]["DateCreated"]);

            }
            return 0;
        }
    }  
}