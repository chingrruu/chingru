using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_chk1
{
    public partial class AdminConfirmAddTutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblPassword.Text = "passTutor";
            lblTutorID.Text = Convert.ToString("01");

            // Extracting detail from querystring
            // lblTutorID.Text = Request.QueryString["tutorid"];
            lblSalutation.Text = Request.QueryString["salutation"];
            lblName.Text = Request.QueryString["name"];
            lblContactNumber.Text = Request.QueryString["contactnumber"];
            lblEmailAddress.Text = Request.QueryString["emailaddress"];
            // lblPassword.Text = Request.QueryString["password"];
            lblYearsOfExperience.Text = Request.QueryString["yearsofexperience"];
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            string strValues;

            // strValues = "tutorid" + lblTutorID.Text;
            strValues = "&salutation=" + lblSalutation.Text;
            strValues += "&name=" + lblName.Text;
            strValues += "&contactnumber=" + lblContactNumber.Text;
            strValues += "&emailaddress=" + lblEmailAddress.Text;
            // strValues += "&password" + lblPassword.Text;
            strValues += "&yearsofexperience=" + lblYearsOfExperience.Text;

            // Redirect querystring back to previous page
            Response.Redirect("AdminAddTutor.aspx?" + strValues);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Ensure that there is no validation errors
            if (Page.IsValid)
            {
                // Create a new object from the Tutor Class
                TutorClass objTutor = new TutorClass();

                // Pass details to Tutor objects with necessary conversion if needed
                // objTutor.tutorid = Convert.ToInt32(lblTutorID.Text);
                objTutor.salutation = lblSalutation.Text;
                objTutor.name = lblName.Text;
                objTutor.telno = Convert.ToInt32(lblContactNumber.Text);
                objTutor.email = lblEmailAddress.Text;
                // objTutor.password = lblPassword.Text;
                objTutor.experience = Convert.ToInt32(lblYearsOfExperience.Text);

                // Call method to add 
                int error = objTutor.add();

                // Added successfully if Tutor.cs returned 1
                if (error == 1)
                    lblText.Text = "Adding of new tutor is successful";
                else
                    lblText.Text = "Adding of new tutor is unsucessful";
            }
        }
    }
}