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
    public partial class roomtypelist : System.Web.UI.Page
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
            string strSQL = "SELECT * FROM room_type";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            PlaceHolder_Data.Controls.Add(new LiteralControl("<table class='table table-bordered data' id='data'>"));
            PlaceHolder_Data.Controls.Add(new LiteralControl("<thead>  <tr>  <th>ID Room Type</th>  <th>Name</th> <th>Option</th>  </tr>  </thead>  <tbody>"));
            while (dr.Read())
            {
                PlaceHolder_Data.Controls.Add(new LiteralControl("<tr>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl(dr["id_room_type"].ToString()));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl(dr["name"].ToString()));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<a class='btn btn-sm btn-default' href=updateroomtype.aspx?id=" + dr["id_room_type"].ToString() + "><i class='fa fa-check'> Edit</i></a>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</tr>"));
            }
            PlaceHolder_Data.Controls.Add(new LiteralControl("</tbody></table>"));
            conn.Close();
        }
    }
}