using Model.ExaminationModel;
using Model.UserModel;
using System;
using System.Collections.Generic;

namespace Repository.UserRepository
{
    public interface IMedicalRecordRepository : IRepository
    {
        MedicalRecord GetMedicalRecordByPatient(Patient patient);
        Examination AddExaminationToMedicalRecord(Examination examination, MedicalRecord medicalRecord);
    }
}