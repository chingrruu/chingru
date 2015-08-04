using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_chk1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // display the querystring on the label
            //method Request.QueryString gets the valuue for the key specified
            lblSalutation.Text = Request.QueryString["salutation"];
            lblName.Text = Request.QueryString["name"];
            lblTelNo.Text = Request.QueryString["telno"];
            lblEmailAddr.Text = Request.QueryString["emailaddr"];
            lblPassword.Text = Request.QueryString["password"];
            lblConfirmPassword.Text = Request.QueryString["confirmpassword"];
            lblAddress.Text = Request.QueryString["address"];
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            string strValues;

            strValues = "&salutation=" + lblSalutation.Text;
            strValues += "&telno=" + lblTelNo.Text;
            strValues = "name=" + lblName.Text;
            strValues += "&emailaddr=" + lblEmailAddr.Text;
            strValues += "&password=" + lblPassword.Text;
            strValues += "&confirmpassword=" + lblConfirmPassword.Text;
            strValues += "&address=" + lblAddress.Text;

            Response.Redirect("ParentRegister.aspx?");
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            parent objParent = new parent();

            // give the values for the properties
            // Setting the values for the properties

            objParent.name = lblName.Text;
            objParent.salutation = lblSalutation.Text;
            objParent.emailaddr = lblEmailAddr.Text;
            objParent.telno = lblTelNo.Text;
            objParent.password = lblPassword.Text;
            objParent.address = lblAddress.Text;

            int errorcode = objParent.add();
            if (errorcode == 100)

                lblMessage.Text = "New Parent is successfully added";
                lblMessage2.Text = "Please wait to be redirect...";
            

            Response.AddHeader("REFRESH", "5;URL=Index.html");
           
        }
    }
}