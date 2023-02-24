using System;
using System.Collections.Generic;
using Model.ExaminationModel;
using Model.UserModel;
using Model.WorkTimeModel;

namespace Repository.UserRepository
{
    public interface IDoctorRepository : IRepository
    {
        List<Doctor> GetAvailableDoctors();
        Doctor GetDoctorById(int employeeId);
        List<Doctor> GetAvailableSpecializedDoctors(String specialization);
        List<Doctor> GetDoctorsByDepartment(String specialization);
        List<WorkTime> GetWorkTimesByDoctor(DateTime startDate, DateTime endDate, Doctor doctor);
        List<Doctor> GetAllDoctors();
    }
}