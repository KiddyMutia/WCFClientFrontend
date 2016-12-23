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
    public partial class rentin : System.Web.UI.Page
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
                    tb_id.Text = generateID();
                }

            }
        }

        protected void btn_saveClick(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(connStr);
                SqlCommand sqlinsert = new SqlCommand("insert into transactionn (id_transaction,id_room,id_customer,datein,dateout,status) values(@id_transaction,@id_room,@id_customer,@datein,@dateout,@status)", sqlconn);

                sqlconn.Open();

                sqlinsert.Parameters.Add(new SqlParameter("@id_transaction", SqlDbType.VarChar, 4));
                sqlinsert.Parameters.Add(new SqlParameter("@id_room", SqlDbType.VarChar, 4));
                sqlinsert.Parameters.Add(new SqlParameter("@id_customer", SqlDbType.VarChar, 4));
                sqlinsert.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 100));
                sqlinsert.Parameters.Add(new SqlParameter("@price", SqlDbType.Money));
                sqlinsert.Parameters.Add(new SqlParameter("@id_room_type", SqlDbType.VarChar, 4));
                sqlinsert.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar, 100));


                sqlinsert.Parameters["@id_room"].Value = tb_id.Text;
                //sqlinsert.Parameters["@name"].Value = tb_name.Text;
                //sqlinsert.Parameters["@price"].Value = tb_price.Text;
                //sqlinsert.Parameters["@id_room_type"].Value = cb_roomtype.SelectedValue;
                sqlinsert.Parameters["@status"].Value = "Available";

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
                tb_id.Text = ex.Message;
                msg += ex.Message;
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + ex.Message + "');", true);

            }
            finally
            {
                //tb_id.Text = "HAAA";
            }

        }

        protected void isiDropDownList()
        {
            //cb_roomtype.Items.Add(new ListItem("--Select Category--", ""));
            cb_room.AppendDataBoundItems = true;

            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("select id_room,name from room", con);

            try
            {
                con.Open();
                cb_room.DataSource = cmd.ExecuteReader();
                cb_room.DataTextField = "name";
                cb_room.DataValueField = "id_room_type";
                cb_room.DataBind();
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

        protected void customerisiDropDownList()
        {
            //cb_roomtype.Items.Add(new ListItem("--Select Category--", ""));
            cb_customer.AppendDataBoundItems = true;

            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("select id_customer,nama from customer", con);

            try
            {
                con.Open();
                cb_customer.DataSource = cmd.ExecuteReader();
                cb_customer.DataTextField = "nama";
                cb_customer.DataValueField = "id_customer";
                cb_customer.DataBind();
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

        protected string generateID()
        {
            string sID = null;
            int ID = 0;
            SqlConnection sqlconn = new SqlConnection(connStr);
            sqlconn.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select TOP 1 id_room from room order by id_room DESC", sqlconn);
            myReader = myCommand.ExecuteReader();

            if (myReader.Read())
            {
                sID = (myReader["id_room"].ToString());
                ID = Convert.ToInt32(sID.Substring(1, 3));
                ID += 1;
                if (ID <= 9)
                {
                    sID = "R00" + ID;
                }
                else if (ID <= 90)
                {
                    sID = "R0" + ID;
                }
                else if (ID <= 900)
                {
                    sID = "R" + ID;
                }
            }
            else
            {
                sID = "R001";
            }
            sqlconn.Close();
            return sID;

        }
    }
}