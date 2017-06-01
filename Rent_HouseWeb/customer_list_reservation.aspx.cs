using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rent_HouseWeb
{
    public partial class customer_list_reservation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nama"] == null) // if it will not find Session user it will redirect to login page.
            {
                Response.Redirect("customer_login.aspx");
            }
            else
            {
                string id = Session["id_user"].ToString() + "";
                if (id != null)
                {
                    MethodGetId(id);

                    lbl_name.Text = Session["nama"].ToString() + "";
                }
                else
                {
                    Response.Redirect("customer_listroom.aspx");
                }

            }
        }

        protected void MethodGetId(string id)
        {
            ReservationService.ReservationServiceClient obj = new ReservationService.ReservationServiceClient();
            IList<ReservationService.ReservationInfo> dataInfo = new List<ReservationService.ReservationInfo>();
            dataInfo = obj.getReservationFromID(id);


            string data = string.Empty;
            string idres = string.Empty;
            string tipe = string.Empty;
            string customername = string.Empty;
            string datetime = string.Empty;
            string status = string.Empty;
            string info = string.Empty;


            try
            {
                foreach (var x in dataInfo)
                {
                    idres = x.IDReservation;
                    tipe = x.TipeRoomTypeReservation;
                    customername = x.NameCustomerReservation;
                    datetime = x.DateTimeReservation;
                    status = x.StatusReservation;
                    info = x.InfoReservation;
                    data += "<tr> <td>" + idres + "</td> <td>" + tipe + "</td> <td>" + customername + "</td> <td>" + datetime + "</td> <td>" + info + "</td> <td>" + status + "</td> </tr>";
                }
                placeHolder.InnerHtml= data;
            }
            catch (Exception ex)
            {
                //Label_Status.Text = ex.Message;
                
            }
        }


    }
}