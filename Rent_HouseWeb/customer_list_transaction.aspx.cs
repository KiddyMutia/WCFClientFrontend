using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rent_HouseWeb
{
    public partial class custoemr_list_transaction : System.Web.UI.Page
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
            MonthPaidService.MonthPaidServiceClient obj = new MonthPaidService.MonthPaidServiceClient();
            IList<MonthPaidService.MonthPaidInfo> dataInfo = new List<MonthPaidService.MonthPaidInfo>();
            dataInfo = obj.getMonthPaidByIDUser(id);


            string data = string.Empty;
            string idtrans = string.Empty;
            string kamar = string.Empty;
            string datetime = string.Empty;
            string total = string.Empty;
            string info = string.Empty;


            try
            {
                foreach (var x in dataInfo)
                {
                    idtrans = x.IDTransaction;
                    kamar = x.KamarMonthPaid;
                    datetime = x.TglMonthPaid;
                    total = x.TotalMonthPaid.ToString();
                    info = x.InfoMonthPaid;
                    data += "<tr> <td>" + idtrans + "</td> <td>" + kamar + "</td> <td>" + datetime + "</td> <td>" + total + "</td> <td>" + info + "</td> </tr>";
                }
                placeHolder.InnerHtml = data;
            }
            catch (Exception ex)
            {
                //Label_Status.Text = ex.Message;

            }
        }
    }
}