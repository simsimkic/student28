using Model.WorkTimeModel;
using System;
using System.Collections.Generic;

namespace Model.UserModel
{
    public class Doctor : Employee
    {
        public List<WorkTime> workTime { get; set; }
        public List<DoctorGrade> doctorGrades { get; set; }
        public DaysOff daysOff { get; set; }
        public OnDuty onDuty { get; set; }
        public String specialization { get; set; }
        public bool available { get; set; }

        public Doctor(List<WorkTime> workTime, List<DoctorGrade> doctorGrades, DaysOff daysOff, OnDuty onDuty, String specialization, bool available, int employeeId, Adress adress, Feedback feedback, String name, String surname, int personalId, DateTime dateOfBirth, Gender gender, MartialStatus martialStatus, String username, String password, String email, int phoneNumber, Boolean appGraded, Boolean userLogged) : base(employeeId, adress, feedback, name, surname, personalId, dateOfBirth, gender, martialStatus, username, password, email, phoneNumber, appGraded, userLogged)
        {
            this.workTime = workTime;
            this.doctorGrades = doctorGrades;
            this.daysOff = daysOff;
            this.onDuty = onDuty;
            this.specialization = specialization;
            this.available = available;
        }
    }
}