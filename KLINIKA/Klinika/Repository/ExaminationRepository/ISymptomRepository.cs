using Model.ExaminationModel;
using System;

namespace Repository.ExaminationRepository
{
    public interface ISymptomRepository
    {
        Symptom AddSymptom(Symptom symptom);
    }
}