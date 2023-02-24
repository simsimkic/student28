using Model.ExaminationModel;
using Model.RoomModel;
using System;
using System.Collections.Generic;

namespace Service.ExaminationService
{
    public interface IHospitalizationService
    {
        Hospitalization AddHospitalization(Hospitalization hospitalization);
    }
}