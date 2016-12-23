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
    public partial class monthlypaidlist : System.Web.UI.Page
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
            string strSQL = "select A.id_monthlypaid,A.id_transaction,A.date_time,A.total,A.info,C.nama as namacustomer,D.name as namaroom from monthlypaid A,transactionn B,customer C,room D where A.id_transaction = B.id_transaction AND B.id_customer = C.id_customer AND B.id_room = D.id_room order by A.id_monthlypaid";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            PlaceHolder_Data.Controls.Add(new LiteralControl("<table class='table table-bordered data' id='data'>"));
            PlaceHolder_Data.Controls.Add(new LiteralControl("<thead>  <tr>  <th>ID MonhtlyPaid Transaction</th> <th>ID Transaction</th>  <th>Room</th> <th>Customer Name</th> <th>Date Paid</th> <th> Total Price</th> <th> Information</th>  </tr>  </thead>  <tbody>"));
            while (dr.Read())
            {
                PlaceHolder_Data.Controls.Add(new LiteralControl("<tr>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl(dr["id_monthlypaid"].ToString()));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
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
                PlaceHolder_Data.Controls.Add(new LiteralControl(dr["date_time"].ToString()));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl(dr["total"].ToString()));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl(dr["info"].ToString()));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</tr>"));
            }
            PlaceHolder_Data.Controls.Add(new LiteralControl("</tbody></table>"));
            conn.Close();
        }
    }
}