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
    public partial class updateroomtype : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null) // if it will not find Session user it will redirect to login page.
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    string id = this.Request["id"];
                    MethodGetId(id);
                    lbl_name.Text = Session["User"].ToString() + "";
                }
            }

        }

        protected void MethodGetId(string id)
        {
            string strSQL = "SELECT * FROM room_type WHERE id_room_type = @id";
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 4).Value = id;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                tb_id.Text = dr["id_room_type"].ToString();
                tb_name.Text = dr["name"].ToString();

                conn.Close();
                //Label_Status.Text = String.Empty;
            }
            catch (Exception ex)
            {
                //Label_Status.Text = ex.Message;
                tb_name.Text = "ERROR!";
            }
        }

        protected void btn_saveClick(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(connStr);
                string id = this.Request["id"];
                SqlCommand sqlinsert = new SqlCommand("update room_type set name=@nama WHERE id_room_type=@id", sqlconn);

                sqlconn.Open();

                sqlinsert.Parameters.Add(new SqlParameter("@nama", SqlDbType.VarChar, 100));
                sqlinsert.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar, 4));

                sqlinsert.Parameters["@nama"].Value = tb_name.Text;
                sqlinsert.Parameters["@id"].Value = id;
                
                sqlinsert.ExecuteNonQuery();
                sqlconn.Close();
                Response.Write("<script>alert('Sukses')</script>");
                Response.Redirect("roomtypelist.aspx");
                //clearData();
                //TextBox1.Text = generateID();
                //DisplayRecord();

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