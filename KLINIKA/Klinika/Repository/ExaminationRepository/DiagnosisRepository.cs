using Klinika.Repository;
using Model.ExaminationModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.ExaminationRepository
{
    public class DiagnosisRepository : IDiagnosisRepository
    {
        private static DiagnosisRepository instance { get; set; }
        private FileRepository<Diagnosis> stream { get; set; }

        public static DiagnosisRepository GetInstance(FileRepository<Diagnosis> stream)
        {
            if (instance == null)
            {
                instance = new DiagnosisRepository(stream);
            }
            return instance;
        }

        private DiagnosisRepository(FileRepository<Diagnosis> stream)
        {
            this.stream = stream;
        }

        public List<Diagnosis> GetDiagnosisBySympthoms(Symptom symptom)
        {
            List<Diagnosis> diagnosesWithSymptom = new List<Diagnosis>();
            foreach(Diagnosis diagnosis in stream.GetAll().ToList())
            {
                if(diagnosis.symptoms.Contains(symptom))
                {
                    diagnosesWithSymptom.Add(diagnosis);
                }
            }
            return diagnosesWithSymptom;
        }

        public Diagnosis AddDiagnosis(Diagnosis diagnosis)
        {
            var allDiagnoses = stream.GetAll().ToList();
            allDiagnoses.Add(diagnosis);
            stream.SaveAll(allDiagnoses);
            return diagnosis;
        }

        public bool Delete(Diagnosis diagnosis)
        {
            var allDiagnoses = stream.GetAll().ToList();
            if (allDiagnoses.Remove(diagnosis))
            {
                stream.SaveAll(allDiagnoses);
                return true;
            }
            return false;
        }
    }
}