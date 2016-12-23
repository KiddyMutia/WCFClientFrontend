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
    public partial class updateroom : System.Web.UI.Page
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
                    isiDropDownList();
                    string id = this.Request["id"];
                    MethodGetId(id);
                    lbl_name.Text = Session["User"].ToString() + "";
                }
            }

        }

        protected void MethodGetId(string id)
        {
            string strSQL = "SELECT * FROM room WHERE id_room = @id";
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 4).Value = id;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                tb_id.Text = dr["id_room"].ToString();
                tb_name.Text = dr["name"].ToString();
                cb_roomtype.SelectedValue = dr["id_room_type"].ToString();
                tb_price.Text = dr["price"].ToString();
                cb_status.Text = dr["status"].ToString();

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
                SqlCommand sqlinsert = new SqlCommand("update room set name=@name,id_room_type=@id_room_type,price=@price,status=@status WHERE id_room=@id", sqlconn);

                sqlconn.Open();

                sqlinsert.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar, 4));
                sqlinsert.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 100));
                sqlinsert.Parameters.Add(new SqlParameter("@price", SqlDbType.Money));
                sqlinsert.Parameters.Add(new SqlParameter("@id_room_type", SqlDbType.VarChar, 4));
                sqlinsert.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar, 100));


                sqlinsert.Parameters["@name"].Value = tb_name.Text;
                sqlinsert.Parameters["@price"].Value = tb_price.Text;
                sqlinsert.Parameters["@id_room_type"].Value = cb_roomtype.SelectedValue;
                sqlinsert.Parameters["@status"].Value = cb_status.SelectedValue;
                sqlinsert.Parameters["@id"].Value = id;

                sqlinsert.ExecuteNonQuery();
                sqlconn.Close();
                Response.Write("<script>alert('Sukses')</script>");
                Response.Redirect("roomlist.aspx");
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

        protected void isiDropDownList()
        {
            //cb_roomtype.Items.Add(new ListItem("--Select Category--", ""));
            cb_roomtype.AppendDataBoundItems = true;

            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("select id_room_type,name from room_type", con);

            try
            {
                con.Open();
                cb_roomtype.DataSource = cmd.ExecuteReader();
                cb_roomtype.DataTextField = "name";
                cb_roomtype.DataValueField = "id_room_type";
                cb_roomtype.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }


    }
}