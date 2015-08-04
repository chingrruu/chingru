using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace dwa_chk1
{
    public class parent
    {
        public int parentid { get; set; }
        public string salutation { get; set; }
        public string name { get; set; }
        public string telno { get; set; }
        public string emailaddr { get; set; }
        public string password { get; set; }
        public string address { get; set; }
    

    public int add()
    {

        string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"].ToString());

        SqlConnection conn = new SqlConnection(strConn);

        SqlCommand cmd = new SqlCommand("INSERT INTO PARENT (PName, PSalutation, PTelNo, PEmailAddr, PPassword, PAddress) VALUES(@name, @salutation, @telno, @emailaddr, @password, @address)", conn);

            
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@salutation", salutation);
            cmd.Parameters.AddWithValue("@telno", telno);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@emailaddr", emailaddr);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

            return 100;
            
    
    }

    public bool isEmailExists(string PEmailAddr)
    {
        string strConn = Convert.ToString(ConfigurationManager.ConnectionStrings["NPTCConnectionString"].ToString());

        SqlConnection conn = new SqlConnection(strConn);

        SqlCommand cmd = new SqlCommand("Select * from parent where PEmailAddr = @PEmailAddr", conn);


        cmd.Parameters.AddWithValue("@PEmailAddr", PEmailAddr);

        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataSet ds = new DataSet();

        conn.Open();
        da.Fill(ds, "parent");
        conn.Close();

        if (ds.Tables["parent"].Rows.Count > 0)
            return true; // email exists
        else
            return false;
    }
}
}