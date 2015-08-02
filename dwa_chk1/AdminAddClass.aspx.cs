using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_chk1
{
    public partial class AdminAddClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNumberOfSessions.Text = Convert.ToString("16");
            lblClassID.Text = Convert.ToString("101");

            if (Page.IsPostBack == false)
            {
                // Prevent from having duplicates in the ddl
                ddlTerm.Items.Add("January");
                ddlTerm.Items.Add("March");
                ddlTerm.Items.Add("September");

                ddlDayOfWeek.Items.Add("Monday");
                ddlDayOfWeek.Items.Add("Tuesday");
                ddlDayOfWeek.Items.Add("Wednesday");
                ddlDayOfWeek.Items.Add("Thursday");
                ddlDayOfWeek.Items.Add("Friday");
                ddlDayOfWeek.Items.Add("Saturday");
                ddlDayOfWeek.Items.Add("Sunday");

                ddlTimeSlot.Items.Add("9am-11am");
                ddlTimeSlot.Items.Add("11am-1pm");
                ddlTimeSlot.Items.Add("1pm-3pm");
                ddlTimeSlot.Items.Add("3pm-5pm");
                ddlTimeSlot.Items.Add("5pm-7pm");
                ddlTimeSlot.Items.Add("7pm-9pm");

                ddlClassroom.Items.Add("Rm 03-01");
                ddlClassroom.Items.Add("Rm 03-02");
                ddlClassroom.Items.Add("Rm 03-03");
                ddlClassroom.Items.Add("Rm 03-04");
                ddlClassroom.Items.Add("Rm 03-05");
                ddlClassroom.Items.Add("Rm 03-06");
                ddlClassroom.Items.Add("Rm 03-07");
                ddlClassroom.Items.Add("Rm 03-08");
                ddlClassroom.Items.Add("Rm 03-09");

                // lblClassID.Text = Request.QueryString["classid"];
                txtSubject.Text = Request.QueryString["subject"];
                txtStartDate.Text = Request.QueryString["startdate"];
                // lblNumberOfSessions.Text = Request.QueryString["numberofsessions"];

                if (string.IsNullOrEmpty(Request.QueryString["term"]))
                    // It will be empty, thus, select the default
                    ddlTerm.SelectedIndex = 0;
                else
                    ddlTerm.SelectedValue = Request.QueryString["term"];


                if (string.IsNullOrEmpty(Request.QueryString["dayofweek"]))
                    ddlDayOfWeek.SelectedIndex = 0;
                else
                    ddlDayOfWeek.SelectedValue = Request.QueryString["dayofweek"];


                if (string.IsNullOrEmpty(Request.QueryString["timeslot"]))
                    ddlTimeSlot.SelectedIndex = 0;
                else
                    ddlTimeSlot.SelectedValue = Request.QueryString["timeslot"];


                if (string.IsNullOrEmpty(Request.QueryString["classroom"]))
                    ddlClassroom.SelectedIndex = 0;
                else
                    ddlClassroom.SelectedValue = Request.QueryString["classroom"];
            }
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            // Ensure that there is no validation errors
            if (Page.IsValid)
            {
                TuitionClass objClass = new TuitionClass();

                if (objClass.isStartDateExists(txtStartDate.Text) == true)
                {
                    if (objClass.isTimeSlotExists(ddlTimeSlot.SelectedValue) == true)
                    {
                        if (objClass.isClassroomExists(ddlClassroom.SelectedValue))
                        {
                            lblError.Text = "Error!";
                        }
                    }
                }

                else
                {
                    // Combine details together
                    string strValues;

                    // strValues = "classid=" + lblClassID.Text;

                    strValues = "&subject=" + txtSubject.Text;

                    strValues += "&startdate=" + Server.UrlEncode(txtStartDate.Text);

                    // strValues += "&numberofsession=" + lblNumberOfSessions.Text;

                    strValues += "&term=" + ddlTerm.SelectedValue;

                    strValues += "&dayofweek=" + ddlDayOfWeek.SelectedValue;

                    strValues += "&timeslot=" + ddlTimeSlot.SelectedValue;

                    strValues += "&classroom=" + ddlClassroom.SelectedValue;

                    // Redirect the querystring to another page
                    Response.Redirect("AdminConfirmAddClass.aspx?" + strValues);
                }
            }
        }

        protected void txtStartDate_TextChanged(object sender, EventArgs e)
        {
            try // Try the code for exception to occur
            {
                // Display the date entered in the textbox 

                calStartDate.SelectedDate = Convert.ToDateTime(txtStartDate.Text);
                calStartDate.VisibleDate = calStartDate.SelectedDate;
                lblStartDateMessage.Text = "";
            }

            catch (FormatException) // Catch the relevant exception 
            {
                lblStartDateMessage.ForeColor = System.Drawing.Color.Red;
                lblStartDateMessage.Text = "Please enter a valid date";
            }

            finally
            {

            }
        }

        //protected void cuvClassroom_ServerValidate1(object source, ServerValidateEventArgs args)
        //{
        //if (Page.IsValid)
        //{
        //TuitionClass objClass = new TuitionClass();

        //if (objClass.isStartDateExists(txtStartDate.Text) == true)
        //{
        //args.IsValid = false;
        //}

        //else
        //args.IsValid = true;
        //}
        //} //objClass.isTimeSlotExists(ddlTimeSlot.SelectedValue) && objClass.isClassroomExists(ddlClassroom.SelectedValue) 
    }
}