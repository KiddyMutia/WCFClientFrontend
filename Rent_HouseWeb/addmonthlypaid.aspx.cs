using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Rent_HouseWeb
{
    public partial class addmonthlypaid : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null) // if it will not find Session user it will redirect to login page.
            {
                Response.Redirect("Login.aspx");

                if (Request.Cookies["LoginCookies"] != null)
                {
                    Response.Redirect("Login.aspx");
                }
            }
            else // if it will find Session it will write message on WelcomeLabel.
            {
                lbl_name.Text = Session["User"].ToString() + "";
                GetDataOrganisasi();
            }

        }

        protected void GetDataOrganisasi()
        {
            string strSQL = "select A.id_transaction,A.id_room,A.id_customer,A.datein,A.dateout,A.status,B.name as namaroom,C.nama as namacustomer,B.price from transactionn A, room B, customer C where A.status = 'Rent In' AND A.id_room = B.id_room AND A.id_customer = C.id_customer order by A.id_transaction";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            PlaceHolder_Data.Controls.Add(new LiteralControl("<table class='table table-bordered data' id='data'>"));
            PlaceHolder_Data.Controls.Add(new LiteralControl("<thead>  <tr>  <th>ID Transaction</th>  <th>Room</th> <th>Customer Name</th> <th>Date In</th> <th>Price</th> <th>Option</th>  </tr>  </thead>  <tbody>"));
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
                PlaceHolder_Data.Controls.Add(new LiteralControl(dr["price"].ToString()));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<a class='btn btn-sm btn-default' href=monthlytransaction.aspx?id=" + dr["id_transaction"].ToString() + "><i class='fa fa-home'> New Paid</i></a>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</tr>"));
            }
            PlaceHolder_Data.Controls.Add(new LiteralControl("</tbody></table>"));
            conn.Close();
        }
    }
}