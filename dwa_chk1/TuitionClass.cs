using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace dwa_chk1
{
    public class TuitionClass
    {
        public int tuitionClassID { get; set; }
        public string subject { get; set; }
        public string term { get; set; }
        public DateTime startdate { get; set;}
        public string dayofweek { get; set; }
        public string timeslot { get; set; }
        public int numsession { get; set; }
        public string classroom {get;set;}
        public int tutorid { get; set; }

        public int add()
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("INSERT INTO TUITIONCLASS([Subject], Term, StartDate, [DayOfWeek], TimeSlot, Classroom) Values(@subject,@term,@startdate,@dayofweek,@timeslot,@classroom)", conn);

            cmd.Parameters.AddWithValue("@term", term);
            cmd.Parameters.AddWithValue("@startdate", startdate);
            cmd.Parameters.AddWithValue("@dayofweek", dayofweek);
            cmd.Parameters.AddWithValue("@timeslot", timeslot);
            cmd.Parameters.AddWithValue("@classroom", classroom);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            // Return 2 when no error occurs
            return 2;
        }
        public void getTuitionDetails(ref DataSet ds)
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM TuitionClass WHERE TuitionClassID=@tuitionClassID", conn);
            cmd.Parameters.AddWithValue("@tuitionClassID", tuitionClassID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            conn.Open();
            da.Fill(ds, "tuitionclassdetails");
            conn.Close();
        }
        public int update()
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("Update TuitionClass SET TutorID=1 WHERE TuitionClassID=@TuitionClassID", conn);
            cmd.Parameters.AddWithValue("@tutorid", 1);
            cmd.Parameters.AddWithValue("@TuitionClassID", tuitionClassID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return 100;
        }
        public int delete()
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("DELETE FROM TuitionClass tc INNER JOIN ClassStudent cs ON tc.TuitionClassID = cs.TuitionClassID WHERE cs.ClassStudentID IS NULL AND tc.TuitionClassID=@selectedtuitionClassID", conn);
            cmd.Parameters.AddWithValue("@selectedtuitionClassID", tuitionClassID);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch (SqlException)
            {
                return 0;
            }

        }

        public bool isStartDateExists(string startDate)
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("SELECT * FROM TUITIONCLASS WHERE StartDate=@startdate", conn);

            cmd.Parameters.AddWithValue("@startdate", startdate);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            conn.Open();
            da.Fill(ds, "classdetails");
            conn.Close();

            if (ds.Tables["classdetails"].Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool isTimeSlotExists(string timeSlot)
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("SELECT * FROM TUITIONCLASS WHERE TimeSlot=@timeslot", conn);

            cmd.Parameters.AddWithValue("@timeslot", timeslot);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            conn.Open();
            da.Fill(ds, "classdetailss");
            conn.Close();

            if (ds.Tables["classdetailss"].Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool isClassroomExists(string classroom)
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("SELECT * FROM TUITIONCLASS WHERE Classroom=@classroom", conn);

            cmd.Parameters.AddWithValue("@classroom", classroom);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            conn.Open();
            da.Fill(ds, "classdetailsss");
            conn.Close();

            if (ds.Tables["classdetailsss"].Rows.Count > 0)
                return true;
            else
                return false;
        }

        internal int getTuitionDetails()
        {
            throw new NotImplementedException();
        }
    }
}