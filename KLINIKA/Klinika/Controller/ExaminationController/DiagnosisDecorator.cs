using Model.ExaminationModel;
using System;
using Model.UserModel;
using System.Collections.Generic;

namespace Controller.ExaminationController
{
    public class DiagnosisDecorator : IDiagnosisController
    {
        private IDiagnosisController iDiagnosisController { get; set; }
        private User user { get; set; }

        public DiagnosisDecorator(IDiagnosisController iDiagnosisController, User user)
        {
            this.iDiagnosisController = iDiagnosisController;
            this.user = user;
        }

        public Diagnosis Add(Diagnosis diagnosis)
        {
            return iDiagnosisController.Add(diagnosis);
        }

        public bool Delete(Diagnosis diagnosis)
        {
            return iDiagnosisController.Delete(diagnosis);
        }

        public List<Diagnosis> GetDiagnosisBySympthoms(Symptom symptom)
        {
            return iDiagnosisController.GetDiagnosisBySympthoms(symptom);
        }
    }
}