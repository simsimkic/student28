using Model.ExaminationModel;
using Model.UserModel;
using Model.WorkTimeModel;
using System;
using System.Collections.Generic;

namespace Controller.UserController
{
    public class DoctorDecorator : IDoctorController
    {
        private IDoctorController iDoctorController { get; set; }
        private User user { get; set; }

        public DoctorDecorator(IDoctorController iDoctorController, User user)
        {
            this.iDoctorController = iDoctorController;
            this.user = user;
        }
        
        public bool ChangePassword(User user)
        {
            return iDoctorController.ChangePassword(user);
        }

        public User EditUser(User user)
        {
            return iDoctorController.EditUser(user);
        }

        public bool DeleteDoctor(Doctor doctor)
        {
            return iDoctorController.DeleteDoctor(doctor);
        }

        public List<Doctor> GetAllDoctors()
        {
            return iDoctorController.GetAllDoctors();
        }

        public List<Doctor> GetAvailableDoctors()
        {
            return iDoctorController.GetAvailableDoctors();
        }

        public List<Doctor> GetAvailableSpecializedDoctors(String specialization)
        {
            return iDoctorController.GetAvailableSpecializedDoctors(specialization);
        }

        public Doctor GetDoctorById(int employeeId)
        {
            return iDoctorController.GetDoctorById(employeeId);
        }

        public List<Doctor> GetDoctorsByDepartment(string specialization)
        {
            return iDoctorController.GetDoctorsByDepartment(specialization);
        }

        public double AverageDoctorGrade(int empId)
        {
            return iDoctorController.AverageDoctorGrade(empId);
        }
        public void GradeDoctor(int grade, int empId)
        {
            iDoctorController.GradeDoctor(grade, empId);
        }

        public User LogIn(string username, string password)
        {
            return iDoctorController.LogIn(username, password);
        }

        public bool LogOut()
        {
            return iDoctorController.LogOut();
        }

        public Doctor RegisterDoctor(Doctor doctor)
        {
                return iDoctorController.RegisterDoctor(doctor);
        }

        public List<WorkTime> GetWorkTimesByDoctor(DateTime startDate, DateTime endDate, Doctor doctor)
        {
            return iDoctorController.GetWorkTimesByDoctor(startDate, endDate, doctor);
        }

        public int GetNumberOfReservedAppointmentsInWorkTime(WorkTime workTime)
        {
            return iDoctorController.GetNumberOfReservedAppointmentsInWorkTime(workTime);
        }
    }
}