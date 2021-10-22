using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Academia_IFM02B2_Project_Website.ACD_Reference;

namespace Academia_IFM02B2_Project_Website
{
    public partial class Packages : System.Web.UI.Page
    {
        ACD_ServiceClient client = new ACD_ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            string display = "";
            dynamic packagesList = client.getAllPackages();
            
            foreach (Package p in packagesList)
            {
                display += " <div class='col-lg-3 col-md-6 mt-4 mt-md-0'>";
                display += " <div class='box featured'>";
                display += $" <h3>{p.Type}</h3>";
                display += $" <h4><sup>R</sup>{Math.Round((double)p.Price, 2)}<span> / {p.Time}</span></h4>";
                display += " <ul>";
                display += $" <li>{p.Description}</li>";
                //display += " <li>Nec feugiat nisl</li>";
                //display += " <li>Nulla at volutpat dola</li>";
                //display += " <li>Pharetra massa</li>";
                //display += " <li class='na'>Massa ultricies mi</li>";
                display += " </ul>";
                display += " <div class='btn-wrap'>";
                display += " <a href = '#' class='btn-buy'>Buy Now</a>";
                display += " </div>";
                display += " </div>";
                display += " </div>";

            }
            packages.InnerHtml = display;


        }
    }
}