using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Academia_IFM02B2_Project_Website.ACD_Reference;

namespace Academia_IFM02B2_Project_Website
{
    public partial class ContactUs : System.Web.UI.Page
    {
        ACD_ServiceClient client = new ACD_ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            results.Visible = false;
        }

        protected void Btn_Contact(object sender, EventArgs e)
        {
            MyContact newUser = new MyContact
            {
                firstname = name.Value,
                email = email.Value,
                subject = subject.Value,
                message = message.Value,
            };



            if (client.AddContactUs(newUser) == 1)
            {
                //Response.Redirect("Home.aspx");
                results.Visible = true;
                results.InnerText = "You successfully sent the message, thank you";

            }
            else //(client.AddContactUs(newUser))
            {
                //The User Exists
               
                results.InnerText = "Something went wrong, please try again later";
            }

            name.Value = "";
            email.Value = "";
            subject.Value = "";
            message.Value = "";



        }
    }
}