using Model.ExaminationModel;
using Repository.ExaminationRepository;
using System;

namespace Service.ExaminationService
{
    public class SymptomService : ISymptomService
    {
        private static SymptomService instance { get; set; }
        private SymptomRepository symptomRepository { get; set; }

        public static SymptomService GetInstance(SymptomRepository symptomRepository)
        {
            if (instance == null)
            {
                instance = new SymptomService(symptomRepository);
            }
            return instance;
        }

        private SymptomService(SymptomRepository symptomRepository)
        {
            this.symptomRepository = symptomRepository;
        }

        public Symptom AddSymptom(Symptom symptom)
        {
            return symptomRepository.AddSymptom(symptom);
        }
    }
}