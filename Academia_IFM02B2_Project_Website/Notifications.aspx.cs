using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Academia_IFM02B2_Project_Website.ACD_Reference;

namespace Academia_IFM02B2_Project_Website
{
    public partial class Notifications : System.Web.UI.Page
    {
        ACD_ServiceClient client = new ACD_ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            dynamic contactUs = client.getAllContactUs();
            string display = "";
            foreach (ContactUSs us in contactUs)
            {

                display += "<div class='card-body'>";
                display += "<div class='row'>";
                display += "<div class='col-md-8'>";
                display += $"<h4 class='card-title'>{us.Firstname}</h4>";
                display += " <div class='alert alert-info'>";
                display += $"<span>{us.Message}</span>";
                display += " </div>";
                display += " </div>";
                display += " </div>";
                display += " </div>";

            }
            

            notification.InnerHtml = display;

        }
    }
}