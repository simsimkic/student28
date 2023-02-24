using System;

namespace Model.UserModel
{
    public class Patient : User
    {
        public MedicalRecord medicalRecord { get; set; }
        public GuestUser guestUser { get; set; }
        public GuestUserMedicalRecord guestUserMedicalRecord { get; set; }

        public Patient(MedicalRecord medicalRecord, GuestUser guestUser,GuestUserMedicalRecord guestUserMedicalRecord, Adress adress, Feedback feedback, string name, string surname, int personalId, DateTime dateOfBirth, Gender gender, MartialStatus martialStatus, string username, string password, string email, int phoneNumber, bool appGraded, bool userLogged) : base(adress, feedback, name, surname, personalId, dateOfBirth, gender, martialStatus, username, password, email, phoneNumber, appGraded, userLogged)
        {
            this.medicalRecord = medicalRecord;
            this.guestUser = guestUser;
            this.guestUserMedicalRecord = guestUserMedicalRecord;
        }
        
       /* public Patient(GuestUser guestUser, GuestUserMedicalRecord guestUserMedicalRecord, Adress adress, Feedback feedback, string name, string surname, int personalId, DateTime dateOfBirth, Gender gender, MartialStatus martialStatus, string username, string password, string email, int phoneNumber, bool appGraded, bool userLogged)  : base(adress, feedback, name, surname, personalId, dateOfBirth, gender, martialStatus, username, password, email, phoneNumber, appGraded, userLogged)
        {
            this.guestUser = guestUser;
            this.guestUserMedicalRecord = guestUserMedicalRecord;
        }*/
    }
}