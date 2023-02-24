using Model.ExaminationModel;
using System;

namespace Repository.ExaminationRepository
{
    public interface IHospitalizationRepository
    {
        Hospitalization AddHospitalization(Hospitalization hospitalization);
    }
}