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
            if (Session["User"] == null) // if it will not find Session user it will redirect to login page.
            {
                Response.Redirect("Login.aspx");

                if (Request.Cookies["LoginCookies"] != null)
                {
                    Response.Redirect("Login.aspx");
                }
            }
            else // if it will find Session it will write message on WelcomeLabel.
            {
                lbl_name.Text = Session["User"].ToString() + "";
                lbl_name2.Text = Session["User"].ToString() + "";
            }
        }

        protected void btn_logoutClick(object sender, EventArgs e)
        {
            Session.Remove("User");
            Session.Contents.RemoveAll();
            Session.RemoveAll();
            if (Request.Cookies["LoginCookies"] != null)
            {
                Response.Cookies["LoginCookies"].Expires = DateTime.Now.AddDays(-1);
                // its trick it will expire yesterday next time when will login it will be expired..
                // because date was before 1 day from today..
            }
            Response.Redirect("Login.aspx");
        }
    }
}