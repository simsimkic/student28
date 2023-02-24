using System;
using System.Collections.Generic;
using Model.ExaminationModel;
using Model.UserModel;
using Model.WorkTimeModel;

namespace Controller.UserController
{
    public interface IDoctorController : IUserController
    {
        List<Doctor> GetAllDoctors();
        List<Doctor> GetAvailableDoctors();
        Doctor GetDoctorById(int employeeId);
        List<Doctor> GetAvailableSpecializedDoctors(String specialization);
        Doctor RegisterDoctor(Doctor doctor);
        bool DeleteDoctor(Doctor doctor);
        List<Doctor> GetDoctorsByDepartment(String specialization);
        List<WorkTime> GetWorkTimesByDoctor(DateTime startDate, DateTime endDate, Doctor doctor);
        double AverageDoctorGrade(int empId);
        void GradeDoctor(int grade, int empId);
        int GetNumberOfReservedAppointmentsInWorkTime(WorkTime workTime);
    }
}