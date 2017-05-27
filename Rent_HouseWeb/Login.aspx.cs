using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Rent_HouseWeb
{
    public partial class Login : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null) // if it will not find Session user it will redirect to login page.
            {
                Response.Redirect("adminhome.aspx");
            }
        }

        protected void btn_loginClick(object sender, EventArgs e)
        {


            string str = "select * from admin where username = @username  and password =@password";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(str, con);

            //string Pass = md5(txtPass.Text);

            try
            {
                con.Open();
                cmd.Parameters.AddWithValue("@username", tb_username.Text);
                cmd.Parameters.AddWithValue("@password", tb_password.Text);

                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {

                    // If Username Password found in Database It will
                    // Storee Session
                    Session["User"] = tb_username.Text;
                    Session.Timeout = 60; //15min
                    // now Storing Cookies & config.
                    HttpCookie LoginCookies = new HttpCookie("LoginCookies");
                    LoginCookies.Value = tb_username.Text;
                    LoginCookies.Expires = DateTime.Now.AddHours(1); // Making Cooki for 1 hour
                    Response.Cookies.Add(LoginCookies);
                    // Redirecting to Welcomepage.
                    Response.Redirect("adminhome.aspx");

                }
                else
                {
                    lbl_error.Text = "Invalid Username Or Password !";
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message + "<br/>" + ex.StackTrace);
            }
            finally
            {
                con.Close();
            }
        }    
    }
}