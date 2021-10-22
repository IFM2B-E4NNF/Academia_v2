using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Academia_IFM02B2_Project_Website.ACD_Reference;

namespace Academia_IFM02B2_Project_Website
{
    public partial class Register : System.Web.UI.Page
    {
        ACD_ServiceClient client = new ACD_ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Register(object sender, EventArgs e)
        {
            MyUser newUser = new MyUser
            {
                firstname = firstname.Value,
                lastname = lastname.Value,
                email = email.Value,
                contacts = contact.Value,
                userType = 1,
                passwd = password1.Value,
            };



            if (client.Register(newUser) == 1)
            {
                Response.Redirect("Home.aspx");

            }
            else if (client.Register(newUser) == 0)
            {
                //The User Exists
                //You did not save changes in the backend
                Response.Redirect("AlreadyRegistered.aspx");
            }

            firstname.Value = "";
            lastname.Value = "";
            email.Value = "";
            contact.Value = "";
            password1.Value = "";


        }
    }
}