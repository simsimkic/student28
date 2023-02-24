using Model.ExaminationModel;
using System;
using Service.ExaminationService;

namespace Controller.ExaminationController
{

    public class SymptomController : ISymptomController
    {
        private static SymptomController instance { get; set; }
        private SymptomService symptomService { get; set; }

        public static SymptomController GetInstance(SymptomService symptomService)
        {
            if (instance == null)
            {
                instance = new SymptomController(symptomService);
            }
            return instance;
        }

        private SymptomController(SymptomService symptomService)
        {
            this.symptomService = symptomService;
        }

        public Symptom AddSymptom(Symptom symptom)
        {
            return symptomService.AddSymptom(symptom);
        }
    }
}