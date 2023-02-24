using Klinika.Repository;
using Model.ExaminationModel;
using System;
using System.Linq;

namespace Repository.ExaminationRepository
{
    public class SymptomRepository : ISymptomRepository
    {
        private static SymptomRepository instance { get; set; }
        private FileRepository<Symptom> stream { get; set; }

        public static SymptomRepository GetInstance(FileRepository<Symptom> stream)
        {
            if (instance == null)
            {
                instance = new SymptomRepository(stream);
            }
            return instance;
        }

        private SymptomRepository(FileRepository<Symptom> stream)
        {
            this.stream = stream;
        }

        public Symptom AddSymptom(Symptom symptom)
        {
            var allSymptoms = stream.GetAll().ToList();
            allSymptoms.Add(symptom);
            stream.SaveAll(allSymptoms);
            return symptom;
        }
    }
}