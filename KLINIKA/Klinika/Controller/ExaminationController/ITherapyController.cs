using Model.ExaminationModel;
using System;

namespace Controller.ExaminationController
{
    public interface ITherapyController
    {
        Therapy AddTherapy(Therapy therapy);
    }
}