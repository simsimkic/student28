using System;
using System.Collections.Generic;
using Model.WorkTimeModel;

namespace Model.UserModel
{
    public class Secretary : Employee
    {
        public DaysOff daysOff { get; set; }
        public List<WorkTime> workTime { get; set; }

        public Secretary(DaysOff daysOff, List<WorkTime> workTime, int employeeId, Adress adress, Feedback feedback, string name, string surname, int personalId, DateTime dateOfBirth, Gender gender, MartialStatus martialStatus, string username, string password, string email, int phoneNumber, bool appGraded, bool userLogged) : base(employeeId, adress, feedback, name, surname, personalId, dateOfBirth, gender, martialStatus, username, password, email, phoneNumber, appGraded, userLogged)
        {
            this.daysOff = daysOff;
            this.workTime = workTime;
        }
    }
}