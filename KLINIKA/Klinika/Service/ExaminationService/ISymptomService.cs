using Model.ExaminationModel;
using System;

namespace Service.ExaminationService
{
    public interface ISymptomService
    {
        Symptom AddSymptom(Symptom symptom);
    }
}