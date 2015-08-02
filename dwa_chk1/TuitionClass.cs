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
            SqlCommand cmd = new SqlCommand("INSERT INTO TuitionClass(TuitionClassID,Suject,Term,StartDate,DayOfWeek,TimeSlot,FreeDayOfWeek,NumSession,Classroom,TutorID) VALUES(@tuitionClassID,@suject,t@erm,@startdate,@dayofweek,@timeslot,@numsession,@classroom,@tutorID)", conn);

            cmd.Parameters.AddWithValue("@tuitionClassID", tuitionClassID);
            cmd.Parameters.AddWithValue("@subject", subject);
            cmd.Parameters.AddWithValue("@term", term);
            cmd.Parameters.AddWithValue("@startdate", startdate);
            cmd.Parameters.AddWithValue("@dayofweek", dayofweek);
            cmd.Parameters.AddWithValue("@timeslot", timeslot);
            cmd.Parameters.AddWithValue("@numsession", numsession);
            cmd.Parameters.AddWithValue("@classroom", classroom);
            cmd.Parameters.AddWithValue("@tutorid", tutorid);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return 100;

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
            SqlCommand cmd = new SqlCommand("Update TuitionClass SET TutorID=null WHERE TuitionClassID=@TuitionClassID", conn);
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
        
    }
}