using Model.ExaminationModel;
using System;
using Service.ExaminationService;
using System.Collections.Generic;

namespace Controller.ExaminationController
{
    public class DiagnosisController : IDiagnosisController
    {
        private static DiagnosisController instance { get; set; }
        private DiagnosisService diagnosisService { get; set; }

        public static DiagnosisController GetInstance(DiagnosisService diagnosisService)
        {
            if (instance == null)
            {
                instance = new DiagnosisController(diagnosisService);
            }
            return instance;
        }

        private DiagnosisController(DiagnosisService diagnosisService)
        {
            this.diagnosisService = diagnosisService;
        }

        public List<Diagnosis> GetDiagnosisBySympthoms(Symptom symptom)
        {
            return diagnosisService.GetDiagnosisBySympthoms(symptom);
        }

        public Diagnosis Add(Diagnosis diagnosis)
        {
            return diagnosisService.Add(diagnosis);
        }

        public bool Delete(Diagnosis diagnosis)
        {
            return diagnosisService.Delete(diagnosis);
        }
    }
}