using System;

namespace Model.UserModel
{
    public class GuestUser
    {
        public String name { get; set; }
        public String surname { get; set; }
        public DateTime dateOfBirth { get; set; }
        public int personalId { get; set; }
        public Boolean appointmentDone { get; set; }
        public GuestUserMedicalRecord guestUserMedicalRecord { get; set; }

        public GuestUser(string name, string surname, DateTime dateOfBirth, int personalId, bool appointmentDone, GuestUserMedicalRecord guestUserMedicalRecord)
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.personalId = personalId;
            this.appointmentDone = appointmentDone;
            this.guestUserMedicalRecord = guestUserMedicalRecord;
        }
    }
}