using Model.ExaminationModel;
using System;
using System.Collections.Generic;

namespace Controller.ExaminationController
{
    public interface IDiagnosisController
    {
        List<Diagnosis> GetDiagnosisBySympthoms(Symptom symptom);
        Diagnosis Add(Diagnosis diagnosis);
        bool Delete(Diagnosis diagnosis);


    }
}