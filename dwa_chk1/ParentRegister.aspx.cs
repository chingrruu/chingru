using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_chk1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            // restrict the execution of code only once
            // when the page loads
            {
                ddlSalutation.Items.Add("Dr");
                ddlSalutation.Items.Add("Mr");
                ddlSalutation.Items.Add("Ms");
                ddlSalutation.Items.Add("Mdm");

                //show the values of the QueryString in textbox
                txtName.Text = Request.QueryString["name"];
                txtTelNo.Text = Request.QueryString["contactnumber"];
                txtEmailAddr.Text = Request.QueryString["emailaddress"];
                txtPassword.Text = Request.QueryString["password"];
                txtConfirmPassword.Text = Request.QueryString["confirmpassword"];
                txtAddress.Text = Request.QueryString["address"];

                if (String.IsNullOrEmpty(Request.QueryString["salutation"]))
                    //when the page load the request.querytring["nationality"]
                    // will be empty hence select the first item as the default
                    ddlSalutation.SelectedIndex = 0;
                else
                    ddlSalutation.SelectedValue = Request.QueryString["salutation"];
            }
        
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            // proceed if there are no validation errors
            {
                string strValues;
                strValues = "name=" + txtName.Text;
                // + concaterate 2 strings
                // Property .Text to get the value from the TextBox

                strValues += "&salutation=" + ddlSalutation.SelectedValue;
                strValues += "&telno=" + txtTelNo.Text;
                
                strValues += "&password=" + txtPassword.Text;
                strValues += "&confirmpassword=" + txtConfirmPassword.Text;
                

                // to pass special characters in QueryString
                // you need to encode them. the decoding will be done automatically

                strValues += "&address=" + Server.UrlEncode(txtAddress.Text);
                strValues += "&emailaddr=" + Server.UrlEncode(txtEmailAddr.Text);

                Response.Redirect("ConfirmRegistration.aspx?" + strValues);
            }
        
        }
    }
}