using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rent_HouseWeb
{
    public partial class adminhome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nama_admin"] == null) // if it will not find Session user it will redirect to login page.
            {
                Response.Redirect("login_admin.aspx");
            }
            else // if it will find Session it will write message on WelcomeLabel.
            {
                customer_name.Text = Session["nama_admin"].ToString() + "";
                customer_name2.Text = Session["nama_admin"].ToString() + "";

            }
        }

        protected void btn_logoutClick(object sender, EventArgs e)
        {
            Response.Redirect("logout_admin.aspx");
        }
    }
}