using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rent_HouseWeb
{
    public partial class login_admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_loginClick(object sender, EventArgs e)
        {
            string id_admin = string.Empty;
            string nama = string.Empty;

            string username = usernameadmin.Value;
            string password = passwordadmin.Value;



            try
            {
                AdminService.AdminServiceClient obj = new AdminService.AdminServiceClient();
                IList<AdminService.AdminInfo> dataInfo = new List<AdminService.AdminInfo>();


                dataInfo = obj.loginAdmin(username, password);

                foreach (var x in dataInfo)
                {
                    if (username == x.UsernameAdmin && password == x.PasswordAdmin)
                    {
                        id_admin = x.IDAdmin;
                        nama = x.NameAdmin;

                        // Storee Session
                        Session["id_admin"] = id_admin;
                        Session["nama_admin"] = nama;
                        Session.Timeout = 60; //15min
                        // Redirecting to Welcomepage.
                        Response.Redirect("adminhome.aspx");
                    }
                    else
                    {
                        //Response.Redirect("customer_login.aspx");
                        lbl_error.Text = "Invalid Username Or Password !";
                    }


                }


            }
            catch (Exception ex)
            {
                //Response.Write("<script>alert('" + ex + "')</script>");
                lbl_error.Text = "Invalid Username Or Password !";
            }
        }
    }
}