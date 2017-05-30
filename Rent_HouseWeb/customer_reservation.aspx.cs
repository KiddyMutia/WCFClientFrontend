using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rent_HouseWeb
{
    public partial class customer_reservation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = this.Request["id"];
            MethodGetId(id);
            lbl_name.Text = Session["nama"].ToString() + "";
            tb_idroom.Enabled = false;
            tb_idroom.Visible = false;
            tb_idcust.Enabled = false;
            tb_idcust.Visible = false;
            user_name.Enabled = false;
            tb_name.Enabled = false;
            tb_price.Enabled = false;
        }

        protected void MethodGetId(string id)
        {
            RoomTypeService.RoomTypeServiceClient obj = new RoomTypeService.RoomTypeServiceClient();
            IList<RoomTypeService.RoomTypeInfo> dataInfo = new List<RoomTypeService.RoomTypeInfo>();
            dataInfo = obj.getReservation(id);

            try
            {
                foreach (var x in dataInfo)
                {
                    tb_idcust.Text = Session["id_user"].ToString();
                    tb_idroom.Text = x.IDRoomType;
                    tb_name.Text = x.TipeRoomType;
                    tb_price.Text = x.PriceRoomType.ToString();
                }
            }
            catch (Exception ex)
            {
                //Label_Status.Text = ex.Message;
                tb_idcust.Text = ex.Message;
            }
        }

        protected void btn_saveClick(object sender, EventArgs e)
        {
            try
            {
                

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
               

            }

        }
    }
}