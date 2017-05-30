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
    }
}