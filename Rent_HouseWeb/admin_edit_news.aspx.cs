using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Rent_HouseWeb
{
    public partial class admin_edit_news : System.Web.UI.Page
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
                string id = this.Request["id"];
                if (id != null)
                {
                    MethodGetId(id);

                    lbl_name.Text = Session["nama_admin"].ToString() + "";
                   
                }
                else
                {
                    Response.Redirect("admin_list_news.aspx");
                }
            }
        }

        protected void MethodGetId(string id)
        {
            string strSQL = "SELECT * from tb_berita WHERE id_berita = @id";
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 4).Value = id;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                tb_title.Text = dr["title"].ToString();
                tb_contains.Text = dr["contain"].ToString();
                
                conn.Close();
                //Label_Status.Text = String.Empty;
            }
            catch (Exception ex)
            {
                //Label_Status.Text = ex.Message;
                tb_contains.Text = "ERROR!";
            }
        }

        protected void btn_saveClick(object sender, EventArgs e)
        {
            try
            {

                string sql = "UPDATE tb_berita SET contain = @contain WHERE id_berita = @id";
                SqlConnection sqlconn = new SqlConnection(connStr);
                sqlconn.Open();
                //Declare the Command
                SqlCommand cmd = new SqlCommand(sql, sqlconn);
                
                string id = this.Request["id"];
                //Add the parameters needed for the SQL query
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 5).Value = id;
                cmd.Parameters.Add("@title", SqlDbType.VarChar, 220).Value = tb_title.Text;
                cmd.Parameters.Add("@contain", SqlDbType.Text).Value = tb_contains.Text;
                
                //Execute the query

                cmd.ExecuteNonQuery();

                sqlconn.Close();
               
                    Response.Redirect("admin_list_news.aspx"); // it is a method where you retrieve a data

                //Response.Redirect("admin_list_news.aspx");
                //}
                //catch (SqlException ex) { }
                //SqlConnection sqlconn = new SqlConnection(connStr);
                //SqlCommand sqlinsert = new SqlCommand("update tb_berita set title = @title, contain = @contain where id_berita = @id_berita", sqlconn);

                //sqlconn.Open();

                //sqlinsert.Parameters.Add(new SqlParameter("@title", SqlDbType.VarChar, 220));
                //sqlinsert.Parameters.Add(new SqlParameter("@id_berita", SqlDbType.VarChar, 4));
                //sqlinsert.Parameters.Add(new SqlParameter("@contain", SqlDbType.Text));

                //sqlinsert.Parameters["@title"].Value = tb_title.Text;
                //sqlinsert.Parameters["@id_berita"].Value = this.Request["id"];
                //sqlinsert.Parameters["@contain"].Value = tb_contains.Text;

                //sqlinsert.ExecuteNonQuery();
                //sqlconn.Close();
                //Response.Write("<script>alert('Sukses')</script>");
                //Response.Redirect("admin_list_news.aspx");
            }
            catch (Exception ex)
            {
                string msg = "Insert Error";
                
                msg += ex.Message;
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + ex.Message + "');", true);
                tb_title.Text = msg;

            }

        }
    }
}