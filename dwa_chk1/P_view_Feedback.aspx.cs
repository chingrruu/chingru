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
    public partial class P_view_Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // populating ddlStudentID
              if(!Page.IsPostBack)
              {
                  populateddl();
                  if (ddlStudentID.Items.Count > 0)
                      viewFeedback();
              }
        }

        public void populateddl()
        {
            string strConn = ConfigurationManager.ConnectionStrings["NPTCConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("SELECT ClassStudentID, StudentName, TuitionClassID, Feedback FROM ClassStudent INNER JOIN Parent ON ClassStudent.ParentID = Parent.ParentID WHERE ClassStudent.ParentID=@parentID", conn);
            cmd.Parameters.AddWithValue("@parentID", 1); // Session["parentID"]

            SqlDataReader reader;

            conn.Open();
                 reader = cmd.ExecuteReader();
                 while (reader.Read())
                 {
                     ddlStudentID.Items.Add(reader["ClassStudentID"].ToString());
                 }
            conn.Close();
        }

        public void viewFeedback()
        {
            string strConn = ConfigurationManager.ConnectionStrings["NPTCConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("SELECT ClassStudentID, StudentName, TuitionClassID, Feedback FROM ClassStudent INNER JOIN Parent ON ClassStudent.ParentID = Parent.ParentID WHERE classStudentID=@ClassStudentID AND ClassStudent.ParentID=@parentID", conn); 
            
            cmd.Parameters.AddWithValue("@parentID", 1); // Session["parentID"]
            cmd.Parameters.AddWithValue("@ClassStudentID", ddlStudentID.SelectedValue);

            SqlDataAdapter daClassStudent = new SqlDataAdapter(cmd);

            DataSet result = new DataSet();

            conn.Open();
            daClassStudent.Fill(result, "FeedbackDetails");
            conn.Close();

            gvFeedback.DataSource = result.Tables["FeedbackDetails"];
            gvFeedback.DataBind();

            // Rows.Count returns the total number of records retrieved
            if (result.Tables["FeedbackDetails"].Rows.Count > 0)
            {
                lblMessage.Text = " There is a total number of:" + result.Tables["FeedbackDetails"].Rows.Count + " records.";
            }
            else
            {
                lblMessage.Text = "There are no records to display";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        protected void ddlStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewFeedback();
        }
  
    }
}