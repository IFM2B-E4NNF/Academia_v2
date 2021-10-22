using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Academia_IFM02B2_Project_Website.ACD_Reference;

namespace Academia_IFM02B2_Project_Website
{
    public partial class Login : System.Web.UI.Page
    {
        ACD_ServiceClient client = new ACD_ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Login(object sender, EventArgs e)
        {
            //int userExist = client.Login(email.Value, password.Value);

            int UserExist = client.Login(email.Value, password.Value);


            if (UserExist == -1)
            {
                results.InnerText = "Wrong email or password";
                email.Value = "";
                password.Value = "";
            }
            else
            {
                User user = client.getUser(UserExist);

                if (user.UserType == 1)
                {
                    Session["ID"] = user.UserId;
                    Session["Name"] = user.Firstname;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Session["ID"] = user.UserId;
                    Session["Name"] = user.Firstname;
                    Response.Redirect("Dashboard.aspx");
                }

            }

        }
    }
}