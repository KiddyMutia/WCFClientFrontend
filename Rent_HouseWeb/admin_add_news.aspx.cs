using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Rent_HouseWeb
{
    public partial class admin_list_news : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["nama_admin"] == null) // if it will not find Session user it will redirect to login page.
            {
                Response.Redirect("login_admin.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    lbl_name.Text = Session["nama_admin"].ToString() + "";
                }
            }
        }

        protected void btn_saveClick(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(connStr);
                SqlCommand sqlinsert = new SqlCommand("insert into tb_berita (title,contain) values(@title,@contain)", sqlconn);

                sqlconn.Open();

                sqlinsert.Parameters.Add(new SqlParameter("@title", SqlDbType.VarChar, 220));
                sqlinsert.Parameters.Add(new SqlParameter("@contain", SqlDbType.Text));
                
                sqlinsert.Parameters["@title"].Value = tb_title.Text;
                sqlinsert.Parameters["@contain"].Value = tb_contains.Text;

                sqlinsert.ExecuteNonQuery();
                sqlconn.Close();
                Response.Write("<script>alert('Sukses')</script>");
                Response.Redirect("admin_list_news.aspx");
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Insert Error";
                msg += ex.Message;
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + ex.Message + "');", true);

            }

        }
    }
}