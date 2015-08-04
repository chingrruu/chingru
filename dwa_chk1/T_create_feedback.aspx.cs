using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_chk1
{
    public partial class T_create_feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // Create a new object from ClassStudent Class
                ClassStudent objClassStudent = new ClassStudent();

                objClassStudent.classStudentID = Convert.ToInt32(txtStudentID.Text);
                objClassStudent.tuitionClassID = Convert.ToInt32(txtTClassID.Text);
                objClassStudent.feedback = txtFeedback.Text;

                int errorcode = objClassStudent.createFeedback();

                if (errorcode == 0)
                {
                    lblMessage.Text = "Feedback must be entered before submission.";
                }
                else
                    lblMessage.Text = "Your feedback has been successfully submitted.";

            }
        }

        protected void txtFeed_TextChanged(object sender, EventArgs e)
        {

        }
    }
}