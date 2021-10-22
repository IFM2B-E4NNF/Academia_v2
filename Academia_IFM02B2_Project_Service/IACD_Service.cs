using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Academia_IFM02B2_Project_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IACD_Service" in both code and config file together.
    [ServiceContract]
    public interface IACD_Service
    {
        [OperationContract]
        int Login(string email, string password);
        [OperationContract]
        int Register(MyUser user);
        [OperationContract]
        User getUser(int Id);

        [OperationContract]
        Tutor getTutor(int id);
        [OperationContract]
        List<Tutor> getAllTutors();

        [OperationContract]
        int AddTutor(MyTutor tutor);

        [OperationContract]
        List<User> getAllUsers();

        [OperationContract]
        int UpdateUser(MyUser user);

        [OperationContract]
        int UpdateTutor(MyTutor tutor);

        [OperationContract]
        List<ContactUSs> getAllContactUs();

        [OperationContract]
        Subject getSubject(int tutId);

        [OperationContract]
        List<Subject> getAllSubjects();

        [OperationContract]
        int AddSubject(MySubject subject);

        [OperationContract]
        Package getPackage(int id);

        [OperationContract]
        List<Package> getAllPackages();

        [OperationContract]
        int AddContactUs(MyContact contact);
    }
}
