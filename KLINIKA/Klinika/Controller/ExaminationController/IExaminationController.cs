using Model.ExaminationModel;
using Model.UserModel;
using Model.WorkTimeModel;
using System;
using System.Collections.Generic;

namespace Controller.ExaminationController
{
    public interface IExaminationController : IController
    {
        Examination GetExaminationByPatient(Patient patient);
        Examination GetExaminationByDoctor(Doctor doctor);
        List<Examination> GetPatientExaminationsByDate(Patient patient, DateTime startDate, DateTime endDate);
        Boolean ApproveExamination(Examination examination);
        Examination GetExaminationById(int examinationId);
        ExaminationType GetExaminationTypeById(int examinationId);
        Examination GetExaminationByAppointment(Appointment appointment);
        List<Doctor> GetDoctorsByExaminationType(ExaminationType examinationType);
        List<Examination> GetPreviousPatientExaminations(Patient patient);
        Examination ChangeExaminationAppointment(Examination examination, Appointment appointment);
    }
}