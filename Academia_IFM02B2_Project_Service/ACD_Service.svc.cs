using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Academia_IFM02B2_Project_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ACD_Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ACD_Service.svc or ACD_Service.svc.cs at the Solution Explorer and start debugging.
    public class ACD_Service : IACD_Service
    {
        AcademiaDataClassesDataContext db = new AcademiaDataClassesDataContext();
        public int Login(string email, string password)
        {
            var userExist = (from p in db.Users
                             where p.Email.Equals(email) &&
                             p.Password.Equals(password)
                             select p).FirstOrDefault();



            if (userExist == null)
            {
                return -1;
            }
            else
            {
                if (userExist.UserType == 1)
                {
                    return 1; //Client
                }
                else
                {
                    return 2;
                }
            }


        }



        private bool isRegistered(string email)
        {
            var exist = (from u in db.Users
                         where u.Email.Equals(email)
                         select u).FirstOrDefault();

            if (exist == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }




        public int Register(MyUser user)
        {
            if (!isRegistered(user.email))
            {
                var newUser = new User
                {
                    Firstname = user.firstname,
                    Lastname = user.lastname,
                    Email = user.email,
                    PhoneNumber = user.contacts,
                    RegDate = DateTime.Now.Date,
                    UserType = user.userType,
                    Password = user.passwd,
                };

                db.Users.InsertOnSubmit(newUser);

                try
                {
                    db.SubmitChanges();
                    return 1;
                }
                catch (Exception e)
                {
                    e.GetBaseException();
                    return -1;
                }
            }
            else
            {
                return 0;
            }

        }




        public User getUser(int Id)
        {
            var user = (from u in db.Users
                        where u.UserId.Equals(Id)
                        select u).FirstOrDefault();

            return user;
        }




        public bool isTutorExist(string email)
        {
            var checkTutor = (from t in db.Tutors
                              where t.Email.Equals(email)
                              select t).FirstOrDefault();

            if (checkTutor == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        public int AddTutor(MyTutor tutor)
        {
            if (!isTutorExist(tutor.email))
            {

                var newTutor = new Tutor
                {
                    //TutorsId = tutor.Id,
                    Firstname = tutor.firstname,
                    Lastname = tutor.lastname,
                    Email = tutor.email,
                    AboutMe = tutor.aboutMe,
                    Image = tutor.image,
                    Qualification = tutor.qualification,
                    City = tutor.city,
                    Province = tutor.province,
                    PostalCode = tutor.postalCode,
                    RegDate = DateTime.Now.Date,
                };


                db.Tutors.InsertOnSubmit(newTutor);

                try
                {
                    db.SubmitChanges();
                    return 1;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return -1;
                }
            }
            else
            {
                //The Tutor already Exists
                return 0;
            }
        }



        public int UpdateTutor(MyTutor tutor)
        {
            if (isTutorExist(tutor.email))
            {
                var editTutor = (from t in db.Tutors
                                 where t.Email.Equals(tutor.email)
                                 select t).FirstOrDefault();

                if (editTutor != null)
                {
                    editTutor.Firstname = tutor.firstname;
                    editTutor.Lastname = tutor.lastname;
                    editTutor.Email = tutor.email;
                    editTutor.AboutMe = tutor.aboutMe;
                    editTutor.Image = tutor.image;
                    editTutor.Qualification = tutor.qualification;
                    editTutor.City = tutor.city;
                    editTutor.Province = tutor.province;
                    editTutor.PostalCode = tutor.postalCode;
                    editTutor.RegDate = DateTime.Now.Date;

                }

                try
                {
                    db.SubmitChanges();
                    return 1;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return -1;
                }


            }
            else
            {
                //The Tutor do not exists
                return 0;
            }
        }

        public Tutor getTutor(int id)
        {
            var tutor = (from u in db.Tutors
                         where u.TutorsId.Equals(id)
                         select u).FirstOrDefault();


            if (tutor == null)
            {
                return null;
            }
            else
            {
                return tutor;
            }
        }

        public List<Tutor> getAllTutors()
        {
            List<Tutor> tutors = new List<Tutor>();

            dynamic tutor = (from t in db.Tutors
                             select t);


            foreach (Tutor tut in tutor)
            {
                tutors.Add(tut);
            }

            return tutors;
        }

        public List<User> getAllUsers()
        {
            List<User> usersList = new List<User>();

            dynamic users = (from u in db.Users
                             select u);

            foreach (User usr in users)
            {
                usersList.Add(usr);
            }

            return usersList;
        }

        private bool isUserIdExits(int id)
        {
            var getId = (from i in db.Users
                         where i.UserId.Equals(id)
                         select i).FirstOrDefault();

            if (getId == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isTutorIdExits(int id)
        {
            var getId = (from i in db.Tutors
                         where i.TutorsId.Equals(id)
                         select i).FirstOrDefault();

            if (getId == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public int UpdateUser(MyUser user)
        {

            if (isUserIdExits(user.id))
            {
                var updateUser = (from u in db.Users
                                  where u.UserId.Equals(user.id)
                                  select u).FirstOrDefault();


                updateUser.Firstname = user.firstname;
                updateUser.Lastname = user.lastname;
                updateUser.Email = user.email;
                updateUser.PhoneNumber = user.contacts;
                updateUser.RegDate = DateTime.Now.Date;
                updateUser.UserType = user.userType;
                updateUser.Password = user.passwd;

                try
                {
                    db.SubmitChanges();
                    return 1;

                }
                catch (Exception e)
                {
                    return -1;
                    e.GetBaseException();
                }



            }
            else
            {
                return 0; //The Id Does not exists
            }

        }


        public List<ContactUSs> getAllContactUs()
        {
            List<ContactUSs> contactsList = new List<ContactUSs>();

            dynamic contact = (from t in db.ContactUSses
                               select t);


            foreach (ContactUSs us in contact)
            {
                contactsList.Add(us);
            }

            return contactsList;

        }

        public Subject getSubject(int tutId)
        {
            var subject = (from s in db.Subjects
                           where s.TutorId.Equals(tutId)
                           select s).AsQueryable().FirstOrDefault();

            if (subject == null)
            {
                return null;
            }
            else
            {
                return subject;
            }
        }

        public List<Subject> getAllSubjects()
        {
            List<Subject> subjectList = new List<Subject>();

            dynamic subjects = (from s in db.Subjects
                                select s);


            foreach (Subject us in subjects)
            {
                subjectList.Add(us);
            }

            return subjectList;

        }

        public int AddSubject(MySubject subject)
        {

            var newSubject = new Subject
            {
                Name = subject.name,
                Category = subject.category,
                Description = subject.description,
                Price = subject.price,
                Image = subject.image,
                TutorId = subject.tutorId,

            };


            db.Subjects.InsertOnSubmit(newSubject);

            try
            {
                db.SubmitChanges();
                return 1; //Added to database
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return -1; //Failed
            }
        }

        public Package getPackage(int id)
        {
            var package = (from s in db.Packages
                           where s.Id.Equals(id)
                           select s).FirstOrDefault();

            if (package == null)
            {
                return null;
            }
            else
            {
                return package;
            }

        }

        public List<Package> getAllPackages()
        {
            List<Package> packagesList = new List<Package>();
            dynamic packages = (from s in db.Packages
                                select s);


            foreach (Package p in packages)
            {
                packagesList.Add(p);
            }

            return packagesList;
        }


        
        private string checkUser(string email)
        {
            var user = (from u in db.Users
                        where u.Email.Equals(email)
                        select u).FirstOrDefault();

           

            if(user.UserType == 0)
            {
                return "Not registered";
                
            }else
            {
                return "Client";
            }
        }

        public int AddContactUs(MyContact contact)
        {
            var newMsg = new ContactUSs
            {
                Firstname = contact.firstname,
                Email = contact.email,
                Subject = contact.subject,
                Message = contact.message,
                Registered = "Not registered" //checkUser(contact.email)
            };


            db.ContactUSses.InsertOnSubmit(newMsg);

            try
            {
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return -1;
            }
        }
    }
}
