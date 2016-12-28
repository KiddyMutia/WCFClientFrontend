using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Rent_HouseWeb
{
    public partial class index : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

            GetDataOrganisasi();

        }
        protected void GetDataOrganisasi()
        {
            string strSQL = "SELECT A.id_room,A.name,A.price,A.status,B.name as nama from room A, room_Type B where A.id_room_type = B.id_room_type AND A.status='Available' ";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            PlaceHolder_Data1.Controls.Add(new LiteralControl("<table class='table table-bordered data' id='data'>"));
            PlaceHolder_Data1.Controls.Add(new LiteralControl("<thead>  <tr>  <th>Room Name</th> <th>Room Type</th> <th>Price</th> <th>Status</th> </tr>  </thead>  <tbody>"));
            while (dr.Read())
            {
                PlaceHolder_Data1.Controls.Add(new LiteralControl("<tr>"));
                PlaceHolder_Data1.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data1.Controls.Add(new LiteralControl(dr["name"].ToString()));
                PlaceHolder_Data1.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data1.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data1.Controls.Add(new LiteralControl(dr["nama"].ToString()));
                PlaceHolder_Data1.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data1.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data1.Controls.Add(new LiteralControl(dr["price"].ToString()));
                PlaceHolder_Data1.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data1.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data1.Controls.Add(new LiteralControl(dr["status"].ToString()));
                PlaceHolder_Data1.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data1.Controls.Add(new LiteralControl("</tr>"));
            }
            PlaceHolder_Data1.Controls.Add(new LiteralControl("</tbody></table>"));
            conn.Close();
        } 
    }
}