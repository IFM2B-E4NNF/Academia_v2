using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Academia_IFM02B2_Project_Website.ACD_Reference;

namespace Academia_IFM02B2_Project_Website
{
    public partial class UserAdmin : System.Web.UI.Page
    {
        ACD_ServiceClient client = new ACD_ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayUsers();
            DisplayTutors();

        }

        private void DisplayUsers()
        {
            string displayUsers = "";



            dynamic clientUsers = client.getAllUsers();

            string userType = "";

            foreach (User u in clientUsers)
            {

                if (u.UserType == 0)
                {
                    userType = "Client";
                }
                else
                {
                    userType = "Admin";
                }
                displayUsers += "<tbody>";
                displayUsers += "<tr>";
                displayUsers += $"<td>{u.UserId}</td>";
                displayUsers += $"<td>{u.Firstname}</td>";
                displayUsers += $"<td>{u.Lastname}</td>";
                displayUsers += $"<td>{u.Email}</td>";
                displayUsers += $"<td>{u.PhoneNumber}</td>";
                displayUsers += $"<td>{userType}</td>";
                displayUsers += "</tr>";
                displayUsers += "</tbody>";
            }
            user_table.InnerHtml = displayUsers;
        }

        private void DisplayTutors()
        {
            string displayTutors = "";


            dynamic clientTutors = client.getAllTutors();
            foreach (Tutor u in clientTutors)
            {
                displayTutors += "<tbody>";
                displayTutors += "<tr>";
                displayTutors += $"<td>{u.TutorsId}</td>";
                displayTutors += $"<td>{u.Firstname}</td>";
                displayTutors += $"<td>{u.Lastname}</td>";
                displayTutors += $"<td>{u.Email}</td>";
                displayTutors += $"<td>{u.AboutMe}</td>";
                displayTutors += $"<td>{u.Qualification}</td>";
                displayTutors += $"<td>{u.City}</td>";
                displayTutors += $"<td>{u.Province}</td>";
                displayTutors += $"<td>{u.PostalCode}</td>";
                displayTutors += "</tr>";
                displayTutors += "</tbody>";
            }
            tutor_table.InnerHtml = displayTutors;

        }
    }
}