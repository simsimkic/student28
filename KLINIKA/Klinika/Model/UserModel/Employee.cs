using System;

namespace Model.UserModel
{
    public class Employee : User
    {
        public int employeeId { get; set; }

        public Employee(int employeeId, Adress adress, Feedback feedback, String name, String surname, int personalId, DateTime dateOfBirth, Gender gender, MartialStatus martialStatus, String username, String password, String email, int phoneNumber, Boolean appGraded, Boolean userLogged) : base(adress, feedback, name, surname, personalId, dateOfBirth, gender, martialStatus, username, password, email, phoneNumber, appGraded, userLogged)
        {
            this.employeeId = employeeId;
        }
    }
}