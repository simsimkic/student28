using Model.ExaminationModel;
using System;

namespace Service.ExaminationService
{
    public interface ITherapyService
    {
        Therapy AddTherapy(Therapy therapy);
    }
}