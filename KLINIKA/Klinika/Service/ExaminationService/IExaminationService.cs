using System;
using Model.ExaminationModel;
using Model.WorkTimeModel;
using Model.UserModel;
using System.Collections.Generic;

namespace Service.ExaminationService
{
    public interface IExaminationService : IService
    {
        Examination GetExaminationByAppointment(Appointment appointment);
        Examination GetExaminationByPatient(Patient patient);
        Examination GetExaminationByDoctor(Doctor doctor);
        List<Examination> GetPatientExaminationsByDate(Patient patient, DateTime startDate, DateTime endDate);
        Boolean ApproveExamination(Examination examination);
        Examination GetExaminationById(int examinationId);
        ExaminationType GetExaminationTypeById(int examinationId);
        List<Doctor> GetDoctorsByExaminationType(ExaminationType examinationType);
        List<Examination> GetPreviousPatientExaminations(Patient patient);
        Examination ChangeExaminationAppointment(Examination examination, Appointment appointment);
    }
}