using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_chk1
{
    public partial class AdminConfirmAddClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNumberOfSessions.Text = Convert.ToString("16");
            lblClassID.Text = Convert.ToString("101");

            // Extracting detail from querystring
            // lblClassID.Text = Request.QueryString["classid"];
            lblSubject.Text = Request.QueryString["subject"];
            lblTerm.Text = Request.QueryString["term"];
            lblStartDate.Text = Request.QueryString["startdate"];
            lblDayOfWeek.Text = Request.QueryString["dayofweek"];
            lblTimeSlot.Text = Request.QueryString["timeslot"];
            // lblNumberOfSessions.Text = Request.QueryString["numberofsession"];
            lblClassroom.Text = Request.QueryString["classroom"];
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            string strValues;

            // strValues = "classid" + lblClassID.Text;
            strValues = "&subject=" + lblSubject.Text;
            strValues += "&term=" + lblTerm.Text;
            strValues += "&startdate=" + lblStartDate.Text;
            strValues += "&dayofweek=" + lblDayOfWeek.Text;
            strValues += "&timeslot=" + lblTimeSlot.Text;
            // strValues += "&numberofsession" + lblNumberOfSessions.Text;
            strValues += "&classroom=" + lblClassroom.Text;

            // Redirect querystring back to previous page
            Response.Redirect("AdminAddClass.aspx?" + strValues);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Ensure that there is no validation errors
            if (Page.IsValid)
            {
                // Create a new object from the TuitionClass Class
                TuitionClass objClass = new TuitionClass();

                // Pass details to Tutor objects with necessary conversion if needed
                // objClass.classid = Convert.ToInt32(lblClassID.Text);
                objClass.subject = lblSubject.Text;
                objClass.term = lblTerm.Text;
                objClass.startdate = Convert.ToDateTime(lblStartDate.Text);
                objClass.dayofweek = lblDayOfWeek.Text;
                objClass.timeslot = lblTimeSlot.Text;
                // objClass.numberofsessions = Convert.ToInt32(lblNumberOfSessions.Text);
                objClass.classroom = lblClassroom.Text;

                // Call method to add 
                int error = objClass.add();

                // Added successfully if Tutor.cs returned 1
                if (error == 2)
                    lblText.Text = "Adding of new class is successful";
                else
                    lblText.Text = "Adding of new class is unsucessful";
            }
        }
    }
}