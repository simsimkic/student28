using Model.ExaminationModel;
using Repository.ExaminationRepository;
using System;
using System.Collections.Generic;

namespace Service.ExaminationService
{
    public class DiagnosisService : IDiagnosisService
    {
        private static DiagnosisService instance { get; set; }
        private DiagnosisRepository diagnosisRepository { get; set; }

        public static DiagnosisService GetInstance(DiagnosisRepository diagnosisRepository)
        {
            if (instance == null)
            {
                instance = new DiagnosisService(diagnosisRepository);
            }
            return instance;
        }

        private DiagnosisService(DiagnosisRepository diagnosisRepository)
        {
            this.diagnosisRepository = diagnosisRepository;
        }

        public List<Diagnosis> GetDiagnosisBySympthoms(Symptom symptom)
        {
            return diagnosisRepository.GetDiagnosisBySympthoms(symptom);
        }

        public Diagnosis Add(Diagnosis diagnosis)
        {
            return diagnosisRepository.AddDiagnosis(diagnosis);
        }

        public bool Delete(Diagnosis diagnosis)
        {
            return diagnosisRepository.Delete(diagnosis);
        }
    }
}