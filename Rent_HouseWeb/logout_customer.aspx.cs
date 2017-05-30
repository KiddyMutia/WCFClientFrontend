using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rent_HouseWeb
{
    public partial class logout_customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove("id_user");
            Session.Remove("nama");
            Session.Remove("email");
            Session.Remove("token");
            Session.Contents.RemoveAll();
            Session.RemoveAll();
            if (Request.Cookies["LoginCookies"] != null)
            {
                Response.Cookies["LoginCookies"].Expires = DateTime.Now.AddDays(-1);
                // its trick it will expire yesterday next time when will login it will be expired..
                // because date was before 1 day from today..
            }
            Response.Redirect("login_customer.aspx");
        }
    }
}