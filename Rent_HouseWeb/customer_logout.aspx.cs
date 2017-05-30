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
            Session.Remove("email");
            Session.Remove("token");
            Session.Contents.RemoveAll();
            Session.RemoveAll();
            Response.Redirect("customer_login.aspx");
        }
    }
}