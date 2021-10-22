using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Academia_IFM02B2_Project_Website.ACD_Reference;

namespace Academia_IFM02B2_Project_Website
{
    public partial class TutorUpdate : System.Web.UI.Page
    {
        ACD_ServiceClient client = new ACD_ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_UpdateUser(object sender, EventArgs e)
        {
            //UpdateTutor();

        }

        private void UpdateTutor()
        {
          

            MyTutor myTutor = new MyTutor
            {
                Id = Convert.ToInt32(tutor_id.Value),
                firstname = firstname.Value,
                lastname = lastname.Value,
                email = email.Value,
                aboutMe = aboutme.Value,
                qualification = qualification.Value,
                city = city.Value,
                province = province.Value,
                postalCode = postal.Value
            };

            int updateTutor = client.UpdateTutor(myTutor);

            if (updateTutor == 1)
            {
                results.Text = firstname.Value + " has successfully update";
            }
            else if (updateTutor == 0)
            {
                results.Text = tutor_id.Value + " Id does not exists";
            }
            else
            {
                results.Text = "Something went wrong";
            }
        }
    
    }
}