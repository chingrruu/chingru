using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace dwa_chk1
{
    public class TutorClass
    {
        public int tutorid { get; set; }
        public string name { get; set; }
        public string salutation { get; set; }
        public string telno { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string freedayofweek { get; set; }
        public string timeslot { get; set; }
        public int experience { get; set;}

        public int add()
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("INSERT INTO Tutor(TutorID,TName,TSalutation,TTelNo,TEmailAddr,TPassword,FreeDayOfWeek,FreeTimeSlot,TExperience) VALUES(@tutorid,@name,@gender,@salutation,@telno,@email,@freedayofweek,@timeslot,@exprience)", conn);
           
            cmd.Parameters.AddWithValue("@tutorid", tutorid);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@salutation", salutation);
            cmd.Parameters.AddWithValue("@telno", telno);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password); 
            cmd.Parameters.AddWithValue("@freedayofweek", freedayofweek);
            cmd.Parameters.AddWithValue("@timeslot", timeslot);
            cmd.Parameters.AddWithValue("@experience", experience);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return 100;

        }

        public int update()
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("Update Tutor SET TTelNo=@telno,TEmailAddr=@email,TPassword=@password,FreeDayOfWeek=@freedayofweek,FreeTimeSlot=@timeslot WHERE TutorID=@tutorid", conn);

            cmd.Parameters.AddWithValue("@tutorid", tutorid);
            cmd.Parameters.AddWithValue("@telno", telno);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password); 
            cmd.Parameters.AddWithValue("@freedayofweek", freedayofweek);
            cmd.Parameters.AddWithValue("@timeslot", timeslot);
            

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
       
            return 100;
        }
        public int delete()
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("DELETE FROM TuitionClass WHERE TutorID=@tutorid", conn);
            cmd.Parameters.AddWithValue("@tutorid", tutorid);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return 100;

        }
        public int getTutorDetails()
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tutor WHERE TutorID=@tutorid", conn);
            cmd.Parameters.AddWithValue("@tutorid", tutorid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            conn.Open();
            da.Fill(ds, "tuitionClasstutordetails");
            conn.Close();

            if (ds.Tables["tutordetails"].Rows.Count > 0)
            {
                if (!DBNull.Value.Equals(ds.Tables["tutordetails"].Rows[0]["TName"].ToString()))
                    name = Convert.ToString(ds.Tables["tutordetails"].Rows[0]["TName"]);
                if (!DBNull.Value.Equals(ds.Tables["tutordetails"].Rows[0]["TSalutation"].ToString()))
                    salutation = Convert.ToString(ds.Tables["tutordetails"].Rows[0]["TSalutation"]);
                if (!DBNull.Value.Equals(ds.Tables["tutordetails"].Rows[0]["TTelno"].ToString()))
                    telno = Convert.ToString(ds.Tables["tutordetails"].Rows[0]["TTelno"]);
                if (!DBNull.Value.Equals(ds.Tables["tutordetails"].Rows[0]["TEmailAddr"].ToString()))
                   email = Convert.ToString(ds.Tables["tutordetails"].Rows[0]["TEmailAddr"]);
                if (!DBNull.Value.Equals(ds.Tables["tutordetails"].Rows[0]["TPassword"].ToString()))
                    password = Convert.ToString(ds.Tables["tutordetails"].Rows[0]["TPassword"]);
                if (!DBNull.Value.Equals(ds.Tables["tutordetails"].Rows[0]["FreeDayOfWeek"].ToString()))
                    freedayofweek = Convert.ToString(ds.Tables["tutordetails"].Rows[0]["FreeDayOfWeek"]);
                if (!DBNull.Value.Equals(ds.Tables["tutordetails"].Rows[0]["FreeTimeSlot"].ToString()))
                    timeslot = Convert.ToString(ds.Tables["tutordetails"].Rows[0]["FreeTimeSlot"]);
                if (!DBNull.Value.Equals(ds.Tables["tutordetails"].Rows[0]["TExperience"].ToString()))
                    experience= Convert.ToInt32(ds.Tables["tutordetails"].Rows[0]["TExperience"]);
                
            }
            return 0;
        }
       
    }
}