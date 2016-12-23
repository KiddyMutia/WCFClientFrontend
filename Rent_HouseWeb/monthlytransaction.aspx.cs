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
    public partial class monthlytransaction : System.Web.UI.Page
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
                    tb_id.Text = generateID();
                    string id = this.Request["id"];
                    MethodGetId(id);
                    lbl_name.Text = Session["User"].ToString() + "";
                    tb_id.Enabled = false;
                    tb_idtrans.Enabled = false;
                    tb_price.Enabled = false;
                    tb_customer.Enabled = false;
                    tb_room.Enabled = false;
                    tb_roomid.Visible = false;
                    tb_customerid.Visible = false;
                }
            }

        }

        protected void MethodGetId(string id)
        {
            string strSQL = "select A.id_transaction,A.id_room,A.id_customer,A.datein,A.dateout,A.status,B.price,B.name as namaroom,C.nama as namacustomer from transactionn A, room B, customer C where A.id_transaction=@id AND A.id_room = B.id_room AND A.id_customer = C.id_customer order by A.id_transaction";

            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 4).Value = id;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                tb_idtrans.Text = dr["id_transaction"].ToString();
                tb_price.Text = dr["price"].ToString();
                tb_room.Text = dr["namaroom"].ToString();
                tb_customer.Text = dr["namacustomer"].ToString();
                tb_roomid.Text = dr["id_room"].ToString();
                tb_customerid.Text = dr["id_customer"].ToString();

                conn.Close();
                //Label_Status.Text = String.Empty;
            }
            catch (Exception ex)
            {
                //Label_Status.Text = ex.Message;
                tb_id.Text = ex.Message;
            }
        }

        protected void btn_saveClick(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(connStr);
                string id = this.Request["id"];
                SqlCommand sqlinsert = new SqlCommand("insert into monthlypaid values (@id_monthlypaid,@id_transaction,@datetime,@total,@info)", sqlconn);

                sqlconn.Open();

                sqlinsert.Parameters.Add(new SqlParameter("@id_monthlypaid", SqlDbType.VarChar, 4));
                sqlinsert.Parameters.Add(new SqlParameter("@id_transaction", SqlDbType.VarChar, 4));
                sqlinsert.Parameters.Add(new SqlParameter("@id_room", SqlDbType.VarChar, 4));
                sqlinsert.Parameters.Add(new SqlParameter("@id_customer", SqlDbType.VarChar, 4));
                sqlinsert.Parameters.Add(new SqlParameter("@datetime", SqlDbType.DateTime));
                sqlinsert.Parameters.Add(new SqlParameter("@total", SqlDbType.Money));
                sqlinsert.Parameters.Add(new SqlParameter("@info", SqlDbType.Text));


                sqlinsert.Parameters["@id_monthlypaid"].Value = tb_id.Text;
                sqlinsert.Parameters["@id_transaction"].Value = tb_idtrans.Text;
                sqlinsert.Parameters["@id_room"].Value = tb_roomid.Text;
                sqlinsert.Parameters["@id_customer"].Value = tb_customerid.Text;
                sqlinsert.Parameters["@datetime"].Value = DateTime.Now;
                //sqlinsert.Parameters["@id"].Value = id;
                sqlinsert.Parameters["@info"].Value = tb_info.Text;
                sqlinsert.Parameters["@total"].Value = tb_price.Text;

                sqlinsert.ExecuteNonQuery();
                sqlconn.Close();
                Response.Write("<script>alert('Sukses')</script>");
                Response.Redirect("transactionlist.aspx");
                //clearData();
                //TextBox1.Text = generateID();
                //DisplayRecord();

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Insert Error";
                msg += ex.Message;
                tb_id.Text = ex.Message;
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + ex.Message + "');", true);

            }

        }

        protected string generateID()
        {
            string sID = null;
            int ID = 0;
            SqlConnection sqlconn = new SqlConnection(connStr);
            sqlconn.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select TOP 1 id_monthlypaid from monthlypaid order by id_monthlypaid DESC", sqlconn);
            myReader = myCommand.ExecuteReader();

            if (myReader.Read())
            {
                sID = (myReader["id_monthlypaid"].ToString());
                ID = Convert.ToInt32(sID.Substring(1, 3));
                ID += 1;
                if (ID <= 9)
                {
                    sID = "M00" + ID;
                }
                else if (ID <= 90)
                {
                    sID = "M0" + ID;
                }
                else if (ID <= 900)
                {
                    sID = "M" + ID;
                }
            }
            else
            {
                sID = "M001";
            }
            sqlconn.Close();
            return sID;

        }


    }
}