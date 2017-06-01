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
            if (Session["nama"] == null) // if it will not find Session user it will redirect to login page.
            {
                Response.Redirect("customer_login.aspx");
            }
            else
            {
                string id = this.Request["id"];
                if (id != null)
                {
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
                else
                {
                    Response.Redirect("customer_listroom.aspx");
                }
                
            }
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
                    user_name.Text = Session["nama"].ToString();
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
                ReservationService.ReservationInfo obj = new ReservationService.ReservationInfo();

                obj.IDRoomReservation = tb_idroom.Text;
                obj.IDCustomerReservation = tb_idcust.Text;
                obj.InfoReservation = tb_info.Text;

                ReservationService.ReservationServiceClient us = new ReservationService.ReservationServiceClient();
                string msg = string.Empty;
                msg = us.insertData(obj);

                if (msg != string.Empty)
                {
                    //Response.Write("<script>alert('Success Regist')</script>");
                    Response.Write("<script language=javascript>alert('Success Regist');</script>");
                    Response.Redirect("customer_list_reservation.aspx");
                }
                else
                {
                    Response.Write("<script language=javascript>alert('Failed Regist, please try again');</script>");
                }               

            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert('Failed Regist, please try again');</script>");
            }

        }
    }
}