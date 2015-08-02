using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_chk1
{
    public partial class updatetutorinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                ddlFreeDay.Items.Add("Monday");
                ddlFreeDay.Items.Add("Tuesday");
                ddlFreeDay.Items.Add("Wednesday");
                ddlFreeDay.Items.Add("Thursday");
                ddlFreeDay.Items.Add("Friday");
                ddlFreeDay.Items.Add("Saturday");
                ddlFreeDay.Items.Add("Sunday");

                ddlTimeSlot.Items.Add("9am - 11am");
                ddlTimeSlot.Items.Add("11am - 1pm");
                ddlTimeSlot.Items.Add("1pm - 3pm");
                ddlTimeSlot.Items.Add("3pm - 5pm");
                ddlTimeSlot.Items.Add("5pm - 7pm");
                ddlTimeSlot.Items.Add("7pm - 9pm");

                TutorClass objTutor = new TutorClass();
                objTutor.tutorid = Convert.ToInt32(Request.QueryString["tutorid"]);
                int code = objTutor.getTutorDetails();

                if(code==0)
                {
                     lblTutorID.Text = Convert.ToString(objTutor.tutorid);
                     lblSalutation.Text = objTutor.salutation;
                     lblName.Text = objTutor.name;
                     txtTelNo.Text = objTutor.telno;
                     txtNewEmailAddr.Text = objTutor.email;
                     txtOldPass.Text = objTutor.password;
                     ddlTimeSlot.SelectedValue = objTutor.timeslot;
                     ddlFreeDay.SelectedValue = objTutor.freedayofweek;
                }
               
            }
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            
            TutorClass objTutor = new TutorClass();
            objTutor.tutorid = Convert.ToInt32(Request.QueryString["tutorid"]);
            objTutor.name = lblName.Text;
            objTutor.telno = txtTelNo.Text;
            objTutor.email = txtNewEmailAddr.Text;
            objTutor.freedayofweek = ddlFreeDay.SelectedValue;
            objTutor.timeslot = ddlTimeSlot.SelectedValue;
            if (txtOldPass.Text != "" && txtNewPass.Text == "")
                objTutor.password = txtOldPass.Text;
            else
                objTutor.password = txtNewPass.Text;

            int error = objTutor.update();
            if (error == 100)
            {
                lblMessage2.Text = "Tutor successfully updated.";
            }
        }

        protected void ddlFreeDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTimeSlot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}