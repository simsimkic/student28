using Model.ExaminationModel;
using System;
using System.Collections.Generic;

namespace Service.ExaminationService
{
    public interface IDiagnosisService
    {
        List<Diagnosis> GetDiagnosisBySympthoms(Symptom symptom);
        Diagnosis Add(Diagnosis diagnosis);
        bool Delete(Diagnosis diagnosis);
    }
}