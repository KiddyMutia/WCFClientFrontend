using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rent_HouseWeb
{
    public partial class customer_listroom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nama"] == null) // if it will not find Session user it will redirect to login page.
            {
                Response.Redirect("customer_login.aspx");
            }
            else // if it will find Session it will write message on WelcomeLabel.
            {
                lbl_name.Text = Session["nama"].ToString() + "";
                getData();
                getTotalData();
            }
            
        }

        protected void getData()
        {
            RoomTypeService.RoomTypeServiceClient obj = new RoomTypeService.RoomTypeServiceClient();
            IList<RoomTypeService.RoomTypeInfo> dataInfo = new List<RoomTypeService.RoomTypeInfo>();
            dataInfo = obj.getRoomType();

            string data = string.Empty;
            string id = string.Empty;
            string tipe = string.Empty;
            string info = string.Empty;
            string harga = string.Empty;

            foreach (var row in dataInfo)
            {
                id = row.IDRoomType;
                tipe = row.TipeRoomType;
                info = row.InfoRoomType;
                harga = row.PriceRoomType.ToString();
                data += "<tr> <td>" + tipe + "</td> <td>" + harga + "</td> <td>" + info + "</td> <td> <a class='btn btn-info' href=customer_reservation.aspx?id=" + id + ">Reserve</a> </td> </tr>";
            }

            placeHolder.InnerHtml = data;
        }

        protected void getTotalData()
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
                data += "<tr> <td>" + id + "</td> <td>" + jumlah +" Rooms Available </td> </tr>";
            }

            Tbody1.InnerHtml = data;    
        } 
    }
}