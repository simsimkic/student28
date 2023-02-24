using System;

namespace Model.UserModel
{
    public class User
    {
        public Adress adress { get; set; }
        public Feedback feedback { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public int personalId { get; set; }
        public DateTime dateOfBirth { get; set; }
        public Gender gender { get; set; }
        public MartialStatus martialStatus { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public String email { get; set; }
        public int phoneNumber { get; set; }
        public Boolean appGraded { get; set; }
        public Boolean userLogged { get; set; }

        public User(Adress adress, Feedback feedback, string name, string surname, int personalId, DateTime dateOfBirth, Gender gender, MartialStatus martialStatus, string username, string password, string email, int phoneNumber, bool appGraded, bool userLogged)
        {
            this.adress = adress;
            this.feedback = feedback;
            this.name = name;
            this.surname = surname;
            this.personalId = personalId;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.martialStatus = martialStatus;
            this.username = username;
            this.password = password;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.appGraded = appGraded;
            this.userLogged = userLogged;
        }
    }
}