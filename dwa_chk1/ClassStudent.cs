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
        public int ClassStudentid { get; set; }
        public string StudentName { get; set; }
        public int Parentid { get; set; }
        public int TuitionClassid { get; set; }
        public string Feedback { get; set; }
        public DateTime DateCreated { get; set; }


        public int add()
        {

            string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTC"].ToString());

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("INSERT INTO CLASSSTUDENT (StudentName, Parentid, TuitionClassid) VALUES(@studentname, @parentid, @tuitionclassid)", conn);



            cmd.Parameters.AddWithValue("@studentname", StudentName);
            cmd.Parameters.AddWithValue("@parentid", Parentid);
            cmd.Parameters.AddWithValue("@tuitionclassid", TuitionClassid);



            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();


            return 100;

        }


        //ublic int validate()
        //


        //string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTC"].ToString());

        //  SqlConnection conn = new SqlConnection(strConn);

        //  SqlCommand cmd = new SqlCommand("SELECT count(*) From TuitionClass where TuitionClassID = @TuitionClass", conn);

        //SqlDataReader reader = cmd.ExecuteReader();
        //DataTable dt = new DataTable();
        //dt.Load(reader);
        //int numRows = dt.Rows.Count;

        //int rowCount = (int)cmd.ExecuteScalar();
        //if (rowCount >= 20)
        // {
        //   return 0;
        // }



    }
}
       


