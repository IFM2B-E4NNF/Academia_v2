using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Academia_IFM02B2_Project_Website.ACD_Reference;


namespace Academia_IFM02B2_Project_Website
{
    public partial class BecomeTutor : System.Web.UI.Page
    {
        ACD_ServiceClient client = new ACD_ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_RegTutor(object sender, EventArgs e)
        {



            string theQualification = "";

            switch (qualifications.SelectedIndex)
            {
                case 0:
                    theQualification = "University";
                    break;
                case 1:
                    theQualification = "Collage";
                    break;
                case 2:
                    theQualification = "High School";
                    break;

            }

            string filename = "";
            if (FileUpload1.HasFile)
            {
                try
                {
                    filename = System.IO.Path.GetFileName(FileUpload1.FileName);
                    string fullPath = Server.MapPath("assets\\img\\tutors\\") + filename;
                    FileUpload1.SaveAs(fullPath);

                    message.InnerText = filename + " uploaded!";
                }
                catch (Exception ex)
                {
                    message.InnerText = filename + " could not be uploaded. The following error occured: " + ex.Message;
                }
            }

            MyTutor newTutor = new MyTutor
            {
                firstname = firstname.Value,
                lastname = lastname.Value,
                email = email.Value,
                aboutMe = aboutme.Value,
                image = "assets\\img\\tutors\\" + filename,
                qualification = theQualification,
                city = city.Value,
                province = state.Value,
                postalCode = postal_code.Value,
            };



            int tutorExist = client.AddTutor(newTutor);
            Tutor tutor = client.getTutor(tutorExist);

            if (tutorExist == 1)
            {
                //message.InnerText = "Successfully updated";
                Session["TutorID"] = tutor.TutorsId;
                Response.Redirect("ApplyTutor.aspx");
            }
            else if (tutorExist == -1)
            {
                message.InnerText = "Something went wrong";
            }
            else if (tutorExist == 0)
            {
                message.InnerText = "The Tutor already Exists";
            }



            firstname.Value = "";
            lastname.Value = "";
            email.Value = "";
            city.Value = "";
            state.Value = "";
            postal_code.Value = "";

        }
    }
}