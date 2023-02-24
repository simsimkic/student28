using Model.ExaminationModel;
using Model.RoomModel;
using System;
using System.Collections.Generic;

namespace Controller.ExaminationController
{
    public interface IHospitalizationController
    {
        Hospitalization AddHospitalization(Hospitalization hospitalization);
    }
}