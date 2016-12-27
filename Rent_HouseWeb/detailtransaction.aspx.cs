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
    public partial class detailtransaction : System.Web.UI.Page
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
                    tb_id.Enabled = false;
                    tb_customer.Enabled = false;
                    GetDataOrganisasi();
                }
            }

        }

        protected void MethodGetId(string id)
        {
            string strSQL = "select A.id_transaction,A.id_room,A.id_customer,A.datein,A.dateout,A.status,B.name as namaroom,C.nama as namacustomer from transactionn A, room B, customer C where A.id_transaction=@id AND A.id_room = B.id_room AND A.id_customer = C.id_customer order by A.id_transaction";

            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 4).Value = id;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                tb_id.Text = dr["id_transaction"].ToString();
                cb_room.Text = dr["namaroom"].ToString();
                tb_customer.Text = dr["namacustomer"].ToString();

                conn.Close();
                //Label_Status.Text = String.Empty;
            }
            catch (Exception ex)
            {
                //Label_Status.Text = ex.Message;
                tb_id.Text = ex.Message;
            }
        }

        protected void GetDataOrganisasi()
        {
            string strSQL = "select A.id_transaction,A.id_room,A.id_customer,A.datein,A.dateout,A.status,B.name as namaroom,C.nama as namacustomer from transactionn A, room B, customer C where A.id_room = B.id_room AND A.id_customer = C.id_customer order by A.status,A.id_transaction ASC";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            PlaceHolder_Data.Controls.Add(new LiteralControl("<table class='table table-bordered data' id='data'>"));
            PlaceHolder_Data.Controls.Add(new LiteralControl("<thead>  <tr>  <th>ID Transaction</th>  <th>Room</th> <th>Customer Name</th> <th>Date In</th> <th>Date Out</th> <th>Status</th> <th>Option</th>  </tr>  </thead>  <tbody>"));
            while (dr.Read())
            {
                PlaceHolder_Data.Controls.Add(new LiteralControl("<tr>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl(dr["id_transaction"].ToString()));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl(dr["namaroom"].ToString()));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl(dr["namacustomer"].ToString()));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl(dr["datein"].ToString()));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl(dr["dateout"].ToString()));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl(dr["status"].ToString()));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<a class='btn btn-sm btn-default' href=detailtransaction.aspx?id=" + dr["id_transaction"].ToString() + "><i class='fa fa-home'> Detail Transaction</i></a>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));

                /*
                 * PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                    PlaceHolder_Data.Controls.Add(new LiteralControl("<a class='btn btn-sm btn-default' href=updatetransaction.aspx?id=" + dr["id_transaction"].ToString() + "><i class='fa fa-home'> Move Room</i></a> <a class='btn btn-sm btn-default' href=rentout.aspx?id=" + dr["id_transaction"].ToString() + "><i class='fa fa-check'> Rent Out</i></a>"));
                    PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                 * */
                PlaceHolder_Data.Controls.Add(new LiteralControl("</tr>"));
            }
            PlaceHolder_Data.Controls.Add(new LiteralControl("</tbody></table>"));
            conn.Close();
        }
    }
}