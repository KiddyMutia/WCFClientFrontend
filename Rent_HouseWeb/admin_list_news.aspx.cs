using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Rent_HouseWeb
{
    public partial class admin_list_news1 : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nama_admin"] == null) // if it will not find Session user it will redirect to login page.
            {
                Response.Redirect("login_admin.aspx");
            }
            else // if it will find Session it will write message on WelcomeLabel.
            {
                lbl_name.Text = Session["nama_admin"].ToString() + "";
                getBerita();
            }
        }

        protected void getBerita()
        {
            string strsql = "select * from tb_berita order by date_time desc";
            string data = string.Empty;
            string id = string.Empty;
            string judul = string.Empty;
            string isi = string.Empty;
            string datetime = string.Empty;

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(strsql, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = dr["id_berita"].ToString();
                judul = dr["title"].ToString();
                isi = dr["contain"].ToString();
                datetime = dr["date_time"].ToString();

                data += "<tr> <td>" + id + "</td> <td>" + judul + "</td> <td>" + isi + "</td> <td>" + datetime + "</td><td> <a class='btn btn-info' href=admin_edit_news.aspx?id=" + id + ">Edit</a> </td> </tr>";
            }
            placeHolder.InnerHtml = data;
            conn.Close();
        }
    }
}