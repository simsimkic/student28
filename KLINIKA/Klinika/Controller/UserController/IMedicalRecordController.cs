using System;
using Model.ExaminationModel;
using Model.UserModel;

namespace Controller.UserController
{
    public interface IMedicalRecordController : IController
    {
        MedicalRecord GetMedicalRecordByPatient(Patient patient);
        Examination AddExaminationToMedicalRecord(Examination examination, MedicalRecord medicalRecord);
    }
}