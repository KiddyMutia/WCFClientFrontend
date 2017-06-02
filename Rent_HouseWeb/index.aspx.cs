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
            getBerita();

        }


        protected void GetDataOrganisasi()
        {
            RoomTypeService.RoomTypeServiceClient obj = new RoomTypeService.RoomTypeServiceClient();
            IList<RoomTypeService.RoomTypeInfo> dataInfo = new List<RoomTypeService.RoomTypeInfo>();
            dataInfo = obj.getTotalRoomType();

            string data = string.Empty;
            string id = string.Empty;
            string jumlah = string.Empty;

            foreach (var row in dataInfo)
            {
                id = row.TipeRoomType;
                jumlah = row.TotalRoomType.ToString();
                data += "<tr> <td>" + id + "</td> <td>" + jumlah + "</td> </tr>";
            }

            placeHolder.InnerHtml = data;     
        }

        protected void getBerita()
        {
            string strsql = "select TOP 3 * from tb_berita order by date_time desc";
            string data = string.Empty;
            string id = string.Empty;
            string judul = string.Empty;
            string isi = string.Empty;
            string datetime = string.Empty;

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(strsql, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = dr["id_berita"].ToString();
                judul = dr["title"].ToString();
                isi = dr["contain"].ToString();
                datetime = dr["date_time"].ToString();

                data += " <div class='col-sm-6 col-md-4'> <div class='thumbnail'> <div class='caption'> <h3>" + judul + "</h3> <p>" + isi + "</p> <br> <p>" + datetime + "</p>  </div> </div> </div>";
            }
            placeHolderBerita.InnerHtml = data;
            conn.Close();
        }
    }
}