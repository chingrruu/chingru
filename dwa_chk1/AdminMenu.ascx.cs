using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_chk1
{
    public partial class AdminMenu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void menuHome_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (e.Item.Value == "- Logout")
            {
                // Redirect to login page if user click - logout from the menu
                Session.Abandon();
                Response.Redirect("Index.html");
            }
        }
    }
}