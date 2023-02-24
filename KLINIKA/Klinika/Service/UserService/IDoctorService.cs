using System;
using Model.UserModel;
using Model.ExaminationModel;
using System.Collections.Generic;
using Model.WorkTimeModel;

namespace Service.UserService
{
    public interface IDoctorService : IUserService
    {
        List<Doctor> GetAllDoctors();
        List<Doctor> GetDoctorsByDepartment(String specialization);
        List<Doctor> GetAvailableDoctors();
        Doctor GetDoctorById(int employeeId);
        List<Doctor> GetAvailableSpecializedDoctors(String specialization);
        Doctor RegisterDoctor(Doctor doctor);
        Boolean DeleteDoctor(Doctor doctor);
        List<WorkTime> GetWorkTimesByDoctor(DateTime startDate, DateTime endDate, Doctor doctor);
        double AverageDoctorGrade(int empId);
        void GradeDoctor(int grade, int empId);
        int GetNumberOfReservedAppointmentsInWorkTime(WorkTime workTime);
    }
}