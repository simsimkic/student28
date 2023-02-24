using Model.ExaminationModel;
using System;

namespace Controller.ExaminationController
{
    public interface ISymptomController
    {
        Symptom AddSymptom(Symptom symptom);
    }
}