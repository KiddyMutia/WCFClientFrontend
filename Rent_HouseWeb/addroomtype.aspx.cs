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
    public partial class addroomtype : System.Web.UI.Page
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
                SqlCommand sqlinsert = new SqlCommand("insert into room_type values(@id_room_type,@nama)", sqlconn);

                sqlconn.Open();

                sqlinsert.Parameters.Add(new SqlParameter("@id_room_type", SqlDbType.VarChar, 4));
                sqlinsert.Parameters.Add(new SqlParameter("@nama", SqlDbType.VarChar, 100));

                sqlinsert.Parameters["@id_room_type"].Value = tb_id.Text;
                sqlinsert.Parameters["@nama"].Value = tb_name.Text;
                
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

        
        protected string generateID()
        {
            string sID = null;
            int ID = 0;
            SqlConnection sqlconn = new SqlConnection(connStr);
            sqlconn.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select TOP 1 id_room_type from room_type order by id_room_type DESC", sqlconn);
            myReader = myCommand.ExecuteReader();

            if (myReader.Read())
            {
                sID = (myReader["id_room_type"].ToString());
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