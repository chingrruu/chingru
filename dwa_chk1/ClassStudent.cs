using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace dwa_chk1
{
    public class ClassStudent
    {
        public int classStudentID { get; set; }
        public string SName { get; set; }
        public int parentID { get; set; }
        public int tuitionClassID { get; set; }
        public string feedback { get; set; }
        public DateTime dateCreated { get; set; }

        public int createFeedback()
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("UPDATE ClassStudent SET Feedback=@feedback WHERE ClassStudentID=@classStudentID AND ParentID=@parentID", conn);
          
            cmd.Parameters.AddWithValue("@classStudentID", classStudentID);
            cmd.Parameters.AddWithValue("@feedback", feedback);
            cmd.Parameters.AddWithValue("@parentID", parentID); // remove if session not available

            // open the connection to database
            conn.Open();

            // to execute (Insert,Update,Delete SQL statement) use this method
            // Insert, Update and Delete SQL statement do not return any records but affect the records
            int count = cmd.ExecuteNonQuery();

            //Connection should be closed after operations.    
            conn.Close();
            if (count != 0) //At least one row of record updated,        
                return 0;   //return 0 as no error occurs. 
            else
                return -2;
        }

        public int addStudent()
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("INSERT INTO CLASSSTUDENT(classStudentID,SName,parentID,tuitionClassID,feedback,dateCreated) VALUES(@classStudent,@SName,@parentID,@tuitionClassID,@feedback,@dateCraeted)", conn);
            // the values for the query are determined during runtime hence we only give parameters here

            cmd.Parameters.AddWithValue("@classStudentID", classStudentID);
            cmd.Parameters.AddWithValue("@SName", SName);
            cmd.Parameters.AddWithValue("@parentID", parentID);
            cmd.Parameters.AddWithValue("@tuitionClassID", tuitionClassID);
            cmd.Parameters.AddWithValue("@feedback", feedback);
            cmd.Parameters.AddWithValue("@dateCreated", dateCreated);

            // open the connection to database
               conn.Open();

            // to execute (Insert,Update,Delete SQL statement) use this method
            // Insert, Update and Delete SQL statement do not return any records but affect the records

               cmd.ExecuteNonQuery();

            // close the connection
            conn.Close();

            // return any integer value
            return 100;
        }

        public int getFeedbackDetails(ref DataSet result)
        {
            string strConn = ConfigurationManager.ConnectionStrings["NPTCConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("SELECT ClassStudentID, StudentName, TuitionClassID, Feedback FROM ClassStudent INNER JOIN Parent ON ClassStudent.ParentID = Parent.ParentID WHERE classStudentID=@ClassStudentID AND ClassStudent.ParentID=@parentID", conn);

            cmd.Parameters.AddWithValue("@parentID", 1); // Session["parentID"]
            cmd.Parameters.AddWithValue("@ClassStudentID", classStudentID);

            SqlDataAdapter daClassStudent = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            conn.Open();
            daClassStudent.Fill(result, "FeedbackDetails");
               conn.Close();

            if (ds.Tables["FeedbackDetails"].Rows.Count > 0)
            {
                if (!DBNull.Value.Equals(ds.Tables["FeedbackDetails"].Rows[0]["classStudentID"].ToString()))
                    classStudentID = Convert.ToInt32(ds.Tables["FeedbackDetails"].Rows[0]["classStudentID"]);

                if (!DBNull.Value.Equals(ds.Tables["FeedbackDetails"].Rows[0]["SName"].ToString()))
                    SName = Convert.ToString(ds.Tables["FeedbackDetails"].Rows[0]["SName"]);
       
                if (!DBNull.Value.Equals(ds.Tables["FeedbackDetails"].Rows[0]["parentID"].ToString()))
                    parentID = Convert.ToInt32(ds.Tables["FeedbackDetails"].Rows[0]["parentID"]);

                if (!DBNull.Value.Equals(ds.Tables["FeedbackDetails"].Rows[0]["tuitionClassID"].ToString()))
                    tuitionClassID = Convert.ToInt32(ds.Tables["FeedbackDetails"].Rows[0]["tuitionClassID"]);

                if (!DBNull.Value.Equals(ds.Tables["FeedbackDetails"].Rows[0]["feedback"].ToString()))
                    feedback = Convert.ToString(ds.Tables["FeedbackDetails"].Rows[0]["feedback"]);

                if (!DBNull.Value.Equals(ds.Tables["FeedbackDetails"].Rows[0]["dateCreated"].ToString()))
                    dateCreated = Convert.ToDateTime(ds.Tables["FeedbackDetails"].Rows[0]["dateCreated"]);

        }
    
            return 0;
        }

        public int getClassStudentDetails(ref DataSet result)
        {
            string strConn = ConfigurationManager.ConnectionStrings["NPTCConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("SELECT * from ClassStudent WHERE ClassStudentID=@classStudentID", conn);

            cmd.Parameters.AddWithValue("@classStudentID", classStudentID); // Session["parentID"]

            SqlDataAdapter daClassStudent = new SqlDataAdapter(cmd);
            
            DataSet ds = new DataSet();

            conn.Open();
            daClassStudent.Fill(ds, "getClassStudentDetails");
            conn.Close();
        
            if (ds.Tables["getClassStudentDetails"].Rows.Count > 0)
            {
                if (!DBNull.Value.Equals(ds.Tables["getClassStudentDetails"].Rows[0]["classStudentID"].ToString()))
                    classStudentID = Convert.ToInt32(ds.Tables["getClassStudentDetails"].Rows[0]["classStudentID"]);
        
                if (!DBNull.Value.Equals(ds.Tables["getClassStudentDetails"].Rows[0]["SName"].ToString()))
                    SName = Convert.ToString(ds.Tables["getClassStudentDetails"].Rows[0]["SName"]);

                if (!DBNull.Value.Equals(ds.Tables["getClassStudentDetails"].Rows[0]["parentID"].ToString()))
                    parentID = Convert.ToInt32(ds.Tables["getClassStudentDetails"].Rows[0]["parentID"]);

                if (!DBNull.Value.Equals(ds.Tables["getClassStudentDetails"].Rows[0]["tuitionClassID"].ToString()))
                    tuitionClassID = Convert.ToInt32(ds.Tables["getClassStudentDetails"].Rows[0]["tuitionClassID"]);

            return 0;
            
                if (!DBNull.Value.Equals(ds.Tables["getClassStudentDetails"].Rows[0]["dateCreated"].ToString()))
                    dateCreated = Convert.ToDateTime(ds.Tables["getClassStudentDetails"].Rows[0]["dateCreated"]);

        }
}
       
    
}
}

