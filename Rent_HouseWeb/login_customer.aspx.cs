using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rent_HouseWeb
{
    public partial class login_customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_loginClick(object sender, EventArgs e)
        {
            string id_user = string.Empty;
            string nama = string.Empty;
            string emailuser = string.Empty;
            Boolean status = true;

            string email = emailfromuser.Value;
            string password = passwordfromuser.Value;

            

            try
            {
                UserService.UserServiceClient obj = new UserService.UserServiceClient();
                IList<UserService.UserInfo> dataInfo = new List<UserService.UserInfo>();


                dataInfo = obj.loginUser(email, password);

                foreach (var x in dataInfo)
                {
                    if (email == x.EmailUser && password == x.PasswordUser)
                    {
                        id_user = x.IDUser;
                        nama = x.NameUser;
                        email = x.EmailUser;

                        // Storee Session
                        Session["id_user"] = id_user;
                        Session["nama"] = nama;
                        Session["email"] = email;
                        Session["token"] = status;
                        Session.Timeout = 60; //15min
                        // Redirecting to Welcomepage.
                        Response.Redirect("customer_home.aspx");
                    }
                    else
                    {
                        //Response.Redirect("customer_home.aspx");
                    }
                    

                }


            }
            catch (Exception ex)
            {
                //Response.Write("<script>alert('" + ex + "')</script>");
            }
        }    
    }
}