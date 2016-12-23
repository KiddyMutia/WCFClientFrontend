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
    public partial class updatecustomer : System.Web.UI.Page
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
            string strSQL = "SELECT * FROM customer WHERE id_customer = @id";
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 4).Value = id;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                tb_id.Text = dr["id_customer"].ToString();
                tb_name.Text = dr["nama"].ToString();
                tb_address.Text = dr["address"].ToString();
                //tb_birthdate2.Text = dr["birthdate"].ToString();
                tb_phone.Text = dr["phonenumber"].ToString();
                tb_number.Text = dr["card_number"].ToString();
                cb_type.Text = dr["card_type"].ToString();

                conn.Close();
                //Label_Status.Text = String.Empty;
            }
            catch (Exception ex)
            {
                //Label_Status.Text = ex.Message;
                tb_name.Text = "ERROR!";
                tb_number.Text = "ERROR!";
                tb_phone.Text = "ERROR!";
                tb_name.Text = "ERROR!";
            }
        }

        protected void btn_saveClick(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(connStr);
                string id = this.Request["id"];
                SqlCommand sqlinsert = new SqlCommand("update customer set nama=@nama,address=@address,phonenumber=@phonenumber,card_type=@card_type,card_number=@card_number WHERE id_customer=@id", sqlconn);

                sqlconn.Open();

                sqlinsert.Parameters.Add(new SqlParameter("@nama", SqlDbType.VarChar, 100));
                sqlinsert.Parameters.Add(new SqlParameter("@address", SqlDbType.Text));
                //sqlinsert.Parameters.Add(new SqlParameter("@birthdate", SqlDbType.Date));
                sqlinsert.Parameters.Add(new SqlParameter("@phonenumber", SqlDbType.VarChar, 100));
                sqlinsert.Parameters.Add(new SqlParameter("@card_type", SqlDbType.VarChar, 100));
                sqlinsert.Parameters.Add(new SqlParameter("@card_number", SqlDbType.VarChar, 100));
                sqlinsert.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar,4));

                sqlinsert.Parameters["@nama"].Value = tb_name.Text;
                sqlinsert.Parameters["@id"].Value = id;
                //sqlinsert.Parameters["@birthdate"].Value = tb_birthdate2.Text.ToString();
                sqlinsert.Parameters["@address"].Value = tb_address.Text;
                sqlinsert.Parameters["@phonenumber"].Value = tb_phone.Text;
                sqlinsert.Parameters["@card_type"].Value = cb_type.SelectedValue;
                sqlinsert.Parameters["@card_number"].Value = tb_number.Text;

                sqlinsert.ExecuteNonQuery();
                sqlconn.Close();
                Response.Write("<script>alert('Sukses')</script>");
                Response.Redirect("customerlist.aspx");
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