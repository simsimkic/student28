using Model.ExaminationModel;
using System;
using Model.UserModel;

namespace Controller.ExaminationController
{
    public class SymptomDecorator : ISymptomController
    {
        private ISymptomController iSymptomController { get; set; }
        private User user { get; set; }

        public SymptomDecorator(ISymptomController iSymptomController, User user)
        {
            this.iSymptomController = iSymptomController;
            this.user = user;
        }

        public Symptom AddSymptom(Symptom symptom)
        {
            return iSymptomController.AddSymptom(symptom);
        }
    }
}