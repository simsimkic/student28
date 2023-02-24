using Model.ExaminationModel;
using Model.UserModel;
using Model.WorkTimeModel;
using Service.UserService;
using System;
using System.Collections.Generic;

namespace Controller.UserController
{
    public class DoctorController : IDoctorController
    {
        private static DoctorController instance { get; set; }
        private DoctorService doctorService { get; set; }

        public static DoctorController GetInstance(DoctorService doctorService)
        {
            if (instance == null) {
                
                instance = new DoctorController(doctorService);
            }
            return instance;
        }

        private DoctorController(DoctorService doctorService)
        {
            this.doctorService = doctorService;
        }

        public List<Doctor> GetAllDoctors()
        {
            return doctorService.GetAllDoctors();
        }

        public List<Doctor> GetAvailableDoctors()
        {
            return doctorService.GetAvailableDoctors();
        }

        public Doctor GetDoctorById(int employeeId)
        {
            return doctorService.GetDoctorById(employeeId);
        }

        public List<Doctor> GetAvailableSpecializedDoctors(String specialization)
        {
            return doctorService.GetAvailableSpecializedDoctors(specialization);
        }

        public Doctor RegisterDoctor(Doctor doctor)
        {
            return doctorService.RegisterDoctor(doctor);
        }

        public List<Doctor> GetDoctorsByDepartment(string specialization)
        {
            return doctorService.GetDoctorsByDepartment(specialization);
        }

        public double AverageDoctorGrade(int empId)
        {
            return doctorService.AverageDoctorGrade(empId);
        }
        public void GradeDoctor(int grade, int empId)
        {
            doctorService.GradeDoctor(grade, empId);
        }

        public User EditUser(User user)
        {
            return doctorService.EditUser(user);
        }

        public bool DeleteDoctor(Doctor doctor)
        {
            return doctorService.DeleteDoctor(doctor);
        }

        public bool ChangePassword(User user)
        {
            return doctorService.ChangePassword(user);
        }

        public User LogIn(string username, string password)
        {
            return doctorService.LogIn(username,password);
        }

        public bool LogOut()
        {
            return doctorService.LogOut();
        }

        public List<WorkTime> GetWorkTimesByDoctor(DateTime startDate, DateTime endDate, Doctor doctor)
        {
            return doctorService.GetWorkTimesByDoctor(startDate, endDate, doctor);
        }

        public int GetNumberOfReservedAppointmentsInWorkTime(WorkTime workTime)
        {
            return doctorService.GetNumberOfReservedAppointmentsInWorkTime(workTime);
        }
    }
}