using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_chk1
{
    public partial class AdminAddTutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblPassword.Text = "passTutor";
            lblTutorID.Text = Convert.ToString("01");

            if (Page.IsPostBack == false)
            {
                // Prevent from having duplicates in the ddl
                ddlSalutation.Items.Add("Dr");
                ddlSalutation.Items.Add("Mr");
                ddlSalutation.Items.Add("Ms");
                ddlSalutation.Items.Add("Mdm");

                // Show the details of the querystring
                // lblTutorID.Text = Request.QueryString["tutorid"];
                txtName.Text = Request.QueryString["name"];
                txtContactNumber.Text = Request.QueryString["contactnumber"];
                txtEmailAddress.Text = Request.QueryString["emailaddress"];
                // lblPassword.Text = Request.QueryString["password"];
                txtYearsOfExperience.Text = Request.QueryString["yearsofexperience"];

                if (string.IsNullOrEmpty(Request.QueryString["salutation"]))
                    // It will be empty, thus, select the default
                    ddlSalutation.SelectedIndex = 0;
                else
                    ddlSalutation.SelectedValue = Request.QueryString["salutation"];
            }
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            // Ensure that there is no validation errors
            if (Page.IsValid)
            {
                // Combine details together
                string strValues;

                // strValues = "tutorid" + lblTutorID.Text;

                strValues = "name=" + txtName.Text;

                // Encode is needed to pass special characters
                strValues += "&contactnumber=" + txtContactNumber.Text;

                // Encode is needed to pass special characters
                strValues += "&emailaddress=" + Server.UrlEncode(txtEmailAddress.Text);

                // strValues += "&password=" + lblPassword.Text;

                strValues += "&yearsofexperience=" + txtYearsOfExperience.Text;

                strValues += "&salutation=" + ddlSalutation.SelectedValue;

                // Redirect the querystring to another page
                Response.Redirect("AdminConfirmAddTutor.aspx?" + strValues);
            }
        }
    }
}