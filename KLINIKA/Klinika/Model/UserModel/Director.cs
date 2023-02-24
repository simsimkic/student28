using Model.RoomModel;
using System;

namespace Model.UserModel
{
    public class Director : Employee
    {
        public Room room { get; set; }

        public Director(Room room, int employeeId, Adress adress, Feedback feedback, String name, String surname, int personalId, DateTime dateOfBirth, Gender gender, MartialStatus martialStatus, String username, String password, String email, int phoneNumber, Boolean appGraded, Boolean userLogged) : base(employeeId, adress, feedback, name, surname, personalId, dateOfBirth, gender, martialStatus, username, password, email, phoneNumber, appGraded, userLogged)
        {
            this.room = room;
        }

    }
}