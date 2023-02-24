using Model.ExaminationModel;
using Model.UserModel;
using System;

namespace Controller.UserController
{
    public class MedicalRecordDecorator : IMedicalRecordController
    {
        private IMedicalRecordController iMedicalRecordController { get; set; }
        private User user { get; set; }

        public MedicalRecordDecorator(IMedicalRecordController iMedicalRecordController, User user)
        {
            this.iMedicalRecordController = iMedicalRecordController;
            this.user = user;
        }

        public object Add(object obj)
        {
            return iMedicalRecordController.Add(obj);
        }

        public object Delete(object obj)
        {
            return iMedicalRecordController.Delete(obj);
        }

        public object Edit(object obj)
        {
            return iMedicalRecordController.Edit(obj);
        }

        public MedicalRecord GetMedicalRecordByPatient(Patient patient)
        {
            return iMedicalRecordController.GetMedicalRecordByPatient(patient);
        }

        public Examination AddExaminationToMedicalRecord(Examination examination, MedicalRecord medicalRecord)
        {
            return iMedicalRecordController.AddExaminationToMedicalRecord(examination, medicalRecord);
        }
    }
}