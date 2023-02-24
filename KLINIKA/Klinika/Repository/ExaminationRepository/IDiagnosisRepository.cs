using Model.ExaminationModel;
using System;
using System.Collections.Generic;

namespace Repository.ExaminationRepository
{
    public interface IDiagnosisRepository
    {
        List<Diagnosis> GetDiagnosisBySympthoms(Symptom symptom);
        Diagnosis AddDiagnosis(Diagnosis diagnosis);
        Boolean Delete(Diagnosis diagnosis);
    }
}