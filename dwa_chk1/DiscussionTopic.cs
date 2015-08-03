using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace dwa_chk1
{
    public class DiscussionTopic
    {
        public int discussionTopicID { get; set; }
        public int parentID { get; set; }
        public int classStudentID { get; set; }
        public DateTime DateTimePosted { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public int createDiscussion(ref DataSet ds)
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("UPDATE DiscussionTopic SET Title=@title, Text=@text WHERE ClassStudentID=@classStudentID", conn);

            cmd.Parameters.AddWithValue("@classStudentID", classStudentID);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@tText", Text);

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


        public int addDiscussionTopic()
        {
            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"]);

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("INSERT INTO DiscussionTopic(discussionTopicID,parentID,classStudentID,DateTimePosted,Title,Text) VALUES(@discussionTopicID,@parentID,@classStudentID,@DateTimePosted,@Title,@Text)", conn);
            // the values for the query are determined during runtime hence we onl give parameters here

            cmd.Parameters.AddWithValue("@discussionTopicID", discussionTopicID);
            cmd.Parameters.AddWithValue("@parentID", parentID);
            cmd.Parameters.AddWithValue("@ClassStudentID", classStudentID);
            cmd.Parameters.AddWithValue("@DateTimePosted", DateTimePosted);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@Text", Text);

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

        public int getDiscussionTopicDetails(ref DataSet ds)
        {
            string strConn = ConfigurationManager.ConnectionStrings["NPTCConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("SELECT * from DiscussionTopic WHERE parentID=@ParentID AND classStudentID=@ClassStudentID", conn);

            cmd.Parameters.AddWithValue("@ParentID", parentID); // Session["parentID"]
            cmd.Parameters.AddWithValue("@ClassStudentID", classStudentID);

            SqlDataAdapter daDiscussionTopic = new SqlDataAdapter(cmd);

            DataSet result = new DataSet();

            conn.Open();
            daDiscussionTopic.Fill(ds, "getDiscussionTopicDetails");
            conn.Close();

            if (ds.Tables["getDiscussionTopicDetails"].Rows.Count > 0)
            {
                if (!DBNull.Value.Equals(ds.Tables["getDiscussionTopicDetails"].Rows[0]["discussionTopicID"].ToString()))
                    discussionTopicID = Convert.ToInt32(ds.Tables["getDiscussionTopicDetails"].Rows[0]["tdiscussionTopicID"]);

                if (!DBNull.Value.Equals(ds.Tables["getDiscussionTopicDetails"].Rows[0]["parentID"].ToString()))
                    parentID = Convert.ToInt32(ds.Tables["getDiscussionTopicDetails"].Rows[0]["parentID"]);

                if (!DBNull.Value.Equals(ds.Tables["getDiscussionTopicDetails"].Rows[0]["classStudentID"].ToString()))
                    classStudentID = Convert.ToInt32(ds.Tables["getDiscussionTopicDetails"].Rows[0]["classStudentID"]);

                if (!DBNull.Value.Equals(ds.Tables["getDiscussionTopicDetails"].Rows[0]["DateTimePosted"].ToString()))
                    DateTimePosted = Convert.ToDateTime(ds.Tables["getDiscussionTopicDetails"].Rows[0]["DateTimePosted"]);

                if (!DBNull.Value.Equals(ds.Tables["getDiscussionTopicDetails"].Rows[0]["Title"].ToString()))
                    Title = Convert.ToString(ds.Tables["getDiscussionTopicDetails"].Rows[0]["Title"]);

                if (!DBNull.Value.Equals(ds.Tables["getDiscussionTopicDetails"].Rows[0]["Text"].ToString()))
                    Text = Convert.ToString(ds.Tables["getDiscussionTopicDetails"].Rows[0]["Text"]);

            }

            return 0;
        }

    }
}