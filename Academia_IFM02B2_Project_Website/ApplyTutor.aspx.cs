using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Academia_IFM02B2_Project_Website.ACD_Reference;

namespace Academia_IFM02B2_Project_Website
{
    public partial class ApplyTutor : System.Web.UI.Page
    {
        ACD_ServiceClient client = new ACD_ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_ApplyTutor(object sender, EventArgs e)
        {

            string subjectCategory = "";

            switch (category.SelectedIndex)
            {
                case 0:
                    subjectCategory = "Business";
                    break;
                case 1:
                    subjectCategory = "Humanities";
                    break;
                case 2:
                    subjectCategory = "Mathematics";
                    break;
                case 3:
                    subjectCategory = "Programming";
                    break;
                case 4:
                    subjectCategory = "Science";
                    break;
                case 5:
                    subjectCategory = "Engineering";
                    break;
                case 6:
                    subjectCategory = "Computer Science";
                    break;
                case 7:
                    subjectCategory = "Law";
                    break;
                case 8:
                    subjectCategory = "Foreign Languages";
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


            int ID = Convert.ToInt32(Session["TutorID"]);
            Tutor info = client.getTutor(ID);
            MySubject mySubject = new MySubject
            {
                name = name.Value,
                category = subjectCategory,
                description = description.Value,
                image = "assets\\img\\subjects\\" + filename,
                price = Convert.ToDecimal(price.Value),
                tutorId = info.TutorsId
            };



            int tutorExist = client.AddSubject(mySubject);

            if (tutorExist == 1)
            {
                //message.InnerText = "Successfully updated";
                Response.Redirect("Tutors.aspx");
            }
            else if (tutorExist == -1)
            {
                message.InnerText = "Something went wrong";
            }



            name.Value = "";
            description.Value = "";
            price.Value = "";



        }
    }
}