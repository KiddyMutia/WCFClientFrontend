using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rent_HouseWeb
{
    public partial class customer_logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove("id_user");
            Session.Remove("nama");
            Session.Contents.RemoveAll();
            Session.RemoveAll();
            if (Request.Cookies["LoginCookies"] != null)
            {
                Response.Cookies["LoginCookies"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("customer_login.aspx");
        }
    }
}