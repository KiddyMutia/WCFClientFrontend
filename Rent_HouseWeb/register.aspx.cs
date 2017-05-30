using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rent_HouseWeb
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_saveClick(object sender, EventArgs e)
        {
            try
            {
                UserService.UserInfo obj = new UserService.UserInfo();

                obj.NameUser = name.Value;
                obj.EmailUser = email.Value;
                obj.PasswordUser = password.Value;
                obj.PhoneNumberUser = phone.Value;
                obj.BirthdateUser = birthdate.Value;
                obj.Card_typeUser = cardtype.Value;
                obj.Card_numberUser = cardnumber.Value;
                obj.AddressUser = address.Value;

                UserService.UserServiceClient us = new UserService.UserServiceClient();
                string msg = string.Empty;
                msg = us.insertUser(obj);

                if (msg != string.Empty)
                {
                    //Response.Write("<script>alert('Success Regist')</script>");
                    Response.Write("<script language=javascript>alert('Success Regist');</script>");
                    Response.Redirect("login.aspx");
                }
                else
                {
                    Response.Write("<script language=javascript>alert('Failed Regist, please try again');</script>");
                }               
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Response.Write("<script>alert('Failed Regist, please try again')</script>");
            }

        }
    }
}