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
                    customerisiDropDownList();
                    tb_id.Text = generateID();
                    tb_id.Enabled = false;
                }

            }
        }

        protected void btn_saveClick(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(connStr);
                SqlCommand sqlinsert = new SqlCommand("insert into transactionn (id_transaction,id_room,id_customer,datein,status) values(@id_transaction,@id_room,@id_customer,@datein,@status)", sqlconn);

                sqlconn.Open();

                sqlinsert.Parameters.Add(new SqlParameter("@id_transaction", SqlDbType.VarChar, 4));
                sqlinsert.Parameters.Add(new SqlParameter("@id_room", SqlDbType.VarChar, 4));
                sqlinsert.Parameters.Add(new SqlParameter("@id_customer", SqlDbType.VarChar, 4));
                sqlinsert.Parameters.Add(new SqlParameter("@datein", SqlDbType.DateTime));
                sqlinsert.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar, 100));

                sqlinsert.Parameters["@id_transaction"].Value = tb_id.Text;
                sqlinsert.Parameters["@id_room"].Value = cb_room.SelectedValue;
                sqlinsert.Parameters["@id_customer"].Value = cb_customer.SelectedValue;
                sqlinsert.Parameters["@datein"].Value = tb_datein.Text;
                sqlinsert.Parameters["@status"].Value = "Rent In";

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
                tb_id.Text = ex.Message;
                msg += ex.Message;
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + ex.Message + "');", true);

            }
            finally
            {
                //tb_id.Text = "HAAA";
            }

        }

        protected void cl_dateinSelectionChanged(object sender, EventArgs e)
        {
            tb_datein.Text = cl_datein.SelectedDate.ToShortDateString();
        }

        protected void isiDropDownList()
        {
            //cb_roomtype.Items.Add(new ListItem("--Select Category--", ""));
            cb_room.AppendDataBoundItems = true;

            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("select id_room,name from room where status='Available' order by name", con);

            try
            {
                con.Open();
                cb_room.DataSource = cmd.ExecuteReader();
                cb_room.DataTextField = "name";
                cb_room.DataValueField = "id_room";
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
            SqlCommand cmd = new SqlCommand("select id_customer,nama from customer order by nama", con);

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
            SqlCommand myCommand = new SqlCommand("select TOP 1 id_transaction from transactionn order by id_transaction DESC", sqlconn);
            myReader = myCommand.ExecuteReader();

            if (myReader.Read())
            {
                sID = (myReader["id_transaction"].ToString());
                ID = Convert.ToInt32(sID.Substring(1, 3));
                ID += 1;
                if (ID <= 9)
                {
                    sID = "T00" + ID;
                }
                else if (ID <= 90)
                {
                    sID = "T0" + ID;
                }
                else if (ID <= 900)
                {
                    sID = "T" + ID;
                }
            }
            else
            {
                sID = "T001";
            }
            sqlconn.Close();
            return sID;

        }
    }
}