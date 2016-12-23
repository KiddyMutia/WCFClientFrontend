using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Rent_HouseWeb
{
    public partial class addcustomer : System.Web.UI.Page
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
                    lbl_name.Text = Session["User"].ToString() + "";
                    tb_id.Enabled = false;
                }
            }
        }

        protected void btn_saveClick(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(connStr);
                SqlCommand sqlinsert = new SqlCommand("insert into customer values(@id_customer,@nama,@birthdate,@address,@phonenumber,@card_type,@card_number)", sqlconn);

                sqlconn.Open();

                sqlinsert.Parameters.Add(new SqlParameter("@id_customer", SqlDbType.VarChar, 4));
                sqlinsert.Parameters.Add(new SqlParameter("@nama", SqlDbType.VarChar, 100));
                sqlinsert.Parameters.Add(new SqlParameter("@address", SqlDbType.Text));
                sqlinsert.Parameters.Add(new SqlParameter("@birthdate", SqlDbType.Date));
                sqlinsert.Parameters.Add(new SqlParameter("@phonenumber", SqlDbType.VarChar, 100));
                sqlinsert.Parameters.Add(new SqlParameter("@card_type", SqlDbType.VarChar, 100));
                sqlinsert.Parameters.Add(new SqlParameter("@card_number", SqlDbType.VarChar, 100));

                sqlinsert.Parameters["@id_customer"].Value = tb_id.Text;
                sqlinsert.Parameters["@nama"].Value = tb_name.Text;
                sqlinsert.Parameters["@birthdate"].Value = tb_date.Text;
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

        protected void bd_SelectionChanged(object sender, EventArgs e)
        {
            tb_date.Text = cb_date.SelectedDate.ToShortDateString();
        }

        protected string generateID()
        {
            string sID = null;
            int ID = 0;
            SqlConnection sqlconn = new SqlConnection(connStr);
            sqlconn.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select TOP 1 id_customer from customer order by id_customer DESC", sqlconn);
            myReader = myCommand.ExecuteReader();

            if (myReader.Read())
            {
                sID = (myReader["id_customer"].ToString());
                ID = Convert.ToInt32(sID.Substring(1, 3));
                ID += 1;
                if (ID <= 9)
                {
                    sID = "C00" + ID;
                }
                else if (ID <= 90)
                {
                    sID = "C0" + ID;
                }
                else if (ID <= 900)
                {
                    sID = "C" + ID;
                }
            }
            else
            {
                sID = "C001";
            }
            sqlconn.Close();
            return sID;

        }
    }
}