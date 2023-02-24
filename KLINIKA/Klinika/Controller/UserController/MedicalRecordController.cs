using Model.ExaminationModel;
using Model.UserModel;
using Service.UserService;
using System;

namespace Controller.UserController
{
    public class MedicalRecordController : IMedicalRecordController
    {
        private static MedicalRecordController instance { get; set; }
        private MedicalRecordService medicalRecordService { get; set; }

        public static MedicalRecordController GetInstance(MedicalRecordService medicalRecordService)
        {
            if (instance == null)
            {
                instance = new MedicalRecordController(medicalRecordService);
            }
            return instance;
        }

        private MedicalRecordController(MedicalRecordService medicalRecordService)
        {
            this.medicalRecordService = medicalRecordService;
        }

        public MedicalRecord GetMedicalRecordByPatient(Patient patient)
        {
            return medicalRecordService.GetMedicalRecordByPatient(patient);
        }

        public object Add(object obj)
        {
           return medicalRecordService.Add(obj);
        }

        public object Edit(object obj)
        {
            return medicalRecordService.Edit(obj);
        }

        public object Delete(object obj)
        {
            return medicalRecordService.Delete(obj);
        }

        public Examination AddExaminationToMedicalRecord(Examination examination, MedicalRecord medicalRecord)
        {
            return medicalRecordService.AddExaminationToMedicalRecord(examination, medicalRecord);
        }
    }
}