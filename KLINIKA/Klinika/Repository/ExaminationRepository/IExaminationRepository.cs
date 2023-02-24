using Model.ExaminationModel;
using Model.UserModel;
using Model.WorkTimeModel;
using System;
using System.Collections.Generic;

namespace Repository.ExaminationRepository
{
    public interface IExaminationRepository : IRepository
    {
        Examination GetExaminationByAppointment(Appointment appointment);
        Examination GetExaminationByPatient(Patient patient);
        Examination GetExaminationByDoctor(Doctor doctor);
        Examination GetExaminationById(int examinationId);
        List<Examination> GetPatientExaminationsByDate(Patient patient, DateTime startDate, DateTime endDate);
        List<Doctor> GetDoctorsByExaminationType(ExaminationType examinationType);
        ExaminationType GetExaminationTypeById(int examinationId);
        List<Examination> GetPreviousPatientExaminations(Patient patient);
    }
}