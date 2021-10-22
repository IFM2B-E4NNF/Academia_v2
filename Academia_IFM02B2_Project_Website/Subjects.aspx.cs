using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Academia_IFM02B2_Project_Website.ACD_Reference;

namespace Academia_IFM02B2_Project_Website
{
    public partial class Subjects : System.Web.UI.Page
    {
        ACD_ServiceClient client = new ACD_ServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            DisplaySubjects();
        }

        private void DisplaySubjects()
        {

            string display = "";
            dynamic subjectList = client.getAllSubjects();


            foreach (Subject s in subjectList)
            {
                display += " <div class='col-lg-4 col-md-6 d-flex align-items-stretch'>";
                display += " <div class='course-item'>";
                display += $"<img src = '{s.Image}' class='img-fluid' alt='...'>";
                display += " <div class='course-content'>";
                display += " <div class='d-flex justify-content-between align-items-center mb-3'>";
                display += $"<h4>{s.Name}</h4>";
                display += $"<p class='price'>R{Math.Round(s.Price, 2)}</p>";
                display += " </div>";
                display += $"<h3><a href = 'course-details.html' >{s.Name}</a></h3>";
                display += $"<p>{s.Category}</p>";
                display += " <div class='trainer d-flex justify-content-between align-items-center'>";
                display += " <div class='trainer-profile d-flex align-items-center'>";
                display += $"<img src = '{s.Image}' class='img-fluid' alt=''>";
                display += "<span>Antonio</span>";
                display += " </div>";
                display += " <div class='trainer-rank d-flex align-items-center'>";
                display += "<i class='bx bx-user'></i>&nbsp;50";
                display += " &nbsp;&nbsp;";
                display += "<i class='bx bx-heart'></i>&nbsp;65";
                display += " </div>";
                display += " </div>";
                display += " </div>";
                display += " </div>";
                display += " </div>";

            }




            subjects.InnerHtml = display;

        }
    }
}