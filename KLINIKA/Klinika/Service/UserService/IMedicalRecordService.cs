using Model.ExaminationModel;
using Model.UserModel;
using System;
using System.Collections.Generic;

namespace Service.UserService
{
    public interface IMedicalRecordService : IService
    {
        Examination AddExaminationToMedicalRecord(Examination examination, MedicalRecord medicalRecord);
        MedicalRecord GetMedicalRecordByPatient(Patient patient);
        List<Examination> GetExaminationsByDate(DateTime startDate, DateTime endTime, MedicalRecord medicalRecord);
    }
}