using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Academia_IFM02B2_Project_Website.ACD_Reference;


namespace Academia_IFM02B2_Project_Website
{
    public partial class Tutors : System.Web.UI.Page
    {
        ACD_ServiceClient client = new ACD_ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayTutors();
        }

        private void DisplayTutors()
        {
            string display = "";

            dynamic allTutors = client.getAllTutors();

            foreach (Tutor t in allTutors)
            {
                //assets/img/tutors/trainer-1.jpg
                display += " <div class='col-lg-4 col-md-6 d-flex align-items-stretch'>";
            display += " <div class='member'>";
            display += $" <img src = '{t.Image}' class='img-fluid' alt=''>";
            display += " <div class='member-content'>";
            display += $" <h4>{t.Firstname} {t.Lastname}</h4>";
            display += "<span>Web Development</span>";
            display += "<p>";
            display += $"{t.AboutMe}";
            display += "</p>";
            display += " </div>";
            display += " </div>";
            display += " </div>";

            }


            display_tutors.InnerHtml = display;

        }
    }
}