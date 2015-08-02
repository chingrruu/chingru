using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace dwa_chk1
{
    public partial class P_create_discussionTopic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // populate the dropdownlist ddlTutor and ddlClass

            if (!Page.IsPostBack)
            {
                // populate the dropdownlist ddlTutor from the method

                TTutor objTTutor = new TTutor();

                DataSet ds = new DataSet();

                int errorcode = objTTutor.getTutorDetails(ref ds);

                if (errorcode == 0)
                {
                    ddlTName.DataSource = ds.Tables["getTutorDetails"];
                    ddlTName.DataTextField = "TName";
                    ddlTName.DataBind();

                    txtStudentID.Text = Request.QueryString["StudentID"];
                    txtTitle.Text = Request.QueryString["Title"];
                    txtText.Text = Request.QueryString["Text"];

                    // ddlTName.SelectedValue = Request.QueryString["TName"];
                    // ddlTClass.SelectedValue = Request.QueryString["tuitionClassID"];
                }

                TuitionClass objTuitionClass = new TuitionClass();

                DataSet result = new DataSet();

                int code = objTuitionClass.getTuitionClassDetails(ref result);

                if (code == 0)
                {
                    ddlTClass.DataSource = ds.Tables["getTuitionClassDetails"];
                    ddlTClass.DataTextField = "tuitionClassID";
                    ddlTClass.DataBind();
              
                    ddlTName.SelectedValue = Convert.ToString(objTTutor.TName);
                    ddlTClass.SelectedValue = Convert.ToString(objTuitionClass.tuitionClassID);
                }

                DiscussionTopic objDiscussionTopic = new DiscussionTopic();

                DataSet ds1 = new DataSet();

                int errorcode2 = objDiscussionTopic.getDiscussionTopicDetails(ref ds1);

                if (errorcode2 == 0)
                {
                    txtTitle.Text = Request.QueryString["Title"];
                    txtText.Text = Request.QueryString["Text"];
                }

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // Create a new object from ClassStudent Class
                ClassStudent objClassStudent = new ClassStudent();

                objClassStudent.classStudentID = Convert.ToInt32(txtStudentID.Text);
                objClassStudent.tuitionClassID = Convert.ToInt32(ddlTClass.SelectedValue);

                // DiscussionTopic Class
                DiscussionTopic objDiscussionTopic = new DiscussionTopic();

                DataSet ds = new DataSet();

                int errorcode2 = objDiscussionTopic.createDiscussion(ref ds);

                if (errorcode2 == 0)
                {
                    lblMessage.Text = "Discussion Topic has been successfully submitted.";
                }
                else
                    lblMessage.Text = "All entries and selections must be entered before submission.";

            }
        }
    }
}